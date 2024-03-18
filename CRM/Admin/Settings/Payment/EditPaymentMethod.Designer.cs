namespace CRM.Admin.Settings.Payment
{
    partial class EditPaymentMethod
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
            this.ctrlPaymentMethodsAddEdit1 = new CRM.Admin.Settings.Payment.ctrlPaymentMethodsAddEdit();
            this.SuspendLayout();
            // 
            // ctrlPaymentMethodsAddEdit1
            // 
            this.ctrlPaymentMethodsAddEdit1.BackColor = System.Drawing.Color.White;
            this.ctrlPaymentMethodsAddEdit1.Location = new System.Drawing.Point(27, 12);
            this.ctrlPaymentMethodsAddEdit1.Name = "ctrlPaymentMethodsAddEdit1";
            this.ctrlPaymentMethodsAddEdit1.Size = new System.Drawing.Size(625, 462);
            this.ctrlPaymentMethodsAddEdit1.TabIndex = 0;
            // 
            // EditPaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 491);
            this.Controls.Add(this.ctrlPaymentMethodsAddEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditPaymentMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Paymen tMethod";
            this.Load += new System.EventHandler(this.EditPaymentMethod_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPaymentMethodsAddEdit ctrlPaymentMethodsAddEdit1;
    }
}