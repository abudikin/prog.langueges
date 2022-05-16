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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form3();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f4 = new Form4();
            f4.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f5 = new Form5();
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f6 = new Form6();
            f6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f7=new Form7();
            f7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f8 = new Form8();
            f8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f9 = new Form9();
            f9.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f10 = new Form10();
            f10.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f11 = new Form11();
            f11.Show();
        }
    }
}
