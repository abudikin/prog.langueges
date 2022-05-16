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
    public partial class studentForm : Form
    {
        public studentForm()
        {
            InitializeComponent();
        }

        //DataTable table = new DataTable();
        
        private void studentForm_Load(object sender, EventArgs e)
        {

            f_load();
        }
        private void f_load()
        {
            listBox1.Items.Clear();
            string connStr = "server=localhost; port=3306; username=root; password=root; database=university;";
            string sql = "SELECT DISTINCT surname FROM student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader["surname"].ToString());
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

        private void db_load()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            if (listBox1.SelectedIndex == -1)
            {
                listBox1.SelectedIndex = 0;
                listBox1.SelectedItem = 0;
            }
            this.Text = listBox1.SelectedItem.ToString();
            //MessageBox.Show(listBox1.SelectedItem.ToString());
            string connStr = "server=localhost; port=3306; username=root; password=root; database=university;";
            string sql = "SELECT student_id, surname, name, kurs, city, birthday FROM student " +
                "where surname = '" + listBox1.SelectedItem.ToString() + "';";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                this.dataGridView1.Columns.Add("student_id", "Id");
                this.dataGridView1.Columns["student_id"].Width = 50;

                this.dataGridView1.Columns.Add("surname", "Surname");
                this.dataGridView1.Columns["surname"].Width = 100;

                this.dataGridView1.Columns.Add("name", "Name");
                this.dataGridView1.Columns["name"].Width = 80;

                this.dataGridView1.Columns.Add("kurs", "Kurs");
                this.dataGridView1.Columns["kurs"].Width = 50;

                this.dataGridView1.Columns.Add("city", "City");
                this.dataGridView1.Columns["city"].Width = 60;

                this.dataGridView1.Columns.Add("birthday", "Birthday");
                this.dataGridView1.Columns["birthday"].Width = 100;

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["student_id"].ToString(), reader["surname"].ToString(), reader["name"].ToString(),
                        reader["kurs"].ToString(), reader["city"].ToString(), Convert.ToDateTime(reader["birthday"]).ToString("dd.MM.yyyy"));
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                db_load();
                f_load();
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentaddform st = new studentaddform();
            st.Show();
        }
    }
}
