using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_DataLayer
{
    public class clsCustomersInvoicesData
    {
        public static int AddNewCustomersInvoices(int CustomerID, int OrderID, DateTime InvoiceDate, float Amount, int StatusID)
        {

            int DefultInvoiceID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "insert into CustomersInvoices values (@CustomerID,@OrderID,@InvoiceDate,@Amount,@StatusID) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);
                        Command.Parameters.AddWithValue("@Amount", Amount);
                        Command.Parameters.AddWithValue("@StatusID", StatusID);
                        Command.Parameters.AddWithValue("@OrderID", OrderID);
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


        public static bool FindCustomersInvoices(ref int InvoiceID, ref int CustomerID,ref int OrderID, ref DateTime InvoiceDate, ref float Amount, ref int StatusID)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  CustomersInvoices where InvoiceID =@InvoiceID";

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
                                InvoiceDate = (DateTime)Reader["InvoiceDate"];
                                Amount = Convert.ToSingle( Reader["Amount"]);
                                StatusID = (int)Reader["StatusID"];
                                OrderID = (int)Reader["OrderID"];
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


        public static bool UpdateCustomersInvoices( int InvoiceID,  int CustomerID, int OrderID, DateTime InvoiceDate,  float Amount,  int StatusID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update CustomersInvoices set CustomerID =@CustomerID , OrderID=@OrderID , InvoiceDate =@InvoiceDate , Amount =@Amount , StatusID =@StatusID where InvoiceID =@InvoiceID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);
                        Command.Parameters.AddWithValue("@Amount", Amount);
                        Command.Parameters.AddWithValue("@StatusID", StatusID);
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


        public static bool DeleteCustomersInvoices(int InvoiceID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "Delete from CustomersInvoices where InvoiceID=@InvoiceID";

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


        public static bool IsCustomersInvoicesExist(int InvoiceID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select Found=1 from CustomersInvoices where InvoiceID=@InvoiceID";

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


        public static DataTable AllCustomersInvoices(int CustomerID)
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "SELECT dbo.CustomersInvoices.InvoiceID, dbo.Customers.Name, dbo.CustomersInvoices.InvoiceDate, dbo.CustomersInvoices.Amount, dbo.InvoicesStatus.Status" +
                        " FROM     dbo.CustomersInvoices INNER JOIN  " +
                        "  dbo.Customers ON dbo.CustomersInvoices.CustomerID = dbo.Customers.CustomerID INNER JOIN " +
                        "  dbo.InvoicesStatus ON dbo.CustomersInvoices.StatusID = dbo.InvoicesStatus.StatusID  where Customers.CustomerID=@CustomerID";

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


        public static bool ChangeInviceStatus(int InvoiceID, int StatusID)
        {
            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update CustomersInvoices set  StatusID =@StatusID where InvoiceID =@InvoiceID";

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
