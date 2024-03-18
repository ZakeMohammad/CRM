using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CRM_DataLayer
{
    public class clsOrdersData
    {
        public static int AddNewOrders(int CustomerID, int? ProductID, int Quantity, float Price, int StatusID)
        {

            int DefultOrderID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "insert into Orders values (@CustomerID,@ProductID,@Quantity,@Price,@StatusID); select SCOPE_IDENTITY();";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("@ProductID", (object)ProductID ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Quantity", Quantity);
                        Command.Parameters.AddWithValue("@Price", Price);
                        Command.Parameters.AddWithValue("@StatusID", StatusID);

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultOrderID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultOrderID;
        }


        public static bool FindOrders(ref int OrderID, ref int CustomerID, ref int? ProductID, ref int Quantity, ref float Price, ref int StatusID)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  Orders where OrderID =@OrderID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@OrderID", OrderID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                OrderID = (int)Reader["OrderID"];
                                CustomerID = (int)Reader["CustomerID"];
                                ProductID = (int?)Reader["ProductID"];
                                ProductID = ((int?)((object)ProductID ?? DBNull.Value));                               
                                Quantity = (int)Reader["Quantity"];
                                Price = Convert.ToSingle(Reader["Price"]);
                                StatusID = (int)Reader["StatusID"];

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


        public static bool UpdateOrders( int OrderID,  int CustomerID,  int? ProductID,  int Quantity,  float Price,  int StatusID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update Orders set CustomerID =@CustomerID , ProductID =@ProductID  , Quantity =@Quantity , Price =@Price , StatusID =@StatusID where OrderID =@OrderID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@OrderID", OrderID);
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("@ProductID", (object)ProductID ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Quantity", Quantity);
                        Command.Parameters.AddWithValue("@Price", Price);
                        Command.Parameters.AddWithValue("@StatusID", StatusID);

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


        public static bool DeleteOrders(int OrderID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "Delete from Orders where OrderID=@OrderID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@OrderID", OrderID);

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


        public static bool IsOrdersExist(int OrderID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select Found=1 from Orders where OrderID=@OrderID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@OrderID", OrderID);

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


        public static DataTable AllOrders()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from OrderDetelis";

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

        public static DataTable OrderDetelis(int CustomerID)
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "SELECT Orders.OrderID, Customers.Name, Products.Name AS ProductName, Orders.Quantity, Orders.Price, OrdersStatus.Status " +
                        "FROM     Customers INNER JOIN  Orders ON Customers.CustomerID = Orders.CustomerID INNER JOIN" +
                        "   Products ON Orders.ProductID = Products.ProductID INNER JOIN" +
                        "  OrdersStatus ON Orders.StatusID = OrdersStatus.StatusID  where Customers.CustomerID=@CustomerID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);

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


        public static bool ChangeOrderStatus(int OrderID,int StatusID)
        {
            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update Orders set  StatusID = @StatusID where OrderID =@OrderID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@OrderID", OrderID);
                        Command.Parameters.AddWithValue("@StatusID", StatusID);

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

        public static bool IsOrderAcitve(int OrderID)
        {
            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select Found=1 from Orders where StatusID=2 and OrderID=@OrderID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@OrderID", OrderID);

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
