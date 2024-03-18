using CRM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BussinsLayer
{
   public class clsDocuments
   {
        public enum enMode { Add, Update }
        enMode Mode;
        public int DocumentID { get; set; }
        public string Title { get; set; }
        public string FilePath { get; set; }


        public clsDocuments()
        {
            Mode = enMode.Add;
            this.DocumentID = 0;
            this.Title = null;
            this.FilePath = null;

        }

        private clsDocuments(int DocumentID, string Title, string FilePath)
        {
            Mode = enMode.Update;
            this.DocumentID = DocumentID;
            this.Title = Title;
            this.FilePath = FilePath;

        }


        private bool _AddNew()
        {
            this.DocumentID = clsDocumentsData.AddNewDocuments(this.Title, this.FilePath);

            return (this.DocumentID != null);
        }


        private bool _Update()
        {
            return clsDocumentsData.UpdateDocuments(this.DocumentID, this.Title, this.FilePath);
        }


        public static clsDocuments Find(int DocumentID)
        {
            string Title = null;
            string FilePath = null;


            if (clsDocumentsData.FindDocuments(ref DocumentID, ref Title, ref FilePath))
                return new clsDocuments(DocumentID, Title, FilePath);
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


        public static bool Delete(int DocumentID)
        {
            return clsDocumentsData.DeleteDocuments(DocumentID);
        }


        public static bool IsDocumentsExist(int DocumentID)
        {
            return clsDocumentsData.IsDocumentsExist(DocumentID);
        }


        public static DataTable All()
        {
            return clsDocumentsData.AllDocuments();
        }



    }
}
