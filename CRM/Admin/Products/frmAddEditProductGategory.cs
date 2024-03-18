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

namespace CRM.Admin.Products
{
    public partial class frmAddEditProductGategory : Form
    {
        public frmAddEditProductGategory()
        {
            InitializeComponent();
        }



        private void frmAddEditProductGategory_Load(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!(this.ValidateChildren()))
                return;

            clsProductsGategory gategory = new clsProductsGategory();

            gategory.GategoryName = TxtName.Text;
            if (gategory.Save())           
                MessageBox.Show($"Gategory Added Succssfilly With ID {gategory.GategoryID}", "Gategorys", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Gategory Does Not Added", "Gategorys", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            this.Close();
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            if (TxtName.Text == string.Empty)
            {
                e.Cancel = true;
                TxtName.Focus();
                errorProvider1.SetError(TxtName, "Plese Enter Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtName, "");
            }
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }




    }
}
