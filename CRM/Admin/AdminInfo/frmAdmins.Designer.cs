namespace CRM.Admin
{
    partial class frmAdmins
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
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showCustomerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.PanelForAllFormsAdmin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CBForFIllter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.NumberOfRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtFiltterFor = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.DgvAdmins = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.PanelForAllFormsAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdmins)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCustomerInfoToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(197, 88);
            // 
            // showCustomerInfoToolStripMenuItem
            // 
            this.showCustomerInfoToolStripMenuItem.Image = global::CRM.Properties.Resources.information;
            this.showCustomerInfoToolStripMenuItem.Name = "showCustomerInfoToolStripMenuItem";
            this.showCustomerInfoToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.showCustomerInfoToolStripMenuItem.Text = "Show Admin Info";
            this.showCustomerInfoToolStripMenuItem.Click += new System.EventHandler(this.showCustomerInfoToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::CRM.Properties.Resources.edit__3_;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::CRM.Properties.Resources.delete__3_;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 6);
            // 
            // PanelForAllFormsAdmin
            // 
            this.PanelForAllFormsAdmin.Controls.Add(this.panel1);
            this.PanelForAllFormsAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForAllFormsAdmin.Location = new System.Drawing.Point(0, 0);
            this.PanelForAllFormsAdmin.Name = "PanelForAllFormsAdmin";
            this.PanelForAllFormsAdmin.Size = new System.Drawing.Size(1749, 848);
            this.PanelForAllFormsAdmin.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CBForFIllter);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.NumberOfRecords);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.TxtFiltterFor);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.btnAddAdmin);
            this.panel1.Controls.Add(this.DgvAdmins);
            this.panel1.Location = new System.Drawing.Point(56, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1606, 579);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(650, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "𝒂𝒅𝒎𝒊𝒏 𝒔𝒄𝒓𝒆𝒆𝒏 ঌ";
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
            "Username",
            "Name"});
            this.CBForFIllter.Location = new System.Drawing.Point(147, 101);
            this.CBForFIllter.Name = "CBForFIllter";
            this.CBForFIllter.Size = new System.Drawing.Size(203, 29);
            this.CBForFIllter.StartIndex = 0;
            this.CBForFIllter.TabIndex = 3;
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
            this.btnExport.Location = new System.Drawing.Point(1348, 508);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(136, 45);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // NumberOfRecords
            // 
            this.NumberOfRecords.AutoSize = false;
            this.NumberOfRecords.BackColor = System.Drawing.Color.Transparent;
            this.NumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfRecords.Location = new System.Drawing.Point(168, 508);
            this.NumberOfRecords.Name = "NumberOfRecords";
            this.NumberOfRecords.Size = new System.Drawing.Size(172, 44);
            this.NumberOfRecords.TabIndex = 7;
            this.NumberOfRecords.Text = "0";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(56, 508);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(172, 44);
            this.guna2HtmlLabel2.TabIndex = 6;
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
            this.TxtFiltterFor.Location = new System.Drawing.Point(356, 101);
            this.TxtFiltterFor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtFiltterFor.Name = "TxtFiltterFor";
            this.TxtFiltterFor.PasswordChar = '\0';
            this.TxtFiltterFor.PlaceholderText = "Search";
            this.TxtFiltterFor.SelectedText = "";
            this.TxtFiltterFor.Size = new System.Drawing.Size(771, 31);
            this.TxtFiltterFor.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtFiltterFor.TabIndex = 5;
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
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(56, 101);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(234, 44);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Fillter By:";
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.AnimatedGIF = true;
            this.btnAddAdmin.BorderRadius = 15;
            this.btnAddAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAdmin.FillColor = System.Drawing.Color.Transparent;
            this.btnAddAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAddAdmin.Image = global::CRM.Properties.Resources.add_friend;
            this.btnAddAdmin.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddAdmin.Location = new System.Drawing.Point(1435, 88);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(75, 44);
            this.btnAddAdmin.TabIndex = 2;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // DgvAdmins
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DgvAdmins.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAdmins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAdmins.ColumnHeadersHeight = 25;
            this.DgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvAdmins.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAdmins.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvAdmins.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DgvAdmins.Location = new System.Drawing.Point(56, 152);
            this.DgvAdmins.Name = "DgvAdmins";
            this.DgvAdmins.ReadOnly = true;
            this.DgvAdmins.RowHeadersVisible = false;
            this.DgvAdmins.RowHeadersWidth = 51;
            this.DgvAdmins.RowTemplate.Height = 24;
            this.DgvAdmins.Size = new System.Drawing.Size(1428, 350);
            this.DgvAdmins.TabIndex = 1;
            this.DgvAdmins.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.DgvAdmins.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DgvAdmins.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvAdmins.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvAdmins.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvAdmins.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvAdmins.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvAdmins.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DgvAdmins.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.DgvAdmins.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvAdmins.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvAdmins.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvAdmins.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvAdmins.ThemeStyle.HeaderStyle.Height = 25;
            this.DgvAdmins.ThemeStyle.ReadOnly = true;
            this.DgvAdmins.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvAdmins.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvAdmins.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvAdmins.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvAdmins.ThemeStyle.RowsStyle.Height = 24;
            this.DgvAdmins.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DgvAdmins.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // frmAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1749, 848);
            this.Controls.Add(this.PanelForAllFormsAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmins";
            this.Tag = "Admin";
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmAdmins_Load);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.PanelForAllFormsAdmin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdmins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showCustomerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Panel PanelForAllFormsAdmin;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox CBForFIllter;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2HtmlLabel NumberOfRecords;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox TxtFiltterFor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnAddAdmin;
        private Guna.UI2.WinForms.Guna2DataGridView DgvAdmins;
        private System.Windows.Forms.Label label1;
    }
}