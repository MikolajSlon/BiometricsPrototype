using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGOne
{
    public partial class CustomKernel : Form
    {
        int x;
        int y;
        public CustomKernel(int x, int y)
        {
            InitializeComponent();
            this.x = x;
            this.y = y;
            tableLayoutPanel1.RowCount = x;
            tableLayoutPanel1.ColumnCount = y;
            
            
            
             if(x ==3 && y ==3 && ShareKernel.kern != null)
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        TextBox t = new TextBox();
                        t.Text = ShareKernel.kern.kernel[i, j].ToString();
                        t.Dock = DockStyle.Fill;
                        tableLayoutPanel1.Controls.Add(t);

                    }
                }
                OffsetTextBox.Text = ShareKernel.kern.offset.ToString();
                DivisorTextBox.Text = ShareKernel.kern.divisor.ToString();
                AncorXTextBox.Text = ShareKernel.kern.anchor.Item1.ToString();
                AncorYTextBox.Text = ShareKernel.kern.anchor.Item2.ToString();
            }
            else
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        TextBox t = new TextBox();
                        t.Text = "1";
                        t.Dock = DockStyle.Fill;
                        tableLayoutPanel1.Controls.Add(t);

                    }
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Kernel kernel = new Kernel(x,y);
            kernel.sizeX = this.x;
            kernel.sizeY = this.y;
            kernel.offset = Convert.ToInt32(OffsetTextBox.Text);
            kernel.divisor = Convert.ToInt32(DivisorTextBox.Text);
            Tuple<int, int> anchor = new Tuple<int, int>(Convert.ToInt32(AncorXTextBox.Text), Convert.ToInt32(AncorYTextBox.Text));
            kernel.anchor = anchor;
            int index = 0;
            int yrow = 0;
            foreach (TextBox t in tableLayoutPanel1.Controls)
            {
                kernel.setKernelNode(index, yrow, Convert.ToInt32(t.Text));
                index++;
                if(index + 1 > x)
                {
                    yrow++;
                    index = 0;
                }
            }
            ShareKernel.kern = kernel;
            this.Close();
        }
    }
}
