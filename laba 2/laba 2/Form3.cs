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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string []slova;
            str = str.Replace(".", "").Replace("  ", " ").Replace(",", "");
            slova = str.Split(' ');
            textBox2.Text = Convert.ToString(slova.Length);
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
