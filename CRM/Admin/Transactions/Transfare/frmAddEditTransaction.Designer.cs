namespace CRM.Admin.Transactions
{
    partial class frmAddEditTransaction
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
            this.PanelForAddEditTransaction = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnTransfare = new Guna.UI2.WinForms.Guna2CircleButton();
            this.TxtAmmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTransfareTo = new System.Windows.Forms.Label();
            this.lblTransfareFrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlBankAccountWithFillter2 = new CRM.Admin.Bank.Control.ctrlBankAccountWithFillter();
            this.ctrlBankAccountWithFillter1 = new CRM.Admin.Bank.Control.ctrlBankAccountWithFillter();
            this.PanelForAddEditTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelForAddEditTransaction
            // 
            this.PanelForAddEditTransaction.BackColor = System.Drawing.Color.Transparent;
            this.PanelForAddEditTransaction.BorderRadius = 30;
            this.PanelForAddEditTransaction.BorderThickness = 1;
            this.PanelForAddEditTransaction.Controls.Add(this.guna2CirclePictureBox1);
            this.PanelForAddEditTransaction.Controls.Add(this.btnTransfare);
            this.PanelForAddEditTransaction.Controls.Add(this.TxtAmmount);
            this.PanelForAddEditTransaction.Controls.Add(this.label3);
            this.PanelForAddEditTransaction.Controls.Add(this.lblTransfareTo);
            this.PanelForAddEditTransaction.Controls.Add(this.lblTransfareFrom);
            this.PanelForAddEditTransaction.Controls.Add(this.label2);
            this.PanelForAddEditTransaction.Controls.Add(this.label1);
            this.PanelForAddEditTransaction.Controls.Add(this.ctrlBankAccountWithFillter2);
            this.PanelForAddEditTransaction.Controls.Add(this.ctrlBankAccountWithFillter1);
            this.PanelForAddEditTransaction.FillColor = System.Drawing.Color.White;
            this.PanelForAddEditTransaction.Location = new System.Drawing.Point(46, 33);
            this.PanelForAddEditTransaction.Name = "PanelForAddEditTransaction";
            this.PanelForAddEditTransaction.ShadowDecoration.BorderRadius = 10;
            this.PanelForAddEditTransaction.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.PanelForAddEditTransaction.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.PanelForAddEditTransaction.Size = new System.Drawing.Size(1558, 736);
            this.PanelForAddEditTransaction.TabIndex = 2;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::CRM.Properties.Resources.back;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1491, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 9;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // btnTransfare
            // 
            this.btnTransfare.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfare.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfare.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransfare.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransfare.Enabled = false;
            this.btnTransfare.FillColor = System.Drawing.Color.White;
            this.btnTransfare.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTransfare.ForeColor = System.Drawing.Color.White;
            this.btnTransfare.Image = global::CRM.Properties.Resources.transaction__2_1;
            this.btnTransfare.ImageSize = new System.Drawing.Size(120, 120);
            this.btnTransfare.Location = new System.Drawing.Point(1059, 480);
            this.btnTransfare.Name = "btnTransfare";
            this.btnTransfare.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnTransfare.Size = new System.Drawing.Size(273, 177);
            this.btnTransfare.TabIndex = 8;
            this.btnTransfare.Click += new System.EventHandler(this.btnTransfare_Click);
            // 
            // TxtAmmount
            // 
            this.TxtAmmount.BorderColor = System.Drawing.Color.Blue;
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
            this.TxtAmmount.Location = new System.Drawing.Point(954, 393);
            this.TxtAmmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtAmmount.Name = "TxtAmmount";
            this.TxtAmmount.PasswordChar = '\0';
            this.TxtAmmount.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtAmmount.PlaceholderText = "Enter Ammount To Transfare Here";
            this.TxtAmmount.SelectedText = "";
            this.TxtAmmount.Size = new System.Drawing.Size(577, 26);
            this.TxtAmmount.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtAmmount.TabIndex = 7;
            this.TxtAmmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtAmmount.TextChanged += new System.EventHandler(this.TxtAmmount_TextChanged);
            this.TxtAmmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAmmount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(949, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ammount :";
            // 
            // lblTransfareTo
            // 
            this.lblTransfareTo.AutoSize = true;
            this.lblTransfareTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransfareTo.Location = new System.Drawing.Point(1255, 213);
            this.lblTransfareTo.Name = "lblTransfareTo";
            this.lblTransfareTo.Size = new System.Drawing.Size(0, 22);
            this.lblTransfareTo.TabIndex = 5;
            // 
            // lblTransfareFrom
            // 
            this.lblTransfareFrom.AutoSize = true;
            this.lblTransfareFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransfareFrom.Location = new System.Drawing.Point(1255, 118);
            this.lblTransfareFrom.Name = "lblTransfareFrom";
            this.lblTransfareFrom.Size = new System.Drawing.Size(0, 22);
            this.lblTransfareFrom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(949, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transfare To Account :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(949, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transfare From Account :";
            // 
            // ctrlBankAccountWithFillter2
            // 
            this.ctrlBankAccountWithFillter2.BackColor = System.Drawing.Color.White;
            this.ctrlBankAccountWithFillter2.Location = new System.Drawing.Point(3, 376);
            this.ctrlBankAccountWithFillter2.Name = "ctrlBankAccountWithFillter2";
            this.ctrlBankAccountWithFillter2.Size = new System.Drawing.Size(848, 357);
            this.ctrlBankAccountWithFillter2.TabIndex = 1;
            this.ctrlBankAccountWithFillter2.OnBankExist += new System.Action<CRM_BussinsLayer.clsBanksAccount>(this.ctrlBankAccountWithFillter2_OnBankExist);
            // 
            // ctrlBankAccountWithFillter1
            // 
            this.ctrlBankAccountWithFillter1.BackColor = System.Drawing.Color.White;
            this.ctrlBankAccountWithFillter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlBankAccountWithFillter1.Name = "ctrlBankAccountWithFillter1";
            this.ctrlBankAccountWithFillter1.Size = new System.Drawing.Size(848, 357);
            this.ctrlBankAccountWithFillter1.TabIndex = 0;
            this.ctrlBankAccountWithFillter1.OnBankExist += new System.Action<CRM_BussinsLayer.clsBanksAccount>(this.ctrlBankAccountWithFillter1_OnBankExist);
            // 
            // frmAddEditTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 848);
            this.Controls.Add(this.PanelForAddEditTransaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditTransaction";
            this.Text = "frmAddEditTransaction";
            this.PanelForAddEditTransaction.ResumeLayout(false);
            this.PanelForAddEditTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelForAddEditTransaction;
        private System.Windows.Forms.Label label1;
        private Bank.Control.ctrlBankAccountWithFillter ctrlBankAccountWithFillter2;
        private Bank.Control.ctrlBankAccountWithFillter ctrlBankAccountWithFillter1;
        private Guna.UI2.WinForms.Guna2CircleButton btnTransfare;
        private Guna.UI2.WinForms.Guna2TextBox TxtAmmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTransfareTo;
        private System.Windows.Forms.Label lblTransfareFrom;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}