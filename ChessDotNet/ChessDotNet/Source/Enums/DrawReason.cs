using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessDotNet
{
    public enum Adjudication
    {
        Repetition,
        FiftyMoveRule,
        Stalemate,
        InsufficientMaterial,
        Draw,
        Resign
    }
}
