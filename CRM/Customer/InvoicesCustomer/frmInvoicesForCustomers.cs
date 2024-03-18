using CRM.Customer.InvoicesCustomer;
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
    public partial class frmInvoicesForCustomers : Form
    {
        public frmInvoicesForCustomers()
        {
            InitializeComponent();
        }

        DataTable AllInvoices;
        enum enInvoiceStatus { Unpaid = 1, Paid = 2, InProgress = 3 }

        void Refresh()
        {
            AllInvoices = clsCustomersInvoices.All(clsGlobal.CurrentCustomer.CustomerID);
            DgvInvoices.DataSource = AllInvoices;
        }


        private void frmInvoicesForCustomers_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrintInvoiceForCustomer frm = new frmPrintInvoiceForCustomer((int)DgvInvoices.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void payToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPayForCustomerInvoice frm = new frmPayForCustomerInvoice((int)DgvInvoices.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            clsCustomersInvoices invoice = clsCustomersInvoices.Find((int)DgvInvoices.CurrentRow.Cells[0].Value);

            if (invoice.StatusID!=(int)enInvoiceStatus.Unpaid)
                payToolStripMenuItem1.Enabled = false;
            else
                payToolStripMenuItem1.Enabled=true;


        }
    }
}
