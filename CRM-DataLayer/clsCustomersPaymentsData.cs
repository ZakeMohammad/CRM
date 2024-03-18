using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_DataLayer
{
    public class clsCustomersPaymentsData
    {
        public static int AddNewCustomersPayments(int PaymentID)
        {

            int DefultCustomerPaymentID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "insert into CustomersPayments values (@PaymentID) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PaymentID", PaymentID);

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultCustomerPaymentID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultCustomerPaymentID;
        }


        public static bool FindCustomersPayments( int CustomerPaymentID, ref int PaymentID)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  CustomersPayments where CustomerPaymentID =@CustomerPaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@CustomerPaymentID", CustomerPaymentID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                CustomerPaymentID = (int)Reader["CustomerPaymentID"];
                                PaymentID = (int)Reader["PaymentID"];

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


        public static bool UpdateCustomersPayments( int CustomerPaymentID,  int PaymentID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update CustomersPayments set PaymentID =@PaymentID where CustomerPaymentID =@CustomerPaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@CustomerPaymentID", CustomerPaymentID);
                        Command.Parameters.AddWithValue("@PaymentID", PaymentID);

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


        public static bool DeleteCustomersPayments(int CustomerPaymentID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "Delete from CustomersPayments where CustomerPaymentID=@CustomerPaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@CustomerPaymentID", CustomerPaymentID);

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


        public static bool IsCustomersPaymentsExist(int CustomerPaymentID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select Found=1 from CustomersPayments where CustomerPaymentID=@CustomerPaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@CustomerPaymentID", CustomerPaymentID);

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


        public static DataTable AllCustomersPayments()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from CustomersPayments";

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
