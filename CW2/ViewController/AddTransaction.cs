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
    public partial class AddTransaction : Form
    {
        public AddTransaction()
        {
            InitializeComponent();
        }
        CW2_SystemDB dataset = new CW2_SystemDB();
        public UserDetails userDetails;
        List<PayerPayeeList> list;
        private void payee_CheckedChanged(object sender, EventArgs e)
        {
            this.payerPayeeList.Items.Clear();
            PayerOrPayeeModel payerOrPayeeModel = new PayerOrPayeeModel();
            this.list=payerOrPayeeModel.GetDetailsForTransaction(userDetails, "Payee");
            foreach(var x in list)
            {
                this.payerPayeeList.Items.Add(x.Name);
            }
        }

        private void payer_CheckedChanged(object sender, EventArgs e)
        {
            this.payerPayeeList.Items.Clear();
            PayerOrPayeeModel payerOrPayeeModel = new PayerOrPayeeModel();
            this.list= payerOrPayeeModel.GetDetailsForTransaction(userDetails, "Payer");
            foreach (var x in list)
            {
                this.payerPayeeList.Items.Add(x.Name);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            double amount;
            SetAlertLabel("");
            if (Double.TryParse(this.amtTxt.Text,out amount))
            {
                if(this.payerPayeeList.SelectedIndex!=-1)
                {
                    CW2_SystemDB.TransactionsRow rows = this.dataset.Transactions.NewTransactionsRow();
                    string type;
                    if (this.transactionTypeRadioButton1.OneTime)
                    {
                        type = "OneTime";
                    }
                    else
                    {
                        type = "Repeat";
                    }
                    if(this.incomeRadioButton1.Checked)
                    {
                        rows.TransactionType = "Income";
                    }
                    else
                    {
                        rows.TransactionType = "Expense";
                    }
                    rows.Amount = amount;
                    rows.PayerOrPayeeId = this.list[this.payerPayeeList.SelectedIndex].Id;
                    rows.Date = Convert.ToDateTime(this.transactionDate.Value.Date.ToShortDateString());
                    rows.OccurenceType = type;
                    rows.Description = this.descTextBox1.Text;
                    rows.UserId = userDetails.Id;

                    dataset.Transactions.AddTransactionsRow(rows);
                    dataset.AcceptChanges();
                    dataset.WriteXml("Transaction.xml");
                 }
                else
                {
                    SetAlertLabel("Please select the Payer or payee from the list if no one exist Add them");
                }
            }
            else
            {
                SetAlertLabel("Insert A Valid Amount");
            }
        }

        public void SetAlertLabel(string text)
        {
            this.alertLabel.Text = text;
        }
    }
}
