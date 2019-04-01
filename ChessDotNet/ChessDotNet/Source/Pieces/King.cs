using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ChessDotNet.Pieces
{
    public class King : ChessPiece
    {
        public bool HasCastlingAbility
        {
            get;
            set;
        }

        public King(ChessPlayer owner) : this(owner, true) { }

        public King(ChessPlayer owner, bool hasCastlingAbility)
        {
            Owner = owner;
            HasCastlingAbility = hasCastlingAbility;
        }

        public override char GetFENLetter()
        {
            return Owner == ChessPlayer.White ? 'K' : 'k';
        }

        public override bool IsLegalMove(Move move, ChessGame game)
        {
            ChessUtility.ThrowIfNull(move, "move");
            BoardPosition origin = move.OriginalPosition;
            BoardPosition destination = move.NewPosition;
            BoardDistance distance = new BoardDistance(origin, destination);
            if ((distance.X != 1 || distance.Y != 1)
                        && (distance.X != 0 || distance.Y != 1)
                        && (distance.X != 1 || distance.Y != 0)
                        && (distance.X != 2 || distance.Y != 0))
                return false;
            if (distance.X != 2)
                return true;
            return CanCastle(origin, destination, game);
        }

        protected virtual bool CanCastle(BoardPosition origin, BoardPosition destination, ChessGame game)
        {
            if (!HasCastlingAbility) return false;
            if (Owner == ChessPlayer.White)
            {
                if (origin.File != ChessFile.E || origin.Rank != 1)
                    return false;
                if (game.IsInCheck(ChessPlayer.White))
                    return false;
                if (destination.File == ChessFile.C)
                {
                    if (!game.CanWhiteCastleQueenSide || game.GetPieceAt(ChessFile.D, 1) != null
                        || game.GetPieceAt(ChessFile.C, 1) != null
                        || game.GetPieceAt(ChessFile.B, 1) != null
                        || game.WouldBeInCheckAfter(new Move(new BoardPosition(ChessFile.E, 1), new BoardPosition(ChessFile.D, 1), ChessPlayer.White), ChessPlayer.White)
                        || game.WouldBeInCheckAfter(new Move(new BoardPosition(ChessFile.E, 1), new BoardPosition(ChessFile.C, 1), ChessPlayer.White), ChessPlayer.White))
                        return false;
                }
                else
                {
                    if (!game.CanWhiteCastleKingSide || game.GetPieceAt(ChessFile.F, 1) != null
                        || game.GetPieceAt(ChessFile.G, 1) != null
                        || game.WouldBeInCheckAfter(new Move(new BoardPosition(ChessFile.E, 1), new BoardPosition(ChessFile.F, 1), ChessPlayer.White), ChessPlayer.White)
                        || game.WouldBeInCheckAfter(new Move(new BoardPosition(ChessFile.E, 1), new BoardPosition(ChessFile.G, 1), ChessPlayer.White), ChessPlayer.White))
                        return false;
                }
            }
            else
            {
                if (origin.File != ChessFile.E || origin.Rank != 8)
                    return false;
                if (game.IsInCheck(ChessPlayer.Black))
                    return false;
                if (destination.File == ChessFile.C)
                {
                    if (!game.CanBlackCastleQueenSide || game.GetPieceAt(ChessFile.D, 8) != null
                        || game.GetPieceAt(ChessFile.C, 8) != null
                        || game.GetPieceAt(ChessFile.B, 8) != null
                        || game.WouldBeInCheckAfter(new Move(new BoardPosition(ChessFile.E, 8), new BoardPosition(ChessFile.D, 8), ChessPlayer.Black), ChessPlayer.Black)
                        || game.WouldBeInCheckAfter(new Move(new BoardPosition(ChessFile.E, 8), new BoardPosition(ChessFile.C, 8), ChessPlayer.Black), ChessPlayer.Black))
                        return false;
                }
                else
                {
                    if (!game.CanBlackCastleKingSide || game.GetPieceAt(ChessFile.F, 8) != null
                        || game.GetPieceAt(ChessFile.G, 8) != null
                        || game.WouldBeInCheckAfter(new Move(new BoardPosition(ChessFile.E, 8), new BoardPosition(ChessFile.F, 8), ChessPlayer.Black), ChessPlayer.Black)
                        || game.WouldBeInCheckAfter(new Move(new BoardPosition(ChessFile.E, 8), new BoardPosition(ChessFile.G, 8), ChessPlayer.Black), ChessPlayer.Black))
                        return false;
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
            int[][] directions = new int[][] { new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { -1, 0 },
                        new int[] { 1, 1 }, new int[] { 1, -1 }, new int[] { -1, 1 }, new int[] { -1, -1 }, new int[] { 2, 0 }, new int[] { -2, 0 } };
            foreach (int[] dir in directions)
            {
                if ((int)from.File + dir[0] < 0 || (int)from.File + dir[0] >= l1
                    || from.Rank + dir[1] < 1 || from.Rank + dir[1] > l0)
                    continue;
                Move move = new Move(from, new BoardPosition(from.File + dir[0], from.Rank + dir[1]), piece.Owner);
                if (gameMoveValidator(move))
                {
                    validMoves.Add(move);
                    if (returnIfAny)
                        return new ReadOnlyCollection<Move>(validMoves);
                }
            }
            return new ReadOnlyCollection<Move>(validMoves);
        }
    }
}
