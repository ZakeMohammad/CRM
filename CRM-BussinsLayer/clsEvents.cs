using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
    public class clsEvents
    {
        public enum enMode { Add, Update }
        enMode Mode;
        public int EventID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }


        public clsEvents()
        {
            Mode = enMode.Add;
            this.EventID = 0;
            this.Name = null;
            this.StartDate = DateTime.Now;
            this.EndDate = DateTime.Now;
            this.Description = null;

        }

        private clsEvents(int EventID, string Name, DateTime StartDate, DateTime EndDate, string Description)
        {
            Mode = enMode.Update;
            this.EventID = EventID;
            this.Name = Name;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Description = Description;

        }


        private bool _AddNew()
        {
            this.EventID = clsEventsData.AddNewEvents(this.Name, this.StartDate, this.EndDate, this.Description);

            return (this.EventID != null);
        }


        private bool _Update()
        {
            return clsEventsData.UpdateEvents(this.EventID, this.Name, this.StartDate, this.EndDate, this.Description);
        }


        public static clsEvents Find(int EventID)
        {
            string Name = null;
            DateTime StartDate = DateTime.Now;
            DateTime EndDate = DateTime.Now;
            string Description = null;


            if (clsEventsData.FindEvents(ref EventID, ref Name, ref StartDate, ref EndDate, ref Description))
                return new clsEvents(EventID, Name, StartDate, EndDate, Description);
            else
                return null;
        }


        public bool Save()
        {
            switch (Mode)
            {

                case enMode.Add:
                    {
                        if (_AddNew())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
                defult:
                    return false;
            }
            return false;
        }


        public static bool Delete(int EventID)
        {
            return clsEventsData.DeleteEvents(EventID);
        }


        public static bool IsEventsExist(int EventID)
        {
            return clsEventsData.IsEventsExist(EventID);
        }


        public static DataTable All()
        {
            return clsEventsData.AllEvents();
        }



    }
}
