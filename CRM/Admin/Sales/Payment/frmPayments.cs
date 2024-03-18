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
    public partial class frmPayments : Form
    {
        public frmPayments()
        {
            InitializeComponent();
        }
        DataTable AllPayment;


        void _Refresh()
        {
            AllPayment = clsAdminsPayments.All(); ;
            DgvAdminInPayments.DataSource = AllPayment;
            NumberOfRecords.Text = AllPayment.Rows.Count.ToString();
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            _Refresh();
            CBForFIllter.SelectedIndex = 0;
        }

        private void CBForFIllter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBForFIllter.SelectedIndex != 0) 
                TxtFiltterFor.Visible = true;
            else
                TxtFiltterFor.Visible=false;
        }

        private void TxtFiltterFor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(CBForFIllter.SelectedIndex!=5)
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

        private void TxtFiltterFor_TextChanged(object sender, EventArgs e)
        {
            string FillterName = "";

            DataView View = AllPayment.DefaultView;

            switch (CBForFIllter.SelectedItem)
            {
                case "None":
                    {
                        FillterName = "";
                        break;
                    }
                case "Username":
                    {
                        FillterName = "Username";
                        break;
                    }
                case "Name":
                    {
                        FillterName = "Name";
                        break;
                    }
                case "Method Name":
                    {
                        FillterName = "MethodName";
                        break;
                    }
                case "Gategory Name":
                    {
                        FillterName = "GategoryName";
                        break;
                    }
                case "Amount":
                    {
                        FillterName = "Amount";
                        break;
                    }
            }


            if (TxtFiltterFor.Text.Length < 0)
            {
                View.RowFilter = "";
                return;
            }

            if(FillterName=="Amount")
            {
                if (TxtFiltterFor.Text=="" || TxtFiltterFor.Text=="0")
                {
                    View.RowFilter = "";
                    return;
                }
                View.RowFilter = string.Format("[{0}] = {1}", FillterName, TxtFiltterFor.Text);
            }
                
            else
                View.RowFilter = string.Format("[{0}] like '{1}%'", FillterName, TxtFiltterFor.Text);


        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            clsExport.ExportTabelsAsPDF(DgvAdminInPayments, "All Admin Payment");
        }
    }
}
