namespace CRM.Admin.Customers
{
    partial class frmCustomerInfo
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
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPersonalInformation1 = new CRM.Admin.Customers.ctrlPersonalInformation();
            this.lbllinkToOpenFomr = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 20;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::CRM.Properties.Resources.arrow_left;
            this.btnBack.Location = new System.Drawing.Point(170, 505);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 45);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ctrlPersonalInformation1
            // 
            this.ctrlPersonalInformation1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonalInformation1.Location = new System.Drawing.Point(12, 3);
            this.ctrlPersonalInformation1.Name = "ctrlPersonalInformation1";
            this.ctrlPersonalInformation1.Size = new System.Drawing.Size(489, 438);
            this.ctrlPersonalInformation1.TabIndex = 3;
            // 
            // lbllinkToOpenFomr
            // 
            this.lbllinkToOpenFomr.AutoSize = true;
            this.lbllinkToOpenFomr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinkToOpenFomr.Location = new System.Drawing.Point(178, 454);
            this.lbllinkToOpenFomr.Name = "lbllinkToOpenFomr";
            this.lbllinkToOpenFomr.Size = new System.Drawing.Size(136, 22);
            this.lbllinkToOpenFomr.TabIndex = 24;
            this.lbllinkToOpenFomr.TabStop = true;
            this.lbllinkToOpenFomr.Text = "Log in directly...";
            this.lbllinkToOpenFomr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllinkToOpenFomr_LinkClicked);
            // 
            // frmCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 562);
            this.Controls.Add(this.lbllinkToOpenFomr);
            this.Controls.Add(this.ctrlPersonalInformation1);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCustomerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Info";
            this.Load += new System.EventHandler(this.frmCustomerInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private ctrlPersonalInformation ctrlPersonalInformation1;
        private System.Windows.Forms.LinkLabel lbllinkToOpenFomr;
    }
}