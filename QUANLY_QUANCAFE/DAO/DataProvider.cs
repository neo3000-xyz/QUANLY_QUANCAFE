using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_QUANCAFE.DAO
{
    public class DataProvider
    {
        private string connectionSTR = @"Data Source=NEO3000;Initial Catalog=QuanLyCafe;User ID=sa;Password=123456;Encrypt=True;TrustServerCertificate=True";

        public DataTable ExcecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }

}
