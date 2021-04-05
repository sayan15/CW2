
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
            this.retypePassTextBox = new System.Windows.Forms.TextBox();
            this.passwordRegTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.maiTtextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordlbl = new System.Windows.Forms.Label();
            this.regPassLbl = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.mailLbl = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.alertLabel = new System.Windows.Forms.Label();
            this.RegisterPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterPanel1
            // 
            this.RegisterPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.RegisterPanel1.Controls.Add(this.alertLabel);
            this.RegisterPanel1.Controls.Add(this.registerBtn);
            this.RegisterPanel1.Controls.Add(this.retypePassTextBox);
            this.RegisterPanel1.Controls.Add(this.passwordRegTextBox);
            this.RegisterPanel1.Controls.Add(this.UserNameTextBox);
            this.RegisterPanel1.Controls.Add(this.maiTtextBox);
            this.RegisterPanel1.Controls.Add(this.confirmPasswordlbl);
            this.RegisterPanel1.Controls.Add(this.regPassLbl);
            this.RegisterPanel1.Controls.Add(this.UserNameLbl);
            this.RegisterPanel1.Controls.Add(this.mailLbl);
            this.RegisterPanel1.Location = new System.Drawing.Point(12, 12);
            this.RegisterPanel1.Name = "RegisterPanel1";
            this.RegisterPanel1.Size = new System.Drawing.Size(731, 503);
            this.RegisterPanel1.TabIndex = 0;
            // 
            // retypePassTextBox
            // 
            this.retypePassTextBox.Location = new System.Drawing.Point(417, 203);
            this.retypePassTextBox.Name = "retypePassTextBox";
            this.retypePassTextBox.PasswordChar = '*';
            this.retypePassTextBox.Size = new System.Drawing.Size(219, 26);
            this.retypePassTextBox.TabIndex = 7;
            // 
            // passwordRegTextBox
            // 
            this.passwordRegTextBox.Location = new System.Drawing.Point(417, 144);
            this.passwordRegTextBox.Name = "passwordRegTextBox";
            this.passwordRegTextBox.PasswordChar = '*';
            this.passwordRegTextBox.Size = new System.Drawing.Size(219, 26);
            this.passwordRegTextBox.TabIndex = 6;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(417, 91);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(219, 26);
            this.UserNameTextBox.TabIndex = 5;
            // 
            // maiTtextBox
            // 
            this.maiTtextBox.Location = new System.Drawing.Point(417, 44);
            this.maiTtextBox.Name = "maiTtextBox";
            this.maiTtextBox.Size = new System.Drawing.Size(219, 26);
            this.maiTtextBox.TabIndex = 4;
            // 
            // confirmPasswordlbl
            // 
            this.confirmPasswordlbl.AutoSize = true;
            this.confirmPasswordlbl.Location = new System.Drawing.Point(116, 209);
            this.confirmPasswordlbl.Name = "confirmPasswordlbl";
            this.confirmPasswordlbl.Size = new System.Drawing.Size(134, 20);
            this.confirmPasswordlbl.TabIndex = 3;
            this.confirmPasswordlbl.Text = "Retype-Password";
            // 
            // regPassLbl
            // 
            this.regPassLbl.AutoSize = true;
            this.regPassLbl.Location = new System.Drawing.Point(116, 150);
            this.regPassLbl.Name = "regPassLbl";
            this.regPassLbl.Size = new System.Drawing.Size(78, 20);
            this.regPassLbl.TabIndex = 2;
            this.regPassLbl.Text = "Password";
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Location = new System.Drawing.Point(116, 97);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(85, 20);
            this.UserNameLbl.TabIndex = 1;
            this.UserNameLbl.Text = "UserName";
            // 
            // mailLbl
            // 
            this.mailLbl.AutoSize = true;
            this.mailLbl.Location = new System.Drawing.Point(116, 50);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(100, 20);
            this.mailLbl.TabIndex = 0;
            this.mailLbl.Text = "Mail Address";
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.Silver;
            this.registerBtn.Location = new System.Drawing.Point(324, 355);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(84, 37);
            this.registerBtn.TabIndex = 8;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.Location = new System.Drawing.Point(216, 420);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(0, 20);
            this.alertLabel.TabIndex = 9;
            this.alertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(755, 527);
            this.Controls.Add(this.RegisterPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label alertLabel;
    }
}