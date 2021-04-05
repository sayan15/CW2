
namespace CW2.ViewController
{
    partial class AddTransaction
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.descTextBox1 = new System.Windows.Forms.RichTextBox();
            this.transactionDate = new System.Windows.Forms.DateTimePicker();
            this.payerPayeeList = new System.Windows.Forms.ListBox();
            this.payer = new System.Windows.Forms.RadioButton();
            this.payee = new System.Windows.Forms.RadioButton();
            this.amtTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recurranceRadioButton1 = new System.Windows.Forms.RadioButton();
            this.onTimeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.onTimeRadioButton1);
            this.panel1.Controls.Add(this.recurranceRadioButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.descTextBox1);
            this.panel1.Controls.Add(this.transactionDate);
            this.panel1.Controls.Add(this.payerPayeeList);
            this.panel1.Controls.Add(this.payer);
            this.panel1.Controls.Add(this.payee);
            this.panel1.Controls.Add(this.amtTxt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 610);
            this.panel1.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(364, 531);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 34);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // descTextBox1
            // 
            this.descTextBox1.Location = new System.Drawing.Point(454, 403);
            this.descTextBox1.Name = "descTextBox1";
            this.descTextBox1.Size = new System.Drawing.Size(200, 96);
            this.descTextBox1.TabIndex = 11;
            this.descTextBox1.Text = "";
            // 
            // transactionDate
            // 
            this.transactionDate.Location = new System.Drawing.Point(454, 249);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.Size = new System.Drawing.Size(200, 26);
            this.transactionDate.TabIndex = 10;
            // 
            // payerPayeeList
            // 
            this.payerPayeeList.FormattingEnabled = true;
            this.payerPayeeList.ItemHeight = 20;
            this.payerPayeeList.Location = new System.Drawing.Point(454, 185);
            this.payerPayeeList.Name = "payerPayeeList";
            this.payerPayeeList.Size = new System.Drawing.Size(200, 24);
            this.payerPayeeList.TabIndex = 9;
            // 
            // payer
            // 
            this.payer.AutoSize = true;
            this.payer.Location = new System.Drawing.Point(580, 127);
            this.payer.Name = "payer";
            this.payer.Size = new System.Drawing.Size(74, 24);
            this.payer.TabIndex = 8;
            this.payer.TabStop = true;
            this.payer.Text = "Payer";
            this.payer.UseVisualStyleBackColor = true;
            // 
            // payee
            // 
            this.payee.AutoSize = true;
            this.payee.Location = new System.Drawing.Point(454, 127);
            this.payee.Name = "payee";
            this.payee.Size = new System.Drawing.Size(78, 24);
            this.payee.TabIndex = 7;
            this.payee.TabStop = true;
            this.payee.Text = "Payee";
            this.payee.UseVisualStyleBackColor = true;
            // 
            // amtTxt
            // 
            this.amtTxt.Location = new System.Drawing.Point(454, 62);
            this.amtTxt.Name = "amtTxt";
            this.amtTxt.Size = new System.Drawing.Size(200, 26);
            this.amtTxt.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payer/Payee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Occurence Type";
            // 
            // recurranceRadioButton1
            // 
            this.recurranceRadioButton1.AutoSize = true;
            this.recurranceRadioButton1.Location = new System.Drawing.Point(454, 313);
            this.recurranceRadioButton1.Name = "recurranceRadioButton1";
            this.recurranceRadioButton1.Size = new System.Drawing.Size(87, 24);
            this.recurranceRadioButton1.TabIndex = 14;
            this.recurranceRadioButton1.TabStop = true;
            this.recurranceRadioButton1.Text = "Repeat";
            this.recurranceRadioButton1.UseVisualStyleBackColor = true;
            // 
            // onTimeRadioButton1
            // 
            this.onTimeRadioButton1.AutoSize = true;
            this.onTimeRadioButton1.Location = new System.Drawing.Point(567, 313);
            this.onTimeRadioButton1.Name = "onTimeRadioButton1";
            this.onTimeRadioButton1.Size = new System.Drawing.Size(98, 24);
            this.onTimeRadioButton1.TabIndex = 15;
            this.onTimeRadioButton1.TabStop = true;
            this.onTimeRadioButton1.Text = "OneTime";
            this.onTimeRadioButton1.UseVisualStyleBackColor = true;
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 611);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddTransaction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton payer;
        private System.Windows.Forms.RadioButton payee;
        private System.Windows.Forms.TextBox amtTxt;
        private System.Windows.Forms.ListBox payerPayeeList;
        private System.Windows.Forms.DateTimePicker transactionDate;
        private System.Windows.Forms.RichTextBox descTextBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RadioButton onTimeRadioButton1;
        private System.Windows.Forms.RadioButton recurranceRadioButton1;
        private System.Windows.Forms.Label label1;
    }
}