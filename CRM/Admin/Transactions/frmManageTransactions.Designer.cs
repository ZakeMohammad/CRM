namespace CRM.Admin.Transactions
{
    partial class frmManageTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelForAllFormsInTransactions = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.btnExpense = new Guna.UI2.WinForms.Guna2Button();
            this.PanelForfrmManageTransactions = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CBForFIllter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtFiltterFor = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddTransaction = new Guna.UI2.WinForms.Guna2Button();
            this.DgvTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PanelForAllFormsInTransactions.SuspendLayout();
            this.PanelForfrmManageTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelForAllFormsInTransactions
            // 
            this.PanelForAllFormsInTransactions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelForAllFormsInTransactions.Controls.Add(this.label2);
            this.PanelForAllFormsInTransactions.Controls.Add(this.label1);
            this.PanelForAllFormsInTransactions.Controls.Add(this.btnDeposit);
            this.PanelForAllFormsInTransactions.Controls.Add(this.btnExpense);
            this.PanelForAllFormsInTransactions.Controls.Add(this.PanelForfrmManageTransactions);
            this.PanelForAllFormsInTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForAllFormsInTransactions.Location = new System.Drawing.Point(0, 0);
            this.PanelForAllFormsInTransactions.Name = "PanelForAllFormsInTransactions";
            this.PanelForAllFormsInTransactions.Size = new System.Drawing.Size(1653, 848);
            this.PanelForAllFormsInTransactions.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(863, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Expense";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Deposit";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BorderRadius = 15;
            this.btnDeposit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeposit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeposit.FillColor = System.Drawing.Color.Transparent;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Image = global::CRM.Properties.Resources.deposit;
            this.btnDeposit.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDeposit.Location = new System.Drawing.Point(542, 26);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(126, 52);
            this.btnDeposit.TabIndex = 29;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnExpense
            // 
            this.btnExpense.BackColor = System.Drawing.Color.Transparent;
            this.btnExpense.BorderRadius = 15;
            this.btnExpense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExpense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExpense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExpense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExpense.FillColor = System.Drawing.Color.Transparent;
            this.btnExpense.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExpense.ForeColor = System.Drawing.Color.White;
            this.btnExpense.Image = global::CRM.Properties.Resources.poor;
            this.btnExpense.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExpense.Location = new System.Drawing.Point(976, 26);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(136, 52);
            this.btnExpense.TabIndex = 28;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // PanelForfrmManageTransactions
            // 
            this.PanelForfrmManageTransactions.BackColor = System.Drawing.Color.Transparent;
            this.PanelForfrmManageTransactions.BorderRadius = 30;
            this.PanelForfrmManageTransactions.BorderThickness = 1;
            this.PanelForfrmManageTransactions.Controls.Add(this.label3);
            this.PanelForfrmManageTransactions.Controls.Add(this.NumberOfRecords);
            this.PanelForfrmManageTransactions.Controls.Add(this.CBForFIllter);
            this.PanelForfrmManageTransactions.Controls.Add(this.btnExport);
            this.PanelForfrmManageTransactions.Controls.Add(this.guna2HtmlLabel2);
            this.PanelForfrmManageTransactions.Controls.Add(this.TxtFiltterFor);
            this.PanelForfrmManageTransactions.Controls.Add(this.guna2HtmlLabel1);
            this.PanelForfrmManageTransactions.Controls.Add(this.btnAddTransaction);
            this.PanelForfrmManageTransactions.Controls.Add(this.DgvTransactions);
            this.PanelForfrmManageTransactions.FillColor = System.Drawing.Color.White;
            this.PanelForfrmManageTransactions.Location = new System.Drawing.Point(81, 84);
            this.PanelForfrmManageTransactions.Name = "PanelForfrmManageTransactions";
            this.PanelForfrmManageTransactions.ShadowDecoration.BorderRadius = 10;
            this.PanelForfrmManageTransactions.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.PanelForfrmManageTransactions.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.PanelForfrmManageTransactions.Size = new System.Drawing.Size(1490, 681);
            this.PanelForfrmManageTransactions.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(528, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 42);
            this.label3.TabIndex = 28;
            this.label3.Text = "𝑇𝑟𝑎𝑛𝑠𝑎𝑐𝑡𝑖𝑜𝑛𝑠 𝒮𝒸𝓇𝑒𝑒𝓃 ঌ";
            // 
            // NumberOfRecords
            // 
            this.NumberOfRecords.AutoSize = false;
            this.NumberOfRecords.BackColor = System.Drawing.Color.Transparent;
            this.NumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfRecords.Location = new System.Drawing.Point(143, 543);
            this.NumberOfRecords.Name = "NumberOfRecords";
            this.NumberOfRecords.Size = new System.Drawing.Size(172, 44);
            this.NumberOfRecords.TabIndex = 25;
            this.NumberOfRecords.Text = "0";
            // 
            // CBForFIllter
            // 
            this.CBForFIllter.BackColor = System.Drawing.Color.Transparent;
            this.CBForFIllter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBForFIllter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBForFIllter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBForFIllter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBForFIllter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBForFIllter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBForFIllter.ItemHeight = 23;
            this.CBForFIllter.Items.AddRange(new object[] {
            "None",
            "Source Account Number",
            "Destination Account Number",
            "Ammount"});
            this.CBForFIllter.Location = new System.Drawing.Point(134, 113);
            this.CBForFIllter.Name = "CBForFIllter";
            this.CBForFIllter.Size = new System.Drawing.Size(203, 29);
            this.CBForFIllter.StartIndex = 0;
            this.CBForFIllter.TabIndex = 21;
            this.CBForFIllter.SelectedIndexChanged += new System.EventHandler(this.CBForFIllter_SelectedIndexChanged);
            // 
            // btnExport
            // 
            this.btnExport.BorderRadius = 15;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.FillColor = System.Drawing.Color.LimeGreen;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = global::CRM.Properties.Resources.import;
            this.btnExport.Location = new System.Drawing.Point(1323, 543);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(136, 45);
            this.btnExport.TabIndex = 26;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(31, 543);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(172, 44);
            this.guna2HtmlLabel2.TabIndex = 24;
            this.guna2HtmlLabel2.Text = "# Records : ";
            // 
            // TxtFiltterFor
            // 
            this.TxtFiltterFor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFiltterFor.DefaultText = "";
            this.TxtFiltterFor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtFiltterFor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtFiltterFor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFiltterFor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFiltterFor.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TxtFiltterFor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFiltterFor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtFiltterFor.ForeColor = System.Drawing.Color.Black;
            this.TxtFiltterFor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFiltterFor.Location = new System.Drawing.Point(343, 113);
            this.TxtFiltterFor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtFiltterFor.Name = "TxtFiltterFor";
            this.TxtFiltterFor.PasswordChar = '\0';
            this.TxtFiltterFor.PlaceholderText = "Search";
            this.TxtFiltterFor.SelectedText = "";
            this.TxtFiltterFor.Size = new System.Drawing.Size(771, 31);
            this.TxtFiltterFor.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtFiltterFor.TabIndex = 23;
            this.TxtFiltterFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtFiltterFor.Visible = false;
            this.TxtFiltterFor.TextChanged += new System.EventHandler(this.TxtFiltterFor_TextChanged);
            this.TxtFiltterFor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFiltterFor_KeyPress);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(42, 113);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(196, 44);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = "Fillter By:";
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.AnimatedGIF = true;
            this.btnAddTransaction.BorderRadius = 15;
            this.btnAddTransaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTransaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTransaction.FillColor = System.Drawing.Color.Transparent;
            this.btnAddTransaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTransaction.ForeColor = System.Drawing.Color.White;
            this.btnAddTransaction.Image = global::CRM.Properties.Resources.transaction__2_;
            this.btnAddTransaction.ImageSize = new System.Drawing.Size(60, 60);
            this.btnAddTransaction.Location = new System.Drawing.Point(1384, 93);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(75, 64);
            this.btnAddTransaction.TabIndex = 20;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // DgvTransactions
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvTransactions.ColumnHeadersHeight = 25;
            this.DgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DgvTransactions.Location = new System.Drawing.Point(31, 163);
            this.DgvTransactions.Name = "DgvTransactions";
            this.DgvTransactions.ReadOnly = true;
            this.DgvTransactions.RowHeadersVisible = false;
            this.DgvTransactions.RowHeadersWidth = 51;
            this.DgvTransactions.RowTemplate.Height = 24;
            this.DgvTransactions.Size = new System.Drawing.Size(1428, 364);
            this.DgvTransactions.TabIndex = 19;
            this.DgvTransactions.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.DgvTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DgvTransactions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvTransactions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvTransactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DgvTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.DgvTransactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvTransactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvTransactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvTransactions.ThemeStyle.HeaderStyle.Height = 25;
            this.DgvTransactions.ThemeStyle.ReadOnly = true;
            this.DgvTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvTransactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvTransactions.ThemeStyle.RowsStyle.Height = 24;
            this.DgvTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DgvTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // frmManageTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1653, 848);
            this.Controls.Add(this.PanelForAllFormsInTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageTransactions";
            this.Tag = "Transaction";
            this.Text = "frmManageTransactions";
            this.Load += new System.EventHandler(this.frmManageTransactions_Load);
            this.PanelForAllFormsInTransactions.ResumeLayout(false);
            this.PanelForAllFormsInTransactions.PerformLayout();
            this.PanelForfrmManageTransactions.ResumeLayout(false);
            this.PanelForfrmManageTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelForAllFormsInTransactions;
        private Guna.UI2.WinForms.Guna2Panel PanelForfrmManageTransactions;
        private Guna.UI2.WinForms.Guna2HtmlLabel NumberOfRecords;
        private Guna.UI2.WinForms.Guna2ComboBox CBForFIllter;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox TxtFiltterFor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnAddTransaction;
        private Guna.UI2.WinForms.Guna2DataGridView DgvTransactions;
        private Guna.UI2.WinForms.Guna2Button btnDeposit;
        private Guna.UI2.WinForms.Guna2Button btnExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}