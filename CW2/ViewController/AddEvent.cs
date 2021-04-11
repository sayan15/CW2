using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW2.ViewController
{
    public partial class AddEvent : Form
    {
        CW2_SystemDB dataset = new CW2_SystemDB();
        public UserDetails details;
        public AddEvent()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            CW2_SystemDB.EventsRow rows = this.dataset.Events.NewEventsRow();
            string type;
            if(this.taskradioButton1.Checked)
            {
                type = "Task";
            }
            else
            {
                type = "Appointment";
            }
            string occurence;
            if(this.typeRadioButton1.OneTime)
            {
                occurence = "OneTime";
            }
            else
            {
                occurence = "Repeat";
            }
            rows.EventType = type;
            rows.OccurenceType = occurence;
            rows.Date = Convert.ToDateTime(this.eventTransactionDate.Value.Date.ToShortDateString());
            if(string.IsNullOrEmpty(this.eventDescTextBox1.Text)!=true)
            {
                rows.Description = this.eventDescTextBox1.Text;
                rows.UserId = details.Id;
                this.dataset.Events.AddEventsRow(rows);
                this.dataset.AcceptChanges();

                this.dataset.WriteXml("Events.xml");
                try
                {
                    EventModel eventModel = new EventModel();
                    eventModel.StoreEvent(dataset);
                    LabelSetter("Succesfully Added");
                }
                catch(Exception m)
                {
                    LabelSetter(m.Message);
                }
                this.dataset.Clear();
            }
            else
            {

            }
        }
        public void getDataEventXML()
        {
            if (File.Exists("Events.xml"))
            {
                this.dataset.ReadXml("Events.xml");
               if (this.details.Id == Int32.Parse(this.dataset.Events.Rows[0]["UserId"].ToString()))
                {
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
                        this.typeRadioButton1.Repeat = false;
                        this.typeRadioButton1.OneTime = true;
                        this.typeRadioButton1.setRadioButton();
                    }
                    else
                    {
                        this.typeRadioButton1.OneTime = false;
                        this.typeRadioButton1.Repeat = true;
                        this.typeRadioButton1.setRadioButton();
                    }
                    this.eventDescTextBox1.Text = this.dataset.Events.Rows[0]["Description"].ToString();
                    this.eventTransactionDate.Value = Convert.ToDateTime(this.dataset.Events.Rows[0]["Date"].ToString());
                }
            }
        }
        public void LabelSetter(string text)
        {
            this.alertLabel.Text = text;
            if (text.Equals("Succesfully Added"))
            {
                File.Delete("Events.xml");
                this.alertLabel.BackColor = System.Drawing.Color.Green;
                this.eventDescTextBox1.Text = "";
            }
            else
            {
                this.alertLabel.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
