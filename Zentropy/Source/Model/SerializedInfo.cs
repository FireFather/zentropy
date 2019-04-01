using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace Zentropy.Model
{
    [Serializable]
    public class SerializedInfo
    {
        public static SerializedInfo Instance { get; set; } = new SerializedInfo();

        public bool UseSquareImages { get; set; } = false;
        public bool HideArrows { get; set; }
        public bool BoardFlipped { get; set; }
        public bool Coordinates { get; set; } = false;
        public bool BoardBorder { get; set; } = false;
        public bool DisplayLegalMoves { get; set; } = false;
        public bool Gradient { get; set; } = true;
        public bool DarkMode { get; set; } = false;
        public bool NoHighlight { get; set; } = false;
        public bool ArrowHighlight { get; set; } = false;
        public bool BorderHighlight { get; set; } = false;
        public bool AutoCheck { get; set; } = false;
        public bool HideBottomPanel { get; set; } = false;
        public bool HideLeftPanel { get; set; } = false;
        public bool HideRightPanel { get; set; } = false;
        public bool ShowExtendedMoveInfo { get; set; } = true;
        public bool SaveGames { get; set; } = true;
        public string SiteName { get; set; } = "Earth";
        public string EventName { get; set; } = "Engine Game";
        public bool SquareOutline { get; set; } = true;
        public bool IsMaximized { get; set; } = false;
        public bool Sound { get; set; } = true;
        public int MultiPv { get; set; } = 1;
        public int MatchGames { get; set; } = 64;
        public int RoundNumber { get; set; } = 1;
        public int Pause { get; set; } = 4;
        public int Opacity { get; set; } = 200;
        public bool UseBook { get; set; } = true;
        public bool Random { get; set; } = false;
        public int LastBookLine { get; set; } = 1;
        public int CurrBookLine { get; set; } = 1;
        public int TotalBookLines { get; set; } = 0;
        public int DrawAdjudicationScore { get; set; } = 10;
        public int DrawAdjudicationMoves { get; set; } = 8;
        public bool DrawAdjudicationEnable { get; set; } = false;
        public int ResignAdjudicationScore { get; set; } = 500;
        public int ResignAdjudicationMoves { get; set; } = 8;
        public bool ResignAdjudicationEnable { get; set; } = false;
        public int SelectedFontIndex { get; set; } = 0;
        public int? SplitterDistanceMain { get; set; } = null;
        public int? SplitterDistance1 { get; set; } = null;
        public int? SplitterDistance2 { get; set; } = null;
        public double PieceSizeFactor { get; set; } = 1;
        public string LightSquarePath { get; set; }
        public string DarkSquarePath { get; set; }
        public TimeControl TimeControl { get; set; } = new TimeControl();
        public Rectangle? Bounds { get; set; } = null;
        public EngineList EngineList { get; set; } = new EngineList();
        public ChessFont SelectedChessFont => ChessFonts[SelectedFontIndex];
        public List<ChessFont> ChessFonts { get; set; } = new List<ChessFont>();

        [XmlElement("DarkSquareColor")]
        public int BoardDarkSquareAsArgb
        {
            get { return DarkSquareColor.ToArgb(); }
            set { DarkSquareColor = Color.FromArgb(value); }
        }

        [XmlElement("LightSquareColor")]
        public int BoardLightSquareAsArgb
        {
            get { return LightSquareColor.ToArgb(); }
            set { LightSquareColor = Color.FromArgb(value); }
        }
        [XmlElement("HighlightLastmoveColor")]
        public int BoardHighlightLastmoveAsArgb
        {
            get { return HighlightLastmoveColor.ToArgb(); }
            set { HighlightLastmoveColor = Color.FromArgb(value); }
        }
        [XmlIgnore] public Color DarkSquareColor { get; set; } = Color.FromArgb(230, 121, 145, 176);
        [XmlIgnore] public Color LightSquareColor { get; set; } = Color.FromArgb(230, 221, 231, 244);
        [XmlIgnore] public Color HighlightLastmoveColor { get; set; } = Color.FromArgb(200, 255, 255, 128);

        private SerializedInfo() { }
    }
}
