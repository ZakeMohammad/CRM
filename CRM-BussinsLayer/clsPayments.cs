using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsPayments
    {
        public enum enMode { Add, Update }
        public enMode Mode;
        public int PaymentID { get; set; }
        public int InvoiceID { get; set; }
        public DateTime PaymentDate { get; set; }
        public float Amount { get; set; }
        public int Method { get; set; }
        public string Description { get; set; }


        public clsPayments()
        {
            Mode = enMode.Add;
            this.PaymentID = 0;
            this.InvoiceID = 0;
            this.PaymentDate = DateTime.Now;
            this.Amount = 0;
            this.Method = 0;
            this.Description = null;

        }

        private clsPayments(int PaymentID, int InvoiceID, DateTime PaymentDate, float Amount, int Method, string Description)
        {
            Mode = enMode.Update;
            this.PaymentID = PaymentID;
            this.InvoiceID = InvoiceID;
            this.PaymentDate = PaymentDate;
            this.Amount = Amount;
            this.Method = Method;
            this.Description = Description;

        }


        private bool _AddNew()
        {
            this.PaymentID = clsPaymentsData.AddNewPayments(this.InvoiceID, this.PaymentDate, this.Amount, this.Method, this.Description);

            return (this.PaymentID != null);
        }


        private bool _Update()
        {
            return clsPaymentsData.UpdatePayments(this.PaymentID, this.InvoiceID, this.PaymentDate, this.Amount, this.Method, this.Description);
        }


        public static clsPayments Find(int PaymentID)
        {
            int InvoiceID = 0;
            DateTime PaymentDate = DateTime.Now;
            float Amount = 0;
            int Method = 0;
            string Description = null;


            if (clsPaymentsData.FindPayments(ref PaymentID, ref InvoiceID, ref PaymentDate, ref Amount, ref Method, ref Description))
                return new clsPayments(PaymentID, InvoiceID, PaymentDate, Amount, Method, Description);
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


        public static bool Delete(int PaymentID)
        {
            return clsPaymentsData.DeletePayments(PaymentID);
        }


        public static bool IsPaymentsExist(int PaymentID)
        {
            return clsPaymentsData.IsPaymentsExist(PaymentID);
        }


        public static DataTable All()
        {
            return clsPaymentsData.AllPayments();
        }






    }
}
