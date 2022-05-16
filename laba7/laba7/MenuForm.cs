using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba7
{
    public partial class MenuForm : Form
    {
        private Form active;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            panelForm(new exam_marksForm());
        }
        private void panelForm(Form fr)
        {
            if (active != null)
            {
                active.Close();
            }
            active = fr;
            fr.TopLevel = false;
            fr.FormBorderStyle = FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fr);
            this.panel1.Tag = fr;
            fr.BringToFront();
            fr.Show();
        }

        private void button_exam_marks_show_Click(object sender, EventArgs e)
        {
            panelForm(new exam_marksForm());
        }

        private void button_lectures_show_Click(object sender, EventArgs e)
        {
            panelForm(new lecturesForm());
        }

        private void button_student_show_Click(object sender, EventArgs e)
        {
            panelForm(new studentForm());
        }

        private void button_subject_show_Click(object sender, EventArgs e)
        {
            panelForm(new subjectForm());
        }

        private void button_university_show_Click(object sender, EventArgs e)
        {
            panelForm(new universityForm());
        }
    }
}
