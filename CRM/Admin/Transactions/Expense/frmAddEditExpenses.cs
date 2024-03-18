using CRM_BussinsLayer;
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

namespace CRM.Admin.Transactions
{
    public partial class frmAddEditExpenses : Form
    {
        public frmAddEditExpenses()
        {
            InitializeComponent();
        }

        clsBanksAccount Account;

        private void btnAddAmmount_Click(object sender, EventArgs e)
        {
            if (TxtAmmount.Text == string.Empty || Convert.ToSingle(TxtAmmount.Text) < 0)
            {
                MessageBox.Show("Plese Enter Ammount To Expense it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Account = ctrlBankAccountWithFillter1.Account;

            if (Account.Expense(Convert.ToSingle(TxtAmmount.Text)))
                MessageBox.Show($"Expense To Account {Account.AccountNumber} Sucssfilly Done", "Bank", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Expense To Account {Account.AccountNumber} Falid", "Bank", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            this.Close();
            return;
        }

        private void TxtAmmount_TextChanged(object sender, EventArgs e)
        {
            if (TxtAmmount.Text == string.Empty)
                btnAddAmmount.Enabled = false;
        }

        private void TxtAmmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ctrlBankAccountWithFillter1_OnBankExist(CRM_BussinsLayer.clsBanksAccount obj)
        {
            if (obj == null)
                btnAddAmmount.Enabled = false;
            else
                btnAddAmmount.Enabled = true;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
