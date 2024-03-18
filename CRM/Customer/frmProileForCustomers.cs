using CRM.Admin.Customers;
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
    public partial class frmProileForCustomers : Form
    {
        public frmProileForCustomers()
        {
            InitializeComponent();
        }

        Form CurrentForm;
        private void OpenChiledForm(Form ChildForm)
        {
            if (CurrentForm != null)
            {
                CurrentForm.Close();
            }
            CurrentForm = ChildForm;
            CurrentForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            PanelForAddEditFrm.Controls.Add(ChildForm);
            PanelForAddEditFrm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void frmProileForCustomers_Load(object sender, EventArgs e)
        {
            frmAddEditCusteomrs frm=new frmAddEditCusteomrs(clsGlobal.CurrentCustomer.CustomerID);
            OpenChiledForm(frm);
            ctrlPersonalInformation1.FillUserControlWithData(clsGlobal.CurrentCustomer.CustomerID);
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAddEditCusteomrs frm = new frmAddEditCusteomrs(clsGlobal.CurrentCustomer.CustomerID);
            OpenChiledForm(frm);
            ctrlPersonalInformation1.FillUserControlWithData(clsGlobal.CurrentCustomer.CustomerID);
        }

    }
}
