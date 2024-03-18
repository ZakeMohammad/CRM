using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsQuotes
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int QuotesID { get; set; }
        public int CustomerID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpirDate { get; set; }
        public float Tax { get; set; }
        public float? Discount { get; set; }
        public string Subject { get; set; }
        public string ProposalText { get; set; }
        public int ProductID { get; set; }
        public int ProductQuantity { get; set; }
        public int QuotesStatusID { get; set; }
        public string Notes { get; set; }


        public clsCustomers Customer;

        public clsProducts Product;


        public clsQuotes()
        {
            Mode = enMode.Add;
            this.QuotesID = 0;
            this.CustomerID = 0;
            this.CreateDate = DateTime.Now;
            this.ExpirDate = DateTime.Now;
            this.Tax = 0;
            this.Discount = null;
            this.Subject = null;
            this.ProposalText = null;
            this.ProductID = 0;
            this.ProductQuantity = 0;
            this.QuotesStatusID = 0;
            this.Notes = null;

        }

        private clsQuotes(int QuotesID, int CustomerID, DateTime CreateDate, DateTime ExpirDate, float Tax, float? Discount, string Subject, string ProposalText, int ProductID, int ProductQuantity, int QuotesStatusID, string Notes)
        {
            Mode = enMode.Update;
            this.QuotesID = QuotesID;
            this.CustomerID = CustomerID;
            this.CreateDate = CreateDate;
            this.ExpirDate = ExpirDate;
            this.Tax = Tax;
            this.Discount = Discount;
            this.Subject = Subject;
            this.ProposalText = ProposalText;
            this.ProductID = ProductID;
            this.ProductQuantity = ProductQuantity;
            this.QuotesStatusID = QuotesStatusID;
            this.Notes = Notes;
            Customer = clsCustomers.Find(CustomerID);
            Product=clsProducts.Find(ProductID);
        }


        private bool _AddNew()
        {
            this.QuotesID = clsQuotesData.AddNewQuotes(this.CustomerID, this.CreateDate, this.ExpirDate, this.Tax, this.Discount, this.Subject, this.ProposalText, this.ProductID, this.ProductQuantity, this.QuotesStatusID, this.Notes);

            return (this.QuotesID != null);
        }


        private bool _Update()
        {
            return clsQuotesData.UpdateQuotes(this.QuotesID, this.CustomerID, this.CreateDate, this.ExpirDate, this.Tax, this.Discount, this.Subject, this.ProposalText, this.ProductID, this.ProductQuantity, this.QuotesStatusID, this.Notes);
        }


        public static clsQuotes Find(int QuotesID)
        {
            int CustomerID = 0;
            DateTime CreateDate = DateTime.Now;
            DateTime ExpirDate = DateTime.Now;
            float Tax = 0;
            float? Discount = null;
            string Subject = null;
            string ProposalText = null;
            int ProductID = 0;
            int ProductQuantity = 0;
            int QuotesStatusID = 0;
            string Notes = null;


            if (clsQuotesData.FindQuotes(ref QuotesID, ref CustomerID, ref CreateDate, ref ExpirDate, ref Tax, ref Discount, ref Subject, ref ProposalText, ref ProductID, ref ProductQuantity, ref QuotesStatusID, ref Notes))
                return new clsQuotes(QuotesID, CustomerID, CreateDate, ExpirDate, Tax, Discount, Subject, ProposalText, ProductID, ProductQuantity, QuotesStatusID, Notes);
            else
                return null;
        }


        public static clsQuotes Find(int QuotesID,int CustomerID)
        {
            DateTime CreateDate = DateTime.Now;
            DateTime ExpirDate = DateTime.Now;
            float Tax = 0;
            float? Discount = null;
            string Subject = null;
            string ProposalText = null;
            int ProductID = 0;
            int ProductQuantity = 0;
            int QuotesStatusID = 0;
            string Notes = null;


            if (clsQuotesData.FindQuotesForThisCustomer(ref QuotesID, ref CustomerID, ref CreateDate, ref ExpirDate, ref Tax, ref Discount, ref Subject, ref ProposalText, ref ProductID, ref ProductQuantity, ref QuotesStatusID, ref Notes))
                return new clsQuotes(QuotesID, CustomerID, CreateDate, ExpirDate, Tax, Discount, Subject, ProposalText, ProductID, ProductQuantity, QuotesStatusID, Notes);
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


        public static bool Delete(int QuotesID)
        {
            return clsQuotesData.DeleteQuotes(QuotesID);
        }


        public static bool IsQuotesExist(int QuotesID)
        {
            return clsQuotesData.IsQuotesExist(QuotesID);
        }


        public static DataTable All()
        {
            return clsQuotesData.AllQuotes();
        }



        public static DataTable AllQuotesForThisCustomer(int CustomerID)
        {
            return clsQuotesData.AllQuotesForThisCustomer(CustomerID);
        }

    }
}
