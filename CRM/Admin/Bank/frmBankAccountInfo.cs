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

namespace CRM.Admin.Bank
{
    public partial class frmBankAccountInfo : Form
    {
        public frmBankAccountInfo(int accountid)
        {
            InitializeComponent();
            AccountID = accountid;
        }

        int AccountID;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBankAccountInfo_Load(object sender, EventArgs e)
        {
            clsBanksAccount Account = clsBanksAccount.Find(AccountID);

            if (Account != null)
            {
                ctrlBankAccountInfo1.FillControlWithData(AccountID);
                ctrlPersonalInformation1.FillUserControlWithData(Account.CustomerID);
            }
        }
    }
}
