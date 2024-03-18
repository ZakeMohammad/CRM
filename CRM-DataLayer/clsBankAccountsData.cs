using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CRM_DataLayer
{
    public class clsBanksAccountData
    {
        public enum enDepositOrExpense { Deposit, Expose }

        public static int AddNewBanksAccount(string AccountNumber, int CustomerID, float InitialBalance, string BankName, string BankURL, string Password, string Description)
        {

            int DefultAccountID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "insert into BanksAccount values (@AccountNumber,@CustomerID,@InitialBalance,@BankName,@BankURL,@Password,@Description); select SCOPE_IDENTITY();";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("@InitialBalance", InitialBalance);
                        Command.Parameters.AddWithValue("@BankName", BankName);
                        Command.Parameters.AddWithValue("@BankURL", BankURL);
                        Command.Parameters.AddWithValue("@Password", Password);
                        Command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultAccountID = (int)(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultAccountID;
        }


        public static bool FindBanksAccount(int AccountID, ref string AccountNumber, ref int CustomerID, ref float InitialBalance, ref string BankName, ref string BankURL, ref string Password, ref string Description)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  BanksAccount where AccountID =@AccountID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AccountID", AccountID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {
                               
                                IsFound = true;
                                AccountID = (int)Reader["AccountID"];
                                AccountNumber = (string)Reader["AccountNumber"];
                                CustomerID = (int)Reader["CustomerID"];
                                InitialBalance = Convert.ToSingle(Reader["InitialBalance"]);
                                BankName = (string)Reader["BankName"];
                                BankURL = (string)Reader["BankURL"];
                                Password = (string)Reader["Password"];
                                Description = Reader["Description"] != DBNull.Value ? (string)Reader["Description"] : null;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            return IsFound;
        }

        public static bool FindBanksAccount(ref int AccountID, string AccountNumber, ref int CustomerID, ref float InitialBalance, ref string BankName, ref string BankURL, ref string Password, ref string Description)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  BanksAccount where AccountNumber =@AccountNumber";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                AccountID = (int)Reader["AccountID"];
                                AccountNumber = (string)Reader["AccountNumber"];
                                CustomerID = (int)Reader["CustomerID"];
                                InitialBalance = Convert.ToSingle(Reader["InitialBalance"]);
                                BankName = (string)Reader["BankName"];
                                BankURL = (string)Reader["BankURL"];
                                Password = (string)Reader["Password"];
                                Description = Reader["Description"] != null ? (string)Reader["Description"] : null;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            return IsFound;
        }

        public static bool FindBanksAccount(ref int AccountID,ref string AccountNumber, int CustomerID, ref float InitialBalance, ref string BankName, ref string BankURL, ref string Password, ref string Description)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  BanksAccount where CustomerID =@CustomerID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                AccountID = (int)Reader["AccountID"];
                                AccountNumber = (string)Reader["AccountNumber"];
                                CustomerID = (int)Reader["CustomerID"];
                                InitialBalance = Convert.ToSingle(Reader["InitialBalance"]);
                                BankName = (string)Reader["BankName"];
                                BankURL = (string)Reader["BankURL"];
                                Password = (string)Reader["Password"];
                                Description = Reader["Description"] != DBNull.Value ? (string)Reader["Description"] : null;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            return IsFound;
        }


        public static bool UpdateBanksAccount( int AccountID,  string AccountNumber,  int CustomerID,  float InitialBalance,  string BankName,  string BankURL,  string Password,  string Description)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update BanksAccount set AccountNumber =@AccountNumber , CustomerID =@CustomerID , InitialBalance =@InitialBalance , BankName =@BankName , BankURL =@BankURL , Password =@Password , Description =@Description where AccountID =@AccountID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AccountID", AccountID);
                        Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("@InitialBalance", InitialBalance);
                        Command.Parameters.AddWithValue("@BankName", BankName);
                        Command.Parameters.AddWithValue("@BankURL", BankURL);
                        Command.Parameters.AddWithValue("@Password", Password);
                        Command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);

                        Connection.Open();

                        RowEffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return (RowEffected > 0);
        }


        public static bool DeleteBanksAccount(int AccountID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "Delete from BanksAccount where AccountID=@AccountID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AccountID", AccountID);

                        Connection.Open();

                        RowEffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return (RowEffected > 0);
        }


        public static bool IsBanksAccountExist(int AccountID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select Found=1 from BanksAccount where AccountID=@AccountID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AccountID", AccountID);

                        Connection.Open();

                        RowEffected = Convert.ToInt32(Command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return (RowEffected > 0);
        }
        
        public static bool IsBanksAccountExist(string AccountNumber)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = @"select Found=1 from BanksAccount where AccountNumber=@AccountNumber;";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

                        Connection.Open();

                        RowEffected = Convert.ToInt32(Command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return (RowEffected > 0);
        }

        public static DataTable AllBanksAccount()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from BankAccountsDetelis";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dt.Load(Reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return dt;
        }


        public static bool ProccesForDepositAndExpense(string AccountNumber,float Ammount,string Status)
        {
            int RowEffected = 0;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {
                    string Querey = "";

                    Querey = (Status=="Deposit") ? "update BanksAccount set InitialBalance+=@Ammount where AccountNumber=@AccountNumber" : "update BanksAccount set InitialBalance-=@Ammount where AccountNumber=@AccountNumber";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {
                        Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                        Command.Parameters.AddWithValue("@Ammount", Ammount);

                        Connection.Open();

                            RowEffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                RowEffected = 0;
            }

            return RowEffected > 0;
        }

        public static int AddTransaction(DateTime Date, string SourceAccountNumber, string DestinationAccountNumber, float Ammount, float SourceBalance, float DestinationBalance)
        {
          int TransactionID = 0;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {
                    string Querey = "insert into Transactions values (@Date,@SourceAccountNumber,@DestinationAccountNumber,@Ammount,@SourceBalance,@DestinationBlance);select SCOPE_IDENTITY();";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {
                        Command.Parameters.AddWithValue("@Date", Date);
                        Command.Parameters.AddWithValue("@SourceAccountNumber", SourceAccountNumber);
                        Command.Parameters.AddWithValue("@DestinationAccountNumber", DestinationAccountNumber);
                        Command.Parameters.AddWithValue("@Ammount", Ammount);
                        Command.Parameters.AddWithValue("@SourceBalance", SourceBalance);
                        Command.Parameters.AddWithValue("@DestinationBlance", DestinationBalance);

                        Connection.Open();

                       object Rustl=Command.ExecuteScalar();

                        TransactionID = (Rustl != null)?(int)Rustl : 0;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                TransactionID = 0;
            }
            return TransactionID;
        }

        public static bool Transfare(string SourceAccountNumber, string DestinationAccountNumber, float Ammount)
        {
            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update BanksAccount set  InitialBalance -=@InitialBalance where AccountNumber =@AccountNumber1  ;" +
                                    "update BanksAccount set  InitialBalance +=@InitialBalance where AccountNumber =@AccountNumber2 ;";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AccountNumber1", SourceAccountNumber);
                        Command.Parameters.AddWithValue("@AccountNumber2", DestinationAccountNumber);
                        Command.Parameters.AddWithValue("@InitialBalance", Ammount);                     

                        Connection.Open();

                        RowEffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return (RowEffected > 0);
        }

        public static float GitTotalBlances()
        {
            float TotalBlance = 0;
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select SUM(BanksAccount.InitialBalance) as TotalSum from BanksAccount ";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();

                        object  Ruslt=Command.ExecuteScalar();
                        TotalBlance=Convert.ToSingle(Ruslt);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return TotalBlance;

        }


        public static DataTable AllTransactions()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from Transactions";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dt.Load(Reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return dt;
        }


        public static DataTable AllTransactionsForThisAccount(string AccountNumber)
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from Transactions where SourceAccountNumber=@AccountNumber or DestinationAccountNumber=@AccountNumber";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();
                        Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                dt.Load(Reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return dt;
        }

    }
}
