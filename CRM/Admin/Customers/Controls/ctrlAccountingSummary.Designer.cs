namespace CRM.Admin.Customers.Controls
{
    partial class ctrlAccountingSummary
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
            this.lbl = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdrress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalExpence = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLoss = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(16, 12);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(179, 22);
            this.lbl.TabIndex = 24;
            this.lbl.Text = "Accounting Summary";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(6, 37);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(767, 28);
            this.guna2Separator1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Loss:";
            // 
            // lblAdrress
            // 
            this.lblAdrress.AutoSize = true;
            this.lblAdrress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdrress.Location = new System.Drawing.Point(328, 184);
            this.lblAdrress.Name = "lblAdrress";
            this.lblAdrress.Size = new System.Drawing.Size(120, 20);
            this.lblAdrress.TabIndex = 27;
            this.lblAdrress.Text = "Total Expence:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Total Income:";
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Location = new System.Drawing.Point(443, 151);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(224, 24);
            this.guna2Separator3.TabIndex = 29;
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.Location = new System.Drawing.Point(443, 207);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(224, 24);
            this.guna2Separator4.TabIndex = 30;
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.Location = new System.Drawing.Point(443, 265);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(224, 24);
            this.guna2Separator5.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.lblTotalIncome);
            this.panel1.Location = new System.Drawing.Point(584, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 20);
            this.panel1.TabIndex = 32;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIncome.ForeColor = System.Drawing.Color.White;
            this.lblTotalIncome.Location = new System.Drawing.Point(15, 0);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(52, 18);
            this.lblTotalIncome.TabIndex = 34;
            this.lblTotalIncome.Text = " $ 0.00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.lblTotalExpence);
            this.panel2.Location = new System.Drawing.Point(584, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 22);
            this.panel2.TabIndex = 33;
            // 
            // lblTotalExpence
            // 
            this.lblTotalExpence.AutoSize = true;
            this.lblTotalExpence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpence.ForeColor = System.Drawing.Color.White;
            this.lblTotalExpence.Location = new System.Drawing.Point(15, 2);
            this.lblTotalExpence.Name = "lblTotalExpence";
            this.lblTotalExpence.Size = new System.Drawing.Size(52, 18);
            this.lblTotalExpence.TabIndex = 35;
            this.lblTotalExpence.Text = " $ 0.00";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.lblLoss);
            this.panel3.Location = new System.Drawing.Point(584, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(83, 22);
            this.panel3.TabIndex = 33;
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoss.ForeColor = System.Drawing.Color.White;
            this.lblLoss.Location = new System.Drawing.Point(15, 2);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(52, 18);
            this.lblLoss.TabIndex = 35;
            this.lblLoss.Text = " $ 0.00";
            // 
            // ctrlAccountingSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Separator5);
            this.Controls.Add(this.guna2Separator4);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdrress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.guna2Separator1);
            this.Name = "ctrlAccountingSummary";
            this.Size = new System.Drawing.Size(773, 308);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdrress;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalExpence;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLoss;
    }
}
