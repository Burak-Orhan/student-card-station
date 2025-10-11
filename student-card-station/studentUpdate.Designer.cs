namespace student_card_station
{
    partial class studentUpdate
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
            this.btnStudentUpdatePicture = new System.Windows.Forms.Button();
            this.imgStudentPicture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbStudentDepartment = new System.Windows.Forms.ComboBox();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudentUpdatePicture
            // 
            this.btnStudentUpdatePicture.Location = new System.Drawing.Point(16, 135);
            this.btnStudentUpdatePicture.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentUpdatePicture.Name = "btnStudentUpdatePicture";
            this.btnStudentUpdatePicture.Size = new System.Drawing.Size(369, 34);
            this.btnStudentUpdatePicture.TabIndex = 18;
            this.btnStudentUpdatePicture.Text = "Öğrenci Resimi Güncelleyin";
            this.btnStudentUpdatePicture.UseVisualStyleBackColor = true;
            this.btnStudentUpdatePicture.Click += new System.EventHandler(this.btnStudentUpdatePicture_Click);
            // 
            // imgStudentPicture
            // 
            this.imgStudentPicture.Location = new System.Drawing.Point(411, 9);
            this.imgStudentPicture.Margin = new System.Windows.Forms.Padding(4);
            this.imgStudentPicture.Name = "imgStudentPicture";
            this.imgStudentPicture.Size = new System.Drawing.Size(239, 261);
            this.imgStudentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStudentPicture.TabIndex = 17;
            this.imgStudentPicture.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Öğrenci Bölümü:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Öğrenci Soyadı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Öğrenci Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(16, 233);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(369, 34);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Güncelleme İşlemini Tamamla";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbStudentDepartment
            // 
            this.cmbStudentDepartment.FormattingEnabled = true;
            this.cmbStudentDepartment.Location = new System.Drawing.Point(147, 90);
            this.cmbStudentDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStudentDepartment.Name = "cmbStudentDepartment";
            this.cmbStudentDepartment.Size = new System.Drawing.Size(237, 24);
            this.cmbStudentDepartment.TabIndex = 12;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Location = new System.Drawing.Point(147, 48);
            this.txtStudentSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(237, 22);
            this.txtStudentSurname.TabIndex = 11;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(147, 7);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(237, 22);
            this.txtStudentName.TabIndex = 10;
            // 
            // studentUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 278);
            this.Controls.Add(this.btnStudentUpdatePicture);
            this.Controls.Add(this.imgStudentPicture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbStudentDepartment);
            this.Controls.Add(this.txtStudentSurname);
            this.Controls.Add(this.txtStudentName);
            this.Name = "studentUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentUpdate";
            this.Load += new System.EventHandler(this.studentUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgStudentPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentUpdatePicture;
        private System.Windows.Forms.PictureBox imgStudentPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbStudentDepartment;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.TextBox txtStudentName;
    }
}