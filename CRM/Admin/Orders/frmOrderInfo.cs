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

namespace CRM.Admin.Orders
{
    public partial class frmOrderInfo : Form
    {
        public frmOrderInfo(int orderID)
        {
            InitializeComponent();

            Order = clsOrders.Find(orderID);
        }

        clsOrders Order;
        enum enOrderStatus { Pending=1,Active=2, Received =3, Canceled =4}
        enum enInvoiceStatus { Unpaid=1,Paid=2}

        private void frmOrderInfo_Load(object sender, EventArgs e)
        {
            lblOrderID.Text=Order.OrderID.ToString();
            groupBox1.Enabled = false;
            ctrlOrderCard1.FillDataToControl(Order.OrderID);
            GitStatusForOrder();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void GitStatusForOrder()
        {
            if (Order.StatusID == (int)enOrderStatus.Active)
            {
                //MessageBox.Show("This Order Is ALready Actived...", "Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                btnAccept.Enabled =false;
                groupBox1.Enabled = true;
                btnDELETE.Enabled = false;
                btnCanceled.Enabled = false;
            }
            if (Order.StatusID == (int)enOrderStatus.Canceled)
            {
                btnCanceled.Enabled = false;
                btnAccept.Enabled = false;               
            }
            if (Order.StatusID == (int)enOrderStatus.Received)
            {
                btnCanceled.Enabled = false;
                btnAccept.Enabled = false;
                btnDELETE.Enabled = false;
            }
          
        }


    

        private void btnAccept_Click(object sender, EventArgs e)
        {


            if (Order.ChangeOrderStatus((int)enOrderStatus.Active))
            {
                clsCustomersInvoices InvoiceForOrder = new clsCustomersInvoices();

                InvoiceForOrder.CustomerID = Order.CustomerID;
                InvoiceForOrder.InvoiceDate = DateTime.Now;
                InvoiceForOrder.Amount = Order.Price;
                InvoiceForOrder.StatusID = (int)enInvoiceStatus.Unpaid;
                InvoiceForOrder.OrderID = Order.OrderID;
                if (InvoiceForOrder.Save())
                {
                    MessageBox.Show("Order Succssfilly Accepted","Orders",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    groupBox1.Enabled = true;
                }

            }
            else
              MessageBox.Show("Order Does Not Actived", "Orders", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            if(Order.ChangeOrderStatus((int)enOrderStatus.Canceled))        
                MessageBox.Show("Order Succssfilly Canceled", "Orders", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
             else
                MessageBox.Show("Order Does Not Canceled", "Orders", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            this.Close();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if(clsOrders.Delete(Order.OrderID))
                MessageBox.Show("Order Succssfilly Deleted", "Orders", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            else
                MessageBox.Show("Order Does Not Deleted", "Orders", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
