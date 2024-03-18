using CRM_BussinsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CRM.Admin.Bank
{
    public partial class frmAddEditAccount : Form
    {
        public frmAddEditAccount()
        {
            InitializeComponent();
            Mode = enMode.Add;
        }
        public frmAddEditAccount(int accountid)
        {
            InitializeComponent();
            AccountID=accountid;
            Mode = enMode.Update;
        }


        public delegate void DataBackEvent(object o, bool IsAddedOrUpdatee);

        public event DataBackEvent DataBack;

        public enum enMode { Add, Update }

        public enMode Mode = enMode.Add;

        int AccountID;
        clsBanksAccount _Account;

        void FillComboBoxForCustomers()
        {
            DataTable dtCustomers = clsCustomers.All();

            foreach (DataRow Row in dtCustomers.Rows)
            {
                CBCustomers.Items.Add(Row["Name"]);
            }
        }

        void BasicInfoForForm()
        {
            FillComboBoxForCustomers();
           
        }


        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditAccount_Load(object sender, EventArgs e)
        {
            BasicInfoForForm();

            if (Mode == enMode.Update)
            {
                clsBanksAccount Account = clsBanksAccount.Find(AccountID);
              
                TxtAccountNumber.Text = Account.AccountNumber;
                CBCustomers.SelectedItem = Account.Customer.Name;
                TxtBalance.Text=Account.InitialBalance.ToString();
                TxtBankName.Text = Account.BankName;
                TxtURL.Text = Account.BankURL;
                TxtPassword.Text = Account.Password;
                TxtConfirmPassword.Text = Account.Password;
                _Account=Account;
                if (Account.Description == null)
                    TxtDescription.Text = "";
                else
                TxtDescription.Text = Account.Description;

                CBCustomers.Enabled = false;
                TxtAccountNumber.Enabled = false;
            }
        }
        private void UpdateAccount()
        {
            _Account.InitialBalance=Convert.ToSingle(TxtBalance.Text);
            _Account.BankName=TxtBankName.Text;
            _Account.BankURL=TxtURL.Text;
            _Account.Password=TxtPassword.Text;
            _Account.Description=TxtDescription.Text;
        }

        private void TxtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (Mode == enMode.Update)
            {
                e.Cancel = false;
                return;
            }

           if (clsBanksAccount.IsBanksAccountExist(TxtAccountNumber.Text))
           {
                e.Cancel = true;
                errorProvider1.SetError(TxtAccountNumber, "Plese Enter Another Account Number This Already Exist");
           }
           else
           {
                e.Cancel = false;
                errorProvider1.SetError(TxtAccountNumber, "");

           }
        }

        private void TxtBalance_Validating(object sender, CancelEventArgs e)
        {
            if ( TxtBalance.Text==string.Empty || (Convert.ToSingle(TxtBalance.Text) <= 99))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtBalance, "Minimmun Inital Balance is 100 $");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtBalance, "");

            }
        }

        private void TxtBankName_Validating(object sender, CancelEventArgs e)
        {
            if (TxtBankName.TextLength <= 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtBankName, "Plese Enter Bank Name More Than 4 Latter");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtBankName, "");

            }
        }

        private void TxtURL_Validating(object sender, CancelEventArgs e)
        {
            if (!clsGlobal.URLValidation(TxtURL.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtURL, "Plese Enter Valid URL");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtURL, "");

            }
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (TxtPassword.TextLength <= 5)
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtPassword, "Plese Enter Password More Than 5 Latter");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtPassword, "");
            }
        }

        private void TxtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (TxtConfirmPassword.TextLength <= 5)
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtConfirmPassword, "Plese Make sure you are wirte same Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtConfirmPassword, "");
            }
        }

        private void TxtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (TxtConfirmPassword.Text != TxtPassword.Text)
            {
                guna2Button1.Enabled = false;
            }
            else
            {
                guna2Button1.Enabled = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            if (Mode == enMode.Update)
            {
                UpdateAccount();
                if (_Account.Save())
                {
                    DataBack?.Invoke(this, true);
                    MessageBox.Show("Data Updated successfully", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data does not Updated ", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DataBack?.Invoke(this, false);
                this.Close();
                return;
            }

           clsBanksAccount Account= new clsBanksAccount();

            Account.AccountNumber = TxtAccountNumber.Text;
            Account.CustomerID = clsCustomers.Find(CBCustomers.SelectedItem.ToString()).CustomerID;
            Account.InitialBalance=Convert.ToSingle(TxtBalance.Text);
            Account.BankName=TxtBankName.Text;
            Account.BankURL=TxtURL.Text;
            Account.Password=TxtPassword.Text;
            if (TxtDescription.Text.Length == 0)
                Account.Description = null;
            else
            Account.Description=TxtDescription.Text;

            if (Account.Save())
            {
                DataBack?.Invoke(this, true);
                MessageBox.Show("Bank Account Added successfully. ", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data does not Added. ", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DataBack?.Invoke(this, false);

            this.Close();


        }

        private void TxtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            guna2Button1.Enabled = (TxtAccountNumber.TextLength >= 3);
        }


    }
}
