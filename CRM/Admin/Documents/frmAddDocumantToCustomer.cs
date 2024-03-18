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

namespace CRM.Admin.Documents
{
    public partial class frmAddDocumantToCustomer : Form
    {
        public frmAddDocumantToCustomer(int pDfID)
        {
            InitializeComponent();
            PDfID = pDfID;
        }

        int PDfID;
        clsDocuments Documant;


        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsCustomersDocumant documant = new clsCustomersDocumant();

            documant.CustomerID=clsCustomers.Find(CBCustomers.SelectedItem.ToString()).CustomerID;
            documant.Titel = Documant.Title;
            documant.Path = Documant.FilePath;

            if (documant.Save())
               this.Close();
        }
        void FillComboBoxForCustomers()
        {
            DataTable dtCustomers = clsCustomers.All();

            foreach (DataRow Row in dtCustomers.Rows)
            {
                CBCustomers.Items.Add(Row["Name"]);
            }
        }
        private void frmAddDocumantToCustomer_Load(object sender, EventArgs e)
        {
            FillComboBoxForCustomers();
            Documant = clsDocuments.Find(PDfID);
        }
    }
}
