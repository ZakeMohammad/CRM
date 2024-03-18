namespace CRM.Admin.Settings.Payment
{
    partial class ctrlPaymentGategoryInfo
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
            this.TxtName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ImageBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.AutoSize = false;
            this.TxtName.BackColor = System.Drawing.Color.Transparent;
            this.TxtName.Font = new System.Drawing.Font("Simplified Arabic Fixed", 18F);
            this.TxtName.Location = new System.Drawing.Point(279, 42);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(229, 107);
            this.TxtName.TabIndex = 7;
            this.TxtName.Text = "guna2HtmlLabel1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::CRM.Properties.Resources.edit__3_;
            this.btnUpdate.ImageRotate = 0F;
            this.btnUpdate.Location = new System.Drawing.Point(407, 155);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnUpdate.Size = new System.Drawing.Size(57, 47);
            this.btnUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::CRM.Properties.Resources.trash;
            this.btnDelete.ImageRotate = 0F;
            this.btnDelete.Location = new System.Drawing.Point(470, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.Size = new System.Drawing.Size(57, 47);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 6;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.Image = global::CRM.Properties.Resources.ask__1_;
            this.ImageBox.ImageRotate = 0F;
            this.ImageBox.Location = new System.Drawing.Point(17, 14);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ImageBox.Size = new System.Drawing.Size(213, 155);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 5;
            this.ImageBox.TabStop = false;
            // 
            // ctrlPaymentGategoryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.ImageBox);
            this.Name = "ctrlPaymentGategoryInfo";
            this.Size = new System.Drawing.Size(531, 204);
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox btnUpdate;
        private Guna.UI2.WinForms.Guna2HtmlLabel TxtName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnDelete;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ImageBox;
    }
}
