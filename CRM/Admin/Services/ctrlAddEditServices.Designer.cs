namespace CRM.Admin.Services
{
    partial class ctrlAddEditServices
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.TxtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblForWhat = new System.Windows.Forms.Label();
            this.TxtSealisPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::CRM.Properties.Resources.check__1_;
            this.btnSave.Location = new System.Drawing.Point(247, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 41);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TxtDescription
            // 
            this.TxtDescription.BorderColor = System.Drawing.Color.Teal;
            this.TxtDescription.BorderRadius = 5;
            this.TxtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDescription.DefaultText = "";
            this.TxtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescription.ForeColor = System.Drawing.Color.Black;
            this.TxtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDescription.Location = new System.Drawing.Point(36, 386);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.PasswordChar = '\0';
            this.TxtDescription.PlaceholderText = "Description";
            this.TxtDescription.SelectedText = "";
            this.TxtDescription.Size = new System.Drawing.Size(574, 35);
            this.TxtDescription.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtDescription.TabIndex = 33;
            this.TxtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtName
            // 
            this.TxtName.BorderColor = System.Drawing.Color.Teal;
            this.TxtName.BorderRadius = 5;
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.DefaultText = "";
            this.TxtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.Black;
            this.TxtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtName.Location = new System.Drawing.Point(36, 126);
            this.TxtName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.PlaceholderText = "Name";
            this.TxtName.SelectedText = "";
            this.TxtName.Size = new System.Drawing.Size(574, 35);
            this.TxtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtName.TabIndex = 32;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            this.TxtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
            // 
            // lblForWhat
            // 
            this.lblForWhat.AutoSize = true;
            this.lblForWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForWhat.Location = new System.Drawing.Point(224, 15);
            this.lblForWhat.Name = "lblForWhat";
            this.lblForWhat.Size = new System.Drawing.Size(220, 42);
            this.lblForWhat.TabIndex = 31;
            this.lblForWhat.Text = "Add Service";
            // 
            // TxtSealisPrice
            // 
            this.TxtSealisPrice.BorderColor = System.Drawing.Color.Teal;
            this.TxtSealisPrice.BorderRadius = 5;
            this.TxtSealisPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSealisPrice.DefaultText = "";
            this.TxtSealisPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSealisPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSealisPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSealisPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSealisPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSealisPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSealisPrice.ForeColor = System.Drawing.Color.Black;
            this.TxtSealisPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSealisPrice.Location = new System.Drawing.Point(36, 260);
            this.TxtSealisPrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtSealisPrice.Name = "TxtSealisPrice";
            this.TxtSealisPrice.PasswordChar = '\0';
            this.TxtSealisPrice.PlaceholderText = "Price";
            this.TxtSealisPrice.SelectedText = "";
            this.TxtSealisPrice.Size = new System.Drawing.Size(574, 35);
            this.TxtSealisPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtSealisPrice.TabIndex = 37;
            this.TxtSealisPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSealisPrice.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSealisPrice_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlAddEditServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TxtSealisPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.lblForWhat);
            this.Name = "ctrlAddEditServices";
            this.Size = new System.Drawing.Size(646, 564);
            this.Load += new System.EventHandler(this.ctrlAddEditServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox TxtDescription;
        private Guna.UI2.WinForms.Guna2TextBox TxtName;
        private System.Windows.Forms.Label lblForWhat;
        private Guna.UI2.WinForms.Guna2TextBox TxtSealisPrice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
