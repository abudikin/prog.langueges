using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsInTriangle(int x1, int x2, int x3, int x, int y1, int y2, int y3, int y)
            {
                int a = (x1 - x) * (y2 - y1) - (x2 - x1) * (y1 - y);
                int b = (x2 - x) * (y3 - y2) - (x3 - x2) * (y2 - y);
                int c = (x3 - x) * (y - y3) - (x1 - x3) * (y3 - y);

                if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
                    return true;
                else
                    return false;
            }
            int X1 = Convert.ToInt32(textBox1.Text);
            int X2 = Convert.ToInt32(textBox3.Text);
            int X3 = Convert.ToInt32(textBox5.Text);
            int X = Convert.ToInt32(textBox7.Text);
            int Y1 = Convert.ToInt32(textBox2.Text);
            int Y2 = Convert.ToInt32(textBox4.Text);
            int Y3 = Convert.ToInt32(textBox6.Text);
            int Y = Convert.ToInt32(textBox8.Text);
            bool check= IsInTriangle(X1,X2,X3,X,Y1,Y2,Y3,Y);

            if (check == true)
            {
                textBox9.Text = "Точка Лежит внутри треугольника";
            }

            else textBox9.Text = "Точка Лежит внутри треугольника";


        }
    }
}
