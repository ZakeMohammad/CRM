using CRM.Admin.Settings.Payment;
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

namespace CRM.Admin.Settings
{
    public partial class frmPaymentGategory : Form
    {
        public frmPaymentGategory()
        {
            InitializeComponent();
        }

        void RefreshMenu()
        {
            DataTable AllGategory = clsPaymentGategorys.All();

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow Row in AllGategory.Rows)
            {
                ctrlPaymentGategoryInfo menuiteminfo = new ctrlPaymentGategoryInfo();

                menuiteminfo.FillDataToControl(Convert.ToInt32(Row["PaymentGategoryID"]));

                flowLayoutPanel1.Controls.Add(menuiteminfo);
            }

        }

        private void ctrlPaymentGategoryAddEdit1_OnGategoryAdded(bool obj)
        {
            if (obj)
            {
                RefreshMenu();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        private void frmPaymentGategory_Load(object sender, EventArgs e)
        {
            RefreshMenu();
        }
    }
}
