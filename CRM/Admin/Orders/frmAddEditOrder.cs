using CRM_BussinsLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CRM.Admin.Orders
{
    public partial class frmAddEditOrder : Form
    {
        public frmAddEditOrder()
        {
            InitializeComponent();

        }

        clsProducts Product;
        clsCustomers Customer;

        enum enIncreaseOrDecreseProduct { Increase=1,Decrease=2}

        void FillProducts()
        {
            CBProducts.Items.Clear();

            DataTable Products = clsGlobal.NamesOfProducts();

            foreach (DataRow Product in Products.Rows)
            {
                CBProducts.Items.Add(Product["Name"].ToString());
            }
        }
        void FillCustomers()
        {
            CBCustomers.Items.Clear();
          

            DataTable Customers = clsGlobal.NamesOfCustomers();

            foreach (DataRow row in Customers.Rows)
            {
                CBCustomers.Items.Add(row["Name"].ToString());
            }
        }
    

        void FillAllControlsBox()
        {
            
            FillProducts();
            FillCustomers();
        }

        private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmAddEditOrder_Load(object sender, EventArgs e)
        {
            FillAllControlsBox();
            CBCustomers.SelectedIndex = 0;
            CBProducts.SelectedIndex = 0;
            CBStatus.SelectedIndex = 0;
        }


        private void CBProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
           Product = clsProducts.Find(CBProducts.SelectedItem.ToString());
           TxtPrice.Text = Product.SalesPrice.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           clsOrders Order=new clsOrders();

            Order.CustomerID = Customer.CustomerID;
            Order.ProductID = Product.ProductID;
            Order.Quantity = Convert.ToInt32(NumbercOrderQuantity.Value);
            Order.Price = (Product.SalesPrice * Convert.ToInt32(NumbercOrderQuantity.Value));
            Order.StatusID=CBStatus.SelectedIndex+1;


            if(Product.IsProductSoludOut(Order.Quantity))
            {
                MessageBox.Show($"Order with Number of Product [ {Order.Quantity} ] Is More Than we have plese Decrase it..", "Orders", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (!Product.ChangeNumberOfProduct(Order.Quantity, (int)enIncreaseOrDecreseProduct.Decrease))
                return;

            if(Order.Save())
            {
                MessageBox.Show($"Order Succssfilly Added with ID [ {Order.OrderID} ]","Orders",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                //Form For Info
            }
            else
            {
                MessageBox.Show("Order Does not Added ", "Orders", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void CBCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
           Customer = clsCustomers.Find(CBCustomers.SelectedItem.ToString());
        }

        private void NumbercOrderQuantity_ValueChanged(object sender, EventArgs e)
        {
            TxtPrice.Text = Convert.ToString(Product.SalesPrice * Convert.ToInt32(NumbercOrderQuantity.Value));
        }


    }
}
