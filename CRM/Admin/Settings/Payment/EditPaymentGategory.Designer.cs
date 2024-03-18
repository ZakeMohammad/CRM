namespace CRM.Admin.Settings.Payment
{
    partial class EditPaymentGategory
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
            this.ctrlPaymentGategoryAddEdit1 = new CRM.Admin.Settings.Payment.ctrlPaymentGategoryAddEdit();
            this.SuspendLayout();
            // 
            // ctrlPaymentGategoryAddEdit1
            // 
            this.ctrlPaymentGategoryAddEdit1.BackColor = System.Drawing.Color.White;
            this.ctrlPaymentGategoryAddEdit1.Location = new System.Drawing.Point(25, 12);
            this.ctrlPaymentGategoryAddEdit1.Name = "ctrlPaymentGategoryAddEdit1";
            this.ctrlPaymentGategoryAddEdit1.Size = new System.Drawing.Size(625, 462);
            this.ctrlPaymentGategoryAddEdit1.TabIndex = 0;
            // 
            // EditPaymentGategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 491);
            this.Controls.Add(this.ctrlPaymentGategoryAddEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditPaymentGategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Payment Gategory";
            this.Load += new System.EventHandler(this.EditPaymentGategory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPaymentGategoryAddEdit ctrlPaymentGategoryAddEdit1;
    }
}