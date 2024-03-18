using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_DataLayer
{
    public class clsPaymentsData
    {

        public static int AddNewPayments(int InvoiceID, DateTime PaymentDate, float Amount, int Method, string Description)
        {

            int DefultPaymentID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "insert into Payments values (@InvoiceID,@PaymentDate,@Amount,@Method,@Description) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                        Command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                        Command.Parameters.AddWithValue("@Amount", Amount);
                        Command.Parameters.AddWithValue("@Method", Method);
                        Command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultPaymentID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultPaymentID;
        }


        public static bool FindPayments(ref int PaymentID, ref int InvoiceID, ref DateTime PaymentDate, ref float Amount, ref int Method, ref string Description)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  Payments where PaymentID =@PaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PaymentID", PaymentID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                PaymentID = (int)Reader["PaymentID"];
                                InvoiceID = (int)Reader["InvoiceID"];
                                PaymentDate = (DateTime)Reader["PaymentDate"];
                                Amount = Convert.ToSingle( Reader["Amount"]);
                                Method = (int)Reader["Method"];
                                Description = Reader["Description"] != DBNull.Value ? (string)Reader["Description"] : null;

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


        public static bool UpdatePayments( int PaymentID,  int InvoiceID,  DateTime PaymentDate,  float Amount,  int Method,  string Description)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update Payments set InvoiceID =@InvoiceID , PaymentDate =@PaymentDate , Amount =@Amount , Method =@Method , Description =@Description where PaymentID =@PaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        Command.Parameters.AddWithValue("@InvoiceID", InvoiceID);
                        Command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                        Command.Parameters.AddWithValue("@Amount", Amount);
                        Command.Parameters.AddWithValue("@Method", Method);
                        Command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);

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


        public static bool DeletePayments(int PaymentID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "Delete from Payments where PaymentID=@PaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

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


        public static bool IsPaymentsExist(int PaymentID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select Found=1 from Payments where PaymentID=@PaymentID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@PaymentID", PaymentID);

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


        public static DataTable AllPayments()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from Payments";

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
