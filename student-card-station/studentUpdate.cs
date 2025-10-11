using MySql.Data.MySqlClient;
using student_card_station.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_card_station
{
    public partial class studentUpdate : Form
    {
        private DBConnection db;

        public studentUpdate()
        {
            InitializeComponent();
            db = new DBConnection();
        }

        public int userId;
        public int studentId;
        public string studentName;
        public string studentSurname;
        public string studentDepartment;
        public byte[] studentImg;

        private void studentUpdate_Load(object sender, EventArgs e)
        {
            txtStudentName.Text = studentName;
            txtStudentSurname.Text = studentSurname;
            cmbStudentDepartment.Text = studentDepartment;

            using (var ms = new MemoryStream(studentImg))
            {
                imgStudentPicture.Image = Image.FromStream(ms);
            }

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
        public event Action UpdateStudent;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    string email = txtStudentName.Text.ToLower() + txtStudentSurname.Text.ToLower() + "@std.school.edu";
                    string addUpdateStudentQuery = "Update students SET name = @name, surname = @surname, department = @department, email = @email, image_blob = @imageBlob, updated_staff = @updated_staff, updated_at = @updated_at WHERE id = " + studentId +" ";

                    using (var cmd = new MySqlCommand(addUpdateStudentQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtStudentName.Text);
                        cmd.Parameters.AddWithValue("@surname", txtStudentSurname.Text);
                        cmd.Parameters.AddWithValue("@department", cmbStudentDepartment.Text);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@imageBlob", imageBytes ?? studentImg);
                        cmd.Parameters.AddWithValue("@updated_staff", userId);
                        cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                        cmd.ExecuteNonQuery();

                        UpdateStudent?.Invoke();
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

        private void btnStudentUpdatePicture_Click(object sender, EventArgs e)
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
