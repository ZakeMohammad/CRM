using CRM.Admin.Calendar;
using CRM.Admin.Services;
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
    public partial class frmService : Form
    {
        public frmService()
        {
            InitializeComponent();
        }

        DataTable AllService;
        void Refresh()
        {
            AllService = clsServices.All();
            DgvServices.DataSource = AllService;
            NumberOfRecords.Text = AllService.Rows.Count.ToString();
        }

        private void ctrlAddEditServices1_IsServiceAddOrUpdate(bool obj)
        {
            if (obj)
            {
                Refresh();
            }
        }

        private void frmService_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            ctrlAddEditServices1.EnableSaveButton();
        }

        private void showEventInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServiceInfo frm=new frmServiceInfo((int)DgvServices.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(clsServices.Delete((int)DgvServices.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Service Succssfilly Deleted", "Services", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                frmService_Load(null, null);
            }
            else
                MessageBox.Show("Service Does Not Deleted", "Services", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrlAddEditServices1.FillForUpdate((int)DgvServices.CurrentRow.Cells[0].Value);
        }
    }
}
