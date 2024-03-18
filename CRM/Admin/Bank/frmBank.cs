using CRM.Admin.Bank;
using CRM.Admin.Transactions;
using CRM_BussinsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Admin
{
    public partial class frmBank : Form
    {
        public frmBank()
        {
            InitializeComponent();
        }

        DataTable _AllAccounts;
        private Form CurrentForm;

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
            PanelForFormsBank.Controls.Add(ChildForm);
            PanelForFormsBank.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }




        private void frmBank_Load(object sender, EventArgs e)
        {
            _Refresh();
        }
        void _Refresh()
        {
            _AllAccounts= clsBanksAccount.All(); ;
            DgvBanksAccount.DataSource = _AllAccounts;
            NumberOfRecords.Text=_AllAccounts.Rows.Count.ToString();
        }

        private void CBForFIllter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtFiltterFor.Visible=(CBForFIllter.SelectedIndex!=0);
        }


        void GitDataBack(object sender, bool IsUpdateOrAdded)
        {
            frmBank_Load(null, null);
        }

        private void TxtFiltterFor_TextChanged(object sender, EventArgs e)
        {
            string FillterName = "";

            DataView View = _AllAccounts.DefaultView;

            switch(CBForFIllter.SelectedItem)
            {
                case "None":
                    {
                        FillterName = "";
                        break;
                    }
                case "Account Number":
                    {
                        FillterName = "AccountNumber";
                        break;
                    }
                case "Name":
                    {
                        FillterName = "Name";
                        break;
                    }
                case "Bank Name":
                    {
                        FillterName = "BankName";
                        break;
                    }
            }


            if(TxtFiltterFor.Text.Length < 0)
            {
                View.RowFilter = "";
                return;
            }
     
            View.RowFilter = string.Format("[{0}] like '{1}%'", FillterName, TxtFiltterFor.Text);

        }

        private void TxtFiltterFor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnAddBankAccount_Click(object sender, EventArgs e)
        {
            frmAddEditAccount frm =new frmAddEditAccount();
            frm.DataBack += GitDataBack;
            OpenChiledForm(frm);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditAccount frm=new frmAddEditAccount((int)DgvBanksAccount.CurrentRow.Cells[0].Value);
            frm.DataBack += GitDataBack;
            OpenChiledForm(frm);
        }

        private void showAccountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBankAccountInfo frm = new frmBankAccountInfo((int)DgvBanksAccount.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deeteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Whant You Whant To Delete This Account?", "Dlete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsBanksAccount.Delete((int)DgvBanksAccount.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Account Sucssfilly Deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmBank_Load(null, null);
                    return;
                }
                else
                {
                    MessageBox.Show("Account Does Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            clsExport.ExportTabelsAsPDF(DgvBanksAccount, "Transactions");
        }

    }
}
