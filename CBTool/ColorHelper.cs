using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CBTool
{
    internal static class ColorHelper
    {
        public static Color HslToRgb(double Hue, double Saturation, double Lightness)
        {
            if (Hue < 0) Hue = 0.0;
            if (Saturation < 0) Saturation = 0.0;
            if (Lightness < 0) Lightness = 0.0;
            if (Hue >= 360) Hue = 359.0;
            if (Saturation > 255) Saturation = 255;
            if (Lightness > 255) Lightness = 255;
            Saturation = Saturation / 255.0;
            Lightness = Lightness / 255.0;
            double C = (1 - Math.Abs(2 * Lightness - 1)) * Saturation;
            double hh = Hue / 60.0;
            double X = C * (1 - Math.Abs(hh % 2 - 1));
            double r = 0, g = 0, b = 0;
            if (hh >= 0 && hh < 1)
            {
                r = C;
                g = X;
            }
            else if (hh >= 1 && hh < 2)
            {
                r = X;
                g = C;
            }
            else if (hh >= 2 && hh < 3)
            {
                g = C;
                b = X;
            }
            else if (hh >= 3 && hh < 4)
            {
                g = X;
                b = C;
            }
            else if (hh >= 4 && hh < 5)
            {
                r = X;
                b = C;
            }
            else
            {
                r = C;
                b = X;
            }
            double m = Lightness - C / 2;
            r += m;
            g += m;
            b += m;
            r = r * 255.0;
            g = g * 255.0;
            b = b * 255.0;
            r = Math.Round(r);
            g = Math.Round(g);
            b = Math.Round(b);
            return System.Drawing.Color.FromArgb((int)r, (int)g, (int)b);
        }

        //C#  RGB转HSL
        public static void RGBToHSL(Color AColor, ref double H, ref double S, ref double L)
        {
            double r = AColor.R;
            double g = AColor.G;
            double b = AColor.B;
            if (r < 0) r = 0;
            if (g < 0) g = 0;
            if (b < 0) b = 0;
            if (r > 255) r = 255;
            if (g > 255) g = 255;
            if (b > 255) b = 255;
            r = r / 255;
            g = g / 255;
            b = b / 255;
            double M = Math.Max(Math.Max(r, g), b);
            double m = Math.Min(Math.Min(r, g), b);
            double d = M - m;
            if (d == 0) H = 0;
            else if (M == r) H = ((g - b) / d) % 6;
            else if (M == g) H = (b - r) / d + 2;
            else H = (r - g) / d + 4;
            H *= 60;
            if (H < 0) H += 360;
            L = (M + m) / 2;
            if (d == 0)
                S = 0;
            else
                S = d / (1 - Math.Abs(2 * L - 1));  //如果放大或者缩小  乘以或者除以相应的倍数
            S = S * 255;
            L = L * 255;
            //document.calcform.h.value = h.toFixed(0);
            //document.calcform.s.value = s.toFixed(1);
            //document.calcform.l.value = l.toFixed(1); //四舍五入的位数
            //document.calcform.color.style.backgroundColor = '#' + hex;
        }
    }
}
