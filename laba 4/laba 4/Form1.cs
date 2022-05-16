using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_4
{
    public partial class Form1 : Form
    {
        public string D;
        public string n1;
        public bool n2;
        public int k = 0;
        public string[] num = new string[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            n1 = textBox1.Text;
            n2 = true;
            
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string l="";
            double dn1, dn2,res;
            res = 0;
            dn1 = Convert.ToDouble(n1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = dn1 + dn2;
                l = "+";
            }
            if (D == "-")
            {
                res = dn1 - dn2;
                l = "-";
            }
            if (D == "×")
            {
                res = dn1 * dn2;
                l = "×";
            }
            if (D == "÷")
            {
                res = dn1 / dn2;
                l = "÷";
            }
            if (D == "%")
            {
                res = (dn2+dn1)/100;
                l = "%";
            }
            D = "=";
            if (D=="=")
            {
                num[k] = dn1.ToString();
                k++;
                num[k] = l;
                k++;
                num[k] = dn2.ToString();
                k++;
                num[k] = D;
                k++;
                num[k]= res.ToString();

            }
            n2 = true;
            textBox1.Text = res.ToString();
            for (int i = 0; i < num.Length; i++)
            {
                textBox2.Text = textBox2.Text + num[i];
                
            }
            textBox2.Text = textBox2.Text + Environment.NewLine;
            k = 0;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Round(Math.Sqrt(dn),4);
            textBox1.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Round(Math.Pow(dn,2),4);
            textBox1.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Round((1 / dn),4);
            textBox1.Text = res.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           textBox1.Text=textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double dn, res = 1;
            dn = Convert.ToDouble(textBox1.Text);
            for (int i = 1; i <=dn; i++)
            {
                res = res * i;
            }
            textBox1.Text = res.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Round(Math.Sin(dn),4);
            textBox1.Text = res.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Round(Math.Cos(dn),4);
            textBox1.Text = res.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Round(Math.Log10(dn),5);
            textBox1.Text = res.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Round(Math.Log(dn), 5);
            textBox1.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            StreamWriter incdate = new StreamWriter("C:\\Users\\Артур\\a.txt", true);
            incdate.WriteLine(textBox2.Text, '\n');
            incdate.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                textBox2.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
    }
}