using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM.Admin;
using CRM.Admin.Settings;
using CRM.Admin.Transactions;
using CRM.Admin.Transactions.Deposit;
using CRM_BussinsLayer;
using CRM.Admin.AdminInfo;

namespace CRM
{
    public partial class MainFormForAdmins : Form
    {
        public MainFormForAdmins(string username)
        {
            InitializeComponent();
            CurrentAdmin = clsAdmins.Find(username);
            clsGlobal.CurrentAdmin = CurrentAdmin;
            lblUsername.Text = CurrentAdmin.Name;
        }


        private Guna2Button CurrentButton;  
        
        private Form CurrentForm;

        public clsAdmins CurrentAdmin;


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

        private void Reset()
        {
            DesabliButton();
            LabelForChiledForm.Text = "Home";
        }

        public void ActiveButtoun(object senderbutton)
        {
            if (senderbutton != null)
            {
                DesabliButton();
                CurrentButton = (Guna2Button)senderbutton;
                CurrentButton.BackColor = Color.Tomato;
               
            }
        }

        public void DesabliButton()
        {
            if (CurrentButton != null)
            {
                CurrentButton.BackColor = Color.Transparent;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmStartForm Form = new frmStartForm();
            Reset();
            OpenChiledForm(Form);
        }

        private void btnDashpoord_Click(object sender, EventArgs e)
        {
            frmDashpoord Form = new frmDashpoord();
            ActiveButtoun(btnDashpoord);
            OpenChiledForm(Form);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            frmStartForm Form=new frmStartForm();
            OpenChiledForm(Form);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frm= new frmCustomers();
            ActiveButtoun(btnCustomers);
            OpenChiledForm(frm);
        }

        private void btnCompanies_Click(object sender, EventArgs e)
        {
            ActiveButtoun(btnCompanies);
            frmCompanies frm= new frmCompanies();
            OpenChiledForm(frm);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            ActiveButtoun(btnTransactions);
            frmManageTransactions frm= new frmManageTransactions();
            OpenChiledForm(frm);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ActiveButtoun(btnSales);
            frmInvoices frm= new frmInvoices();
            OpenChiledForm(frm);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ActiveButtoun(btnOrders);
            frmOrders frm= new frmOrders();
            OpenChiledForm(frm);
        }

        private void btnDoucuments_Click(object sender, EventArgs e)
        {
            ActiveButtoun(btnDoucuments);
            frmDocuments frm= new frmDocuments();
            OpenChiledForm(frm);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ActiveButtoun(btnCalendar);
            frmCalendar frm= new frmCalendar();
            OpenChiledForm(frm);
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            ActiveButtoun(btnBank);
            frmBank frm= new frmBank();
            OpenChiledForm(frm);
        }

        private void btnProductAndService_Click(object sender, EventArgs e)
        {
            ActiveButtoun(btnProductAndService);
            frmProducts frm= new frmProducts();
            OpenChiledForm(frm);
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActiveButtoun(btnSettings);
            frmAdmins frm= new frmAdmins();
            OpenChiledForm(frm);
        }

        private void listCoustmersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers frm= new frmCustomers();
            OpenChiledForm(frm);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmInvoices frm= new frmInvoices();
            OpenChiledForm(frm);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmQuotes frm= new frmQuotes();
            OpenChiledForm(frm);
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayments frm= new frmPayments();
            OpenChiledForm(frm);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmProducts frm= new frmProducts();
            OpenChiledForm(frm);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmService frm= new frmService();
            OpenChiledForm(frm);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAdmins frm= new frmAdmins();
            OpenChiledForm(frm);
        }

 

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmPaymentMehod frm= new frmPaymentMehod();
            OpenChiledForm(frm);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmPaymentGategory frm= new frmPaymentGategory();
            OpenChiledForm(frm);
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm= new frmLogin();
            frm.Show();
            this.Close();
        }

        private void showAdminInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminInfo frm = new frmAdminInfo(CurrentAdmin.AdminID);
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
