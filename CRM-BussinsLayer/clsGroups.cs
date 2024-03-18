using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsGroups
    {
        public enum enMode { Add, Update }
        public enMode Mode;
        public int GroupID { get; set; }
        public string Name { get; set; }
        private clsGroups(int GroupID, string Name)
        {
            this.GroupID = GroupID;
            this.Name = Name;
            this.Mode = enMode.Update;
        }
        public clsGroups()
        {
            this.GroupID = -1;
            this.Name = "";
            this.Mode = enMode.Add;
        }
        private bool _AddGroups()
        {
            this.GroupID = clsGroupsData.AddNewGroups(this.Name);
            return (this.GroupID != -1);
        }
        private bool _UpdateGroups()
        {
            return clsGroupsData.UpdateGroups(this.GroupID, this.Name);
        }
        public bool Save()
        {

            switch (Mode)
            {

                case enMode.Update:
                    {

                        return _UpdateGroups();

                    }
                case enMode.Add:
                    {

                        if (_AddGroups())

                        {
                            this.Mode = enMode.Update;

                            return true;
                        }
                        else

                            return false;
                    }
            }
            return false;
        }
        public static bool DeleteGroups(int GroupID)
        {
            return clsGroupsData.DeleteGroups(GroupID);
        }
        public static DataTable GitAllGroups()
        {
            return clsGroupsData.GitAllGroups();
        }
        public static clsGroups Find(int GroupID)
        {
            string Name = "";
            if (clsGroupsData.Find(GroupID, ref Name))
                return new clsGroups(GroupID, Name);
            else
                return null;
        }

    }
}
