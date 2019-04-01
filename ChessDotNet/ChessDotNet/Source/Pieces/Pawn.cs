using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ChessDotNet.Pieces
{
    public class Pawn : ChessPiece
    {
        public Pawn(ChessPlayer owner)
        {
            Owner = owner;
        }

        public override char GetFENLetter()
        {
            return Owner == ChessPlayer.White ? 'P' : 'p';
        }

        protected virtual char[] ValidPromotionPieces
        {
            get
            {
                return new char[] { 'Q', 'q', 'R', 'r', 'B', 'b', 'N', 'n' };
            }
        }

        public override bool IsLegalMove(Move move, ChessGame game)
        {
            ChessUtility.ThrowIfNull(move, "move");
            ChessUtility.ThrowIfNull(game, "game");
            BoardPosition origin = move.OriginalPosition;
            BoardPosition destination = move.NewPosition;

            ChessPiece promotion = null;
            if (move.Promotion.HasValue && ValidPromotionPieces.Contains(move.Promotion.Value))
            {
                promotion = game.MapPgnCharToPiece(char.ToUpper(move.Promotion.Value), move.Player);
            }
            BoardDistance posDelta = new BoardDistance(origin, destination);
            if ((posDelta.X != 0 || posDelta.Y != 1) && (posDelta.X != 1 || posDelta.Y != 1)
                        && (posDelta.X != 0 || posDelta.Y != 2))
                return false;
            if (Owner == ChessPlayer.White)
            {
                if (origin.Rank > destination.Rank)
                    return false;
                if (destination.Rank == 8)
                {
                    if (promotion == null)
                        return false;
                    if (promotion.Owner != ChessPlayer.White)
                        return false;
                    if (!ValidPromotionPieces.Contains(promotion.GetFENLetter()))
                        return false;
                }
            }
            if (Owner == ChessPlayer.Black)
            {
                if (origin.Rank < destination.Rank)
                    return false;
                if (destination.Rank == 1)
                {
                    if (promotion == null)
                        return false;
                    if (promotion.Owner != ChessPlayer.Black)
                        return false;
                    if (!ValidPromotionPieces.Contains(promotion.GetFENLetter()))
                        return false;
                }
            }
            bool checkEnPassant = false;
            if (posDelta.Y == 2)
            {
                if ((origin.Rank != 2 && Owner == ChessPlayer.White)
                    || (origin.Rank != 7 && Owner == ChessPlayer.Black))
                    return false;
                if (origin.Rank == 2 && game.GetPieceAt(origin.File, 3) != null)
                    return false;
                if (origin.Rank == 7 && game.GetPieceAt(origin.File, 6) != null)
                    return false;
            }
            ChessPiece pieceAtDestination = game.GetPieceAt(destination);
            if (posDelta.X == 0 && (posDelta.Y == 1 || posDelta.Y == 2))
            {
                if (pieceAtDestination != null)
                    return false;
            }
            else
            {
                if (pieceAtDestination == null)
                    checkEnPassant = true;
                else if (pieceAtDestination.Owner == Owner)
                    return false;
            }
            if (checkEnPassant)
            {
                ReadOnlyCollection<DetailedMove> _moves = game.Moves;
                if (_moves.Count == 0)
                {
                    return false;
                }
                if ((origin.Rank != 5 && Owner == ChessPlayer.White)
                    || (origin.Rank != 4 && Owner == ChessPlayer.Black))
                    return false;
                Move latestMove = _moves[_moves.Count - 1];
                if (latestMove.Player != ChessUtility.GetOpponentOf(Owner))
                    return false;
                if (!(game.GetPieceAt(latestMove.NewPosition) is Pawn))
                    return false;
                if (game.GetPieceAt(latestMove.NewPosition).Owner == Owner)
                    return false;
                if (Owner == ChessPlayer.White)
                {
                    if (latestMove.OriginalPosition.Rank != 7 || latestMove.NewPosition.Rank != 5)
                        return false;
                }
                else // (m.Player == Players.Black)
                {
                    if (latestMove.OriginalPosition.Rank != 2 || latestMove.NewPosition.Rank != 4)
                        return false;
                }
                if (destination.File != latestMove.NewPosition.File)
                    return false;
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
            int[][] directions;
            if (piece.Owner == ChessPlayer.White)
            {
                directions = new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 1, 1 }, new int[] { -1, 1 } };
            }
            else
            {
                directions = new int[][] { new int[] { 0, -1 }, new int[] { 0, -2 }, new int[] { -1, -1 }, new int[] { 1, -1 } };
            }
            foreach (int[] dir in directions)
            {
                if ((int)from.File + dir[0] < 0 || (int)from.File + dir[0] >= l1
                    || from.Rank + dir[1] < 1 || from.Rank + dir[1] > l0)
                    continue;
                Move move = new Move(from, new BoardPosition(from.File + dir[0], from.Rank + dir[1]), piece.Owner);
                List<Move> moves = new List<Move>();
                if ((move.NewPosition.Rank == 8 && move.Player == ChessPlayer.White) || (move.NewPosition.Rank == 1 && move.Player == ChessPlayer.Black))
                {
                    foreach (char pieceChar in ValidPromotionPieces.Where(x => char.IsUpper(x)))
                    {
                        moves.Add(new Move(move.OriginalPosition, move.NewPosition, move.Player, pieceChar));
                    }
                }
                else
                {
                    moves.Add(move);
                }
                foreach (Move m in moves)
                {
                    if (gameMoveValidator(m))
                    {
                        validMoves.Add(m);
                        if (returnIfAny)
                            return new ReadOnlyCollection<Move>(validMoves);
                    }
                }
            }
            return new ReadOnlyCollection<Move>(validMoves);
        }
    }
}
