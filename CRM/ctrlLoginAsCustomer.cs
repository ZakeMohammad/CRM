using CRM.Customer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CRM
{
    public partial class ctrlLoginAsCustomer : UserControl
    {
        public ctrlLoginAsCustomer()
        {
            InitializeComponent();
        }



        public event Action<bool> IsLogin;

        protected virtual void IsLoginSuccssfilly(bool Ruslt)
        {
            Action<bool> Handler = IsLogin;

            if (Handler != null)
            {
                Handler(Ruslt);
            }
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            if(clsGlobal.LoginForCustomers(TxtName.Text,TxtPassword.Text))
            {

                frmMainFormForCoustomer frm = new frmMainFormForCoustomer(TxtName.Text);
                TxtName.Text = string.Empty;
                TxtPassword.Text = string.Empty;
                frm.Show();
                IsLoginSuccssfilly(true);
            }
            else
            {
                lblWrongInput.Visible = true;
                lblWrongInput.Text = "! Wrong Name / Password ....";
                TxtName.Text = string.Empty;
                TxtPassword.Text = string.Empty;
                TxtName.Focus();
            }
            
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            if (TxtName.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtName, "Plese Enter Name / Email");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtName, "");
            }
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (TxtPassword.Text == string.Empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtPassword, "Plese Enter Password");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtPassword, "");
            }
        }
    }
}
