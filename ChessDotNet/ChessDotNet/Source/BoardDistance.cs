using System;

namespace ChessDotNet
{
    public struct BoardDistance
    {
        public int X { get; }
        public int Y { get; }


        public BoardDistance(BoardPosition position, BoardPosition destination)
        {
            if (position == null)
            {
                throw new ArgumentNullException(nameof(position));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            X = Math.Abs((int)position.File - (int)destination.File);
            Y = Math.Abs(position.Rank - destination.Rank);
        }

        public override int GetHashCode()
        {
            return new { X, Y }.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            BoardDistance distance = (BoardDistance)obj;
            return X == distance.X && Y == distance.Y;
        }

        public static bool operator ==(BoardDistance distance1, BoardDistance distance2)
        {
            return distance1.Equals(distance2);
        }

        public static bool operator !=(BoardDistance distance1, BoardDistance distance2)
        {
            return !distance1.Equals(distance2);
        }
    }
}
