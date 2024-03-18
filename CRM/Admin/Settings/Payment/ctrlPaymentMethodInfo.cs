using CRM.Properties;
using CRM_BussinsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Admin.Settings.Payment
{
    public partial class ctrlPaymentMethodInfo : UserControl
    {
        public ctrlPaymentMethodInfo()
        {
            InitializeComponent();
        }

        int MethodId;

        public event Action<bool> OnMethodDelete;

        protected virtual void MethodDeletedSucccssfilly(bool Ruslt)
        {
            Action<bool> Handler = OnMethodDelete;

            if (Handler != null)
            {
                Handler(Ruslt);
            }
        }


        public void FillDataToControl(int MethodID)
        {
            clsPaymentMethods Method = clsPaymentMethods.Find(MethodID);


            TxtName.Text = Method.MethodName;

            MethodId=Method.MethodID;

            if (Method.Image != null)
            {
                ImageBox.ImageLocation = Method.Image;
            }
            else
               ImageBox.Image= Resources.ask;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            if (clsPaymentMethods.Delete(MethodId))
                MethodDeletedSucccssfilly(true);
            else
                MethodDeletedSucccssfilly(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EditPaymentMethod frm = new EditPaymentMethod(MethodId);
            frm.ShowDialog();
            
        }

    }
}
