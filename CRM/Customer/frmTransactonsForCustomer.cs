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
    public partial class frmTransactonsForCustomer : Form
    {
        public frmTransactonsForCustomer()
        {
            InitializeComponent();
        }


        DataTable AllTransactionsForThisCustomer;
        void Refresh()
        {

            clsBanksAccount BankAccount = clsBanksAccount.Find(clsGlobal.CurrentCustomer.CustomerID, true);

            AllTransactionsForThisCustomer = clsBanksAccount.AllTransactionsForThisAccount(BankAccount.AccountNumber);
            DgvTransactions.DataSource = AllTransactionsForThisCustomer;
        }

        private void frmTransactonsForCustomer_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
