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
    public partial class frmPayForAdmins : Form
    {
        public frmPayForAdmins(int adminInvoiceID, int customerInvoiceID)
        {
            InitializeComponent();
            AdminInvoiceID = adminInvoiceID;
            CustomerInvoiceID = customerInvoiceID;
            CustomerInvoice = clsCustomersInvoices.Find(customerInvoiceID);
            AdminInvoices=clsAdminInvoices.Find(adminInvoiceID);
        }


        int AdminInvoiceID;
        int CustomerInvoiceID;

        clsCustomersInvoices CustomerInvoice;
        clsAdminInvoices AdminInvoices;

        enum enInvoiceStatus { Unpaid = 1, Paid = 2, InProgress = 3 }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPayForAdmins_Load(object sender, EventArgs e)
        {
            FillDataToForm();
            CBGategoryes.SelectedIndex = 0;
            CBMethods.SelectedIndex = 0;
          
           
        }

        void FillDataToForm()
        {
            FillComboBox();
            lblInvoiceID.Text = AdminInvoiceID.ToString();
            lblCustomerAccount.Text = CustomerInvoice.BankAccount.AccountNumber;
            TxtDate.Text = DateTime.Now.ToShortDateString();
            TxtDescriptoin.Text = $"This Payment for Customer for this ID [{CustomerInvoiceID}] ";
            TxtAmmount.Text = "$ " + CustomerInvoice.Amount;
            TxtCustomer.Text = CustomerInvoice.BankAccount.Customer.Name;
        }

        void FillPaymentMethods()
        {
            DataTable dt = clsGlobal.NamesOfPaymentMethods();

            foreach (DataRow row in dt.Rows)
            {
                CBMethods.Items.Add((string)row["MethodName"]);
            }
        }


        void FillPaymentGategory()
        {
            DataTable dt = clsGlobal.NamesOfPaymentGategory();

            foreach (DataRow row in dt.Rows)
            {
                CBGategoryes.Items.Add((string)row["Name"]);
            }
        }


        void FillComboBox()
        {
            CBGategoryes.Items.Clear();
            CBMethods.Items.Clear();
            FillPaymentGategory();
            FillPaymentMethods();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsAdminsPayments payment = new clsAdminsPayments();

            payment.InvoiceCustomerID = CustomerInvoiceID;
            payment.PayByAdminID = clsGlobal.CurrentAdmin.AdminID;
            payment.GategoryID = CBGategoryes.SelectedIndex + 1;
            payment.MethodID=CBMethods.SelectedIndex + 1;

          
            payment.InvoiceID = AdminInvoiceID;           
            payment.PaymentDate=DateTime.Now;
            payment.Description =TxtDescriptoin.Text;
            payment.Amount = CustomerInvoice.Amount;
            payment.Method= CBMethods.SelectedIndex + 1;

            if(payment.Save())
            {

                if (!CustomerInvoice.ChangeInviceStatus((int)enInvoiceStatus.Paid))
                    return;

                if (!AdminInvoices.ChangeInviceStatus((int)enInvoiceStatus.Paid))
                    return;

                if(!CustomerInvoice.BankAccount.Deposit(CustomerInvoice.Amount)) 
                    return;

                    MessageBox.Show($"Payment Added successfully ", "Payments", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show($"Payment Does Not Added...", "Payments", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            this.Close();
        }



    }
}
