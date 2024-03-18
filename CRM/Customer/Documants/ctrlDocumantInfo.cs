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

namespace CRM.Customer.Documants
{
    public partial class ctrlDocumantInfo : UserControl
    {
        public ctrlDocumantInfo()
        {
            InitializeComponent();
        }

        string Path;

        int documantID;


        public void FillDataToControl(int DocumantID)
        {
            clsCustomersDocumant Documant = clsCustomersDocumant.Find(DocumantID);

            lblName.Text = Documant.Titel;
            Path=Documant.Path;
            documantID=DocumantID;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Process.Start(Path);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsCustomersDocumant.Delete(documantID))
                return;
        }
    }
}
