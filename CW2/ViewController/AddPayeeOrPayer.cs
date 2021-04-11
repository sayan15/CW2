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
    public partial class AddPayeeOrPayer : Form
    {
        CW2_SystemDB dataset = new CW2_SystemDB();
        public UserDetails details;
        public AddPayeeOrPayer()
        {
            InitializeComponent();
        }

        private void payerAddbutton1_Click(object sender, EventArgs e)
        {
            this.alertLabel.Text = "";
            this.alertLabel.BackColor = System.Drawing.Color.White;
            if (String.IsNullOrEmpty(this.nametextBox1.Text)!=true)
            { 
                if(EmailIsValid(this.mailtextBox1.Text))
                {
                    if(this.phonetextBox1.Text.Length==10 && Int32.TryParse(this.phonetextBox1.Text, out int n))
                    {
                        CW2_SystemDB.PayerOrPayeesRow rows = this.dataset.PayerOrPayees.NewPayerOrPayeesRow();
                        rows.Name = this.nametextBox1.Text;
                        rows.Mail = this.mailtextBox1.Text;
                        rows.PhoneNumber = Int32.Parse(this.phonetextBox1.Text);
                        rows.Address = this.addressRichTextBox1.Text;
                        bool type = this.payeeRadioBtn.Checked;
                        if (type)
                        {
                            rows.Type = "Payee";
                        }
                        else
                        {
                            rows.Type = "Payer";
                        }
                        rows.UserId = details.Id;

                        this.dataset.PayerOrPayees.AddPayerOrPayeesRow(rows);
                        this.dataset.AcceptChanges();

                        this.dataset.WriteXml("PayeeOrPayer.xml");

                        //call PayeeOrPayerModel class
                        PayerOrPayeeModel payerOrPayeeModel = new PayerOrPayeeModel();
                        try
                        {
                            payerOrPayeeModel.AddPayerOrPayee(dataset);
                            LabelSetter("Succesfully Added");
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

        public void getDataXML()
        {
            if (File.Exists("PayeeOrPayer.xml"))
            {
                this.dataset.ReadXml("PayeeOrPayer.xml");
                if (this.details.Id == Int32.Parse(this.dataset.Tables[0].Rows[0]["UserId"].ToString()))
                {
                    this.nametextBox1.Text = (this.dataset.Tables[0].Rows[0]["Name"]).ToString();
                    this.mailtextBox1.Text = (this.dataset.Tables[0].Rows[0]["Mail"]).ToString();
                    this.phonetextBox1.Text = (this.dataset.Tables[0].Rows[0]["PhoneNumber"]).ToString();
                    this.addressRichTextBox1.Text = (this.dataset.Tables[0].Rows[0]["Address"]).ToString();
                    if ((this.dataset.Tables[0].Rows[0]["Type"]).ToString().Equals("Payee"))
                    {
                        this.payeeRadioBtn.Checked = true;
                    }
                    else
                    {
                        this.payerRadioBtn.Checked = true;
                    }
                }
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

        public void LabelSetter(string text)
        {
            this.alertLabel.Text = text;
            if (text.Equals("Succesfully Added"))
            {
                File.Delete("PayeeOrPayer.xml");
                this.alertLabel.BackColor = System.Drawing.Color.Green;
                this.nametextBox1.Text = "";
                this.mailtextBox1.Text="";
                this.phonetextBox1.Text="";
                this.addressRichTextBox1.Text="";
                
            }
            else
            {
                this.alertLabel.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
