using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGOne
{
    public class Quantizator : IPixelProcessing
    {
        Random rnd;
        protected int _k;
        //protected List<List<Tuple<int,int>>> _groupedPixels;
        protected Dictionary<int, List<Tuple<int, int>>> _groupedPixels;

        protected List<Color> _means;
        protected Bitmap _map;
        public Quantizator(int k, Bitmap m)
        {
            bool flag = true; 
            this._k = k;
            this._map = m;
            _groupedPixels = new Dictionary<int, List<Tuple<int, int>>>();
            _means = new List<Color>();
            rnd = new Random();
            pickInitialMeans();
            while (flag)
            {
                assignMeans();
                flag = calculateMeans();
            }
        }

        public Bitmap applyChanges()
        {
            Bitmap map = new Bitmap(_map);
            
            foreach(var list in _groupedPixels)
            {
                foreach(var pix in list.Value)
                {
                    map.SetPixel(pix.Item1, pix.Item2, _means[list.Key]);
                }
                
            }
            /*for(int i =0; i<_groupedPixels.Count;i++)
            {
                for(int j =0;j<_groupedPixels[i].Count;j++)
                {
                   
                }
            }*/
            return map;
        }
        public Color calculatePixel(Color c)
        {
            return Color.White;
        }

        void pickInitialMeans()
        {
            for(int i =0; i< _k; i++)
            {
                _means.Add(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));
                //_groupedPixels.Add(new List<Tuple<int, int>>());
            }
            
        }
        double colorDistance(Color src, Color dest)
        {
            return Math.Sqrt(Math.Pow(dest.R - src.R, 2) + Math.Pow(dest.G - src.G, 2) + Math.Pow(dest.B - src.B, 2));
        }
        void assignMeans()
        {
            clearLists();
            for (int i = 0; i < _map.Width; i++)
            {
                for (int j = 0; j < _map.Height; j++)
                {
                    Color color = _map.GetPixel(i, j);
                    assignMean(color, i, j);
                }
            }
        }
        void assignMean(Color color,int x, int y)
        {
            double min = colorDistance(color, _means[0]);
            int minIndex = 0;
            double tmp = 0;
            for (int l = 0; l < _means.Count; l++)
            {
                tmp = colorDistance(color, _means[l]);
                if (tmp < min)
                {
                    min = tmp;
                    minIndex = l;
                }
            }
            if (_groupedPixels[minIndex] == null)
            {
                _groupedPixels.Add(minIndex, new List<Tuple<int, int>>());
            }
            _groupedPixels[minIndex].Add(Tuple.Create(x, y));
            //_groupedPixels[minIndex].Add(Tuple.Create(x, y));
        }

        bool calculateMeans()
        {
            bool stopCalculation = true;
            for (int i = 0; i < _means.Count; i++)
            {
                if (_groupedPixels[i].Count != 0)
                { 
                    Color newMean = averageColor(_groupedPixels[i]);
                    if (newMean != _means[i])
                    {
                        stopCalculation = false;
                    }
                    _means[i] = newMean;
                }
            }
            if (stopCalculation)
            {
                return false;
            }else
            {
                return true;
            }
        }
        Color averageColor(List<Tuple<int,int>> colors)
        {
            int sumR = 0;
            int sumG = 0;
            int sumB = 0;
            Color color;
            for (int i =0; i<colors.Count; i++)
            {
                color = _map.GetPixel(colors[i].Item1, colors[i].Item2);
                sumR += color.R;
                sumG += color.G;
                sumB += color.B;
            }
            return Color.FromArgb(sumR / colors.Count, sumG / colors.Count, sumB / colors.Count);
        }

        void clearLists()
        {
            for(int i =0;i< _k;i++)
            {
                _groupedPixels[i] = new List<Tuple<int, int>>();
            }
        }
             
    }
}
