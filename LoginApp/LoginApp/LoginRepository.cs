using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    class LoginRepository
    {
        public static string ServerName { get; set; } = @"DESKTOP-9802V5M\JSSQLSERVER";
        public static string DatabaseName { get; set; } = "LoginInformation";
        public string ConnString { get; set; } = $"Server={ServerName}; Database = {DatabaseName}; Trusted_Connection = True";

        public bool CheckPassword(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT " +
                            "(CASE " +
                            "WHEN Password = @Password " +
                            "THEN 1 " +
                            "ELSE 0 " +
                            "END) " +
                            "FROM LoginInfo " +
                            "WHERE Username = @Username";

                        command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
                        command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;

                        int resultOfQuery = Convert.ToInt32(command.ExecuteScalar());

                        if ( resultOfQuery == 1)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}

