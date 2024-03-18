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

namespace CRM.Admin.Sales.Invoice
{
    public partial class frmPrintInvoiceForAdmins : Form
    {
        public frmPrintInvoiceForAdmins(int admininvoiceid)
        {
            InitializeComponent();
            AdminInvoice=clsAdminInvoices.Find(admininvoiceid);
            CustomerInvoice = clsCustomersInvoices.Find((int)AdminInvoice.InvoiceIDForCustomer);
        }

     

        clsAdminInvoices AdminInvoice;
        clsCustomersInvoices CustomerInvoice;


        void FillData()
        {
           lblAccountNumber.Text= CustomerInvoice.BankAccount.AccountNumber;
            lblInvoiceID.Text=AdminInvoice.InvoiceID.ToString();
            lblBankName.Text = CustomerInvoice.BankAccount.BankName;
            lblAccountName.Text = CustomerInvoice.BankAccount.Customer.Name;
           lblAmount.Text=AdminInvoice.Amount.ToString();
        }

        private void frmPrintInvoiceForAdmins_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            clsExport.ExportInvoicesAsPDF($"Admin Invoice Number {AdminInvoice.InvoiceID}", AdminInvoice, CustomerInvoice);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
