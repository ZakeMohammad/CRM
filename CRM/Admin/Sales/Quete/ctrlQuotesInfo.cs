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
    public partial class ctrlQuotesInfo : UserControl
    {
        public ctrlQuotesInfo()
        {
            InitializeComponent();
        }

        enum enQuotesStatus { InProgress = 1, Accepted = 2, Rejection = 3 }

        int QuoteID;

        public event Action<bool> OnQuoteDelete;

        protected virtual void QuoteCaneld(bool Ruslt)
        {
            Action<bool> Handler = OnQuoteDelete;

            if (Handler != null)
            {
                Handler(Ruslt);
            }
        }

        float CalculateTotalPriceForQutete(float SubTotal,float tax,float disacount)
        {
            float result = 0;

            result = SubTotal + tax;

            result = result - disacount;

            return result;
        }

        public void FillDataToControl(int QueteID)
        {
            QuoteID= QueteID;
            clsQuotes Quotes = clsQuotes.Find(QueteID);

            clsProducts Product = clsProducts.Find(Quotes.ProductID);

            lblQuetosID.Text ="Quotes # "+ QueteID.ToString();
            lblProductName.Text=Product.Name;
            lblCustomerName.Text=clsCustomers.Find(Quotes.CustomerID).Name;

            if (Quotes.QuotesStatusID == (int)enQuotesStatus.InProgress)
                lblStatus.Text = "In Progress";
            if (Quotes.QuotesStatusID == (int)enQuotesStatus.Accepted)
                lblStatus.Text = "Accepted";
            if (Quotes.QuotesStatusID == (int)enQuotesStatus.Rejection)
                lblStatus.Text = "Rejection";

            lblProductAndQunitityPrice.Text = (Product.SalesPrice * Quotes.ProductQuantity).ToString()+" $";
            lblDesactount.Text=Quotes.Discount.ToString()+" $";
            lblTax.Text=Quotes.Tax.ToString()+" $";
            lblTotalPriceForQuete.Text=Convert.ToString(CalculateTotalPriceForQutete((Product.SalesPrice * Quotes.ProductQuantity),Quotes.Tax, (float)Quotes.Discount))+" $";
        }

        private void ctrlQuotesInfo_Load(object sender, EventArgs e)
        {
          
        }

        private void btnShowQuete_Click(object sender, EventArgs e)
        {
            frmQuotesInfo frm = new frmQuotesInfo(QuoteID);
            frm.ShowDialog();
        }

        private void btnDeleteQuete_Click(object sender, EventArgs e)
        {
            if (clsQuotes.Delete(QuoteID))
                QuoteCaneld(true);
            else
                QuoteCaneld(false);

        }


    }
}
