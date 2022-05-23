
namespace laba12
{
    partial class Form1
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button_add = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.buttonContrastP = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonContrastM = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// button_add
			// 
			this.button_add.Location = new System.Drawing.Point(79, 35);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(69, 31);
			this.button_add.TabIndex = 1;
			this.button_add.Text = "add";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.button_add_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.panel7);
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(674, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(234, 581);
			this.panel1.TabIndex = 3;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.button4);
			this.panel6.Controls.Add(this.label4);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 271);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(234, 57);
			this.panel6.TabIndex = 7;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(101, 19);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(20, 21);
			this.button4.TabIndex = 4;
			this.button4.Text = "+";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(76, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Черно белый";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.button3);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 214);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(234, 57);
			this.panel5.TabIndex = 6;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(101, 19);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(20, 21);
			this.button3.TabIndex = 4;
			this.button3.Text = "+";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(58, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Повышение резкости";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.button1);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.button2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 157);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(234, 57);
			this.panel4.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(118, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(20, 21);
			this.button1.TabIndex = 4;
			this.button1.Text = "+";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(58, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Яркость";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(24, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(20, 21);
			this.button2.TabIndex = 2;
			this.button2.Text = "-";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.buttonContrastP);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.buttonContrastM);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 100);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(234, 57);
			this.panel3.TabIndex = 4;
			this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			// 
			// buttonContrastP
			// 
			this.buttonContrastP.Location = new System.Drawing.Point(118, 16);
			this.buttonContrastP.Name = "buttonContrastP";
			this.buttonContrastP.Size = new System.Drawing.Size(20, 21);
			this.buttonContrastP.TabIndex = 4;
			this.buttonContrastP.Text = "+";
			this.buttonContrastP.UseVisualStyleBackColor = true;
			this.buttonContrastP.Click += new System.EventHandler(this.buttonContrastP_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Контраст";
			// 
			// buttonContrastM
			// 
			this.buttonContrastM.Location = new System.Drawing.Point(24, 16);
			this.buttonContrastM.Name = "buttonContrastM";
			this.buttonContrastM.Size = new System.Drawing.Size(20, 21);
			this.buttonContrastM.TabIndex = 2;
			this.buttonContrastM.Text = "-";
			this.buttonContrastM.UseVisualStyleBackColor = true;
			this.buttonContrastM.Click += new System.EventHandler(this.buttonContrastM_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button_add);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(234, 100);
			this.panel2.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(674, 581);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.button5);
			this.panel7.Controls.Add(this.label5);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(0, 328);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(234, 57);
			this.panel7.TabIndex = 8;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(101, 19);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(20, 21);
			this.button5.TabIndex = 4;
			this.button5.Text = "+";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(76, 3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Сглаживание";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 391);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 9;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(8, 417);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 10;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(132, 389);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 11;
			this.button6.Text = "обновить";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(94, 534);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 12;
			this.button7.Text = "Изменить";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(908, 581);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonContrastP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonContrastM;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
	}
}

