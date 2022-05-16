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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1, s2, s3;
            s1 = textBox1.Text;
            s2 = textBox2.Text;
            s3 = s1 + " " + s2;
            textBox3.Text = s3;
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
