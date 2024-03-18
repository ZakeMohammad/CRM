using CRM.Customer;
using System;
using System.Windows.Forms;

namespace CRM.Admin.Customers
{
    public partial class frmCustomerInfo : Form
    {
        public frmCustomerInfo(int customerId)
        {
            InitializeComponent();
            CustomerId = customerId;
        }

        int CustomerId;
        string CustomerName;
        private void frmCustomerInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonalInformation1.FillUserControlWithData(CustomerId);
            CustomerName=ctrlPersonalInformation1.Customer.Name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbllinkToOpenFomr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMainFormForCoustomer frm = new frmMainFormForCoustomer(CustomerName);
            this.Close();
            frm.Show();
            
        }

    }
}
