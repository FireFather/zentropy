using System;

namespace Zentropy.Model
{
    [Serializable]
    public class TimeControl
    {
        public TimeControlType SelectedTimeControlType { get; set; }
        public int Plies { get; set; }
        public long TimePerMove { get; set; }
        public long TotalTime { get; set; }
        public long Increment { get; set; }
        public long Nodes { get; set; }

        public TimeControl()
        {
            SelectedTimeControlType = TimeControlType.TimePerMove;
            Plies = 16;
            TimePerMove = 1000;
            TotalTime = 180000;
            Increment = 2000;
            Nodes = 1000000;
        }
    }
}
