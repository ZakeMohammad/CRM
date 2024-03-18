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

namespace CRM.Admin.Orders.Controls
{
    public partial class ctrlOrderCard : UserControl
    {
        public ctrlOrderCard()
        {
            InitializeComponent();
        }

      


        public void FillDataToControl(int orderid)
        {
            clsOrders Order = clsOrders.Find(orderid);


            lblOrderID.Text = orderid.ToString();
            lblCustomerName.Text = Order.Customer.Name;
            lblProductName.Text = Order.Product.Name;
            lblAmount.Text="$ "+Order.Price.ToString();
            lblQUantity.Text=Order.Quantity.ToString();

            if(Order.StatusID==1)
            {
                lblStatus.Text = "Pending";
                lblStatus.BackColor = Color.Orange;
            }
            if(Order.StatusID ==2)
            {
                lblStatus.Text = "Active";
                lblStatus.BackColor = Color.Green;
            }
            if (Order.StatusID == 3)
            {
                lblStatus.Text = "Received";
                lblStatus.BackColor = Color.Blue;
            }
            if (Order.StatusID == 4)
            {
                lblStatus.Text = "Canceled";
                lblStatus.BackColor = Color.Red;
            }

        }


    }
}
