using CRM.Admin.AdminInfo;
using CRM.Admin.Customers;
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

namespace CRM.Admin
{
    public partial class frmAdmins : Form
    {
        public frmAdmins()
        {
            InitializeComponent();
        }

        private Form CurrentForm;

        private DataTable _DTALlAdmins = clsAdmins.All();

        void _RefreshData()
        {
            _DTALlAdmins = clsAdmins.All();
            DgvAdmins.DataSource = _DTALlAdmins;
            NumberOfRecords.Text = _DTALlAdmins.Rows.Count.ToString();
        }


        private void showCustomerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminInfo frm = new frmAdminInfo((int)DgvAdmins.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditAdmin frm = new frmAddEditAdmin((int)DgvAdmins.CurrentRow.Cells[0].Value);
            OpenChiledForm(frm);
            frmAdmins_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsAdmins.Delete((int)DgvAdmins.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Customer Sucssfilly Deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAdmins_Load(null, null);
                return;
            }
            else
            {
                MessageBox.Show("Customer Does Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void frmAdmins_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }
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
            PanelForAllFormsAdmin.Controls.Add(ChildForm);
            PanelForAllFormsAdmin.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            frmAddEditAdmin frm = new frmAddEditAdmin();
           
            OpenChiledForm(frm);
            _RefreshData();
        }

        private void CBForFIllter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtFiltterFor.Visible = (CBForFIllter.SelectedIndex != 0);

            if (!TxtFiltterFor.Visible)
            {
                DataView dataView = _DTALlAdmins.DefaultView;
                dataView.RowFilter = "";
                NumberOfRecords.Text = dataView.Count.ToString();
            }
        }

        private void TxtFiltterFor_TextChanged(object sender, EventArgs e)
        {
            string FillterFor = "";

            DataView dataView = _DTALlAdmins.DefaultView;

            switch (CBForFIllter.SelectedItem.ToString())
            {
                case "None":
                    {
                        FillterFor = "";
                        break;
                    }               
                case "Name":
                    {
                        FillterFor = "Name";
                        break;
                    }
                case "Username":
                    {
                        FillterFor = "Username";
                        break;
                    }
            }
                dataView.RowFilter = string.Format("[{0}] like '{1}%'", FillterFor, TxtFiltterFor.Text);
        }

        private void TxtFiltterFor_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            clsExport.ExportTabelsAsPDF(DgvAdmins, "All Admins");
        }


    }
}
