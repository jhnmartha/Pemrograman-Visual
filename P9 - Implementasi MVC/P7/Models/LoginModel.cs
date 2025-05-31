using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace P7.Models
{
    internal class LoginModel
    {
        public static bool CekLogin(string username, string password)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM user WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }
    }
}
