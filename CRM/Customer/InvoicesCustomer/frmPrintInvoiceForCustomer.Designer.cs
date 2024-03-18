namespace CRM.Customer
{
    partial class frmPrintInvoiceForCustomer
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
            this.ctrlInvoiceInfo1 = new CRM.Customer.ctrlInvoiceInfo();
            this.SuspendLayout();
            // 
            // ctrlInvoiceInfo1
            // 
            this.ctrlInvoiceInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlInvoiceInfo1.Location = new System.Drawing.Point(3, 12);
            this.ctrlInvoiceInfo1.Name = "ctrlInvoiceInfo1";
            this.ctrlInvoiceInfo1.Size = new System.Drawing.Size(1453, 775);
            this.ctrlInvoiceInfo1.TabIndex = 0;
            // 
            // frmPrintInvoiceForCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1468, 788);
            this.Controls.Add(this.ctrlInvoiceInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmPrintInvoiceForCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Invoice";
            this.Load += new System.EventHandler(this.frmPrintInvoiceForCustomer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlInvoiceInfo ctrlInvoiceInfo1;
    }
}