using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Admin.Companies
{
    public partial class frmCompanyInfo : Form
    {
        public frmCompanyInfo(int companyID)
        {
            InitializeComponent();
            CompanyID = companyID;
        }
        int CompanyID;
        private void frmCompanyInfo_Load(object sender, EventArgs e)
        {
            ctrlCompanyInfo1.FillControlWithData(CompanyID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
