using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_2
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1, s2;
            int n;
            s1 = textBox1.Text;
            s2 = textBox2.Text;
            n = Convert.ToInt32(textBox3.Text);
            char[] str = s1.ToCharArray();
            char[] str1 = new char[n];
            for (int i = 0; i < n; i++)
            {
                str1[i] = str[i];
            }
            string s3 = new string(str1);
            s3 = s3 + s2;
            char[] str2 = new char[100];
            int k = 0;
            for (int j = n; j < str.Length; j++)
            {
                str2[k] = str[j];
                k++;
            }
            string s4 = new string(str2);
            s3 = s3 + s4;
            textBox4.Text = s3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Form1();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
