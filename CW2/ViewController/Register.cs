using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW2.ViewController
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        UserDetails user = new UserDetails();
        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (EmailIsValid(this.maiTtextBox.Text))
            {
                if (PasswordTester(this.passwordRegTextBox.Text))
                {
                    if (this.passwordRegTextBox.Text.Equals(this.retypePassTextBox.Text))
                    {
                        UserModel userModel = new UserModel();
                        this.user.UserName = this.UserNameTextBox.Text;
                        this.user.Password = this.passwordRegTextBox.Text;
                        this.user.Mail = this.maiTtextBox.Text;
                        LabelSetter(userModel.RegisterUser(user));
                    }
                    else
                    {
                        LabelSetter("Password Should be Same");
                        this.passwordRegTextBox.Text = "";
                        this.retypePassTextBox.Text = "";
                    }
                }
                else
                {
                    LabelSetter("Password Length should be greater than 5");
                    this.passwordRegTextBox.Text = "";
                    this.retypePassTextBox.Text = "";
                }
            }
            else
            {
                LabelSetter("Please Enetr the Valid Mail Address");
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

        public static bool PasswordTester(string password)
        {
            if (password.Length > 5)
            {
                return true;
            }
            return false;
        }
        public void LabelSetter(string text)
         {
            this.alertLabel.Text = text;
            if (text.Equals("Succesfully Added"))
            {
                this.alertLabel.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                this.alertLabel.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
