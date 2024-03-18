using CRM_DataLayer;
using System;
using System.Data;

namespace CRM_BussinsLayer
{
    public class clsBanksAccount
    {
        public enum enMode { Add, Update }
        enMode Mode;

       // public enum enDepositOrExpense { Deposit,Expose}
       //public enDepositOrExpense ModeForTransactions=enDepositOrExpense.Deposit;
        public int AccountID { get; set; }
        public string AccountNumber { get; set; }
        public int CustomerID { get; set; }
        public float InitialBalance { get; set; }
        public string BankName { get; set; }
        public string BankURL { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public clsCustomers Customer { get; }

        

        public clsBanksAccount()
        {
            Mode = enMode.Add;
            this.AccountID = 0;
            this.AccountNumber = null;
            this.CustomerID = 0;
            this.InitialBalance = 0;
            this.BankName = null;
            this.BankURL = null;
            this.Password = null;
            this.Description = null;

        }

        private clsBanksAccount(int AccountID, string AccountNumber, int CustomerID, float InitialBalance, string BankName, string BankURL, string Password, string Description)
        {
            Mode = enMode.Update;
            this.AccountID = AccountID;
            this.AccountNumber = AccountNumber;
            this.CustomerID = CustomerID;
            this.InitialBalance = InitialBalance;
            this.BankName = BankName;
            this.BankURL = BankURL;
            this.Password = Password;
            this.Description = Description;
            this.Customer = clsCustomers.Find(CustomerID);
        }


        private bool _AddNew()
        {
            this.AccountID = clsBanksAccountData.AddNewBanksAccount(this.AccountNumber, this.CustomerID, this.InitialBalance, this.BankName, this.BankURL, this.Password, this.Description);

            return (this.AccountID != null);
        }


        private bool _Update()
        {
            return clsBanksAccountData.UpdateBanksAccount(this.AccountID, this.AccountNumber, this.CustomerID, this.InitialBalance, this.BankName, this.BankURL, this.Password, this.Description);
        }


        public static clsBanksAccount Find(int AccountID)
        {
           
            string AccountNumber = null;
            int CustomerID = 0;
            float InitialBalance = 0;
            string BankName = null;
            string BankURL = null;
            string Password = null;
            string Description = null;


            if (clsBanksAccountData.FindBanksAccount(AccountID, ref AccountNumber, ref CustomerID, ref InitialBalance, ref BankName, ref BankURL, ref Password, ref Description))
                return new clsBanksAccount(AccountID, AccountNumber, CustomerID, InitialBalance, BankName, BankURL, Password, Description);
            else
                return null;
        }

        public static clsBanksAccount Find(string AccountNumber)
        {

            int AccountID = 0;
            int CustomerID = 0;
            float InitialBalance = 0;
            string BankName = null;
            string BankURL = null;
            string Password = null;
            string Description = null;


            if (clsBanksAccountData.FindBanksAccount(ref AccountID,  AccountNumber, ref CustomerID, ref InitialBalance, ref BankName, ref BankURL, ref Password, ref Description))
                return new clsBanksAccount(AccountID, AccountNumber, CustomerID, InitialBalance, BankName, BankURL, Password, Description);
            else
                return null;
        }

        public static clsBanksAccount Find(int CustomerID,bool ThisForOnlyOverload=true)
        {

            int AccountID = 0;
           string AccountNumber = null;
            float InitialBalance = 0;
            string BankName = null;
            string BankURL = null;
            string Password = null;
            string Description = null;


            if (clsBanksAccountData.FindBanksAccount(ref AccountID,ref AccountNumber,  CustomerID, ref InitialBalance, ref BankName, ref BankURL, ref Password, ref Description))
                return new clsBanksAccount(AccountID, AccountNumber, CustomerID, InitialBalance, BankName, BankURL, Password, Description);
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
        public static bool Delete(int AccountID)
        {
            return clsBanksAccountData.DeleteBanksAccount(AccountID);
        }


        public static bool IsBanksAccountExist(int AccountID)
        {
            return clsBanksAccountData.IsBanksAccountExist(AccountID);
        }
        public static bool IsBanksAccountExist(string AccountNumber)
        {
            return clsBanksAccountData.IsBanksAccountExist(AccountNumber);
        }

        public static DataTable All()
        {
            return clsBanksAccountData.AllBanksAccount();
        }

        public static float GitTotalBlances()
        {
            return clsBanksAccountData.GitTotalBlances();
        }
        public bool Transfare(string DestinationAccountNumber, float Ammount)
        {
            if(this.InitialBalance<=Ammount)
                return false;
            return clsBanksAccountData.Transfare(this.AccountNumber, DestinationAccountNumber, Ammount);
        }

        public static int AddTransaction(DateTime Date, string SourceAccountNumber, string DestinationAccountNumber, float Ammount, float SourceBalance, float DestinationBalance)
        {
            return clsBanksAccountData.AddTransaction(Date, SourceAccountNumber, DestinationAccountNumber,Ammount, SourceBalance, DestinationBalance);
        }

        public bool Deposit(float Ammount)
        {
            //I Use Enums But Does Not Work...

            //ModeForTransactions = enDepositOrExpense.Deposit;

            return clsBanksAccountData.ProccesForDepositAndExpense(this.AccountNumber, Ammount, "Deposit"); 
        }

        public bool Expense(float Ammount)
        {
            return clsBanksAccountData.ProccesForDepositAndExpense(this.AccountNumber, Ammount, "Expense");
        }
        public static DataTable AllTransactions()
        {
            return clsBanksAccountData.AllTransactions();
        }


        public static DataTable AllTransactionsForThisAccount(string AccountNumber)
        {
            return clsBanksAccountData.AllTransactionsForThisAccount(AccountNumber);
        }

    }
}
