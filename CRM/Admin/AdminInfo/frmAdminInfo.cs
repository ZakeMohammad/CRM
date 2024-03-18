using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Admin.AdminInfo
{
    public partial class frmAdminInfo : Form
    {
        public frmAdminInfo(int adminid)
        {
            InitializeComponent();
            AdminID = adminid;
        }

        int AdminID;

        private void frmAdminInfo_Load(object sender, EventArgs e)
        {
            ctrlAdminInfo1.FillUserControlWithData(AdminID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
