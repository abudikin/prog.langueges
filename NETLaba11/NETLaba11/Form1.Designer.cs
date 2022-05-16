
namespace NETLaba11
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.create = new System.Windows.Forms.Button();
			this.read = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.add = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(288, 310);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// create
			// 
			this.create.Location = new System.Drawing.Point(401, 50);
			this.create.Name = "create";
			this.create.Size = new System.Drawing.Size(97, 23);
			this.create.TabIndex = 1;
			this.create.Text = "Создать";
			this.create.UseVisualStyleBackColor = true;
			this.create.Click += new System.EventHandler(this.create_Click);
			// 
			// read
			// 
			this.read.Location = new System.Drawing.Point(401, 127);
			this.read.Name = "read";
			this.read.Size = new System.Drawing.Size(97, 23);
			this.read.TabIndex = 2;
			this.read.Text = "Вывод";
			this.read.UseVisualStyleBackColor = true;
			this.read.Click += new System.EventHandler(this.read_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(325, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(173, 20);
			this.textBox1.TabIndex = 3;
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(401, 88);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(97, 23);
			this.add.TabIndex = 4;
			this.add.Text = "Добавить";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 327);
			this.Controls.Add(this.add);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.read);
			this.Controls.Add(this.create);
			this.Controls.Add(this.richTextBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button create;
		private System.Windows.Forms.Button read;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button add;
	}
}

