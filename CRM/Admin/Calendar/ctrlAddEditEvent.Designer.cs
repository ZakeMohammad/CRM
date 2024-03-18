namespace CRM.Admin.Calendar
{
    partial class ctrlAddEditEvent
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
            this.lblForWhat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DatePickerForStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DatePickerForEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForWhat
            // 
            this.lblForWhat.AutoSize = true;
            this.lblForWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForWhat.Location = new System.Drawing.Point(208, 12);
            this.lblForWhat.Name = "lblForWhat";
            this.lblForWhat.Size = new System.Drawing.Size(191, 42);
            this.lblForWhat.TabIndex = 0;
            this.lblForWhat.Text = "Add Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
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
            this.TxtName.Location = new System.Drawing.Point(20, 123);
            this.TxtName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.PlaceholderText = "Name";
            this.TxtName.SelectedText = "";
            this.TxtName.Size = new System.Drawing.Size(574, 35);
            this.TxtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtName.TabIndex = 2;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            this.TxtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "End Date :";
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
            this.TxtDescription.Location = new System.Drawing.Point(20, 498);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.PasswordChar = '\0';
            this.TxtDescription.PlaceholderText = "Description";
            this.TxtDescription.SelectedText = "";
            this.TxtDescription.Size = new System.Drawing.Size(574, 35);
            this.TxtDescription.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtDescription.TabIndex = 8;
            this.TxtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescription_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description :";
            // 
            // DatePickerForStartDate
            // 
            this.DatePickerForStartDate.Checked = true;
            this.DatePickerForStartDate.CustomFormat = "";
            this.DatePickerForStartDate.FillColor = System.Drawing.Color.Teal;
            this.DatePickerForStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePickerForStartDate.ForeColor = System.Drawing.Color.White;
            this.DatePickerForStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerForStartDate.Location = new System.Drawing.Point(20, 248);
            this.DatePickerForStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DatePickerForStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DatePickerForStartDate.Name = "DatePickerForStartDate";
            this.DatePickerForStartDate.Size = new System.Drawing.Size(574, 40);
            this.DatePickerForStartDate.TabIndex = 9;
            this.DatePickerForStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DatePickerForStartDate.Value = new System.DateTime(2023, 12, 31, 14, 30, 52, 453);
            // 
            // DatePickerForEndDate
            // 
            this.DatePickerForEndDate.Checked = true;
            this.DatePickerForEndDate.CustomFormat = "yyyy/dd/MM";
            this.DatePickerForEndDate.FillColor = System.Drawing.Color.Teal;
            this.DatePickerForEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePickerForEndDate.ForeColor = System.Drawing.Color.White;
            this.DatePickerForEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerForEndDate.Location = new System.Drawing.Point(20, 379);
            this.DatePickerForEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DatePickerForEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DatePickerForEndDate.Name = "DatePickerForEndDate";
            this.DatePickerForEndDate.Size = new System.Drawing.Size(574, 40);
            this.DatePickerForEndDate.TabIndex = 10;
            this.DatePickerForEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DatePickerForEndDate.Value = new System.DateTime(2023, 12, 31, 14, 19, 36, 563);
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
            this.btnSave.Location = new System.Drawing.Point(238, 584);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 41);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlAddEditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.DatePickerForEndDate);
            this.Controls.Add(this.DatePickerForStartDate);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblForWhat);
            this.Name = "ctrlAddEditEvent";
            this.Size = new System.Drawing.Size(646, 642);
            this.Load += new System.EventHandler(this.ctrlAddEditEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForWhat;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TxtDescription;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePickerForStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker DatePickerForEndDate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
