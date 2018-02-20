namespace CGOne
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.GammaFucntionButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.brightnessTextBox = new System.Windows.Forms.TextBox();
            this.ContrastTextBox = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.applyContrastButton = new System.Windows.Forms.Button();
            this.TrueContrastTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Treshhold = new System.Windows.Forms.Button();
            this.averageDitheringButton = new System.Windows.Forms.Button();
            this.kQuantizationButton = new System.Windows.Forms.Button();
            this.averageDitheringTxt = new System.Windows.Forms.TextBox();
            this.kQuantizationTxt = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GrayscaleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 624);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(194, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(910, 594);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1125, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Apply Brightness";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.brightness_Click);
            // 
            // GammaFucntionButton
            // 
            this.GammaFucntionButton.Location = new System.Drawing.Point(1125, 90);
            this.GammaFucntionButton.Name = "GammaFucntionButton";
            this.GammaFucntionButton.Size = new System.Drawing.Size(103, 33);
            this.GammaFucntionButton.TabIndex = 3;
            this.GammaFucntionButton.Text = "Apply Gamma Function";
            this.GammaFucntionButton.UseVisualStyleBackColor = true;
            this.GammaFucntionButton.Click += new System.EventHandler(this.Contrast_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1125, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Negation";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Negation_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1125, 189);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 51);
            this.button7.TabIndex = 8;
            this.button7.Text = "blur";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Blur_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1216, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 51);
            this.button5.TabIndex = 9;
            this.button5.Text = "smoothing";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Smooth_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1125, 257);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 51);
            this.button6.TabIndex = 10;
            this.button6.Text = "sharpen";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Sharpen_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1216, 257);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(66, 51);
            this.button8.TabIndex = 11;
            this.button8.Text = "mean removal";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.MeanRemoval_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1125, 326);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(66, 51);
            this.button9.TabIndex = 12;
            this.button9.Text = "edge detection";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.EdgeDetection_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1216, 326);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(66, 51);
            this.button10.TabIndex = 13;
            this.button10.Text = "emboss";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Emboss_Click);
            // 
            // brightnessTextBox
            // 
            this.brightnessTextBox.Location = new System.Drawing.Point(1234, 58);
            this.brightnessTextBox.Name = "brightnessTextBox";
            this.brightnessTextBox.Size = new System.Drawing.Size(48, 20);
            this.brightnessTextBox.TabIndex = 14;
            this.brightnessTextBox.Text = "10";
            // 
            // ContrastTextBox
            // 
            this.ContrastTextBox.Location = new System.Drawing.Point(1234, 97);
            this.ContrastTextBox.Name = "ContrastTextBox";
            this.ContrastTextBox.Size = new System.Drawing.Size(48, 20);
            this.ContrastTextBox.TabIndex = 15;
            this.ContrastTextBox.Text = "0,9";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1124, 534);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(157, 51);
            this.button11.TabIndex = 17;
            this.button11.Text = "create custom kernel";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Create_Custom_Kernel_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1124, 591);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(157, 51);
            this.button12.TabIndex = 18;
            this.button12.Text = "apply custom kernel";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.ApplyKernel_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1162, 508);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(43, 20);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "3";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1233, 508);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(48, 20);
            this.textBox5.TabIndex = 20;
            this.textBox5.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1190, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "size";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(1131, 511);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(12, 13);
            this.x.TabIndex = 22;
            this.x.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1211, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "y";
            // 
            // applyContrastButton
            // 
            this.applyContrastButton.Location = new System.Drawing.Point(1125, 12);
            this.applyContrastButton.Name = "applyContrastButton";
            this.applyContrastButton.Size = new System.Drawing.Size(103, 32);
            this.applyContrastButton.TabIndex = 24;
            this.applyContrastButton.Text = "Apply Contrast";
            this.applyContrastButton.UseVisualStyleBackColor = true;
            this.applyContrastButton.UseWaitCursor = true;
            this.applyContrastButton.Click += new System.EventHandler(this.applyContrastButton_Click);
            // 
            // TrueContrastTextBox
            // 
            this.TrueContrastTextBox.Location = new System.Drawing.Point(1234, 19);
            this.TrueContrastTextBox.Name = "TrueContrastTextBox";
            this.TrueContrastTextBox.Size = new System.Drawing.Size(48, 20);
            this.TrueContrastTextBox.TabIndex = 25;
            this.TrueContrastTextBox.Text = "1,1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1125, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 51);
            this.button3.TabIndex = 26;
            this.button3.Text = "Median Filter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Treshhold
            // 
            this.Treshhold.Location = new System.Drawing.Point(1214, 383);
            this.Treshhold.Name = "Treshhold";
            this.Treshhold.Size = new System.Drawing.Size(66, 51);
            this.Treshhold.TabIndex = 27;
            this.Treshhold.Text = "Apply Treshhold";
            this.Treshhold.UseVisualStyleBackColor = true;
            this.Treshhold.Click += new System.EventHandler(this.TreshholdClick);
            // 
            // averageDitheringButton
            // 
            this.averageDitheringButton.Location = new System.Drawing.Point(1307, 189);
            this.averageDitheringButton.Name = "averageDitheringButton";
            this.averageDitheringButton.Size = new System.Drawing.Size(72, 51);
            this.averageDitheringButton.TabIndex = 28;
            this.averageDitheringButton.Text = "average dithering";
            this.averageDitheringButton.UseVisualStyleBackColor = true;
            this.averageDitheringButton.Click += new System.EventHandler(this.averageDitheringButton_Click);
            // 
            // kQuantizationButton
            // 
            this.kQuantizationButton.Location = new System.Drawing.Point(1307, 257);
            this.kQuantizationButton.Name = "kQuantizationButton";
            this.kQuantizationButton.Size = new System.Drawing.Size(72, 51);
            this.kQuantizationButton.TabIndex = 29;
            this.kQuantizationButton.Text = "k means Color Quantization";
            this.kQuantizationButton.UseVisualStyleBackColor = true;
            this.kQuantizationButton.Click += new System.EventHandler(this.kQuantizationButton_Click);
            // 
            // averageDitheringTxt
            // 
            this.averageDitheringTxt.Location = new System.Drawing.Point(1385, 205);
            this.averageDitheringTxt.Name = "averageDitheringTxt";
            this.averageDitheringTxt.Size = new System.Drawing.Size(25, 20);
            this.averageDitheringTxt.TabIndex = 30;
            this.averageDitheringTxt.Text = "4";
            // 
            // kQuantizationTxt
            // 
            this.kQuantizationTxt.Location = new System.Drawing.Point(1385, 273);
            this.kQuantizationTxt.Name = "kQuantizationTxt";
            this.kQuantizationTxt.Size = new System.Drawing.Size(25, 20);
            this.kQuantizationTxt.TabIndex = 31;
            this.kQuantizationTxt.Text = "4";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(194, 653);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(916, 120);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(1, 12);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(187, 594);
            this.chart2.TabIndex = 33;
            this.chart2.Text = "chart2";
            // 
            // GrayscaleButton
            // 
            this.GrayscaleButton.Location = new System.Drawing.Point(1307, 326);
            this.GrayscaleButton.Name = "GrayscaleButton";
            this.GrayscaleButton.Size = new System.Drawing.Size(72, 51);
            this.GrayscaleButton.TabIndex = 34;
            this.GrayscaleButton.Text = "GrayScale";
            this.GrayscaleButton.UseVisualStyleBackColor = true;
            this.GrayscaleButton.Click += new System.EventHandler(this.GrayscaleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 784);
            this.Controls.Add(this.GrayscaleButton);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.kQuantizationTxt);
            this.Controls.Add(this.averageDitheringTxt);
            this.Controls.Add(this.kQuantizationButton);
            this.Controls.Add(this.averageDitheringButton);
            this.Controls.Add(this.Treshhold);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TrueContrastTextBox);
            this.Controls.Add(this.applyContrastButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.ContrastTextBox);
            this.Controls.Add(this.brightnessTextBox);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.GammaFucntionButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ElephantPhoto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button GammaFucntionButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox brightnessTextBox;
        private System.Windows.Forms.TextBox ContrastTextBox;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applyContrastButton;
        private System.Windows.Forms.TextBox TrueContrastTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Treshhold;
        private System.Windows.Forms.Button averageDitheringButton;
        private System.Windows.Forms.Button kQuantizationButton;
        private System.Windows.Forms.TextBox averageDitheringTxt;
        private System.Windows.Forms.TextBox kQuantizationTxt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button GrayscaleButton;
    }
}

