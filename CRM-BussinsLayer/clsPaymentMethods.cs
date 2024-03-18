using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsPaymentMethods
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int MethodID { get; set; }
        public string MethodName { get; set; }
        public string Image { get; set; }


        public clsPaymentMethods()
        {
            Mode = enMode.Add;
            this.MethodID = 0;
            this.MethodName = null;
            this.Image = null;

        }

        private clsPaymentMethods(int MethodID, string MethodName, string Image)
        {
            Mode = enMode.Update;
            this.MethodID = MethodID;
            this.MethodName = MethodName;
            this.Image = Image;

        }


        private bool _AddNew()
        {
            this.MethodID = clsPaymentMethodsData.AddNewPaymentMethods(this.MethodName, this.Image);

            return (this.MethodID != null);
        }


        private bool _Update()
        {
            return clsPaymentMethodsData.UpdatePaymentMethods(this.MethodID, this.MethodName, this.Image);
        }


        public static clsPaymentMethods Find(int MethodID)
        {
            string MethodName = null;
            string Image = null;


            if (clsPaymentMethodsData.FindPaymentMethods(ref MethodID, ref MethodName, ref Image))
                return new clsPaymentMethods(MethodID, MethodName, Image);
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


        public static bool Delete(int MethodID)
        {
            return clsPaymentMethodsData.DeletePaymentMethods(MethodID);
        }


        public static bool IsPaymentMethodsExist(int MethodID)
        {
            return clsPaymentMethodsData.IsPaymentMethodsExist(MethodID);
        }


        public static DataTable All()
        {
            return clsPaymentMethodsData.AllPaymentMethods();
        }



    }
}
