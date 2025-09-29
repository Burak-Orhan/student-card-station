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
    public partial class studentCreate : Form
    {
        private DBConnection db;

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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string email = txtStudentName.Text + txtStudentSurname.Text + "@school.com";
            MessageBox.Show(email);
        }
    }
}
