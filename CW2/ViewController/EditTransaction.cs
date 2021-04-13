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
    public partial class EditTransaction : Form
    {
        public EditTransaction()
        {
            InitializeComponent();
        }
        public CW2_SystemDB dataset;
        UserDetails userDetails = new UserDetails();
        List<PayerPayeeList> list;
        public void PublishData()
        {
            this.transactionIDTxtBox.Text=(this.dataset.Transactions.Rows[0]["Id"]).ToString();
            this.amtTxtBox.Text= (this.dataset.Transactions.Rows[0]["Amount"]).ToString();
            this.payerOrPayeeIdtextBox1.Text= (this.dataset.Transactions.Rows[0]["PayerOrPayeeId"]).ToString();
            this.descTextBox1.Text= (this.dataset.Transactions.Rows[0]["Description"]).ToString();
            this.transactionDate.Value=Convert.ToDateTime( (this.dataset.Transactions.Rows[0]["Date"]).ToString());
            if ((this.dataset.Transactions.Rows[0]["TransactionType"]).ToString() == "Income")
            {
                this.editIncomeRadioButton1.Checked = true;
            }
            else
            {
                this.editExpenseRadioButton1.Checked = true;
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
            userDetails.Id = Int32.Parse((this.dataset.Transactions.Rows[0]["UserId"]).ToString());
        }

        private void transactionUpadteBtn_Click(object sender, EventArgs e)
        {
            double amount;
            dataset = new CW2_SystemDB();
            SetAlertLabel("");
            if (Double.TryParse(this.amtTxtBox.Text, out amount))
            {
                if (this.payerPayeeList.SelectedIndex != -1)
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
                        if (this.editIncomeRadioButton1.Checked)
                        {
                            rows.TransactionType = "Income";
                        }
                        else
                        {
                            rows.TransactionType = "Expense";
                        }
                        rows.Id = Int32.Parse(this.transactionIDTxtBox.Text);
                        rows.Amount = amount;
                        rows.PayerOrPayeeId = this.list[this.payerPayeeList.SelectedIndex].Id;
                        rows.Date = Convert.ToDateTime(this.transactionDate.Value.Date.ToShortDateString());
                        rows.OccurenceType = type;
                        rows.Description = this.descTextBox1.Text;
                        rows.UserId = userDetails.Id;

                        dataset.Transactions.AddTransactionsRow(rows);
                        dataset.AcceptChanges();
                        dataset.WriteXml("EditTransaction.xml");

                        try
                        {
                            TransactionModel transactionModel = new TransactionModel();
                            transactionModel.Update(dataset);
                            SetAlertLabel("Successfully Updated");
                            File.Delete("EditTransaction.xml");
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

        private void SetAlertLabel(string text)
        {
            if (text == "Successfully Updated")
            {
                this.alertLbl.BackColor = System.Drawing.Color.Green;
                this.alertLbl.Text = text;
            }
            else
            {
                this.alertLbl.BackColor = System.Drawing.Color.Red;
                this.alertLbl.Text = text;
            }
        }

        private void transDeleteBtn_Click(object sender, EventArgs e)
        {
            int id;
            id = Int32.Parse(this.transactionIDTxtBox.Text);

            try
            {
                TransactionModel transactionModel = new TransactionModel();
                transactionModel.Delete(id);
                SetAlertLabel("Successfully Deleted");
                File.Delete("EditTransaction.xml");
                this.transactionIDTxtBox.Text = "";
                this.amtTxtBox.Text = "";
                this.descTextBox1.Text = "";
                this.payerPayeeList.ClearSelected();
            }
            catch (Exception m)
            {
                SetAlertLabel(m.Message);
            }
            dataset.Clear();
        }

        private void payee_CheckedChanged(object sender, EventArgs e)
        {
            this.payerPayeeList.Items.Clear();
            PayerOrPayeeModel payerOrPayeeModel = new PayerOrPayeeModel();
            this.list = payerOrPayeeModel.GetDetailsForTransaction(userDetails, "Payee");
            foreach (var x in list)
            {
                this.payerPayeeList.Items.Add(x.Name);
            }

        }

        private void payer_CheckedChanged(object sender, EventArgs e)
        {
            this.payerPayeeList.Items.Clear();
            PayerOrPayeeModel payerOrPayeeModel = new PayerOrPayeeModel();
            this.list = payerOrPayeeModel.GetDetailsForTransaction(userDetails, "Payer");
            foreach (var x in list)
            {
                this.payerPayeeList.Items.Add(x.Name);
            }

        }
    }
}
