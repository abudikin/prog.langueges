using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetSize();
        }

        private bool isMouse = false;
        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;
            public ArrayPoints(int size)
            {
                if (size <=0)
                {
                    size = 2;
                }
                points = new Point[size];
                
            }
            public void SetPoint(int x,int y)
            {
                if (index>=points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }
            public void ResetPoints()
            {
                index = 0;
            }
            public int GetCountPoints()
            {
                return index;
            }
            public Point[] GetPoints()
            {
                return points;
            }
        }
        private ArrayPoints arrayPoints = new ArrayPoints(2);
        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;

        Pen pen = new Pen(Color.Black, 3f);
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            arrayPoints.ResetPoints();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse || func!=0)
            {
                return;
            }
            
            arrayPoints.SetPoint(e.X, e.Y);
            if (arrayPoints.GetCountPoints()>=2)
            {
                graphics.DrawLines(pen,arrayPoints.GetPoints());
                pictureBox1.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
            func = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()==DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
                func = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox1.BackColor);
            pictureBox1.Image = map;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                if (pictureBox1.Image!=null)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                    MessageBox.Show("Файл успешно сохранен");
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
            }
            }

        private void imageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                    MessageBox.Show("Файл успешно сохранен");
                }
            }
            graphics.Clear(pictureBox1.BackColor);
            pictureBox1.Image = map;
            MessageBox.Show("Файл создан");
        }
        int func = 0;
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            func = 1;
        }
        Random random = new Random();


        private int circleSize = 30;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (func==1)
            {
                int x, y;

                x = pictureBox1.Height / 2;
                y = pictureBox1.Width / 2;

                Color color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                SolidBrush brush = new SolidBrush(color);
               // Pen pen = new Pen(color);
                pen.Width = 3;

                circleSize=random.Next(50,200);
                graphics.FillEllipse(brush, e.X - circleSize / 2, e.Y - circleSize / 2, circleSize, circleSize);
              
                pictureBox1.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);
            }
            else if (func == 2)
            {
                int x, y;

                x = pictureBox1.Height / 2;
                y = pictureBox1.Width / 2;

                Color color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                SolidBrush brush = new SolidBrush(color);
                //pen.Width = 3;
                graphics.FillEllipse(brush, e.X - circleSize / 2, e.Y - circleSize / 2, circleSize, circleSize);

                circleSize = random.Next(50, 200);
                pictureBox1.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            func = 2;
        }
    }
}
