using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsAdminsPayments : clsPayments
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int AdminPaymentID { get; set; }
        public int InvoiceCustomerID { get; set; }
        public int PayByAdminID { get; set; }
        public int GategoryID { get; set; }
        public int? MethodID { get; set; }


        public clsAdminsPayments()
        {
            Mode = enMode.Add;
            this.AdminPaymentID = 0;
            this.InvoiceCustomerID = 0;
            this.PayByAdminID = 0;
            this.GategoryID = 0;
            this.MethodID = null;

        }

        private clsAdminsPayments(int AdminPaymentID, int InvoiceCustomerID, int PayByAdminID, int GategoryID, int? MethodID)
        {
            Mode = enMode.Update;
            this.AdminPaymentID = AdminPaymentID;
            this.InvoiceCustomerID = InvoiceCustomerID;
            this.PayByAdminID = PayByAdminID;
            this.GategoryID = GategoryID;
            this.MethodID = MethodID;

        }


        private bool _AddNew()
        {
            this.AdminPaymentID = clsAdminsPaymentsData.AddNewAdminsPayments(this.InvoiceCustomerID, this.PayByAdminID, this.GategoryID, this.MethodID);

            return (this.AdminPaymentID != null);
        }


        private bool _Update()
        {
            return clsAdminsPaymentsData.UpdateAdminsPayments(this.AdminPaymentID, this.InvoiceCustomerID, this.PayByAdminID, this.GategoryID, this.MethodID);
        }


        public static clsAdminsPayments Find(int AdminPaymentID)
        {
            int InvoiceCustomerID = 0;
            int PayByAdminID = 0;
            int GategoryID = 0;
            int? MethodID = null;


            if (clsAdminsPaymentsData.FindAdminsPayments(ref AdminPaymentID, ref InvoiceCustomerID, ref PayByAdminID, ref GategoryID, ref MethodID))
                return new clsAdminsPayments(AdminPaymentID, InvoiceCustomerID, PayByAdminID, GategoryID, MethodID);
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


        public static bool Delete(int AdminPaymentID)
        {
            return clsAdminsPaymentsData.DeleteAdminsPayments(AdminPaymentID);
        }


        public static bool IsAdminsPaymentsExist(int AdminPaymentID)
        {
            return clsAdminsPaymentsData.IsAdminsPaymentsExist(AdminPaymentID);
        }


        public static DataTable All()
        {
            return clsAdminsPaymentsData.AllAdminsPayments();
        }






    }
}
