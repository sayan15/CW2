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
        UserDetails newUsr = new UserDetails();
        UserModel userModel = new UserModel();
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.newUsr.UserName = this.userNameTxtBox.Text;
            this.newUsr.Password = this.passwordTextBox1.Text;
            if(userModel.LoginUser(newUsr).Equals("exist"))
            {
                    Main rg = new Main();
                    newUsr.Id = userModel.GetID(newUsr);
                    rg.newUser = this.newUsr;
                    this.Hide();
                    
                    rg.Activate();
                    rg.loadWeekEvent();
                    rg.loadDailyTransaction();
                    rg.Show();
            }
            else
            {
                MessageBox.Show(userModel.LoginUser(newUsr),"Alert");
            }
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Activate();
            register.ShowDialog();
        }
        public void enableWindow()
        {
            this.Show();
        }
    }
}
