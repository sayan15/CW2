using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW2.ViewController
{
    public partial class EditPayerOrPayee : Form
    {
        public EditPayerOrPayee()
        {
            InitializeComponent();
        }
        public CW2_SystemDB dataset;
        UserDetails userDetails= new UserDetails();
        public void PublishData()
        {
                this.IdtextBox1.Text= (this.dataset.PayerOrPayees.Rows[0]["Id"]).ToString();
                 this.editNametextBox1.Text = (this.dataset.PayerOrPayees.Rows[0]["Name"]).ToString();
                this.editMailtextBox1.Text = (this.dataset.PayerOrPayees.Rows[0]["Mail"]).ToString();
                this.editPhonetextBox1.Text = (this.dataset.PayerOrPayees.Rows[0]["PhoneNumber"]).ToString();
                this.editAddressRichTextBox1.Text = (this.dataset.PayerOrPayees.Rows[0]["Address"]).ToString();
                if ((this.dataset.PayerOrPayees.Rows[0]["Type"]).ToString().Equals("Payee"))
                 {
                    this.editPayeeRadioBtn.Checked = true;
                 }
                 else
                 {
                    this.editPayerRadioBtn.Checked = true;
                 }
                userDetails.Id = Int32.Parse((this.dataset.PayerOrPayees.Rows[0]["UserId"]).ToString());


        }

        private void Updatebutton1_Click(object sender, EventArgs e)
        {   
            dataset = new CW2_SystemDB();
            if (String.IsNullOrEmpty(this.editNametextBox1.Text) != true)
            {
                if (EmailIsValid(this.editMailtextBox1.Text))
                {
                    if (this.editPhonetextBox1.Text.Length == 10 && Int32.TryParse(this.editPhonetextBox1.Text, out int n))
                    {
                        CW2_SystemDB.PayerOrPayeesRow rows = this.dataset.PayerOrPayees.NewPayerOrPayeesRow();
                        rows.Name = this.editNametextBox1.Text;
                        rows.Mail = this.editMailtextBox1.Text;
                        rows.PhoneNumber = Int32.Parse(this.editPhonetextBox1.Text);
                        rows.Address = this.editAddressRichTextBox1.Text;
                        bool type = this.editPayeeRadioBtn.Checked;
                        if (type)
                        {
                            rows.Type = "Payee";
                        }
                        else
                        {
                            rows.Type = "Payer";
                        }
                        rows.Id = Int32.Parse(this.IdtextBox1.Text);
                        rows.UserId = userDetails.Id;

                        this.dataset.PayerOrPayees.AddPayerOrPayeesRow(rows);
                        this.dataset.AcceptChanges();

                        this.dataset.WriteXml("EditPayeeOrPayer.xml");

                        //call PayeeOrPayerModel class
                        PayerOrPayeeModel payerOrPayeeModel = new PayerOrPayeeModel();

                        try
                        {
                            payerOrPayeeModel.Update(dataset);
                            LabelSetter("Updated Successfully");
                        }
                        catch(Exception m)
                        {
                            LabelSetter(m.Message);
                        }
                        //clearDatatable
                        this.dataset.Clear();
                    }
                    else
                    {
                        LabelSetter("Please Enter the Valid PhoneNumber");
                    }
                }
                else
                {
                    LabelSetter("Please Enter the Correct Mail ID");
                }
            }
            else
            {
                LabelSetter("Please Enter the Name");
            }
        }

        private void LabelSetter(string v)
        {
            this.alertLabel.Text = v;
            if (v.Equals("Updated Successfully"))
            {
                File.Delete("EditPayeeOrPayer.xml");
                this.alertLabel.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                this.alertLabel.BackColor = System.Drawing.Color.Red;
            }
        }

        public static bool EmailIsValid(string email)
        {
            string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expression))
            {
                if (Regex.Replace(email, expression, string.Empty).Length == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id;
            id = Int32.Parse(this.IdtextBox1.Text);

            //call PayeeOrPayerModel class
            PayerOrPayeeModel payerOrPayeeModel = new PayerOrPayeeModel();

            try
            {
                payerOrPayeeModel.Delete(id);
                LabelSetter("Deleted Successfully");
                this.editNametextBox1.Text="";
                this.editMailtextBox1.Text="";
                this.editPhonetextBox1.Text="";
                this.editAddressRichTextBox1.Text="";
                this.IdtextBox1.Text = "";
            }
            catch (Exception m)
            {
                LabelSetter(m.Message);
            }
            //clearDatatable
            this.dataset.Clear();
        }
    }
    
}
