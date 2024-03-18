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
    public partial class ctrlBankAccountInfo : UserControl
    {
        public ctrlBankAccountInfo()
        {
            InitializeComponent();
        }

        string AccountNumber;
        int AccountID;
        clsBanksAccount _Account;
        public clsBanksAccount Account;
        public void FillControlWithData(int accoutnid)
        {
            _Account = clsBanksAccount.Find(accoutnid);

            if(_Account != null)
            {
                lblAccountIDAndCustomerName.Text = $"# {_Account.AccountID} {_Account.Customer.Name}";
                lblAccountNumber.Text=_Account.AccountNumber;
                lblBalance.Text = _Account.InitialBalance.ToString() + " $";
                lblBalance.ForeColor = Color.Green;
                lblBankName.Text = _Account.BankName;
                if (_Account.Description != "")
                    lblDescription.Text = _Account.Description;
                else
                    lblDescription.Text = "No Description";

                TxtURL.Text = _Account.BankURL;
                AccountNumber = _Account.AccountNumber;
                AccountID = _Account.AccountID;
                Account = _Account;
            }
        }

        public void FillControlWithData(string accoutnnumber)
        {
            _Account = clsBanksAccount.Find(accoutnnumber);

            if (_Account != null)
            {
                lblAccountIDAndCustomerName.Text = $"# {_Account.AccountID} {_Account.Customer.Name}";
                lblAccountNumber.Text = _Account.AccountNumber;
                lblBalance.Text = _Account.InitialBalance.ToString() + "$";
                lblBalance.ForeColor = Color.Green;
                lblBankName.Text = _Account.BankName;
                if (_Account.Description != "")
                    lblDescription.Text = _Account.Description;
                else
                    lblDescription.Text = "No Description";

                TxtURL.Text = _Account.BankURL;
                AccountNumber = _Account.AccountNumber;
                AccountID = _Account.AccountID;
                Account = _Account;
            }
        }


        public void Restart()
        {
            lblAccountIDAndCustomerName.Text = "[???]";
            lblAccountNumber.Text = "[???]";
            lblBalance.Text = "[???]";
            lblBankName.Text= "[???]";
            lblDescription.Text= "[???]";
            TxtURL.Text = string.Empty;
        }

    }
}
