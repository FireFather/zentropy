using Zentropy.Properties;
using System;
using System.Drawing;

namespace Zentropy.View
{
    public static class PieceImageProvider
    {
        public const int ColorCount = 2;
        public const int PieceCount = 6;

        private static int _id = -1;

        public static Bitmap[] PieceImages { get; set; }

        public static void Inititalize(Bitmap sprite, int id)
        {
            if (_id == id)
            {
                return;
            }

            _id = id;

            PieceImages = new Bitmap[12];

            double pieceImageWidth = sprite.Width / (double)PieceCount;
            double pieceImageHeight = sprite.Height / (double)ColorCount;

            int roundedWidth = (int)Math.Ceiling(pieceImageWidth);
            int roundedHeight = (int)Math.Ceiling(pieceImageHeight);

            int x;
            int y;

            for (int colorI = 0; colorI < 2; colorI++)
            {
                for (int pieceI = 0; pieceI < 6; pieceI++)
                {
                    x = (int)Math.Ceiling(pieceI * pieceImageWidth);
                    y = (int)Math.Ceiling(colorI * pieceImageHeight);

                    PieceImages[colorI * 6 + pieceI] = CropImage(sprite, new Rectangle(x, y, roundedWidth, roundedHeight));
                }
            }
        }

        public static Bitmap GetFromFEN(char FENCharacter)
        {
            if (PieceImages == null || PieceImages[0] == null)
            {
                Inititalize(Resources.AlphaChessPieces, 0);
            }

            switch (FENCharacter)
            {
                case 'K':
                    return PieceImages[0];
                case 'Q':
                    return PieceImages[1];
                case 'B':
                    return PieceImages[2];
                case 'N':
                    return PieceImages[3];
                case 'R':
                    return PieceImages[4];
                case 'P':
                    return PieceImages[5];
                case 'k':
                    return PieceImages[6];
                case 'q':
                    return PieceImages[7];
                case 'b':
                    return PieceImages[8];
                case 'n':
                    return PieceImages[9];
                case 'r':
                    return PieceImages[10];
                case 'p':
                    return PieceImages[11];
            }

            throw new ArgumentException("Invalid char.");
        }

        private static int Round(double value)
        {
            return (int)Math.Round(value, 0);
        }

        private static Bitmap CropImage(Bitmap source, Rectangle section)
        {
            Bitmap croppedImage = new Bitmap(section.Width, section.Height);
            Graphics g = Graphics.FromImage(croppedImage);
            Rectangle src = new Rectangle(section.X, section.Y, section.Width, section.Height);
            Rectangle dst = new Rectangle(0, 0, section.Height, section.Width);
            g.DrawImage(source, dst, src, GraphicsUnit.Pixel);
            g.Dispose();

            return croppedImage;
        }
    }
}
