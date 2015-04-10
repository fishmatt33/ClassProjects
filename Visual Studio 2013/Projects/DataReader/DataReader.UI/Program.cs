using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DataReader.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString;
            connectionString = ConfigurationManager
                .ConnectionStrings["Northwind"]
                .ConnectionString;

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * From Employees";
                cmd.Connection = cn;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("{0} {1}, {2}",
                            dr["EmployeeID"].ToString(),
                            dr["LastName"].ToString(),
                            dr["FirstName"].ToString());
                        Console.ReadLine();
                    }
                }

            }
        }

        
    }
}
