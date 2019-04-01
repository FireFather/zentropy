using System;

namespace ChessEngineInterface
{
    public class Evaluation
    {
        public InfoType[] Types { get; private set; }

        private readonly string[] _values;

        public string this[InfoType type]
        {
            get
            {
                for (int i = 0; i < Types.Length; i++)
                {
                    if(Types[i] == type)
                    {
                        return _values[i];
                    }
                }

                return null;
            }
        }

        public string this[int index]
        {
            get
            {
                return _values[index];
            }
        }

        public Evaluation(InfoType[] types, string[] values)
        {
            Types = types;
            _values = values;
        }
    }
}
