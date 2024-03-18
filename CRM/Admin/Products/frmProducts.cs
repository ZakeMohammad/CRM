using CRM.Admin.Calendar;
using CRM.Admin.Products;
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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }


        DataTable AllProduct;

        void Refresh()
        {
            AllProduct = clsProducts.All();
            DgvProducts.DataSource = AllProduct;
            NumberOfRecords.Text = AllProduct.Rows.Count.ToString();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            ctrlAddEditProducts1.Resat();
            ctrlAddEditProducts1.EnableSaveButton();

        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctrlAddEditProducts1.FillForUpdate(Convert.ToInt32(DgvProducts.CurrentRow.Cells[0].Value));
        }

        private void ctrlAddEditProducts1_IsProductAddOrUpdate_1(bool obj)
        {
            if(obj)
            {
                Refresh();
            }
        }

        private void showEventInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductInfo frm = new frmProductInfo(Convert.ToInt32(DgvProducts.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(clsProducts.Delete(Convert.ToInt32(DgvProducts.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("Product Succssfilly Deleted","Products",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                frmProducts_Load(null, null);
            }
            else
                MessageBox.Show("Product Does Not Deleted", "Products", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

    }
}
