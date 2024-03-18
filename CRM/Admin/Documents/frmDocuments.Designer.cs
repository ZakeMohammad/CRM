namespace CRM.Admin
{
    partial class frmDocuments
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
            this.PanelForDocumant = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChoosePDF = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PanelForDocumant.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForDocumant
            // 
            this.PanelForDocumant.BackColor = System.Drawing.Color.Transparent;
            this.PanelForDocumant.BorderRadius = 30;
            this.PanelForDocumant.BorderThickness = 1;
            this.PanelForDocumant.Controls.Add(this.flowLayoutPanel1);
            this.PanelForDocumant.Controls.Add(this.btnChoosePDF);
            this.PanelForDocumant.Controls.Add(this.label1);
            this.PanelForDocumant.FillColor = System.Drawing.Color.White;
            this.PanelForDocumant.Location = new System.Drawing.Point(76, 80);
            this.PanelForDocumant.Name = "PanelForDocumant";
            this.PanelForDocumant.ShadowDecoration.BorderRadius = 10;
            this.PanelForDocumant.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.PanelForDocumant.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.PanelForDocumant.Size = new System.Drawing.Size(1428, 688);
            this.PanelForDocumant.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 124);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1374, 539);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnChoosePDF
            // 
            this.btnChoosePDF.BorderRadius = 20;
            this.btnChoosePDF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChoosePDF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChoosePDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChoosePDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChoosePDF.FillColor = System.Drawing.Color.Black;
            this.btnChoosePDF.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePDF.ForeColor = System.Drawing.Color.White;
            this.btnChoosePDF.Image = global::CRM.Properties.Resources.sheet;
            this.btnChoosePDF.ImageSize = new System.Drawing.Size(55, 55);
            this.btnChoosePDF.Location = new System.Drawing.Point(474, 42);
            this.btnChoosePDF.Name = "btnChoosePDF";
            this.btnChoosePDF.Size = new System.Drawing.Size(180, 45);
            this.btnChoosePDF.TabIndex = 1;
            this.btnChoosePDF.Text = "Choose PDF";
            this.btnChoosePDF.Click += new System.EventHandler(this.btnChoosePDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose PDF To Download";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 848);
            this.Controls.Add(this.PanelForDocumant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDocuments";
            this.Tag = "Documents";
            this.Text = "frmDocuments";
            this.Load += new System.EventHandler(this.frmDocuments_Load);
            this.PanelForDocumant.ResumeLayout(false);
            this.PanelForDocumant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelForDocumant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button btnChoosePDF;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}