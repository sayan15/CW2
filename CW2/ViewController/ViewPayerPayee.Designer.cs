
namespace CW2.ViewController
{
    partial class ViewPayerPayee
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.payeeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.payerRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.address,
            this.mail,
            this.phNo,
            this.edit});
            this.dataGridView1.Location = new System.Drawing.Point(4, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(816, 684);
            this.dataGridView1.TabIndex = 0;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Name";
            this.customerName.MinimumWidth = 8;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 150;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 8;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 150;
            // 
            // mail
            // 
            this.mail.HeaderText = "Mail";
            this.mail.MinimumWidth = 8;
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Width = 150;
            // 
            // phNo
            // 
            this.phNo.HeaderText = "PhoneNumber";
            this.phNo.MinimumWidth = 8;
            this.phNo.Name = "phNo";
            this.phNo.ReadOnly = true;
            this.phNo.Width = 150;
            // 
            // edit
            // 
            this.edit.HeaderText = "Edit";
            this.edit.MinimumWidth = 8;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 150;
            // 
            // payeeRadioButton1
            // 
            this.payeeRadioButton1.AutoSize = true;
            this.payeeRadioButton1.Location = new System.Drawing.Point(867, 89);
            this.payeeRadioButton1.Name = "payeeRadioButton1";
            this.payeeRadioButton1.Size = new System.Drawing.Size(78, 24);
            this.payeeRadioButton1.TabIndex = 1;
            this.payeeRadioButton1.TabStop = true;
            this.payeeRadioButton1.Text = "Payee";
            this.payeeRadioButton1.UseVisualStyleBackColor = true;
            // 
            // payerRadioButton
            // 
            this.payerRadioButton.AutoSize = true;
            this.payerRadioButton.Location = new System.Drawing.Point(981, 89);
            this.payerRadioButton.Name = "payerRadioButton";
            this.payerRadioButton.Size = new System.Drawing.Size(74, 24);
            this.payerRadioButton.TabIndex = 2;
            this.payerRadioButton.TabStop = true;
            this.payerRadioButton.Text = "Payer";
            this.payerRadioButton.UseVisualStyleBackColor = true;
            // 
            // ViewPayerPayee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1095, 685);
            this.Controls.Add(this.payerRadioButton);
            this.Controls.Add(this.payeeRadioButton1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewPayerPayee";
            this.Text = "ViewPayerPayee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn phNo;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.RadioButton payeeRadioButton1;
        private System.Windows.Forms.RadioButton payerRadioButton;
    }
}