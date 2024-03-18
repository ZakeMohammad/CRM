using CRM.Admin.Companies;
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
    public partial class frmCompanies : Form
    {
        public frmCompanies()
        {
            InitializeComponent();
        }

        DataTable _AllCompanies;

        private void frmCompanies_Load(object sender, EventArgs e)
        {
            _Refersh();
        }

        void _Refersh()
        {
            _AllCompanies = clsCompanyes.GitAllCompanyes();
            DgvCompaneis.DataSource = _AllCompanies;
            NumberOfRecords.Text = (_AllCompanies.Rows.Count).ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCompany frm= new frmAddEditCompany((int)DgvCompaneis.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmCompanies_Load(null, null);
        }

     

        private void showCompanyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompanyInfo frm = new frmCompanyInfo((int)DgvCompaneis.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void btnAddCompany_Click_1(object sender, EventArgs e)
        {
            frmAddEditCompany frm = new frmAddEditCompany();
            frm.ShowDialog();
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            clsExport.ExportTabelsAsPDF(DgvCompaneis, "Companeis In Our System");
        }

        private void TxtFiltterFor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (CBForFIllter.SelectedItem == "Company ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }
            }
        }

        private void TxtFiltterFor_TextChanged(object sender, EventArgs e)
        {
            string FillterName = "";

            switch (CBForFIllter.SelectedItem)
            {
                case "None":
                    {
                        FillterName = "";
                        break;
                    }
                case "Company ID":
                    {
                        FillterName = "CompanyID";
                        break;
                    }
                case "Company Name":
                    {
                        FillterName = "CompanyName";
                        break;
                    }

            }

            DataView View = _AllCompanies.DefaultView;

            if (TxtFiltterFor.Text == "" || TxtFiltterFor.Text == "0")
            {
                View.RowFilter = "";
                return;
            }

            if (CBForFIllter.SelectedItem == "Company ID")
                View.RowFilter = string.Format("[{0}] = {1}", FillterName, TxtFiltterFor.Text);
            else
                View.RowFilter = string.Format("[{0}] like '{1}%'", FillterName, TxtFiltterFor.Text);
        }

        private void CBForFIllter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtFiltterFor.Visible = (CBForFIllter.SelectedIndex != 0);
        }
    }
}
