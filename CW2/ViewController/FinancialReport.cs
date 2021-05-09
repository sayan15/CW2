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
    public partial class FinancialReport : Form
    {
        public FinancialReport()
        {
            InitializeComponent();
        }
        public UserDetails userDetails;
        List<Transaction> list = new List<Transaction>();
        private void viewBtn_Click(object sender, EventArgs e)
        {
            TransactionModel transactionModel = new TransactionModel();
            DateTime from = Convert.ToDateTime(this.fromDateTimePicker1.Value.Date.ToShortDateString());
            DateTime to= Convert.ToDateTime(this.toDateTimePicker1.Value.Date.ToShortDateString());
            try
            {
                if(((to-from).TotalDays<=30) && (from<=to))
                {
                    list = transactionModel.GetDetails(userDetails, from, to);
                    this.financialReportView.AutoGenerateColumns = false;
                    this.financialReportView.DataSource = list;
                    double totalIncome = transactionModel.GetTotalIncome(userDetails, from, to);
                    double totalExpense = transactionModel.GetTotalExpense(userDetails, from, to);
                    this.totalIncometextBox1.Text = totalIncome.ToString();
                    this.totalExpensetextBox1.Text = totalExpense.ToString();
                    this.netTextBox1.Text = (totalIncome - totalExpense).ToString();
                }
                else
                {
                    MessageBox.Show("Please select the date raange between 30 days");
                }

            }
            catch(Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }


        private void financialReportView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {

                CW2_SystemDB dataset = new CW2_SystemDB();
                CW2_SystemDB.TransactionsRow rows = dataset.Transactions.NewTransactionsRow();
                try
                {
                    rows.Id = list[e.RowIndex].Id;
                    rows.TransactionType = list[e.RowIndex].TransactionType;
                    rows.OccurenceType = list[e.RowIndex].OccurenceType;
                    rows.Date = list[e.RowIndex].Date;
                    rows.Description = list[e.RowIndex].Description;
                    rows.Amount = list[e.RowIndex].Amount;
                    rows.PayerOrPayeeId = list[e.RowIndex].PayerOrPayeeId;
                    rows.UserId = list[e.RowIndex].UserId;

                    dataset.Transactions.AddTransactionsRow(rows);
                    dataset.AcceptChanges();

                    EditTransaction editTransaction = new EditTransaction();
                    editTransaction.dataset = dataset;
                    editTransaction.PublishData();
                    editTransaction.Activate();
                    editTransaction.ShowDialog();
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }

            }
        }
    }
}
