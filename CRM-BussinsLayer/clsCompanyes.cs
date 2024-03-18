using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsCompanyes
    {
        public enum enMode { Add, Update }
        public enMode Mode;
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string URL { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        private clsCompanyes(int CompanyID, string CompanyName, string URL, string Email, string Phone)
        {
            this.CompanyID = CompanyID;
            this.CompanyName = CompanyName;
            this.URL = URL;
            this.Email = Email;
            this.Phone = Phone;
            this.Mode = enMode.Update;
        }
        public clsCompanyes()
        {
            this.CompanyID = -1;
            this.CompanyName = "";
            this.URL = "";
            this.Email = "";
            this.Phone = "";
            this.Mode = enMode.Add;
        }
        private bool _AddCompanyes()
        {
            this.CompanyID = clsCompanyesData.AddNewCompanyes(this.CompanyName, this.URL, this.Email, this.Phone);
            return (this.CompanyID != -1);
        }
        private bool _UpdateCompanyes()
        {
            return clsCompanyesData.UpdateCompanyes(this.CompanyID, this.CompanyName, this.URL, this.Email, this.Phone);
        }
        public bool Save()
        {

            switch (Mode)
            {

                case enMode.Update:
                    {

                        return _UpdateCompanyes();

                    }
                case enMode.Add:
                    {

                        if (_AddCompanyes())

                        {
                            this.Mode = enMode.Update;

                            return true;
                        }
                        else

                            return false;
                    }
            }
            return false;
        }
        public static bool DeleteCompanyes(int CompanyID)
        {
            return clsCompanyesData.DeleteCompanyes(CompanyID);
        }
        public static DataTable GitAllCompanyes()
        {
            return clsCompanyesData.GitAllCompanyes();
        }
        public static clsCompanyes Find(int CompanyID)
        {
            string CompanyName = "";
            string URL = "";
            string Email = "";
            string Phone = "";
            if (clsCompanyesData.Find(CompanyID, ref CompanyName, ref URL, ref Email, ref Phone))
                return new clsCompanyes(CompanyID, CompanyName, URL, Email, Phone);
            else
                return null;
        }

    }
}
