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
    public partial class ViewPayerPayee : Form
    {
        public ViewPayerPayee()
        {
            InitializeComponent();
        }
        public UserDetails details;
        List<PayerOrPayee> list = new List<PayerOrPayee>();
        private void payerOrPayeeViewBtn_Click(object sender, EventArgs e)
        {
            PayerOrPayeeModel payerOrPayeeModel = new PayerOrPayeeModel();
            string val;
            if(this.payeeRadioButton1.Checked)
            {
                val = "Payee";
            }
            else
            {
                val = "Payer";
            }
            try
            {
                list = payerOrPayeeModel.GetDetails(details, val);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = list;
            }
            catch(Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==7)
            {
                
                CW2_SystemDB dataset = new CW2_SystemDB();
                CW2_SystemDB.PayerOrPayeesRow rows = dataset.PayerOrPayees.NewPayerOrPayeesRow();
                try
                {
                    rows.Id = list[e.RowIndex].Id;
                    rows.Name = list[e.RowIndex].Name;
                    rows.Mail = list[e.RowIndex].Mail;
                    rows.PhoneNumber = list[e.RowIndex].PhoneNumber;
                    rows.Address = list[e.RowIndex].Address;
                    rows.Type = list[e.RowIndex].Type;
                    rows.UserId = list[e.RowIndex].UserId;
                    dataset.PayerOrPayees.AddPayerOrPayeesRow(rows);
                    dataset.AcceptChanges();

                    EditPayerOrPayee editPayerOrPayee = new EditPayerOrPayee();
                    editPayerOrPayee.dataset = dataset;
                    editPayerOrPayee.PublishData();
                    editPayerOrPayee.Activate();
                    editPayerOrPayee.ShowDialog();
                }
                catch(Exception m)
                {
                    MessageBox.Show(m.Message);
                }

            }
        }
    }
}
