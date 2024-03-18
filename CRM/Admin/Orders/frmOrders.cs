using CRM.Admin.Orders;
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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }


        private Form CurrentForm;

        DataTable AllOrders;

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
            PanelForAll.Controls.Add(ChildForm);
            PanelForAll.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        void Refresh()
        {
            AllOrders = clsOrders.All();
            DgvOrders.DataSource = AllOrders;
            NumberOfRecords.Text=AllOrders.Rows.Count.ToString();
        }

        private void showOrderInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderInfo frm = new frmOrderInfo((int)DgvOrders.CurrentRow.Cells[0].Value);

            OpenChiledForm(frm);
            frmOrders_Load(null, null);
        }


        private void btnAddOrder_Click_1(object sender, EventArgs e)
        {
            frmAddEditOrder frm = new frmAddEditOrder();
            OpenChiledForm(frm);
            frmOrders_Load(null, null);
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void CBStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FillterName = "";

            DataView View = AllOrders.DefaultView;

            switch (CBStatus.SelectedItem)
            {
                case "All":
                    {
                        FillterName = "";
                        break;
                    }
                case "Pending":
                    {
                        FillterName = "Pending";
                        break;
                    }
                case "Active":
                    {
                        FillterName = "Active";
                        break;
                    }
                case "Received":
                    {
                        FillterName = "Received";
                        break;
                    }
                case "Canceled":
                    {
                        FillterName = "Canceled";
                        break;
                    }
            }
            if (FillterName == "")
            {
                View.RowFilter = "";
                return;
            }

            View.RowFilter = string.Format("[Status] like '{0}%'", FillterName);
        }

        private void TxtFiltterFor_TextChanged(object sender, EventArgs e)
        {
            string FillterName = "";

            DataView View = AllOrders.DefaultView;

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
                case "Product":
                    {
                        FillterName = "Product";
                        break;
                    }
                case "Quantity":
                    {
                        FillterName = "Quantity";
                        break;
                    }
            }


            if (TxtFiltterFor.Text.Length < 0)
            {
                View.RowFilter = "";
                return;
            }

            if(CBForFIllter.SelectedIndex==3)
            {
                if(TxtFiltterFor.Text==string.Empty || TxtFiltterFor.Text=="0")
                {
                    View.RowFilter = "";
                    return;
                }
                View.RowFilter = string.Format("[{0}] = {1}", FillterName, TxtFiltterFor.Text);
                return;
            }


            View.RowFilter = string.Format("[{0}] like '{1}%'", FillterName, TxtFiltterFor.Text);
        }

        private void TxtFiltterFor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CBForFIllter.SelectedIndex != 3)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void CBForFIllter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBForFIllter.SelectedIndex != 0 && CBForFIllter.SelectedIndex != 4)
                TxtFiltterFor.Visible = true;
            else
                TxtFiltterFor.Visible = false;

            if (CBForFIllter.SelectedIndex == 4)
                CBStatus.Visible = true;
            else
                CBStatus.Visible = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            clsExport.ExportTabelsAsPDF(DgvOrders, "All Orders");
        }
    }
}
