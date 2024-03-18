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

namespace CRM.Admin.Sales.Quete
{
    public partial class frmAddEditQuete : Form
    {
        public frmAddEditQuete()
        {
            InitializeComponent();
        }

        enum enIncreaseOrDecreseProduct { Increase = 1, Decrease = 2 }
        enum enQuotesStatus { InProgress = 1, Accepted = 2, Rejection = 3 }


        clsProducts _Product;

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectTab(1);
        }

       

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

        private void frmAddEditQuete_Load(object sender, EventArgs e)
        {
            BasicInfo();
            FillAllControlsBox();
        }

        void BasicInfo()
        {
            RDAmmount.Checked = true;
            PDExpiryDate.Value=DateTime.Now.AddDays(1);
            lblTax.Text = "0 %";
            lblDiscount.Text = "0";
        }

        private void CBCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtAddress.Text = clsCustomers.Find(CBCustomers.SelectedItem.ToString()).Adrress;
        }

        private void CBProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtProposalText.Text = $"This Is our quotation for {CBProducts.SelectedItem} Product";
        }

        private void NumbercForPercent_ValueChanged(object sender, EventArgs e)
        {
            if(RDAmmount.Checked)
                lblDiscount.Text = $"{NumbercForDiscount.Value} $";
            else
                lblDiscount.Text = $"{NumbercForDiscount.Value} %";

        }

        private void NumbercForTax_ValueChanged(object sender, EventArgs e)
        {
            lblTax.Text = $"{NumbercForTax.Value} %";
        }


        float CalculateTax(float Tax, float ProductsPrice)
        {
            return ((Tax / 100) * ProductsPrice); 
        }

        float ClaculateDisacount(float disacount, float ProductsPrice)
        {
            if(RDAmmount.Checked)
                return disacount;         
           if(RDpercent.Checked)        
                return ((disacount / 100) * ProductsPrice);
           else
                return 0;
        }

       

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            clsQuotes quotes = new clsQuotes();

            quotes.CustomerID = clsCustomers.Find(CBCustomers.SelectedItem.ToString()).CustomerID;
            quotes.CreateDate = DPCreateDate.Value;
            quotes.ExpirDate = PDExpiryDate.Value;
            quotes.Subject=TxtSubject.Text;
            quotes.ProposalText=TxtProposalText.Text;

            quotes.ProductID = clsProducts.Find(CBProducts.SelectedItem.ToString()).ProductID;
            quotes.Product = clsProducts.Find(quotes.ProductID);

            quotes.ProductQuantity = (int)NumbercForProductQuanitity.Value;

            quotes.Tax = CalculateTax((float)NumbercForTax.Value, (quotes.Product.SalesPrice * quotes.ProductQuantity));
            quotes.Discount = ClaculateDisacount((float)NumbercForDiscount.Value, (quotes.Product.SalesPrice * quotes.ProductQuantity));

            quotes.QuotesStatusID = (int)enQuotesStatus.InProgress;
            quotes.Notes=TxtCustomerNotes.Text;


            if (quotes.Product.IsProductSoludOut(quotes.ProductQuantity))
            {
                MessageBox.Show($"Quote with Number of Product [ {quotes.ProductQuantity} ] Is More Than we have plese Decrase it..", "Quote", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (!quotes.Product.ChangeNumberOfProduct(quotes.ProductQuantity, (int)enIncreaseOrDecreseProduct.Decrease))
                return;

            if (quotes.Save())
                MessageBox.Show("Quotes Succssfilly Sent To Customer.","Quotes",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else
                MessageBox.Show("Quotes Does Not Sent To Customer.", "Quotes", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            this.Close();
        }

        private void CBProducts_Validating(object sender, CancelEventArgs e)
        {
            if(CBProducts.SelectedIndex<0)
            {
                e.Cancel = true;
                errorProvider1.SetError(CBProducts, "Plese Choose Product");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(CBProducts, "");
            }

        }

        private void CBCustomers_Validating(object sender, CancelEventArgs e)
        {
            if (CBCustomers.SelectedIndex < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(CBCustomers, "Plese Choose Customer");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(CBCustomers, "");
            }
        }


    }
}
