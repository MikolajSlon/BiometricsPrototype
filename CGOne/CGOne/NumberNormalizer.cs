using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGOne
{
    class NumberNormalizer
    {
        NumberNormalizer()
        {
        }
        public static int Normalize(int number)
        {
            if (number > 255)
            {
                number = 255;
            }
            if (number < 0)
            {
                number = 0;
            }
            return number;
        }
        public static int Normalize(int number,int bound)
        {
            if (number >= bound)
            {
                number = bound-1;
            }
            if (number < 0)
            {
                number = 0;
            }
            return number;
        }
        public static int Normalize(double number)
        {
            if (number > 255)
            {
                number = 255;
            }
            if (number < 0)
            {
                number = 0;
            }
            return Convert.ToInt32(number);
        }
    }
}
