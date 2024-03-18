using CRM.Properties;
using CRM_BussinsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Admin.Settings.Payment
{
    public partial class ctrlPaymentMethodsAddEdit : UserControl
    {
        public ctrlPaymentMethodsAddEdit()
        {
            InitializeComponent();
        }

        string ImagePath=null;

        clsPaymentMethods MethodForUpdaet;

        public event Action<bool> OnMethodAdded;

        protected virtual void MethodAddedSucccssfilly(bool Ruslt)
        {
            Action<bool> Handler = OnMethodAdded;

            if (Handler != null)
            {
                Handler(Ruslt);
            }
        }


        public enum enMode { add,update}

        public enMode Mode = enMode.add;

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if(TxtName.Text.Length > 0)
            {
                btnChooseImage.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                btnChooseImage.Enabled = false;
                btnSave.Enabled = false;
            }
          

        }


        public void FillDataForUpdate(int MethodID)
        {
            Mode = enMode.update;

           clsPaymentMethods Method = clsPaymentMethods.Find(MethodID);

            TxtName.Text = Method.MethodName;

            if (Method.Image != null)
            {
                ImageBox.ImageLocation = Method.Image;
            }
            else
                ImageBox.Image = Resources.ask;

            MethodForUpdaet = Method;
        }

        public void Update()
        {
            MethodForUpdaet.MethodName = TxtName.Text;

            if (ImageBox.ImageLocation == null)
                MethodForUpdaet.Image = null;
            else
                MethodForUpdaet.Image = ImageBox.ImageLocation;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if(Mode==enMode.update)
            {
                Update();

                if(MethodForUpdaet.Save())
                {
                    MethodAddedSucccssfilly(true);
                    TxtName.Text = string.Empty;
                    ImageBox.Image = Resources.ask;
                    return;
                }
                else
                    MessageBox.Show("Method Does Not Update", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                MethodAddedSucccssfilly(false);
                return;
            }

            clsPaymentMethods Method=new clsPaymentMethods();

            Method.MethodName=TxtName.Text;
            Method.Image = ImagePath;

            if (Method.Save())
            {
                MethodAddedSucccssfilly(true);
                TxtName.Text = string.Empty;
                ImageBox.Image = Resources.ask;
                return; 
            }
            else
                MessageBox.Show("Method Does Not Added", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            MethodAddedSucccssfilly(false);
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageBox.ImageLocation = openFileDialog1.FileName;
                ImagePath = openFileDialog1.FileName;
            }
            else
                ImagePath = null;
        }

        private void ctrlPaymentMethodsAddEdit_Load(object sender, EventArgs e)
        {
           
        }
    }
}
