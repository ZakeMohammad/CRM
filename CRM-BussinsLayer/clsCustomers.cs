using CRM_BussinsLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CRM_DataLayer;
namespace CRM_BussinsLayer
{
    public class clsCustomers
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public int CompanyID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adrress { get; set; }
        public string City { get; set; }
        public string State_Regoin { get; set; }
        public string Zip { get; set; }
        public int CountryID { get; set; }
        public int CurrencyID { get; set; }
        public int GroupID { get; set; }
        public string Password { get; set; }
        public clsCompanyes Companye { get; }
        public clsGroups Group { get; }

        public clsCustomers()
        {
            Mode = enMode.Add;
            this.CustomerID = 0;
            this.Name = null;
            this.CompanyID = 0;
            this.Email = null;
            this.Phone = null;
            this.Adrress = null;
            this.City = null;
            this.State_Regoin = null;
            this.Zip = null;
            this.CountryID = 0;
            this.CurrencyID = 0;
            this.GroupID = 0;
            this.Password = null;

        }

        private clsCustomers(int CustomerID, string Name, int CompanyID, string Email, string Phone, string Adrress, string City, string State_Regoin, string Zip, int CountryID, int CurrencyID, int GroupID, string Password)
        {
            Mode = enMode.Update;
            this.CustomerID = CustomerID;
            this.Name = Name;
            this.CompanyID = CompanyID;
            this.Email = Email;
            this.Phone = Phone;
            this.Adrress = Adrress;
            this.City = City;
            this.State_Regoin = State_Regoin;
            this.Zip = Zip;
            this.CountryID = CountryID;
            this.CurrencyID = CurrencyID;
            this.GroupID = GroupID;
            this.Password = Password;
            this.Group = clsGroups.Find(GroupID);
            this.Companye = clsCompanyes.Find(CompanyID);
        }


        private bool _AddNew()
        {
            this.CustomerID = clsCustomersData.AddNewCustomers(this.Name, this.CompanyID, this.Email, this.Phone, this.Adrress, this.City, this.State_Regoin, this.Zip, this.CountryID, this.CurrencyID, this.GroupID, this.Password);

            return (this.CustomerID != null);
        }


        private bool _Update()
        {
            return clsCustomersData.UpdateCustomers(this.CustomerID, this.Name, this.CompanyID, this.Email, this.Phone, this.Adrress, this.City, this.State_Regoin, this.Zip, this.CountryID, this.CurrencyID, this.GroupID, this.Password);
        }


        public static clsCustomers Find(int CustomerID)
        {
            string Name = null;
            int CompanyID = 0;
            string Email = null;
            string Phone = null;
            string Adrress = null;
            string City = null;
            string State_Regoin = null;
            string Zip = null;
            int CountryID = 0;
            int CurrencyID = 0;
            int GroupID = 0;
            string Password = null;


            if (clsCustomersData.FindCustomers(CustomerID, ref Name, ref CompanyID, ref Email, ref Phone, ref Adrress, ref City, ref State_Regoin, ref Zip, ref CountryID, ref CurrencyID, ref GroupID, ref Password))
                return new clsCustomers(CustomerID, Name, CompanyID, Email, Phone, Adrress, City, State_Regoin, Zip, CountryID, CurrencyID, GroupID, Password);
            else
                return null;
        }


        public static clsCustomers Find(string Name)
        {
            int CustomerID = 0;
            int CompanyID = 0;
            string Email = null;
            string Phone = null;
            string Adrress = null;
            string City = null;
            string State_Regoin = null;
            string Zip = null;
            int CountryID = 0;
            int CurrencyID = 0;
            int GroupID = 0;
            string Password = null;


            if (clsCustomersData.FindCustomers( ref CustomerID,  Name, ref CompanyID, ref Email, ref Phone, ref Adrress, ref City, ref State_Regoin, ref Zip, ref CountryID, ref CurrencyID, ref GroupID, ref Password))
                return new clsCustomers(CustomerID, Name, CompanyID, Email, Phone, Adrress, City, State_Regoin, Zip, CountryID, CurrencyID, GroupID, Password);
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


        public static bool Delete(int CustomerID)
        {
            return clsCustomersData.DeleteCustomers(CustomerID);
        }


        public static bool IsCustomersExist(int CustomerID)
        {
            return clsCustomersData.IsCustomersExist(CustomerID);
        }


        public static DataTable All()
        {
            return clsCustomersData.AllCustomers();
        }
        public static int GitCustomerIDByName(string Name)
        {
            return clsCustomersData.GitCustomerIDByName(Name);
        }


    }
}
