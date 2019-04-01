using ChessDotNet.Pieces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ChessDotNet
{
    public class ChessGame
    {

        protected virtual int[] AllowedFenPartsLength
        {
            get
            {
                return new int[1] { 6 };
            }
        }

        private readonly Dictionary<char, ChessPiece> fenMappings = new Dictionary<char, ChessPiece>()
        {
            { 'K', new King(ChessPlayer.White) },
            { 'k', new King(ChessPlayer.Black) },
            { 'Q', new Queen(ChessPlayer.White) },
            { 'q', new Queen(ChessPlayer.Black) },
            { 'R', new Rook(ChessPlayer.White) },
            { 'r', new Rook(ChessPlayer.Black) },
            { 'B', new Bishop(ChessPlayer.White) },
            { 'b', new Bishop(ChessPlayer.Black) },
            { 'N', new Knight(ChessPlayer.White) },
            { 'n', new Knight(ChessPlayer.Black) },
            { 'P', new Pawn(ChessPlayer.White) },
            { 'p', new Pawn(ChessPlayer.Black) },
        };
        protected virtual Dictionary<char, ChessPiece> FenMappings
        {
            get
            {
                return fenMappings;
            }
        }

        public virtual ChessPiece MapPgnCharToPiece(char c, ChessPlayer owner)
        {
            switch (c)
            {
                case 'K':
                    return owner == ChessPlayer.White ? FenMappings['K'] : FenMappings['k'];
                case 'Q':
                    return owner == ChessPlayer.White ? FenMappings['Q'] : FenMappings['q'];
                case 'R':
                    return owner == ChessPlayer.White ? FenMappings['R'] : FenMappings['r'];
                case 'B':
                    return owner == ChessPlayer.White ? FenMappings['B'] : FenMappings['b'];
                case 'N':
                    return owner == ChessPlayer.White ? FenMappings['N'] : FenMappings['n'];
                case 'P':
                    return owner == ChessPlayer.White ? FenMappings['P'] : FenMappings['p'];
                default:
                    if (!char.IsLower(c))
                    {
                        throw new PgnException("Unrecognized piece type: " + c.ToString());
                    }
                    return owner == ChessPlayer.White ? FenMappings['P'] : FenMappings['p'];
            }
        }

        public bool drawAdjudication = false;
        public bool resignAdjudication = false;
        protected bool fiftyMoves = false;

        public virtual bool IsAdjudication
        {
            get
            {
                return Is3Fold() || !HasSufficientMaterial() || fiftyMoves || IsStalemated(WhoseTurn)
                    || drawAdjudication || resignAdjudication;
            }
        }

        private struct LocPiece
        {
            public ChessPiece Piece;
            public int X;
            public int Y;
        }

        private bool Is3Fold()
        {
            if (_positions.Count < 3)
            {
                return false;
            }

            int sameCount = 0;

            for (int checkedI = 0; checkedI < _positions.Count; checkedI++)
            {
                for (int i = checkedI + 1; i < _positions.Count; i++)
                {
                    if (_positions[checkedI] == _positions[i])
                    {
                        sameCount++;

                        if (sameCount > 2)
                        {
                            return true;
                        }
                    }
                }
                sameCount = 0;
            }

            return false;
        }

        private bool HasSufficientMaterial()
        {
            List<LocPiece> pieces = new List<LocPiece>();

            for (int y = 0; y < Board.Length; y++)
            {
                for (int x = 0; x < Board.Length; x++)
                {
                    if (Board[x][y] == null || Board[x][y].Owner == ChessPlayer.None || Board[x][y].GetFENLetter() == 'k' || Board[x][y].GetFENLetter() == 'K')
                    {
                        continue;
                    }

                    LocPiece locPiece = new LocPiece
                    {
                        Piece = Board[x][y],
                        X = x,
                        Y = y
                    };

                    pieces.Add(locPiece);
                }
            }

            if (pieces.Count == 0)
            {
                return false;
            }
            else if (pieces.Count == 1)
            {
                if (pieces[0].Piece.GetFENLetter() == 'B' ||
                    pieces[0].Piece.GetFENLetter() == 'b' ||
                    pieces[0].Piece.GetFENLetter() == 'N' ||
                    pieces[0].Piece.GetFENLetter() == 'n')
                {
                    return false;
                }
            }

            return true;
        }

        public ChessPlayer WhoseTurn
        {
            get;
            protected set;
        }

        int _halfMoveClock = 0;
        public int HalfMoveClock
        {
            get
            {
                return _halfMoveClock;
            }
        }

        int _fullMoveNumber = 1;
        public int FullMoveNumber
        {
            get
            {
                return _fullMoveNumber;
            }
        }

        public ReadOnlyCollection<ChessPiece> PiecesOnBoard
        {
            get
            {
                return new ReadOnlyCollection<ChessPiece>(Board.SelectMany(x => x).Where(x => x != null).ToList());
            }
        }

        public virtual int BoardWidth
        {
            get
            {
                return 8;
            }
        }

        public virtual int BoardHeight
        {
            get
            {
                return 8;
            }
        }

        protected ChessPiece[][] Board;
        public ChessPiece[][] GetBoard()
        {
            return CloneBoard(Board);
        }

        List<string> _positions = new List<string>();

        public ReadOnlyCollection<string> Positions
        {
            get
            {
                return new ReadOnlyCollection<string>(_positions);
            }
            protected set
            {
                _positions = value.ToList();
            }
        }

        List<DetailedMove> _moves = new List<DetailedMove>();
        public ReadOnlyCollection<DetailedMove> Moves
        {
            get
            {
                return new ReadOnlyCollection<DetailedMove>(_moves);
            }
            protected set
            {
                _moves = value.ToList();
            }
        }

        public bool CanBlackCastleKingSide
        {
            get;
            protected set;
        }

        public bool CanBlackCastleQueenSide
        {
            get;
            protected set;
        }

        public bool CanWhiteCastleKingSide
        {
            get;
            protected set;
        }

        public bool CanWhiteCastleQueenSide
        {
            get;
            protected set;
        }

        protected virtual bool CastlingCanBeLegal
        {
            get
            {
                return true;
            }
        }

        protected static ChessPiece[][] CloneBoard(ChessPiece[][] originalBoard)
        {
            ChessUtility.ThrowIfNull(originalBoard, "originalBoard");
            ChessPiece[][] newBoard = new ChessPiece[originalBoard.Length][];
            for (int i = 0; i < originalBoard.Length; i++)
            {
                newBoard[i] = new ChessPiece[originalBoard[i].Length];
                Array.Copy(originalBoard[i], newBoard[i], originalBoard[i].Length);
            }
            return newBoard;
        }

        public ChessGame()
        {
            WhoseTurn = ChessPlayer.White;
            _moves = new List<DetailedMove>();
            _positions = new List<string>();
            Board = new ChessPiece[8][];
            ChessPiece kw = FenMappings['K'];
            ChessPiece kb = FenMappings['k'];
            ChessPiece qw = FenMappings['Q'];
            ChessPiece qb = FenMappings['q'];
            ChessPiece rw = FenMappings['R'];
            ChessPiece rb = FenMappings['r'];
            ChessPiece nw = FenMappings['N'];
            ChessPiece nb = FenMappings['n'];
            ChessPiece bw = FenMappings['B'];
            ChessPiece bb = FenMappings['b'];
            ChessPiece pw = FenMappings['P'];
            ChessPiece pb = FenMappings['p'];
            ChessPiece o = null;
            Board = new ChessPiece[8][]
            {
                new[] { rb, nb, bb, qb, kb, bb, nb, rb },
                new[] { pb, pb, pb, pb, pb, pb, pb, pb },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { o, o, o, o, o, o, o, o },
                new[] { pw, pw, pw, pw, pw, pw, pw, pw },
                new[] { rw, nw, bw, qw, kw, bw, nw, rw }
            };
            CanBlackCastleKingSide = CanBlackCastleQueenSide = CanWhiteCastleKingSide = CanWhiteCastleQueenSide = CastlingCanBeLegal;
        }

        public ChessGame(IEnumerable<Move> moves, bool movesAreValidated) : this()
        {
            if (moves == null)
                throw new ArgumentNullException("moves");
            if (moves.Count() == 0)
                throw new ArgumentException("The Count of moves has to be greater than 0.");
            foreach (Move m in moves)
            {
                if (ApplyMove(m, movesAreValidated) == MoveType.Invalid)
                {
                    throw new ArgumentException("Invalid move passed to ChessGame constructor.");
                }
            }
        }

        public ChessGame(string fen)
        {
            GameCreationData data = FenStringToGameCreationData(fen);
            UseGameCreationData(data);
        }

        public ChessGame(GameCreationData data)
        {
            UseGameCreationData(data);
        }

        [Obsolete("This constructor is obsolete, use ChessGame(GameCreationData) instead.")]
        public ChessGame(ChessPiece[][] board, ChessPlayer whoseTurn)
        {
            Board = CloneBoard(board);
            _moves = new List<DetailedMove>();
            WhoseTurn = whoseTurn;
            ChessPiece e1 = GetPieceAt(ChessFile.E, 1);
            ChessPiece e8 = GetPieceAt(ChessFile.E, 8);
            ChessPiece a1 = GetPieceAt(ChessFile.A, 1);
            ChessPiece h1 = GetPieceAt(ChessFile.H, 1);
            ChessPiece a8 = GetPieceAt(ChessFile.A, 8);
            ChessPiece h8 = GetPieceAt(ChessFile.H, 8);
            CanBlackCastleKingSide = CanBlackCastleQueenSide = CanWhiteCastleKingSide = CanWhiteCastleQueenSide = CastlingCanBeLegal;
            if (CastlingCanBeLegal)
            {
                if (!(e1 is King) || e1.Owner != ChessPlayer.White)
                    CanWhiteCastleKingSide = CanWhiteCastleQueenSide = false;
                if (!(e8 is King) || e8.Owner != ChessPlayer.Black)
                    CanBlackCastleKingSide = CanBlackCastleQueenSide = false;
                if (!(a1 is Rook) || a1.Owner != ChessPlayer.White)
                    CanWhiteCastleQueenSide = false;
                if (!(h1 is Rook) || h1.Owner != ChessPlayer.White)
                    CanWhiteCastleKingSide = false;
                if (!(a8 is Rook) || a8.Owner != ChessPlayer.Black)
                    CanBlackCastleQueenSide = false;
                if (!(h8 is Rook) || h8.Owner != ChessPlayer.Black)
                    CanBlackCastleKingSide = false;
            }
        }

        protected virtual void UseGameCreationData(GameCreationData data)
        {
            Board = CloneBoard(data.Board);
            WhoseTurn = data.WhoseTurn;
            ChessPiece e1 = GetPieceAt(ChessFile.E, 1);
            ChessPiece e8 = GetPieceAt(ChessFile.E, 8);
            ChessPiece a1 = GetPieceAt(ChessFile.A, 1);
            ChessPiece h1 = GetPieceAt(ChessFile.H, 1);
            ChessPiece a8 = GetPieceAt(ChessFile.A, 8);
            ChessPiece h8 = GetPieceAt(ChessFile.H, 8);
            CanBlackCastleKingSide = CanBlackCastleQueenSide = CanWhiteCastleKingSide = CanWhiteCastleQueenSide = CastlingCanBeLegal;
            if (CastlingCanBeLegal)
            {
                if (!(e1 is King) || e1.Owner != ChessPlayer.White)
                    CanWhiteCastleKingSide = CanWhiteCastleQueenSide = false;
                if (!(e8 is King) || e8.Owner != ChessPlayer.Black)
                    CanBlackCastleKingSide = CanBlackCastleQueenSide = false;
                if (!(a1 is Rook) || a1.Owner != ChessPlayer.White || !data.CanWhiteCastleQueenSide)
                    CanWhiteCastleQueenSide = false;
                if (!(h1 is Rook) || h1.Owner != ChessPlayer.White || !data.CanWhiteCastleKingSide)
                    CanWhiteCastleKingSide = false;
                if (!(a8 is Rook) || a8.Owner != ChessPlayer.Black || !data.CanBlackCastleQueenSide)
                    CanBlackCastleQueenSide = false;
                if (!(h8 is Rook) || h8.Owner != ChessPlayer.Black || !data.CanBlackCastleKingSide)
                    CanBlackCastleKingSide = false;
            }

            if (data.EnPassant != null)
            {
                DetailedMove latestMove = new DetailedMove(new Move(new BoardPosition(data.EnPassant.File, data.WhoseTurn == ChessPlayer.White ? 7 : 2),
                                                                    new BoardPosition(data.EnPassant.File, data.WhoseTurn == ChessPlayer.White ? 5 : 4),
                                                                    ChessUtility.GetOpponentOf(data.WhoseTurn)),
                                          new Pawn(ChessUtility.GetOpponentOf(data.WhoseTurn)),
                                          false,
                                          CastlingType.None);
                _moves.Add(latestMove);
            }

            _halfMoveClock = data.HalfMoveClock;
            _fullMoveNumber = data.FullMoveNumber;
        }

        public virtual string GetFen()
        {
            StringBuilder fenBuilder = new StringBuilder();
            ChessPiece[][] board = GetBoard();
            for (int i = 0; i < board.Length; i++)
            {
                ChessPiece[] row = board[i];
                int empty = 0;
                foreach (ChessPiece piece in row)
                {
                    char pieceChar = piece == null ? '\0' : piece.GetFENLetter();
                    if (pieceChar == '\0')
                    {
                        empty++;
                        continue;
                    }
                    if (empty != 0)
                    {
                        fenBuilder.Append(empty);
                        empty = 0;
                    }
                    fenBuilder.Append(pieceChar);
                }
                if (empty != 0)
                {
                    fenBuilder.Append(empty);
                }
                if (i != board.Length - 1)
                {
                    fenBuilder.Append('/');
                }
            }

            fenBuilder.Append(' ');

            fenBuilder.Append(WhoseTurn == ChessPlayer.White ? 'w' : 'b');

            fenBuilder.Append(' ');

            bool hasAnyCastlingOptions = false;


            if (CanWhiteCastleKingSide)
            {
                fenBuilder.Append('K');
                hasAnyCastlingOptions = true;
            }
            if (CanWhiteCastleQueenSide)
            {
                fenBuilder.Append('Q');
                hasAnyCastlingOptions = true;
            }


            if (CanBlackCastleKingSide)
            {
                fenBuilder.Append('k');
                hasAnyCastlingOptions = true;
            }
            if (CanBlackCastleQueenSide)
            {
                fenBuilder.Append('q');
                hasAnyCastlingOptions = true;
            }
            if (!hasAnyCastlingOptions)
            {
                fenBuilder.Append('-');
            }

            fenBuilder.Append(' ');

            DetailedMove last;
            if (Moves.Count > 0 && (last = Moves[Moves.Count - 1]).Piece is Pawn && Math.Abs(last.OriginalPosition.Rank - last.NewPosition.Rank) == 2
                && last.OriginalPosition.Rank == (last.Player == ChessPlayer.White ? 2 : 7))
            {
                fenBuilder.Append(last.NewPosition.File.ToString().ToLowerInvariant());
                fenBuilder.Append(last.Player == ChessPlayer.White ? 3 : 6);
            }
            else
            {
                fenBuilder.Append("-");
            }

            fenBuilder.Append(' ');

            fenBuilder.Append(_halfMoveClock);

            fenBuilder.Append(' ');

            fenBuilder.Append(_fullMoveNumber);

            return fenBuilder.ToString();
        }

        protected virtual string GetPosition()
        {
            StringBuilder fenBuilder = new StringBuilder();
            ChessPiece[][] board = GetBoard();
            for (int i = 0; i < board.Length; i++)
            {
                ChessPiece[] row = board[i];
                int empty = 0;
                foreach (ChessPiece piece in row)
                {
                    char pieceChar = piece == null ? '\0' : piece.GetFENLetter();
                    if (pieceChar == '\0')
                    {
                        empty++;
                        continue;
                    }
                    if (empty != 0)
                    {
                        fenBuilder.Append(empty);
                        empty = 0;
                    }
                    fenBuilder.Append(pieceChar);
                }
                if (empty != 0)
                {
                    fenBuilder.Append(empty);
                }
                if (i != board.Length - 1)
                {
                    fenBuilder.Append('/');
                }
            }

            fenBuilder.Append(' ');

            fenBuilder.Append(WhoseTurn == ChessPlayer.White ? 'w' : 'b');

            fenBuilder.Append(' ');

            bool hasAnyCastlingOptions = false;


            if (CanWhiteCastleKingSide)
            {
                fenBuilder.Append('K');
                hasAnyCastlingOptions = true;
            }
            if (CanWhiteCastleQueenSide)
            {
                fenBuilder.Append('Q');
                hasAnyCastlingOptions = true;
            }


            if (CanBlackCastleKingSide)
            {
                fenBuilder.Append('k');
                hasAnyCastlingOptions = true;
            }
            if (CanBlackCastleQueenSide)
            {
                fenBuilder.Append('q');
                hasAnyCastlingOptions = true;
            }
            if (!hasAnyCastlingOptions)
            {
                fenBuilder.Append('-');
            }

            fenBuilder.Append(' ');

            DetailedMove last;
            if (Moves.Count > 0 && (last = Moves[Moves.Count - 1]).Piece is Pawn && Math.Abs(last.OriginalPosition.Rank - last.NewPosition.Rank) == 2
                && last.OriginalPosition.Rank == (last.Player == ChessPlayer.White ? 2 : 7))
            {
                fenBuilder.Append(last.NewPosition.File.ToString().ToLowerInvariant());
                fenBuilder.Append(last.Player == ChessPlayer.White ? 3 : 6);
            }
            else
            {
                fenBuilder.Append("-");
            }

            return fenBuilder.ToString();
        }

        protected virtual GameCreationData FenStringToGameCreationData(string fen)
        {
            Dictionary<char, ChessPiece> fenMappings = FenMappings;
            string[] parts = fen.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (!AllowedFenPartsLength.Contains(parts.Length)) throw new ArgumentException("The FEN string has too much, or too few, parts.");
            ChessPiece[][] board = new ChessPiece[8][];
            string[] rows = parts[0].Split('/');
            if (rows.Length != 8) throw new ArgumentException("The board in the FEN string does not have 8 rows.");
            GameCreationData data = new GameCreationData();
            for (int i = 0; i < 8; i++)
            {
                string row = rows[i];
                ChessPiece[] currentRow = new ChessPiece[8] { null, null, null, null, null, null, null, null };
                int j = 0;
                foreach (char c in row)
                {
                    if (char.IsDigit(c))
                    {
                        j += (int)char.GetNumericValue(c);
                        continue;
                    }
                    if (!fenMappings.ContainsKey(c)) throw new ArgumentException("The FEN string contains an unknown piece.");
                    currentRow[j] = fenMappings[c];
                    j++;
                }
                if (j != 8)
                {
                    throw new ArgumentException("Not enough pieces provided for a row in the FEN string.");
                }
                board[i] = currentRow;
            }
            data.Board = board;

            if (parts[1] == "w")
            {
                data.WhoseTurn = ChessPlayer.White;
            }
            else if (parts[1] == "b")
            {
                data.WhoseTurn = ChessPlayer.Black;
            }
            else
            {
                throw new ArgumentException("Expected `w` or `b` for the active player in the FEN string.");
            }

            if (parts[2].Contains('K')) data.CanWhiteCastleKingSide = true;
            else data.CanWhiteCastleKingSide = false;

            if (parts[2].Contains('Q')) data.CanWhiteCastleQueenSide = true;
            else data.CanWhiteCastleQueenSide = false;

            if (parts[2].Contains('k')) data.CanBlackCastleKingSide = true;
            else data.CanBlackCastleKingSide = false;

            if (parts[2].Contains('q')) data.CanBlackCastleQueenSide = true;
            else data.CanBlackCastleQueenSide = false;

            if (parts[3] == "-") data.EnPassant = null;
            else
            {
                BoardPosition ep = new BoardPosition(parts[3]);
                if ((data.WhoseTurn == ChessPlayer.White && (ep.Rank != 6 || !(data.Board[3][(int)ep.File] is Pawn))) ||
                    (data.WhoseTurn == ChessPlayer.Black && (ep.Rank != 3 || !(data.Board[4][(int)ep.File] is Pawn))))
                {
                    throw new ArgumentException("Invalid en passant field in FEN.");
                }
                data.EnPassant = ep;
            }

            if (int.TryParse(parts[4], out int halfmoveClock))
            {
                data.HalfMoveClock = halfmoveClock;
            }
            else
            {
                throw new ArgumentException("Halfmove clock in FEN is invalid.");
            }

            if (int.TryParse(parts[5], out int fullMoveNumber))
            {
                data.FullMoveNumber = fullMoveNumber;
            }
            else
            {
                throw new ArgumentException("Fullmove number in FEN is invalid.");
            }

            return data;
        }

        public ChessPiece GetPieceAt(BoardPosition position)
        {
            ChessUtility.ThrowIfNull(position, "position");
            return GetPieceAt(position.File, position.Rank);
        }

        public ChessPiece GetPieceAt(ChessFile file, int rank)
        {
            return Board[8 - rank][(int)file];
        }

        protected virtual void SetPieceAt(ChessFile file, int rank, ChessPiece piece)
        {
            Board[8 - rank][(int)file] = piece;
        }

        public bool IsValidMove(Move move)
        {
            ChessUtility.ThrowIfNull(move, "move");
            return IsValidMove(move, true, true);
        }

        protected bool IsValidMove(Move move, bool validateCheck)
        {
            ChessUtility.ThrowIfNull(move, "move");
            return IsValidMove(move, validateCheck, true);
        }

        public bool CheckforAdjudication(ref Adjudication reason)
        {
            bool isDraw = true;

            if (IsStalemated(WhoseTurn))
            {
                reason = Adjudication.Stalemate;
            }
            else if (!HasSufficientMaterial())
            {
                reason = Adjudication.InsufficientMaterial;
            }
            else if (Is3Fold())
            {
                reason = Adjudication.Repetition;
            }
            else if (fiftyMoves)
            {
                reason = Adjudication.FiftyMoveRule;
            }
            else if (drawAdjudication)
            {
                reason = Adjudication.Draw;
            }
            else if (resignAdjudication)
            {
                reason = Adjudication.Resign;
            }
            else
            {
                isDraw = false;
            }

            return isDraw;
        }

        protected virtual bool IsValidMove(Move move, bool validateCheck, bool careAboutWhoseTurnItIs)
        {
            ChessUtility.ThrowIfNull(move, "move");
            if (move.OriginalPosition.Equals(move.NewPosition))
                return false;
            ChessPiece piece = GetPieceAt(move.OriginalPosition.File, move.OriginalPosition.Rank);
            if (careAboutWhoseTurnItIs && move.Player != WhoseTurn) return false;
            if (piece == null || piece.Owner != move.Player) return false;
            ChessPiece pieceAtDestination = GetPieceAt(move.NewPosition);
            if (pieceAtDestination != null && pieceAtDestination.Owner == move.Player)
            {
                return false;
            }
            if (!piece.IsLegalMove(move, this))
            {
                return false;
            }
            if (validateCheck && WouldBeInCheckAfter(move, move.Player))
            {
                return false;
            }

            return true;
        }

        protected virtual CastlingType ApplyCastle(Move move)
        {
            CastlingType castle;
            int rank = move.Player == ChessPlayer.White ? 1 : 8;
            ChessFile rookFile;
            ChessFile newRookFile;
            if (move.NewPosition.File == ChessFile.C)
            {
                castle = CastlingType.QueenSide;
                rookFile = ChessFile.A;
                newRookFile = ChessFile.D;
            }
            else
            {
                castle = CastlingType.KingSide;
                rookFile = ChessFile.H;
                newRookFile = ChessFile.F;
            }
            SetPieceAt(newRookFile, rank, new Rook(move.Player));
            SetPieceAt(rookFile, rank, null);
            return castle;
        }

        public virtual MoveType ApplyMove(Move move, bool alreadyValidated)
        {
            ChessUtility.ThrowIfNull(move, "move");
            if (!alreadyValidated && !IsValidMove(move))
                return MoveType.Invalid;
            MoveType type = MoveType.Move;
            ChessPiece movingPiece = GetPieceAt(move.OriginalPosition.File, move.OriginalPosition.Rank);
            ChessPiece capturedPiece = GetPieceAt(move.NewPosition.File, move.NewPosition.Rank);
            ChessPiece newPiece = movingPiece;
            bool isCapture = capturedPiece != null;
            CastlingType castle = CastlingType.None;
            if (movingPiece is Pawn)
            {
                _halfMoveClock = 0;
                BoardDistance pd = new BoardDistance(move.OriginalPosition, move.NewPosition);
                if (pd.X == 1 && pd.Y == 1 && GetPieceAt(move.NewPosition) == null)
                { // en passant
                    isCapture = true;
                    SetPieceAt(move.NewPosition.File, move.OriginalPosition.Rank, null);
                }
                if (move.NewPosition.Rank == (move.Player == ChessPlayer.White ? 8 : 1))
                {
                    newPiece = MapPgnCharToPiece(move.Promotion.Value, move.Player);
                    type |= MoveType.Promotion;
                }
            }
            else if (movingPiece is King)
            {
                if (movingPiece.Owner == ChessPlayer.White)
                    CanWhiteCastleKingSide = CanWhiteCastleQueenSide = false;
                else
                    CanBlackCastleKingSide = CanBlackCastleQueenSide = false;

                if (new BoardDistance(move.OriginalPosition, move.NewPosition).X == 2 && CastlingCanBeLegal)
                {
                    castle = ApplyCastle(move);
                    type |= MoveType.Castling;
                }
            }
            else if (movingPiece is Rook)
            {
                if (move.Player == ChessPlayer.White)
                {
                    if (move.OriginalPosition.File == ChessFile.A && move.OriginalPosition.Rank == 1)
                        CanWhiteCastleQueenSide = false;
                    else if (move.OriginalPosition.File == ChessFile.H && move.OriginalPosition.Rank == 1)
                        CanWhiteCastleKingSide = false;
                }
                else
                {
                    if (move.OriginalPosition.File == ChessFile.A && move.OriginalPosition.Rank == 8)
                        CanBlackCastleQueenSide = false;
                    else if (move.OriginalPosition.File == ChessFile.H && move.OriginalPosition.Rank == 8)
                        CanBlackCastleKingSide = false;
                }
            }
            if (isCapture)
            {
                type |= MoveType.Capture;
                _halfMoveClock = 0;
                if (move.NewPosition.File == ChessFile.A && move.NewPosition.Rank == 1)
                    CanWhiteCastleQueenSide = false;
                else if (move.NewPosition.File == ChessFile.H && move.NewPosition.Rank == 1)
                    CanWhiteCastleKingSide = false;
                else if (move.NewPosition.File == ChessFile.A && move.NewPosition.Rank == 8)
                    CanBlackCastleQueenSide = false;
                else if (move.NewPosition.File == ChessFile.H && move.NewPosition.Rank == 8)
                    CanBlackCastleKingSide = false;
            }
            if (!isCapture && !(movingPiece is Pawn))
            {
                _halfMoveClock++;
                if (_halfMoveClock >= 100)
                {
                    fiftyMoves = true;
                }
                else
                {
                    fiftyMoves = false;
                }
            }
            if (move.Player == ChessPlayer.Black)
            {
                _fullMoveNumber++;
            }
            SetPieceAt(move.NewPosition.File, move.NewPosition.Rank, newPiece);
            SetPieceAt(move.OriginalPosition.File, move.OriginalPosition.Rank, null);
            WhoseTurn = ChessUtility.GetOpponentOf(move.Player);
            _moves.Add(new DetailedMove(move, movingPiece, isCapture, castle));
            _positions.Add(GetPosition());
            return type;
        }

        public ReadOnlyCollection<Move> GetValidMoves(BoardPosition from)
        {
            ChessUtility.ThrowIfNull(from, "from");
            return GetValidMoves(from, false);
        }

        protected virtual ReadOnlyCollection<Move> GetValidMoves(BoardPosition from, bool returnIfAny)
        {
            ChessUtility.ThrowIfNull(from, "from");
            ChessPiece piece = GetPieceAt(from);
            if (piece == null || piece.Owner != WhoseTurn) return new ReadOnlyCollection<Move>(new List<Move>());
            return piece.GetLegalMoves(from, returnIfAny, this, IsValidMove);
        }

        public ReadOnlyCollection<Move> GetValidMoves(ChessPlayer player)
        {
            return GetValidMoves(player, false);
        }

        protected virtual ReadOnlyCollection<Move> GetValidMoves(ChessPlayer player, bool returnIfAny)
        {
            if (player != WhoseTurn) return new ReadOnlyCollection<Move>(new List<Move>());
            List<Move> validMoves = new List<Move>();
            for (int r = 1; r <= Board.Length; r++)
            {
                for (int f = 0; f < Board[8 - r].Length; f++)
                {
                    ChessPiece p = GetPieceAt((ChessFile)f, r);
                    if (p != null && p.Owner == player)
                    {
                        validMoves.AddRange(GetValidMoves(new BoardPosition((ChessFile)f, r), returnIfAny));
                        if (returnIfAny && validMoves.Count > 0)
                        {
                            return new ReadOnlyCollection<Move>(validMoves);
                        }
                    }
                }
            }
            return new ReadOnlyCollection<Move>(validMoves);
        }

        public virtual bool HasAnyValidMoves(BoardPosition from)
        {
            ChessUtility.ThrowIfNull(from, "from");
            ReadOnlyCollection<Move> validMoves = GetValidMoves(from, true);
            return validMoves.Count > 0;
        }

        public virtual bool HasAnyValidMoves(ChessPlayer player)
        {
            ReadOnlyCollection<Move> validMoves = GetValidMoves(player, true);
            return validMoves.Count > 0;
        }

        protected Cache<bool> inCheckCacheWhite = new Cache<bool>(false, -1);
        protected Cache<bool> inCheckCacheBlack = new Cache<bool>(false, -1);
        public virtual bool IsInCheck(ChessPlayer player)
        {
            if (player == ChessPlayer.None)
            {
                throw new ArgumentException("IsInCheck: Player.None is an invalid argument.");
            }
            Cache<bool> cache = player == ChessPlayer.White ? inCheckCacheWhite : inCheckCacheBlack;
            if (cache.CachedAt == Moves.Count)
            {
                return cache.Value;
            }

            BoardPosition kingPos = new BoardPosition(ChessFile.None, -1);

            for (int r = 1; r <= Board.Length; r++)
            {
                for (int f = 0; f < Board[8 - r].Length; f++)
                {
                    ChessPiece curr = GetPieceAt((ChessFile)f, r);
                    if (curr is King && curr.Owner == player)
                    {
                        kingPos = new BoardPosition((ChessFile)f, r);
                        break;
                    }
                }
                if (kingPos != new BoardPosition(ChessFile.None, -1))
                {
                    break;
                }
            }

            if (kingPos.File == ChessFile.None)
                return cache.UpdateCache(false, Moves.Count);

            for (int r = 1; r <= Board.Length; r++)
            {
                for (int f = 0; f < Board[8 - r].Length; f++)
                {
                    ChessPiece curr = GetPieceAt((ChessFile)f, r);
                    if (curr == null) continue;
                    ChessPlayer p = curr.Owner;
                    Move move = new Move(new BoardPosition((ChessFile)f, r), kingPos, p);
                    List<Move> moves = new List<Move>();
                    if (curr is Pawn && ((move.NewPosition.Rank == 8 && move.Player == ChessPlayer.White) || (move.NewPosition.Rank == 1 && move.Player == ChessPlayer.Black)))
                    {
                        moves.Add(new Move(move.OriginalPosition, move.NewPosition, move.Player, 'Q'));
                        moves.Add(new Move(move.OriginalPosition, move.NewPosition, move.Player, 'R'));
                        moves.Add(new Move(move.OriginalPosition, move.NewPosition, move.Player, 'B'));
                        moves.Add(new Move(move.OriginalPosition, move.NewPosition, move.Player, 'N'));
                        moves.Add(new Move(move.OriginalPosition, move.NewPosition, move.Player, 'K'));
                    }
                    else
                    {
                        moves.Add(move);
                    }
                    foreach (Move m in moves)
                    {
                        if (IsValidMove(m, false, false))
                        {
                            return cache.UpdateCache(true, Moves.Count);
                        }
                    }
                }
            }
            return cache.UpdateCache(false, Moves.Count);
        }

        protected Cache<bool> checkmatedCacheWhite = new Cache<bool>(false, -1);
        protected Cache<bool> checkmatedCacheBlack = new Cache<bool>(false, -1);
        public virtual bool IsCheckmated(ChessPlayer player)
        {
            Cache<bool> cache = player == ChessPlayer.White ? checkmatedCacheWhite : checkmatedCacheBlack;
            if (cache.CachedAt == Moves.Count)
            {
                return cache.Value;
            }

            return cache.UpdateCache(IsInCheck(player) && !HasAnyValidMoves(player), Moves.Count);
        }

        protected Cache<bool> stalematedCacheWhite = new Cache<bool>(false, -1);
        protected Cache<bool> stalematedCacheBlack = new Cache<bool>(false, -1);
        public virtual bool IsStalemated(ChessPlayer player)
        {
            Cache<bool> cache = player == ChessPlayer.White ? stalematedCacheWhite : stalematedCacheBlack;
            if (cache.CachedAt == Moves.Count)
            {
                return cache.Value;
            }

            return cache.UpdateCache(WhoseTurn == player && !IsInCheck(player) && !HasAnyValidMoves(player), Moves.Count);
        }

        public virtual bool IsWinner(ChessPlayer player)
        {
            return IsCheckmated(ChessUtility.GetOpponentOf(player));
        }

        public virtual bool WouldBeInCheckAfter(Move move, ChessPlayer player)
        {
            ChessUtility.ThrowIfNull(move, "move");
            GameCreationData gcd = new GameCreationData
            {
                Board = Board,
                CanWhiteCastleKingSide = CanWhiteCastleKingSide,
                CanWhiteCastleQueenSide = CanWhiteCastleQueenSide,
                CanBlackCastleKingSide = CanBlackCastleKingSide,
                CanBlackCastleQueenSide = CanBlackCastleQueenSide,
                EnPassant = null
            };
            if (_moves.Count > 0)
            {
                DetailedMove last = _moves.Last();
                if (last.Piece is Pawn && new BoardDistance(last.OriginalPosition, last.NewPosition).Y == 2)
                {
                    gcd.EnPassant = new BoardPosition(last.NewPosition.File, last.Player == ChessPlayer.White ? 3 : 6);
                }
            }
            gcd.HalfMoveClock = _halfMoveClock;
            gcd.FullMoveNumber = _fullMoveNumber;
            ChessGame copy = new ChessGame(gcd);
            copy.ApplyMove(move, true);
            return copy.IsInCheck(player);
        }
    }
}
