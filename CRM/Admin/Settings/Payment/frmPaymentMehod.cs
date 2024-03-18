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
    public partial class frmPaymentMehod : Form
    {
        public frmPaymentMehod()
        {
            InitializeComponent();
        }


        void RefreshMenu()
        {
            DataTable AllMethods = clsPaymentMethods.All();

            flowLayoutPanel1.Controls.Clear();

            foreach(DataRow Row in AllMethods.Rows)
            {
                ctrlPaymentMethodInfo menuiteminfo = new ctrlPaymentMethodInfo();

              
                menuiteminfo.FillDataToControl(Convert.ToInt32(Row["MethodID"]));

                flowLayoutPanel1.Controls.Add(menuiteminfo);
            }

        }


        private void ctrlPaymentMethodsAddEdit1_OnMethodAdded(bool obj)
        {
            if(obj)
            {
                RefreshMenu();
            }
        }

        private void frmPaymentMehod_Load(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshMenu();
        }

    }
}
