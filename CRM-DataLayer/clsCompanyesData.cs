using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_DataLayer
{
    public class clsCompanyesData
    {
        public static int AddNewCompanyes(string CompanyName, string URL, string Email, string Phone)
        {
            int CompanyesID = -1;

            SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456");

            string Querey = "insert into Companyes  values (@CompanyName,@URL,@Email,@Phone);SELECT SCOPE_IDENTITY(); ";

            SqlCommand Command = new SqlCommand(Querey, Conniction);


            Command.Parameters.AddWithValue("@CompanyName", CompanyName);

            if (URL != "")
                Command.Parameters.AddWithValue("@URL", URL);
            else
                Command.Parameters.AddWithValue("@URL", System.DBNull.Value);

            if (Email != "")
                Command.Parameters.AddWithValue("@Email", Email);
            else
                Command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            if (Phone != "")
                Command.Parameters.AddWithValue("@Phone", Phone);
            else
                Command.Parameters.AddWithValue("@Phone", System.DBNull.Value);


            try
            {

                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {

                    CompanyesID = InsertedID;

                }
            }
            catch (Exception ex)
            {
                return CompanyesID;
            }
            finally
            {

                Conniction.Close();

            }
            return CompanyesID;
        }
        public static bool UpdateCompanyes(int CompanyID, string CompanyName, string URL, string Email, string Phone)
        {

            bool IsUpdate = false;

            SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456");
            string Querey = "update Companyes set  CompanyName=@CompanyName,URL=@URL,Email=@Email,Phone=@Phone where CompanyID=@CompanyID";

            SqlCommand Command = new SqlCommand(Querey, Conniction);


            Command.Parameters.AddWithValue("@CompanyID", CompanyID);

            Command.Parameters.AddWithValue("@CompanyName", CompanyName);

            if (URL != "")
                Command.Parameters.AddWithValue("@URL", URL);
            else
                Command.Parameters.AddWithValue("@URL", System.DBNull.Value);

            if (Email != "")
                Command.Parameters.AddWithValue("@Email", Email);
            else
                Command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            if (Phone != "")
                Command.Parameters.AddWithValue("@Phone", Phone);
            else
                Command.Parameters.AddWithValue("@Phone", System.DBNull.Value);

            try
            {

                Conniction.Open();

                int RowEffected = Command.ExecuteNonQuery();

                if (RowEffected > 0)
                {

                    IsUpdate = true;

                }
            }
            catch (Exception ex)
            {
                return IsUpdate = false;
            }
            finally
            {

                Conniction.Close();

            }
            return IsUpdate;
        }
        public static bool Find(int CompanyID, ref string CompanyName, ref string URL, ref string Email, ref string Phone)
        {

            bool IsFound = false;

            SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456");

            string Querey = "select * from Companyes where CompanyID=@CompanyID";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@CompanyID", CompanyID);
            try
            {
                Conniction.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;

                    CompanyID = (int)Reader["CompanyID"];
                    CompanyName = (string)Reader["CompanyName"];
                    if (Reader["URL"] != System.DBNull.Value)
                        URL = (string)Reader["URL"];
                    else
                        URL = "";

                    if (Reader["Email"] != System.DBNull.Value)
                        Email = (string)Reader["Email"];
                    else
                        Email = "";

                    if (Reader["Phone"] != System.DBNull.Value)
                        Phone = (string)Reader["Phone"];
                    else
                        Phone = "";


                }

                Reader.Close();

            }
            catch (Exception e)
            {
                IsFound = false;
            }
            finally
            {

                Conniction.Close();

            }
            return IsFound;
        }
        public static bool DeleteCompanyes(int CompanyID)
        {
            bool IsDeleted = false;
            SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456");
            string Querey = "delete Companyes where CompanyID=@CompanyID ";
            SqlCommand Command = new SqlCommand(Querey, Conniction);
            Command.Parameters.AddWithValue("@CompanyID", CompanyID);
            try
            {

                Conniction.Open();

                int RowEffected = Command.ExecuteNonQuery();

                if (RowEffected > 0)
                {

                    IsDeleted = true;

                }
            }
            catch (Exception ex)
            {
                IsDeleted = false;
            }
            finally
            {

                Conniction.Close();

            }
            return IsDeleted;
        }
        public static bool IsCompanyesExist(int CompanyID)
        {

            bool IsExist = false;

            SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456");

            string Querey = " select Found=1 from Companyes  where CompanyID = @CompanyID";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@CompanyID", CompanyID);

            try
            {

                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null)
                    IsExist = true;
                else
                    IsExist = false;

            }
            catch (Exception ex)
            {
                IsExist = false;
            }
            finally
            {

                Conniction.Close();

            }
            return IsExist;
        }
        public static DataTable GitAllCompanyes()
        {

            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456");

            string Query = "SELECT * FROM Companyes";

            SqlCommand Command = new SqlCommand(Query, Conniction);

            try
            {

                Conniction.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    dt.Load(Reader);

            }
            catch (Exception ex)
            {
            }
            finally
            {
                Conniction.Close();
            }
            return dt;
        }

    }
}
