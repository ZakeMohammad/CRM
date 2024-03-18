using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsServices
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int ServiceID { get; set; }
        public string Name { get; set; }
        public float SalesPrice { get; set; }
        public string Descriptoin { get; set; }


        public clsServices()
        {
            Mode = enMode.Add;
            this.ServiceID = 0;
            this.Name = null;
            this.SalesPrice = 0;
            this.Descriptoin = null;

        }

        private clsServices(int ServiceID, string Name, float SalesPrice, string Descriptoin)
        {
            Mode = enMode.Update;
            this.ServiceID = ServiceID;
            this.Name = Name;
            this.SalesPrice = SalesPrice;
            this.Descriptoin = Descriptoin;

        }


        private bool _AddNew()
        {
            this.ServiceID = clsServicesData.AddNewServices(this.Name, this.SalesPrice, this.Descriptoin);

            return (this.ServiceID != null);
        }


        private bool _Update()
        {
            return clsServicesData.UpdateServices(this.ServiceID, this.Name, this.SalesPrice, this.Descriptoin);
        }


        public static clsServices Find(int ServiceID)
        {
            string Name = null;
            float SalesPrice = 0;
            string Descriptoin = null;


            if (clsServicesData.FindServices(ref ServiceID, ref Name, ref SalesPrice, ref Descriptoin))
                return new clsServices(ServiceID, Name, SalesPrice, Descriptoin);
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


        public static bool Delete(int ServiceID)
        {
            return clsServicesData.DeleteServices(ServiceID);
        }


        public static bool IsServicesExist(int ServiceID)
        {
            return clsServicesData.IsServicesExist(ServiceID);
        }


        public static DataTable All()
        {
            return clsServicesData.AllServices();
        }





    }
}
