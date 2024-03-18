namespace CRM.Admin
{
    partial class frmQuotes
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
            this.PanelForAllFrmQutes = new System.Windows.Forms.Panel();
            this.PanelForQutesMangent = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewQuotes = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelForAllFrmQutes.SuspendLayout();
            this.PanelForQutesMangent.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForAllFrmQutes
            // 
            this.PanelForAllFrmQutes.Controls.Add(this.PanelForQutesMangent);
            this.PanelForAllFrmQutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForAllFrmQutes.Location = new System.Drawing.Point(0, 0);
            this.PanelForAllFrmQutes.Name = "PanelForAllFrmQutes";
            this.PanelForAllFrmQutes.Size = new System.Drawing.Size(1581, 848);
            this.PanelForAllFrmQutes.TabIndex = 0;
            // 
            // PanelForQutesMangent
            // 
            this.PanelForQutesMangent.BackColor = System.Drawing.Color.Transparent;
            this.PanelForQutesMangent.BorderColor = System.Drawing.Color.White;
            this.PanelForQutesMangent.BorderRadius = 20;
            this.PanelForQutesMangent.BorderThickness = 10;
            this.PanelForQutesMangent.Controls.Add(this.label1);
            this.PanelForQutesMangent.Controls.Add(this.btnAddNewQuotes);
            this.PanelForQutesMangent.Controls.Add(this.flowLayoutPanel1);
            this.PanelForQutesMangent.FillColor = System.Drawing.Color.White;
            this.PanelForQutesMangent.Location = new System.Drawing.Point(68, 41);
            this.PanelForQutesMangent.Name = "PanelForQutesMangent";
            this.PanelForQutesMangent.Size = new System.Drawing.Size(1444, 767);
            this.PanelForQutesMangent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(587, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 42);
            this.label1.TabIndex = 23;
            this.label1.Text = "𝑄𝑢𝑜𝑡𝑒𝑠 𝒮𝒸𝓇𝑒𝑒𝓃 ঌ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddNewQuotes
            // 
            this.btnAddNewQuotes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewQuotes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewQuotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewQuotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewQuotes.FillColor = System.Drawing.Color.White;
            this.btnAddNewQuotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewQuotes.ForeColor = System.Drawing.Color.White;
            this.btnAddNewQuotes.Image = global::CRM.Properties.Resources.mail;
            this.btnAddNewQuotes.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewQuotes.Location = new System.Drawing.Point(1363, 30);
            this.btnAddNewQuotes.Name = "btnAddNewQuotes";
            this.btnAddNewQuotes.Size = new System.Drawing.Size(64, 62);
            this.btnAddNewQuotes.TabIndex = 2;
            this.btnAddNewQuotes.Click += new System.EventHandler(this.btnAddNewQuotes_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 98);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1410, 666);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // frmQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 848);
            this.Controls.Add(this.PanelForAllFrmQutes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuotes";
            this.Tag = "Quote";
            this.Text = "frmQuotes";
            this.Load += new System.EventHandler(this.frmQuotes_Load);
            this.PanelForAllFrmQutes.ResumeLayout(false);
            this.PanelForQutesMangent.ResumeLayout(false);
            this.PanelForQutesMangent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelForAllFrmQutes;
        private Guna.UI2.WinForms.Guna2Panel PanelForQutesMangent;
        private Guna.UI2.WinForms.Guna2Button btnAddNewQuotes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}