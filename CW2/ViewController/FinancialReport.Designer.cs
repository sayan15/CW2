
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
            this.payerPayee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.viewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.financialReportView)).BeginInit();
            this.SuspendLayout();
            // 
            // financialReportView
            // 
            this.financialReportView.BackgroundColor = System.Drawing.Color.Azure;
            this.financialReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.financialReportView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransNumber,
            this.Amount,
            this.type,
            this.payerPayee,
            this.editButton});
            this.financialReportView.Location = new System.Drawing.Point(2, 0);
            this.financialReportView.Name = "financialReportView";
            this.financialReportView.RowHeadersWidth = 62;
            this.financialReportView.RowTemplate.Height = 28;
            this.financialReportView.Size = new System.Drawing.Size(767, 673);
            this.financialReportView.TabIndex = 2;
            // 
            // TransNumber
            // 
            this.TransNumber.HeaderText = "TransactionNumber";
            this.TransNumber.MinimumWidth = 8;
            this.TransNumber.Name = "TransNumber";
            this.TransNumber.ReadOnly = true;
            this.TransNumber.Width = 150;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 150;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 8;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 150;
            // 
            // payerPayee
            // 
            this.payerPayee.HeaderText = "PayeeOrPayer";
            this.payerPayee.MinimumWidth = 8;
            this.payerPayee.Name = "payerPayee";
            this.payerPayee.ReadOnly = true;
            this.payerPayee.Width = 150;
            // 
            // editButton
            // 
            this.editButton.HeaderText = "Edit";
            this.editButton.MinimumWidth = 8;
            this.editButton.Name = "editButton";
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
            // 
            // FinancialReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1108, 673);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn TransNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn payerPayee;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker1;
        private System.Windows.Forms.DateTimePicker toDateTimePicker1;
        private System.Windows.Forms.Button viewBtn;
    }
}