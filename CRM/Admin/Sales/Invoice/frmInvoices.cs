using CRM.Admin.Sales.Invoice;
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
    public partial class frmInvoices : Form
    {
        public frmInvoices()
        {
            InitializeComponent();
        }
        DataTable AllInvoices;
        private Form CurrentForm;
        enum enInvoiceStatus { Unpaid = 1, Paid = 2, InProgress = 3 }

        void _Refresh()
        {
            AllInvoices = clsAdminInvoices.All(); ;
            DgvAdminInvoices.DataSource = AllInvoices;
            NumberOfRecords.Text = AllInvoices.Rows.Count.ToString();
        }

        private void frmInvoices_Load(object sender, EventArgs e)
        {
            _Refresh();
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
            PanelForfrmAdminInvoice.Controls.Add(ChildForm);
            PanelForfrmAdminInvoice.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }



        private void printInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrintInvoiceForAdmins frm=new frmPrintInvoiceForAdmins((int)DgvAdminInvoices.CurrentRow.Cells[0].Value);
            OpenChiledForm(frm);
            frmInvoices_Load(null,null);
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayForAdmins frm=new frmPayForAdmins((int)DgvAdminInvoices.CurrentRow.Cells[0].Value, (int)DgvAdminInvoices.CurrentRow.Cells[6].Value);
            OpenChiledForm(frm);
            frmInvoices_Load(null, null);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            clsExport.ExportTabelsAsPDF(DgvAdminInvoices, "All Invoices");
        }

        private void CBForFIllter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBForFIllter.SelectedIndex != 0 && CBForFIllter.SelectedIndex != 3)
            {
                TxtFiltterFor.Visible = true;
            }
            else
            TxtFiltterFor.Visible=false;

            if(CBForFIllter.SelectedIndex==3)
                CBStatus.Visible = true;
            else
                CBStatus.Visible=false;
        }

        private void TxtFiltterFor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TxtFiltterFor_TextChanged(object sender, EventArgs e)
        {
            string FillterName = "";

            DataView View = AllInvoices.DefaultView;

            switch (CBForFIllter.SelectedItem)
            {
                case "None":
                    {
                        FillterName = "";
                        break;
                    }
                case "Name":
                    {
                        FillterName = "Name";
                        break;
                    }
                case "Product Name":
                    {
                        FillterName = "ProductName";
                        break;
                    }
            }


            if (TxtFiltterFor.Text.Length < 0)
            {
                View.RowFilter = "";
                return;
            }

            View.RowFilter = string.Format("[{0}] like '{1}%'", FillterName, TxtFiltterFor.Text);

        }

        private void CBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FillterName = "";

            DataView View = AllInvoices.DefaultView;

            switch (CBStatus.SelectedItem)
            {
                case "All":
                    {
                        FillterName = "";
                        break;
                    }
                case "Unpaid":
                    {
                        FillterName = "Status";
                        break;
                    }
                case "Paid":
                    {
                        FillterName = "Status";
                        break;
                    }
            }
            if (FillterName =="")
            {
                View.RowFilter = "";
                return;
            }

            View.RowFilter = string.Format("[{0}] like '{1}%'", FillterName, CBStatus.SelectedItem.ToString());
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            clsAdminInvoices invoice = clsAdminInvoices.Find((int)DgvAdminInvoices.CurrentRow.Cells[0].Value);

            if (invoice.StatusID != (int)enInvoiceStatus.Unpaid)
                payToolStripMenuItem.Enabled = false;
            else
                payToolStripMenuItem.Enabled = true;
        }


    }
}
