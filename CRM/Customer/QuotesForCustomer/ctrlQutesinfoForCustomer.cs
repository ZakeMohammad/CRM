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

namespace CRM.Customer.QuotesForCustomer
{
    public partial class ctrlQutesinfoForCustomer : UserControl
    {
        public ctrlQutesinfoForCustomer()
        {
            InitializeComponent();
        }

        enum enQuotesStatus { InProgress = 1, Accepted = 2, Rejection = 3 }


        int QuoteID;

        float TotalPriceForOrder = 0;

        bool DesapelAcceptedButton {  get; set; }


        public event Action<bool> OnQuoteDelete;

        protected virtual void QuoteCaneld(bool Ruslt)
        {
            Action<bool> Handler = OnQuoteDelete;

            if (Handler != null)
            {
                Handler(Ruslt);
            }
        }

        float CalculateTotalPriceForQutete(float SubTotal, float tax, float disacount)
        {
            float result = 0;

            result = SubTotal + tax;

            result = result - disacount;

            return result;
        }


        public void FillDataToControl(int QueteID,int CustomerID)
        {
            QuoteID = QueteID;
            clsQuotes Quotes = clsQuotes.Find(QueteID,CustomerID);

            clsProducts Product = clsProducts.Find(Quotes.ProductID);

            lblQuetosID.Text = "Quotes # " + QueteID.ToString();


            lblProductName.Text = Product.Name+$" x{Quotes.ProductQuantity}";

            lblOrginalPrice.Text = (Product.SalesPrice * Quotes.ProductQuantity).ToString() + " $";

            if (Quotes.QuotesStatusID == (int)enQuotesStatus.InProgress)
                lblStatus.Text = "In Progress";
            if (Quotes.QuotesStatusID == (int)enQuotesStatus.Accepted)
                lblStatus.Text = "Accepted";
            if (Quotes.QuotesStatusID == (int)enQuotesStatus.Rejection)
                lblStatus.Text = "Rejection";

            TotalPriceForOrder = CalculateTotalPriceForQutete((Product.SalesPrice * Quotes.ProductQuantity), Quotes.Tax, (float)Quotes.Discount);

           lblTotalPriceForQuete.Text = Convert.ToString(TotalPriceForOrder) + " $";
           
        }


        private void ctrlQutesinfoForCustomer_Load(object sender, EventArgs e)
        {
            if(DesapelAcceptedButton)
                btnAccepted.Enabled = false;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (clsQuotes.Delete(QuoteID))
                QuoteCaneld(true);
            else
                QuoteCaneld(false);
        }

        private void btnAccepted_Click_1(object sender, EventArgs e)
        {
            clsQuotes Quotes = clsQuotes.Find(QuoteID);

            clsOrders Order = new clsOrders();

            Order.CustomerID = Quotes.CustomerID;
            Order.ProductID = Quotes.ProductID;
            Order.Quantity = Quotes.ProductQuantity;
            Order.Price = TotalPriceForOrder;
            Order.StatusID = 1;//This For order status Panding

            if (Order.Save())
            {
                if (clsQuotes.Delete(QuoteID))
                    QuoteCaneld(true);
                else
                    QuoteCaneld(false);
                return;
            }
        }
    }
}
