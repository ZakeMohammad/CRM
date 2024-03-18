using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsProducts
    {

        public enum enMode { Add, Update }
        enMode Mode;
        public int ProductID { get; set; }
        public string Name { get; set; }
        public float SalesPrice { get; set; }
        public string Description { get; set; }
        public int NumberOfProduct { get; set; }
        public int GategoryID { get; set; }


        public clsProducts()
        {
            Mode = enMode.Add;
            this.ProductID = 0;
            this.Name = null;
            this.SalesPrice = 0;
            this.Description = null;
            this.NumberOfProduct = 0;
            this.GategoryID = 0;

        }

        private clsProducts(int ProductID, string Name, float SalesPrice, string Description, int NumberOfProduct, int GategoryID)
        {
            Mode = enMode.Update;
            this.ProductID = ProductID;
            this.Name = Name;
            this.SalesPrice = SalesPrice;
            this.Description = Description;
            this.NumberOfProduct = NumberOfProduct;
            this.GategoryID = GategoryID;

        }


        private bool _AddNew()
        {
            this.ProductID = clsProductsData.AddNewProducts(this.Name, this.SalesPrice, this.Description, this.NumberOfProduct, this.GategoryID);

            return (this.ProductID != null);
        }


        private bool _Update()
        {
            return clsProductsData.UpdateProducts(this.ProductID, this.Name, this.SalesPrice, this.Description, this.NumberOfProduct, this.GategoryID);
        }


        public static clsProducts Find(int ProductID)
        {
            string Name = null;
            float SalesPrice = 0;
            string Description = null;
            int NumberOfProduct = 0;
            int GategoryID = 0;


            if (clsProductsData.FindProducts( ProductID, ref Name, ref SalesPrice, ref Description, ref NumberOfProduct, ref GategoryID))
                return new clsProducts(ProductID, Name, SalesPrice, Description, NumberOfProduct, GategoryID);
            else
                return null;
        }
        public static clsProducts Find(string Name)
        {
            int ProductID = 0;  
            float SalesPrice = 0;
            string Description = null;
            int NumberOfProduct = 0;
            int GategoryID = 0;


            if (clsProductsData.FindProducts(ref ProductID,  Name, ref SalesPrice, ref Description, ref NumberOfProduct, ref GategoryID))
                return new clsProducts(ProductID, Name, SalesPrice, Description, NumberOfProduct, GategoryID);
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


        public static bool Delete(int ProductID)
        {
            return clsProductsData.DeleteProducts(ProductID);
        }


        public static bool IsProductsExist(int ProductID)
        {
            return clsProductsData.IsProductsExist(ProductID);
        }


        public static DataTable All()
        {
            return clsProductsData.AllProducts();
        }



        public bool ChangeNumberOfProduct(int NumberOfProduct, int Status)
        {
            return clsProductsData.ChangeNumberOfProduct(this.ProductID,NumberOfProduct, Status);
        }


        public bool IsProductSoludOut(int NumberOfProduct)
        {
            return clsProductsData.IsProductSoludOutOrCustomerOrderMoreThanValuabelProducts(this.ProductID, NumberOfProduct);
        }
       
    }
}
