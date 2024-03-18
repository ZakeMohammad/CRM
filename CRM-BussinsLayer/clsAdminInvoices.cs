using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsAdminInvoices
    {


        public enum enMode { Add, Update }
        enMode Mode;
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public int StatusID { get; set; }
        public int? InvoiceIDForCustomer { get; set; }
        public DateTime InvoiceDate { get; set; }
        public float Amount { get; set; }
        public float? Tax { get; set; }

        public clsAdminInvoices()
        {
            Mode = enMode.Add;
            this.InvoiceID = 0;
            this.CustomerID = 0;
            this.OrderID = 0;
            this.StatusID = 0;
            this.InvoiceIDForCustomer = null;
            this.InvoiceDate = DateTime.Now;
            this.Amount = 0;
            this.Tax = null;

        }

        private clsAdminInvoices(int InvoiceID, int CustomerID, int OrderID, int StatusID, int? InvoiceIDForCustomer, DateTime InvoiceDate, float Amount, float? Tax)
        {
            Mode = enMode.Update;
            this.InvoiceID = InvoiceID;
            this.CustomerID = CustomerID;
            this.OrderID = OrderID;
            this.StatusID = StatusID;
            this.InvoiceIDForCustomer = InvoiceIDForCustomer;
            this.InvoiceDate = InvoiceDate;
            this.Amount = Amount;
            this.Tax = Tax;
           
        }


        private bool _AddNew()
        {
            this.InvoiceID = clsAdminInvoicesData.AddNewAdminInvoices(this.CustomerID, this.OrderID, this.StatusID, this.InvoiceIDForCustomer, this.InvoiceDate, this.Amount, this.Tax);

            return (this.InvoiceID != null);
        }


        private bool _Update()
        {
            return clsAdminInvoicesData.UpdateAdminInvoices(this.InvoiceID, this.CustomerID, this.OrderID, this.StatusID, this.InvoiceIDForCustomer, this.InvoiceDate, this.Amount, this.Tax);
        }


        public static clsAdminInvoices Find(int InvoiceID)
        {
            int CustomerID = 0;
            int OrderID = 0;
            int StatusID = 0;
            int? InvoiceIDForCustomer = null;
            DateTime InvoiceDate = DateTime.Now;
            float Amount = 0;
            float? Tax = null;


            if (clsAdminInvoicesData.FindAdminInvoices(ref InvoiceID, ref CustomerID, ref OrderID, ref StatusID, ref InvoiceIDForCustomer, ref InvoiceDate, ref Amount, ref Tax))
                return new clsAdminInvoices(InvoiceID, CustomerID, OrderID, StatusID, InvoiceIDForCustomer, InvoiceDate, Amount, Tax);
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
            return clsAdminInvoicesData.DeleteAdminInvoices(InvoiceID);
        }


        public static bool IsAdminInvoicesExist(int InvoiceID)
        {
            return clsAdminInvoicesData.IsAdminInvoicesExist(InvoiceID);
        }


        public static DataTable All()
        {
            return clsAdminInvoicesData.AllAdminInvoices();
        }


        public bool ChangeInviceStatus(int StatusID)
        {
            return clsAdminInvoicesData.ChangeInviceStatus(this.InvoiceID, StatusID);
        }



    }
}
