using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3
{
    public class Color
    {
        int Red { get; set; }
        int Blue { get; set; }
        int Green { get; set; }
        int Alpha { get; set; }
        public int GetRed()
        {
            return Red;
        }
        public void SetRed(int r)
        {
            Red = r;
        }
        public int GetBlue()
        {
            return Blue;
        }
        public void SetBlue(int b)
        {
            Blue = b;
        }
        public int GetGreen()
        {
            return Green;
        }
        public void SetGreen(int g)
        {
            Green = g;
        }
        public int GetAlpha()
        {
            return Alpha;
        }
        public void SetAlpha(int a)
        {
            Alpha = a;
        }
        public decimal GrayScale()
        {
            return (decimal)(Red + Green + Blue) / 3;
        }
        public Color(int red, int blue, int green, int alpha)
        {
            Red = red;
            Blue = blue;
            Green = green;
            Alpha = alpha;
        }
        public Color(int red, int blue, int green)
        {
            Red = red;
            Blue = blue;
            Green = green;
            Alpha = 255;
        }
    }
}
