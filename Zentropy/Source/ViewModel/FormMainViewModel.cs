using Zentropy.Model;
using ChessDotNet;
using ChessEngineInterface;
using System.Collections.Generic;

namespace Zentropy.ViewModel
{
    public class FormMainViewModel
    {
        #region Fields

        public const string ConfigurationFileName = "config.txt";

        #endregion

        #region Properties

        public int NavigationIndex { get; set; }
        public Engine[] Engines { get; set; }
        public ChessGame Game { get; set; }
        public List<ChessPly> PlyList { get; set; }
        public bool GameFinished => Game.IsCheckmated(Game.WhoseTurn) || Game.IsAdjudication;
        public ChessPly LatestPly => PlyList.Count > 0 ? PlyList[PlyList.Count - 1] : null;

        public ChessPly CurrentPly => PlyList.Count > 0 ? PlyList[NavigationIndex] : null;

        #endregion

        #region Constructors

        public FormMainViewModel()
        {
            Engines = new Engine[2];
            NavigationIndex = 0;
            PlyList = new List<ChessPly>();
            Game = new ChessGame();
            PlyList.Add(new ChessPly(Game.GetFen()));
        }

        #endregion
    }
}
