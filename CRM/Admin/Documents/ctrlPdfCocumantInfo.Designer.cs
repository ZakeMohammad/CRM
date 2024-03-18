namespace CRM.Admin.Documents
{
    partial class ctrlPdfCocumantInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtFilePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPDFName = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnShowInfo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnShowInfo);
            this.groupBox1.Controls.Add(this.TxtFilePath);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblPDFName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TxtFilePath
            // 
            this.TxtFilePath.BorderColor = System.Drawing.Color.DimGray;
            this.TxtFilePath.BorderRadius = 15;
            this.TxtFilePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFilePath.DefaultText = "";
            this.TxtFilePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtFilePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtFilePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFilePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFilePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtFilePath.ForeColor = System.Drawing.Color.Black;
            this.TxtFilePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFilePath.Location = new System.Drawing.Point(14, 187);
            this.TxtFilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtFilePath.Multiline = true;
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.PasswordChar = '\0';
            this.TxtFilePath.PlaceholderText = "";
            this.TxtFilePath.ReadOnly = true;
            this.TxtFilePath.SelectedText = "";
            this.TxtFilePath.Size = new System.Drawing.Size(369, 83);
            this.TxtFilePath.TabIndex = 16;
            // 
            // lblPDFName
            // 
            this.lblPDFName.AutoSize = true;
            this.lblPDFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDFName.Location = new System.Drawing.Point(85, 158);
            this.lblPDFName.Name = "lblPDFName";
            this.lblPDFName.Size = new System.Drawing.Size(64, 25);
            this.lblPDFName.TabIndex = 14;
            this.lblPDFName.Text = "label1";
            // 
            // btnSend
            // 
            this.btnSend.Image = global::CRM.Properties.Resources.send;
            this.btnSend.Location = new System.Drawing.Point(348, 119);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(42, 40);
            this.btnSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSend.TabIndex = 19;
            this.btnSend.TabStop = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::CRM.Properties.Resources.delete__4_;
            this.btnDelete.Location = new System.Drawing.Point(348, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(42, 40);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 18;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Image = global::CRM.Properties.Resources.information;
            this.btnShowInfo.Location = new System.Drawing.Point(348, 27);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(42, 40);
            this.btnShowInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowInfo.TabIndex = 17;
            this.btnShowInfo.TabStop = false;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRM.Properties.Resources.pdf_file_format;
            this.pictureBox1.Location = new System.Drawing.Point(43, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlPdfCocumantInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlPdfCocumantInfo";
            this.Size = new System.Drawing.Size(396, 286);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox TxtFilePath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPDFName;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnShowInfo;
        private System.Windows.Forms.PictureBox btnSend;
    }
}
