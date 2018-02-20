using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGOne
{
    public static class GrayScale
    {
        public static int toGrayscale(Color color)
        {
            return Convert.ToInt32(color.R * 0.3 + color.G * 0.58 + 0.12 * color.B);
        }
    }
}
