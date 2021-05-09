
namespace CW2.ViewController
{
    partial class FinancialReport
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
            this.financialReportView = new System.Windows.Forms.DataGridView();
            this.TransNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.viewBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.totalIncometextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalExpensetextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.netTextBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.financialReportView)).BeginInit();
            this.SuspendLayout();
            // 
            // financialReportView
            // 
            this.financialReportView.AllowUserToAddRows = false;
            this.financialReportView.AllowUserToDeleteRows = false;
            this.financialReportView.BackgroundColor = System.Drawing.Color.Azure;
            this.financialReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.financialReportView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransNumber,
            this.Amount,
            this.type,
            this.Description,
            this.editButton});
            this.financialReportView.Location = new System.Drawing.Point(2, 0);
            this.financialReportView.Name = "financialReportView";
            this.financialReportView.RowHeadersWidth = 62;
            this.financialReportView.RowTemplate.Height = 28;
            this.financialReportView.Size = new System.Drawing.Size(767, 673);
            this.financialReportView.TabIndex = 2;
            this.financialReportView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.financialReportView_CellClick);
            // 
            // TransNumber
            // 
            this.TransNumber.DataPropertyName = "Id";
            this.TransNumber.HeaderText = "Id";
            this.TransNumber.MinimumWidth = 8;
            this.TransNumber.Name = "TransNumber";
            this.TransNumber.ReadOnly = true;
            this.TransNumber.Width = 150;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 150;
            // 
            // type
            // 
            this.type.DataPropertyName = "TransactionType";
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 8;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 150;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 150;
            // 
            // editButton
            // 
            this.editButton.HeaderText = "Edit";
            this.editButton.MinimumWidth = 8;
            this.editButton.Name = "editButton";
            this.editButton.Text = "Edit";
            this.editButton.UseColumnTextForButtonValue = true;
            this.editButton.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(804, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(804, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // fromDateTimePicker1
            // 
            this.fromDateTimePicker1.Location = new System.Drawing.Point(896, 90);
            this.fromDateTimePicker1.Name = "fromDateTimePicker1";
            this.fromDateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.fromDateTimePicker1.TabIndex = 4;
            // 
            // toDateTimePicker1
            // 
            this.toDateTimePicker1.Location = new System.Drawing.Point(896, 160);
            this.toDateTimePicker1.Name = "toDateTimePicker1";
            this.toDateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.toDateTimePicker1.TabIndex = 5;
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBtn.Location = new System.Drawing.Point(896, 238);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 39);
            this.viewBtn.TabIndex = 6;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(790, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Income";
            // 
            // totalIncometextBox1
            // 
            this.totalIncometextBox1.Enabled = false;
            this.totalIncometextBox1.Location = new System.Drawing.Point(980, 342);
            this.totalIncometextBox1.Name = "totalIncometextBox1";
            this.totalIncometextBox1.Size = new System.Drawing.Size(100, 26);
            this.totalIncometextBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(790, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Expense";
            // 
            // totalExpensetextBox1
            // 
            this.totalExpensetextBox1.Enabled = false;
            this.totalExpensetextBox1.Location = new System.Drawing.Point(980, 414);
            this.totalExpensetextBox1.Name = "totalExpensetextBox1";
            this.totalExpensetextBox1.Size = new System.Drawing.Size(100, 26);
            this.totalExpensetextBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(790, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Net Value";
            // 
            // netTextBox1
            // 
            this.netTextBox1.Location = new System.Drawing.Point(980, 484);
            this.netTextBox1.Name = "netTextBox1";
            this.netTextBox1.Size = new System.Drawing.Size(100, 26);
            this.netTextBox1.TabIndex = 12;
            // 
            // FinancialReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1108, 673);
            this.Controls.Add(this.netTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalExpensetextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalIncometextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.toDateTimePicker1);
            this.Controls.Add(this.fromDateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.financialReportView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FinancialReport";
            this.Text = "FinancialReport";
            ((System.ComponentModel.ISupportInitialize)(this.financialReportView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView financialReportView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker1;
        private System.Windows.Forms.DateTimePicker toDateTimePicker1;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalIncometextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalExpensetextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox netTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
    }
}