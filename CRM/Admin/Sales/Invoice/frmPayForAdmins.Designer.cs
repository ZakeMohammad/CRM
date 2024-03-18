namespace CRM.Admin.Sales.Invoice
{
    partial class frmPayForAdmins
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerAccount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtDescriptoin = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtAmmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBGategoryes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CBMethods = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCancle = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // lblCustomerAccount
            // 
            this.lblCustomerAccount.AutoSize = true;
            this.lblCustomerAccount.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F);
            this.lblCustomerAccount.Location = new System.Drawing.Point(309, 78);
            this.lblCustomerAccount.Name = "lblCustomerAccount";
            this.lblCustomerAccount.Size = new System.Drawing.Size(70, 23);
            this.lblCustomerAccount.TabIndex = 1;
            this.lblCustomerAccount.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descriptoin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ammount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gategory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Customer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(186, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Method";
            // 
            // TxtDate
            // 
            this.TxtDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TxtDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDate.DefaultText = "";
            this.TxtDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtDate.ForeColor = System.Drawing.Color.Black;
            this.TxtDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDate.Location = new System.Drawing.Point(314, 142);
            this.TxtDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.PasswordChar = '\0';
            this.TxtDate.PlaceholderText = "";
            this.TxtDate.ReadOnly = true;
            this.TxtDate.SelectedText = "";
            this.TxtDate.Size = new System.Drawing.Size(1021, 29);
            this.TxtDate.TabIndex = 8;
            // 
            // TxtDescriptoin
            // 
            this.TxtDescriptoin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TxtDescriptoin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDescriptoin.DefaultText = "";
            this.TxtDescriptoin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDescriptoin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDescriptoin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDescriptoin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDescriptoin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDescriptoin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtDescriptoin.ForeColor = System.Drawing.Color.Black;
            this.TxtDescriptoin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDescriptoin.Location = new System.Drawing.Point(314, 217);
            this.TxtDescriptoin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDescriptoin.Name = "TxtDescriptoin";
            this.TxtDescriptoin.PasswordChar = '\0';
            this.TxtDescriptoin.PlaceholderText = "";
            this.TxtDescriptoin.ReadOnly = true;
            this.TxtDescriptoin.SelectedText = "";
            this.TxtDescriptoin.Size = new System.Drawing.Size(1021, 29);
            this.TxtDescriptoin.TabIndex = 9;
            // 
            // TxtAmmount
            // 
            this.TxtAmmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TxtAmmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAmmount.DefaultText = "";
            this.TxtAmmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtAmmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtAmmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAmmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAmmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAmmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtAmmount.ForeColor = System.Drawing.Color.Black;
            this.TxtAmmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAmmount.Location = new System.Drawing.Point(313, 290);
            this.TxtAmmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtAmmount.Name = "TxtAmmount";
            this.TxtAmmount.PasswordChar = '\0';
            this.TxtAmmount.PlaceholderText = "";
            this.TxtAmmount.ReadOnly = true;
            this.TxtAmmount.SelectedText = "";
            this.TxtAmmount.Size = new System.Drawing.Size(1021, 29);
            this.TxtAmmount.TabIndex = 10;
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TxtCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCustomer.DefaultText = "";
            this.TxtCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCustomer.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TxtCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtCustomer.ForeColor = System.Drawing.Color.Black;
            this.TxtCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCustomer.Location = new System.Drawing.Point(314, 458);
            this.TxtCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.PasswordChar = '\0';
            this.TxtCustomer.PlaceholderText = "";
            this.TxtCustomer.ReadOnly = true;
            this.TxtCustomer.SelectedText = "";
            this.TxtCustomer.Size = new System.Drawing.Size(1021, 29);
            this.TxtCustomer.TabIndex = 11;
            // 
            // CBGategoryes
            // 
            this.CBGategoryes.BackColor = System.Drawing.Color.Transparent;
            this.CBGategoryes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CBGategoryes.BorderRadius = 15;
            this.CBGategoryes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBGategoryes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGategoryes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBGategoryes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBGategoryes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBGategoryes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBGategoryes.ItemHeight = 30;
            this.CBGategoryes.Location = new System.Drawing.Point(314, 378);
            this.CBGategoryes.Name = "CBGategoryes";
            this.CBGategoryes.Size = new System.Drawing.Size(312, 36);
            this.CBGategoryes.TabIndex = 12;
            // 
            // CBMethods
            // 
            this.CBMethods.BackColor = System.Drawing.Color.Transparent;
            this.CBMethods.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CBMethods.BorderRadius = 15;
            this.CBMethods.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMethods.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBMethods.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBMethods.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBMethods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBMethods.ItemHeight = 30;
            this.CBMethods.Location = new System.Drawing.Point(313, 524);
            this.CBMethods.Name = "CBMethods";
            this.CBMethods.Size = new System.Drawing.Size(312, 36);
            this.CBMethods.TabIndex = 13;
            // 
            // btnCancle
            // 
            this.btnCancle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancle.FillColor = System.Drawing.Color.IndianRed;
            this.btnCancle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.Location = new System.Drawing.Point(1224, 628);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(111, 41);
            this.btnCancle.TabIndex = 51;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::CRM.Properties.Resources.check__1_;
            this.btnSave.Location = new System.Drawing.Point(1094, 629);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 41);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.lblInvoiceID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1459, 63);
            this.panel1.TabIndex = 52;
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F);
            this.lblInvoiceID.Location = new System.Drawing.Point(186, 18);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(22, 23);
            this.lblInvoiceID.TabIndex = 54;
            this.lblInvoiceID.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 13.8F);
            this.label8.Location = new System.Drawing.Point(63, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 53;
            this.label8.Text = "Invoice #";
            // 
            // frmPayForAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1459, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.CBMethods);
            this.Controls.Add(this.CBGategoryes);
            this.Controls.Add(this.TxtCustomer);
            this.Controls.Add(this.TxtAmmount);
            this.Controls.Add(this.TxtDescriptoin);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustomerAccount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayForAdmins";
            this.Load += new System.EventHandler(this.frmPayForAdmins_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox TxtDate;
        private Guna.UI2.WinForms.Guna2TextBox TxtDescriptoin;
        private Guna.UI2.WinForms.Guna2TextBox TxtAmmount;
        private Guna.UI2.WinForms.Guna2TextBox TxtCustomer;
        private Guna.UI2.WinForms.Guna2ComboBox CBGategoryes;
        private Guna.UI2.WinForms.Guna2ComboBox CBMethods;
        private Guna.UI2.WinForms.Guna2Button btnCancle;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.Label label8;
    }
}