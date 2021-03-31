
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoginBtn);
            this.panel1.Controls.Add(this.passwordTextBox1);
            this.panel1.Controls.Add(this.userNameTxtBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(40, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 408);
            this.panel1.TabIndex = 0;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Blue;
            this.LoginBtn.Location = new System.Drawing.Point(351, 292);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 32);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox1.Location = new System.Drawing.Point(210, 220);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.PasswordChar = '*';
            this.passwordTextBox1.Size = new System.Drawing.Size(357, 22);
            this.passwordTextBox1.TabIndex = 2;
            this.passwordTextBox1.Text = "Password";
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTxtBox.Location = new System.Drawing.Point(210, 165);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userNameTxtBox.Size = new System.Drawing.Size(357, 22);
            this.userNameTxtBox.TabIndex = 1;
            this.userNameTxtBox.Text = "UserName";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.closeIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 155);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CW2.Properties.Resources.Man;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::CW2.Properties.Resources.Man;
            this.pictureBox1.Location = new System.Drawing.Point(315, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // closeIcon
            // 
            this.closeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeIcon.Image = global::CW2.Properties.Resources.close;
            this.closeIcon.Location = new System.Drawing.Point(890, 0);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(27, 22);
            this.closeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeIcon.TabIndex = 0;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.closeIcon_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.PictureBox closeIcon;
    }
}

