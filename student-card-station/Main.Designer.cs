namespace student_card_station
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.btnDataGridViewPrint = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.lblSystemUser = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 36);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(776, 345);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.Location = new System.Drawing.Point(12, 386);
            this.btnAddNewStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(150, 50);
            this.btnAddNewStudent.TabIndex = 1;
            this.btnAddNewStudent.Text = "Yeni Öğrenci Ekle";
            this.btnAddNewStudent.UseVisualStyleBackColor = true;
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // btnDataGridViewPrint
            // 
            this.btnDataGridViewPrint.Location = new System.Drawing.Point(480, 386);
            this.btnDataGridViewPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDataGridViewPrint.Name = "btnDataGridViewPrint";
            this.btnDataGridViewPrint.Size = new System.Drawing.Size(150, 50);
            this.btnDataGridViewPrint.TabIndex = 2;
            this.btnDataGridViewPrint.Text = "Verileri Yazdır";
            this.btnDataGridViewPrint.UseVisualStyleBackColor = true;
            this.btnDataGridViewPrint.Click += new System.EventHandler(this.btnDataGridViewPrint_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog1";
            this.printPreviewDialog.Text = "Baskı önizleme";
            this.printPreviewDialog.Visible = false;
            // 
            // lblSystemUser
            // 
            this.lblSystemUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSystemUser.Location = new System.Drawing.Point(12, 9);
            this.lblSystemUser.Name = "lblSystemUser";
            this.lblSystemUser.Size = new System.Drawing.Size(776, 25);
            this.lblSystemUser.TabIndex = 3;
            this.lblSystemUser.Text = "staffArea";
            this.lblSystemUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogOut.Location = new System.Drawing.Point(636, 386);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(150, 50);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Oturum Sonlandır";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(168, 386);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(150, 50);
            this.btnUpdateStudent.TabIndex = 5;
            this.btnUpdateStudent.Text = "Öğrenci Güncelle";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(324, 385);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteStudent.TabIndex = 6;
            this.btnDeleteStudent.Text = "Öğrenci Sil";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblSystemUser);
            this.Controls.Add(this.btnDataGridViewPrint);
            this.Controls.Add(this.btnAddNewStudent);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAddNewStudent;
        private System.Windows.Forms.Button btnDataGridViewPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Label lblSystemUser;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
    }
}

