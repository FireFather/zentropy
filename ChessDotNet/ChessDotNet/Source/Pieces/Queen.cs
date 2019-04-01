using System;
using System.Linq;
using System.Collections.ObjectModel;

namespace ChessDotNet.Pieces
{
    public class Queen : ChessPiece
    {
        public Queen(ChessPlayer owner)
        {
            Owner = owner;
        }

        public override char GetFENLetter()
        {
            return Owner == ChessPlayer.White ? 'Q' : 'q';
        }

        public override bool IsLegalMove(Move move, ChessGame game)
        {
            ChessUtility.ThrowIfNull(move, "move");
            ChessUtility.ThrowIfNull(game, "game");
            return new Bishop(Owner).IsLegalMove(move, game) || new Rook(Owner).IsLegalMove(move, game);
        }

        public override ReadOnlyCollection<Move> GetLegalMoves(BoardPosition from, bool returnIfAny, ChessGame game, Func<Move, bool> gameMoveValidator)
        {
            ChessUtility.ThrowIfNull(from, "from");
            ReadOnlyCollection<Move> horizontalVerticalMoves = new Rook(Owner).GetLegalMoves(from, returnIfAny, game, gameMoveValidator);
            if (returnIfAny && horizontalVerticalMoves.Count > 0)
                return horizontalVerticalMoves;
            ReadOnlyCollection<Move> diagonalMoves = new Bishop(Owner).GetLegalMoves(from, returnIfAny, game, gameMoveValidator);
            return new ReadOnlyCollection<Move>(horizontalVerticalMoves.Concat(diagonalMoves).ToList());
        }
    }
}
