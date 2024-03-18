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

namespace CRM.Admin.Customers.Controls
{
    public partial class ctrlCustomerInfoWithFillter : UserControl
    {
        public ctrlCustomerInfoWithFillter()
        {
            InitializeComponent();
        }

        public clsCustomers Customer;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(clsCustomers.IsCustomersExist(Convert.ToInt32(TxtSearchByID.Text)))
            {
                ctrlPersonalInformation1.FillUserControlWithData(Convert.ToInt32(TxtSearchByID.Text));
                Customer = ctrlPersonalInformation1.Customer;
            }
            else
                MessageBox.Show($"Customer Wiht ID {TxtSearchByID.Text} Does Not Exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void TxtSearchByID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
