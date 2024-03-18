namespace CRM.Admin.Bank
{
    partial class frmBankAccountInfo
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
            this.ctrlPersonalInformation1 = new CRM.Admin.Customers.ctrlPersonalInformation();
            this.ctrlBankAccountInfo1 = new CRM.Admin.Bank.Control.ctrlBankAccountInfo();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ctrlPersonalInformation1
            // 
            this.ctrlPersonalInformation1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonalInformation1.Location = new System.Drawing.Point(12, 12);
            this.ctrlPersonalInformation1.Name = "ctrlPersonalInformation1";
            this.ctrlPersonalInformation1.Size = new System.Drawing.Size(685, 438);
            this.ctrlPersonalInformation1.TabIndex = 0;
            // 
            // ctrlBankAccountInfo1
            // 
            this.ctrlBankAccountInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlBankAccountInfo1.Location = new System.Drawing.Point(703, 12);
            this.ctrlBankAccountInfo1.Name = "ctrlBankAccountInfo1";
            this.ctrlBankAccountInfo1.Size = new System.Drawing.Size(822, 286);
            this.ctrlBankAccountInfo1.TabIndex = 1;
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
            this.btnBack.Location = new System.Drawing.Point(737, 381);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 45);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmBankAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1531, 470);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ctrlBankAccountInfo1);
            this.Controls.Add(this.ctrlPersonalInformation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmBankAccountInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Account Info";
            this.Load += new System.EventHandler(this.frmBankAccountInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Customers.ctrlPersonalInformation ctrlPersonalInformation1;
        private Control.ctrlBankAccountInfo ctrlBankAccountInfo1;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}