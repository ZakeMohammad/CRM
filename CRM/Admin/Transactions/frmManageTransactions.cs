using CRM.Admin.Transactions.Deposit;
using CRM_BussinsLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace CRM.Admin.Transactions
{
    public partial class frmManageTransactions : Form
    {
        public frmManageTransactions()
        {
            InitializeComponent();
        }

        private Form CurrentForm;
        DataTable _AllTransactions;
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
            PanelForAllFormsInTransactions.Controls.Add(ChildForm);
            PanelForAllFormsInTransactions.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();  
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmAddEditDeposit frm = new frmAddEditDeposit();
            OpenChiledForm(frm);
            frmManageTransactions_Load(null, null);
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            frmAddEditExpenses frm = new frmAddEditExpenses();
            OpenChiledForm(frm);
            frmManageTransactions_Load(null, null);
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            frmAddEditTransaction frm = new frmAddEditTransaction();
            OpenChiledForm(frm);
            frmManageTransactions_Load(null, null);
        }

        private void frmManageTransactions_Load(object sender, EventArgs e)
        {
            Refrech();
        }


        void Refrech()
        {
            _AllTransactions= clsBanksAccount.AllTransactions();
            DgvTransactions.DataSource= _AllTransactions;
            NumberOfRecords.Text = (_AllTransactions.Rows.Count).ToString();
        }

        private void CBForFIllter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtFiltterFor.Visible = (CBForFIllter.SelectedIndex != 0);
        }

        private void TxtFiltterFor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(CBForFIllter.SelectedIndex!=3)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }
            }
            else
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                 {
                      e.Handled = true;
                 }

        }

        private void TxtFiltterFor_TextChanged(object sender, EventArgs e)
        {
            string FillterName = "";

            DataView View = _AllTransactions.DefaultView;

            switch (CBForFIllter.SelectedItem)
            {
                case "None":
                    {
                        FillterName = "";
                        break;
                    }
                case "Source Account Number":
                    {
                        FillterName = "SourceAccountNumber";
                        break;
                    }
                case "Destination Account Number":
                    {
                        FillterName = "DestinationAccountNumber";
                        break;
                    }
                case "Ammount":
                    {
                        FillterName = "Ammount";
                        break;
                    }
            }


           

            if(CBForFIllter.SelectedIndex != 3)
            {
                View.RowFilter = string.Format("[{0}] like '{1}%'", FillterName, TxtFiltterFor.Text);
            }
            else
            {
                if (TxtFiltterFor.Text==string.Empty||TxtFiltterFor.Text.Length < 0)
                {
                    View.RowFilter = "";
                    return;
                }
                View.RowFilter = string.Format("[{0}]={1}", FillterName, TxtFiltterFor.Text);
            }
              
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            clsExport.ExportTabelsAsPDF(DgvTransactions, "All Transactions");
        }
    }
}
