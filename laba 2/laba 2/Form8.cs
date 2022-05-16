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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;


            char[] str = s.ToCharArray();
            int k = s.Length;
            int j = 0;
            char[] str2 = new char[k];
            for (int i = str.Length-1; i > -1; i--)
            {
                str2[j] = str[i];
                j++;
               
            }
            string str3 = new string(str2);
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
