namespace student_card_station
{
    partial class studentCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.cmbStudentDepartment = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgStudentPicture = new System.Windows.Forms.PictureBox();
            this.btnStudentAddPicture = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(147, 9);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(237, 22);
            this.txtStudentName.TabIndex = 0;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Location = new System.Drawing.Point(147, 50);
            this.txtStudentSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(237, 22);
            this.txtStudentSurname.TabIndex = 1;
            // 
            // cmbStudentDepartment
            // 
            this.cmbStudentDepartment.FormattingEnabled = true;
            this.cmbStudentDepartment.Location = new System.Drawing.Point(147, 92);
            this.cmbStudentDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStudentDepartment.Name = "cmbStudentDepartment";
            this.cmbStudentDepartment.Size = new System.Drawing.Size(237, 24);
            this.cmbStudentDepartment.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(16, 235);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(369, 34);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Kaydı Tamamla";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğrenci Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Öğrenci Soyadı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Öğrenci Bölümü:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imgStudentPicture
            // 
            this.imgStudentPicture.Location = new System.Drawing.Point(411, 9);
            this.imgStudentPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgStudentPicture.Name = "imgStudentPicture";
            this.imgStudentPicture.Size = new System.Drawing.Size(239, 261);
            this.imgStudentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStudentPicture.TabIndex = 8;
            this.imgStudentPicture.TabStop = false;
            // 
            // btnStudentAddPicture
            // 
            this.btnStudentAddPicture.Location = new System.Drawing.Point(16, 137);
            this.btnStudentAddPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStudentAddPicture.Name = "btnStudentAddPicture";
            this.btnStudentAddPicture.Size = new System.Drawing.Size(369, 34);
            this.btnStudentAddPicture.TabIndex = 9;
            this.btnStudentAddPicture.Text = "Öğrenci Resimi Seçin";
            this.btnStudentAddPicture.UseVisualStyleBackColor = true;
            this.btnStudentAddPicture.Click += new System.EventHandler(this.btnStudentAddPicture_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // studentCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 278);
            this.Controls.Add(this.btnStudentAddPicture);
            this.Controls.Add(this.imgStudentPicture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmbStudentDepartment);
            this.Controls.Add(this.txtStudentSurname);
            this.Controls.Add(this.txtStudentName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "studentCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentCreate";
            this.Load += new System.EventHandler(this.studentCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgStudentPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.ComboBox cmbStudentDepartment;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgStudentPicture;
        private System.Windows.Forms.Button btnStudentAddPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}