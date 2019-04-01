using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Zentropy.Model
{
    public static class Recognizer
    {
        #region Fields

        private const int SideLength = 8;
        private static Bitmap _lastBoardSnap;

        #endregion

        #region Properties

        public static bool BoardFound { get; private set; }
        public static int ScreenIndex { get; private set; } = -1;
        public static int MinimumSize { get; set; } = 32;
        public static Point BoardLocation { get; private set; }
        public static Size BoardSize { get; private set; }
        public static SizeF FieldSize { get; set; }

        #endregion

        #region Methods

        public static void UpdateBoardImage()
        {
            if (BoardFound)
            {
                _lastBoardSnap = GetBoardSnap();
            }
        }

        public static void UpdateBoardImage(Bitmap image)
        {
            if (BoardFound)
            {
                _lastBoardSnap = image;
            }
        }

        public static bool SearchBoard(Color lightSquareColor, Color darkSquareColor)
        {
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                if (SearchBoard(GetScreenshot(Screen.AllScreens[i]), darkSquareColor, lightSquareColor))
                {
                    if (BoardSize.Width < MinimumSize || BoardSize.Height < MinimumSize)
                    {
                        return false;
                    }

                    BoardFound = true;
                    ScreenIndex = i;
                    _lastBoardSnap = GetBoardSnap();
                    return true;
                }
            }

            return false;
        }

        public static Point[] GetChangedSquares(Bitmap boardSnap)
        {
            if (!BoardFound)
                return null;

            double fieldWidth = boardSnap.Width / (double)SideLength;
            double fieldHeight = boardSnap.Height / (double)SideLength;
            var changedSquares = new List<Point>();

            unsafe
            {
                BitmapData snapData = LockBits(boardSnap);
                BitmapData lastSnapData = LockBits(_lastBoardSnap);
                var scan0 = (byte*)snapData.Scan0;
                var lastScan0 = (byte*)lastSnapData.Scan0;

                for (int y = 0; y < SideLength; y++)
                {
                    for (int x = 0; x < SideLength; x++)
                    {
                        Point border = new Point()
                        {
                            X = Round((x * fieldWidth + 4)),
                            Y = Round((y * fieldHeight + 4))
                        };

                        Point center = new Point()
                        {
                            X = Round((x * fieldWidth + (fieldWidth / 2.0))),
                            Y = Round((y * fieldHeight + fieldHeight * 0.73))
                        };

                        int borderColor = GetPixel(scan0, snapData.Stride, border);
                        int centerColor = GetPixel(scan0, snapData.Stride, center);
                        bool same = borderColor == centerColor;

                        int lastBorderColor = GetPixel(lastScan0, lastSnapData.Stride, border);
                        int lastCenterColor = GetPixel(lastScan0, lastSnapData.Stride, center);
                        bool lastSame = lastBorderColor == lastCenterColor;

                        if (same != lastSame)
                        {
                            changedSquares.Add(new Point(x, y));
                        }
                        else if (!same && centerColor != lastCenterColor)
                        {
                            changedSquares.Add(new Point(x, y));
                        }
                    }
                }

                boardSnap.UnlockBits(snapData);
                _lastBoardSnap.UnlockBits(lastSnapData);
            }

            return changedSquares.ToArray();
        }

        private static BitmapData LockBits(Bitmap bitmap)
        {
            return bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
        }

        public static bool CompareBitmaps(Bitmap bitmap1, Bitmap bitmap2)
        {
            try
            {
                bool equals = true;

                Rectangle rect = new Rectangle(0, 0, bitmap1.Width, bitmap1.Height);
                BitmapData bitmapData1 = bitmap1.LockBits(rect, ImageLockMode.ReadOnly, bitmap1.PixelFormat);
                BitmapData bitmapData2 = bitmap2.LockBits(rect, ImageLockMode.ReadOnly, bitmap2.PixelFormat);

                unsafe
                {
                    var pointer1 = (byte*)bitmapData1.Scan0.ToPointer();
                    var pointer2 = (byte*)bitmapData2.Scan0.ToPointer();
                    int width = rect.Width * 3;

                    for (int y = 0; equals && y < rect.Height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            if (*pointer1 != *pointer2)
                            {
                                equals = false;
                                break;
                            }

                            pointer1++;
                            pointer2++;
                        }

                        pointer1 += bitmapData1.Stride - width;
                        pointer2 += bitmapData2.Stride - width;
                    }
                }

                bitmap1.UnlockBits(bitmapData1);
                bitmap2.UnlockBits(bitmapData2);

                return equals;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return false;
        }

        private static unsafe int GetPixel(byte* scan0, int stride, Point location)
        {
            var pointer = scan0;
            pointer += location.Y * stride + location.X * 3;
            return pointer[0] * 255 * 255 + pointer[1] * 255 + pointer[2];
        }

        public static Bitmap GetBoardSnap()
        {
            if (!BoardFound)
                return null;

            Screen screen = Screen.AllScreens[ScreenIndex];
            Bitmap scrennshot = new Bitmap(BoardSize.Width, BoardSize.Height, PixelFormat.Format24bppRgb);

            using (Graphics g = Graphics.FromImage(scrennshot))
            {
                g.CopyFromScreen(screen.Bounds.X + BoardLocation.X, screen.Bounds.Y + BoardLocation.Y, 0, 0, BoardSize, CopyPixelOperation.SourceCopy);
            }

            return scrennshot;
        }

        public static Bitmap GetScreenshot(Screen screen)
        {
            Bitmap screenshot = new Bitmap(screen.Bounds.Width, screen.Bounds.Height, PixelFormat.Format24bppRgb);

            using (Graphics g = Graphics.FromImage(screenshot))
            {
                g.CopyFromScreen(screen.Bounds.X, screen.Bounds.Y, 0, 0, screen.Bounds.Size, CopyPixelOperation.SourceCopy);
            }

            return screenshot;
        }

        private static bool SearchBoard(Bitmap image, Color darkSquareColor, Color lightSquareColor)
        {
            BitmapData imageData = LockBits(image);

            bool matchFound = false;
            bool widthFound = false;
            bool heightFound = false;
            Rectangle board = new Rectangle(-1, -1, 0, 0);
            const int matchTolerance = 0;
            int initialTolerance = 4;
            int tolerance = -1;
            int imageWidth = image.Width * 3;
            int imageHeight = image.Height;

            unsafe
            {
                byte* imagePointer = (byte*)(void*)imageData.Scan0;
                byte* startPointer = null;

                if (imagePointer == null)
                {
                    image.UnlockBits(imageData);
                    return false;
                }

                for (int y = 0; y < imageHeight; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        Color pixelColor = Color.FromArgb(imagePointer[2], imagePointer[1], imagePointer[0]);

                        if (IsSameColor(pixelColor, lightSquareColor, matchTolerance) || IsSameColor(pixelColor, darkSquareColor, matchTolerance))
                        {
                            if (tolerance > 0)
                            {
                                tolerance = initialTolerance;
                            }

                            if (!matchFound)
                            {
                                board.X = x;
                                board.Y = y;
                                startPointer = imagePointer;
                                matchFound = true;
                            }
                            else if (!widthFound)
                            {
                                board.Width++;
                            }
                            else
                            {
                                board.Height++;
                            }
                        }
                        else
                        {
                            if (tolerance == -1 && matchFound)
                            {
                                initialTolerance = (int)Math.Ceiling(board.Width / 10.0);
                                tolerance = initialTolerance;
                            }

                            if (tolerance > 0)
                            {
                                tolerance--;

                                if (widthFound)
                                {
                                    board.Height++;
                                }
                                else
                                {
                                    board.Width++;
                                }
                            }

                            if (widthFound && tolerance == 0)
                            {
                                heightFound = true;
                                board.Height -= initialTolerance;
                                break;
                            }

                            if (matchFound && tolerance == 0)
                            {
                                widthFound = true;
                                board.Width -= initialTolerance;
                                tolerance = -1;

                                imagePointer = startPointer;
                                imagePointer -= imageWidth;
                                y = board.Y;
                                break;
                            }
                        }

                        if (!widthFound)
                        {
                            imagePointer += 3;
                        }
                        else
                            break;
                    }

                    if (widthFound)
                    {
                        imagePointer += imageWidth;
                    }

                    if (heightFound)
                        break;
                }
            }

            image.UnlockBits(imageData);

            if (heightFound)
            {
                BoardLocation = new Point(board.X, board.Y);
                BoardSize = new Size(board.Width, board.Height);
                FieldSize = new SizeF(BoardSize.Width / (float)SideLength, BoardSize.Height / (float)SideLength);
            }

            return heightFound;
        }

        private static bool IsSameColor(Color color1, Color color2, int tolerance)
        {
            return tolerance >= Math.Abs(color1.R - color2.R) + Math.Abs(color1.G - color2.G) + Math.Abs(color1.B - color2.B);
        }

        private static int Round(double number)
        {
            return (int)Math.Round(number, 0);
        }

        #endregion
    }
}
