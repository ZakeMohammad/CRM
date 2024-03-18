using CRM.Admin.Sales.Quete;
using CRM.Customer.QuotesForCustomer;
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

namespace CRM.Customer
{
    public partial class frmQuotesForCustomers : Form
    {
        public frmQuotesForCustomers()
        {
            InitializeComponent();
        }
       
        private void frmQuotesForCustomers_Load(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        void RefreshMenu()
        {
            DataTable AllQuetes = clsQuotes.AllQuotesForThisCustomer(clsGlobal.CurrentCustomer.CustomerID);

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow Row in AllQuetes.Rows)
            {
                ctrlQutesinfoForCustomer menuiteminfo = new ctrlQutesinfoForCustomer();


                menuiteminfo.FillDataToControl(Convert.ToInt32(Row["QuotesID"]),clsGlobal.CurrentCustomer.CustomerID);

                flowLayoutPanel1.Controls.Add(menuiteminfo);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            RefreshMenu();
        }
    }
}
