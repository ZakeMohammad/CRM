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

namespace CRM.Admin.Transactions
{
    public partial class frmAddEditTransaction : Form
    {
        public frmAddEditTransaction()
        {
            InitializeComponent();
        }

        clsBanksAccount AccountToTransfareFrom;

        clsBanksAccount AccoutnToTransfareTo;

        private void TxtAmmount_TextChanged(object sender, EventArgs e)
        {
            btnTransfare.Enabled=(TxtAmmount.Text.Length>0);
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
            if (obj != null)
            {
                AccountToTransfareFrom = obj;
                lblTransfareFrom.Text = AccountToTransfareFrom.AccountNumber;
                lblTransfareFrom.ForeColor = Color.Red;
            }
                
            else
                return;
                
        }

        private void ctrlBankAccountWithFillter2_OnBankExist(CRM_BussinsLayer.clsBanksAccount obj)
        {
            if (obj == null)
                btnTransfare.Enabled = false;
            else
            {
                AccoutnToTransfareTo = obj;
                lblTransfareTo.Text = AccoutnToTransfareTo.AccountNumber;
                lblTransfareTo.ForeColor = Color.Green;
                btnTransfare.Enabled = true;
            }
                
        }

        private void btnTransfare_Click(object sender, EventArgs e)
        {
            if (TxtAmmount.Text == string.Empty || Convert.ToSingle(TxtAmmount.Text) < 0)
            {
                MessageBox.Show("Plese Enter Ammount To Expense it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

           if (AccountToTransfareFrom.Transfare(AccoutnToTransfareTo.AccountNumber,Convert.ToSingle(TxtAmmount.Text)))
           {
                int NewTransaction = clsBanksAccount.AddTransaction(DateTime.Now, AccountToTransfareFrom.AccountNumber, AccoutnToTransfareTo.AccountNumber, Convert.ToSingle(TxtAmmount.Text), AccountToTransfareFrom.InitialBalance, AccoutnToTransfareTo.InitialBalance);
                if (NewTransaction != 0)
                {
                    MessageBox.Show($"Transfare Succssfilly Done From Accoutn {AccountToTransfareFrom.AccountNumber} To {AccoutnToTransfareTo.AccountNumber}", "Bank", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }  
           }
           else
                MessageBox.Show("Transfare Does Not Done", "Bank", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

           this.Close();
            return;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
