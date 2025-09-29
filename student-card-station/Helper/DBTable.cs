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

                    // Table Area
                    string createUsersTable = @"
                        CREATE TABLE IF NOT EXISTS users (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            username VARCHAR(50) NOT NULL UNIQUE,
                            password VARCHAR(255) NOT NULL,
                            role ENUM('admin', 'user') DEFAULT 'user',
                            created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                    );";

                    string createStudentsTable = @"
                        CREATE TABLE IF NOT EXISTS students (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            name VARCHAR(100) NOT NULL,
                            surname VARCHAR(100) NOT NULL,
                            department VARCHAR(100) NOT NULL,
                            email VARCHAR(100) NOT NULL UNIQUE,
                            image_blob LONGBLOB,
                            created_staff INT,
                            created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                            FOREIGN KEY (created_staff) REFERENCES users(id)
                                    ON DELETE SET NULL 
                                    ON UPDATE CASCADE
                    );";


                    string createLessionsTable = @"
                        CREATE TABLE IF NOT EXISTS lessons (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            name VARCHAR(100) NOT NULL,
                            created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                    );";

                    string createMigrationsTable = @"
                        CREATE TABLE IF NOT EXISTS migrations (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            migration VARCHAR(255) NOT NULL,
                            created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                    );";

                    // Insert Area
                    string insertLessons = @"
                        INSERT INTO lessons (name) VALUES
                        ('Bilgisayar Programcılığı'),
                        ('Elektrikli Cihaz Teknolojisi'),
                        ('Bankacılık ve Sigortacılık'),
                        ('İnsansız Araç Teknikerliği'),
                        ('İlk ve Acil Yardım'),
                        ('Tıbbi Dokümantasyon ve Sekreterlik')
                    ";

                    string insertFakeUser = @"
                        INSERT INTO users (username,password) VALUES
                        ('test','test')
                    ";

                    MySqlCommand cmdUsers = new MySqlCommand(createUsersTable, conn);
                    MySqlCommand cmdStudents = new MySqlCommand(createStudentsTable, conn);
                    MySqlCommand cmdLessions = new MySqlCommand(createLessionsTable, conn);
                    MySqlCommand cmdMigrations = new MySqlCommand(createMigrationsTable, conn);
                    
                    MySqlCommand cmdLessionsInsert = new MySqlCommand(insertLessons, conn);
                    MySqlCommand cmdFakeUserInsert = new MySqlCommand (insertFakeUser, conn);

                    cmdMigrations.ExecuteNonQuery();
                    cmdUsers.ExecuteNonQuery();
                    cmdStudents.ExecuteNonQuery();
                    cmdLessions.ExecuteNonQuery();

                    using (var checkCmd = new MySqlCommand("SELECT COUNT(*) FROM lessons", conn))
                    {
                        var count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count == 0)
                        {
                            cmdLessionsInsert.ExecuteNonQuery();
                        }
                    }

                    using (var checkCmd = new MySqlCommand("SELECT COUNT(*) FROM users", conn))
                    {
                        var count = Convert.ToInt32 (checkCmd.ExecuteScalar());
                        if (count == 0)
                        {
                            cmdFakeUserInsert.ExecuteNonQuery();
                        }
                    }
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
