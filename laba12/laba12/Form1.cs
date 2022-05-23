﻿using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace laba12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void buttonContrastP_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;


            IFilter contrast = new ContrastCorrection(15);

            pictureBox1.Image = contrast.Apply(bmp);
        }

        private void buttonContrastM_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;


            IFilter contrast = new ContrastCorrection(-15);

            pictureBox1.Image = contrast.Apply(bmp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            IFilter brightness = new BrightnessCorrection(50);
            pictureBox1.Image = brightness.Apply(bmp);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            IFilter brightness = new BrightnessCorrection(-50);
            pictureBox1.Image = brightness.Apply(bmp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;

            int[,] kernel = {
                    { -1,  -1,  -1 },
                    { -1,   9,  -1 },
                    { -1,  -1,  -1 } };

            IFilter filter = new Convolution(kernel);

            pictureBox1.Image = filter.Apply(bmp);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;

           
            IFilter filter = new BaseResizeFilter(2000,200);

            pictureBox1.Image = filter.Apply(bmp);

        }
    }
}
