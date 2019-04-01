using Zentropy.View;
using System;
using System.Windows.Forms;

namespace Zentropy
{
    public static class EntryPoint
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}