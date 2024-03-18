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
    public partial class ctrlPaymentGategoryAddEdit : UserControl
    {
        public ctrlPaymentGategoryAddEdit()
        {
            InitializeComponent();
        }

        public enum enMode { add, update }

        public enMode Mode = enMode.add;

        string ImagePath = null;

        clsPaymentGategorys GategoryForUpdaet;

        public event Action<bool> OnGategoryAdded;

        protected virtual void GategoryAddedSucccssfilly(bool Ruslt)
        {
            Action<bool> Handler = OnGategoryAdded;

            if (Handler != null)
            {
                Handler(Ruslt);
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (TxtName.Text.Length > 0)
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

        public void FillDataForUpdate(int GategoryID)
        {
            Mode = enMode.update;

            clsPaymentGategorys Gategory = clsPaymentGategorys.Find(GategoryID);

            TxtName.Text = Gategory.Name;

            if (Gategory.Image != null)
            {
                ImageBox.ImageLocation = Gategory.Image;
            }
            else
                ImageBox.Image = Resources.ask__1_;

            GategoryForUpdaet = Gategory;
        }

        public void Update()
        {
            GategoryForUpdaet.Name = TxtName.Text;

            if (ImageBox.ImageLocation == null)
                GategoryForUpdaet.Image = null;
            else
                GategoryForUpdaet.Image = ImageBox.ImageLocation;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.update)
            {
                Update();

                if (GategoryForUpdaet.Save())
                {
                    GategoryAddedSucccssfilly(true);
                    TxtName.Text = string.Empty;
                    ImageBox.Image = Resources.ask__1_;
                    return;
                }
                else
                    MessageBox.Show("Gategory Does Not Update", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                GategoryAddedSucccssfilly(false);
                return;
            }

           clsPaymentGategorys Gategory= new clsPaymentGategorys();

            Gategory.Name = TxtName.Text;
            Gategory.Image = ImagePath;

            if (Gategory.Save())
            {
                GategoryAddedSucccssfilly(true);
                TxtName.Text = string.Empty;
                ImageBox.Image = Resources.ask__1_;
                return;
            }
            else
                MessageBox.Show("Gategory Does Not Added", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            GategoryAddedSucccssfilly(false);
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImageBox.ImageLocation = openFileDialog1.FileName;
                ImagePath = openFileDialog1.FileName;
            }
            else
                ImagePath = null;
        }


    }
}
