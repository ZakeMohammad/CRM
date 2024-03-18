using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsPaymentGategorys
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int PaymentGategoryID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }


        public clsPaymentGategorys()
        {
            Mode = enMode.Add;
            this.PaymentGategoryID = 0;
            this.Name = null;
            this.Image = null;

        }

        private clsPaymentGategorys(int PaymentGategoryID, string Name, string Image)
        {
            Mode = enMode.Update;
            this.PaymentGategoryID = PaymentGategoryID;
            this.Name = Name;
            this.Image = Image;

        }


        private bool _AddNew()
        {
            this.PaymentGategoryID = clsPaymentGategorysData.AddNewPaymentGategorys(this.Name, this.Image);

            return (this.PaymentGategoryID != null);
        }


        private bool _Update()
        {
            return clsPaymentGategorysData.UpdatePaymentGategorys(this.PaymentGategoryID, this.Name, this.Image);
        }


        public static clsPaymentGategorys Find(int PaymentGategoryID)
        {
            string Name = null;
            string Image = null;


            if (clsPaymentGategorysData.FindPaymentGategorys(ref PaymentGategoryID, ref Name, ref Image))
                return new clsPaymentGategorys(PaymentGategoryID, Name, Image);
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


        public static bool Delete(int PaymentGategoryID)
        {
            return clsPaymentGategorysData.DeletePaymentGategorys(PaymentGategoryID);
        }


        public static bool IsPaymentGategorysExist(int PaymentGategoryID)
        {
            return clsPaymentGategorysData.IsPaymentGategorysExist(PaymentGategoryID);
        }


        public static DataTable All()
        {
            return clsPaymentGategorysData.AllPaymentGategorys();
        }



    }
}
