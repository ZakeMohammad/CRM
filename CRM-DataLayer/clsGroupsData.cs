using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_DataLayer
{
    public class clsGroupsData
    {
        public static int AddNewGroups(string Name)
        {
            int GroupsID = -1;

            SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456");

            string Querey = "insert into Groups values (@Name);SELECT SCOPE_IDENTITY(); ";

            SqlCommand Command = new SqlCommand(Querey, Conniction);


            Command.Parameters.AddWithValue("@Name", Name);


            try
            {

                Conniction.Open();

                object Ruslt = Command.ExecuteScalar();

                if (Ruslt != null && int.TryParse(Ruslt.ToString(), out int InsertedID))
                {

                    GroupsID = InsertedID;

                }
            }
            catch (Exception ex)
            {
                return GroupsID;
            }
            finally
            {

                Conniction.Close();

            }
            return GroupsID;
        }
        public static bool UpdateGroups(int GroupID, string Name)
        {

            bool IsUpdate = false;

            SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456");
            string Querey = "update Groups set  Name=@Name where GroupID=@GroupID";

            SqlCommand Command = new SqlCommand(Querey, Conniction);


            Command.Parameters.AddWithValue("@GroupID", GroupID);

            Command.Parameters.AddWithValue("@Name", Name);

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
        public static bool Find(int GroupID, ref string Name)
        {

            bool IsFound = false;

            SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456");

            string Querey = "select * from Groups where GroupID=@GroupID";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@GroupID", GroupID);
            try
            {
                Conniction.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;

                    GroupID = (int)Reader["GroupID"];
                    Name = (string)Reader["Name"];

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
        public static bool DeleteGroups(int GroupID)
        {
            bool IsDeleted = false;
            SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456");
            string Querey = "delete Groups where GroupID=@GroupID ";
            SqlCommand Command = new SqlCommand(Querey, Conniction);
            Command.Parameters.AddWithValue("@GroupID", GroupID);
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
        public static bool IsGroupsExist(int GroupsID)
        {

            bool IsExist = false;

            SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456");

            string Querey = " select Found=1 from Groups  where GroupID = @GroupID";

            SqlCommand Command = new SqlCommand(Querey, Conniction);

            Command.Parameters.AddWithValue("@GroupID", GroupsID);

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
        public static DataTable GitAllGroups()
        {

            DataTable dt = new DataTable();

            SqlConnection Conniction = new SqlConnection("Server=.;Database=CRM;User Id=sa;Password=123456");

            string Query = "SELECT * FROM Groups";

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
