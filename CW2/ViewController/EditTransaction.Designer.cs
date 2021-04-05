
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
            this.onTimeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.recurranceRadioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.transactionID = new System.Windows.Forms.TextBox();
            this.transactionUpadteBtn = new System.Windows.Forms.Button();
            this.transDeleteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.transDeleteBtn);
            this.panel1.Controls.Add(this.transactionUpadteBtn);
            this.panel1.Controls.Add(this.transactionID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.onTimeRadioButton1);
            this.panel1.Controls.Add(this.recurranceRadioButton1);
            this.panel1.Controls.Add(this.label1);
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
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 622);
            this.panel1.TabIndex = 0;
            // 
            // onTimeRadioButton1
            // 
            this.onTimeRadioButton1.AutoSize = true;
            this.onTimeRadioButton1.Location = new System.Drawing.Point(529, 347);
            this.onTimeRadioButton1.Name = "onTimeRadioButton1";
            this.onTimeRadioButton1.Size = new System.Drawing.Size(98, 24);
            this.onTimeRadioButton1.TabIndex = 29;
            this.onTimeRadioButton1.TabStop = true;
            this.onTimeRadioButton1.Text = "OneTime";
            this.onTimeRadioButton1.UseVisualStyleBackColor = true;
            // 
            // recurranceRadioButton1
            // 
            this.recurranceRadioButton1.AutoSize = true;
            this.recurranceRadioButton1.Location = new System.Drawing.Point(416, 347);
            this.recurranceRadioButton1.Name = "recurranceRadioButton1";
            this.recurranceRadioButton1.Size = new System.Drawing.Size(87, 24);
            this.recurranceRadioButton1.TabIndex = 28;
            this.recurranceRadioButton1.TabStop = true;
            this.recurranceRadioButton1.Text = "Repeat";
            this.recurranceRadioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Occurence Type";
            // 
            // descTextBox1
            // 
            this.descTextBox1.Location = new System.Drawing.Point(419, 423);
            this.descTextBox1.Name = "descTextBox1";
            this.descTextBox1.Size = new System.Drawing.Size(200, 96);
            this.descTextBox1.TabIndex = 26;
            this.descTextBox1.Text = "";
            // 
            // transactionDate
            // 
            this.transactionDate.Location = new System.Drawing.Point(416, 283);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.Size = new System.Drawing.Size(200, 26);
            this.transactionDate.TabIndex = 25;
            // 
            // payerPayeeList
            // 
            this.payerPayeeList.FormattingEnabled = true;
            this.payerPayeeList.ItemHeight = 20;
            this.payerPayeeList.Location = new System.Drawing.Point(416, 219);
            this.payerPayeeList.Name = "payerPayeeList";
            this.payerPayeeList.Size = new System.Drawing.Size(200, 24);
            this.payerPayeeList.TabIndex = 24;
            // 
            // payer
            // 
            this.payer.AutoSize = true;
            this.payer.Location = new System.Drawing.Point(542, 161);
            this.payer.Name = "payer";
            this.payer.Size = new System.Drawing.Size(74, 24);
            this.payer.TabIndex = 23;
            this.payer.TabStop = true;
            this.payer.Text = "Payer";
            this.payer.UseVisualStyleBackColor = true;
            // 
            // payee
            // 
            this.payee.AutoSize = true;
            this.payee.Location = new System.Drawing.Point(416, 161);
            this.payee.Name = "payee";
            this.payee.Size = new System.Drawing.Size(78, 24);
            this.payee.TabIndex = 22;
            this.payee.TabStop = true;
            this.payee.Text = "Payee";
            this.payee.UseVisualStyleBackColor = true;
            // 
            // amtTxt
            // 
            this.amtTxt.Location = new System.Drawing.Point(416, 96);
            this.amtTxt.Name = "amtTxt";
            this.amtTxt.Size = new System.Drawing.Size(200, 26);
            this.amtTxt.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Payer/Payee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 161);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "TransctionID";
            // 
            // transactionID
            // 
            this.transactionID.Location = new System.Drawing.Point(416, 35);
            this.transactionID.Name = "transactionID";
            this.transactionID.ReadOnly = true;
            this.transactionID.Size = new System.Drawing.Size(200, 26);
            this.transactionID.TabIndex = 31;
            // 
            // transactionUpadteBtn
            // 
            this.transactionUpadteBtn.BackColor = System.Drawing.Color.Silver;
            this.transactionUpadteBtn.Location = new System.Drawing.Point(240, 560);
            this.transactionUpadteBtn.Name = "transactionUpadteBtn";
            this.transactionUpadteBtn.Size = new System.Drawing.Size(75, 29);
            this.transactionUpadteBtn.TabIndex = 32;
            this.transactionUpadteBtn.Text = "Update";
            this.transactionUpadteBtn.UseVisualStyleBackColor = false;
            // 
            // transDeleteBtn
            // 
            this.transDeleteBtn.BackColor = System.Drawing.Color.Silver;
            this.transDeleteBtn.Location = new System.Drawing.Point(400, 560);
            this.transDeleteBtn.Name = "transDeleteBtn";
            this.transDeleteBtn.Size = new System.Drawing.Size(75, 29);
            this.transDeleteBtn.TabIndex = 33;
            this.transDeleteBtn.Text = "Delete";
            this.transDeleteBtn.UseVisualStyleBackColor = false;
            // 
            // EditTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 624);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditTransaction";
            this.Text = "EditTransaction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox transactionID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton onTimeRadioButton1;
        private System.Windows.Forms.RadioButton recurranceRadioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox descTextBox1;
        private System.Windows.Forms.DateTimePicker transactionDate;
        private System.Windows.Forms.ListBox payerPayeeList;
        private System.Windows.Forms.RadioButton payer;
        private System.Windows.Forms.RadioButton payee;
        private System.Windows.Forms.TextBox amtTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button transactionUpadteBtn;
        private System.Windows.Forms.Button transDeleteBtn;
    }
}