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
    public partial class authRegister : Form
    {
        private DBConnection db;

        public authRegister()
        {
            InitializeComponent();
            db = new DBConnection();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var conn = db.GetConnection())
            {
                try
                {
                    if (txtPassword.Text != txtPasswordVerifly.Text) { 
                        MessageBox.Show("Şifreler Uyuşmuyor.");
                    } else { 
                        conn.Open();

                        string queryUsername = "SELECT * FROM users WHERE username = @username";
                        using (var cmdUsername = new MySqlCommand(queryUsername, conn))
                        {
                            cmdUsername.Parameters.AddWithValue("@username", txtUsername.Text);
                            using (var reader = cmdUsername.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    MessageBox.Show("Kullanıcı Adı Kullanılmakta. Lütfen Başka Kullanıcı Adı Giriniz.");
                                    return;
                                }
                            }
                        }

                        string queryInsert = "INSERT INTO users (username, password) VALUES (@username, @password)";
                        using (var cmd = new MySqlCommand(queryInsert, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                string queryGetId = "SELECT id FROM users WHERE username = @username";
                                using (var cmdGetId = new MySqlCommand(queryGetId, conn))
                                {
                                    cmdGetId.Parameters.AddWithValue("@username", txtUsername.Text);
                                    using (var reader = cmdGetId.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            this.Hide();
                                            var mainForm = new Main();
                                            mainForm.Closed += (s, args) => this.Close();
                                            mainForm.userId = Convert.ToInt32(reader["id"]);
                                            mainForm.Show();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kayıt İşlemi İptal Oldu. Lütfen Tekrar Deneyin");
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

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var loginForm = new authLogin();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
