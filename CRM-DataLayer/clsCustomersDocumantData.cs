using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_DataLayer
{
    public class clsCustomersDocumantData
    {
        public static int AddNewCustomersDocumant(int CustomerID,string Titel, string Path)
        {

            int DefultDocumantID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "insert into CustomersDocumant values (@CustomerID,@Titel,@Path) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Titel", Titel);
                        Command.Parameters.AddWithValue("@Path", Path);
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultDocumantID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultDocumantID;
        }


        public static bool FindCustomersDocumant(ref int DocumantID,ref int CustomerID, ref string Titel, ref string Path)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  CustomersDocumant where DocumantID =@DocumantID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@DocumantID", DocumantID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                DocumantID = (int)Reader["DocumantID"];
                                Titel = (string)Reader["Titel"];
                                Path = (string)Reader["Path"];
                                CustomerID = (int)Reader["CustomerID"];
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


        public static bool UpdateCustomersDocumant(int DocumantID, int CustomerID, string Titel, string Path)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update CustomersDocumant set CustomerID=@CustomerID , Titel =@Titel , Path =@Path where DocumantID =@DocumantID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@DocumantID", DocumantID);
                        Command.Parameters.AddWithValue("@Titel", Titel);
                        Command.Parameters.AddWithValue("@Path", Path);
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


        public static bool DeleteCustomersDocumant(int DocumantID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "Delete from CustomersDocumant where DocumantID=@DocumantID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@DocumantID", DocumantID);

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


        public static bool IsCustomersDocumantExist(int DocumantID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select Found=1 from CustomersDocumant where DocumantID=@DocumantID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@DocumantID", DocumantID);

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


        public static DataTable AllCustomersDocumant(int CustomerID)
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from CustomersDocumant where CustomerID=@CustomerID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Connection.Open();

                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);

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
