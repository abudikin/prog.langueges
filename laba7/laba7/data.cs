using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace laba7
{
    class data
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=university");
        public void openConnection()
        {
            if (connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
