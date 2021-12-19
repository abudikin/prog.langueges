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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0,i;
            for (i = 0; i <= 1000; i++)
            {
                if (i % 7 == 0)
                {
                    sum = sum + i;
                }
            }
            textBox1.Text = Convert.ToString(sum);
        }
    }
}
