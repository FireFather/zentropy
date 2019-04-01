using System;
using System.Globalization;

namespace ChessDotNet
{
    public class BoardPosition
    {
        public int Rank { get; }
        public ChessFile File { get; }


        public BoardPosition(ChessFile file, int rank)
        {
            File = file;
            Rank = rank;
        }

        public BoardPosition(string position)
        {
            if (position == null)
            {
                throw new ArgumentNullException(nameof(position));
            }

            if (position.Length != 2)
            {
                throw new ArgumentException($"Length of '{nameof(position)}' is not 2.");
            }

            position = position.ToUpperInvariant();

            char file = position[0];
            char rank = position[1];

            switch (file)
            {
                case 'A':
                    File = ChessFile.A;
                    break;
                case 'B':
                    File = ChessFile.B;
                    break;
                case 'C':
                    File = ChessFile.C;
                    break;
                case 'D':
                    File = ChessFile.D;
                    break;
                case 'E':
                    File = ChessFile.E;
                    break;
                case 'F':
                    File = ChessFile.F;
                    break;
                case 'G':
                    File = ChessFile.G;
                    break;
                case 'H':
                    File = ChessFile.H;
                    break;

                default:
                    throw new ArgumentException($"First char of '{nameof(position)}' not in range A-F.");
            }

            bool isNumber = int.TryParse(rank.ToString(), out int parsedRank);

            if (!(isNumber && parsedRank > 0 && parsedRank < 9))
            {
                throw new ArgumentException($"Second char of '{nameof(position)}' not in range 1-8.");
            }

            Rank = parsedRank;
        }


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

            BoardPosition position = (BoardPosition)obj;
            return File == position.File && Rank == position.Rank;
        }

        public override int GetHashCode()
        {
            return new { File, Rank }.GetHashCode();
        }

        public override string ToString()
        {
            return File.ToString().ToLowerInvariant() + Rank.ToString(CultureInfo.InvariantCulture);
        }

        public static bool operator ==(BoardPosition position1, BoardPosition position2)
        {
            if (ReferenceEquals(position1, position2))
            {
                return true;
            }

            if ((object)position1 == null || (object)position2 == null)
            {
                return false;
            }

            return position1.Equals(position2);
        }

        public static bool operator !=(BoardPosition position1, BoardPosition position2)
        {
            if (ReferenceEquals(position1, position2))
            {
                return false;
            }

            if ((object)position1 == null || (object)position2 == null)
            {
                return true;
            }

            return !position1.Equals(position2);
        }
    }
}
