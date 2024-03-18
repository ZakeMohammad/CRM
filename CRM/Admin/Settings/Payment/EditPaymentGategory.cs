using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Admin.Settings.Payment
{
    public partial class EditPaymentGategory : Form
    {
        public EditPaymentGategory(int gategoryID)
        {
            InitializeComponent();
            GategoryID = gategoryID;
        }

        int GategoryID;

        private void EditPaymentGategory_Load(object sender, EventArgs e)
        {
            ctrlPaymentGategoryAddEdit1.FillDataForUpdate(GategoryID);
        }
    }
}
