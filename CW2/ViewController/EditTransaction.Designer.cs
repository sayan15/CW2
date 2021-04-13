
namespace CW2.ViewController
{
    partial class EditTransaction
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
            this.occurenceTypeRadioButton1 = new CW2.TypeRadioButton();
            this.payerOrPayeeIdtextBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.editTransactionTypegroupBox1 = new System.Windows.Forms.GroupBox();
            this.editExpenseRadioButton1 = new System.Windows.Forms.RadioButton();
            this.editIncomeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.transDeleteBtn = new System.Windows.Forms.Button();
            this.transactionUpadteBtn = new System.Windows.Forms.Button();
            this.transactionIDTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descTextBox1 = new System.Windows.Forms.RichTextBox();
            this.transactionDate = new System.Windows.Forms.DateTimePicker();
            this.payerPayeeList = new System.Windows.Forms.ListBox();
            this.payer = new System.Windows.Forms.RadioButton();
            this.payee = new System.Windows.Forms.RadioButton();
            this.amtTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alertLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.editTransactionTypegroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.alertLbl);
            this.panel1.Controls.Add(this.occurenceTypeRadioButton1);
            this.panel1.Controls.Add(this.payerOrPayeeIdtextBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.editTransactionTypegroupBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.transDeleteBtn);
            this.panel1.Controls.Add(this.transactionUpadteBtn);
            this.panel1.Controls.Add(this.transactionIDTxtBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.descTextBox1);
            this.panel1.Controls.Add(this.transactionDate);
            this.panel1.Controls.Add(this.payerPayeeList);
            this.panel1.Controls.Add(this.payer);
            this.panel1.Controls.Add(this.payee);
            this.panel1.Controls.Add(this.amtTxtBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 708);
            this.panel1.TabIndex = 0;
            // 
            // occurenceTypeRadioButton1
            // 
            this.occurenceTypeRadioButton1.BackColor = System.Drawing.Color.AliceBlue;
            this.occurenceTypeRadioButton1.ForeColor = System.Drawing.Color.Black;
            this.occurenceTypeRadioButton1.Location = new System.Drawing.Point(411, 429);
            this.occurenceTypeRadioButton1.Name = "occurenceTypeRadioButton1";
            this.occurenceTypeRadioButton1.OneTime = false;
            this.occurenceTypeRadioButton1.Repeat = false;
            this.occurenceTypeRadioButton1.Size = new System.Drawing.Size(265, 54);
            this.occurenceTypeRadioButton1.TabIndex = 38;
            // 
            // payerOrPayeeIdtextBox1
            // 
            this.payerOrPayeeIdtextBox1.Enabled = false;
            this.payerOrPayeeIdtextBox1.Location = new System.Drawing.Point(419, 204);
            this.payerOrPayeeIdtextBox1.Name = "payerOrPayeeIdtextBox1";
            this.payerOrPayeeIdtextBox1.Size = new System.Drawing.Size(197, 26);
            this.payerOrPayeeIdtextBox1.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Payer/Payee ID";
            // 
            // editTransactionTypegroupBox1
            // 
            this.editTransactionTypegroupBox1.Controls.Add(this.editExpenseRadioButton1);
            this.editTransactionTypegroupBox1.Controls.Add(this.editIncomeRadioButton1);
            this.editTransactionTypegroupBox1.Location = new System.Drawing.Point(400, 138);
            this.editTransactionTypegroupBox1.Name = "editTransactionTypegroupBox1";
            this.editTransactionTypegroupBox1.Size = new System.Drawing.Size(322, 54);
            this.editTransactionTypegroupBox1.TabIndex = 35;
            this.editTransactionTypegroupBox1.TabStop = false;
            // 
            // editExpenseRadioButton1
            // 
            this.editExpenseRadioButton1.AutoSize = true;
            this.editExpenseRadioButton1.Location = new System.Drawing.Point(180, 21);
            this.editExpenseRadioButton1.Name = "editExpenseRadioButton1";
            this.editExpenseRadioButton1.Size = new System.Drawing.Size(96, 24);
            this.editExpenseRadioButton1.TabIndex = 1;
            this.editExpenseRadioButton1.Text = "Expense";
            this.editExpenseRadioButton1.UseVisualStyleBackColor = true;
            // 
            // editIncomeRadioButton1
            // 
            this.editIncomeRadioButton1.AutoSize = true;
            this.editIncomeRadioButton1.Checked = true;
            this.editIncomeRadioButton1.Location = new System.Drawing.Point(12, 21);
            this.editIncomeRadioButton1.Name = "editIncomeRadioButton1";
            this.editIncomeRadioButton1.Size = new System.Drawing.Size(87, 24);
            this.editIncomeRadioButton1.TabIndex = 0;
            this.editIncomeRadioButton1.TabStop = true;
            this.editIncomeRadioButton1.Text = "Income";
            this.editIncomeRadioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Transaction Type";
            // 
            // transDeleteBtn
            // 
            this.transDeleteBtn.BackColor = System.Drawing.Color.Silver;
            this.transDeleteBtn.Location = new System.Drawing.Point(400, 659);
            this.transDeleteBtn.Name = "transDeleteBtn";
            this.transDeleteBtn.Size = new System.Drawing.Size(75, 29);
            this.transDeleteBtn.TabIndex = 33;
            this.transDeleteBtn.Text = "Delete";
            this.transDeleteBtn.UseVisualStyleBackColor = false;
            this.transDeleteBtn.Click += new System.EventHandler(this.transDeleteBtn_Click);
            // 
            // transactionUpadteBtn
            // 
            this.transactionUpadteBtn.BackColor = System.Drawing.Color.Silver;
            this.transactionUpadteBtn.Location = new System.Drawing.Point(240, 659);
            this.transactionUpadteBtn.Name = "transactionUpadteBtn";
            this.transactionUpadteBtn.Size = new System.Drawing.Size(75, 29);
            this.transactionUpadteBtn.TabIndex = 32;
            this.transactionUpadteBtn.Text = "Update";
            this.transactionUpadteBtn.UseVisualStyleBackColor = false;
            this.transactionUpadteBtn.Click += new System.EventHandler(this.transactionUpadteBtn_Click);
            // 
            // transactionIDTxtBox
            // 
            this.transactionIDTxtBox.Location = new System.Drawing.Point(416, 35);
            this.transactionIDTxtBox.Name = "transactionIDTxtBox";
            this.transactionIDTxtBox.ReadOnly = true;
            this.transactionIDTxtBox.Size = new System.Drawing.Size(200, 26);
            this.transactionIDTxtBox.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "TransctionID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Occurence Type";
            // 
            // descTextBox1
            // 
            this.descTextBox1.Location = new System.Drawing.Point(419, 522);
            this.descTextBox1.Name = "descTextBox1";
            this.descTextBox1.Size = new System.Drawing.Size(200, 96);
            this.descTextBox1.TabIndex = 26;
            this.descTextBox1.Text = "";
            // 
            // transactionDate
            // 
            this.transactionDate.Location = new System.Drawing.Point(416, 382);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.Size = new System.Drawing.Size(200, 26);
            this.transactionDate.TabIndex = 25;
            // 
            // payerPayeeList
            // 
            this.payerPayeeList.FormattingEnabled = true;
            this.payerPayeeList.ItemHeight = 20;
            this.payerPayeeList.Location = new System.Drawing.Point(416, 318);
            this.payerPayeeList.Name = "payerPayeeList";
            this.payerPayeeList.Size = new System.Drawing.Size(200, 24);
            this.payerPayeeList.TabIndex = 24;
            // 
            // payer
            // 
            this.payer.AutoSize = true;
            this.payer.Location = new System.Drawing.Point(580, 258);
            this.payer.Name = "payer";
            this.payer.Size = new System.Drawing.Size(74, 24);
            this.payer.TabIndex = 23;
            this.payer.TabStop = true;
            this.payer.Text = "Payer";
            this.payer.UseVisualStyleBackColor = true;
            this.payer.CheckedChanged += new System.EventHandler(this.payer_CheckedChanged);
            // 
            // payee
            // 
            this.payee.AutoSize = true;
            this.payee.Location = new System.Drawing.Point(416, 260);
            this.payee.Name = "payee";
            this.payee.Size = new System.Drawing.Size(78, 24);
            this.payee.TabIndex = 22;
            this.payee.TabStop = true;
            this.payee.Text = "Payee";
            this.payee.UseVisualStyleBackColor = true;
            this.payee.CheckedChanged += new System.EventHandler(this.payee_CheckedChanged);
            // 
            // amtTxtBox
            // 
            this.amtTxtBox.Location = new System.Drawing.Point(416, 96);
            this.amtTxtBox.Name = "amtTxtBox";
            this.amtTxtBox.Size = new System.Drawing.Size(200, 26);
            this.amtTxtBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Payer/Payee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Amount";
            // 
            // alertLbl
            // 
            this.alertLbl.AutoSize = true;
            this.alertLbl.Location = new System.Drawing.Point(10, 9);
            this.alertLbl.Name = "alertLbl";
            this.alertLbl.Size = new System.Drawing.Size(0, 20);
            this.alertLbl.TabIndex = 39;
            // 
            // EditTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 707);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditTransaction";
            this.Text = "EditTransaction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.editTransactionTypegroupBox1.ResumeLayout(false);
            this.editTransactionTypegroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox transactionIDTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox descTextBox1;
        private System.Windows.Forms.DateTimePicker transactionDate;
        private System.Windows.Forms.ListBox payerPayeeList;
        private System.Windows.Forms.RadioButton payer;
        private System.Windows.Forms.RadioButton payee;
        private System.Windows.Forms.TextBox amtTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button transactionUpadteBtn;
        private System.Windows.Forms.Button transDeleteBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox editTransactionTypegroupBox1;
        private System.Windows.Forms.RadioButton editExpenseRadioButton1;
        private System.Windows.Forms.RadioButton editIncomeRadioButton1;
        private System.Windows.Forms.TextBox payerOrPayeeIdtextBox1;
        private System.Windows.Forms.Label label9;
        private TypeRadioButton occurenceTypeRadioButton1;
        private System.Windows.Forms.Label alertLbl;
    }
}