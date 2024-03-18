namespace CRM.Customer
{
    partial class frmProileForCustomers
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
            this.PanelForOrder = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelForAddEditFrm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlPersonalInformation1 = new CRM.Admin.Customers.ctrlPersonalInformation();
            this.PanelForOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelForOrder
            // 
            this.PanelForOrder.AutoScroll = true;
            this.PanelForOrder.BackColor = System.Drawing.Color.Transparent;
            this.PanelForOrder.BorderThickness = 1;
            this.PanelForOrder.Controls.Add(this.pictureBox1);
            this.PanelForOrder.Controls.Add(this.label1);
            this.PanelForOrder.Controls.Add(this.ctrlPersonalInformation1);
            this.PanelForOrder.Controls.Add(this.PanelForAddEditFrm);
            this.PanelForOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForOrder.FillColor = System.Drawing.Color.White;
            this.PanelForOrder.Location = new System.Drawing.Point(0, 0);
            this.PanelForOrder.Name = "PanelForOrder";
            this.PanelForOrder.ShadowDecoration.BorderRadius = 0;
            this.PanelForOrder.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.PanelForOrder.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.PanelForOrder.Size = new System.Drawing.Size(1928, 808);
            this.PanelForOrder.TabIndex = 5;
            // 
            // PanelForAddEditFrm
            // 
            this.PanelForAddEditFrm.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelForAddEditFrm.Location = new System.Drawing.Point(550, 0);
            this.PanelForAddEditFrm.Name = "PanelForAddEditFrm";
            this.PanelForAddEditFrm.Size = new System.Drawing.Size(1378, 808);
            this.PanelForAddEditFrm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Profile :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRM.Properties.Resources.verified;
            this.pictureBox1.Location = new System.Drawing.Point(13, 552);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ctrlPersonalInformation1
            // 
            this.ctrlPersonalInformation1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonalInformation1.Location = new System.Drawing.Point(13, 94);
            this.ctrlPersonalInformation1.Name = "ctrlPersonalInformation1";
            this.ctrlPersonalInformation1.Size = new System.Drawing.Size(402, 438);
            this.ctrlPersonalInformation1.TabIndex = 1;
            // 
            // frmProileForCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1928, 808);
            this.Controls.Add(this.PanelForOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProileForCustomers";
            this.Tag = "Profile";
            this.Text = "frmProileForCustomers";
            this.Load += new System.EventHandler(this.frmProileForCustomers_Load);
            this.PanelForOrder.ResumeLayout(false);
            this.PanelForOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelForOrder;
        private System.Windows.Forms.Panel PanelForAddEditFrm;
        private System.Windows.Forms.Label label1;
        private Admin.Customers.ctrlPersonalInformation ctrlPersonalInformation1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}