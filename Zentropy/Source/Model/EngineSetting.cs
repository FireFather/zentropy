using System;

namespace Zentropy.Model
{
    [Serializable]
    public class EngineSetting
    {
        public string Name { get; set; }
        public string ExecutablePath { get; set; }
        public string LogoPath { get; set; }
        public string[] UciOptions { get; set; }
    }
}
