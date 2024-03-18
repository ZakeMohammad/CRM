using CRM.Properties;
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

namespace CRM.Admin.Settings.Payment
{
    public partial class ctrlPaymentGategoryInfo : UserControl
    {
        public ctrlPaymentGategoryInfo()
        {
            InitializeComponent();
        }

        int GategoryID;

        public event Action<bool> OnGategoryDelete;

        protected virtual void GategoryDeletedSucccssfilly(bool Ruslt)
        {
            Action<bool> Handler = OnGategoryDelete;

            if (Handler != null)
            {
                Handler(Ruslt);
            }
        }

        public void FillDataToControl(int gategoryid)
        {
            clsPaymentGategorys Gategpry = clsPaymentGategorys.Find(gategoryid);


            TxtName.Text = Gategpry.Name;

            GategoryID = Gategpry.PaymentGategoryID;

            if (Gategpry.Image != null)
            {
                ImageBox.ImageLocation = Gategpry.Image;
            }
            else
                ImageBox.Image = Resources.ask__1_;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsPaymentGategorys.Delete(GategoryID))
                GategoryDeletedSucccssfilly(true);
            else
                GategoryDeletedSucccssfilly(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EditPaymentGategory frm = new EditPaymentGategory(GategoryID);
            frm.ShowDialog();
        }

     

    }


}
