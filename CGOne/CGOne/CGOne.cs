using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CGOne
{
    public partial class Form1 : Form
    {
        BindableMap picture;
        Kernel currentKernel = new Kernel(5,5);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picture = new BindableMap();
                picture.Bitmap = new Bitmap(dlg.FileName);
                pictureBox1.Image = picture.Bitmap;
                populateCharts(picture.Bitmap);
                //picture = new Bitmap(picture, new Size(pictureBox1.Width, pictureBox1.Height));
                //pictureBox1.DataBindings.Add("Image", picture,"Bitmap",false );
            }

            dlg.Dispose();
        
        }

        private void brightness_Click(object sender, EventArgs e)
        {
            int constant = Convert.ToInt32(brightnessTextBox.Text);
            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    Color newColor = picture.Bitmap.GetPixel(i, j);
                    newColor = Color.FromArgb(NumberNormalizer.Normalize(newColor.R + constant), NumberNormalizer.Normalize(newColor.G + constant), NumberNormalizer.Normalize(newColor.B + constant));
                    picture.Bitmap.SetPixel(i, j, newColor);
                }
            }
            pictureBox1.Refresh();
        }

        private void Contrast_Click(object sender, EventArgs e)
        {
           double constant = Convert.ToDouble(ContrastTextBox.Text);
            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    Color newColor = picture.Bitmap.GetPixel(i, j);
                    newColor = Color.FromArgb(NumberNormalizer.Normalize(Math.Pow(newColor.R, constant)),
                    NumberNormalizer.Normalize( Math.Pow(newColor.G , constant)),
                    NumberNormalizer.Normalize( Math.Pow(newColor.B , constant)));
                    picture.Bitmap.SetPixel(i, j, newColor);
                }
            }
            pictureBox1.Refresh();
        }

        private void Negation_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    Color newColor = picture.Bitmap.GetPixel(i, j);
                    newColor = Color.FromArgb(NumberNormalizer.Normalize(255 - newColor.R), NumberNormalizer.Normalize(255 -newColor.G ), NumberNormalizer.Normalize(255 -newColor.B));
                    picture.Bitmap.SetPixel(i, j, newColor);
                }
            }
            pictureBox1.Refresh();
        }

        private void Blur_Click(object sender, EventArgs e)
        {
            currentKernel.setKernelBlur();

            Bitmap newImage = ApplyKernel();
            picture.Bitmap = newImage;
            pictureBox1.Image = newImage;
            pictureBox1.Refresh();
            
        }
        private int[,] createNeighbours(int i, int j)
        {
            int[,] neighbours = new int[Kernel.MAXINDEX, Kernel.MAXINDEX];
            for (int x = 0; x < currentKernel.sizeX; x++)
            {
                for (int y = 0; y < currentKernel.sizeY; y++)
                {
                    neighbours[x, y] = picture.Bitmap.GetPixel(
                        NumberNormalizer.Normalize(i - currentKernel.anchor.Item1 + x, picture.Bitmap.Width),
                        NumberNormalizer.Normalize(j - currentKernel.anchor.Item2 + y, picture.Bitmap.Height)
                        ).ToArgb();
                }
            }
            return neighbours;
        }

        private Bitmap ApplyKernel()
        {
            Bitmap newImage = new Bitmap(picture.Bitmap.Width, picture.Bitmap.Height);


            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {

                    int[,] neighbours = createNeighbours(i, j);
                    newImage.SetPixel(i, j, Color.FromArgb(currentKernel.calculate(neighbours)));
                }
            }
            return newImage;
        }
        private void Smooth_Click(object sender, EventArgs e)
        {
            currentKernel.setKernelGaussianSmoothing();
            Bitmap newImage = ApplyKernel();
            picture.Bitmap = newImage;
            pictureBox1.Image = newImage;
            pictureBox1.Refresh();
        }

        private void Create_Custom_Kernel_Click(object sender, EventArgs e)
        {
            CustomKernel customKernel = new CustomKernel(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox4.Text));
            customKernel.ShowDialog();
            currentKernel = ShareKernel.kern;
        }

        private void ApplyKernel_Click(object sender, EventArgs e)
        {
            Bitmap newImage = ApplyKernel();
            picture.Bitmap = newImage;
            pictureBox1.Image = newImage;
            pictureBox1.Refresh();
        }

        private void Sharpen_Click(object sender, EventArgs e)
        {
            currentKernel.setKernelSharpen();
            Bitmap newImage = ApplyKernel();
            picture.Bitmap = newImage;
            pictureBox1.Image = newImage;
            pictureBox1.Refresh();
        }

        private void MeanRemoval_Click(object sender, EventArgs e)
        {
            currentKernel.setKernelMeanRemoval();
            Bitmap newImage = ApplyKernel();
            picture.Bitmap = newImage;
            pictureBox1.Image = newImage;
            pictureBox1.Refresh();
        }

        private void EdgeDetection_Click(object sender, EventArgs e)
        {
            currentKernel.setKernelEdgeDetection();
            Bitmap newImage = ApplyKernel();
            picture.Bitmap = newImage;
            pictureBox1.Image = newImage;
            pictureBox1.Refresh();
        }

        private void Emboss_Click(object sender, EventArgs e)
        {
            currentKernel.setKernelEmboss();
            Bitmap newImage = ApplyKernel();
            picture.Bitmap = newImage;
            pictureBox1.Image = newImage;
            pictureBox1.Refresh();
        }

        private void applyContrastButton_Click(object sender, EventArgs e)
        {
            
            double constant = Convert.ToDouble(TrueContrastTextBox.Text);
            Bitmap newImage = new Bitmap(picture.Bitmap.Width, picture.Bitmap.Height);

            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    Color newColor = picture.Bitmap.GetPixel(i, j);
                    newColor = Color.FromArgb(NumberNormalizer.Normalize((newColor.R - 127) * constant + 127), NumberNormalizer.Normalize((newColor.G - 127) * constant + 127), NumberNormalizer.Normalize((newColor.B - 127) * constant + 127));
                    newImage.SetPixel(i, j, newColor);
                }
            }
            picture.Bitmap = newImage;
            pictureBox1.Image = newImage;
            pictureBox1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentKernel.setKernelBlur();
            Bitmap newImage = new Bitmap(picture.Bitmap.Width, picture.Bitmap.Height);


            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {

                    int[,] neighbours = createNeighbours(i, j);
                    newImage.SetPixel(i, j, Color.FromArgb(currentKernel.calculateMedian(neighbours)));
                }
            }
            picture.Bitmap = newImage;
            pictureBox1.Image = newImage;
            pictureBox1.Refresh();
        }

        private void TreshholdClick(object sender, EventArgs e)
        {
            int k = 6;
            double t = 0.5;
            TreshholdProvider treshholdProvider = new TreshholdProvider(k, t);

            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    Color color = picture.Bitmap.GetPixel(i, j);
                    Color newColor = treshholdProvider.processPixel(color);
                    picture.Bitmap.SetPixel(i, j, newColor);
                }
            }
            pictureBox1.Refresh();
        }

        private void averageDitheringButton_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(averageDitheringTxt.Text);
            TreshholdProvider tresh = new TreshholdProvider(k);
            tresh.calCulateTresholds(picture.Bitmap);
            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    Color color = picture.Bitmap.GetPixel(i, j);
                    Color newColor = tresh.processPixelAverageDithering(color);
                    picture.Bitmap.SetPixel(i, j, newColor);
                }
            }
            pictureBox1.Refresh();
        }

        private void kQuantizationButton_Click(object sender, EventArgs e)
        {
            Task runParalel = new Task(() => quantization());
            runParalel.Start();
        }

        private void quantization()
        {
            int k = Convert.ToInt32(kQuantizationTxt.Text);
            Quantizator quant = new Quantizator(k, picture.Bitmap);
            Bitmap newImage = quant.applyChanges();
            picture.Bitmap = newImage;
            pictureBox1.Image = newImage;
        }
        private void populateCharts(Bitmap bmp)
        {
            chart1.Series.Clear();
            chart2.Series.Clear();
            Series chart1R = new Series();
            Series chart1G = new Series();
            Series chart1B = new Series();
            Series chart2R = new Series();
            Series chart2G = new Series();
            Series chart2B = new Series();
            chart2R.ChartType = SeriesChartType.Bar;
            chart2G.ChartType = SeriesChartType.Bar;
            chart2B.ChartType = SeriesChartType.Bar;
            for (int i = 0; i < bmp.Width; i++)
            {
                int R = 0;
                int G = 0;
                int B = 0;
                for (int j = 0; j < bmp.Height; j++)
                {
                    R += bmp.GetPixel(i, j).R;
                    G += bmp.GetPixel(i, j).G;
                    B += bmp.GetPixel(i, j).B;
                }
                chart1R.Points.AddXY(i, R);
                chart1R.Points[i].Color = Color.Red;
                chart1G.Points.AddXY(i, G);
                chart1G.Points[i].Color = Color.Green;
                chart1B.Points.AddXY(i, B);
                chart1B.Points[i].Color = Color.Blue;
            }
            for (int i = 0; i < bmp.Height; i++)
            {
                int R = 0;
                int G = 0;
                int B = 0;
                for (int j = 0; j < bmp.Width; j++)
                {
                    R += bmp.GetPixel(j, i).R;
                    G += bmp.GetPixel(j, i).G;
                    B += bmp.GetPixel(j, i).B;
                }
                chart2R.Points.AddXY(i, R);
                chart2R.Points[i].Color = Color.Red;
                chart2G.Points.AddXY(i, G);
                chart2G.Points[i].Color = Color.Green;
                chart2B.Points.AddXY(i, B);
                chart2B.Points[i].Color = Color.Blue;
            }
            chart1.Series.Add(chart1R);
            chart1.Series.Add(chart1G);
            chart1.Series.Add(chart1B);
            chart2.Series.Add(chart2R);
            chart2.Series.Add(chart2G);
            chart2.Series.Add(chart2B);

        }

        private void GrayscaleButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    Color color = picture.Bitmap.GetPixel(i, j);
                    Color newColor = Color.FromArgb(GrayScale.toGrayscale(color), GrayScale.toGrayscale(color), GrayScale.toGrayscale(color));
                    picture.Bitmap.SetPixel(i, j, newColor);
                }
            }
            pictureBox1.Refresh();
        }
    }
}
