using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW2.ViewController
{
    public partial class EditEvent : Form
    {
        public EditEvent()
        {
            InitializeComponent();
        }
        public CW2_SystemDB dataset;
        UserDetails userDetails = new UserDetails();
        public void PublishData()
        {
            this.evntIDTxtBox.Text = (this.dataset.Events.Rows[0]["Id"]).ToString();
            this.eventDate.Value = Convert.ToDateTime(this.dataset.Events.Rows[0]["Date"]);
            this.eventDescTextBox1.Text = (this.dataset.Events.Rows[0]["Description"]).ToString();
            if ((this.dataset.Events.Rows[0]["EventType"]).ToString().Equals("Task"))
            {
                this.taskradioButton1.Checked = true;
            }
            else
            {
                this.appointRadioButton2.Checked = true;
            }
            if ((this.dataset.Events.Rows[0]["OccurenceType"]).ToString().Equals("OneTime"))
            {
                this.occurenceTypeRadBtn.Repeat = false;
                this.occurenceTypeRadBtn.OneTime = true;
                this.occurenceTypeRadBtn.setRadioButton();
            }
            else
            {
                this.occurenceTypeRadBtn.OneTime = false;
                this.occurenceTypeRadBtn.Repeat = true;
                this.occurenceTypeRadBtn.setRadioButton();
            }
            userDetails.Id = Int32.Parse((this.dataset.Events.Rows[0]["UserId"]).ToString());

        }

        private void eventUpdateBtn_Click(object sender, EventArgs e)
        {
            dataset = new CW2_SystemDB();
            if (string.IsNullOrEmpty(this.eventDescTextBox1.Text) != true)
            {
                CW2_SystemDB.EventsRow rows = this.dataset.Events.NewEventsRow();
                rows.Id = Int32.Parse(this.evntIDTxtBox.Text);
                if (this.taskradioButton1.Checked)
                {
                    rows.EventType = "Task";
                }
                else
                {
                    rows.EventType = "Appointment";
                }
                if (this.occurenceTypeRadBtn.OneTime)
                {
                    rows.OccurenceType = "OneTime";
                }
                else
                {
                    rows.OccurenceType = "Repeat";
                }
                rows.Date = Convert.ToDateTime(this.eventDate.Value.ToShortDateString());
                rows.Description = this.eventDescTextBox1.Text;
                rows.UserId = this.userDetails.Id;

                dataset.Events.AddEventsRow(rows);
                dataset.AcceptChanges();

                dataset.WriteXml("EditEvents.xml");

                EventModel model = new EventModel();
                try
                {
                    model.UpdateEvent(dataset);
                    MessageBox.Show("Succesfully Updated the Event");
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
                dataset.Clear();
            }
        }

        private void eventDeleteBtn_Click(object sender, EventArgs e)
        {

            dataset = new CW2_SystemDB();
                CW2_SystemDB.EventsRow rows = this.dataset.Events.NewEventsRow();
                rows.Id = Int32.Parse(this.evntIDTxtBox.Text);
                if (this.taskradioButton1.Checked)
                {
                    rows.EventType = "Task";
                }
                else
                {
                    rows.EventType = "Appointment";
                }
                if (this.occurenceTypeRadBtn.OneTime)
                {
                    rows.OccurenceType = "OneTime";
                }
                else
                {
                    rows.OccurenceType = "Repeat";
                }
                rows.Date = Convert.ToDateTime(this.eventDate.Value.ToShortDateString());
                rows.Description = this.eventDescTextBox1.Text;
                rows.UserId = this.userDetails.Id;

                dataset.Events.AddEventsRow(rows);
                dataset.AcceptChanges();

                dataset.WriteXml("EditEvents.xml");

                EventModel model = new EventModel();
                try
                {
                    DeletedDetailView deletedDetailView = new DeletedDetailView();

                    if (deletedDetailView.SetText(dataset))
                    {
                        this.eventDate.Value = DateTime.Today;
                        this.eventDescTextBox1.Text = "";
                        model.DeleteEVent(dataset);
                        this.evntIDTxtBox.Text = "";

                        MessageBox.Show("Succesfully Deleted the Event");
                        //clearDatatable
                        this.dataset.Clear();
                }

                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                    //clearDatatable
                    this.dataset.Clear();
                }
            
        }
    }

}
