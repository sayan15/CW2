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
                    if (this.transactionDate.Value >= DateTime.Today)
                    {
                        CW2_SystemDB.TransactionsRow rows = this.dataset.Transactions.NewTransactionsRow();
                        string type;
                        if (this.occurenceTypeRadioButton1.OneTime)
                        {
                            type = "OneTime";
                        }
                        else
                        {
                            type = "Repeat";
                        }
                        if (this.incomeRadioButton1.Checked)
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

                        try
                        {
                            TransactionModel transactionModel = new TransactionModel();
                            transactionModel.StoreTransaction(dataset);
                            SetAlertLabel("Successfully Added");
                            File.Delete("Transaction.xml");
                        }
                        catch (Exception m)
                        {
                            SetAlertLabel(m.Message);
                        }
                        dataset.Clear();
                    }
                    else
                    {
                        SetAlertLabel("Please select the Future Date");
                    }
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
        public void getDataTransactiontXML()
        {
            if (File.Exists("Transaction.xml"))
            {
                this.dataset.ReadXml("Transaction.xml");
                if (this.userDetails.Id == Int32.Parse(this.dataset.Transactions.Rows[0]["UserId"].ToString()))
                {
                    if ((this.dataset.Transactions.Rows[0]["TransactionType"]).ToString().Equals("Income"))
                    {
                        this.incomeRadioButton1.Checked = true;
                    }
                    else
                    {
                        this.expenseRadioButton1.Checked = true;
                    }

                    if ((this.dataset.Transactions.Rows[0]["OccurenceType"]).ToString().Equals("OneTime"))
                    {
                        this.occurenceTypeRadioButton1.Repeat = false;
                        this.occurenceTypeRadioButton1.OneTime = true;
                        this.occurenceTypeRadioButton1.setRadioButton();
                    }
                    else
                    {
                        this.occurenceTypeRadioButton1.OneTime = false;
                        this.occurenceTypeRadioButton1.Repeat = true;
                        this.occurenceTypeRadioButton1.setRadioButton();
                    }

                    this.descTextBox1.Text = this.dataset.Transactions.Rows[0]["Description"].ToString();
                    this.transactionDate.Value = Convert.ToDateTime(this.dataset.Transactions.Rows[0]["Date"].ToString());
                    this.amtTxt.Text= this.dataset.Transactions.Rows[0]["Amount"].ToString();
                }
            }
        }

        public void SetAlertLabel(string text)
        {
            if(text== "Successfully Added")
            {
                this.alertLabel.BackColor= System.Drawing.Color.Green;
                this.alertLabel.Text = text;
                this.amtTxt.Text = "";
                this.payerPayeeList.ClearSelected();
                this.descTextBox1.Text="";            
             }
            else
            {
                this.alertLabel.BackColor = System.Drawing.Color.Red;
                this.alertLabel.Text = text;
            }
            
        }
    }
}
