using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGOne
{
    public class Dithering
    {
        protected int _treshold;
        public Dithering(int treshold)
        {
            this._treshold = treshold;
        }

        public Color calculatePixel(Color c)
        {
            if(GrayScale.toGrayscale(c) < _treshold)
            {
                return Color.Black;
            }
            else
            {
                return Color.White;
            }
        }
    }
}
