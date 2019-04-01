using System;
using System.Drawing;

namespace Zentropy.View
{
    public class MoveArrowDrawInfo
    {
        public MoveArrow Arrow { get; set; }
        public PointF[] Positions { get; set; }

        public float Length
        {
            get
            {
                if (Positions.Length > 1)
                {
                    return GetDistance(Math.Abs(Positions[0].X - Positions[1].X), Math.Abs(Positions[0].Y - Positions[1].Y));
                }

                return -1;
            }
        }

        private float GetDistance(float a, float b)
        {
            return (float)Math.Sqrt(a * a + b * b);
        }
    }
}
