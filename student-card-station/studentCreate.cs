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
using System.IO;
using ZstdSharp.Unsafe;

namespace student_card_station
{
    public partial class studentCreate : Form
    {
        private DBConnection db;
        public int userId;

        public studentCreate()
        {
            InitializeComponent();
            db = new DBConnection();
        }

        private void studentCreate_Load(object sender, EventArgs e)
        {
            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, name FROM lessons";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbStudentDepartment.DataSource = dt;
                    cmbStudentDepartment.DisplayMember = "name";
                    cmbStudentDepartment.ValueMember = "id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private byte[] imageBytes;
        public event Action CreateStudent;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    string email = txtStudentName.Text.ToLower() + txtStudentSurname.Text.ToLower() + "@std.school.edu";
                    string addNewStudentQuery = "INSERT INTO students (name, surname, department, email, image_blob, created_staff) VALUES (@name, @surname, @department, @email, @imageBlob, @created_staff)";

                    using (var cmd = new MySqlCommand(addNewStudentQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtStudentName.Text);
                        cmd.Parameters.AddWithValue("@surname", txtStudentSurname.Text);
                        cmd.Parameters.AddWithValue("@department", cmbStudentDepartment.Text);
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("@imageBlob", imageBytes);
                        cmd.Parameters.AddWithValue("@created_staff", userId);
                        cmd.ExecuteNonQuery();

                        CreateStudent?.Invoke();
                        this.Close();
                    }
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void btnStudentAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Öğrenci Resimi Seçiniz";
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                imgStudentPicture.Image = Image.FromFile(filePath);
                imageBytes = File.ReadAllBytes(ofd.FileName);
            }
        }
    }
}
