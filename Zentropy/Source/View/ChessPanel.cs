using Zentropy.Properties;
using ChessDotNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Zentropy.View
{
    public class ChessPanel : Panel
    {
        #region Constructors

        public ChessPanel()
        {
            base.DoubleBuffered = true;
        }

        #endregion

        #region Events

        public event PieceMovedEventHandler PieceMoved;

        #endregion

        #region Fields

        private bool _moveTrigger;
        private bool _indicatorMoveDrawing;
        private bool _coordinates = false;
        private bool _boardBorder = false;
        private bool _renderImages = true;
        private int _boardDimension;
        private double _fieldSize;
        private double? _fontSizeFactor;
        private string _pieceFontFamily = string.Empty;
        private Color _darkSquare = Color.Brown;
        private Color _borderColor = Color.White;
        private readonly Brush _legalMoveCircleBrush = new SolidBrush(Color.FromArgb(80, 6, 6, 6));
        private Point _boardLocation;
        private Point _selectedIndex = new Point(-1, -1);
        private Point _movingIndex = new Point(-1, -1);
        private Point _movingPoint = new Point(-1, -1);
        private ChessGame _game;
        private Bitmap[] _scaledPieceImages = new Bitmap[12];
        private List<Image> _resizedDarkSquareImages = new List<Image>();
        private List<Image> _resizedLightSquareImages = new List<Image>();

        private readonly Color _indicatorPositiveColor = Color.FromArgb(160, Color.Green);
        private readonly Color _indicatorNegativeColor = Color.FromArgb(160, Color.Red);
        private readonly Color _indicatorNeutralColor = Color.FromArgb(160, Color.Blue);
        private readonly List<int> _indicatedPositiveSquares = new List<int>();
        private readonly List<int> _indicatedNegativeSquares = new List<int>();
        private readonly List<int> _indicatedNeutralSquares = new List<int>();
        private readonly List<MoveArrow> _indicatedMoves = new List<MoveArrow>();

        #endregion

        #region Properties

        public bool UseSquareImages { get; set; } = false;
        public bool Gradient { get; set; } = true;
        public bool NoHighlight { get; set; } = false;
        public bool BorderHighlight { get; set; } = false;
        public bool IsUnicodeFont { get; set; }
        public bool DisplayLegalMoves { get; set; } = true;
        public bool IsFlipped { get; set; } = false;
        public bool SquareOutline { get; set; } = true;
        public double PieceSizeFactor { get; set; } = 1;
        public string ChessFontChars { get; set; }
        public List<Point> HighlightedSquares { get; set; } = new List<Point>();
        public Image DarkSquareImage { get; set; }
        public Image LightSquareImage { get; set; }

        public bool BoardBorder
        {
            get { return _boardBorder; }
            set
            {
                InvalidateRender();
                _boardBorder = value;
            }
        }

        public bool Coordinates
        {
            get { return _coordinates; }
            set
            {
                InvalidateRender();
                _coordinates = value;
            }
        }

        public string PieceFontFamily
        {
            get { return _pieceFontFamily; }
            set
            {
                _pieceFontFamily = value;
                _fontSizeFactor = null;

                if (_pieceFontFamily != "")
                {
                    _scaledPieceImages = GetPiecesFromFontFamily(value, _fieldSize);
                }
                else
                {
                    _renderImages = true;
                }

                Invalidate();
            }
        }

        public Color DarkSquareColor
        {
            get { return _darkSquare; }

            set
            {
                _darkSquare = value;

                var borderColor = new int[3];

                borderColor[0] = _darkSquare.R - 32;
                borderColor[1] = _darkSquare.G - 32;
                borderColor[2] = _darkSquare.B - 32;

                for (var i = 0; i < borderColor.Length; i++)
                {
                    if (borderColor[i] < 0)
                    {
                        borderColor[i] = 0;
                    }
                }

                _borderColor = Color.FromArgb(borderColor[0], borderColor[1], borderColor[2]);
            }
        }

        public Color LightSquareColor { get; set; } = Color.FromArgb(Model.SerializedInfo.Instance.Opacity, 221, 231, 244);
        public Color HighlightLastmoveColor { get; set; } = Color.FromArgb(Model.SerializedInfo.Instance.Opacity, 255, 255, 128);

        public ChessGame Game
        {
            get { return _game; }
            set
            {
                _movingIndex = new Point(-1, -1);
                _selectedIndex = new Point(-1, -1);

                _game = value;
            }
        }

        public ChessPiece[][] Board { get; private set; }

        public List<MoveArrow> Arrows { get; set; } = new List<MoveArrow>();

        #endregion

        #region Event Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Game == null)
            {
                return;
            }

            var g = e.Graphics;
            Board = Game.GetBoard();

            if (Width > Height)
            {
                _boardLocation = new Point(Round((Width - Height) / 2.0), 0);
                _boardDimension = Height - 1;
            }
            else
            {
                _boardLocation = new Point(0, Round((Height - Width) / 2.0));
                _boardDimension = Width - 1;
            }

            // Draw Border & Coordinates
            if (BoardBorder && Coordinates)
            {
                var borderBrush = new SolidBrush(_borderColor);
                var borderThickness = Round(_boardDimension * 0.032);

                g.FillRectangle(borderBrush, _boardLocation.X, _boardLocation.Y, _boardDimension + 1, _boardDimension + 1);
                g.DrawRectangle(Pens.Black, _boardLocation.X - 1, _boardLocation.Y - 1, _boardDimension + 2, _boardDimension + 2);

                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                var coordinateFontSize = (int)(borderThickness * 0.5);

                if (coordinateFontSize >= 1)
                {
                    var coordinateFont = new Font("Verdana", coordinateFontSize, FontStyle.Bold);

                    for (var i = 0; i < Board.Length; i++)
                    {
                        string rank;
                        string file;

                        if (IsFlipped)
                        {
                            rank = (i + 1).ToString();
                            file = ((char)(Invert(i, 7) + 65)).ToString();
                        }
                        else
                        {
                            rank = (Invert(i, 7) + 1).ToString();
                            file = ((char)(i + 65)).ToString();
                        }

                        g.DrawString(rank, coordinateFont, Brushes.Black,
                            _boardLocation.X + Round(borderThickness * 0.15),
                            _boardLocation.Y + Round(borderThickness + _fieldSize / 2.5 + _fieldSize * i));

                        g.DrawString(file, coordinateFont, Brushes.Black,
                            _boardLocation.X + Round(borderThickness + _fieldSize / 2.4 + _fieldSize * i),
                            _boardLocation.Y + _boardDimension - Round(borderThickness * 0.85));
                    }
                }

                _boardLocation.X += borderThickness;
                _boardLocation.Y += borderThickness;

                _boardDimension -= 2 * borderThickness;

                g.DrawRectangle(Pens.Black, _boardLocation.X - 1, _boardLocation.Y - 1, _boardDimension + 2, _boardDimension + 2);
            }
            else
            // Draw Border
            if (BoardBorder && !Coordinates)
            {
                var borderThickness = Round(_boardDimension * 0.032);
                var borderBrush = new SolidBrush(_borderColor);

                g.FillRectangle(borderBrush, _boardLocation.X, _boardLocation.Y, _boardDimension + 1, _boardDimension + 1);
                g.DrawRectangle(Pens.Black, _boardLocation.X - 1, _boardLocation.Y - 1, _boardDimension + 2, _boardDimension + 2);

                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                _boardLocation.X += borderThickness;
                _boardLocation.Y += borderThickness;

                _boardDimension -= 2 * borderThickness;

                g.DrawRectangle(Pens.Black, _boardLocation.X - 1, _boardLocation.Y - 1, _boardDimension + 2, _boardDimension + 2);
            }
            else
            // Draw Coordinates
            if (Coordinates && !BoardBorder)
            {
                var borderThickness = Round(_boardDimension * 0.032);
                var coordinateFontSize = (int)(borderThickness * 0.5);

                if (coordinateFontSize >= 1)
                {
                    var coordinateFont = new Font("Verdana", coordinateFontSize, FontStyle.Bold);

                    for (var i = 0; i < Board.Length; i++)
                    {
                        string rank;
                        string file;

                        if (IsFlipped)
                        {
                            rank = (i + 1).ToString();
                            file = ((char)(Invert(i, 7) + 65)).ToString();
                        }
                        else
                        {
                            rank = (Invert(i, 7) + 1).ToString();
                            file = ((char)(i + 65)).ToString();
                        }

                        g.DrawString(rank, coordinateFont, Brushes.Black,
                            _boardLocation.X + Round(borderThickness * 0.15),
                            _boardLocation.Y + Round(borderThickness + _fieldSize / 2.5 + _fieldSize * i));

                        g.DrawString(file, coordinateFont, Brushes.Black,
                            _boardLocation.X + Round(borderThickness + _fieldSize / 2.4 + _fieldSize * i),
                            _boardLocation.Y + _boardDimension - Round(borderThickness * 0.85));
                    }
                }

                _boardLocation.X += borderThickness;
                _boardLocation.Y += borderThickness;

                _boardDimension -= 2 * borderThickness;

                g.DrawRectangle(Pens.Black, _boardLocation.X - 1, _boardLocation.Y - 1, _boardDimension + 2,
                    _boardDimension + 2);
            }

            _fieldSize = _boardDimension / (double)Board.Length;

            // Image rendering if required
            if (_renderImages)
            {
                _scaledPieceImages = new Bitmap[12];

                var defaultFont = false;

                if (PieceFontFamily == "" || PieceFontFamily == "Alpha")
                {
                    PieceImageProvider.Inititalize(Resources.AlphaChessPieces, 0);
                    defaultFont = true;
                }
                else if (PieceFontFamily == "Burnett")
                {
                    PieceImageProvider.Inititalize(Resources.BurnettChessPieces, 1);
                    defaultFont = true;
                }
                else if (PieceFontFamily == "Ivory")
                {
                    PieceImageProvider.Inititalize(Resources.IvoryChessPieces, 2);
                    defaultFont = true;
                }
                else if (PieceFontFamily == "Merida")
                {
                    PieceImageProvider.Inititalize(Resources.MeridaChessPieces, 3);
                    defaultFont = true;
                }
                else if (PieceFontFamily == "Monk")
                {
                    PieceImageProvider.Inititalize(Resources.MonkChessPieces, 4);
                    defaultFont = true;
                }

                if (defaultFont)
                {
                    for (var i = 0; i < _scaledPieceImages.Length; i++)
                    {
                        if (PieceSizeFactor > 1.5)
                        {
                            PieceSizeFactor = 1.5;
                        }

                        _scaledPieceImages[i] = ResizeImage(PieceImageProvider.PieceImages[i],
                            (int)(_fieldSize * PieceSizeFactor), (int)(_fieldSize * PieceSizeFactor));
                    }
                }
                else
                {
                    _scaledPieceImages = GetPiecesFromFontFamily(_pieceFontFamily, _fieldSize);

                    if (_scaledPieceImages == null)
                    {
                        return;
                    }
                }

                if (Gradient)
                {
                    for (var i = 0; i < _scaledPieceImages.Length; i++)
                    {
                        _scaledPieceImages[i] = GradientBitmap(_scaledPieceImages[i], i > 5);
                    }
                }
            }

            float absX;
            float absY;

            var xLinePositions = new int[Board.Length + 1];
            var yLinePositions = new int[Board.Length + 1];

            for (int i = 0; i < Board.Length + 1; i++)
            {
                int iPosition = Round(_fieldSize * i);
                xLinePositions[i] = iPosition + _boardLocation.X;
                yLinePositions[i] = iPosition + _boardLocation.Y;
            }

            g.SmoothingMode = SmoothingMode.Default;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;

            if (UseSquareImages && DarkSquareImage != null && LightSquareImage != null)
            {
                if (_renderImages)
                {
                    _resizedDarkSquareImages.Clear();
                    _resizedLightSquareImages.Clear();
                }

                // Drawing image squares
                for (int y = 0; y < Game.BoardHeight; y++)
                {
                    for (int x = 0; x < Game.BoardHeight; x++)
                    {
                        int index = y * Game.BoardHeight + x + y;

                        int width = xLinePositions[x + 1] - xLinePositions[x] + 1;
                        int height = xLinePositions[y + 1] - xLinePositions[y] + 1;
                        Image drawnImage = null;

                        if (index % 2 == 0)
                        {
                            foreach (Image image in _resizedLightSquareImages)
                            {
                                if (image.Width == width && image.Height == height)
                                {
                                    drawnImage = image;
                                    break;
                                }
                            }

                            if (drawnImage == null)
                            {
                                drawnImage = ResizeImage(LightSquareImage, width, height);
                                _resizedLightSquareImages.Add(drawnImage);
                            }
                        }
                        else
                        {
                            foreach (Image image in _resizedDarkSquareImages)
                            {
                                if (image.Width == width && image.Height == height)
                                {
                                    drawnImage = image;
                                    break;
                                }
                            }

                            if (drawnImage == null)
                            {
                                drawnImage = ResizeImage(DarkSquareImage, width, height);
                                _resizedDarkSquareImages.Add(drawnImage);
                            }
                        }

                        g.DrawImage(drawnImage, xLinePositions[x], yLinePositions[y], xLinePositions[x + 1] - xLinePositions[x] + 1, xLinePositions[y + 1] - xLinePositions[y] + 1);
                    }
                }
            }
            else if (UseSquareImages && DarkSquareImage != null)
            {
                Image drawnImage = null;

                if (_renderImages)
                {
                    _resizedDarkSquareImages.Clear();
                    _resizedLightSquareImages.Clear();
                }

                foreach (Image image in _resizedDarkSquareImages)
                {
                    if (image.Width == _boardDimension && image.Height == _boardDimension)
                    {
                        drawnImage = image;
                        break;
                    }
                }

                if (drawnImage == null)
                {
                    drawnImage = ResizeImage(DarkSquareImage, _boardDimension, _boardDimension);
                    _resizedDarkSquareImages.Add(drawnImage);
                }

                g.DrawImage(drawnImage, _boardLocation.X, _boardLocation.Y, _boardDimension + 1, _boardDimension + 1);
            }
            else
            {
                Color evenSquare;
                Color oddSquare;

                evenSquare = LightSquareColor;
                oddSquare = DarkSquareColor;

                // Drawing squares
                for (int y = 0; y < Game.BoardHeight; y++)
                {
                    for (int x = 0; x < Game.BoardHeight; x++)
                    {
                        int index = y * Game.BoardHeight + x + y;

                        if (index % 2 == 0)
                        {
                            g.FillRectangle(new SolidBrush(evenSquare), xLinePositions[x], yLinePositions[y], xLinePositions[x + 1] - xLinePositions[x] + 1, xLinePositions[y + 1] - xLinePositions[y] + 1);
                        }
                        else
                        {
                            g.FillRectangle(new SolidBrush(oddSquare), xLinePositions[x], yLinePositions[y], xLinePositions[x + 1] - xLinePositions[x] + 1, xLinePositions[y + 1] - xLinePositions[y] + 1);
                        }
                    }
                }
            }

            if (!NoHighlight)
            {
                // Last move highlight
                for (var y = 0; y < Game.BoardHeight; y++)
                {
                    for (var x = 0; x < Game.BoardHeight; x++)
                    {
                        foreach (var square in HighlightedSquares)
                        {
                            if ((square.X != x || square.Y != y || IsFlipped) &&
                                (square.X != Invert(Game.BoardHeight - 1, x) ||
                                 square.Y != Invert(Game.BoardHeight - 1, y) || !IsFlipped))
                            {
                                continue;
                            }

                            var widthCorrection = 0;
                            var heightCorrection = 0;

                            if (square.X == Game.BoardWidth - 1 && !IsFlipped ||
                                square.X == 0 && IsFlipped)
                            {
                                widthCorrection = 1;
                            }

                            if (square.Y == Game.BoardWidth - 1 && !IsFlipped ||
                                square.Y == 0 && IsFlipped)
                            {
                                heightCorrection = 1;
                            }

                            if (BorderHighlight)
                            {
                                var offSet = 1;
                                var borderThickness = 1;

                                var borderPen = new Pen(HighlightLastmoveColor, borderThickness * 2);

                                g.DrawRectangle(borderPen, xLinePositions[x] + offSet, yLinePositions[y] + offSet,
                                    xLinePositions[x + 1] - xLinePositions[x] + widthCorrection - borderThickness,
                                    xLinePositions[y + 1] - xLinePositions[y] + heightCorrection - borderThickness);
                            }
                            else
                            {
                                var highLight = new SolidBrush(HighlightLastmoveColor);

                                g.FillRectangle(highLight, xLinePositions[x], yLinePositions[y],
                                    xLinePositions[x + 1] - xLinePositions[x] + widthCorrection,
                                    xLinePositions[y + 1] - xLinePositions[y] + heightCorrection);
                            }
                        }
                    }
                }
            }

            g.SmoothingMode = SmoothingMode.AntiAlias;
            DrawIndicatorSquares(g, xLinePositions, yLinePositions);

            // Draw king check effect
            if (Game.IsInCheck(Game.WhoseTurn))
            {
                var king = Game.WhoseTurn == ChessPlayer.White ? 'K' : 'k';
                var kingFound = false;

                for (var y = 0; y < Board.Length; y++)
                {
                    for (var x = 0; x < Board.Length; x++)
                    {
                        if (Board[y][x] == null)
                        {
                            continue;
                        }

                        if (Board[y][x].GetFENLetter() == king)
                        {
                            var widthCorrection = 0;
                            var heightCorrection = 0;

                            if (x == Game.BoardWidth - 1 && !IsFlipped || x == 0 && IsFlipped)
                            {
                                widthCorrection = 1;
                            }

                            if (y == Game.BoardWidth - 1 && !IsFlipped || y == 0 && IsFlipped)
                            {
                                heightCorrection = 1;
                            }

                            if (IsFlipped)
                            {
                                x = Invert(Game.BoardHeight - 1, x);
                                y = Invert(Game.BoardHeight - 1, y);
                            }

                            float width = xLinePositions[x + 1] - xLinePositions[x] + widthCorrection;
                            float height = xLinePositions[y + 1] - xLinePositions[y] + heightCorrection;

                            var path = new GraphicsPath();
                            path.AddEllipse(xLinePositions[x], yLinePositions[y], width, height);

                            var strongRed = Color.FromArgb(150, Color.Red);
                            var lightRed = Color.FromArgb(0, Color.Red);

                            var checkedWarn = new PathGradientBrush(path)
                            {
                                CenterColor = strongRed,
                                FocusScales = new PointF(0.5F, 0.5F),
                                SurroundColors = new[] { lightRed }
                            };

                            g.FillEllipse(checkedWarn, xLinePositions[x], yLinePositions[y], width, height);
                            kingFound = true;
                            break;
                        }
                    }

                    if (kingFound)
                    {
                        break;
                    }
                }
            }

            // Draw grid borders
            if (SquareOutline)
            {
                for (var i = 0; i < Board.Length + 1; i++)
                {
                    g.DrawLine(Pens.Black, _boardLocation.X, yLinePositions[i], _boardDimension + _boardLocation.X,
                        yLinePositions[i]);
                    g.DrawLine(Pens.Black, xLinePositions[i], _boardLocation.Y, xLinePositions[i],
                        _boardDimension + _boardLocation.Y);
                }
            }

            var maxHeight = 0;
            var heightOffset = 0;

            for (var i = 0; i < _scaledPieceImages.Length; i++)
            {
                if (_scaledPieceImages[i].Height > maxHeight)
                {
                    maxHeight = _scaledPieceImages[i].Height;
                }
            }

            heightOffset = (int)Math.Ceiling((_fieldSize - maxHeight) / 2.0);

            // Draw input arrows that are above pieces
            DrawArrows(g, false);

            // Draw pieces
            for (var y = 0; y < Board.Length; y++)
            {
                for (var x = 0; x < Board.Length; x++)
                {
                    if (Board[y][x] == null || y == _movingIndex.Y && x == _movingIndex.X && !_indicatorMoveDrawing &&
                        _moveTrigger)
                    {
                        continue;
                    }

                    if (Board[y][x].Owner == ChessPlayer.White)
                    {
                        new SolidBrush(Color.White);
                    }
                    else
                    {
                        new SolidBrush(Color.Black);
                    }

                    if (!IsFlipped)
                    {
                        absX = (float)(x * _fieldSize) + _boardLocation.X;
                        absY = (float)(y * _fieldSize) + _boardLocation.Y;
                    }
                    else
                    {
                        absX = (float)(Invert(Game.BoardHeight - 1, x) * _fieldSize) + _boardLocation.X;
                        absY = (float)(Invert(Game.BoardHeight - 1, y) * _fieldSize) + _boardLocation.Y;
                    }

                    var pieceWidth = _scaledPieceImages[GetPieceIndexFromFenChar(Board[y][x].GetFENLetter())].Width;

                    absX += (float)((_fieldSize - pieceWidth) / 2.0);
                    absY += heightOffset + maxHeight -
                            _scaledPieceImages[GetPieceIndexFromFenChar(Board[y][x].GetFENLetter())].Height;

                    g.DrawImage(_scaledPieceImages[GetPieceIndexFromFenChar(Board[y][x].GetFENLetter())], absX, absY);

                    _renderImages = false;
                }
            }

            // Draw legal moves from moved index
            if (DisplayLegalMoves && !_indicatorMoveDrawing)
            {
                var _possibleMovePieceIndex = new Point(-1, -1);

                if (_movingIndex.X != -1)
                {
                    _possibleMovePieceIndex = _movingIndex;
                }
                else if (_selectedIndex.X != -1)
                {
                    _possibleMovePieceIndex = _selectedIndex;
                }

                if (_possibleMovePieceIndex.X != -1 &&
                    Board[_possibleMovePieceIndex.Y][_possibleMovePieceIndex.X] != null)
                {
                    if (Board[_possibleMovePieceIndex.Y][_possibleMovePieceIndex.X].Owner == ChessPlayer.White)
                    {
                        new SolidBrush(Color.White);
                    }
                    else
                    {
                        new SolidBrush(Color.Black);
                    }

                    var startPosition = new BoardPosition((ChessFile)_possibleMovePieceIndex.X,
                        Invert(Game.BoardHeight, _possibleMovePieceIndex.Y));

                    var validMoves = Game.GetValidMoves(startPosition);

                    for (var i = 0; i < validMoves.Count; i++)
                    {
                        var current = validMoves[i];

                        if (!IsFlipped)
                        {
                            g.FillEllipse(_legalMoveCircleBrush,
                                Round((int)current.NewPosition.File * _fieldSize + _fieldSize * 0.4) +
                                _boardLocation.X,
                                Round(Invert(Game.BoardHeight, current.NewPosition.Rank) * _fieldSize +
                                      _fieldSize * 0.4) + _boardLocation.Y, Round(_fieldSize * 0.2),
                                Round(_fieldSize * 0.2));
                        }
                        else
                        {
                            g.FillEllipse(_legalMoveCircleBrush,
                                Round(Invert(Game.BoardHeight - 1, (int)current.NewPosition.File) * _fieldSize +
                                      _fieldSize * 0.4) + _boardLocation.X,
                                Round((current.NewPosition.Rank - 1) * _fieldSize + _fieldSize * 0.4) +
                                _boardLocation.Y, Round(_fieldSize * 0.2), Round(_fieldSize * 0.2));
                        }
                    }
                }
            }

            // Draw indicated move arrows
            if (_indicatedMoves.Count > 0)
            {
                var drawInfo = new MoveArrowDrawInfo[_indicatedMoves.Count];

                for (var i = 0; i < _indicatedMoves.Count; i++)
                {
                    drawInfo[i] = new MoveArrowDrawInfo
                    {
                        Arrow = _indicatedMoves[i],
                        Positions = GetAbsPositionsFromMoveString(_indicatedMoves[i].Move)
                    };
                }

                drawInfo = drawInfo.OrderBy(c => c.Length).ToArray();

                for (var i = drawInfo.Length - 1; i >= 0; i--)
                {
                    var arrowThickness = (float)(drawInfo[i].Arrow.ThicknessPercent / 100.0 * _boardDimension);

                    if (drawInfo[i].Length / _fieldSize > 1.45)
                    {
                        arrowThickness -= 0.85F;
                    }

                    var arrowPen = new Pen(Color.Black, arrowThickness)
                    {
                        Brush = new SolidBrush(drawInfo[i].Arrow.Color),
                        EndCap = LineCap.ArrowAnchor
                    };

                    if (drawInfo[i].Arrow.HasStartCircle)
                    {
                        arrowPen.StartCap = LineCap.RoundAnchor;
                    }
                    else
                    {
                        arrowPen.StartCap = LineCap.Round;
                    }

                    g.DrawLine(arrowPen, drawInfo[i].Positions[0], drawInfo[i].Positions[1]);
                }
            }

            // Draw input arrows that are above pieces
            DrawArrows(g, true);

            // Draw moving index
            if (_movingIndex.X != -1 && _movingPoint.X != -1)
            {
                var indexRelPosition = new Point((int)((_movingPoint.X - _boardLocation.X) / _fieldSize),
                    (int)((_movingPoint.Y - _boardLocation.Y) / _fieldSize));

                if (_indicatorMoveDrawing && indexRelPosition != _movingIndex && indexRelPosition != _movingIndex)
                {
                    var sourcePosX = (float)((_movingIndex.X + 0.5) * _fieldSize + _boardLocation.X);
                    var sourcePosY = (float)((_movingIndex.Y + 0.5) * _fieldSize + _boardLocation.Y);
                    var source = new PointF(sourcePosX, sourcePosY);

                    Color arrowColor;

                    if (ModifierKeys == Keys.Shift)
                    {
                        arrowColor = _indicatorNegativeColor;
                    }
                    else if(ModifierKeys == Keys.Control)
                    {
                        arrowColor = _indicatorNeutralColor;
                    }
                    else
                    {
                        arrowColor = _indicatorPositiveColor;
                    }

                    var arrowPen = new Pen(Color.Black, _boardDimension * 0.025F)
                    {
                        Brush = new SolidBrush(arrowColor),
                        EndCap = LineCap.ArrowAnchor,
                        StartCap = LineCap.Round
                    };

                    g.DrawLine(arrowPen, source, _movingPoint);
                }
                else if (Board[_movingIndex.Y][_movingIndex.X] != null && _moveTrigger)
                {
                    absX = _movingPoint.X - (float)(_fieldSize / 2.0);
                    absY = _movingPoint.Y - (float)(_fieldSize / 2.0);

                    absX += (float)((_fieldSize -
                                      _scaledPieceImages[
                                          GetPieceIndexFromFenChar(
                                              Board[_movingIndex.Y][_movingIndex.X].GetFENLetter())].Width) / 2);
                    absY += (float)((_fieldSize -
                                      _scaledPieceImages[
                                          GetPieceIndexFromFenChar(
                                              Board[_movingIndex.Y][_movingIndex.X].GetFENLetter())].Height) / 2);

                    g.DrawImage(
                        _scaledPieceImages[
                            GetPieceIndexFromFenChar(Board[_movingIndex.Y][_movingIndex.X].GetFENLetter())], absX,
                        absY);
                }
            }
        }

        private void DrawIndicatorSquares(Graphics g, int[] xLines, int[] yLines)
        {
            DrawSquares(_indicatedPositiveSquares, xLines, yLines, _indicatorPositiveColor, g);
            DrawSquares(_indicatedNegativeSquares, xLines, yLines, _indicatorNegativeColor, g);
            DrawSquares(_indicatedNeutralSquares, xLines, yLines, _indicatorNeutralColor, g);
        }

        private void DrawSquares(List<int> indicatedPositiveSquares, int[] xLines, int[] yLines, Color color, Graphics g)
        {
            // Draw indicated squares
            var indicatedGreenBrush = new SolidBrush(Color.FromArgb(100, color));

            for (var i = 0; i < indicatedPositiveSquares.Count; i++)
            {
                var index = indicatedPositiveSquares[i];
                var brush = indicatedGreenBrush;

                var x = index % Game.BoardHeight;
                var y = index / Game.BoardHeight;

                g.FillEllipse(brush, xLines[x] - 1, yLines[y] - 1,
                    xLines[x + 1] - xLines[x] + 1, xLines[y + 1] - xLines[y] + 1);
            }
        }

        private void DrawArrows(Graphics g, bool areAbovePieces)
        {
            if (Arrows.Count > 0)
            {
                var drawInfos = new List<MoveArrowDrawInfo>();

                foreach (var arrow in Arrows)
                {
                    if (arrow.IsAbovePieces != areAbovePieces)
                    {
                        continue;
                    }

                    var arrowInfo = new MoveArrowDrawInfo
                    {
                        Arrow = arrow,
                        Positions = GetAbsPositionsFromMoveString(arrow.Move)
                    };

                    drawInfos.Add(arrowInfo);
                }

                drawInfos = drawInfos.OrderBy(c => c.Length).ToList();

                for (var i = drawInfos.Count - 1; i >= 0; i--)
                {
                    var arrowThickness = (float)(drawInfos[i].Arrow.ThicknessPercent / 100.0 * _boardDimension);

                    if (drawInfos[i].Length / _fieldSize > 1.45)
                    {
                        arrowThickness -= 0.85F;
                    }

                    var arrowPen = new Pen(Color.Black, arrowThickness)
                    {
                        Brush = new SolidBrush(drawInfos[i].Arrow.Color),
                        EndCap = LineCap.ArrowAnchor
                    };

                    if (drawInfos[i].Arrow.HasStartCircle)
                    {
                        arrowPen.StartCap = LineCap.SquareAnchor;
                    }
                    else
                    {
                        arrowPen.StartCap = LineCap.Round;
                    }

                    g.DrawLine(arrowPen, drawInfos[i].Positions[0], drawInfos[i].Positions[1]);
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            var absoluteBoardX = e.X - _boardLocation.X;
            var absoluteBoardY = e.Y - _boardLocation.Y;

            var relativeBoardX = absoluteBoardX / (int)_fieldSize;
            var relativeBoardY = absoluteBoardY / (int)_fieldSize;

            if (relativeBoardX < 0 || relativeBoardX > 7 || relativeBoardY < 0 || relativeBoardY > 7)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                Point pieceIndex;

                if (!IsFlipped)
                {
                    pieceIndex = new Point(relativeBoardX, relativeBoardY);
                }
                else
                {
                    pieceIndex = new Point(Invert(Game.BoardHeight - 1, relativeBoardX),
                        Invert(Game.BoardHeight - 1, relativeBoardY));
                }

                if (Board[pieceIndex.Y][pieceIndex.X] == null)
                {
                    return;
                }

                _movingPoint = new Point(e.X, e.Y);
                _movingIndex = pieceIndex;
            }
            else if (e.Button == MouseButtons.Right)
            {
                _indicatorMoveDrawing = true;

                Point movingIndex;

                movingIndex = new Point(relativeBoardX, relativeBoardY);

                _movingPoint = new Point(e.X, e.Y);
                _movingIndex = movingIndex;
            }

            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            var absoluteBoardX = e.X - _boardLocation.X;
            var absoluteBoardY = e.Y - _boardLocation.Y;

            int relativeBoardX;
            int relativeBoardY;

            if (!IsFlipped)
            {
                relativeBoardX = absoluteBoardX / (int)_fieldSize;
                relativeBoardY = absoluteBoardY / (int)_fieldSize;
            }
            else
            {
                relativeBoardX = Invert(Game.BoardHeight - 1, absoluteBoardX / (int)_fieldSize);
                relativeBoardY = Invert(Game.BoardHeight - 1, absoluteBoardY / (int)_fieldSize);
            }

            if (relativeBoardX < 0 || relativeBoardX > 7 || relativeBoardY < 0 || relativeBoardY > 7)
            {
                _movingIndex = new Point(-1, -1);
                _selectedIndex = new Point(-1, -1);
                Invalidate();
                _indicatorMoveDrawing = false;
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                ClearIndicators();

                var currentIndex = new Point(relativeBoardX, relativeBoardY);

                if (_movingIndex.X != -1 && !_movingIndex.Equals(currentIndex))
                {
                    PieceMoved?.Invoke(this, new PieceMovedEventArgs(_movingIndex, currentIndex));
                    _movingIndex = new Point(-1, -1);
                    _selectedIndex = new Point(-1, -1);
                }
                else
                {
                    _movingIndex = new Point(-1, -1);

                    if (_selectedIndex.X == -1)
                    {
                        if (Board[currentIndex.Y][currentIndex.X] != null &&
                            Board[currentIndex.Y][currentIndex.X].Owner == Game.WhoseTurn)
                        {
                            _selectedIndex = currentIndex;
                        }
                    }
                    else if (!_selectedIndex.Equals(currentIndex))
                    {
                        if (Board[currentIndex.Y][currentIndex.X] != null &&
                            Board[_selectedIndex.Y][_selectedIndex.X] != null &&
                            Board[currentIndex.Y][currentIndex.X].Owner ==
                            Board[_selectedIndex.Y][_selectedIndex.X].Owner)
                        {
                            _selectedIndex = currentIndex;
                        }
                        else
                        {
                            PieceMoved?.Invoke(this, new PieceMovedEventArgs(_selectedIndex, currentIndex));

                            _movingIndex = new Point(-1, -1);
                            _selectedIndex = new Point(-1, -1);
                        }
                    }
                }

                _moveTrigger = false;
            }
            else if (e.Button == MouseButtons.Right && _indicatorMoveDrawing)
            {
                var initialMovingIndex = _movingIndex;
                var moveIndex = new Point(relativeBoardX, relativeBoardY);

                if (IsFlipped)
                {
                    _movingIndex.X = Invert(Game.BoardHeight - 1, _movingIndex.X);
                    _movingIndex.Y = Invert(Game.BoardHeight - 1, _movingIndex.Y);
                }

                if (_movingIndex == moveIndex)
                {
                    _movingIndex = initialMovingIndex;

                    var squareIndex = _movingIndex.Y * Game.BoardHeight + _movingIndex.X;

                    List<int> squares;

                    if (ModifierKeys == Keys.Shift)
                    {
                        squares = _indicatedNegativeSquares;
                    }
                    else if (ModifierKeys == Keys.Control)
                    {
                        squares = _indicatedNeutralSquares;
                    }
                    else
                    {
                        squares = _indicatedPositiveSquares;
                    }

                    if (squares.Contains(squareIndex))
                    {
                        squares.Remove(squareIndex);
                    }
                    else
                    {
                        squares.Add(squareIndex);
                    }
                }
                else
                {
                    var moveString = GetMoveStringFromRelPositions(new[] { _movingIndex, moveIndex });

                    var wasExisting = false;

                    Color arrowColor;

                    if (ModifierKeys == Keys.Shift)
                    {
                        arrowColor = _indicatorNegativeColor;
                    }
                    else if (ModifierKeys == Keys.Control)
                    {
                        arrowColor = _indicatorNeutralColor;
                    }
                    else
                    {
                        arrowColor = _indicatorPositiveColor;
                    }

                    for (var i = 0; i < _indicatedMoves.Count; i++)
                    {
                        if (_indicatedMoves[i].Move == moveString && _indicatedMoves[i].Color == arrowColor)
                        {
                            _indicatedMoves.RemoveAt(i);
                            wasExisting = true;
                            break;
                        }
                    }

                    if (!wasExisting)
                    {
                        var indicatorArrow = new MoveArrow(moveString, 1.2, arrowColor, true, true);
                        _indicatedMoves.Add(indicatorArrow);
                    }
                }

                _movingIndex = new Point(-1, -1);
            }

            _indicatorMoveDrawing = false;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (_movingIndex.X != -1)
            {
                _moveTrigger = !_indicatorMoveDrawing;
                _movingPoint = new Point(e.X, e.Y);
                Invalidate();
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            _renderImages = true;
            Invalidate();
        }

        #endregion

        #region Other Methods

        public void ClearIndicators()
        {
            _indicatedMoves.Clear();
            _indicatedPositiveSquares.Clear();
            _indicatedNegativeSquares.Clear();
            _indicatedNeutralSquares.Clear();
        }

        public void InvalidateRender()
        {
            _renderImages = true;
            Invalidate();
        }

        private void FloodFill(Bitmap image, int x, int y)
        {
            var data = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);
            var check = new LinkedList<Point>();

            var recordLength = 4;
            var bits = new int[data.Stride / recordLength * data.Height];

            Marshal.Copy(data.Scan0, bits, 0, bits.Length);

            var smoothPixelLocations = new List<int>();
            var smoothPixelColors = new List<int>();

            var border = -16777216;
            var alpha1 = 16777216;
            var floodTo = 16777215;
            var floodFrom = bits[x + y * data.Stride / recordLength];

            bits[x + y * data.Stride / recordLength] = floodTo;

            Point[] offSets =
            {
                new Point(0, -1), new Point(0, 1), new Point(-1, 0), new Point(1, 0)
            };

            if (floodFrom != floodTo)
            {
                check.AddLast(new Point(x, y));

                while (check.Count > 0)
                {
                    var current = check.First.Value;
                    check.RemoveFirst();

                    foreach (var offSet in offSets)
                    {
                        var next = new Point(current.X + offSet.X, current.Y + offSet.Y);

                        if (next.X >= 0 && next.Y >= 0 && next.X < data.Width && next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride / recordLength] != border &&
                                (bits[next.X + next.Y * data.Stride / recordLength] > alpha1 ||
                                 bits[next.X + next.Y * data.Stride / recordLength] < 0))
                            {
                                check.AddLast(next);

                                if (bits[next.X + next.Y * data.Stride / recordLength] != floodFrom)
                                {
                                    smoothPixelLocations.Add(next.X + next.Y * data.Stride / recordLength);
                                    smoothPixelColors.Add(bits[next.X + next.Y * data.Stride / recordLength]);
                                }

                                bits[next.X + next.Y * data.Stride / recordLength] = floodTo;
                            }
                        }
                    }
                }
            }

            for (var i = 0; i < smoothPixelLocations.Count; i++)
            {
                var colorInteger = smoothPixelColors[i];
                var color = Color.FromArgb(colorInteger);

                bits[smoothPixelLocations[i]] = Color.FromArgb(Math.Abs(color.R - 255), 0, 0, 0).ToArgb();
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            image.UnlockBits(data);
        }

        private int Round(double number)
        {
            return (int)Math.Round(number, 0);
        }

        private int Invert(int max, int value)
        {
            return Math.Abs(value - max);
        }

        private int GetPieceIndexFromFenChar(char fenCharacter)
        {
            switch (fenCharacter)
            {
                case 'K':
                    return 0;
                case 'k':
                    return 6;
                case 'Q':
                    return 1;
                case 'q':
                    return 7;
                case 'R':
                    return 4;
                case 'r':
                    return 10;
                case 'B':
                    return 2;
                case 'b':
                    return 8;
                case 'N':
                    return 3;
                case 'n':
                    return 9;
                case 'P':
                    return 5;
                case 'p':
                    return 11;
            }

            return -1;
        }

        private Bitmap FillTransparentSectors(Bitmap image)
        {
            Bitmap filledImage;
                filledImage = TransparentToColor(image, Color.White);

            FloodFill(filledImage, 0, 0);
            return filledImage;
        }

        private Bitmap TransparentToColor(Bitmap image, Color color)
        {
            var filledImage = new Bitmap(image.Width, image.Height);
            var rectangle = new Rectangle(Point.Empty, image.Size);

            using (var g = Graphics.FromImage(filledImage))
            {
                g.Clear(color);
                g.DrawImageUnscaledAndClipped(image, rectangle);
            }

            return filledImage;
        }

        private Bitmap GradientBitmap(Bitmap image, bool transformDark = false)
        {
            unsafe
            {
                var data = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                    ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                var pointer = (byte*)data.Scan0;

                var startingPoint = (int)(image.Width * 0.4);

                for (var y = 0; y < image.Height; y++)
                {
                    for (var x = startingPoint; x < image.Width; x++)
                    {
                        var diffValue = (int)(255 * ((x - startingPoint) / (double)image.Width * 0.225));

                        pointer = (byte*)(data.Scan0 + y * data.Stride + x * 4);

                        if (pointer[3] == 255)
                        {
                            for (var i = 0; i < 3; i++)
                            {
                                var value = pointer[i] - diffValue;

                                if (value < 0)
                                {
                                    value = 0;
                                }

                                pointer[i] = (byte)value;
                            }
                        }
                    }
                }

                if (transformDark)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        for (int x = 0; x < image.Width; x++)
                        {
                            int diffValue = Math.Max(40 - x / 2, 0);

                            pointer = (byte*)(data.Scan0 + y * data.Stride + x * 4);

                            if (pointer[1] < diffValue + 1)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    int value = pointer[i] + diffValue;

                                    if (value > 255)
                                    {
                                        value = 255;
                                    }

                                    pointer[i] = (byte)value;
                                }
                            }
                        }
                    }
                }

                image.UnlockBits(data);
            }

            return image;
        }

        private Bitmap CropTransparentBorders(Bitmap image)
        {
            var width = image.Width;
            var height = image.Height;

            bool allTransparentRow(int row)
            {
                for (var i = 0; i < width; ++i)
                {
                    if (image.GetPixel(i, row).A != 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            bool allTransparentColumn(int column)
            {
                for (var i = 0; i < height; ++i)
                {
                    if (image.GetPixel(column, i).A != 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            var topmost = 0;
            for (var row = 0; row < height; ++row)
            {
                if (allTransparentRow(row))
                {
                    topmost = row;
                }
                else
                {
                    break;
                }
            }

            var bottommost = 0;
            for (var row = height - 1; row >= 0; --row)
            {
                if (allTransparentRow(row))
                {
                    bottommost = row;
                }
                else
                {
                    break;
                }
            }

            var leftmost = 0;
            var rightmost = 0;

            for (var column = 0; column < width; ++column)
            {
                if (allTransparentColumn(column))
                {
                    leftmost = column;
                }
                else
                {
                    break;
                }
            }

            for (var column = width - 1; column >= 0; --column)
            {
                if (allTransparentColumn(column))
                {
                    rightmost = column;
                }
                else
                {
                    break;
                }
            }

            var croppedWidth = rightmost + 1 - leftmost;
            var croppedHeight = bottommost + 1 - topmost;

            try
            {
                var target = new Bitmap(croppedWidth, croppedHeight);

                using (var g = Graphics.FromImage(target))
                {
                    g.DrawImage(image, new RectangleF(0, 0, croppedWidth, croppedHeight),
                        new RectangleF(leftmost, topmost, croppedWidth, croppedHeight), GraphicsUnit.Pixel);
                }

                return target;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return image;
            }
        }

        private Bitmap GetCharacterImage(string fontFamily, int fontSize, char character)
        {
            var font = new Font(fontFamily, fontSize);
            SizeF drawSize = TextRenderer.MeasureText(character.ToString(), font);
            var charImage = new Bitmap((int)drawSize.Width, (int)drawSize.Height);
            var g = Graphics.FromImage(charImage);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            g.DrawString(character.ToString(), font, Brushes.Black, 0, 0);
            return charImage;
        }

        private Bitmap ResizeImage(Image image, int width, int height)
        {
            var result = new Bitmap(width, height);
            result.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var g = Graphics.FromImage(result))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.DrawImage(image, 0, 0, result.Width, result.Height);
            }

            return result;
        }

        public Point[] GetRelPositionsFromMoveString(string move)
        {
            var index = new Point[2];
            index[0] = new Point(move[0] - 97, Invert(Game.BoardHeight, int.Parse(move[1].ToString())));
            index[1] = new Point(move[2] - 97, Invert(Game.BoardHeight, int.Parse(move[3].ToString())));

            return index;
        }

        public PointF[] GetAbsPositionsFromMoveString(string move)
        {
            var index = new PointF[2];

            var offSet = 0.5;

            if (!IsFlipped)
            {
                index[0] = new PointF((float)((move[0] - 97 + offSet) * _fieldSize + _boardLocation.X - 0.45F),
                    (float)((Invert(Game.BoardHeight, int.Parse(move[1].ToString())) + offSet) * _fieldSize +
                             _boardLocation.Y));
                index[1] = new PointF((float)((move[2] - 97 + offSet) * _fieldSize + _boardLocation.X - 0.45F),
                    (float)((Invert(Game.BoardHeight, int.Parse(move[3].ToString())) + offSet) * _fieldSize +
                             _boardLocation.Y));
            }
            else
            {
                index[0] = new PointF(
                    (float)((Invert(Game.BoardHeight - 1, move[0] - 97) + offSet) * _fieldSize + _boardLocation.X -
                             0.70F),
                    (float)((int.Parse(move[1].ToString()) - 1 + offSet) * _fieldSize + _boardLocation.Y));
                index[1] = new PointF(
                    (float)((Invert(Game.BoardHeight - 1, move[2] - 97) + offSet) * _fieldSize + _boardLocation.X -
                             0.70F),
                    (float)((int.Parse(move[3].ToString()) - 1 + offSet) * _fieldSize + _boardLocation.Y));
            }

            return index;
        }

        private string GetMoveStringFromRelPositions(Point[] position)
        {
            var moveString = "";

            for (var i = 0; i < 2; i++)
            {
                moveString += (char)(position[i].X + 97);
                moveString += Invert(Game.BoardWidth, position[i].Y);
            }

            return moveString;
        }

        private Bitmap[] GetPiecesFromFontFamily(string fontFamily, double fieldSize)
        {
            if (fieldSize == 0)
            {
                return null;
            }

            var pieceImages = new Bitmap[12];

            var minFontSize = 125;
            var whiteKing = 0x2654;

            char[] characters;

            if (IsUnicodeFont || ChessFontChars == null || ChessFontChars.Length != 12)
            {
                characters = new[]
                {
                    '♔', '♕', '♗', '♘', '♖', '♙',
                    '♚', '♛', '♝', '♞', '♜', '♟'
                };
            }
            else
            {
                characters = ChessFontChars.ToCharArray();
            }

            if (_fontSizeFactor == null)
            {
                _fontSizeFactor = double.MaxValue;

                for (var i = 0; i < 6; i++)
                {
                    var image = GetCharacterImage(fontFamily, (int)fieldSize, characters[i]);
                    var croppedImage = CropTransparentBorders(image);

                    var widthOffset = (double)image.Width / croppedImage.Width - 1;
                    var heightOffset = (double)image.Height / croppedImage.Height - 1;

                    if (widthOffset < _fontSizeFactor)
                    {
                        _fontSizeFactor = widthOffset;
                    }

                    if (heightOffset < _fontSizeFactor)
                    {
                        _fontSizeFactor = heightOffset;
                    }
                }
            }

            var fontSize = -1;
            var currentDimension = new SizeF(-1, -1);

            var fontSizeCounter = 0;

            while (currentDimension.Height < fieldSize && currentDimension.Width < fieldSize)
            {
                fontSizeCounter++;

                var font = new Font(fontFamily, fontSizeCounter);
                currentDimension = TextRenderer.MeasureText(((char)whiteKing).ToString(), font);
            }

            fontSize = (int)(fontSizeCounter * (1 + _fontSizeFactor) * PieceSizeFactor);

            if (fontSize > (int)_fieldSize + 1)
            {
                fontSize = (int)_fieldSize;
            }

            for (var i = 0; i < pieceImages.Length; i++)
            {
                Bitmap originalImage = null;

                if (fontSize < minFontSize)
                {
                    originalImage = CropTransparentBorders(GetCharacterImage(fontFamily, fontSize, characters[i]));
                    pieceImages[i] = CropTransparentBorders(GetCharacterImage(fontFamily, minFontSize, characters[i]));
                }
                else
                {
                    pieceImages[i] = CropTransparentBorders(GetCharacterImage(fontFamily, fontSize, characters[i]));
                }

                pieceImages[i] = FillTransparentSectors(pieceImages[i]);

                if (fontSize < minFontSize)
                {
                    pieceImages[i] = ResizeImage(pieceImages[i], originalImage.Width, originalImage.Height);
                }
            }

            return pieceImages;
        }

        #endregion
    }
}