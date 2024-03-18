using CRM_BussinsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace CRM.Admin.Calendar
{
    public partial class ctrlAddEditEvent : UserControl
    {
        public ctrlAddEditEvent()
        {
            InitializeComponent();
        }

        public event Action<bool> IsEventAddOrUpdate;

       
        protected virtual void EventAddOrEdit(bool AddOrEdit)
        {
            Action<bool> Handler = IsEventAddOrUpdate;

            if (Handler != null)
            {
                Handler(AddOrEdit);
            }
        }


        enum enMode { Add,Update}
        enMode Mode=enMode.Add;

        public int ID;
        private clsEvents _EventForUpdate;
        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            if(TxtName.Text==string.Empty)
            {
                e.Cancel = true;
                TxtName.Focus();
                errorProvider1.SetError(TxtName, "Plese Enter Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtName, "");
            }
        }


        private void TxtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        public void FillForUpdate(int id)
        {
            clsEvents event1 = clsEvents.Find(Convert.ToInt32(id));

            lblForWhat.Text = "Update Event";
            TxtName.Text = event1.Name;
            TxtDescription.Text = (event1.Description=="")?"":event1.Description;
            DatePickerForStartDate.Value = event1.StartDate;
            DatePickerForEndDate.Value = event1.EndDate;
            _EventForUpdate = event1;
            ID = id;
            Mode = enMode.Update;
        }

        void Update()
        {
            _EventForUpdate.Name = TxtName.Text;
            _EventForUpdate.Description= TxtDescription.Text;
            _EventForUpdate.StartDate = DatePickerForStartDate.Value;
            _EventForUpdate.EndDate = DatePickerForEndDate.Value;
        }

        private void ctrlAddEditEvent_Load(object sender, EventArgs e)
        {
          Resat();
        }


        void Resat()
        {
            lblForWhat.Text = "Add Event";

            TxtName.Text = "A";
            TxtDescription.Text= string.Empty; 
            DatePickerForStartDate.Value = DateTime.Now.Date;
            DatePickerForEndDate.Value = DateTime.Now.Date.AddDays(1); 
            Mode = enMode.Add;

            DisapleSaveButton();
        }

        bool IsDate1AfterDate2(DateTime date1,DateTime date2)
        {
            return date1 > date2;
        }

        void DisapleSaveButton()
        {
            btnSave.Enabled = false;
        }

       public void EnableSaveButton()
       {
            btnSave.Enabled = true;
       }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            if(IsDate1AfterDate2(DatePickerForStartDate.Value,DatePickerForEndDate.Value))
            {
                MessageBox.Show("Plese Cheak Dates Its Wrong..", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                DisapleSaveButton();
                return;
            }

            if(Mode==enMode.Add)
            {
                clsEvents NewEvent= new clsEvents();

                NewEvent.Name = TxtName.Text;
                NewEvent.Description = TxtDescription.Text;
                NewEvent.StartDate=DatePickerForStartDate.Value;
                NewEvent.EndDate=DatePickerForEndDate.Value;

                if(NewEvent.Save())
                {
                    MessageBox.Show($"Event Added Succssfilly With ID {NewEvent.EventID}", "Events", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    EventAddOrEdit(true);
                }    
                else
                    MessageBox.Show($"Event Does Not Added", "Events", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
               
            }
            else
            {
                Update();

                if (_EventForUpdate.Save())
                {
                    
                    MessageBox.Show($"Event Updated Succssfilly With ID {_EventForUpdate.EventID}", "Events", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    EventAddOrEdit(true);
                }
                    
                else
                    MessageBox.Show($"Event Does Not Updated", "Events", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            Resat();
            return;
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (TxtName.Text == string.Empty)
                DisapleSaveButton();
            else
                EnableSaveButton();
        }


    }
}
