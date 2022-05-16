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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            int m = 0;
            string s = textBox1.Text;
            char[] str = s.ToCharArray();
            char[] str1 = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    k = 1;
                    str1[m] = str[i];
                    m++;
                }
                else if (str[i] == ' ' && k == 1)
                {
                    str1[m] = str[i];
                    m++;
                }
            }
            for (int j = str1.Length-1; j > -1; j--)
            {

                if (str1[j] == ' ')
                {
                    str1[j] = '\0';
                }
                else if (str1[j] != ' ') break;
            }
            string s1 = new string(str1);
            textBox2.Text = s1;
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
