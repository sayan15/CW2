
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
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.descTextBox1 = new System.Windows.Forms.RichTextBox();
            this.transactionDate = new System.Windows.Forms.DateTimePicker();
            this.payer = new System.Windows.Forms.RadioButton();
            this.payee = new System.Windows.Forms.RadioButton();
            this.amtTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.payerPayeeList = new System.Windows.Forms.ListBox();
            this.alertLabel = new System.Windows.Forms.Label();
            this.transactonTypeLbl = new System.Windows.Forms.Label();
            this.transactionTypegroupBox1 = new System.Windows.Forms.GroupBox();
            this.incomeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.expenseRadioButton1 = new System.Windows.Forms.RadioButton();
            this.occurenceTypeRadioButton1 = new CW2.TypeRadioButton();
            this.panel1.SuspendLayout();
            this.transactionTypegroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.transactionTypegroupBox1);
            this.panel1.Controls.Add(this.transactonTypeLbl);
            this.panel1.Controls.Add(this.alertLabel);
            this.panel1.Controls.Add(this.payerPayeeList);
            this.panel1.Controls.Add(this.occurenceTypeRadioButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.descTextBox1);
            this.panel1.Controls.Add(this.transactionDate);
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
            this.panel1.Size = new System.Drawing.Size(822, 790);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Occurence Type";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(353, 610);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 34);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // descTextBox1
            // 
            this.descTextBox1.Location = new System.Drawing.Point(437, 488);
            this.descTextBox1.Name = "descTextBox1";
            this.descTextBox1.Size = new System.Drawing.Size(239, 54);
            this.descTextBox1.TabIndex = 11;
            this.descTextBox1.Text = "";
            // 
            // transactionDate
            // 
            this.transactionDate.Location = new System.Drawing.Point(438, 336);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.Size = new System.Drawing.Size(239, 26);
            this.transactionDate.TabIndex = 10;
            // 
            // payer
            // 
            this.payer.AutoSize = true;
            this.payer.Location = new System.Drawing.Point(603, 121);
            this.payer.Name = "payer";
            this.payer.Size = new System.Drawing.Size(74, 24);
            this.payer.TabIndex = 8;
            this.payer.Text = "Payer";
            this.payer.UseVisualStyleBackColor = true;
            this.payer.CheckedChanged += new System.EventHandler(this.payer_CheckedChanged);
            // 
            // payee
            // 
            this.payee.AutoSize = true;
            this.payee.Location = new System.Drawing.Point(438, 121);
            this.payee.Name = "payee";
            this.payee.Size = new System.Drawing.Size(78, 24);
            this.payee.TabIndex = 7;
            this.payee.Text = "Payee";
            this.payee.UseVisualStyleBackColor = true;
            this.payee.CheckedChanged += new System.EventHandler(this.payee_CheckedChanged);
            // 
            // amtTxt
            // 
            this.amtTxt.Location = new System.Drawing.Point(438, 56);
            this.amtTxt.Name = "amtTxt";
            this.amtTxt.Size = new System.Drawing.Size(239, 26);
            this.amtTxt.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payer/Payee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // payerPayeeList
            // 
            this.payerPayeeList.FormattingEnabled = true;
            this.payerPayeeList.ItemHeight = 20;
            this.payerPayeeList.Location = new System.Drawing.Point(437, 177);
            this.payerPayeeList.Name = "payerPayeeList";
            this.payerPayeeList.Size = new System.Drawing.Size(239, 44);
            this.payerPayeeList.TabIndex = 15;
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.Location = new System.Drawing.Point(26, 20);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(0, 20);
            this.alertLabel.TabIndex = 16;
            // 
            // transactonTypeLbl
            // 
            this.transactonTypeLbl.AutoSize = true;
            this.transactonTypeLbl.Location = new System.Drawing.Point(161, 261);
            this.transactonTypeLbl.Name = "transactonTypeLbl";
            this.transactonTypeLbl.Size = new System.Drawing.Size(126, 20);
            this.transactonTypeLbl.TabIndex = 17;
            this.transactonTypeLbl.Text = "TransactionType";
            // 
            // transactionTypegroupBox1
            // 
            this.transactionTypegroupBox1.Controls.Add(this.expenseRadioButton1);
            this.transactionTypegroupBox1.Controls.Add(this.incomeRadioButton1);
            this.transactionTypegroupBox1.Location = new System.Drawing.Point(428, 238);
            this.transactionTypegroupBox1.Name = "transactionTypegroupBox1";
            this.transactionTypegroupBox1.Size = new System.Drawing.Size(322, 54);
            this.transactionTypegroupBox1.TabIndex = 18;
            this.transactionTypegroupBox1.TabStop = false;
            // 
            // incomeRadioButton1
            // 
            this.incomeRadioButton1.AutoSize = true;
            this.incomeRadioButton1.Checked = true;
            this.incomeRadioButton1.Location = new System.Drawing.Point(12, 21);
            this.incomeRadioButton1.Name = "incomeRadioButton1";
            this.incomeRadioButton1.Size = new System.Drawing.Size(87, 24);
            this.incomeRadioButton1.TabIndex = 0;
            this.incomeRadioButton1.TabStop = true;
            this.incomeRadioButton1.Text = "Income";
            this.incomeRadioButton1.UseVisualStyleBackColor = true;
            // 
            // expenseRadioButton1
            // 
            this.expenseRadioButton1.AutoSize = true;
            this.expenseRadioButton1.Location = new System.Drawing.Point(180, 21);
            this.expenseRadioButton1.Name = "expenseRadioButton1";
            this.expenseRadioButton1.Size = new System.Drawing.Size(96, 24);
            this.expenseRadioButton1.TabIndex = 1;
            this.expenseRadioButton1.Text = "Expense";
            this.expenseRadioButton1.UseVisualStyleBackColor = true;
            // 
            // occurenceTypeRadioButton1
            // 
            this.occurenceTypeRadioButton1.BackColor = System.Drawing.Color.AliceBlue;
            this.occurenceTypeRadioButton1.ForeColor = System.Drawing.Color.Black;
            this.occurenceTypeRadioButton1.Location = new System.Drawing.Point(428, 388);
            this.occurenceTypeRadioButton1.Name = "occurenceTypeRadioButton1";
            this.occurenceTypeRadioButton1.OneTime = false;
            this.occurenceTypeRadioButton1.Repeat = false;
            this.occurenceTypeRadioButton1.Size = new System.Drawing.Size(265, 54);
            this.occurenceTypeRadioButton1.TabIndex = 14;
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 789);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddTransaction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.transactionTypegroupBox1.ResumeLayout(false);
            this.transactionTypegroupBox1.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker transactionDate;
        private System.Windows.Forms.RichTextBox descTextBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private TypeRadioButton occurenceTypeRadioButton1;
        private System.Windows.Forms.ListBox payerPayeeList;
        private System.Windows.Forms.Label alertLabel;
        private System.Windows.Forms.Label transactonTypeLbl;
        private System.Windows.Forms.GroupBox transactionTypegroupBox1;
        private System.Windows.Forms.RadioButton incomeRadioButton1;
        private System.Windows.Forms.RadioButton expenseRadioButton1;
    }
}