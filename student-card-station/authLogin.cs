using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using student_card_station.Helper;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace student_card_station
{
    public partial class authLogin : Form
    {
        private DBConnection db;

        public authLogin()
        {
            InitializeComponent();
            db = new DBConnection();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.Hide();
                                var mainForm = new Main();
                                mainForm.userId = Convert.ToInt32(reader["id"]);
                                mainForm.Closed += (s, args) => this.Close();
                                mainForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
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

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var registerForm = new authRegister();
            registerForm.Closed += (s, args) => this.Close();
            registerForm.Show();
        }
    }
}
