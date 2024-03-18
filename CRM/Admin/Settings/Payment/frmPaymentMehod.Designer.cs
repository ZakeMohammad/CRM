namespace CRM.Admin.Settings
{
    partial class frmPaymentMehod
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
            this.PanelForfrmAddEditPaymentMethods = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPaymentMethodsAddEdit1 = new CRM.Admin.Settings.Payment.ctrlPaymentMethodsAddEdit();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelForfrmAddEditPaymentMethods.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForfrmAddEditPaymentMethods
            // 
            this.PanelForfrmAddEditPaymentMethods.BackColor = System.Drawing.Color.Transparent;
            this.PanelForfrmAddEditPaymentMethods.BorderRadius = 30;
            this.PanelForfrmAddEditPaymentMethods.BorderThickness = 1;
            this.PanelForfrmAddEditPaymentMethods.Controls.Add(this.btnRefresh);
            this.PanelForfrmAddEditPaymentMethods.Controls.Add(this.ctrlPaymentMethodsAddEdit1);
            this.PanelForfrmAddEditPaymentMethods.Controls.Add(this.flowLayoutPanel1);
            this.PanelForfrmAddEditPaymentMethods.FillColor = System.Drawing.Color.White;
            this.PanelForfrmAddEditPaymentMethods.Location = new System.Drawing.Point(25, 94);
            this.PanelForfrmAddEditPaymentMethods.Name = "PanelForfrmAddEditPaymentMethods";
            this.PanelForfrmAddEditPaymentMethods.ShadowDecoration.BorderRadius = 10;
            this.PanelForfrmAddEditPaymentMethods.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.PanelForfrmAddEditPaymentMethods.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.PanelForfrmAddEditPaymentMethods.Size = new System.Drawing.Size(1735, 604);
            this.PanelForfrmAddEditPaymentMethods.TabIndex = 4;
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
            // ctrlPaymentMethodsAddEdit1
            // 
            this.ctrlPaymentMethodsAddEdit1.BackColor = System.Drawing.Color.White;
            this.ctrlPaymentMethodsAddEdit1.Location = new System.Drawing.Point(3, 65);
            this.ctrlPaymentMethodsAddEdit1.Name = "ctrlPaymentMethodsAddEdit1";
            this.ctrlPaymentMethodsAddEdit1.Size = new System.Drawing.Size(615, 462);
            this.ctrlPaymentMethodsAddEdit1.TabIndex = 34;
            this.ctrlPaymentMethodsAddEdit1.OnMethodAdded += new System.Action<bool>(this.ctrlPaymentMethodsAddEdit1_OnMethodAdded);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(624, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1103, 587);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // frmPaymentMehod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 848);
            this.Controls.Add(this.PanelForfrmAddEditPaymentMethods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPaymentMehod";
            this.Tag = "Payment Methods";
            this.Text = "frmPaymentMehod";
            this.Load += new System.EventHandler(this.frmPaymentMehod_Load);
            this.PanelForfrmAddEditPaymentMethods.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelForfrmAddEditPaymentMethods;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Payment.ctrlPaymentMethodsAddEdit ctrlPaymentMethodsAddEdit1;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}