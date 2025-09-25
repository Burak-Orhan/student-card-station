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
    public partial class studentCard : Form
    {
        public string studentName;
        public string studentSurname;
        public string studentDepartment;
        public int studentId;

        public studentCard()
        {
            InitializeComponent();
        }

        private void studentCard_Load(object sender, EventArgs e)
        {
            txtName.Text = studentName;
            txtSurname.Text = studentSurname;
            txtDepartment.Text = studentDepartment;
            txtNo.Text = studentId.ToString();
        }

        private void CaptureScreen()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
        }

        private void btnCardPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog(); // Önizleme açılır
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.Image, 0, 0);
        }
    }
}
