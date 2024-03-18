using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsAdmins
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int AdminID { get; set; }
        public string Username { get; set; }
        public string Paswoord { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adrress { get; set; }
        public string City { get; set; }
        public int CountryID { get; set; }
        public int CompanyID { get; set; }
        public int Permissoins { get; set; }


        public clsCompanyes Company { get; }

        public clsAdmins()
        {
            Mode = enMode.Add;
            this.AdminID = 0;
            this.Username = null;
            this.Paswoord = null;
            this.Name = null;
            this.Email = null;
            this.Phone = null;
            this.Adrress = null;
            this.City = null;
            this.CountryID = 0;
            this.CompanyID = 0;
            this.Permissoins = 0;

        }

        private clsAdmins(int AdminID, string Username, string Paswoord, string Name, string Email, string Phone, string Adrress, string City, int CountryID, int CompanyID, int Permissoins)
        {
            Mode = enMode.Update;
            this.AdminID = AdminID;
            this.Username = Username;
            this.Paswoord = Paswoord;
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
            this.Adrress = Adrress;
            this.City = City;
            this.CountryID = CountryID;
            this.CompanyID = CompanyID;
            this.Permissoins = Permissoins;
            Company = clsCompanyes.Find(CompanyID);

        }


        private bool _AddNew()
        {
            this.AdminID = clsAdminsData.AddNewAdmins(this.Username, this.Paswoord, this.Name, this.Email, this.Phone, this.Adrress, this.City, this.CountryID, this.CompanyID, this.Permissoins);

            return (this.AdminID != null);
        }


        private bool _Update()
        {
            return clsAdminsData.UpdateAdmins(this.AdminID, this.Username, this.Paswoord, this.Name, this.Email, this.Phone, this.Adrress, this.City, this.CountryID, this.CompanyID, this.Permissoins);
        }


        public static clsAdmins Find(int AdminID)
        {
            string Username = null;
            string Paswoord = null;
            string Name = null;
            string Email = null;
            string Phone = null;
            string Adrress = null;
            string City = null;
            int CountryID = 0;
            int CompanyID = 0;
            int Permissoins = 0;


            if (clsAdminsData.FindAdmins(AdminID, ref Username, ref Paswoord, ref Name, ref Email, ref Phone, ref Adrress, ref City, ref CountryID, ref CompanyID, ref Permissoins))
                return new clsAdmins(AdminID, Username, Paswoord, Name, Email, Phone, Adrress, City, CountryID, CompanyID, Permissoins);
            else
                return null;
        }
        public static clsAdmins Find(string Username)
        {
            int AdminID = 0;    
            string Paswoord = null;
            string Name = null;
            string Email = null;
            string Phone = null;
            string Adrress = null;
            string City = null;
            int CountryID = 0;
            int CompanyID = 0;
            int Permissoins = 0;


            if (clsAdminsData.FindAdmins(ref AdminID, Username, ref Paswoord, ref Name, ref Email, ref Phone, ref Adrress, ref City, ref CountryID, ref CompanyID, ref Permissoins))
                return new clsAdmins(AdminID, Username, Paswoord, Name, Email, Phone, Adrress, City, CountryID, CompanyID, Permissoins);
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


        public static bool Delete(int AdminID)
        {
            return clsAdminsData.DeleteAdmins(AdminID);
        }


        public static bool IsAdminsExist(int AdminID)
        {
            return clsAdminsData.IsAdminsExist(AdminID);
        }


        public static DataTable All()
        {
            return clsAdminsData.AllAdmins();
        }



    }
}
