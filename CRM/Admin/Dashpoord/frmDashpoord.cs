using System;
using System.Windows.Forms;

namespace CRM
{
    public partial class frmDashpoord : Form
    {
        public frmDashpoord()
        {
            InitializeComponent();
        }

        private void frmDashpoord_Load(object sender, EventArgs e)
        {
            lblNumberOfCustomers.Text=clsGlobal.GitNumberOfAllCustomers().ToString();
            lblNumberOfAdmins.Text = clsGlobal.GitNumberOfAllAdmins().ToString();
            lblBankAccounts.Text = clsGlobal.GitNumberOfAllBankAccounts().ToString();
            lblNumberOfCompanies.Text = clsGlobal.GitNumberOfAllCompanies().ToString();
            lblNumberOfOrders.Text = clsGlobal.GitNumberOfAllOrders().ToString();
            lblNumberOfProducts.Text = clsGlobal.GitNumberOfAllProducts().ToString();
            lblNumberOfPayments.Text = clsGlobal.GitNumberOfAllPayments().ToString();
            lblNumberOfQuete.Text = clsGlobal.GitNumberOfAllQuotes().ToString();
        }
    }
}
