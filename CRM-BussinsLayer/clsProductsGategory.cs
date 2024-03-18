using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsProductsGategory
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int GategoryID { get; set; }
        public string GategoryName { get; set; }


        public clsProductsGategory()
        {
            Mode = enMode.Add;
            this.GategoryID = 0;
            this.GategoryName = null;

        }

        private clsProductsGategory(int GategoryID, string GategoryName)
        {
            Mode = enMode.Update;
            this.GategoryID = GategoryID;
            this.GategoryName = GategoryName;

        }


        private bool _AddNew()
        {
            this.GategoryID = clsProductsGategorysData.AddNewProductsGategory(this.GategoryName);

            return (this.GategoryID != null);
        }


        private bool _Update()
        {
            return clsProductsGategorysData.UpdateProductsGategory(this.GategoryID, this.GategoryName);
        }


        public static clsProductsGategory Find(int GategoryID)
        {
            string GategoryName = null;


            if (clsProductsGategorysData.FindProductsGategory(ref GategoryID, ref GategoryName))
                return new clsProductsGategory(GategoryID, GategoryName);
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


        public static bool Delete(int GategoryID)
        {
            return clsProductsGategorysData.DeleteProductsGategory(GategoryID);
        }


        public static bool IsProductsGategoryExist(int GategoryID)
        {
            return clsProductsGategorysData.IsProductsGategoryExist(GategoryID);
        }


        public static DataTable All()
        {
            return clsProductsGategorysData.AllProductsGategory();
        }



    }
}
