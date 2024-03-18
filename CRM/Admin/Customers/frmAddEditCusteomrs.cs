using CRM.Admin.Companies;
using CRM.Admin.Customers.Groups;
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

namespace CRM.Admin.Customers
{
    public partial class frmAddEditCusteomrs : Form
    {
        public frmAddEditCusteomrs()
        {
            InitializeComponent();
            Mode = enMode.Add;
        }
        public frmAddEditCusteomrs(int customerid)
        {
            InitializeComponent();
            Mode = enMode.Update;
            CustomerIDForUpdate = customerid;
        }


        public delegate void DataBackEvent(object o, bool IsAddedOrUpdate);

        public event DataBackEvent DataBack;

        public enum enMode { Add, Update }

        public enMode Mode = enMode.Add;

        public int CustomerIDForUpdate;
        public clsCustomers _Customer;


        void FillComboBoxForCompanyes()
        {
            DataTable dtCompanye = clsCompanyes.GitAllCompanyes();

            foreach (DataRow Row in dtCompanye.Rows)
            {
                CBCompanys.Items.Add(Row["CompanyName"]);
            }
        }
        void FillComboBoxForGorups()
        {
            DataTable dtGroups = clsGroups.GitAllGroups();

            foreach (DataRow Row in dtGroups.Rows)
            {
                CBGroups.Items.Add(Row["Name"]);
            }
        }
        void FillComboBoxForCountres()
        {
            foreach (DataRow Row in clsGlobal.GitAllCountrys().Rows)
            {
                CBCountrys.Items.Add(Row["CountryName"]);
            }

        }
        void FillComboBoxForCurrency()
        {
            foreach (DataRow Row in clsGlobal.GitAllCurrency().Rows)
            {
                CBCurrency.Items.Add(Row["CurrenceCode"]);
            }
        }
        void GitDataIfNewCompanyAdded(object sender, int companyid)
        {
            CBCompanys.Items.Clear();
            FillComboBoxForCompanyes();
            CBCompanys.SelectedIndex = companyid - 1;
        }
        void GitDataIfNewGroupAdded(object sender, int groupid)
        {
            CBGroups.Items.Clear();
            FillComboBoxForGorups();
            CBGroups.SelectedIndex = groupid - 1;
           
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAddNewCompany_Click(object sender, EventArgs e)
        {
            frmAddEditCompany frm= new frmAddEditCompany();
            frm.DataBack += GitDataIfNewCompanyAdded;
            frm.ShowDialog();
        }

        void BasicInfoForForm()
        {
            FillComboBoxForCompanyes();
            FillComboBoxForCountres();
            FillComboBoxForGorups();
            FillComboBoxForCurrency();
        }

        private void frmAddEditCusteomrs_Load(object sender, EventArgs e)
        {
           BasicInfoForForm();

            if(Mode==enMode.Update)
            {
                clsCustomers Customer = clsCustomers.Find(CustomerIDForUpdate);
                TxtName.Text = Customer.Name;
                CBCompanys.SelectedIndex = Customer.CompanyID-1;
                TxtEmail.Text = Customer.Email;
                TxtPhone.Text = Customer.Phone;
                TxtAdrress.Text = Customer.Adrress;
                TxtCity.Text = Customer.City;
                TxtRegion.Text=Customer.State_Regoin;
                CBCountrys.SelectedIndex = Customer.CountryID-1;
                CBCurrency.SelectedIndex = Customer.CurrencyID-1;
                CBGroups.SelectedIndex=Customer.GroupID-1;
                TxtZip.Text = Customer.Zip;
                TxtPassword.Text = Customer.Password;
                TxtConfirmPassword.Text = Customer.Password;
                _Customer= Customer;
            }
        }
        private void UpdateCustomer()
        {
            _Customer.CustomerID = CustomerIDForUpdate;
            _Customer.Name=TxtName.Text;
            _Customer.Email=TxtEmail.Text;
            _Customer.Phone=TxtPhone.Text;
            _Customer.Adrress=TxtAdrress.Text;
            _Customer.City=TxtCity.Text;
            _Customer.State_Regoin=TxtRegion.Text;
            _Customer.Zip=TxtZip.Text;
            _Customer.Password=TxtPassword.Text;
            _Customer.CompanyID=CBCompanys.SelectedIndex+1;
            _Customer.GroupID=CBGroups.SelectedIndex+1;
            _Customer.CurrencyID=CBCurrency.SelectedIndex+1;
            _Customer.CountryID = CBCountrys.SelectedIndex+1;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            frmAddEditGroup frm=new frmAddEditGroup();
            frm.DataBack += GitDataIfNewGroupAdded;
            frm.ShowDialog();
        }

     
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if(!this.ValidateChildren())
            {
                return;
            }

            if(Mode ==enMode.Update)
            {
                UpdateCustomer();
                if(_Customer.Save())
                {
                    DataBack?.Invoke(this, true);
                    MessageBox.Show("Data Updated successfully", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                   
                else                  
                MessageBox.Show("Data does not Updated ", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataBack?.Invoke(this, false);
                this.Close();
                return;
            }

            clsCustomers NewCustomer= new clsCustomers();

            NewCustomer.Name = TxtName.Text;
            NewCustomer.Email = TxtEmail.Text;
            NewCustomer.Phone = TxtPhone.Text;
            NewCustomer.Adrress = TxtAdrress.Text;
            NewCustomer.City = TxtCity.Text;
            NewCustomer.State_Regoin = TxtRegion.Text;
            NewCustomer.Zip=TxtZip.Text;
            NewCustomer.Password = TxtPassword.Text;
            NewCustomer.CountryID = CBCountrys.SelectedIndex + 1;
            NewCustomer.GroupID = CBGroups.SelectedIndex + 1;
            NewCustomer.CurrencyID = CBCurrency.SelectedIndex + 1;
            NewCustomer.CompanyID = CBCompanys.SelectedIndex + 1;
           
            if(NewCustomer.Save())
            {
                DataBack?.Invoke(this,true);
                MessageBox.Show($"Customer Added successfully With ID {NewCustomer.CustomerID}", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            MessageBox.Show("Data does not Added ", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DataBack?.Invoke(this, false);

            this.Close();
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            if(TxtName.TextLength<=5)
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtName, "Plese Enter Name More Than 5 Latter");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(TxtName, "");
            }
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
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

        private void TxtPhone_Validating(object sender, CancelEventArgs e)
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

        private void TxtAdrress_Validating(object sender, CancelEventArgs e)
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

        private void TxtCity_Validating(object sender, CancelEventArgs e)
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

        private void TxtRegion_Validating(object sender, CancelEventArgs e)
        {
            if (TxtRegion.TextLength <= 5)
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtRegion, "Plese Enter Region More Than 5 Latter");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtRegion, "");
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
            if (TxtConfirmPassword.Text!=TxtPassword.Text)
            {
                guna2Button1.Enabled = false;
            }
            else
            {
                guna2Button1.Enabled = true;
            }
        }

        private void TxtZip_Validating(object sender, CancelEventArgs e)
        {
            if (TxtZip.TextLength < 4 || TxtZip.TextLength > 6)
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtZip, "Plese Make sure you are wirte only 5 numbers");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtZip, "");
            }
        }

  
    }
}
