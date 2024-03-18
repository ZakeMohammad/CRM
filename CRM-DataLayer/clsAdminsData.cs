using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CRM_DataLayer
{
    public class clsAdminsData
    {
        public static int AddNewAdmins(string Username, string Paswoord, string Name, string Email, string Phone, string Adrress, string City, int CountryID, int CompanyID, int Permissoins)
        {

            int DefultAdminID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "insert into Admins values (@Username,@Paswoord,@Name,@Email,@Phone,@Adrress,@City,@CountryID,@CompanyID,@Permissoins) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Username", Username);
                        Command.Parameters.AddWithValue("@Paswoord", Paswoord);
                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@Email", Email);
                        Command.Parameters.AddWithValue("@Phone", Phone);
                        Command.Parameters.AddWithValue("@Adrress", Adrress);
                        Command.Parameters.AddWithValue("@City", City);
                        Command.Parameters.AddWithValue("@CountryID", CountryID);
                        Command.Parameters.AddWithValue("@CompanyID", CompanyID);
                        Command.Parameters.AddWithValue("@Permissoins", Permissoins);

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultAdminID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultAdminID;
        }


        public static bool FindAdmins( int AdminID, ref string Username, ref string Paswoord, ref string Name, ref string Email, ref string Phone, ref string Adrress, ref string City, ref int CountryID, ref int CompanyID, ref int Permissoins)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  Admins where AdminID =@AdminID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AdminID", AdminID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                AdminID = (int)Reader["AdminID"];
                                Username = (string)Reader["Username"];
                                Paswoord = (string)Reader["Paswoord"];
                                Name = (string)Reader["Name"];
                                Email = (string)Reader["Email"];
                                Phone = (string)Reader["Phone"];
                                Adrress = (string)Reader["Adrress"];
                                City = (string)Reader["City"];
                                CountryID = (int)Reader["CountryID"];
                                CompanyID = (int)Reader["CompanyID"];
                                Permissoins = (int)Reader["Permissoins"];

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

        public static bool FindAdmins(ref int AdminID,  string Username, ref string Paswoord, ref string Name, ref string Email, ref string Phone, ref string Adrress, ref string City, ref int CountryID, ref int CompanyID, ref int Permissoins)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  Admins where Username =@Username";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Username", Username);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                AdminID = (int)Reader["AdminID"];
                                Username = (string)Reader["Username"];
                                Paswoord = (string)Reader["Paswoord"];
                                Name = (string)Reader["Name"];
                                Email = (string)Reader["Email"];
                                Phone = (string)Reader["Phone"];
                                Adrress = (string)Reader["Adrress"];
                                City = (string)Reader["City"];
                                CountryID = (int)Reader["CountryID"];
                                CompanyID = (int)Reader["CompanyID"];
                                Permissoins = (int)Reader["Permissoins"];

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


        public static bool UpdateAdmins( int AdminID,  string Username,  string Paswoord,  string Name,  string Email,  string Phone,  string Adrress,  string City,  int CountryID,  int CompanyID,  int Permissoins)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update Admins set Username =@Username , Paswoord =@Paswoord , Name =@Name , Email =@Email , Phone =@Phone , Adrress =@Adrress , City =@City , CountryID =@CountryID , CompanyID =@CompanyID , Permissoins =@Permissoins where AdminID =@AdminID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AdminID", AdminID);
                        Command.Parameters.AddWithValue("@Username", Username);
                        Command.Parameters.AddWithValue("@Paswoord", Paswoord);
                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@Email", Email);
                        Command.Parameters.AddWithValue("@Phone", Phone);
                        Command.Parameters.AddWithValue("@Adrress", Adrress);
                        Command.Parameters.AddWithValue("@City", City);
                        Command.Parameters.AddWithValue("@CountryID", CountryID);
                        Command.Parameters.AddWithValue("@CompanyID", CompanyID);
                        Command.Parameters.AddWithValue("@Permissoins", Permissoins);

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


        public static bool DeleteAdmins(int AdminID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "Delete from Admins where AdminID=@AdminID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AdminID", AdminID);

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


        public static bool IsAdminsExist(int AdminID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select Found=1 from Admins where AdminID=@AdminID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AdminID", AdminID);

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


        public static DataTable AllAdmins()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from AdminsInfo";

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


    }
}
