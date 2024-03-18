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
    public partial class frmPrintInvoiceForCustomer : Form
    {
        public frmPrintInvoiceForCustomer(int invoiceID)
        {
            InitializeComponent();
            InvoiceID = invoiceID;
        }
        int InvoiceID;
        private void frmPrintInvoiceForCustomer_Load(object sender, EventArgs e)
        {
            ctrlInvoiceInfo1.FillDataToConrtol(InvoiceID);
        }
    }
}
