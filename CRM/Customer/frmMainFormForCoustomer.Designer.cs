namespace CRM.Customer
{
    partial class frmMainFormForCoustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainFormForCoustomer));
            this.PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.StaticPanel = new System.Windows.Forms.Panel();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnQuotes = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrders = new Guna.UI2.WinForms.Guna2Button();
            this.btnDocuments = new Guna.UI2.WinForms.Guna2Button();
            this.btnInvoices = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransactions = new Guna.UI2.WinForms.Guna2Button();
            this.PanelForAllFormsMain = new System.Windows.Forms.Panel();
            this.PanelForFomsName = new System.Windows.Forms.Panel();
            this.LabelForChiledForm = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.StaticPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.PanelForFomsName.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.SystemColors.Control;
            this.PanelTop.BorderRadius = 12;
            this.PanelTop.Controls.Add(this.pictureBox2);
            this.PanelTop.CustomBorderColor = System.Drawing.Color.White;
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.FillColor = System.Drawing.Color.WhiteSmoke;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.ShadowDecoration.BorderRadius = 12;
            this.PanelTop.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.PanelTop.Size = new System.Drawing.Size(1867, 88);
            this.PanelTop.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CRM.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(67, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1710, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // StaticPanel
            // 
            this.StaticPanel.BackColor = System.Drawing.Color.White;
            this.StaticPanel.Controls.Add(this.btnProfile);
            this.StaticPanel.Controls.Add(this.guna2CirclePictureBox2);
            this.StaticPanel.Controls.Add(this.btnQuotes);
            this.StaticPanel.Controls.Add(this.btnOrders);
            this.StaticPanel.Controls.Add(this.btnDocuments);
            this.StaticPanel.Controls.Add(this.btnInvoices);
            this.StaticPanel.Controls.Add(this.btnTransactions);
            this.StaticPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StaticPanel.Location = new System.Drawing.Point(0, 88);
            this.StaticPanel.Name = "StaticPanel";
            this.StaticPanel.Size = new System.Drawing.Size(1867, 85);
            this.StaticPanel.TabIndex = 10;
            // 
            // btnProfile
            // 
            this.btnProfile.BorderRadius = 18;
            this.btnProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProfile.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProfile.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.Image = global::CRM.Properties.Resources.avatar__1_;
            this.btnProfile.ImageSize = new System.Drawing.Size(27, 27);
            this.btnProfile.Location = new System.Drawing.Point(1417, 6);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(315, 73);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = global::CRM.Properties.Resources.exit__1_;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(1772, 23);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(59, 41);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 16;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.Click += new System.EventHandler(this.guna2CirclePictureBox2_Click_1);
            // 
            // btnQuotes
            // 
            this.btnQuotes.BorderRadius = 18;
            this.btnQuotes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuotes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuotes.FillColor = System.Drawing.Color.MediumOrchid;
            this.btnQuotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuotes.ForeColor = System.Drawing.Color.Black;
            this.btnQuotes.Image = global::CRM.Properties.Resources.quotes;
            this.btnQuotes.ImageSize = new System.Drawing.Size(30, 30);
            this.btnQuotes.Location = new System.Drawing.Point(1146, 6);
            this.btnQuotes.Name = "btnQuotes";
            this.btnQuotes.Size = new System.Drawing.Size(265, 73);
            this.btnQuotes.TabIndex = 5;
            this.btnQuotes.Text = "Quotes";
            this.btnQuotes.Click += new System.EventHandler(this.btnQuotes_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BorderRadius = 18;
            this.btnOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrders.ForeColor = System.Drawing.Color.Black;
            this.btnOrders.Image = global::CRM.Properties.Resources.shopping_cart;
            this.btnOrders.ImageSize = new System.Drawing.Size(30, 30);
            this.btnOrders.Location = new System.Drawing.Point(604, 6);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(265, 73);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Orders";
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnDocuments
            // 
            this.btnDocuments.BorderRadius = 18;
            this.btnDocuments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDocuments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDocuments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDocuments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDocuments.FillColor = System.Drawing.Color.LightGreen;
            this.btnDocuments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDocuments.ForeColor = System.Drawing.Color.Black;
            this.btnDocuments.Image = global::CRM.Properties.Resources.documents;
            this.btnDocuments.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDocuments.Location = new System.Drawing.Point(333, 6);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(265, 73);
            this.btnDocuments.TabIndex = 3;
            this.btnDocuments.Text = "Documents";
            this.btnDocuments.Click += new System.EventHandler(this.btnDocuments_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.BorderRadius = 18;
            this.btnInvoices.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInvoices.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInvoices.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInvoices.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInvoices.FillColor = System.Drawing.Color.IndianRed;
            this.btnInvoices.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInvoices.ForeColor = System.Drawing.Color.Black;
            this.btnInvoices.Image = global::CRM.Properties.Resources.invoice__1_;
            this.btnInvoices.ImageSize = new System.Drawing.Size(30, 30);
            this.btnInvoices.Location = new System.Drawing.Point(875, 6);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(265, 73);
            this.btnInvoices.TabIndex = 4;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BorderRadius = 18;
            this.btnTransactions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransactions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransactions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTransactions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTransactions.ForeColor = System.Drawing.Color.Black;
            this.btnTransactions.Image = global::CRM.Properties.Resources.transaction__1_;
            this.btnTransactions.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTransactions.Location = new System.Drawing.Point(12, 6);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(315, 73);
            this.btnTransactions.TabIndex = 1;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // PanelForAllFormsMain
            // 
            this.PanelForAllFormsMain.ForeColor = System.Drawing.Color.Black;
            this.PanelForAllFormsMain.Location = new System.Drawing.Point(0, 248);
            this.PanelForAllFormsMain.Name = "PanelForAllFormsMain";
            this.PanelForAllFormsMain.Size = new System.Drawing.Size(1867, 746);
            this.PanelForAllFormsMain.TabIndex = 11;
            // 
            // PanelForFomsName
            // 
            this.PanelForFomsName.BackColor = System.Drawing.Color.White;
            this.PanelForFomsName.Controls.Add(this.LabelForChiledForm);
            this.PanelForFomsName.Controls.Add(this.lblCustomerName);
            this.PanelForFomsName.Controls.Add(this.label1);
            this.PanelForFomsName.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelForFomsName.Location = new System.Drawing.Point(0, 173);
            this.PanelForFomsName.Name = "PanelForFomsName";
            this.PanelForFomsName.Size = new System.Drawing.Size(1867, 69);
            this.PanelForFomsName.TabIndex = 12;
            // 
            // LabelForChiledForm
            // 
            this.LabelForChiledForm.AutoSize = true;
            this.LabelForChiledForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelForChiledForm.ForeColor = System.Drawing.Color.Black;
            this.LabelForChiledForm.Location = new System.Drawing.Point(887, 3);
            this.LabelForChiledForm.Name = "LabelForChiledForm";
            this.LabelForChiledForm.Size = new System.Drawing.Size(253, 54);
            this.LabelForChiledForm.TabIndex = 0;
            this.LabelForChiledForm.Text = "Dashpoord";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.DimGray;
            this.lblCustomerName.Location = new System.Drawing.Point(1517, 17);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(146, 22);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Zaki Mohammad ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(1450, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello !";
            // 
            // frmMainFormForCoustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 994);
            this.Controls.Add(this.PanelForFomsName);
            this.Controls.Add(this.PanelForAllFormsMain);
            this.Controls.Add(this.StaticPanel);
            this.Controls.Add(this.PanelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainFormForCoustomer";
            this.Text = "CRM-Customers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainFormForCoustomer_Load);
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.StaticPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.PanelForFomsName.ResumeLayout(false);
            this.PanelForFomsName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelTop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel StaticPanel;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnQuotes;
        private Guna.UI2.WinForms.Guna2Button btnInvoices;
        private Guna.UI2.WinForms.Guna2Button btnDocuments;
        private Guna.UI2.WinForms.Guna2Button btnOrders;
        private Guna.UI2.WinForms.Guna2Button btnTransactions;
        private System.Windows.Forms.Panel PanelForAllFormsMain;
        private System.Windows.Forms.Panel PanelForFomsName;
        private System.Windows.Forms.Label LabelForChiledForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label1;
    }
}