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
    public partial class frmProductInfo : Form
    {
        public frmProductInfo(int productid)
        {
            InitializeComponent();
            ProductID = productid;
        }

        int ProductID;

        private void frmProductInfo_Load(object sender, EventArgs e)
        {
            clsProducts Product = clsProducts.Find(ProductID);

            lblProductID.Text="# "+ProductID.ToString();
            lblProductName.Text = Product.Name;
            lblPrice.Text=Product.SalesPrice.ToString()+" $";
            lblNumberOfProduct.Text = Product.NumberOfProduct.ToString();
            lblGategory.Text= clsGlobal.GitGategoryNameForProduct(Product.GategoryID);

            if (Product.Description == "")
                TxtDescription.Text = "No Description";
            else
                TxtDescription.Text = Product.Description;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
