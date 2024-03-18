using CRM.Admin.Documents;
using CRM.Admin.Sales.Quete;
using CRM_BussinsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Admin
{
    public partial class frmDocuments : Form
    {
        public frmDocuments()
        {
            InitializeComponent();
        }
        void RefreshMenu()
        {
            DataTable AllDocumant = clsDocuments.All();

            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow Row in AllDocumant.Rows)
            {
                ctrlPdfCocumantInfo menuiteminfo = new ctrlPdfCocumantInfo();


                menuiteminfo.FillDataToControl(Convert.ToInt32(Row["DocumentID"]));

                flowLayoutPanel1.Controls.Add(menuiteminfo);
            }

        }
        private void btnChoosePDF_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfile=new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    clsDocuments documents = new clsDocuments();
                    documents.Title = Path.GetFileName(openFileDialog1.FileName);
                    documents.FilePath = openFileDialog1.FileName;
                    if (documents.Save())
                        RefreshMenu();
                }
            }           
        }

        private void frmDocuments_Load(object sender, EventArgs e)
        {
            RefreshMenu();
        }
    }
}
