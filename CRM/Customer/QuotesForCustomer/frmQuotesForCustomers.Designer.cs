namespace CRM.Customer
{
    partial class frmQuotesForCustomers
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
            this.PanelForOrder = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PanelForOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelForOrder
            // 
            this.PanelForOrder.BackColor = System.Drawing.Color.Transparent;
            this.PanelForOrder.BorderRadius = 20;
            this.PanelForOrder.BorderThickness = 1;
            this.PanelForOrder.Controls.Add(this.flowLayoutPanel1);
            this.PanelForOrder.Controls.Add(this.label4);
            this.PanelForOrder.Controls.Add(this.label3);
            this.PanelForOrder.Controls.Add(this.label2);
            this.PanelForOrder.Controls.Add(this.label1);
            this.PanelForOrder.Controls.Add(this.guna2CirclePictureBox1);
            this.PanelForOrder.FillColor = System.Drawing.Color.White;
            this.PanelForOrder.Location = new System.Drawing.Point(271, 40);
            this.PanelForOrder.Name = "PanelForOrder";
            this.PanelForOrder.ShadowDecoration.BorderRadius = 10;
            this.PanelForOrder.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.PanelForOrder.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.PanelForOrder.Size = new System.Drawing.Size(1428, 548);
            this.PanelForOrder.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1384, 342);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(464, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(646, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "providing a user-friendly interface for customers to make informed decisions.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(464, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "This feature streamlines the quotation process,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(464, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(570, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "accept or decline them, and initiate any necessary follow-up actions.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(464, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Customers can easily compare quotes,";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::CRM.Properties.Resources.notes;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(0, 371);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(264, 171);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 14;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // frmQuotesForCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1886, 801);
            this.Controls.Add(this.PanelForOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuotesForCustomers";
            this.Tag = "Quotes";
            this.Text = "frmQuotesForCustomers";
            this.Load += new System.EventHandler(this.frmQuotesForCustomers_Load);
            this.PanelForOrder.ResumeLayout(false);
            this.PanelForOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelForOrder;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}