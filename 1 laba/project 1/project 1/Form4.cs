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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name2,name1;
            int c=0;
            for (int j = 0; j < listView1.Items.Count; j++)
            {
                name1 = listView1.Items[j].SubItems[0].Text;
                string[] words1 = name1.Split(' ');
               

                for (int i = 1; i < listView1.Items.Count - 1; i++)
                {
                    name2 = listView1.Items[i].SubItems[0].Text;
                    string[] words2 = name2.Split(' ');

                    if (words2.Length > 2)
                    {
                        if (words1[2] == words2[2] || words1[3] == words2[3])
                        { c++;
                            
                            
                        }
                        
                    }


                }
            }
            textBox1.Text = Convert.ToString(c);
        }
    }
}
