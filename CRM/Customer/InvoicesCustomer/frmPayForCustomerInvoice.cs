using CRM_BussinsLayer;
using iTextSharp.text.pdf.qrcode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Customer.InvoicesCustomer
{
    public partial class frmPayForCustomerInvoice : Form
    {
        public frmPayForCustomerInvoice(int invoiceID)
        {
            InitializeComponent();
            InvoiceID = invoiceID;
            Invoice = clsCustomersInvoices.Find(InvoiceID);
        }

        int InvoiceID;

        clsCustomersInvoices Invoice;


        enum enInvoiceStatus { Unpaid=1,Paid=2,InProgress=3 }

        void FillComboBox()
        {
            DataTable dt = clsGlobal.NamesOfPaymentMethods();

            foreach (DataRow row in dt.Rows)
            {
                CBPaymentsMethods.Items.Add((string)row["MethodName"]);
            }
        }

        private void frmPayForCustomerInvoice_Load(object sender, EventArgs e)
        {
            FillComboBox();
            CBPaymentsMethods.SelectedIndex = 0;
            ctrlOrderCard1.FillDataToControl(Invoice.OrderID);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsCustomersPayments payment = new clsCustomersPayments();

           
           
            payment.InvoiceID = InvoiceID;
            payment.PaymentDate= DateTime.Now;
            payment.Amount = Invoice.Amount;
            payment.Method = CBPaymentsMethods.SelectedIndex + 1;
          
            if (TxtDescription.Text.Length == 0)
                payment.Description = null;
            else
                payment.Description = TxtDescription.Text;

            if(payment.Save())
            {

                if (!Invoice.ChangeInviceStatus((int)enInvoiceStatus.InProgress))
                    return;
                
                clsAdminInvoices AdminInvoices = new clsAdminInvoices();

                AdminInvoices.CustomerID = Invoice.CustomerID;
                AdminInvoices.OrderID=Invoice.OrderID;
                AdminInvoices.StatusID = (int)enInvoiceStatus.Unpaid;
                AdminInvoices.InvoiceDate = DateTime.Now;
                AdminInvoices.Amount = Invoice.Amount;
                AdminInvoices.Tax = null;
                AdminInvoices.InvoiceIDForCustomer= InvoiceID;

                if(AdminInvoices.Save()) {
                    MessageBox.Show($"Payment Added successfully ", "Payments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"Payment Does Not Added...", "Payments", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }              
            else
                MessageBox.Show($"Payment Does Not Added...", "Payments", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            this.Close();
        }

        private void CBPaymentsMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
