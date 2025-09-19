using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using student_card_station.Helper;

namespace student_card_station
{
    public partial class Main : Form
    {
        private DBConnection db;
        private DBTable dbTable;

        public int userId;

        public Main()
        {
            InitializeComponent();
            db = new DBConnection();
            dbTable = new DBTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbTable.CreateTables();

            MessageBox.Show($"User ID: {userId}");

            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM students";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show($"ID: {reader["id"]}, Name: {reader["name"]}");
                            }
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
