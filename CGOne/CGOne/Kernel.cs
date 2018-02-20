using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGOne
{
    public class Kernel
    {
        public const int MAXINDEX = 9;
        public int sizeX;
        public int sizeY;
        public int divisor = 9;
        public int offset = 0;
        public Tuple<int, int> anchor = new Tuple<int, int>(1, 1);
        public int[,] kernel;
        public Kernel(int sizeX = 3, int sizeY = 3)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            kernel = new int[MAXINDEX, MAXINDEX]; 
            for(int i =0; i < sizeX; i++)
            {
                for(int j =0; j< sizeY; j++)
                {
                    kernel[i, j] = 1;
                }
            }
        }

        public void setKernelNode(int x, int y, int value)
        {
            kernel[x, y] = value;
        }

        public int calculate(int[,] neighbours)
        {
            int valR = 0;
            int valG = 0;
            int valB = 0;

            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    Color pix = Color.FromArgb(neighbours[i, j]);
                    valR += kernel[i, j] * pix.R;
                    valG += kernel[i, j] * pix.G;
                    valB += kernel[i, j] * pix.B;
                }
            }
            valR = NumberNormalizer.Normalize(valR / divisor + offset);
            valG = NumberNormalizer.Normalize(valG / divisor + offset);
            valB = NumberNormalizer.Normalize(valB / divisor + offset);
            Color pixel = Color.FromArgb(valR, valG, valB);
            
            return pixel.ToArgb();
        }

        public int calculateMedian(int[,] neighbours)
        {
            List<int> colors = new List<int>();
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    Color pix = Color.FromArgb(neighbours[i, j]);
                    colors.Add(ToGrayscale(pix));
                }
            }
            colors.Sort();
            Color temp =  Color.FromArgb(colors[colors.Count / 2], colors[colors.Count / 2], colors[colors.Count / 2]);
            return temp.ToArgb();
        }

        int[,] getKernel()
        {
            return kernel;
        }

        public void setKernelBlur()
        {
            sizeX = 3;
            sizeY = 3;
            offset = 0;
            anchor = new Tuple<int, int>(1, 1);
            divisor = 9;

            kernel[0, 0] = 1;
            kernel[1, 0] = 1;
            kernel[2, 0] = 1;

            kernel[0, 1] = 1;
            kernel[1, 1] = 1;
            kernel[2, 1] = 1;

            kernel[0, 2] = 1;
            kernel[1, 2] = 1;
            kernel[2, 2] = 1;
            ShareKernel.kern = this;
        }
        public void setKernelGaussianSmoothing()
        {
            sizeX = 3;
            sizeY = 3;
            offset = 0;
            anchor = new Tuple<int, int>(1, 1);
            divisor = 8;

            kernel[0, 0] = 0;
            kernel[1, 0] = 1;
            kernel[2, 0] = 0;

            kernel[0, 1] = 1;
            kernel[1, 1] = 4;
            kernel[2, 1] = 1;

            kernel[0, 2] = 0;
            kernel[1, 2] = 1;
            kernel[2, 2] = 0;
            ShareKernel.kern = this;

        }
        public void setKernelSharpen()
        {
            sizeX = 3;
            sizeY = 3;
            offset = 0;
            anchor = new Tuple<int, int>(1, 1);
            divisor = 1;

            kernel[0, 0] = 0;
            kernel[1, 0] = -1;
            kernel[2, 0] = 0;

            kernel[0, 1] = -1;
            kernel[1, 1] = 5;
            kernel[2, 1] = -1;

            kernel[0, 2] = 0;
            kernel[1, 2] = -1;
            kernel[2, 2] = 0;
            ShareKernel.kern = this;

        }
        public void setKernelMeanRemoval()
        {
            sizeX = 3;
            sizeY = 3;
            offset = 0;
            anchor = new Tuple<int, int>(1, 1);
            divisor = 1;

            kernel[0, 0] = -1;
            kernel[1, 0] = -1;
            kernel[2, 0] = -1;

            kernel[0, 1] = -1;
            kernel[1, 1] = 9;
            kernel[2, 1] = -1;

            kernel[0, 2] = -1;
            kernel[1, 2] = -1;
            kernel[2, 2] = -1;
            ShareKernel.kern = this;

        }
        public void setKernelEdgeDetection()
        {
            sizeX = 3;
            sizeY = 3;
            offset = 127;
            anchor = new Tuple<int, int>(1, 1);
            divisor = 1;

            kernel[0, 0] = -1;
            kernel[1, 0] = 0;
            kernel[2, 0] = 0;

            kernel[0, 1] = 0;
            kernel[1, 1] = 1;
            kernel[2, 1] = 0;

            kernel[0, 2] = 0;
            kernel[1, 2] = 0;
            kernel[2, 2] = 0;
            ShareKernel.kern = this;

        }
        public void setKernelEmboss()
        {
            sizeX = 3;
            sizeY = 3;
            offset = 0;
            anchor = new Tuple<int, int>(1, 1);
            divisor = 1;

            kernel[0, 0] = -1;
            kernel[1, 0] = 0;
            kernel[2, 0] = 1;

            kernel[0, 1] = -1;
            kernel[1, 1] = 1;
            kernel[2, 1] = 1;

            kernel[0, 2] = -1;
            kernel[1, 2] = 0;
            kernel[2, 2] = 1;
            ShareKernel.kern = this;

        }


        private int ToGrayscale(Color color)
        {
            return Convert.ToInt32(color.R * 0.3 + color.G * 0.58 + 0.12 * color.B);
        }
    }
}
