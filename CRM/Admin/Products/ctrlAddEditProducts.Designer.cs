namespace CRM.Admin.Products
{
    partial class ctrlAddEditProducts
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
            this.TxtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblForWhat = new System.Windows.Forms.Label();
            this.TxtSelasPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericNumberOfProducts = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblNumberOfProduct = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.CBGategorys = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LinkToAddNewProductGategory = new System.Windows.Forms.LinkLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericNumberOfProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.TxtDescription.Location = new System.Drawing.Point(34, 514);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.PasswordChar = '\0';
            this.TxtDescription.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.TxtName.Location = new System.Drawing.Point(34, 103);
            this.TxtName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.lblForWhat.Size = new System.Drawing.Size(224, 42);
            this.lblForWhat.TabIndex = 31;
            this.lblForWhat.Text = "Add Product";
            // 
            // TxtSelasPrice
            // 
            this.TxtSelasPrice.BorderColor = System.Drawing.Color.Teal;
            this.TxtSelasPrice.BorderRadius = 5;
            this.TxtSelasPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSelasPrice.DefaultText = "";
            this.TxtSelasPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSelasPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSelasPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSelasPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSelasPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSelasPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSelasPrice.ForeColor = System.Drawing.Color.Black;
            this.TxtSelasPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSelasPrice.Location = new System.Drawing.Point(36, 209);
            this.TxtSelasPrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtSelasPrice.Name = "TxtSelasPrice";
            this.TxtSelasPrice.PasswordChar = '\0';
            this.TxtSelasPrice.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtSelasPrice.PlaceholderText = "Price";
            this.TxtSelasPrice.SelectedText = "";
            this.TxtSelasPrice.Size = new System.Drawing.Size(574, 35);
            this.TxtSelasPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtSelasPrice.TabIndex = 37;
            this.TxtSelasPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSelasPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSelasPrice_KeyPress);
            this.TxtSelasPrice.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSelasPrice_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Number Of Product :";
            // 
            // NumericNumberOfProducts
            // 
            this.NumericNumberOfProducts.BackColor = System.Drawing.Color.Transparent;
            this.NumericNumberOfProducts.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericNumberOfProducts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericNumberOfProducts.Location = new System.Drawing.Point(269, 317);
            this.NumericNumberOfProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumericNumberOfProducts.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericNumberOfProducts.Name = "NumericNumberOfProducts";
            this.NumericNumberOfProducts.Size = new System.Drawing.Size(214, 43);
            this.NumericNumberOfProducts.TabIndex = 39;
            this.NumericNumberOfProducts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericNumberOfProducts.ValueChanged += new System.EventHandler(this.NumericNumberOfProducts_ValueChanged);
            // 
            // lblNumberOfProduct
            // 
            this.lblNumberOfProduct.AutoSize = true;
            this.lblNumberOfProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfProduct.Location = new System.Drawing.Point(520, 322);
            this.lblNumberOfProduct.Name = "lblNumberOfProduct";
            this.lblNumberOfProduct.Size = new System.Drawing.Size(26, 29);
            this.lblNumberOfProduct.TabIndex = 40;
            this.lblNumberOfProduct.Text = "0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Gategory :";
            // 
            // CBGategorys
            // 
            this.CBGategorys.BackColor = System.Drawing.Color.Transparent;
            this.CBGategorys.BorderRadius = 12;
            this.CBGategorys.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBGategorys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGategorys.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBGategorys.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBGategorys.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBGategorys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBGategorys.ItemHeight = 30;
            this.CBGategorys.Items.AddRange(new object[] {
            "None"});
            this.CBGategorys.Location = new System.Drawing.Point(151, 429);
            this.CBGategorys.Name = "CBGategorys";
            this.CBGategorys.Size = new System.Drawing.Size(345, 36);
            this.CBGategorys.TabIndex = 42;
            this.CBGategorys.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CBGategorys.SelectedIndexChanged += new System.EventHandler(this.CBGategorys_SelectedIndexChanged);
            // 
            // LinkToAddNewProductGategory
            // 
            this.LinkToAddNewProductGategory.AutoSize = true;
            this.LinkToAddNewProductGategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkToAddNewProductGategory.Location = new System.Drawing.Point(502, 437);
            this.LinkToAddNewProductGategory.Name = "LinkToAddNewProductGategory";
            this.LinkToAddNewProductGategory.Size = new System.Drawing.Size(106, 18);
            this.LinkToAddNewProductGategory.TabIndex = 43;
            this.LinkToAddNewProductGategory.TabStop = true;
            this.LinkToAddNewProductGategory.Text = "Add Gategory?";
            this.LinkToAddNewProductGategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToAddNewProductGategory_LinkClicked);
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
            this.btnSave.Location = new System.Drawing.Point(256, 584);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 41);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlAddEditProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LinkToAddNewProductGategory);
            this.Controls.Add(this.CBGategorys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumberOfProduct);
            this.Controls.Add(this.NumericNumberOfProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSelasPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.lblForWhat);
            this.Name = "ctrlAddEditProducts";
            this.Size = new System.Drawing.Size(646, 663);
            this.Load += new System.EventHandler(this.ctrlAddEditProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericNumberOfProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox TxtDescription;
        private Guna.UI2.WinForms.Guna2TextBox TxtName;
        private System.Windows.Forms.Label lblForWhat;
        private Guna.UI2.WinForms.Guna2TextBox TxtSelasPrice;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericNumberOfProducts;
        private System.Windows.Forms.Label lblNumberOfProduct;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ComboBox CBGategorys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LinkToAddNewProductGategory;
    }
}
