using CRM.Customer.QuotesForCustomer;
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
    public partial class frmQuotesInfo : Form
    {
        public frmQuotesInfo(int quotesID)
        {
            InitializeComponent();
            QuotesID = quotesID;
        }

        int QuotesID;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        float CalculateTotalPriceForQutete(float SubTotal, float tax, float disacount)
        {
            float result = 0;

            result = SubTotal + tax;

            result = result - disacount;

            return result;
        }
        void FillData()
        {
            clsQuotes Quote = clsQuotes.Find(QuotesID);

            lblQuoteID.Text = QuotesID.ToString();
            lblCustomerName.Text = Quote.Customer.Name;
            lblProductName.Text = Quote.Product.Name;
            lblProductQuantity.Text = Quote.ProductQuantity.ToString();
            lblCreateDate.Text=Quote.CreateDate.ToShortDateString();
            lblExpiryDate.Text=Quote.ExpirDate.ToShortDateString();
            lblOrginalPrice.Text = (Quote.Product.SalesPrice * Quote.ProductQuantity).ToString()+" $";
            lblNewPrice.Text= CalculateTotalPriceForQutete((Quote.Product.SalesPrice * Quote.ProductQuantity), Quote.Tax, (float)Quote.Discount).ToString()+" $";

        }

        private void frmQuotesInfo_Load(object sender, EventArgs e)
        {
            FillData();
        }


    }
}
