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
    public partial class frmOrderForCustomers : Form
    {
        public frmOrderForCustomers()
        {
            InitializeComponent();
        }

        DataTable AllOrdersForThisCustomer;
        void Refresh()
        {
            AllOrdersForThisCustomer = clsOrders.OrderDetelis(clsGlobal.CurrentCustomer.CustomerID);
            DgvOrders.DataSource = AllOrdersForThisCustomer;
        }
        private void frmOrderForCustomers_Load(object sender, EventArgs e)
        {
            Refresh();
        }


    }
}
