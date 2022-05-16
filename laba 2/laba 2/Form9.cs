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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            char[] s = str.ToCharArray();
            char[] s1 = new char[s.Length];
            int n, l;
            int k = 0;
            n = Convert.ToInt32(textBox3.Text);
            l = Convert.ToInt32(textBox4.Text);
            
            for (int i = n - 1; i < s.Length - l; i++) { 
                s1[i] = s[i + l];
              
            }
            string str3 = new string(s1);
            textBox2.Text = str3;
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
