using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CRM
{
    public partial class ctrlloginAsAdmin : UserControl
    {
        public ctrlloginAsAdmin()
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

            if(clsGlobal.LoginForAdmins(TxtUsername.Text,TxtPassword.Text))
            {
                MainFormForAdmins frm = new MainFormForAdmins(TxtUsername.Text);
                TxtUsername.Text = string.Empty;
                TxtPassword.Text = string.Empty;
                frm.Show();
                IsLoginSuccssfilly(true);
            }
            else
            {
                lblWrongInput.Visible = true;
                lblWrongInput.Text = "! Wrong Username / Password ....";
                TxtUsername.Text = string.Empty;
                TxtPassword.Text = string.Empty;
                TxtUsername.Focus();
            }
            return;
        }

        private void TxtUsername_Validating(object sender, CancelEventArgs e)
        {
            if(TxtUsername.Text==string.Empty)
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtUsername, "Plese Enter Username");

            }
            else
            {
                e.Cancel=false;
                errorProvider1.SetError(TxtUsername, "");
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
