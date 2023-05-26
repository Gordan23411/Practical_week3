using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_week3
{
    bd database = new bd();
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string connectString = "Data Source = DESKTOP-C73J7NQ\\SQLEXPRESS; Initial Catalog = SPRAV_db; Integrated Security = True";


            SqlConnection sqlConnection = new SqlConnection(connectString);


            SqlConnection.Open();


            string query = "SELECT * FROM SPRAV_db ORDER BY fac_id";
            

            SqlCommand command = new SqlCommand(query, sqlConnection);
        }

       
    }
}
