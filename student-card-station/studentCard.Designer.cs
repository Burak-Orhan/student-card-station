namespace student_card_station
{
    partial class studentCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentCard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCardPrint = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCardPrint
            // 
            this.btnCardPrint.Location = new System.Drawing.Point(12, 356);
            this.btnCardPrint.Name = "btnCardPrint";
            this.btnCardPrint.Size = new System.Drawing.Size(521, 30);
            this.btnCardPrint.TabIndex = 1;
            this.btnCardPrint.Text = "Kartı Yazdır";
            this.btnCardPrint.UseVisualStyleBackColor = true;
            this.btnCardPrint.Click += new System.EventHandler(this.btnCardPrint_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 140);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 21);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "txtName";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(159, 164);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(150, 21);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.Text = "txtSurname";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(160, 188);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(150, 21);
            this.txtDepartment.TabIndex = 4;
            this.txtDepartment.Text = "txtDepartment";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(184, 214);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(125, 21);
            this.txtNo.TabIndex = 5;
            this.txtNo.Text = "txtNo";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // studentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 398);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCardPrint);
            this.Controls.Add(this.pictureBox1);
            this.Name = "studentCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentCard";
            this.Load += new System.EventHandler(this.studentCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCardPrint;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtSurname;
        private System.Windows.Forms.Label txtDepartment;
        private System.Windows.Forms.Label txtNo;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}