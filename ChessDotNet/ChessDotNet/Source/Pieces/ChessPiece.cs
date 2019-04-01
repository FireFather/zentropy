using System;
using System.Collections.ObjectModel;

namespace ChessDotNet
{
    /// <summary>
    /// Abstractly represents a chess piece
    /// </summary>
    public abstract class ChessPiece
    {
        /// <summary>
        /// Chess player who owns the piece
        /// </summary>
        public ChessPlayer Owner { get; protected set; }


        public abstract char GetFENLetter();

        public abstract bool IsLegalMove(Move move, ChessGame game);

        public abstract ReadOnlyCollection<Move> GetLegalMoves(BoardPosition position, bool returnIfAny, ChessGame game, Func<Move, bool> gameMoveValidator);

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ChessPiece piece = (ChessPiece)obj;
            return Owner == piece.Owner;
        }

        public override int GetHashCode()
        {
            return new { Piece = GetFENLetter(), Owner }.GetHashCode();
        }

        public static bool operator ==(ChessPiece piece1, ChessPiece piece2)
        {
            if (ReferenceEquals(piece1, piece2))
            {
                return true;
            }

            if ((object)piece1 == null || (object)piece2 == null)
            {
                return false;
            }

            return piece1.Equals(piece2);
        }

        public static bool operator !=(ChessPiece piece1, ChessPiece piece2)
        {
            if (ReferenceEquals(piece1, piece2))
            {
                return false;
            }

            if ((object)piece1 == null || (object)piece2 == null)
            {
                return true;
            }

            return !piece1.Equals(piece2);
        }
    }
}
