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

namespace CRM.Admin.Services
{
    public partial class ctrlAddEditServices : UserControl
    {
        public ctrlAddEditServices()
        {
            InitializeComponent();
        }

        public event Action<bool> IsServiceAddOrUpdate;


        protected virtual void ServiceAddOrEdit(bool AddOrEdit)
        {
            Action<bool> Handler = IsServiceAddOrUpdate;

            if (Handler != null)
            {
                Handler(AddOrEdit);
            }
        }

        enum enMode { Add, Update }
        enMode Mode = enMode.Add;

        public int ID;
        clsServices _Service;

        void DisapleSaveButton()
        {
            btnSave.Enabled = false;
        }

        public void EnableSaveButton()
        {
            btnSave.Enabled = true;
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            if (TxtName.Text == string.Empty)
            {
                e.Cancel = true;
                TxtName.Focus();
                errorProvider1.SetError(TxtName, "Plese Enter Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtName, "");
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (TxtName.Text == string.Empty)
                DisapleSaveButton();
            else
                EnableSaveButton();
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        public void FillForUpdate(int id)
        {
           clsServices Service=clsServices.Find(id);

            lblForWhat.Text = "Update Service";
            TxtName.Text = Service.Name;
            TxtDescription.Text = (Service.Descriptoin == "") ? "" : Service.Descriptoin;
            TxtSealisPrice.Text=Service.SalesPrice.ToString();

            _Service=Service;
             ID = id;
            Mode = enMode.Update;
        }

        void Update()
        {
            _Service.Name = TxtName.Text;
            _Service.Descriptoin = TxtDescription.Text;
            _Service.SalesPrice = Convert.ToSingle(TxtSealisPrice.Text);
        }

        private void ctrlAddEditServices_Load(object sender, EventArgs e)
        {
            Resat();
        }
        void Resat()
        {
            lblForWhat.Text = "Add Service";

            TxtName.Text = string.Empty;
            TxtDescription.Text = string.Empty;
            TxtSealisPrice.Text="5";
            Mode = enMode.Add;
            TxtDescription.Focus();
            DisapleSaveButton();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;


            if (Mode == enMode.Add)
            {
                clsServices Service= new clsServices();

                Service.Name = TxtName.Text;
                Service.Descriptoin = TxtDescription.Text;
                Service.SalesPrice=Convert.ToSingle(TxtSealisPrice.Text);

                if (Service.Save())
                {
                    MessageBox.Show($"Service Added Succssfilly With ID {Service.ServiceID}", "Services", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    ServiceAddOrEdit(true);
                }
                else
                    MessageBox.Show($"Service Does Not Added", "Services", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                Update();

                if (_Service.Save())
                {

                    MessageBox.Show($"Service Updated Succssfilly With ID {_Service.ServiceID}", "Services", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    ServiceAddOrEdit(true);
                }

                else
                    MessageBox.Show($"Service Does Not Updated", "Services", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            Resat();
            return;
        }

        private void TxtSealisPrice_Validating(object sender, CancelEventArgs e)
        {
            if (TxtSealisPrice.Text == string.Empty || Convert.ToInt32(TxtSealisPrice.Text) < 5)
            {
                e.Cancel = true;
                TxtSealisPrice.Focus();
                errorProvider1.SetError(TxtSealisPrice, "Minnuimim Price For Any Service is 5 $");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtSealisPrice, "");
            }
        }

    }
}
