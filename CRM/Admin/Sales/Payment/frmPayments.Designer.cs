namespace CRM.Admin
{
    partial class frmPayments
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
            this.PanelForfrmAdminPayments = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CBForFIllter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.NumberOfRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtFiltterFor = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DgvAdminInPayments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PanelForfrmAdminPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdminInPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelForfrmAdminPayments
            // 
            this.PanelForfrmAdminPayments.BackColor = System.Drawing.Color.Transparent;
            this.PanelForfrmAdminPayments.BorderRadius = 10;
            this.PanelForfrmAdminPayments.BorderThickness = 1;
            this.PanelForfrmAdminPayments.Controls.Add(this.label1);
            this.PanelForfrmAdminPayments.Controls.Add(this.CBForFIllter);
            this.PanelForfrmAdminPayments.Controls.Add(this.btnExport);
            this.PanelForfrmAdminPayments.Controls.Add(this.NumberOfRecords);
            this.PanelForfrmAdminPayments.Controls.Add(this.guna2HtmlLabel2);
            this.PanelForfrmAdminPayments.Controls.Add(this.TxtFiltterFor);
            this.PanelForfrmAdminPayments.Controls.Add(this.guna2HtmlLabel1);
            this.PanelForfrmAdminPayments.Controls.Add(this.DgvAdminInPayments);
            this.PanelForfrmAdminPayments.FillColor = System.Drawing.Color.White;
            this.PanelForfrmAdminPayments.Location = new System.Drawing.Point(61, 84);
            this.PanelForfrmAdminPayments.Name = "PanelForfrmAdminPayments";
            this.PanelForfrmAdminPayments.ShadowDecoration.BorderRadius = 10;
            this.PanelForfrmAdminPayments.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.PanelForfrmAdminPayments.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(12, 0, 0, 12);
            this.PanelForfrmAdminPayments.Size = new System.Drawing.Size(1459, 681);
            this.PanelForfrmAdminPayments.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(557, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "𝑃𝑎𝑦𝑚𝑒𝑛𝑡𝑠 𝒮𝒸𝓇𝑒𝑒𝓃 ঌ";
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
            "Name",
            "Method Name",
            "Gategory Name",
            "Amount"});
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
            // DgvAdminInPayments
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DgvAdminInPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAdminInPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAdminInPayments.ColumnHeadersHeight = 25;
            this.DgvAdminInPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAdminInPayments.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvAdminInPayments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DgvAdminInPayments.Location = new System.Drawing.Point(15, 159);
            this.DgvAdminInPayments.Name = "DgvAdminInPayments";
            this.DgvAdminInPayments.ReadOnly = true;
            this.DgvAdminInPayments.RowHeadersVisible = false;
            this.DgvAdminInPayments.RowHeadersWidth = 51;
            this.DgvAdminInPayments.RowTemplate.Height = 24;
            this.DgvAdminInPayments.Size = new System.Drawing.Size(1417, 364);
            this.DgvAdminInPayments.TabIndex = 9;
            this.DgvAdminInPayments.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.DgvAdminInPayments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DgvAdminInPayments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvAdminInPayments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvAdminInPayments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvAdminInPayments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvAdminInPayments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvAdminInPayments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.DgvAdminInPayments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.DgvAdminInPayments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvAdminInPayments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvAdminInPayments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvAdminInPayments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvAdminInPayments.ThemeStyle.HeaderStyle.Height = 25;
            this.DgvAdminInPayments.ThemeStyle.ReadOnly = true;
            this.DgvAdminInPayments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvAdminInPayments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvAdminInPayments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvAdminInPayments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvAdminInPayments.ThemeStyle.RowsStyle.Height = 24;
            this.DgvAdminInPayments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DgvAdminInPayments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 848);
            this.Controls.Add(this.PanelForfrmAdminPayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayments";
            this.Tag = "Payment";
            this.Text = "frmPayments";
            this.Load += new System.EventHandler(this.frmPayments_Load);
            this.PanelForfrmAdminPayments.ResumeLayout(false);
            this.PanelForfrmAdminPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdminInPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelForfrmAdminPayments;
        private Guna.UI2.WinForms.Guna2ComboBox CBForFIllter;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2HtmlLabel NumberOfRecords;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox TxtFiltterFor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView DgvAdminInPayments;
        private System.Windows.Forms.Label label1;
    }
}