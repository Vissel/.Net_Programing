using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PHocKi.Models
{
    public class DBConnect
    {

        public static SqlConnection getConnection()
        {
            SqlConnection result = null;
            string connectionString = "Data Source=127.0.0.1;Initial Catalog=DOTNET;User ID=sa;Password=12345";

            result = new SqlConnection(connectionString);
            result.Open();
            return result;
        }

        public static void Main(String[] args)
        {
            SqlConnection sql = DBConnect.getConnection();

            if (sql == null)
            {
                Console.WriteLine("Fail");
            }
            else Console.WriteLine("Ok");
        }
    }
}