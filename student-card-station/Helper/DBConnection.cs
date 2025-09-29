using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace student_card_station.Helper
{
    internal class DBConnection
    {
        private string server = "localhost";
        private string database = "student-card-station";
        private string uid = "root";
        private string password = "";

        private string connectionString;
       
        public DBConnection()
        {
            string createString = $"server={server};uid={uid};pwd={password};";
            using (var conn = new MySqlConnection(createString)) 
            { 
                conn.Open();

                string createDBQuery = $"CREATE DATABASE IF NOT EXISTS `{database}`;";

                using (var cmd = new MySqlCommand(createDBQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                    connectionString = $"server={server};database={database};uid={uid};pwd={password};";
                }
            }
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
