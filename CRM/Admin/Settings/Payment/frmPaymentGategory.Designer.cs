namespace CRM.Admin.Settings
{
    partial class frmPaymentGategory
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
            this.PanelForfrmAddEditPaymentGategory = new Guna.UI2.WinForms.Guna2Panel();
            this.ctrlPaymentGategoryAddEdit1 = new CRM.Admin.Settings.Payment.ctrlPaymentGategoryAddEdit();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelForfrmAddEditPaymentGategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForfrmAddEditPaymentGategory
            // 
            this.PanelForfrmAddEditPaymentGategory.BackColor = System.Drawing.Color.Transparent;
            this.PanelForfrmAddEditPaymentGategory.BorderRadius = 30;
            this.PanelForfrmAddEditPaymentGategory.BorderThickness = 1;
            this.PanelForfrmAddEditPaymentGategory.Controls.Add(this.ctrlPaymentGategoryAddEdit1);
            this.PanelForfrmAddEditPaymentGategory.Controls.Add(this.btnRefresh);
            this.PanelForfrmAddEditPaymentGategory.Controls.Add(this.flowLayoutPanel1);
            this.PanelForfrmAddEditPaymentGategory.FillColor = System.Drawing.Color.White;
            this.PanelForfrmAddEditPaymentGategory.Location = new System.Drawing.Point(8, 122);
            this.PanelForfrmAddEditPaymentGategory.Name = "PanelForfrmAddEditPaymentGategory";
            this.PanelForfrmAddEditPaymentGategory.ShadowDecoration.BorderRadius = 10;
            this.PanelForfrmAddEditPaymentGategory.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.PanelForfrmAddEditPaymentGategory.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.PanelForfrmAddEditPaymentGategory.Size = new System.Drawing.Size(1735, 604);
            this.PanelForfrmAddEditPaymentGategory.TabIndex = 5;
            // 
            // ctrlPaymentGategoryAddEdit1
            // 
            this.ctrlPaymentGategoryAddEdit1.BackColor = System.Drawing.Color.White;
            this.ctrlPaymentGategoryAddEdit1.Location = new System.Drawing.Point(4, 53);
            this.ctrlPaymentGategoryAddEdit1.Name = "ctrlPaymentGategoryAddEdit1";
            this.ctrlPaymentGategoryAddEdit1.Size = new System.Drawing.Size(614, 462);
            this.ctrlPaymentGategoryAddEdit1.TabIndex = 36;
            this.ctrlPaymentGategoryAddEdit1.OnGategoryAdded += new System.Action<bool>(this.ctrlPaymentGategoryAddEdit1_OnGategoryAdded);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 20;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::CRM.Properties.Resources.repeat;
            this.btnRefresh.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRefresh.Location = new System.Drawing.Point(572, 548);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(46, 42);
            this.btnRefresh.TabIndex = 35;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(624, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1103, 587);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // frmPaymentGategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 848);
            this.Controls.Add(this.PanelForfrmAddEditPaymentGategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPaymentGategory";
            this.Tag = "Payments Gategory";
            this.Text = "frmPaymentGategory";
            this.Load += new System.EventHandler(this.frmPaymentGategory_Load);
            this.PanelForfrmAddEditPaymentGategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelForfrmAddEditPaymentGategory;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Payment.ctrlPaymentGategoryAddEdit ctrlPaymentGategoryAddEdit1;
    }
}