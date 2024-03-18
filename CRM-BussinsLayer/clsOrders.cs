using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsOrders
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int? ProductID { get; set; }
      
        public int Quantity { get; set; }
        public float Price { get; set; }
        public int StatusID { get; set; }

        public clsProducts Product { get; }

        public clsCustomers Customer { get; set; }
     

        public clsOrders()
        {
            Mode = enMode.Add;
            this.OrderID = 0;
            this.CustomerID = 0;
            this.ProductID = null;
          
            this.Quantity = 0;
            this.Price = 0;
            this.StatusID = 0;

        }

        private clsOrders(int OrderID, int CustomerID, int? ProductID, int Quantity, float Price, int StatusID)
        {
            Mode = enMode.Update;
            this.OrderID = OrderID;
            this.CustomerID = CustomerID;
            this.ProductID = ProductID;       
            this.Quantity = Quantity;
            this.Price = Price;
            this.StatusID = StatusID;
            Product = clsProducts.Find((int)ProductID);  
            Customer=clsCustomers.Find(CustomerID);
        }


        private bool _AddNew()
        {
            this.OrderID = clsOrdersData.AddNewOrders(this.CustomerID, this.ProductID, this.Quantity, this.Price, this.StatusID);

            return (this.OrderID != null);
        }


        private bool _Update()
        {
            return clsOrdersData.UpdateOrders(this.OrderID, this.CustomerID, this.ProductID,  this.Quantity, this.Price, this.StatusID);
        }


        public static clsOrders Find(int OrderID)
        {
            int CustomerID = 0;
            int? ProductID = null;
          
            int Quantity = 0;
            float Price = 0;
            int StatusID = 0;


            if (clsOrdersData.FindOrders(ref OrderID, ref CustomerID, ref ProductID, ref Quantity, ref Price, ref StatusID))
                return new clsOrders(OrderID, CustomerID, ProductID, Quantity, Price, StatusID);
            else
                return null;
        }


        public bool Save()
        {
            switch (Mode)
            {

                case enMode.Add:
                    {
                        if (_AddNew())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
                defult:
                    return false;
            }
            return false;
        }


        public static bool Delete(int OrderID)
        {
            return clsOrdersData.DeleteOrders(OrderID);
        }


        public static bool IsOrdersExist(int OrderID)
        {
            return clsOrdersData.IsOrdersExist(OrderID);
        }


        public static DataTable All()
        {
            return clsOrdersData.AllOrders();
        }



        public static DataTable OrderDetelis(int CustomerID)
        {
            return clsOrdersData.OrderDetelis(CustomerID);
        }


        public bool ChangeOrderStatus(int StatusID)
        {
            return clsOrdersData.ChangeOrderStatus(this.OrderID,StatusID);
        }

        public bool IsOrderAcitve()
        {
            return clsOrdersData.IsOrderAcitve(this.OrderID);
        }





    }
}
