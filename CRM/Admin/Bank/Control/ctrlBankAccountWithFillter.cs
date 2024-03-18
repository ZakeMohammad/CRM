using CRM.Admin.Customers;
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

namespace CRM.Admin.Bank.Control
{
    public partial class ctrlBankAccountWithFillter : UserControl
    {
        public ctrlBankAccountWithFillter()
        {
            InitializeComponent();
        }
        public clsBanksAccount Account;

        public event Action<clsBanksAccount> OnBankExist;

        protected virtual void BankAccountFound(clsBanksAccount Account)
        {
            Action<clsBanksAccount> Handler = OnBankExist;

            if (Handler != null)
            {
                Handler(Account);
            }
        }

  
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (clsBanksAccount.IsBanksAccountExist(TxtSearchByAccountNumber.Text))
            {
                ctrlBankAccountInfo1.FillControlWithData((TxtSearchByAccountNumber.Text));
                Account = ctrlBankAccountInfo1.Account;
                BankAccountFound(Account);
                return;
            }
            else
                MessageBox.Show($"Bank Account Wiht Number {TxtSearchByAccountNumber.Text} Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            BankAccountFound(null);
            ctrlBankAccountInfo1.Restart();
        }


    }
}
