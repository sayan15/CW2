
namespace CW2
{
    partial class LoginWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserNameAndPassword = new System.Windows.Forms.Panel();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.UserNameAndPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameAndPassword
            // 
            this.UserNameAndPassword.BackColor = System.Drawing.Color.LightSteelBlue;
            this.UserNameAndPassword.Controls.Add(this.passwordTextBox1);
            this.UserNameAndPassword.Controls.Add(this.LoginBtn);
            this.UserNameAndPassword.Controls.Add(this.passwordLbl);
            this.UserNameAndPassword.Controls.Add(this.userNameTxtBox);
            this.UserNameAndPassword.Controls.Add(this.usernameLbl);
            this.UserNameAndPassword.Location = new System.Drawing.Point(130, 105);
            this.UserNameAndPassword.Name = "UserNameAndPassword";
            this.UserNameAndPassword.Size = new System.Drawing.Size(396, 179);
            this.UserNameAndPassword.TabIndex = 0;
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.Location = new System.Drawing.Point(191, 56);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.PasswordChar = '*';
            this.passwordTextBox1.Size = new System.Drawing.Size(149, 26);
            this.passwordTextBox1.TabIndex = 3;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoginBtn.Location = new System.Drawing.Point(156, 122);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 38);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(22, 63);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(78, 20);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Password";
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Location = new System.Drawing.Point(191, 12);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(149, 26);
            this.userNameTxtBox.TabIndex = 1;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(22, 19);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(85, 20);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "UserName";
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 435);
            this.Controls.Add(this.UserNameAndPassword);
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";
            this.UserNameAndPassword.ResumeLayout(false);
            this.UserNameAndPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UserNameAndPassword;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox passwordTextBox1;
    }
}

