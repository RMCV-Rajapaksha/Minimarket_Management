using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Minimarket_Management
{
    internal class DBConnect
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ROG\OneDrive\Desktop\Projects\My project\New folder\Minimarket_Management\minimarketdb.mdf"";Integrated Security=True;Connect Timeout=30");
        public SqlConnection GetCon()
        {
            return connection;
        }

        public void openCon()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
