using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ChessDotNet
{
    /// <summary>
    /// Represents a rook in a chess game
    /// </summary>
    public class Rook : ChessPiece
    {
        /// <summary>
        /// Creates an instance of a rook
        /// </summary>
        /// <param name="owner"></param>
        public Rook(ChessPlayer owner)
        {
            Owner = owner;
        }

        /// <summary>
        /// Returns the FEN letter
        /// </summary>
        /// <returns>FEN letter</returns>
        public override char GetFENLetter()
        {
            return Owner == ChessPlayer.White ? 'R' : 'r';
        }

        public override bool IsLegalMove(Move move, ChessGame game)
        {
            ChessUtility.ThrowIfNull(move, "move");
            ChessUtility.ThrowIfNull(game, "game");
            BoardPosition origin = move.OriginalPosition;
            BoardPosition destination = move.NewPosition;

            BoardDistance posDelta = new BoardDistance(origin, destination);
            if (posDelta.X != 0 && posDelta.Y != 0)
                return false;
            bool increasingRank = destination.Rank > origin.Rank;
            bool increasingFile = (int)destination.File > (int)origin.File;
            if (posDelta.X == 0)
            {
                int f = (int)origin.File;
                for (int r = origin.Rank + (increasingRank ? 1 : -1);
                    increasingRank ? r < destination.Rank : r > destination.Rank;
                    r += increasingRank ? 1 : -1)
                {
                    if (game.GetPieceAt((ChessFile)f, r) != null)
                    {
                        return false;
                    }
                }
            }
            else // (posDelta.DeltaY == 0)
            {
                int r = origin.Rank;
                for (int f = (int)origin.File + (increasingFile ? 1 : -1);
                    increasingFile ? f < (int)destination.File : f > (int)destination.File;
                    f += increasingFile ? 1 : -1)
                {
                    if (game.GetPieceAt((ChessFile)f, r) != null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override ReadOnlyCollection<Move> GetLegalMoves(BoardPosition from, bool returnIfAny, ChessGame game, Func<Move, bool> gameMoveValidator)
        {
            ChessUtility.ThrowIfNull(from, "from");
            List<Move> validMoves = new List<Move>();
            ChessPiece piece = game.GetPieceAt(from);
            int l0 = game.BoardHeight;
            int l1 = game.BoardWidth;
            for (int i = -7; i < 8; i++)
            {
                if (i == 0)
                    continue;
                if (from.Rank + i > 0 && from.Rank + i <= l0)
                {
                    Move move = new Move(from, new BoardPosition(from.File, from.Rank + i), piece.Owner);
                    if (gameMoveValidator(move))
                    {
                        validMoves.Add(move);
                        if (returnIfAny)
                            return new ReadOnlyCollection<Move>(validMoves);
                    }
                }
                if ((int)from.File + i > -1 && (int)from.File + i < l1)
                {
                    Move move = new Move(from, new BoardPosition(from.File + i, from.Rank), piece.Owner);
                    if (gameMoveValidator(move))
                    {
                        validMoves.Add(move);
                        if (returnIfAny)
                            return new ReadOnlyCollection<Move>(validMoves);
                    }
                }
            }
            return new ReadOnlyCollection<Move>(validMoves);
        }
    }
}
