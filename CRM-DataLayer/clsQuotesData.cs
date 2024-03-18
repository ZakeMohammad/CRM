using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_DataLayer
{
    public class clsQuotesData
    {
        public static int AddNewQuotes(int CustomerID, DateTime CreateDate, DateTime ExpirDate, float Tax, float? Discount, string Subject, string ProposalText, int ProductID, int ProductQuantity, int QuotesStatusID, string Notes)
        {

            int DefultQuotesID = 0;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "insert into Quotes values (@CustomerID,@CreateDate,@ExpirDate,@Tax,@Discount,@Subject,@ProposalText,@ProductID,@ProductQuantity,@QuotesStatusID,@Notes) ;select SCOPE_IDENTITY()";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("@CreateDate", CreateDate);
                        Command.Parameters.AddWithValue("@ExpirDate", ExpirDate);
                        Command.Parameters.AddWithValue("@Tax", Tax);
                        Command.Parameters.AddWithValue("@Discount", (object)Discount ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Subject", Subject);
                        Command.Parameters.AddWithValue("@ProposalText", ProposalText);
                        Command.Parameters.AddWithValue("@ProductID", ProductID);
                        Command.Parameters.AddWithValue("@ProductQuantity", ProductQuantity);
                        Command.Parameters.AddWithValue("@QuotesStatusID", QuotesStatusID);
                        Command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);

                        Connection.Open();

                        object Ruslt = Command.ExecuteScalar();

                        if (Ruslt != null)
                        {

                            DefultQuotesID = Convert.ToInt32(Ruslt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return DefultQuotesID;
        }


        public static bool FindQuotes(ref int QuotesID, ref int CustomerID, ref DateTime CreateDate, ref DateTime ExpirDate, ref float Tax, ref float? Discount, ref string Subject, ref string ProposalText, ref int ProductID, ref int ProductQuantity, ref int QuotesStatusID, ref string Notes)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  Quotes where QuotesID =@QuotesID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@QuotesID", QuotesID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                QuotesID = (int)Reader["QuotesID"];
                                CustomerID = (int)Reader["CustomerID"];
                                CreateDate = (DateTime)Reader["CreateDate"];
                                ExpirDate = (DateTime)Reader["ExpirDate"];
                                Tax = Convert.ToSingle( Reader["Tax"]);
                                Discount = Convert.ToSingle(Reader["Discount"]);
                                Discount = Convert.ToSingle((object)Discount ?? DBNull.Value);
                                Subject = (string)Reader["Subject"];
                                ProposalText = (string)Reader["ProposalText"];
                                ProductID = (int)Reader["ProductID"];
                                ProductQuantity = (int)Reader["ProductQuantity"];
                                QuotesStatusID = (int)Reader["QuotesStatusID"];
                                Notes = Reader["Notes"] != DBNull.Value ? (string)Reader["Notes"] : null;

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

        public static bool FindQuotesForThisCustomer(ref int QuotesID, ref int CustomerID, ref DateTime CreateDate, ref DateTime ExpirDate, ref float Tax, ref float? Discount, ref string Subject, ref string ProposalText, ref int ProductID, ref int ProductQuantity, ref int QuotesStatusID, ref string Notes)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from  Quotes where QuotesID =@QuotesID and CustomerID=@CustomerID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@QuotesID", QuotesID);

                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);

                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;
                                QuotesID = (int)Reader["QuotesID"];
                                CustomerID = (int)Reader["CustomerID"];
                                CreateDate = (DateTime)Reader["CreateDate"];
                                ExpirDate = (DateTime)Reader["ExpirDate"];
                                Tax = Convert.ToSingle(Reader["Tax"]);
                                Discount = Convert.ToSingle(Reader["Discount"]);
                                Discount = Convert.ToSingle((object)Discount ?? DBNull.Value);
                                Subject = (string)Reader["Subject"];
                                ProposalText = (string)Reader["ProposalText"];
                                ProductID = (int)Reader["ProductID"];
                                ProductQuantity = (int)Reader["ProductQuantity"];
                                QuotesStatusID = (int)Reader["QuotesStatusID"];
                                Notes = Reader["Notes"] != DBNull.Value ? (string)Reader["Notes"] : null;

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
        public static bool UpdateQuotes(int QuotesID, int CustomerID, DateTime CreateDate, DateTime ExpirDate, float Tax, float? Discount, string Subject, string ProposalText, int ProductID, int ProductQuantity, int QuotesStatusID, string Notes)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "update Quotes set CustomerID =@CustomerID , CreateDate =@CreateDate , ExpirDate =@ExpirDate , Tax =@Tax , Discount =@Discount , Subject =@Subject , ProposalText =@ProposalText , ProductID =@ProductID , ProductQuantity =@ProductQuantity , QuotesStatusID =@QuotesStatusID , Notes =@Notes where QuotesID =@QuotesID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@QuotesID", QuotesID);
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        Command.Parameters.AddWithValue("@CreateDate", CreateDate);
                        Command.Parameters.AddWithValue("@ExpirDate", ExpirDate);
                        Command.Parameters.AddWithValue("@Tax", Tax);
                        Command.Parameters.AddWithValue("@Discount", (object)Discount ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Subject", Subject);
                        Command.Parameters.AddWithValue("@ProposalText", ProposalText);
                        Command.Parameters.AddWithValue("@ProductID", ProductID);
                        Command.Parameters.AddWithValue("@ProductQuantity", ProductQuantity);
                        Command.Parameters.AddWithValue("@QuotesStatusID", QuotesStatusID);
                        Command.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);

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


        public static bool DeleteQuotes(int QuotesID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "Delete from Quotes where QuotesID=@QuotesID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@QuotesID", QuotesID);

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


        public static bool IsQuotesExist(int QuotesID)
        {

            int RowEffected = 0;
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select Found=1 from Quotes where QuotesID=@QuotesID";

                    using (SqlCommand Command = new SqlCommand(Querey, Connection))
                    {

                        Command.Parameters.AddWithValue("@QuotesID", QuotesID);

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


        public static DataTable AllQuotes()
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from Quotes";

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

        public static DataTable AllQuotesForThisCustomer(int CustomerID)
        {

            DataTable dt = new DataTable();
            try
            {

                using (SqlConnection Connection = new SqlConnection(clsConnectionSettings.ConnectionString))
                {

                    string Querey = "select * from Quotes where CustomerID=@CustomerID";

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
