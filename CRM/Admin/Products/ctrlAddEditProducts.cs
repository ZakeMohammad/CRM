using CRM_BussinsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Admin.Products
{
    public partial class ctrlAddEditProducts : UserControl
    {
        public ctrlAddEditProducts()
        {
            InitializeComponent();
        }

        public event Action<bool> IsProductAddOrUpdate;


        protected virtual void ProductAddOrEdit(bool AddOrEdit)
        {
            Action<bool> Handler = IsProductAddOrUpdate;

            if (Handler != null)
            {
                Handler(AddOrEdit);
            }
        }

        enum enMode { Add, Update }
        enMode Mode = enMode.Add;

        public int ID;
        clsProducts _Product;


        enum enIncreaseOrDecreseProduct { Increase = 1, Decrease = 2 }

        void DisapleSaveButton()
        {
            btnSave.Enabled = false;
        }

        public void EnableSaveButton()
        {
            btnSave.Enabled = true;
        }


        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            if (TxtName.Text == string.Empty)
            {
                e.Cancel = true;
                TxtName.Focus();
                errorProvider1.SetError(TxtName, "Plese Enter Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtName, "");
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (TxtName.Text == string.Empty)
                DisapleSaveButton();
            else
                EnableSaveButton();
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }


        public void FillForUpdate(int id)
        {
           clsProducts Product=clsProducts.Find(id);

            lblForWhat.Text = "Update Product";
            TxtName.Text = Product.Name;
            TxtDescription.Text = (Product.Description == "") ? "" : Product.Description;
            TxtSelasPrice.Text = Convert.ToString(Product.SalesPrice);
            NumericNumberOfProducts.Value = Product.NumberOfProduct;
            CBGategorys.SelectedIndex = Product.GategoryID;
            _Product=Product;
            ID = id;
            Mode = enMode.Update;
        }

        void GitAllGategorys()
        {
            CBGategorys.Items.Clear();
            CBGategorys.Items.Add("None");
            DataTable dt = clsProductsGategory.All();

            foreach(DataRow dr in dt.Rows)
            {
                CBGategorys.Items.Add(dr["GategoryName"].ToString());
            }
        }

        void Update()
        {
            _Product.Name = TxtName.Text;
            _Product.Description = TxtDescription.Text;
           _Product.SalesPrice=Convert.ToSingle(TxtSelasPrice.Text);
            _Product.NumberOfProduct = Convert.ToInt32(NumericNumberOfProducts.Value);
            _Product.GategoryID=CBGategorys.SelectedIndex;
        }

        private void ctrlAddEditProducts_Load(object sender, EventArgs e)
        {
            Resat();
        }
        public  void Resat()
        {
            lblForWhat.Text = "Add Product";

            TxtName.Text = string.Empty;
            TxtSelasPrice.Text= string.Empty;
            TxtDescription.Text = string.Empty;
            NumericNumberOfProducts.Value = 1;
            CBGategorys.SelectedIndex = 0;
            lblNumberOfProduct.Visible = false;
            CBGategorys.SelectedIndex = 0;
            Mode = enMode.Add;
            GitAllGategorys();
            DisapleSaveButton();
        }

        private void NumericNumberOfProducts_ValueChanged(object sender, EventArgs e)
        {
            if(NumericNumberOfProducts.Value==0)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;


            lblNumberOfProduct.Visible=true;
            lblNumberOfProduct.Text=NumericNumberOfProducts.Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!(this.ValidateChildren()))
                return;

            if (Mode == enMode.Add)
            {
                clsProducts Product= new clsProducts();

                Product.Name = TxtName.Text;
                Product.Description = TxtDescription.Text;
                Product.SalesPrice=Convert.ToSingle(TxtSelasPrice.Text);
                Product.NumberOfProduct=Convert.ToInt32(NumericNumberOfProducts.Value);
                Product.GategoryID=CBGategorys.SelectedIndex;

                

                if (Product.Save())
                {
                    MessageBox.Show($"Product Added Succssfilly With ID {Product.ProductID}", "Products", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    ProductAddOrEdit(true);
                }
                else
                    MessageBox.Show($"Product Does Not Added", "Products", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                Update();

                if (_Product.Save())
                {

                    MessageBox.Show($"Product Updated Succssfilly With ID {_Product.ProductID}", "Products", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    ProductAddOrEdit(true);
                }

                else
                    MessageBox.Show($"Product Does Not Updated", "Products", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            TxtDescription.Focus();
            Resat();
            return;


        }

        private void TxtSelasPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtSelasPrice_Validating(object sender, CancelEventArgs e)
        {
            if (TxtSelasPrice.Text==string.Empty||Convert.ToInt32(TxtSelasPrice.Text)<1)
            {
                e.Cancel = true;
                TxtSelasPrice.Focus();
                errorProvider1.SetError(TxtSelasPrice, "Minnuimim Price For Any Product is 1 $");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtSelasPrice, "");
            }
        }

        private void CBGategorys_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled=(CBGategorys.SelectedIndex!=0);
        }

        private void LinkToAddNewProductGategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditProductGategory frm=new frmAddEditProductGategory();
            frm.ShowDialog();          
            GitAllGategorys();
        }

    }
}
