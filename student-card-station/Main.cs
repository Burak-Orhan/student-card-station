using MySql.Data.MySqlClient;
using student_card_station.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_card_station
{
    public partial class Main : Form
    {
        private DBConnection db;
        public int userId;

        public Main()
        {
            InitializeComponent();
            db = new DBConnection();
        }

        // Refresh dataGridView Event Method
        public void LoadStudents()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM students";
                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                try
                {
                    string query = "SELECT * FROM students";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView.DataSource = dt;
                        }
                    }

    
                    string userQuery = "SELECT username FROM users WHERE id = @userId";
                    using (var cmdUser = new MySqlCommand(userQuery, conn))
                    {
                        cmdUser.Parameters.AddWithValue("@userId", this.userId);
                        using (var reader = cmdUser.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["username"].ToString();
                                lblSystemUser.Text = $"Sistemde ki Yetkili Kişi: ({name}) (ID: {userId})";
                            }
                            else
                            {
                                lblSystemUser.Text = "Sistemde ki Yetkili Kişiye Ulaşılamıyor";
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

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            studentCreate studentCreate = new studentCreate();
            studentCreate.Closed += (s, args) => this.Show();
            dataGridView.Refresh();

            // New Student Add This Form Refresh
            studentCreate.CreateStudent += () =>
            {
                LoadStudents();
            };

            studentCreate.userId = userId;
            studentCreate.Show();
            this.Hide();
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            studentCard studentCard = new studentCard();
            studentCard.studentName = dataGridView.CurrentRow.Cells["name"].Value.ToString();
            studentCard.studentSurname = dataGridView.CurrentRow.Cells["surname"].Value.ToString();
            studentCard.studentDepartment = dataGridView.CurrentRow.Cells["department"].Value.ToString();
            studentCard.studentId = Convert.ToInt32(dataGridView.CurrentRow.Cells["id"].Value);
            studentCard.studentImg = (byte[])dataGridView.CurrentRow.Cells["image_blob"].Value;
            studentCard.Closed += (s, args) => this.Show();
            studentCard.ShowDialog();
        }

        private void btnDataGridViewPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ClientSize = new Size(800, 600);
            previewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView.DrawToBitmap(bm, new Rectangle(0, 0, dataGridView.Width, dataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var authLogin = new authLogin();
            authLogin.Closed += (s, args) => this.Close();
            authLogin.Show();
        }
    }
}
