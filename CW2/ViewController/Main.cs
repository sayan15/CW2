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
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }
        public UserDetails newUser;
    
        private void Main_Load(object sender, EventArgs e)
        {
            this.usrLbl.Text = this.newUser.UserName;
        }

        private void addTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTransaction ad = new AddTransaction();
            ad.userDetails = newUser;
            ad.getDataTransactiontXML();
            ad.Activate();
            ad.ShowDialog();
        }

        private void viewEditTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialReport financialReport = new FinancialReport();
            financialReport.userDetails = newUser;
            financialReport.Activate();
            financialReport.ShowDialog();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEvent addEvent = new AddEvent();
            addEvent.details = newUser;
            addEvent.getDataEventXML();
            addEvent.Activate();
            addEvent.ShowDialog();
        }

        private void viewEditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewEvents viewevent = new ViewEvents();
            viewevent.details = newUser;
            viewevent.Activate();
            viewevent.ShowDialog();
        }

        private void addDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayeeOrPayer addPayeeorPayer = new AddPayeeOrPayer();
            addPayeeorPayer.details = newUser;
            addPayeeorPayer.getDataXML();
            addPayeeorPayer.Activate();
            addPayeeorPayer.ShowDialog();
        }

        private void viewEditToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewPayerPayee viewPayerPayee = new ViewPayerPayee();
            viewPayerPayee.details = newUser;
            viewPayerPayee.Activate();
            viewPayerPayee.ShowDialog();
        }

        public void loadWeekEvent()
        {
            try
            {
                EventModel eventModel = new EventModel();
                var list = eventModel.GetWeekDetails(newUser, Convert.ToDateTime(DateTime.Today.ToShortDateString()));
                this.weekEventdataGridView1.AutoGenerateColumns = false;
                this.weekEventdataGridView1.DataSource = list;
                int rowcount = 0;
                foreach (var row in list)
                {
                    if ((DateTime.Today.Day - row.Date.Day) < 0)
                    {
                        this.weekEventdataGridView1[1, rowcount].Value = row.Date.Day.ToString() + "-" + row.Date.Month.ToString() + "-" + DateTime.Today.Year;
                    }
                    else
                    {
                        this.weekEventdataGridView1[1, rowcount].Value = row.Date.Day.ToString() + "-" + DateTime.Today.AddMonths(1).Month.ToString() + "-" + DateTime.Today.Year;
                    }
                    rowcount = rowcount + 1;
                }

                this.weekEventdataGridView1.ForeColor= System.Drawing.Color.Red;
                
            }
            catch
            {

            }
        }
        public void loadDailyTransaction()
        {
            try
            {
                TransactionModel transaction = new TransactionModel();
                var list = transaction.GetDailyTransaction(newUser, Convert.ToDateTime(DateTime.Today.ToShortDateString()));
                this.dailyTransdataGridView1.AutoGenerateColumns = false;
                this.dailyTransdataGridView1.DataSource = list;
                this.dailyTransdataGridView1.ForeColor = System.Drawing.Color.Red;
            }
            catch
            {

            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginWindow form = new LoginWindow();
            form.enableWindow();
           // System.Windows.Forms.Application.Exit();
        }

        
        private async void predictbtn_Click(object sender, EventArgs e)
        {
            var val=await PredictedValue();
            this.predictedRichTextBox1.Text += this.predictDateTimePicker1.Value.ToShortDateString().ToString() + "-----------------" + Math.Round(val,2)+ "\r\n";
        }

        public async Task<double> PredictedValue()
        {
            var value=0.0;
            try
            {
                TransactionModel _transaction = new TransactionModel();
                 value = _transaction.GetDetailsForPrediction(newUser, Convert.ToDateTime(this.predictDateTimePicker1.Value.ToString()));
                return value;
            }
            catch(Exception m)
            {
                MessageBox.Show(m.Message);
            }
            return value;
        }
    }
}
