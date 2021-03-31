using CW2.ViewController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW2
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(this.userNameTxtBox.Text.Equals("Sayan") && this.passwordTextBox1.Text.Equals("123"))
                {
                    
                    Register rg = new Register();
                    this.Hide();
                    rg.Activate();
                    rg.Show();

            }
            else
            {
                MessageBox.Show(this.userNameTxtBox.Text +""+ this.passwordTextBox1.Text);
            }
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
