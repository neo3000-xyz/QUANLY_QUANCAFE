using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_QUANCAFE.DAO
{
    public class DataProvider
    {
        private string connectionSTR = @"Data Source=NEO3000;Initial Catalog=QuanLyCafe;User ID=sa;Password=123456;Encrypt=True;TrustServerCertificate=True";

        public void ExcecuteQuery(string query)
        {
            //SqlConnection connection = new SqlConnection(connectionSTR);
            //string query = "Select DisplayName as [Tên hiển thị] from dbo.Account";
            //connection.Open();
            //SqlConnection command = new SqlCommand(query, connection);
            //Datatable data = new DataTable();
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //adapter.Fill(data);
            //connection.Close();
            //return data;
        }
    }

}
