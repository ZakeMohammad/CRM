using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CRM_DataLayer
{
    public class clsProductsData
    {
        public static int AddNewProducts(string Name, float SalesPrice, string Description, int NumberOfProduct, int GategoryID)
        {

            int DefultProductID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "insert into Products values (@Name,@SalesPrice,@Description,@NumberOfProduct,@GategoryID) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@SalesPrice", SalesPrice);
                        Command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@NumberOfProduct", NumberOfProduct);
                        Command.Parameters.AddWithValue("@GategoryID", GategoryID);

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultProductID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultProductID;
        }


        public static bool FindProducts( int ProductID, ref string Name, ref float SalesPrice, ref string Description, ref int NumberOfProduct, ref int GategoryID)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  Products where ProductID =@ProductID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@ProductID", ProductID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                ProductID = (int)Reader["ProductID"];
                                Name = (string)Reader["Name"];
                                SalesPrice = Convert.ToSingle( Reader["SalesPrice"]);
                                Description = Reader["Description"] != DBNull.Value ? (string)Reader["Description"] : null;
                                NumberOfProduct = (int)Reader["NumberOfProduct"];
                                GategoryID = (int)Reader["GategoryID"];

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


        public static bool FindProducts(ref int ProductID, string Name, ref float SalesPrice, ref string Description, ref int NumberOfProduct, ref int GategoryID)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  Products where Name =@Name";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@Name", Name);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                ProductID = (int)Reader["ProductID"];
                                Name = (string)Reader["Name"];
                                SalesPrice = Convert.ToSingle(Reader["SalesPrice"]);
                                Description = Reader["Description"] != DBNull.Value ? (string)Reader["Description"] : null;
                                NumberOfProduct = (int)Reader["NumberOfProduct"];
                                GategoryID = (int)Reader["GategoryID"];

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



        public static bool UpdateProducts( int ProductID,  string Name,  float SalesPrice,  string Description,  int NumberOfProduct,  int GategoryID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update Products set Name =@Name , SalesPrice =@SalesPrice , Description =@Description , NumberOfProduct =@NumberOfProduct , GategoryID =@GategoryID where ProductID =@ProductID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@ProductID", ProductID);
                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@SalesPrice", SalesPrice);
                        Command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@NumberOfProduct", NumberOfProduct);
                        Command.Parameters.AddWithValue("@GategoryID", GategoryID);

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


        public static bool DeleteProducts(int ProductID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "Delete from Products where ProductID=@ProductID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@ProductID", ProductID);

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


        public static bool IsProductsExist(int ProductID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select Found=1 from Products where ProductID=@ProductID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@ProductID", ProductID);

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


        public static DataTable AllProducts()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from Products";

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


        public static bool ChangeNumberOfProduct(int ProductID,int NumberOfProduct,int Status)
        {
            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {
                    string Querey = "";
                    if (Status==1)
                       Querey = "update Products set NumberOfProduct +=@NumberOfProduct where ProductID =@ProductID";
                    if(Status==2)
                        Querey = "update Products set NumberOfProduct -=@NumberOfProduct where ProductID =@ProductID";


                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@ProductID", ProductID);                      
                        Command.Parameters.AddWithValue("@NumberOfProduct", NumberOfProduct);
           
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


        public static bool IsProductSoludOutOrCustomerOrderMoreThanValuabelProducts(int ProductID,int NumberOfProduct)
        {
            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select Found=1 from Products where ProductID=@ProductID and (NumberOfProduct < @NumberOfProduct  or NumberOfProduct = 0 )";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@ProductID", ProductID);
                        Command.Parameters.AddWithValue("@NumberOfProduct", NumberOfProduct);
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

    }
}
