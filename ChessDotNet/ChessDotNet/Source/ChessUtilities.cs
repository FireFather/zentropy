using System;

namespace ChessDotNet
{
    public static class ChessUtility
    {
        internal static void ThrowIfNull(object value, string parameterName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName);
            }
        }

        public static ChessPlayer GetOpponentOf(ChessPlayer player)
        {
            if (player == ChessPlayer.None)
                throw new ArgumentException("`player` cannot be Player.None.");
            return player == ChessPlayer.White ? ChessPlayer.Black : ChessPlayer.White;
        }
    }
}
