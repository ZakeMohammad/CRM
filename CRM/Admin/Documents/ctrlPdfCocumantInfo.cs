using CRM_BussinsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Admin.Documents
{
    public partial class ctrlPdfCocumantInfo : UserControl
    {
        public ctrlPdfCocumantInfo()
        {
            InitializeComponent();
        }

        int DoucmantID;
        public void FillDataToControl(int DocumentId)
        {
            DoucmantID = DocumentId;
            clsDocuments documents = clsDocuments.Find(DocumentId);

            lblPDFName.Text = documents.Title;
            TxtFilePath.Text = documents.FilePath;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsDocuments.Delete(DoucmantID))
                return;
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Process.Start(TxtFilePath.Text);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            frmAddDocumantToCustomer frm = new frmAddDocumantToCustomer(DoucmantID);
            frm.ShowDialog();
        }


    }
}
