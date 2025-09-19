using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_card_station.Helper
{
    internal class DBTable
    {
        DBConnection dbConnection = new DBConnection();

        public void CreateTables()
        {
            using (var conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string createStudentsTable = @"
                        CREATE TABLE IF NOT EXISTS students (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            name VARCHAR(100) NOT NULL,
                            email VARCHAR(100) NOT NULL UNIQUE,
                            created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                    );";

                    string createUsersTable = @"
                        CREATE TABLE IF NOT EXISTS users (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            username VARCHAR(50) NOT NULL UNIQUE,
                            password VARCHAR(255) NOT NULL,
                            role ENUM('admin', 'user') DEFAULT 'user',
                            created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                    );";

                    string createLessionsTable = @"
                        CREATE TABLE IF NOT EXISTS lessons (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            name VARCHAR(100) NOT NULL,
                            created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                    );";

                    string insertLessons = @"
                        INSERT INTO lessons (name) VALUES
                        ('Bilgisayar Programcılığı'),
                        ('Elektrikli Cihaz Teknolojisi'),
                        ('Bankacılık ve Sigortacılık'),
                        ('İnsansız Araç Teknikerliği'),
                        ('İlk ve Acil Yardım'),
                        ('Tıbbi Dokümantasyon ve Sekreterlik')
                    ";

                    MySqlCommand cmdUsers = new MySqlCommand(createUsersTable, conn);
                    MySqlCommand cmdStudents = new MySqlCommand(createStudentsTable, conn);
                    MySqlCommand cmdLessions = new MySqlCommand(createLessionsTable, conn);
                    MySqlCommand cmdLessionsInsert = new MySqlCommand(insertLessons, conn);

                    cmdUsers.ExecuteNonQuery();
                    cmdStudents.ExecuteNonQuery();
                    cmdLessions.ExecuteNonQuery();
                    cmdLessionsInsert.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

    }
}
