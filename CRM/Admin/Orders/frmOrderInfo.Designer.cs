namespace CRM.Admin.Orders
{
    partial class frmOrderInfo
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
            this.PanelForfrmOrderInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSendMessage = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSubject = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlOrderCard1 = new CRM.Admin.Orders.Controls.ctrlOrderCard();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnDELETE = new Guna.UI2.WinForms.Guna2Button();
            this.btnCanceled = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccept = new Guna.UI2.WinForms.Guna2Button();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PanelForfrmOrderInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelForfrmOrderInfo
            // 
            this.PanelForfrmOrderInfo.BackColor = System.Drawing.Color.Transparent;
            this.PanelForfrmOrderInfo.BorderRadius = 30;
            this.PanelForfrmOrderInfo.BorderThickness = 1;
            this.PanelForfrmOrderInfo.Controls.Add(this.btnSendMessage);
            this.PanelForfrmOrderInfo.Controls.Add(this.groupBox1);
            this.PanelForfrmOrderInfo.Controls.Add(this.ctrlOrderCard1);
            this.PanelForfrmOrderInfo.Controls.Add(this.guna2Separator2);
            this.PanelForfrmOrderInfo.Controls.Add(this.guna2Separator1);
            this.PanelForfrmOrderInfo.Controls.Add(this.btnDELETE);
            this.PanelForfrmOrderInfo.Controls.Add(this.btnCanceled);
            this.PanelForfrmOrderInfo.Controls.Add(this.btnAccept);
            this.PanelForfrmOrderInfo.Controls.Add(this.lblOrderID);
            this.PanelForfrmOrderInfo.Controls.Add(this.label1);
            this.PanelForfrmOrderInfo.Controls.Add(this.guna2CirclePictureBox1);
            this.PanelForfrmOrderInfo.FillColor = System.Drawing.Color.White;
            this.PanelForfrmOrderInfo.Location = new System.Drawing.Point(76, 80);
            this.PanelForfrmOrderInfo.Name = "PanelForfrmOrderInfo";
            this.PanelForfrmOrderInfo.ShadowDecoration.BorderRadius = 10;
            this.PanelForfrmOrderInfo.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.PanelForfrmOrderInfo.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.PanelForfrmOrderInfo.Size = new System.Drawing.Size(1428, 701);
            this.PanelForfrmOrderInfo.TabIndex = 3;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSendMessage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSendMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSendMessage.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSendMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSendMessage.ForeColor = System.Drawing.Color.White;
            this.btnSendMessage.Image = global::CRM.Properties.Resources.paper_plane;
            this.btnSendMessage.Location = new System.Drawing.Point(906, 638);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(217, 44);
            this.btnSendMessage.TabIndex = 28;
            this.btnSendMessage.Text = "Send Message";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtMessage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtSubject);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(639, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 500);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // TxtMessage
            // 
            this.TxtMessage.BorderColor = System.Drawing.Color.Black;
            this.TxtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMessage.DefaultText = "";
            this.TxtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtMessage.ForeColor = System.Drawing.Color.Black;
            this.TxtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMessage.Location = new System.Drawing.Point(18, 219);
            this.TxtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.PasswordChar = '\0';
            this.TxtMessage.PlaceholderText = "";
            this.TxtMessage.SelectedText = "";
            this.TxtMessage.Size = new System.Drawing.Size(720, 264);
            this.TxtMessage.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(13, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Message";
            // 
            // TxtSubject
            // 
            this.TxtSubject.BorderColor = System.Drawing.Color.Black;
            this.TxtSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSubject.DefaultText = "";
            this.TxtSubject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSubject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSubject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtSubject.ForeColor = System.Drawing.Color.Black;
            this.TxtSubject.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSubject.Location = new System.Drawing.Point(18, 102);
            this.TxtSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.PasswordChar = '\0';
            this.TxtSubject.PlaceholderText = "";
            this.TxtSubject.SelectedText = "";
            this.TxtSubject.Size = new System.Drawing.Size(720, 40);
            this.TxtSubject.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Activation Message";
            // 
            // ctrlOrderCard1
            // 
            this.ctrlOrderCard1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlOrderCard1.Location = new System.Drawing.Point(44, 175);
            this.ctrlOrderCard1.Name = "ctrlOrderCard1";
            this.ctrlOrderCard1.Size = new System.Drawing.Size(532, 379);
            this.ctrlOrderCard1.TabIndex = 20;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Separator2.Location = new System.Drawing.Point(12, 116);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1377, 10);
            this.guna2Separator2.TabIndex = 19;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Separator1.Location = new System.Drawing.Point(12, 46);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1377, 10);
            this.guna2Separator1.TabIndex = 18;
            // 
            // btnDELETE
            // 
            this.btnDELETE.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDELETE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDELETE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDELETE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDELETE.FillColor = System.Drawing.Color.Red;
            this.btnDELETE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDELETE.ForeColor = System.Drawing.Color.White;
            this.btnDELETE.Image = global::CRM.Properties.Resources.trash_can;
            this.btnDELETE.Location = new System.Drawing.Point(431, 66);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(159, 44);
            this.btnDELETE.TabIndex = 17;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnCanceled
            // 
            this.btnCanceled.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCanceled.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCanceled.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCanceled.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCanceled.FillColor = System.Drawing.Color.DarkOrange;
            this.btnCanceled.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCanceled.ForeColor = System.Drawing.Color.White;
            this.btnCanceled.Image = global::CRM.Properties.Resources.x;
            this.btnCanceled.ImageSize = new System.Drawing.Size(18, 18);
            this.btnCanceled.Location = new System.Drawing.Point(234, 66);
            this.btnCanceled.Name = "btnCanceled";
            this.btnCanceled.Size = new System.Drawing.Size(159, 44);
            this.btnCanceled.TabIndex = 16;
            this.btnCanceled.Text = "CANCELED";
            this.btnCanceled.Click += new System.EventHandler(this.btnCanceled_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccept.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Image = global::CRM.Properties.Resources.check__1_;
            this.btnAccept.Location = new System.Drawing.Point(44, 66);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(159, 44);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "ACCEPT";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblOrderID.Location = new System.Drawing.Point(136, 14);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(27, 29);
            this.lblOrderID.TabIndex = 14;
            this.lblOrderID.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(39, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Order #";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::CRM.Properties.Resources.back;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1361, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 12;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // frmOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 848);
            this.Controls.Add(this.PanelForfrmOrderInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderInfo";
            this.Text = "frmOrderInfo";
            this.Load += new System.EventHandler(this.frmOrderInfo_Load);
            this.PanelForfrmOrderInfo.ResumeLayout(false);
            this.PanelForfrmOrderInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelForfrmOrderInfo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDELETE;
        private Guna.UI2.WinForms.Guna2Button btnCanceled;
        private Guna.UI2.WinForms.Guna2Button btnAccept;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Controls.ctrlOrderCard ctrlOrderCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox TxtMessage;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TxtSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSendMessage;
    }
}