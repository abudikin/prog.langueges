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
    public partial class universityForm : Form
    {
        public universityForm()
        {
            InitializeComponent();
        }

        private void universityForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            data db = new data();
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=university");
            //MySqlCommand cmd = new MySqlCommand("select * from exam_marks", connection);
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand("select * from university", connection);
            adapter.Fill(table);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = table;
            dataGridView1.DataSource = bindingSource;
        }
    }
}
