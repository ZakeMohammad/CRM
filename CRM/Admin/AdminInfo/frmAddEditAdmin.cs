using CRM.Admin.Companies;
using CRM_BussinsLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CRM.Admin.AdminInfo
{
    public partial class frmAddEditAdmin : Form
    {
        public frmAddEditAdmin()
        {
            InitializeComponent();
            Mode = enMode.Add;
        }

        public frmAddEditAdmin(int adminid)
        {
            InitializeComponent();
            AdminID = adminid;
            Mode = enMode.Update;
        }


        enum enPermissions 
        { 
            All=-1,Customers=1,Companies=2,Transactions=4,
            Invoice=16,Quetes=32 ,Payments=64,
            Orders=128,Documant=256,Calender=512,Bank=1024,Products=2048,
            Service=4096,Reporites=8192,Uitelties=16284,Taxs=32768,Admins=65536,
            PaymentMethods=131072,PaymentGategory=262144 
        }


        int AdminID;

       
        public clsAdmins _Admin;

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int CalculatePermissions()
        {
            int Result = 0;

            if(CHAll.Checked == true)
            {
                Result = -1;
                return Result;
            }
            else
                Result = 0;

            if (CHCustomers.Checked==true)
                Result += 1;
          
            if (CHCompanies.Checked == true)
                Result += 2;
           
            if (CHTransactions.Checked == true)
                Result += 4;
           
            if (CHInvoices.Checked == true)
                Result += 16;
            
            if (CHQuetes.Checked == true)
                Result += 32;
           
            if (CHPayments.Checked == true)
                Result += 64;
           
            if (CHOrders.Checked == true)
                Result += 128;
           
            if (CHDocumant.Checked == true)
                Result += 256;
           
            if (CHCalender.Checked == true)
                Result += 512;
           
            if (CHBank.Checked == true)
                Result += 1024;
           
            if (CHProducts.Checked == true)
                Result += 2048;
           
            if (CHServices.Checked == true)
                Result += 4096;
           
            if (CHReporits.Checked == true)
                Result += 8192;
           
            if (CHUtilites.Checked == true)
                Result += 16284;
            
            if (ChTax.Checked == true)
                Result += 32768;
           
            if (CHAdmins.Checked == true)
                Result += 65536;
           
            if (CHPaymentMethod.Checked == true)
                Result += 131072;
           
            if (CHPaymentGategory.Checked == true)
                Result += 262144;
          

            return Result;
        }

        void CheakAll(bool IsCheakAll)
        {
            if(IsCheakAll)
            {
                CHCustomers.Checked = true;
                CHCompanies.Checked = true;
                CHTransactions.Checked = true;
                CHInvoices.Checked = true;
                CHQuetes.Checked = true;
                CHPayments.Checked = true;
                CHOrders.Checked = true;
                CHDocumant.Checked = true;
                CHCalender.Checked = true;
                CHBank.Checked = true;
                CHProducts.Checked = true;
                CHServices.Checked = true;
                CHReporits.Checked = true;
                CHUtilites.Checked = true;
                ChTax.Checked = true;
                CHAdmins.Checked = true;
                CHPaymentMethod.Checked = true;
                CHPaymentGategory.Checked = true;
            }
            else
            {
                CHCustomers.Checked = false;
                CHCompanies.Checked = false;
                CHTransactions.Checked = false;
                CHInvoices.Checked = false;
                CHQuetes.Checked = false;
                CHPayments.Checked = false;
                CHOrders.Checked = false;
                CHDocumant.Checked = false;
                CHCalender.Checked = false;
                CHBank.Checked = false;
                CHProducts.Checked = false;
                CHServices.Checked = false;
                CHReporits.Checked = false;
                CHUtilites.Checked = false;
                ChTax.Checked = false;
                CHAdmins.Checked = false;
                CHPaymentMethod.Checked = false;
                CHPaymentGategory.Checked = false;
            }
        }

        private void CHAll_CheckedChanged(object sender, EventArgs e)
        {
            if (CHAll.Checked == true)
                CheakAll(true);
            else
                CheakAll(false);
        }

        public enum enMode { Add, Update }

        public enMode Mode = enMode.Add;


        void FillComboBoxForCompanyes()
        {
            DataTable dtCompanye = clsCompanyes.GitAllCompanyes();

            foreach (DataRow Row in dtCompanye.Rows)
            {
                CBCompanys.Items.Add(Row["CompanyName"]);
            }
        }

        void FillComboBoxForCountres()
        {
            foreach (DataRow Row in clsGlobal.GitAllCountrys().Rows)
            {
                CBCountrys.Items.Add(Row["CountryName"]);
            }

        }

        void BasicInfoForForm()
        {
            FillComboBoxForCompanyes();
            FillComboBoxForCountres();
          
        }

        void GitDataIfNewCompanyAdded(object sender, int companyid)
        {
            CBCompanys.Items.Clear();
            FillComboBoxForCompanyes();
            CBCompanys.SelectedIndex = companyid - 1;
        }

        private void lblAddNewCompany_Click(object sender, EventArgs e)
        {
            frmAddEditCompany frm = new frmAddEditCompany();
            frm.DataBack += GitDataIfNewCompanyAdded;
            frm.ShowDialog();
        }


        void CheakWhatAdminHavePermissions()
        {
            if(_Admin.Permissoins==-1)
            {
                CHAll.Checked = true;
                return;
            }

            if((_Admin.Permissoins & (int)enPermissions.Customers) == (int)enPermissions.Customers)
            {
                CHCustomers.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.Companies) == (int)enPermissions.Companies)
            {
                CHCompanies.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.Transactions) == (int)enPermissions.Transactions)
            {
                CHTransactions.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.Invoice) == (int)enPermissions.Invoice)
            {
                CHInvoices.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.Quetes) == (int)enPermissions.Quetes)
            {
                CHQuetes.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.Payments) == (int)enPermissions.Payments)
            {
                CHPayments.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.Orders) == (int)enPermissions.Orders)
            {
                CHOrders.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.Documant) == (int)enPermissions.Documant)
            {
                CHDocumant.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.Calender) == (int)enPermissions.Calender)
            {
                CHCalender.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.Bank) == (int)enPermissions.Bank)
            {
                CHBank.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.Products) == (int)enPermissions.Products)
            {
                CHProducts.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.Service) == (int)enPermissions.Service)
            {
                CHServices.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.Reporites) == (int)enPermissions.Reporites)
            {
                CHReporits.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.Uitelties) == (int)enPermissions.Uitelties)
            {
                CHUtilites.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.Taxs) == (int)enPermissions.Taxs)
            {
                ChTax.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.Admins) == (int)enPermissions.Admins)
            {
                CHAdmins.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.PaymentMethods) == (int)enPermissions.PaymentMethods)
            {
                CHPaymentMethod.Checked = true;
            }
            if ((_Admin.Permissoins & (int)enPermissions.PaymentGategory) == (int)enPermissions.PaymentGategory)
            {
                CHPaymentGategory.Checked = true;
            }

        }

        private void frmAddEditAdmin_Load(object sender, EventArgs e)
        {
            BasicInfoForForm();

            if (Mode == enMode.Update)
            {
                clsAdmins Admin = clsAdmins.Find(AdminID);
                TxtName.Text = Admin.Name;
                TxtUsername.Text = Admin.Username;
                CBCompanys.SelectedIndex = Admin.CompanyID - 1;
                TxtEmail.Text = Admin.Email;
                TxtPhone.Text = Admin.Phone;
                TxtAdrress.Text = Admin.Adrress;
                TxtCity.Text = Admin.City;              
                CBCountrys.SelectedIndex = Admin.CountryID - 1;
                TxtPassword.Text = Admin.Paswoord;
                TxtConfirmPassword.Text = Admin.Paswoord;
                _Admin = Admin;
                CheakWhatAdminHavePermissions();
                TxtUsername.Enabled = false;
            }
            CBCompanys.SelectedIndex = 1;
            CBCountrys.SelectedIndex = 89;
        }

        private void UpdateAdmin()
        {
            _Admin.AdminID = AdminID;
            _Admin.Name = TxtName.Text;
            _Admin.Username = TxtUsername.Text;
            _Admin.Email = TxtEmail.Text;
            _Admin.Phone = TxtPhone.Text;
            _Admin.Adrress = TxtAdrress.Text;
            _Admin.City = TxtCity.Text;
            _Admin.Paswoord = TxtPassword.Text;
            _Admin.CompanyID = CBCompanys.SelectedIndex + 1;
            _Admin.CountryID = CBCountrys.SelectedIndex + 1;
            _Admin.Permissoins = CalculatePermissions();
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            if (Mode == enMode.Update)
            {
                UpdateAdmin();
                if (_Admin.Save())
                {
                   
                    MessageBox.Show("Data Updated successfully", "Admins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data does not Updated ", "Admins", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

          clsAdmins NewAdmin = new clsAdmins();

            NewAdmin.Name = TxtName.Text;
            NewAdmin.Username = TxtUsername.Text;
            NewAdmin.Email = TxtEmail.Text;
            NewAdmin.Phone = TxtPhone.Text;
            NewAdmin.Adrress = TxtAdrress.Text;
            NewAdmin.City = TxtCity.Text;
            NewAdmin.Paswoord = TxtPassword.Text;
            NewAdmin.CountryID = CBCountrys.SelectedIndex + 1;
            NewAdmin.Permissoins = CalculatePermissions();
            NewAdmin.CompanyID = CBCompanys.SelectedIndex + 1;

            if (NewAdmin.Save())
            {
                MessageBox.Show($"Admin Added successfully With ID {NewAdmin.AdminID}", "Admins", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data does not Added ", "Admins", MessageBoxButtons.OK, MessageBoxIcon.Error);
           

            this.Close();
        }

        private void TxtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TxtName.TextLength <= 5)
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtName, "Plese Enter Name More Than 5 Latter");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtName, "");
            }
        }

        private void TxtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(Mode==enMode.Update)
            {
                if(clsAdmins.Find(TxtUsername.Text) != null && TxtUsername.Text!=_Admin.Username)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(TxtUsername, "There Are Another User like This Username.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(TxtUsername, "");
                }
                return;
            }


            if(clsAdmins.Find(TxtUsername.Text)!=null)
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtUsername, "There Are Another User like This Username.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtUsername, "");
            }
        }

        private void TxtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!clsGlobal.EmailValidation(TxtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtEmail, "Plese Enter Valid Email");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtEmail, "");
            }
        }

        private void TxtPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!clsGlobal.PhoneValidation(TxtPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtPhone, "Plese Enter Valid Phone");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtPhone, "");
            }
        }

        private void TxtAdrress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TxtAdrress.TextLength <= 5)
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtAdrress, "Plese Enter Adrress More Than 5 Latter");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtAdrress, "");
            }
        }

        private void TxtCity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (TxtCity.TextLength <= 5)
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtCity, "Plese Enter City More Than 5 Latter");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtCity, "");
            }
        }

        private void TxtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void TxtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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


    }

}
