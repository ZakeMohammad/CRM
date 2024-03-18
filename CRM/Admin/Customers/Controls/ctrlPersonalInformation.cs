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
    public partial class ctrlPersonalInformation : UserControl
    {
        public ctrlPersonalInformation()
        {
            InitializeComponent();
        }

        private clsCustomers _Customer;


        public clsCustomers Customer;

        public int CustomerID;


        public void FillUserControlWithData(int customerid)
        {
            _Customer = clsCustomers.Find(customerid);
            if (_Customer != null)
            {
                Customer=_Customer;
                CustomerID = customerid;
                lblPersonName.Text = _Customer.Name;
                lblFullName2.Text = _Customer.Name;
                lblCompanyName.Text = _Customer.Companye.CompanyName;
                lblEmail.Text = _Customer.Email;
                lblPhone.Text = _Customer.Phone;
                lblCity.Text = _Customer.City;
                lblAdrress.Text = _Customer.Adrress;
                lblRegion.Text = _Customer.State_Regoin;
                lblZip.Text = _Customer.Zip;
                lblGruop.Text = _Customer.Group.Name;
                lblCountry.Text = clsGlobal.GitCountryName(_Customer.CountryID);

            }

        }

     

    }
}
