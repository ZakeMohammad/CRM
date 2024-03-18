namespace CRM.Admin.Customers.Controls
{
    partial class ctrlCustomerInfoWithFillter
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
            this.TxtSearchByID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.ctrlPersonalInformation1 = new CRM.Admin.Customers.ctrlPersonalInformation();
            this.SuspendLayout();
            // 
            // TxtSearchByID
            // 
            this.TxtSearchByID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtSearchByID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearchByID.DefaultText = "";
            this.TxtSearchByID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSearchByID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSearchByID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearchByID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearchByID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearchByID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtSearchByID.ForeColor = System.Drawing.Color.Black;
            this.TxtSearchByID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearchByID.Location = new System.Drawing.Point(29, 42);
            this.TxtSearchByID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSearchByID.Name = "TxtSearchByID";
            this.TxtSearchByID.PasswordChar = '\0';
            this.TxtSearchByID.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtSearchByID.PlaceholderText = "Customer ID";
            this.TxtSearchByID.SelectedText = "";
            this.TxtSearchByID.ShadowDecoration.Color = System.Drawing.Color.DarkOrange;
            this.TxtSearchByID.Size = new System.Drawing.Size(728, 30);
            this.TxtSearchByID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtSearchByID.TabIndex = 1;
            this.TxtSearchByID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
           
            this.TxtSearchByID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchByID_KeyPress);
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
            this.btnSearch.Location = new System.Drawing.Point(763, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearch.Size = new System.Drawing.Size(63, 59);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(3, 92);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(823, 10);
            this.guna2Separator1.TabIndex = 22;
            // 
            // ctrlPersonalInformation1
            // 
            this.ctrlPersonalInformation1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonalInformation1.Location = new System.Drawing.Point(3, 111);
            this.ctrlPersonalInformation1.Name = "ctrlPersonalInformation1";
            this.ctrlPersonalInformation1.Size = new System.Drawing.Size(823, 438);
            this.ctrlPersonalInformation1.TabIndex = 3;
            // 
            // ctrlCustomerInfoWithFillter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.ctrlPersonalInformation1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TxtSearchByID);
            this.Name = "ctrlCustomerInfoWithFillter";
            this.Size = new System.Drawing.Size(847, 564);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TxtSearchByID;
        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
        private ctrlPersonalInformation ctrlPersonalInformation1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
