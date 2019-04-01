namespace Zentropy.Model
{
    public class ChessPly
    {
        public int EvaluationDepth { get; set; } = 0;
        public double Evaluation { get; set; }
        public string Fen { get; }
        public string Move { get; }
        public string ShortNotation { get; set; }

        public ChessPly(string fen, double evaluation = 0.00, string move = null, string shortNotation = null)
        {
            Fen = fen;
            Evaluation = evaluation;
            Move = move;
            ShortNotation = shortNotation;
        }
    }
}
