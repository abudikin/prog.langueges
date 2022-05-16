
namespace laba7
{
    partial class MenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_exam_marks_show = new System.Windows.Forms.Button();
            this.button_lectures_show = new System.Windows.Forms.Button();
            this.button_student_show = new System.Windows.Forms.Button();
            this.button_subject_show = new System.Windows.Forms.Button();
            this.button_university_show = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_exam_marks_show
            // 
            this.button_exam_marks_show.Location = new System.Drawing.Point(12, 12);
            this.button_exam_marks_show.Name = "button_exam_marks_show";
            this.button_exam_marks_show.Size = new System.Drawing.Size(75, 23);
            this.button_exam_marks_show.TabIndex = 1;
            this.button_exam_marks_show.Text = "exam_marks";
            this.button_exam_marks_show.UseVisualStyleBackColor = true;
            this.button_exam_marks_show.Click += new System.EventHandler(this.button_exam_marks_show_Click);
            // 
            // button_lectures_show
            // 
            this.button_lectures_show.Location = new System.Drawing.Point(93, 12);
            this.button_lectures_show.Name = "button_lectures_show";
            this.button_lectures_show.Size = new System.Drawing.Size(75, 23);
            this.button_lectures_show.TabIndex = 2;
            this.button_lectures_show.Text = "lectures";
            this.button_lectures_show.UseVisualStyleBackColor = true;
            this.button_lectures_show.Click += new System.EventHandler(this.button_lectures_show_Click);
            // 
            // button_student_show
            // 
            this.button_student_show.Location = new System.Drawing.Point(174, 12);
            this.button_student_show.Name = "button_student_show";
            this.button_student_show.Size = new System.Drawing.Size(75, 23);
            this.button_student_show.TabIndex = 3;
            this.button_student_show.Text = "student";
            this.button_student_show.UseVisualStyleBackColor = true;
            this.button_student_show.Click += new System.EventHandler(this.button_student_show_Click);
            // 
            // button_subject_show
            // 
            this.button_subject_show.Location = new System.Drawing.Point(255, 12);
            this.button_subject_show.Name = "button_subject_show";
            this.button_subject_show.Size = new System.Drawing.Size(75, 23);
            this.button_subject_show.TabIndex = 4;
            this.button_subject_show.Text = "subject";
            this.button_subject_show.UseVisualStyleBackColor = true;
            this.button_subject_show.Click += new System.EventHandler(this.button_subject_show_Click);
            // 
            // button_university_show
            // 
            this.button_university_show.Location = new System.Drawing.Point(336, 12);
            this.button_university_show.Name = "button_university_show";
            this.button_university_show.Size = new System.Drawing.Size(75, 23);
            this.button_university_show.TabIndex = 5;
            this.button_university_show.Text = "university";
            this.button_university_show.UseVisualStyleBackColor = true;
            this.button_university_show.Click += new System.EventHandler(this.button_university_show_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 340);
            this.panel1.TabIndex = 6;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 407);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_university_show);
            this.Controls.Add(this.button_subject_show);
            this.Controls.Add(this.button_student_show);
            this.Controls.Add(this.button_lectures_show);
            this.Controls.Add(this.button_exam_marks_show);
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_exam_marks_show;
        private System.Windows.Forms.Button button_lectures_show;
        private System.Windows.Forms.Button button_student_show;
        private System.Windows.Forms.Button button_subject_show;
        private System.Windows.Forms.Button button_university_show;
        private System.Windows.Forms.Panel panel1;
    }
}

