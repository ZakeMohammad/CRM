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

namespace CRM.Admin.Companies
{
    public partial class ctrlCompanyInfo : UserControl
    {
        public ctrlCompanyInfo()
        {
            InitializeComponent();
        }

        private int _CompanyID;
       private clsCompanyes _Companyes;


        public int CompanyID;
        public clsCompanyes Company;


        public void FillControlWithData(int Companyid)
        {
            _Companyes = clsCompanyes.Find(Companyid);

            if(_Companyes != null)
            {
                lblCompanyName1.Text = _Companyes.CompanyName;
                lblCompanyName2.Text = _Companyes.CompanyName;
                lblEmail.Text= _Companyes.Email;
                lblPhone.Text= _Companyes.Phone;
                lblURL.Text= _Companyes.URL;
                Company = _Companyes;
            }
        }

    }
}
