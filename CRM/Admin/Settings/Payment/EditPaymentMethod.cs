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
    public partial class EditPaymentMethod : Form
    {
        public EditPaymentMethod(int methodID)
        {
            InitializeComponent();
            MethodID = methodID;
        }

        int MethodID;

        private void EditPaymentMethod_Load(object sender, EventArgs e)
        {
            ctrlPaymentMethodsAddEdit1.FillDataForUpdate(MethodID);
           
        }
    }
}
