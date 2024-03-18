using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_DataLayer
{
    public class clsAdminInvoicesData
    {
        public static int AddNewAdminInvoices(int CustomerID, int OrderID, int StatusID, int? InvoiceIDForCustomer, DateTime InvoiceDate, float Amount, float? Tax)
        {

            int DefultInvoiceID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "insert into AdminInvoices values (@CustomerID,@OrderID,@StatusID,@InvoiceIDForCustomer,@InvoiceDate,@Amount,@Tax) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("@OrderID", OrderID);
                        Command.Parameters.AddWithValue("@StatusID", StatusID);
                        Command.Parameters.AddWithValue("@InvoiceIDForCustomer", (object)InvoiceIDForCustomer ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);
                        Command.Parameters.AddWithValue("@Amount", Amount);
                        Command.Parameters.AddWithValue("@Tax", (object)Tax ?? DBNull.Value);

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultInvoiceID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultInvoiceID;
        }


        public static bool FindAdminInvoices(ref int InvoiceID, ref int CustomerID, ref int OrderID, ref int StatusID, ref int? InvoiceIDForCustomer, ref DateTime InvoiceDate, ref float Amount, ref float? Tax)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  AdminInvoices where InvoiceID =@InvoiceID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@InvoiceID", InvoiceID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                InvoiceID = (int)Reader["InvoiceID"];
                                CustomerID = (int)Reader["CustomerID"];
                                OrderID = (int)Reader["OrderID"];
                                StatusID = (int)Reader["StatusID"];
                                InvoiceIDForCustomer = (int?)Reader["InvoiceIDForCustomer"];
                                InvoiceIDForCustomer = ((int?)((object)InvoiceIDForCustomer ?? DBNull.Value));
                                InvoiceDate = (DateTime)Reader["InvoiceDate"];
                                Amount = Convert.ToSingle(Reader["Amount"]);
                                //Tax = Convert.ToSingle(Reader["Tax"]);
                                if (Tax == null)
                                    Tax = 1;
                                else
                                Tax = Convert.ToSingle((object)Tax ?? DBNull.Value);

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


        public static bool UpdateAdminInvoices(int InvoiceID, int CustomerID, int OrderID, int StatusID, int? InvoiceIDForCustomer, DateTime InvoiceDate, float Amount, float? Tax)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update AdminInvoices set CustomerID =@CustomerID , OrderID =@OrderID , StatusID =@StatusID , InvoiceIDForCustomer =@InvoiceIDForCustomer , InvoiceDate =@InvoiceDate , Amount =@Amount , Tax =@Tax where InvoiceID =@InvoiceID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("@OrderID", OrderID);
                        Command.Parameters.AddWithValue("@StatusID", StatusID);
                        Command.Parameters.AddWithValue("@InvoiceIDForCustomer", (object)InvoiceIDForCustomer ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);
                        Command.Parameters.AddWithValue("@Amount", Amount);
                        Command.Parameters.AddWithValue("@Tax", (object)Tax ?? DBNull.Value);

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


        public static bool DeleteAdminInvoices(int InvoiceID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "Delete from AdminInvoices where InvoiceID=@InvoiceID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@InvoiceID", InvoiceID);

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


        public static bool IsAdminInvoicesExist(int InvoiceID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select Found=1 from AdminInvoices where InvoiceID=@InvoiceID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@InvoiceID", InvoiceID);

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


        public static DataTable AllAdminInvoices()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "SELECT AdminInvoices.InvoiceID, Customers.Name, Products.Name AS ProductName, InvoicesStatus.Status, AdminInvoices.InvoiceDate, AdminInvoices.Amount,AdminInvoices.InvoiceIDForCustomer " +
                        " FROM  AdminInvoices INNER JOIN   Customers ON AdminInvoices.CustomerID = Customers.CustomerID INNER JOIN " +
                        " Orders ON AdminInvoices.OrderID = Orders.OrderID AND Customers.CustomerID = Orders.CustomerID INNER JOIN " +
                        " InvoicesStatus ON AdminInvoices.StatusID = InvoicesStatus.StatusID INNER JOIN " +
                        " Products ON Orders.ProductID = Products.ProductID";

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


        public static bool ChangeInviceStatus(int InvoiceID, int StatusID)
        {
            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update AdminInvoices set  StatusID =@StatusID where InvoiceID =@InvoiceID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
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



    }
}
