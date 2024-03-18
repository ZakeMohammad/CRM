using CRM_BussinsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Admin.Companies
{
    public partial class frmAddEditCompany : Form
    {
        public frmAddEditCompany()
        {
            InitializeComponent();
            Mode = enMode.Add;
        }
        public frmAddEditCompany(int Companyid)
        {
            InitializeComponent();
            Mode = enMode.Update;
            CompanyID = Companyid;
        }

        public enum enMode { Add,Update}

        public enMode Mode= enMode.Add;


        public delegate void DataBackEvent(object o, int companyid);

        public event DataBackEvent DataBack;

 
        private int CompanyID;

        private clsCompanyes _Company;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                return;
            }

            if(Mode==enMode.Update)
            {
                UpdateCompany();
                if(_Company.Save())
                {
                    MessageBox.Show("Data Updated successfully", "Companyes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                   
                else
                    MessageBox.Show("Data does ot Updated ", "Companyes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

           clsCompanyes NewCompany=new clsCompanyes();

            NewCompany.CompanyName = TxtCompanyName.Text;
            NewCompany.URL=TxtURL.Text;
            NewCompany.Email=TxtEmail.Text;
            NewCompany.Phone=TxtPhone.Text;

            if(NewCompany.Save())
            {
                DataBack?.Invoke(this, NewCompany.CompanyID);
                MessageBox.Show("Data added successfully", "Companyes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                       
            else
                MessageBox.Show("Data does ot added ", "Companyes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if(!clsGlobal.EmailValidation(TxtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtEmail, "Plese Enter Valid Email");
            }
            else
            {
                e.Cancel= false;
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

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void UpdateCompany()
        {
           
            _Company.CompanyName=TxtCompanyName.Text;   
            _Company.Email= TxtEmail.Text;
            _Company.URL=TxtURL.Text;
            _Company.Phone=TxtPhone.Text;
        }
        void FillDataToFormForUpdateMode()
        {
            clsCompanyes Company = clsCompanyes.Find(CompanyID);
            TxtCompanyName.Text = Company.CompanyName;

            if (Company.URL != "")
                TxtURL.Text = Company.URL;
            else
                TxtURL.Text = "";

            if (Company.Email != "")
                TxtEmail.Text = Company.Email;
            else
                TxtEmail.Text = "";
            
            if (Company.Phone != "")
                TxtPhone.Text = Company.Phone;
            else
                TxtPhone.Text = "";

            _Company = Company;
        }

        private void frmAddEditCompany_Load(object sender, EventArgs e)
        {
            if(Mode==enMode.Update)
            {
                this.Text = "Update Company";
                FillDataToFormForUpdateMode();
                return;
            }
            this.Text = "Add Company";
        }

        private void TxtCompanyName_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCompanyName.TextLength<6)
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtCompanyName, "Plese Enter Valid Company Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtCompanyName, "");
            }
        }
    }
}
