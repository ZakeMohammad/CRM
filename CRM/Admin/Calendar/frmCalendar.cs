using CRM_BussinsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRM.Admin
{
    public partial class frmCalendar : Form
    {
        public frmCalendar()
        {
            InitializeComponent();
        }

     

        DataTable AllEvents;

        void Refresh()
        {
            AllEvents = clsEvents.All();
            DgvEvents.DataSource= AllEvents;
            NumberOfRecords.Text=AllEvents.Rows.Count.ToString();
        }


        private void frmCalendar_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            ctrlAddEditEvent1.EnableSaveButton();
        }

        private void ctrlAddEditEvent1_IsEventAddOrUpdate(bool obj)
        {
            if(obj)
            {
                Refresh();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrlAddEditEvent1.FillForUpdate(Convert.ToInt32(DgvEvents.CurrentRow.Cells[0].Value));
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsEvents.Delete(Convert.ToInt32(DgvEvents.CurrentRow.Cells[0].Value)))
                return;
        }
    }
}
