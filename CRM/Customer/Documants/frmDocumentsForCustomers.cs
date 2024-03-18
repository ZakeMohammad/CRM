using CRM.Admin.Sales.Quete;
using CRM.Customer.Documants;
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
    public partial class frmDocumentsForCustomers : Form
    {
        public frmDocumentsForCustomers()
        {
            InitializeComponent();
        }


        void RefreshMenu()
        {
            DataTable AllDocumants = clsCustomersDocumant.All(clsGlobal.CurrentCustomer.CustomerID);

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow Row in AllDocumants.Rows)
            {
                ctrlDocumantInfo menuiteminfo = new ctrlDocumantInfo();


                menuiteminfo.FillDataToControl(Convert.ToInt32(Row["DocumantID"]));

                flowLayoutPanel1.Controls.Add(menuiteminfo);
            }

        }


        private void frmDocumentsForCustomers_Load(object sender, EventArgs e)
        {
            RefreshMenu();
        }




    }
}
