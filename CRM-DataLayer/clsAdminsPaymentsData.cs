using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_DataLayer
{
    public class clsAdminsPaymentsData
    {
        public static int AddNewAdminsPayments(int InvoiceCustomerID, int PayByAdminID, int GategoryID, int? MethodID)
        {

            int DefultAdminPaymentID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "insert into AdminsPayments values (@InvoiceCustomerID,@PayByAdminID,@GategoryID,@MethodID) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@InvoiceCustomerID", InvoiceCustomerID);
                        Command.Parameters.AddWithValue("@PayByAdminID", PayByAdminID);
                        Command.Parameters.AddWithValue("@GategoryID", GategoryID);
                        Command.Parameters.AddWithValue("@MethodID", (object)MethodID ?? DBNull.Value);

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultAdminPaymentID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultAdminPaymentID;
        }


        public static bool FindAdminsPayments(ref int AdminPaymentID, ref int InvoiceCustomerID, ref int PayByAdminID, ref int GategoryID, ref int? MethodID)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  AdminsPayments where AdminPaymentID =@AdminPaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AdminPaymentID", AdminPaymentID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                AdminPaymentID = (int)Reader["AdminPaymentID"];
                                InvoiceCustomerID = (int)Reader["InvoiceCustomerID"];
                                PayByAdminID = (int)Reader["PayByAdminID"];
                                GategoryID = (int)Reader["GategoryID"];
                                MethodID = (int?)Reader["MethodID"];
                                MethodID = ((int?)((object)MethodID ?? DBNull.Value));

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


        public static bool UpdateAdminsPayments(int AdminPaymentID, int InvoiceCustomerID, int PayByAdminID, int GategoryID, int? MethodID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update AdminsPayments set InvoiceCustomerID =@InvoiceCustomerID , PayByAdminID =@PayByAdminID , GategoryID =@GategoryID , MethodID =@MethodID where AdminPaymentID =@AdminPaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AdminPaymentID", AdminPaymentID);
                        Command.Parameters.AddWithValue("@InvoiceCustomerID", InvoiceCustomerID);
                        Command.Parameters.AddWithValue("@PayByAdminID", PayByAdminID);
                        Command.Parameters.AddWithValue("@GategoryID", GategoryID);
                        Command.Parameters.AddWithValue("@MethodID", (object)MethodID ?? DBNull.Value);

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


        public static bool DeleteAdminsPayments(int AdminPaymentID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "Delete from AdminsPayments where AdminPaymentID=@AdminPaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AdminPaymentID", AdminPaymentID);

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


        public static bool IsAdminsPaymentsExist(int AdminPaymentID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select Found=1 from AdminsPayments where AdminPaymentID=@AdminPaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@AdminPaymentID", AdminPaymentID);

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


        public static DataTable AllAdminsPayments()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "SELECT " +
                        " AdminsPayments.AdminPaymentID," +
                        " Admins.Username," +
                        " Customers.Name," +
                        " PaymentMethods.MethodName," +
                        " PaymentGategorys.Name AS GategoryName," +
                        " CustomersInvoices.Amount " +
                        "FROM " +
                        "  Customers " +
                        "INNER JOIN " +
                        " AdminInvoices  ON Customers.CustomerID = AdminInvoices.CustomerID " +
                        "INNER JOIN " +
                        " CustomersInvoices  ON AdminInvoices.InvoiceIDForCustomer = CustomersInvoices.InvoiceID " +
                        "INNER JOIN " +
                        " AdminsPayments  ON CustomersInvoices.InvoiceID = AdminsPayments.InvoiceCustomerID " +
                        "INNER JOIN " +
                        " Admins  ON AdminsPayments.PayByAdminID = Admins.AdminID " +
                        "INNER JOIN " +
                        " PaymentMethods  ON AdminsPayments.MethodID = PaymentMethods.MethodID " +
                        "CROSS JOIN " +
                        "PaymentGategorys where AdminsPayments.GategoryID=PaymentGategorys.PaymentGategoryID ;";

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
