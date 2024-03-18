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

namespace CRM.Admin.AdminInfo
{
    public partial class ctrlAdminInfo : UserControl
    {
        public ctrlAdminInfo()
        {
            InitializeComponent();
        }


        private clsAdmins _Admin;


        public clsAdmins Admin;

        public int AdminID;

        public void FillUserControlWithData(int adminid)
        {
            _Admin = clsAdmins.Find(adminid);
            if (_Admin != null)
            {
                Admin = _Admin;
                AdminID = adminid;
                lblUsername.Text = _Admin.Username;
                lblFullName.Text = _Admin.Name;
                lblCompany.Text = _Admin.Company.CompanyName;
                lblEmail.Text = _Admin.Email;
                lblPhone.Text = _Admin.Phone;
                lblCity.Text = _Admin.City;
                lblAdrress.Text = _Admin.Adrress;
                lblCountry.Text = clsGlobal.GitCountryName(_Admin.CountryID);

            }

        }

    }
}
