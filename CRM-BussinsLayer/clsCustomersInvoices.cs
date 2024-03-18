using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsCustomersInvoices
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public float Amount { get; set; }
        public int StatusID { get; set; }

        public clsOrders Order;

        public int OrderID { get; set; }

        public clsBanksAccount BankAccount { get;}
        public clsCustomersInvoices()
        {
            Mode = enMode.Add;
            this.InvoiceID = 0;
            this.CustomerID = 0;
            this.InvoiceDate = DateTime.Now;
            this.Amount = 0;
            this.StatusID = 0;
            this.OrderID = 0;
            
        }

        private clsCustomersInvoices(int InvoiceID, int CustomerID,int OrderID, DateTime InvoiceDate, float Amount, int StatusID)
        {
            Mode = enMode.Update;
            this.InvoiceID = InvoiceID;
            this.CustomerID = CustomerID;
            this.InvoiceDate = InvoiceDate;
            this.Amount = Amount;
            this.StatusID = StatusID;
            this.OrderID = OrderID;
            Order = clsOrders.Find(OrderID);
            BankAccount = clsBanksAccount.Find(CustomerID,true);
        }


        private bool _AddNew()
        {
            this.InvoiceID = clsCustomersInvoicesData.AddNewCustomersInvoices(this.CustomerID,this.OrderID, this.InvoiceDate, this.Amount, this.StatusID);

            return (this.InvoiceID != null);
        }


        private bool _Update()
        {
            return clsCustomersInvoicesData.UpdateCustomersInvoices(this.InvoiceID, this.CustomerID,this.OrderID, this.InvoiceDate, this.Amount, this.StatusID);
        }


        public static clsCustomersInvoices Find(int InvoiceID)
        {
            int CustomerID = 0;
            int OrderID = 0;
            DateTime InvoiceDate = DateTime.Now;
            float Amount = 0;
            int StatusID = 0;


            if (clsCustomersInvoicesData.FindCustomersInvoices(ref InvoiceID, ref CustomerID,ref OrderID, ref InvoiceDate, ref Amount, ref StatusID))
                return new clsCustomersInvoices(InvoiceID, CustomerID,OrderID, InvoiceDate, Amount, StatusID);
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


        public static bool Delete(int InvoiceID)
        {
            return clsCustomersInvoicesData.DeleteCustomersInvoices(InvoiceID);
        }


        public static bool IsCustomersInvoicesExist(int InvoiceID)
        {
            return clsCustomersInvoicesData.IsCustomersInvoicesExist(InvoiceID);
        }


        public static DataTable All(int CustomerID)
        {
            return clsCustomersInvoicesData.AllCustomersInvoices(CustomerID);
        }


        public  bool ChangeInviceStatus(int StatusID)
        {
            return clsCustomersInvoicesData.ChangeInviceStatus(this.InvoiceID, StatusID);
        }

    }
}
