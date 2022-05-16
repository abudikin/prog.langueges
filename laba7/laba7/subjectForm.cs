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
    public partial class subjectForm : Form
    {
        public subjectForm()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        data db = new data();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=university");
        BindingSource bindingSource = new BindingSource();
        private void subjectForm_Load(object sender, EventArgs e)
        {
            db.openConnection();
            adapter.SelectCommand = new MySqlCommand("select * from subject", connection);
            adapter.Fill(table);
            bindingSource.DataSource = table;
            dataGridView1.DataSource = bindingSource;
            db.closeConnection();
        }
    }
}
