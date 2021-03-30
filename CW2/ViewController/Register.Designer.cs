
namespace CW2.ViewController
{
    partial class Register
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
            this.RegisterPanel1 = new System.Windows.Forms.Panel();
            this.mailLbl = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.regPassLbl = new System.Windows.Forms.Label();
            this.confirmPasswordlbl = new System.Windows.Forms.Label();
            this.maiTtextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordRegTextBox = new System.Windows.Forms.TextBox();
            this.retypePassTextBox = new System.Windows.Forms.TextBox();
            this.RegisterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterPanel1
            // 
            this.RegisterPanel1.Controls.Add(this.retypePassTextBox);
            this.RegisterPanel1.Controls.Add(this.passwordRegTextBox);
            this.RegisterPanel1.Controls.Add(this.UserNameTextBox);
            this.RegisterPanel1.Controls.Add(this.maiTtextBox);
            this.RegisterPanel1.Controls.Add(this.confirmPasswordlbl);
            this.RegisterPanel1.Controls.Add(this.regPassLbl);
            this.RegisterPanel1.Controls.Add(this.UserNameLbl);
            this.RegisterPanel1.Controls.Add(this.mailLbl);
            this.RegisterPanel1.Location = new System.Drawing.Point(24, 24);
            this.RegisterPanel1.Name = "RegisterPanel1";
            this.RegisterPanel1.Size = new System.Drawing.Size(434, 348);
            this.RegisterPanel1.TabIndex = 0;
            // 
            // mailLbl
            // 
            this.mailLbl.AutoSize = true;
            this.mailLbl.Location = new System.Drawing.Point(34, 53);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(100, 20);
            this.mailLbl.TabIndex = 0;
            this.mailLbl.Text = "Mail Address";
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Location = new System.Drawing.Point(34, 103);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(85, 20);
            this.UserNameLbl.TabIndex = 1;
            this.UserNameLbl.Text = "UserName";
            // 
            // regPassLbl
            // 
            this.regPassLbl.AutoSize = true;
            this.regPassLbl.Location = new System.Drawing.Point(34, 153);
            this.regPassLbl.Name = "regPassLbl";
            this.regPassLbl.Size = new System.Drawing.Size(78, 20);
            this.regPassLbl.TabIndex = 2;
            this.regPassLbl.Text = "Password";
            // 
            // confirmPasswordlbl
            // 
            this.confirmPasswordlbl.AutoSize = true;
            this.confirmPasswordlbl.Location = new System.Drawing.Point(34, 200);
            this.confirmPasswordlbl.Name = "confirmPasswordlbl";
            this.confirmPasswordlbl.Size = new System.Drawing.Size(134, 20);
            this.confirmPasswordlbl.TabIndex = 3;
            this.confirmPasswordlbl.Text = "Retype-Password";
            // 
            // maiTtextBox
            // 
            this.maiTtextBox.Location = new System.Drawing.Point(257, 47);
            this.maiTtextBox.Name = "maiTtextBox";
            this.maiTtextBox.Size = new System.Drawing.Size(130, 26);
            this.maiTtextBox.TabIndex = 4;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(257, 97);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(130, 26);
            this.UserNameTextBox.TabIndex = 5;
            // 
            // passwordRegTextBox
            // 
            this.passwordRegTextBox.Location = new System.Drawing.Point(257, 147);
            this.passwordRegTextBox.Name = "passwordRegTextBox";
            this.passwordRegTextBox.PasswordChar = '*';
            this.passwordRegTextBox.Size = new System.Drawing.Size(130, 26);
            this.passwordRegTextBox.TabIndex = 6;
            // 
            // retypePassTextBox
            // 
            this.retypePassTextBox.Location = new System.Drawing.Point(259, 197);
            this.retypePassTextBox.Name = "retypePassTextBox";
            this.retypePassTextBox.PasswordChar = '*';
            this.retypePassTextBox.Size = new System.Drawing.Size(130, 26);
            this.retypePassTextBox.TabIndex = 7;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 397);
            this.Controls.Add(this.RegisterPanel1);
            this.Name = "Register";
            this.Text = "Register";
            this.RegisterPanel1.ResumeLayout(false);
            this.RegisterPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegisterPanel1;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox maiTtextBox;
        private System.Windows.Forms.Label confirmPasswordlbl;
        private System.Windows.Forms.Label regPassLbl;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Label mailLbl;
        private System.Windows.Forms.TextBox retypePassTextBox;
        private System.Windows.Forms.TextBox passwordRegTextBox;
    }
}