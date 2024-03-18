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

namespace CRM.Customer
{
    public partial class ctrlInvoiceInfo : UserControl
    {
        public ctrlInvoiceInfo()
        {
            InitializeComponent();
          
        }


        public void FillDataToConrtol(int invoiceID)
        {
            clsCustomersInvoices Invoice = clsCustomersInvoices.Find(invoiceID);

            ctrlPersonalInformation1.FillUserControlWithData(Invoice.CustomerID);

            lblInvoiceID.Text=invoiceID.ToString();
            lblInvoce2.Text=invoiceID.ToString();
            lblAmmount.Text="$ " + Invoice.Amount.ToString();
            if (Invoice.StatusID == 1)
                lblStatus.Text = "Unpaid";
            else if (Invoice.StatusID == 2)
                lblStatus.Text = "Paid";
            else
                lblStatus.Text = "In Progress";


            lblInvoiceDate.Text = Invoice.InvoiceDate.ToShortDateString();
            lblDueDate.Text=Invoice.InvoiceDate.ToShortDateString();
            lblProductName.Text = Invoice.Order.Product.Name;
            lblPrice.Text = "$ " + Invoice.Order.Product.SalesPrice.ToString();
            lblQuantity.Text=Invoice.Order.Quantity.ToString();
            lblTotalPrice.Text = "$ "+Invoice.Amount.ToString();
            lblTotalPrice2.Text = "$ " + Invoice.Amount.ToString();
            lblTotalPrice3.Text = "$ " + Invoice.Amount.ToString();
        }


    }
}
