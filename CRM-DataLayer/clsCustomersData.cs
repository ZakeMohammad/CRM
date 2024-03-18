using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace CRM_DataLayer
{
    public class clsCustomersData
    {
        public static int AddNewCustomers(string Name, int CompanyID, string Email, string Phone, string Adrress, string City, string State_Regoin, string Zip, int CountryID, int CurrencyID, int GroupID, string Password)
        {

            int DefultCustomerID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "insert into Customers values (@Name,@CompanyID,@Email,@Phone,@Adrress,@City,@State_Regoin,@Zip,@CountryID,@CurrencyID,@GroupID,@Password) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@CompanyID", CompanyID);
                        Command.Parameters.AddWithValue("@Email", Email);
                        Command.Parameters.AddWithValue("@Phone", Phone);
                        Command.Parameters.AddWithValue("@Adrress", Adrress);
                        Command.Parameters.AddWithValue("@City", City);
                        Command.Parameters.AddWithValue("@State_Regoin", State_Regoin);
                        Command.Parameters.AddWithValue("@Zip", Zip);
                        Command.Parameters.AddWithValue("@CountryID", CountryID);
                        Command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
                        Command.Parameters.AddWithValue("@GroupID", GroupID);
                        Command.Parameters.AddWithValue("@Password", Password);

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultCustomerID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultCustomerID;
        }


        public static bool FindCustomers(int CustomerID, ref string Name, ref int CompanyID, ref string Email, ref string Phone, ref string Adrress, ref string City, ref string State_Regoin, ref string Zip, ref int CountryID, ref int CurrencyID, ref int GroupID, ref string Password)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  Customers where CustomerID =@CustomerID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                CustomerID = (int)Reader["CustomerID"];
                                Name = (string)Reader["Name"];
                                CompanyID = (int)Reader["CompanyID"];
                                Email = (string)Reader["Email"];
                                Phone = (string)Reader["Phone"];
                                Adrress = (string)Reader["Adrress"];
                                City = (string)Reader["City"];
                                State_Regoin = (string)Reader["State_Regoin"];
                                Zip = (string)Reader["Zip"];
                                CountryID = (int)Reader["CountryID"];
                                CurrencyID = (int)Reader["CurrencyID"];
                                GroupID = (int)Reader["GroupID"];           
                                Password = (string)Reader["Password"];

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


        public static bool FindCustomers(ref int CustomerID, string Name, ref int CompanyID, ref string Email, ref string Phone, ref string Adrress, ref string City, ref string State_Regoin, ref string Zip, ref int CountryID, ref int CurrencyID, ref int GroupID, ref string Password)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  Customers where Name =@Name";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Name", Name);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                CustomerID = (int)Reader["CustomerID"];
                                Name = (string)Reader["Name"];
                                CompanyID = (int)Reader["CompanyID"];
                                Email = (string)Reader["Email"];
                                Phone = (string)Reader["Phone"];
                                Adrress = (string)Reader["Adrress"];
                                City = (string)Reader["City"];
                                State_Regoin = (string)Reader["State_Regoin"];
                                Zip = (string)Reader["Zip"];
                                CountryID = (int)Reader["CountryID"];
                                GroupID = (int)Reader["GroupID"];
                                CurrencyID = (int)Reader["CurrencyID"];                               
                                Password = (string)Reader["Password"];

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

        public static bool UpdateCustomers( int CustomerID,  string Name,  int CompanyID,  string Email,  string Phone,  string Adrress,  string City,  string State_Regoin,  string Zip,  int CountryID,  int CurrencyID,  int GroupID,  string Password)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update Customers set Name =@Name , CompanyID =@CompanyID , Email =@Email , Phone =@Phone , Adrress =@Adrress , City =@City , State_Regoin =@State_Regoin , Zip =@Zip , CountryID =@CountryID , CurrencyID =@CurrencyID , GroupID =@GroupID , Password =@Password where CustomerID =@CustomerID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@CompanyID", CompanyID);
                        Command.Parameters.AddWithValue("@Email", Email);
                        Command.Parameters.AddWithValue("@Phone", Phone);
                        Command.Parameters.AddWithValue("@Adrress", Adrress);
                        Command.Parameters.AddWithValue("@City", City);
                        Command.Parameters.AddWithValue("@State_Regoin", State_Regoin);
                        Command.Parameters.AddWithValue("@Zip", Zip);
                        Command.Parameters.AddWithValue("@CountryID", CountryID);
                        Command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
                        Command.Parameters.AddWithValue("@GroupID", GroupID);
                        Command.Parameters.AddWithValue("@Password", Password);

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


        public static bool DeleteCustomers(int CustomerID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "Delete from Customers where CustomerID=@CustomerID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);

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


        public static bool IsCustomersExist(int CustomerID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select Found=1 from Customers where CustomerID=@CustomerID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);

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


        public static DataTable AllCustomers()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from CustomersDetalies";

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

        public static int GitCustomerIDByName(string Name)
        {
            int CustomerID = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from Customers  where Name = @Name";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Name", Name);

                        Connection.Open();

                        CustomerID = Convert.ToInt32(Command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {

            }
            
            return CustomerID;
        }






    }
}
