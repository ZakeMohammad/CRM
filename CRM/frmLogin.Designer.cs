namespace CRM
{
    partial class frmLogin
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.RDCustomer = new System.Windows.Forms.RadioButton();
            this.RDAdmin = new System.Windows.Forms.RadioButton();
            this.ctrlloginAsAdmin1 = new CRM.ctrlloginAsAdmin();
            this.ctrlLoginAsCustomer1 = new CRM.ctrlLoginAsCustomer();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Navy;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Linen;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Navy;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Navy;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(889, 66);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Light", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(163, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer relationship management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CRM.Properties.Resources.switch__1_3;
            this.pictureBox1.Location = new System.Drawing.Point(837, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login As :";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 131);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(951, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // RDCustomer
            // 
            this.RDCustomer.AutoSize = true;
            this.RDCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RDCustomer.Location = new System.Drawing.Point(278, 92);
            this.RDCustomer.Name = "RDCustomer";
            this.RDCustomer.Size = new System.Drawing.Size(103, 24);
            this.RDCustomer.TabIndex = 3;
            this.RDCustomer.TabStop = true;
            this.RDCustomer.Text = "Customer";
            this.RDCustomer.UseVisualStyleBackColor = true;
            this.RDCustomer.CheckedChanged += new System.EventHandler(this.RDCustomer_CheckedChanged);
            // 
            // RDAdmin
            // 
            this.RDAdmin.AutoSize = true;
            this.RDAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDAdmin.ForeColor = System.Drawing.Color.Navy;
            this.RDAdmin.Location = new System.Drawing.Point(171, 92);
            this.RDAdmin.Name = "RDAdmin";
            this.RDAdmin.Size = new System.Drawing.Size(77, 24);
            this.RDAdmin.TabIndex = 4;
            this.RDAdmin.TabStop = true;
            this.RDAdmin.Text = "Admin";
            this.RDAdmin.UseVisualStyleBackColor = true;
            this.RDAdmin.CheckedChanged += new System.EventHandler(this.RDAdmin_CheckedChanged);
            // 
            // ctrlloginAsAdmin1
            // 
            this.ctrlloginAsAdmin1.BackColor = System.Drawing.Color.White;
            this.ctrlloginAsAdmin1.Location = new System.Drawing.Point(66, 156);
            this.ctrlloginAsAdmin1.Name = "ctrlloginAsAdmin1";
            this.ctrlloginAsAdmin1.Size = new System.Drawing.Size(759, 329);
            this.ctrlloginAsAdmin1.TabIndex = 7;
            this.ctrlloginAsAdmin1.IsLogin += new System.Action<bool>(this.ctrlloginAsAdmin1_IsLogin);
            // 
            // ctrlLoginAsCustomer1
            // 
            this.ctrlLoginAsCustomer1.BackColor = System.Drawing.Color.White;
            this.ctrlLoginAsCustomer1.Location = new System.Drawing.Point(66, 156);
            this.ctrlLoginAsCustomer1.Name = "ctrlLoginAsCustomer1";
            this.ctrlLoginAsCustomer1.Size = new System.Drawing.Size(759, 329);
            this.ctrlLoginAsCustomer1.TabIndex = 6;
            this.ctrlLoginAsCustomer1.IsLogin += new System.Action<bool>(this.ctrlLoginAsCustomer1_IsLogin);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 497);
            this.Controls.Add(this.ctrlloginAsAdmin1);
            this.Controls.Add(this.ctrlLoginAsCustomer1);
            this.Controls.Add(this.RDAdmin);
            this.Controls.Add(this.RDCustomer);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.RadioButton RDCustomer;
        private System.Windows.Forms.RadioButton RDAdmin;
        private System.Windows.Forms.Label label2;
        private ctrlLoginAsCustomer ctrlLoginAsCustomer1;
        private ctrlloginAsAdmin ctrlloginAsAdmin1;
    }
}