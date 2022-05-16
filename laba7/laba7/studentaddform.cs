using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace laba7
{
    public partial class studentaddform : Form
    {
        public studentaddform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 &&
				textBox4.Text.Length != 0 && textBox5.Text.Length != 0 && textBox6.Text.Length != 0)
			{
				int c1 = comboBox1.SelectedIndex + 1;
				string connStr = "server=localhost; port=3306; username=root; password=root; database=university;";
				string sql = "INSERT INTO student(student_id, surname, name, stipend, kurs, city, birthday, univ_id) " +
							 "VALUES(" + textBox1.Text + ", '" + textBox2.Text + "', '" + textBox3.Text + "', " + textBox4.Text + ", "
							 + textBox5.Text + ", '" + textBox6.Text + "', '" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd")
							 + "', " + c1 + ");";
				MySqlConnection conn = new MySqlConnection(connStr);
				MySqlCommand command = new MySqlCommand(sql, conn);
				MySqlDataReader reader;
				conn.Open();
				reader = command.ExecuteReader();
				MessageBox.Show("Добавлено");
				conn.Close();
				this.Close();
			}
			else MessageBox.Show("Заполнены не все поля");
		}

        private void studentaddform_Load(object sender, EventArgs e)
        {
			string connStr = "server=localhost; port=3306; username=root; password=root; database=university;";
			string sql = "SELECT DISTINCT univ_name FROM university;";
			MySqlConnection conn = new MySqlConnection(connStr);
			MySqlCommand command = new MySqlCommand(sql, conn);
			MySqlDataReader reader;
			try
			{
				command.Connection.Open();
				reader = command.ExecuteReader();

				while (reader.Read())
				{
					comboBox1.Items.Add(reader["univ_name"].ToString());
				}
				reader.Close();
			}
			catch (MySqlException ex)
			{
				Console.WriteLine("Error", ex.ToString());
			}
			finally
			{
				command.Connection.Close();
			}
		}
    }
}
