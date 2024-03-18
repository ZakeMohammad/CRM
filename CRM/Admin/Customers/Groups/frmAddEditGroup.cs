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

namespace CRM.Admin.Customers.Groups
{
    public partial class frmAddEditGroup : Form
    {
        public frmAddEditGroup()
        {
            InitializeComponent();
            Mode = enMode.Add;
        }
        public frmAddEditGroup(int groupID)
        {
            InitializeComponent();
            Mode = enMode.Update;
            GroupID = groupID;
        }

        public delegate void DataBackEvent(object o, int groupid);

        public event DataBackEvent DataBack;
        public enum enMode { Add, Update }

        public enMode Mode = enMode.Add;

        int GroupID;

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditGroup_Load(object sender, EventArgs e)
        {
            if(Mode != enMode.Add)
            {
                this.Text = "Update Group";
                return;
            }
            this.Text = "Add Group";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            clsGroups Group= new clsGroups();

            Group.Name=TxtName.Text;
            if (Group.Save())
            {
                DataBack?.Invoke(this, Group.GroupID);
                MessageBox.Show("Data added successfully", "Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                MessageBox.Show("Data does not added ", "Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();  
        }



    }
}
