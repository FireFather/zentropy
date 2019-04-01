using System;
using System.Drawing;

namespace Zentropy.View
{
    public class MoveArrow
    {
        public bool HasStartCircle { get; set; }
        public bool IsAbovePieces { get; set; }
        public double ThicknessPercent { get; set; }
        public string Move { get; set; }
        public Color Color { get; set; }

        public MoveArrow(string move, double thickness, Color color, bool abovePieces, bool hasStartCircle)
        {
            if(move.Length != 4)
            {
                throw new ArgumentException("Move must have length of 4.");
            }

            Move = move;
            ThicknessPercent = thickness;
            Color = color;
            IsAbovePieces = abovePieces;
            HasStartCircle = hasStartCircle;
        }
    }
}