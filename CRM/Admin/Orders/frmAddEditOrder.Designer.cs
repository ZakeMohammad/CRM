namespace CRM.Admin.Orders
{
    partial class frmAddEditOrder
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
            this.components = new System.ComponentModel.Container();
            this.PanelForfrmAddEditOrder = new Guna.UI2.WinForms.Guna2Panel();
            this.NumbercOrderQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.CBCustomers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancle = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RDNotSend = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RDSendEmail = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RDNotGenereate = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RDGenerateInvoce = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.TxtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.CBStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CBProducts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelForfrmAddEditOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumbercOrderQuantity)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelForfrmAddEditOrder
            // 
            this.PanelForfrmAddEditOrder.BackColor = System.Drawing.Color.Transparent;
            this.PanelForfrmAddEditOrder.BorderRadius = 30;
            this.PanelForfrmAddEditOrder.BorderThickness = 1;
            this.PanelForfrmAddEditOrder.Controls.Add(this.NumbercOrderQuantity);
            this.PanelForfrmAddEditOrder.Controls.Add(this.CBCustomers);
            this.PanelForfrmAddEditOrder.Controls.Add(this.label11);
            this.PanelForfrmAddEditOrder.Controls.Add(this.btnCancle);
            this.PanelForfrmAddEditOrder.Controls.Add(this.btnSave);
            this.PanelForfrmAddEditOrder.Controls.Add(this.panel2);
            this.PanelForfrmAddEditOrder.Controls.Add(this.panel1);
            this.PanelForfrmAddEditOrder.Controls.Add(this.TxtPrice);
            this.PanelForfrmAddEditOrder.Controls.Add(this.CBStatus);
            this.PanelForfrmAddEditOrder.Controls.Add(this.CBProducts);
            this.PanelForfrmAddEditOrder.Controls.Add(this.label6);
            this.PanelForfrmAddEditOrder.Controls.Add(this.label5);
            this.PanelForfrmAddEditOrder.Controls.Add(this.label4);
            this.PanelForfrmAddEditOrder.Controls.Add(this.label3);
            this.PanelForfrmAddEditOrder.Controls.Add(this.label1);
            this.PanelForfrmAddEditOrder.Controls.Add(this.guna2CirclePictureBox1);
            this.PanelForfrmAddEditOrder.FillColor = System.Drawing.Color.White;
            this.PanelForfrmAddEditOrder.Location = new System.Drawing.Point(76, 80);
            this.PanelForfrmAddEditOrder.Name = "PanelForfrmAddEditOrder";
            this.PanelForfrmAddEditOrder.ShadowDecoration.BorderRadius = 10;
            this.PanelForfrmAddEditOrder.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.PanelForfrmAddEditOrder.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.PanelForfrmAddEditOrder.Size = new System.Drawing.Size(1428, 548);
            this.PanelForfrmAddEditOrder.TabIndex = 3;
            // 
            // NumbercOrderQuantity
            // 
            this.NumbercOrderQuantity.BackColor = System.Drawing.Color.Transparent;
            this.NumbercOrderQuantity.BorderRadius = 15;
            this.NumbercOrderQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumbercOrderQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumbercOrderQuantity.Location = new System.Drawing.Point(656, 210);
            this.NumbercOrderQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumbercOrderQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumbercOrderQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumbercOrderQuantity.Name = "NumbercOrderQuantity";
            this.NumbercOrderQuantity.Size = new System.Drawing.Size(139, 39);
            this.NumbercOrderQuantity.TabIndex = 35;
            this.NumbercOrderQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NumbercOrderQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumbercOrderQuantity.ValueChanged += new System.EventHandler(this.NumbercOrderQuantity_ValueChanged);
            // 
            // CBCustomers
            // 
            this.CBCustomers.BackColor = System.Drawing.Color.Transparent;
            this.CBCustomers.BorderRadius = 5;
            this.CBCustomers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCustomers.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBCustomers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBCustomers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBCustomers.ForeColor = System.Drawing.Color.Black;
            this.CBCustomers.ItemHeight = 30;
            this.CBCustomers.Location = new System.Drawing.Point(358, 90);
            this.CBCustomers.Name = "CBCustomers";
            this.CBCustomers.Size = new System.Drawing.Size(734, 36);
            this.CBCustomers.TabIndex = 34;
            this.CBCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CBCustomers.SelectedIndexChanged += new System.EventHandler(this.CBCustomers_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(191, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 25);
            this.label11.TabIndex = 33;
            this.label11.Text = "Customer";
            // 
            // btnCancle
            // 
            this.btnCancle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancle.FillColor = System.Drawing.Color.IndianRed;
            this.btnCancle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.Location = new System.Drawing.Point(750, 469);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(111, 41);
            this.btnCancle.TabIndex = 32;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::CRM.Properties.Resources.check__1_;
            this.btnSave.Location = new System.Drawing.Point(620, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 41);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.RDNotSend);
            this.panel2.Controls.Add(this.RDSendEmail);
            this.panel2.Location = new System.Drawing.Point(357, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 56);
            this.panel2.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(190, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 22);
            this.label10.TabIndex = 31;
            this.label10.Text = "No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "Yes";
            // 
            // RDNotSend
            // 
            this.RDNotSend.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDNotSend.CheckedState.BorderThickness = 0;
            this.RDNotSend.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDNotSend.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RDNotSend.Location = new System.Drawing.Point(151, 13);
            this.RDNotSend.Name = "RDNotSend";
            this.RDNotSend.Size = new System.Drawing.Size(33, 27);
            this.RDNotSend.TabIndex = 25;
            this.RDNotSend.Text = "guna2CustomRadioButton1";
            this.RDNotSend.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.RDNotSend.UncheckedState.BorderThickness = 2;
            this.RDNotSend.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RDNotSend.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // RDSendEmail
            // 
            this.RDSendEmail.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDSendEmail.CheckedState.BorderThickness = 0;
            this.RDSendEmail.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDSendEmail.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RDSendEmail.Location = new System.Drawing.Point(26, 13);
            this.RDSendEmail.Name = "RDSendEmail";
            this.RDSendEmail.Size = new System.Drawing.Size(33, 27);
            this.RDSendEmail.TabIndex = 23;
            this.RDSendEmail.Text = "guna2CustomRadioButton1";
            this.RDSendEmail.UncheckedState.BorderColor = System.Drawing.Color.Green;
            this.RDSendEmail.UncheckedState.BorderThickness = 2;
            this.RDSendEmail.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RDSendEmail.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.RDNotGenereate);
            this.panel1.Controls.Add(this.RDGenerateInvoce);
            this.panel1.Location = new System.Drawing.Point(357, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 56);
            this.panel1.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(190, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 22);
            this.label9.TabIndex = 30;
            this.label9.Text = "No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Yes";
            // 
            // RDNotGenereate
            // 
            this.RDNotGenereate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDNotGenereate.CheckedState.BorderThickness = 0;
            this.RDNotGenereate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDNotGenereate.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RDNotGenereate.Location = new System.Drawing.Point(151, 12);
            this.RDNotGenereate.Name = "RDNotGenereate";
            this.RDNotGenereate.Size = new System.Drawing.Size(33, 27);
            this.RDNotGenereate.TabIndex = 25;
            this.RDNotGenereate.Text = "guna2CustomRadioButton1";
            this.RDNotGenereate.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.RDNotGenereate.UncheckedState.BorderThickness = 2;
            this.RDNotGenereate.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RDNotGenereate.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // RDGenerateInvoce
            // 
            this.RDGenerateInvoce.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDGenerateInvoce.CheckedState.BorderThickness = 0;
            this.RDGenerateInvoce.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDGenerateInvoce.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RDGenerateInvoce.Location = new System.Drawing.Point(26, 13);
            this.RDGenerateInvoce.Name = "RDGenerateInvoce";
            this.RDGenerateInvoce.Size = new System.Drawing.Size(33, 27);
            this.RDGenerateInvoce.TabIndex = 23;
            this.RDGenerateInvoce.Text = "guna2CustomRadioButton1";
            this.RDGenerateInvoce.UncheckedState.BorderColor = System.Drawing.Color.Green;
            this.RDGenerateInvoce.UncheckedState.BorderThickness = 2;
            this.RDGenerateInvoce.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RDGenerateInvoce.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPrice.DefaultText = "";
            this.TxtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtPrice.ForeColor = System.Drawing.Color.Black;
            this.TxtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrice.IconLeft = global::CRM.Properties.Resources.dollar_symbol;
            this.TxtPrice.Location = new System.Drawing.Point(359, 212);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.PasswordChar = '\0';
            this.TxtPrice.PlaceholderText = "";
            this.TxtPrice.ReadOnly = true;
            this.TxtPrice.SelectedText = "";
            this.TxtPrice.Size = new System.Drawing.Size(291, 37);
            this.TxtPrice.TabIndex = 22;
            this.TxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPrice.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // CBStatus
            // 
            this.CBStatus.BackColor = System.Drawing.Color.Transparent;
            this.CBStatus.BorderRadius = 5;
            this.CBStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBStatus.ForeColor = System.Drawing.Color.Black;
            this.CBStatus.ItemHeight = 30;
            this.CBStatus.Items.AddRange(new object[] {
            "Pending",
            "Active"});
            this.CBStatus.Location = new System.Drawing.Point(359, 147);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(734, 36);
            this.CBStatus.TabIndex = 21;
            this.CBStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CBProducts
            // 
            this.CBProducts.BackColor = System.Drawing.Color.Transparent;
            this.CBProducts.BorderRadius = 5;
            this.CBProducts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBProducts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBProducts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBProducts.ForeColor = System.Drawing.Color.Black;
            this.CBProducts.ItemHeight = 30;
            this.CBProducts.Location = new System.Drawing.Point(358, 29);
            this.CBProducts.Name = "CBProducts";
            this.CBProducts.Size = new System.Drawing.Size(734, 36);
            this.CBProducts.TabIndex = 19;
            this.CBProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CBProducts.SelectedIndexChanged += new System.EventHandler(this.CBProducts_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Send Email ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Generate Invoice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Price ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product";
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
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 848);
            this.Controls.Add(this.PanelForfrmAddEditOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditOrder";
            this.Tag = "Order";
            this.Text = "frmAddEditOrder";
            this.Load += new System.EventHandler(this.frmAddEditOrder_Load);
            this.PanelForfrmAddEditOrder.ResumeLayout(false);
            this.PanelForfrmAddEditOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumbercOrderQuantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelForfrmAddEditOrder;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtPrice;
        private Guna.UI2.WinForms.Guna2ComboBox CBStatus;
        private Guna.UI2.WinForms.Guna2ComboBox CBProducts;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RDNotGenereate;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RDGenerateInvoce;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RDNotSend;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RDSendEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnCancle;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox CBCustomers;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumbercOrderQuantity;
    }
}