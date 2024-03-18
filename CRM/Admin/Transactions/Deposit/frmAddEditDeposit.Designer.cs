namespace CRM.Admin.Transactions.Deposit
{
    partial class frmAddEditDeposit
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
            this.PanelForDeposit = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnAddAmmount = new Guna.UI2.WinForms.Guna2CircleButton();
            this.TxtAmmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlBankAccountWithFillter1 = new CRM.Admin.Bank.Control.ctrlBankAccountWithFillter();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelForDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelForDeposit
            // 
            this.PanelForDeposit.BackColor = System.Drawing.Color.Transparent;
            this.PanelForDeposit.BorderRadius = 30;
            this.PanelForDeposit.BorderThickness = 1;
            this.PanelForDeposit.Controls.Add(this.label2);
            this.PanelForDeposit.Controls.Add(this.guna2CirclePictureBox1);
            this.PanelForDeposit.Controls.Add(this.btnAddAmmount);
            this.PanelForDeposit.Controls.Add(this.TxtAmmount);
            this.PanelForDeposit.Controls.Add(this.label1);
            this.PanelForDeposit.Controls.Add(this.ctrlBankAccountWithFillter1);
            this.PanelForDeposit.FillColor = System.Drawing.Color.White;
            this.PanelForDeposit.Location = new System.Drawing.Point(107, 67);
            this.PanelForDeposit.Name = "PanelForDeposit";
            this.PanelForDeposit.ShadowDecoration.BorderRadius = 10;
            this.PanelForDeposit.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.PanelForDeposit.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.PanelForDeposit.Size = new System.Drawing.Size(1445, 686);
            this.PanelForDeposit.TabIndex = 2;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::CRM.Properties.Resources.back;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1368, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 11;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // btnAddAmmount
            // 
            this.btnAddAmmount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAmmount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAmmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAmmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAmmount.FillColor = System.Drawing.Color.Transparent;
            this.btnAddAmmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddAmmount.ForeColor = System.Drawing.Color.White;
            this.btnAddAmmount.Image = global::CRM.Properties.Resources.deposit;
            this.btnAddAmmount.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddAmmount.Location = new System.Drawing.Point(637, 630);
            this.btnAddAmmount.Name = "btnAddAmmount";
            this.btnAddAmmount.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddAmmount.Size = new System.Drawing.Size(392, 47);
            this.btnAddAmmount.TabIndex = 3;
            this.btnAddAmmount.Click += new System.EventHandler(this.btnAddAmmount_Click);
            // 
            // TxtAmmount
            // 
            this.TxtAmmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            this.TxtAmmount.Location = new System.Drawing.Point(506, 512);
            this.TxtAmmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtAmmount.Name = "TxtAmmount";
            this.TxtAmmount.PasswordChar = '\0';
            this.TxtAmmount.PlaceholderText = "Enter Ammount To Deposit";
            this.TxtAmmount.SelectedText = "";
            this.TxtAmmount.Size = new System.Drawing.Size(638, 33);
            this.TxtAmmount.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtAmmount.TabIndex = 2;
            this.TxtAmmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtAmmount.TextChanged += new System.EventHandler(this.TxtAmmount_TextChanged);
            this.TxtAmmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAmmount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ammount :";
            // 
            // ctrlBankAccountWithFillter1
            // 
            this.ctrlBankAccountWithFillter1.BackColor = System.Drawing.Color.White;
            this.ctrlBankAccountWithFillter1.Location = new System.Drawing.Point(292, 73);
            this.ctrlBankAccountWithFillter1.Name = "ctrlBankAccountWithFillter1";
            this.ctrlBankAccountWithFillter1.Size = new System.Drawing.Size(852, 387);
            this.ctrlBankAccountWithFillter1.TabIndex = 0;
            this.ctrlBankAccountWithFillter1.OnBankExist += new System.Action<CRM_BussinsLayer.clsBanksAccount>(this.ctrlBankAccountWithFillter1_OnBankExist);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 42);
            this.label2.TabIndex = 29;
            this.label2.Text = "𝒟𝑒𝓅𝑜𝓈𝒾𝓉 𝒮𝒸𝓇𝑒𝑒𝓃 ঌ";
            // 
            // frmAddEditDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 848);
            this.Controls.Add(this.PanelForDeposit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditDeposit";
            this.Tag = "Deposit";
            this.Text = "frmAddEditDeposit";
            this.PanelForDeposit.ResumeLayout(false);
            this.PanelForDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelForDeposit;
        private Bank.Control.ctrlBankAccountWithFillter ctrlBankAccountWithFillter1;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddAmmount;
        private Guna.UI2.WinForms.Guna2TextBox TxtAmmount;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label2;
    }
}