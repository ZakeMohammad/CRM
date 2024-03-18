using CRM_BussinsLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CRM
{
    public class clsGlobal
    {
      


        public static bool EmailValidation(string Email) {

            string Pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(Pattern);
            return regex.IsMatch(Email);
        }

        public static bool PhoneValidation(string Phone) {
           
            string pattern = @"^\+?[0-9]+$";
           Regex regex = new Regex(pattern);
            return regex.IsMatch(Phone);
        }

        public static bool URLValidation(string URL)
        {
            string Pattern= @"^(https?|ftp):\/\/[^\s\/$.?#].[^\s]*$";
            Regex regex = new Regex(Pattern);
            return regex.IsMatch(URL);
        }


         public static DataTable GitAllCountrys()
        {
            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456");

            string Query = "SELECT * FROM Countres";

            SqlCommand Command = new SqlCommand(Query, Conniction);

            try
            {

                Conniction.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    dt.Load(Reader);

            }
            catch (Exception ex)
            {
            }
            finally
            {
                Conniction.Close();
            }
            return dt;
        }

        public static string GitCountryName(int CountryID)
        {
            string Name = "";

            try
            {

                using (SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {
                    string Query = @"SELECT * FROM Countres where CountryID=@CountryID";

                    using (SqlCommand Command = new SqlCommand(Query, Conniction))
                    {
                        Command.Parameters.AddWithValue("@CountryID", CountryID);

                        Conniction.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                                Name = Reader.GetString(1);
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
            
            return Name;
        }

        public static DataTable GitAllCurrency()
        {
            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456");

            string Query = "SELECT * FROM Currencyes";

            SqlCommand Command = new SqlCommand(Query, Conniction);

            try
            {

                Conniction.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    dt.Load(Reader);

            }
            catch (Exception ex)
            {
            }
            finally
            {
                Conniction.Close();
            }
            return dt;
        }

        public static string GitGategoryNameForProduct(int GategoryID)
        {
            string Name = "";

            try
            {

                using (SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {
                    string Query = @"SELECT * FROM ProductsGategory where GategoryID=@GategoryID";

                    using (SqlCommand Command = new SqlCommand(Query, Conniction))
                    {
                        Command.Parameters.AddWithValue("@GategoryID", GategoryID);

                        Conniction.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.Read())
                                Name = Reader.GetString(1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return Name;
        }


        public static bool LoginForCustomers(string CustomerNmae,string Password)
        {
            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {

                    string Querey = "select Found=1 from Customers where Name=@Name and Password=@Password";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Name", CustomerNmae);
                        Command.Parameters.AddWithValue("@Password", Password);

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

        public static bool LoginForAdmins(string Username, string Password)
        {
            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {

                    string Querey = "select Found=1 from Admins where Username=@Username and Paswoord=@Paswoord";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Username", Username);
                        Command.Parameters.AddWithValue("@Paswoord", Password);

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



        public static DataTable NamesOfProducts()
        {
            DataTable Names =new DataTable();

            try
            {

                using (SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {
                    string Query = @"SELECT Name FROM Products ";

                    using (SqlCommand Command = new SqlCommand(Query, Conniction))
                    {
                        
                        Conniction.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                Names.Load(Reader);


                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return Names;
        }
      
        public static DataTable NamesOfCustomers()
        {
            DataTable Names = new DataTable();

            try
            {

                using (SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {
                    string Query = @"SELECT Name FROM Customers ";

                    using (SqlCommand Command = new SqlCommand(Query, Conniction))
                    {

                        Conniction.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                Names.Load(Reader);

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return Names;
        }

        public static DataTable NamesOfPaymentMethods()
        {
            DataTable Names = new DataTable();

            try
            {

                using (SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {
                    string Query = @"SELECT MethodName FROM PaymentMethods ";

                    using (SqlCommand Command = new SqlCommand(Query, Conniction))
                    {

                        Conniction.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                Names.Load(Reader);

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return Names;
        }

        public static DataTable NamesOfPaymentGategory()
        {
            DataTable Names = new DataTable();

            try
            {

                using (SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {
                    string Query = "SELECT Name FROM PaymentGategorys ";

                    using (SqlCommand Command = new SqlCommand(Query, Conniction))
                    {

                        Conniction.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                                Names.Load(Reader);

                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return Names;
        }

        public static int GitNumberOfAllCustomers()
        {
            int Number = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {

                    string Querey = "select count(*) from Customers";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            Number = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return Number;
        }

        public static int GitNumberOfAllAdmins()
        {
            int Number = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {

                    string Querey = "select count(*) from Admins";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            Number = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return Number;
        }

        public static int GitNumberOfAllBankAccounts()
        {
            int Number = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {

                    string Querey = "select count(*) from BanksAccount";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            Number = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return Number;
        }


        public static int GitNumberOfAllCompanies()
        {
            int Number = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {

                    string Querey = "select count(*) from Companyes";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            Number = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return Number;
        }



        public static int GitNumberOfAllOrders()
        {
            int Number = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {

                    string Querey = "select count(*) from Orders";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            Number = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return Number;
        }


        public static int GitNumberOfAllProducts()
        {
            int Number = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {

                    string Querey = "select count(*) from Products";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            Number = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return Number;
        }


        public static int GitNumberOfAllPayments()
        {
            int Number = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {

                    string Querey = "select count(*) from Payments";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            Number = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return Number;
        }


        public static int GitNumberOfAllQuotes()
        {
            int Number = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456"))
                {

                    string Querey = "select count(*) from Quotes";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            Number = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return Number;
        }







        public static clsCustomers CurrentCustomer {  get; set; }

        public static clsAdmins CurrentAdmin {  get; set; }





    }
}
