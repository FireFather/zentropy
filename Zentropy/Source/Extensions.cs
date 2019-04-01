using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace Zentropy
{
    public static class Extensions
    {
        public static void SetDoubleBuffered(this Control control)
        {
            if (SystemInformation.TerminalServerSession)
                return;

            PropertyInfo property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
            property?.SetValue(control, true, null);
        }

        public static void FitFont(this Control control, double widthFactor, double heightFactor)
        {
            int fontSize = 1;
            Size size = TextRenderer.MeasureText(control.Text, new Font(control.Font.FontFamily, fontSize));

            double factorWidth = control.Width * widthFactor;
            double factorHeight = control.Height * heightFactor;

            while (size.Width < factorWidth && size.Height < factorHeight && size.Width != 0 && size.Height != 0)
            {
                fontSize++;
                size = TextRenderer.MeasureText(control.Text, new Font(control.Font.FontFamily, fontSize));
            }

            control.Font = new Font(control.Font.FontFamily, fontSize);
        }

        public static int CapRange(this int number, int bottomCap, int topCap)
        {
            number = Math.Min(number, topCap);
            number = Math.Max(number, bottomCap);
            return number;
        }

        public static Color AlterRgb(this Color color, int amount, bool isAddition)
        {
            if (!isAddition)
                amount = -amount;

            int r = (color.R + amount).CapRange(0, 255);
            int g = (color.G + amount).CapRange(0, 255);
            int b = (color.B + amount).CapRange(0, 255);
            return Color.FromArgb(r, g, b);
        }
    }
}
