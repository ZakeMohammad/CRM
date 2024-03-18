using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsCustomersPayments : clsPayments
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int CustomerPaymentID { get; set; }

        public clsCustomersPayments()
        {
            Mode = enMode.Add;
            this.CustomerPaymentID = 0;
            this.PaymentID = 0;

        }

        private clsCustomersPayments(int CustomerPaymentID, int PaymentID)
        {
            Mode = enMode.Update;
            this.CustomerPaymentID = CustomerPaymentID;
            this.PaymentID = PaymentID;

        }


        private bool _AddNew()
        {
            this.CustomerPaymentID = clsCustomersPaymentsData.AddNewCustomersPayments(this.PaymentID);

            return (this.CustomerPaymentID != null);
        }


        private bool _Update()
        {
            return clsCustomersPaymentsData.UpdateCustomersPayments(this.CustomerPaymentID, this.PaymentID);
        }


        public static clsCustomersPayments Find(int CustomerPaymentID)
        {
            int PaymentID = 0;


            if (clsCustomersPaymentsData.FindCustomersPayments(CustomerPaymentID, ref PaymentID))
                return new clsCustomersPayments(CustomerPaymentID, PaymentID);
            else
                return null;
        }


        public bool Save()
        {

            base.Mode = (clsPayments.enMode)Mode;
            if (!base.Save())
                return false;


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
            }
            return false;

        }


        public static bool Delete(int CustomerPaymentID)
        {
            return clsCustomersPaymentsData.DeleteCustomersPayments(CustomerPaymentID);
        }


        public static bool IsCustomersPaymentsExist(int CustomerPaymentID)
        {
            return clsCustomersPaymentsData.IsCustomersPaymentsExist(CustomerPaymentID);
        }


        public static DataTable All()
        {
            return clsCustomersPaymentsData.AllCustomersPayments();
        }



    }
}
