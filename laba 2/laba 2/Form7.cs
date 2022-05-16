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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string S = textBox1.Text;
            string S1 = textBox2.Text;
            string S2 = textBox3.Text;
            int i = S.IndexOf(S1);
            while (i != -1)
            {
                S = S.Remove(i, S1.Length).Insert(i, S2);
                i = S.IndexOf(S1, i + S1.Length);
            }
 

            textBox1.Text = S;
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
