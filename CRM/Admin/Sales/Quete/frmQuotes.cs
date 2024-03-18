using CRM.Admin.Sales.Quete;
using CRM.Admin.Settings.Payment;
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
    public partial class frmQuotes : Form
    {
        public frmQuotes()
        {
            InitializeComponent();
        }

        Form CurrentForm;
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
            PanelForAllFrmQutes.Controls.Add(ChildForm);
            PanelForAllFrmQutes.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        void RefreshMenu()
        {
            DataTable AllQuetes = clsQuotes.All();

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow Row in AllQuetes.Rows)
            {
                ctrlQuotesInfo menuiteminfo = new ctrlQuotesInfo();


                menuiteminfo.FillDataToControl(Convert.ToInt32(Row["QuotesID"]));

                flowLayoutPanel1.Controls.Add(menuiteminfo);
            }

        }

        private void btnAddNewQuotes_Click(object sender, EventArgs e)
        {
            frmAddEditQuete frm=new frmAddEditQuete();
            OpenChiledForm(frm);
            frmQuotes_Load(null, null);
        }

        private void frmQuotes_Load(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            RefreshMenu();
        }
    }
}
