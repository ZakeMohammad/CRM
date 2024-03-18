using CRM_BussinsLayer;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CRM.Customer
{
    public partial class frmMainFormForCoustomer : Form
    {
        public frmMainFormForCoustomer(string CustomerName)
        {
            InitializeComponent();

            Customer=clsCustomers.Find(CustomerName);
            clsGlobal.CurrentCustomer = Customer;
            lblCustomerName.Text = CustomerName;
        }
         

        private Guna2Button CurrentButton;

        private Form CurrentForm;

        public clsCustomers Customer;

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
            PanelForAllFormsMain.Controls.Add(ChildForm);
            PanelForAllFormsMain.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            LabelForChiledForm.Text = CurrentForm.Tag.ToString();
        }

      



        public void DesabliButton()
        {
            if (CurrentButton != null)
            {
                CurrentButton.BackColor = Color.Transparent;

            }
        }

 

        private void frmMainFormForCoustomer_Load(object sender, EventArgs e)
        {
            frmTransactonsForCustomer frm= new frmTransactonsForCustomer();
            OpenChiledForm(frm);
        }

  

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            frmTransactonsForCustomer frm = new frmTransactonsForCustomer();
           
            OpenChiledForm(frm);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrderForCustomers frm = new frmOrderForCustomers();
           
            OpenChiledForm(frm);
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            frmDocumentsForCustomers frm = new frmDocumentsForCustomers();
           
            OpenChiledForm(frm);
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            frmInvoicesForCustomers frm = new frmInvoicesForCustomers();
            
            OpenChiledForm(frm);
        }

        private void btnQuotes_Click(object sender, EventArgs e)
        {
            frmQuotesForCustomers frm = new frmQuotesForCustomers();
           
            OpenChiledForm(frm);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProileForCustomers frm = new frmProileForCustomers();
           
            OpenChiledForm(frm);
        }

        private void guna2CirclePictureBox2_Click_1(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }

    }
}
