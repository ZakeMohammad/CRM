using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsCustomersDocumant
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int DocumantID { get; set; }
        public string Titel { get; set; }
        public string Path { get; set; }

        public int CustomerID { get; set; }
        public clsCustomersDocumant()
        {
            Mode = enMode.Add;
            this.DocumantID = 0;
            this.Titel = null;
            this.Path = null;
            this.CustomerID = 0;
        }

        private clsCustomersDocumant(int DocumantID,int CustomerID, string Titel, string Path)
        {
            Mode = enMode.Update;
            this.DocumantID = DocumantID;
            this.CustomerID=CustomerID;
            this.Titel = Titel;
            this.Path = Path;

        }


        private bool _AddNew()
        {
            this.DocumantID = clsCustomersDocumantData.AddNewCustomersDocumant(this.CustomerID,this.Titel, this.Path);

            return (this.DocumantID != null);
        }


        private bool _Update()
        {
            return clsCustomersDocumantData.UpdateCustomersDocumant(this.DocumantID, this.CustomerID,this.Titel, this.Path);
        }


        public static clsCustomersDocumant Find(int DocumantID)
        {
            string Titel = null;
            string Path = null;
            int CustomerID = 0;

            if (clsCustomersDocumantData.FindCustomersDocumant(ref DocumantID,ref CustomerID, ref Titel, ref Path))
                return new clsCustomersDocumant(DocumantID, CustomerID, Titel, Path);
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


        public static bool Delete(int DocumantID)
        {
            return clsCustomersDocumantData.DeleteCustomersDocumant(DocumantID);
        }


        public static bool IsCustomersDocumantExist(int DocumantID)
        {
            return clsCustomersDocumantData.IsCustomersDocumantExist(DocumantID);
        }


        public static DataTable All(int CustomerID)
        {
            return clsCustomersDocumantData.AllCustomersDocumant(CustomerID);
        }



    }
}
