namespace ChessDotNet
{
    public class GameCreationData
    {
        public ChessPiece[][] Board
        {
            get;
            set;
        }

        public ChessPlayer WhoseTurn
        {
            get;
            set;
        }

        public bool CanWhiteCastleKingSide
        {
            get;
            set;
        }

        public bool CanWhiteCastleQueenSide
        {
            get;
            set;
        }

        public bool CanBlackCastleKingSide
        {
            get;
            set;
        }

        public bool CanBlackCastleQueenSide
        {
            get;
            set;
        }

        public BoardPosition EnPassant
        {
            get;
            set;
        }

        public int HalfMoveClock
        {
            get;
            set;
        }

        public int FullMoveNumber
        {
            get;
            set;
        }

        public int ThreeCheck_ChecksByWhite
        {
            get;
            set;
        }

        public int ThreeCheck_ChecksByBlack
        {
            get;
            set;
        }
    }
}
