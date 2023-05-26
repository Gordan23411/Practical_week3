using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Practical_week3
{
    internal class bd
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-C73J7NQ\SQLEXPRESS; Initial Catalog = SPRAV_db; Integrated Security = True");


        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) 
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }



    }
}
