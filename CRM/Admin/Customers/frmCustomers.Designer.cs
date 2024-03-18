namespace CRM.Admin
{
    partial class frmCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelForFormAddEditCustomer = new System.Windows.Forms.Panel();
            this.ProgreesForDelete = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBForFIllter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.NumberOfRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtFiltterFor = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.DgvCustomers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showCustomerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TimerForActions = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.PanelForFormAddEditCustomer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForFormAddEditCustomer
            // 
            this.PanelForFormAddEditCustomer.Controls.Add(this.ProgreesForDelete);
            this.PanelForFormAddEditCustomer.Controls.Add(this.panel1);
            this.PanelForFormAddEditCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForFormAddEditCustomer.Location = new System.Drawing.Point(0, 0);
            this.PanelForFormAddEditCustomer.Name = "PanelForFormAddEditCustomer";
            this.PanelForFormAddEditCustomer.Size = new System.Drawing.Size(1676, 848);
            this.PanelForFormAddEditCustomer.TabIndex = 0;
            // 
            // ProgreesForDelete
            // 
            this.ProgreesForDelete.AutoStart = true;
            this.ProgreesForDelete.Location = new System.Drawing.Point(734, 625);
            this.ProgreesForDelete.Name = "ProgreesForDelete";
            this.ProgreesForDelete.ProgressColor = System.Drawing.Color.Red;
            this.ProgreesForDelete.Size = new System.Drawing.Size(128, 111);
            this.ProgreesForDelete.TabIndex = 4;
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
            this.panel1.Controls.Add(this.btnAddCustomer);
            this.panel1.Controls.Add(this.DgvCustomers);
            this.panel1.Location = new System.Drawing.Point(35, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1606, 565);
            this.panel1.TabIndex = 1;
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
            "Customer ID",
            "Name",
            "Company Name",
            "Group Name"});
            this.CBForFIllter.Location = new System.Drawing.Point(168, 83);
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
            this.btnExport.Location = new System.Drawing.Point(1348, 503);
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
            this.NumberOfRecords.Location = new System.Drawing.Point(168, 504);
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
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(56, 504);
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
            this.TxtFiltterFor.Location = new System.Drawing.Point(377, 83);
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
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(71, 83);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(234, 44);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Fillter By:";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.AnimatedGIF = true;
            this.btnAddCustomer.BorderRadius = 15;
            this.btnAddCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Image = global::CRM.Properties.Resources.add_friend;
            this.btnAddCustomer.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddCustomer.Location = new System.Drawing.Point(1431, 83);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 44);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // DgvCustomers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCustomers.ColumnHeadersHeight = 25;
            this.DgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvCustomers.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DgvCustomers.Location = new System.Drawing.Point(56, 133);
            this.DgvCustomers.Name = "DgvCustomers";
            this.DgvCustomers.ReadOnly = true;
            this.DgvCustomers.RowHeadersVisible = false;
            this.DgvCustomers.RowHeadersWidth = 51;
            this.DgvCustomers.RowTemplate.Height = 24;
            this.DgvCustomers.Size = new System.Drawing.Size(1428, 364);
            this.DgvCustomers.TabIndex = 1;
            this.DgvCustomers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.DgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvCustomers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvCustomers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DgvCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.DgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvCustomers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvCustomers.ThemeStyle.HeaderStyle.Height = 25;
            this.DgvCustomers.ThemeStyle.ReadOnly = true;
            this.DgvCustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvCustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvCustomers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvCustomers.ThemeStyle.RowsStyle.Height = 24;
            this.DgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCustomerInfoToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sendEmailToolStripMenuItem,
            this.callPhoneToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(216, 140);
            // 
            // showCustomerInfoToolStripMenuItem
            // 
            this.showCustomerInfoToolStripMenuItem.Image = global::CRM.Properties.Resources.information;
            this.showCustomerInfoToolStripMenuItem.Name = "showCustomerInfoToolStripMenuItem";
            this.showCustomerInfoToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.showCustomerInfoToolStripMenuItem.Text = "Show Customer Info";
            this.showCustomerInfoToolStripMenuItem.Click += new System.EventHandler(this.showCustomerInfoToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::CRM.Properties.Resources.edit__3_;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::CRM.Properties.Resources.delete__3_;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(212, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::CRM.Properties.Resources.envelope__1_;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // callPhoneToolStripMenuItem
            // 
            this.callPhoneToolStripMenuItem.Image = global::CRM.Properties.Resources.phone_call;
            this.callPhoneToolStripMenuItem.Name = "callPhoneToolStripMenuItem";
            this.callPhoneToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.callPhoneToolStripMenuItem.Text = "Call Phone";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TimerForActions
            // 
            this.TimerForActions.Interval = 1000;
            this.TimerForActions.Tick += new System.EventHandler(this.TimerForActions_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(627, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "𝒞𝓊𝓈𝓉𝑜𝓂𝑒𝓇 𝒮𝒸𝓇𝑒𝑒𝓃 ঌ";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 848);
            this.Controls.Add(this.PanelForFormAddEditCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomers";
            this.Tag = "Customers";
            this.Text = "frmCustomers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.PanelForFormAddEditCustomer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelForFormAddEditCustomer;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DgvCustomers;
        private Guna.UI2.WinForms.Guna2Button btnAddCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox CBForFIllter;
        private Guna.UI2.WinForms.Guna2TextBox TxtFiltterFor;
        private Guna.UI2.WinForms.Guna2HtmlLabel NumberOfRecords;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showCustomerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callPhoneToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator ProgreesForDelete;
        private System.Windows.Forms.Timer TimerForActions;
        private System.Windows.Forms.Label label1;
    }
}