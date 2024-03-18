using CRM.Admin.Customers;
using CRM_BussinsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using IronPdf;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Configuration;

namespace CRM.Admin
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }
        private Form CurrentForm;

        private  DataTable _DTALlCustomers=clsCustomers.All();

        int Seconds = 0;

        private void frmCustomers_Load(object sender, EventArgs e)
        {
           ProgreesForDelete.Visible = false;
            ProgreesForDelete.Enabled = false;
            _RefreshData();
        }

        void _RefreshData()
        {
            _DTALlCustomers = clsCustomers.All();
            DgvCustomers.DataSource = _DTALlCustomers;
            NumberOfRecords.Text=_DTALlCustomers.Rows.Count.ToString();
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
            PanelForFormAddEditCustomer.Controls.Add(ChildForm);
            PanelForFormAddEditCustomer.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();           
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddEditCusteomrs frm=new frmAddEditCusteomrs();
            frm.DataBack += GitTrueIfUpdateOrAddedForCustomers;
            OpenChiledForm(frm);
          
        }

        private void GitTrueIfUpdateOrAddedForCustomers(object e,bool isUpdateOrAdded)
        {
            frmCustomers_Load(null, null);
        }
        private void CBForFIllter_SelectedIndexChanged(object sender, EventArgs e)
        {

            TxtFiltterFor.Visible = (CBForFIllter.SelectedIndex != 0);

            if(!TxtFiltterFor.Visible)
            {
                DataView dataView = _DTALlCustomers.DefaultView;
                dataView.RowFilter = "";
                NumberOfRecords.Text=dataView.Count.ToString();
            }
        }

        private void TxtFiltterFor_TextChanged(object sender, EventArgs e)
        {
            string FillterFor = "";

            DataView dataView = _DTALlCustomers.DefaultView;

            switch (CBForFIllter.SelectedItem.ToString()) 
            {
                case "None":
                    {
                        FillterFor = "";
                        break;
                    }
                case "Customer ID":
                    {
                        FillterFor = "CustomerID";
                        break;
                    }
                case "Name":
                    {
                        FillterFor = "Name";
                        break;
                    }
                case "Company Name":
                    {
                        FillterFor = "CompanyName";
                        break;
                    }
                case "Group Name":
                    {
                        FillterFor = "GroupName";
                        break;
                    }
            }


            if (CBForFIllter.SelectedItem.ToString() == "Customer ID")
            {
                if (TxtFiltterFor.Text == "" || TxtFiltterFor.Text == "0")
                {
                    dataView.RowFilter = "";
                    return;
                }
                dataView.RowFilter = string.Format("[{0}] = {1}",FillterFor,TxtFiltterFor.Text);
            }
            else
                dataView.RowFilter = string.Format("[{0}] like '{1}%'",FillterFor,TxtFiltterFor.Text);

        }

        private void TxtFiltterFor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CBForFIllter.SelectedItem == "Customer ID")
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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCusteomrs frm=new frmAddEditCusteomrs((int)DgvCustomers.CurrentRow.Cells[0].Value);
            frm.DataBack += GitTrueIfUpdateOrAddedForCustomers;
            OpenChiledForm(frm);
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            clsExport.ExportTabelsAsPDF(DgvCustomers,"All Customers");
        }

        private void showCustomerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerInfo frm = new frmCustomerInfo((int)DgvCustomers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void TimerForActions_Tick(object sender, EventArgs e)
        {
            Seconds++;
            ProgreesForDelete.Enabled = true;
            ProgreesForDelete.Visible = true;

            if (Seconds >=3)
            {
                TimerForActions.Enabled = false;
                ProgreesForDelete.Enabled = false;
                ProgreesForDelete.Visible = false;
                if (clsCustomers.Delete((int)DgvCustomers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Customer Sucssfilly Deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCustomers_Load(null, null);
                    return;
                }
                else
                {
                    MessageBox.Show("Customer Does Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                   
                    return;
                }
               
               
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are You Whant You Whant To Delete This Customer?","Dlete",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
           {
             TimerForActions.Enabled = true;
           }

        }



    }

}
