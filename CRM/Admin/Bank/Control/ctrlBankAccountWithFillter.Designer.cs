namespace CRM.Admin.Bank.Control
{
    partial class ctrlBankAccountWithFillter
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
            this.TxtSearchByAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ctrlBankAccountInfo1 = new CRM.Admin.Bank.Control.ctrlBankAccountInfo();
            this.SuspendLayout();
            // 
            // TxtSearchByAccountNumber
            // 
            this.TxtSearchByAccountNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtSearchByAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearchByAccountNumber.DefaultText = "";
            this.TxtSearchByAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSearchByAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSearchByAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearchByAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearchByAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearchByAccountNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtSearchByAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.TxtSearchByAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearchByAccountNumber.Location = new System.Drawing.Point(17, 27);
            this.TxtSearchByAccountNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSearchByAccountNumber.Name = "TxtSearchByAccountNumber";
            this.TxtSearchByAccountNumber.PasswordChar = '\0';
            this.TxtSearchByAccountNumber.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtSearchByAccountNumber.PlaceholderText = "Account Number";
            this.TxtSearchByAccountNumber.SelectedText = "";
            this.TxtSearchByAccountNumber.ShadowDecoration.Color = System.Drawing.Color.DarkOrange;
            this.TxtSearchByAccountNumber.Size = new System.Drawing.Size(753, 30);
            this.TxtSearchByAccountNumber.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtSearchByAccountNumber.TabIndex = 3;
            this.TxtSearchByAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
          
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::CRM.Properties.Resources.search__1_;
            this.btnSearch.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSearch.Location = new System.Drawing.Point(776, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearch.Size = new System.Drawing.Size(63, 59);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ctrlBankAccountInfo1
            // 
            this.ctrlBankAccountInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlBankAccountInfo1.Location = new System.Drawing.Point(17, 77);
            this.ctrlBankAccountInfo1.Name = "ctrlBankAccountInfo1";
            this.ctrlBankAccountInfo1.Size = new System.Drawing.Size(822, 286);
            this.ctrlBankAccountInfo1.TabIndex = 5;
            // 
            // ctrlBankAccountWithFillter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlBankAccountInfo1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TxtSearchByAccountNumber);
            this.Name = "ctrlBankAccountWithFillter";
            this.Size = new System.Drawing.Size(852, 387);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearchByAccountNumber;
        private ctrlBankAccountInfo ctrlBankAccountInfo1;
    }
}
