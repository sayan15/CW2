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
    public partial class ViewEvents : Form
    {
        public ViewEvents()
        {
            InitializeComponent();
        }
        public UserDetails details;
        List<Event> list = new List<Event>();
        private void viewButton1_Click(object sender, EventArgs e)
        {
            EventModel eventModel= new EventModel();
            string val;
            if (this.taskRadioButton1.Checked)
            {
                val = "Task";
            }
            else
            {
                val = "Appointment";
            }
            try
            {
                list = eventModel.GetDetails(details, val);
                this.eventDataGridView1.AutoGenerateColumns = false;
                this.eventDataGridView1.DataSource = list;
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void eventDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                CW2_SystemDB dataset = new CW2_SystemDB();
                CW2_SystemDB.EventsRow rows = dataset.Events.NewEventsRow();
                try
                {
                    rows.Id = list[e.RowIndex].Id;
                    rows.EventType = list[e.RowIndex].EventType;
                    rows.OccurenceType = list[e.RowIndex].OccurenceType;
                    rows.Date = list[e.RowIndex].Date;
                    rows.Description = list[e.RowIndex].Description;
                    rows.UserId = list[e.RowIndex].UserId;
 
                    dataset.Events.AddEventsRow(rows);
                    dataset.AcceptChanges();

                    EditEvent editEvent = new EditEvent();
                    editEvent.dataset = dataset;
                    editEvent.PublishData();
                    editEvent.Activate();
                    editEvent.ShowDialog();
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }

            }
        }
    }
}
