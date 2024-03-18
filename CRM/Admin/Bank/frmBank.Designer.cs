namespace CRM.Admin
{
    partial class frmBank
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
            this.PanelForFormsBank = new System.Windows.Forms.Panel();
            this.PanelForfrmCalender = new Guna.UI2.WinForms.Guna2Panel();
            this.CBForFIllter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.NumberOfRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtFiltterFor = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddBankAccount = new Guna.UI2.WinForms.Guna2Button();
            this.DgvBanksAccount = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showAccountInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deeteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelForFormsBank.SuspendLayout();
            this.PanelForfrmCalender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBanksAccount)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForFormsBank
            // 
            this.PanelForFormsBank.Controls.Add(this.PanelForfrmCalender);
            this.PanelForFormsBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForFormsBank.Location = new System.Drawing.Point(0, 0);
            this.PanelForFormsBank.Name = "PanelForFormsBank";
            this.PanelForFormsBank.Size = new System.Drawing.Size(1715, 848);
            this.PanelForFormsBank.TabIndex = 1;
            // 
            // PanelForfrmCalender
            // 
            this.PanelForfrmCalender.BackColor = System.Drawing.Color.Transparent;
            this.PanelForfrmCalender.BorderRadius = 30;
            this.PanelForfrmCalender.BorderThickness = 1;
            this.PanelForfrmCalender.Controls.Add(this.label1);
            this.PanelForfrmCalender.Controls.Add(this.CBForFIllter);
            this.PanelForfrmCalender.Controls.Add(this.btnExport);
            this.PanelForfrmCalender.Controls.Add(this.NumberOfRecords);
            this.PanelForfrmCalender.Controls.Add(this.guna2HtmlLabel2);
            this.PanelForfrmCalender.Controls.Add(this.TxtFiltterFor);
            this.PanelForfrmCalender.Controls.Add(this.guna2HtmlLabel1);
            this.PanelForfrmCalender.Controls.Add(this.btnAddBankAccount);
            this.PanelForfrmCalender.Controls.Add(this.DgvBanksAccount);
            this.PanelForfrmCalender.FillColor = System.Drawing.Color.White;
            this.PanelForfrmCalender.Location = new System.Drawing.Point(99, 40);
            this.PanelForfrmCalender.Name = "PanelForfrmCalender";
            this.PanelForfrmCalender.ShadowDecoration.BorderRadius = 10;
            this.PanelForfrmCalender.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.PanelForfrmCalender.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.PanelForfrmCalender.Size = new System.Drawing.Size(1459, 610);
            this.PanelForfrmCalender.TabIndex = 1;
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
            "Account Number",
            "Name",
            "Bank Name"});
            this.CBForFIllter.Location = new System.Drawing.Point(107, 109);
            this.CBForFIllter.Name = "CBForFIllter";
            this.CBForFIllter.Size = new System.Drawing.Size(203, 29);
            this.CBForFIllter.StartIndex = 0;
            this.CBForFIllter.TabIndex = 11;
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
            this.btnExport.Location = new System.Drawing.Point(1296, 539);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(136, 45);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // NumberOfRecords
            // 
            this.NumberOfRecords.AutoSize = false;
            this.NumberOfRecords.BackColor = System.Drawing.Color.Transparent;
            this.NumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfRecords.Location = new System.Drawing.Point(118, 540);
            this.NumberOfRecords.Name = "NumberOfRecords";
            this.NumberOfRecords.Size = new System.Drawing.Size(172, 44);
            this.NumberOfRecords.TabIndex = 15;
            this.NumberOfRecords.Text = "0";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(15, 539);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(172, 44);
            this.guna2HtmlLabel2.TabIndex = 14;
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
            this.TxtFiltterFor.Location = new System.Drawing.Point(316, 109);
            this.TxtFiltterFor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtFiltterFor.Name = "TxtFiltterFor";
            this.TxtFiltterFor.PasswordChar = '\0';
            this.TxtFiltterFor.PlaceholderText = "Search";
            this.TxtFiltterFor.SelectedText = "";
            this.TxtFiltterFor.Size = new System.Drawing.Size(771, 31);
            this.TxtFiltterFor.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtFiltterFor.TabIndex = 13;
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
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(15, 109);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(234, 44);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "Fillter By:";
            // 
            // btnAddBankAccount
            // 
            this.btnAddBankAccount.AnimatedGIF = true;
            this.btnAddBankAccount.BorderRadius = 15;
            this.btnAddBankAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBankAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBankAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBankAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBankAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnAddBankAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddBankAccount.ForeColor = System.Drawing.Color.White;
            this.btnAddBankAccount.Image = global::CRM.Properties.Resources.account;
            this.btnAddBankAccount.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddBankAccount.Location = new System.Drawing.Point(1371, 96);
            this.btnAddBankAccount.Name = "btnAddBankAccount";
            this.btnAddBankAccount.Size = new System.Drawing.Size(75, 44);
            this.btnAddBankAccount.TabIndex = 10;
            this.btnAddBankAccount.Click += new System.EventHandler(this.btnAddBankAccount_Click);
            // 
            // DgvBanksAccount
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DgvBanksAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBanksAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvBanksAccount.ColumnHeadersHeight = 25;
            this.DgvBanksAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvBanksAccount.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBanksAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvBanksAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DgvBanksAccount.Location = new System.Drawing.Point(15, 159);
            this.DgvBanksAccount.Name = "DgvBanksAccount";
            this.DgvBanksAccount.ReadOnly = true;
            this.DgvBanksAccount.RowHeadersVisible = false;
            this.DgvBanksAccount.RowHeadersWidth = 51;
            this.DgvBanksAccount.RowTemplate.Height = 24;
            this.DgvBanksAccount.Size = new System.Drawing.Size(1417, 364);
            this.DgvBanksAccount.TabIndex = 9;
            this.DgvBanksAccount.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.DgvBanksAccount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DgvBanksAccount.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvBanksAccount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvBanksAccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvBanksAccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvBanksAccount.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvBanksAccount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DgvBanksAccount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.DgvBanksAccount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvBanksAccount.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvBanksAccount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvBanksAccount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvBanksAccount.ThemeStyle.HeaderStyle.Height = 25;
            this.DgvBanksAccount.ThemeStyle.ReadOnly = true;
            this.DgvBanksAccount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvBanksAccount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvBanksAccount.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvBanksAccount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvBanksAccount.ThemeStyle.RowsStyle.Height = 24;
            this.DgvBanksAccount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DgvBanksAccount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAccountInfoToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deeteToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(207, 82);
            // 
            // showAccountInfoToolStripMenuItem
            // 
            this.showAccountInfoToolStripMenuItem.Image = global::CRM.Properties.Resources.information;
            this.showAccountInfoToolStripMenuItem.Name = "showAccountInfoToolStripMenuItem";
            this.showAccountInfoToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.showAccountInfoToolStripMenuItem.Text = "Show Account Info";
            this.showAccountInfoToolStripMenuItem.Click += new System.EventHandler(this.showAccountInfoToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::CRM.Properties.Resources.edit__3_;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deeteToolStripMenuItem
            // 
            this.deeteToolStripMenuItem.Image = global::CRM.Properties.Resources.delete__3_;
            this.deeteToolStripMenuItem.Name = "deeteToolStripMenuItem";
            this.deeteToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.deeteToolStripMenuItem.Text = "De;ete";
            this.deeteToolStripMenuItem.Click += new System.EventHandler(this.deeteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(586, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "𝐵𝑎𝑛𝑘 𝒮𝒸𝓇𝑒𝑒𝓃 ঌ";
            // 
            // frmBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1715, 848);
            this.Controls.Add(this.PanelForFormsBank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBank";
            this.Tag = "Bank";
            this.Text = "frmBank";
            this.Load += new System.EventHandler(this.frmBank_Load);
            this.PanelForFormsBank.ResumeLayout(false);
            this.PanelForfrmCalender.ResumeLayout(false);
            this.PanelForfrmCalender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBanksAccount)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelForFormsBank;
        private Guna.UI2.WinForms.Guna2Panel PanelForfrmCalender;
        private Guna.UI2.WinForms.Guna2ComboBox CBForFIllter;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2HtmlLabel NumberOfRecords;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox TxtFiltterFor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnAddBankAccount;
        private Guna.UI2.WinForms.Guna2DataGridView DgvBanksAccount;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showAccountInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deeteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}