
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.payeeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.payerRadioButton = new System.Windows.Forms.RadioButton();
            this.payerOrPayeeViewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.customerName,
            this.mail,
            this.phNo,
            this.address,
            this.Type,
            this.UserId,
            this.button});
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(816, 684);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 150;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "Name";
            this.customerName.HeaderText = "Name";
            this.customerName.MinimumWidth = 8;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 150;
            // 
            // mail
            // 
            this.mail.DataPropertyName = "Mail";
            this.mail.HeaderText = "Mail";
            this.mail.MinimumWidth = 8;
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Width = 150;
            // 
            // phNo
            // 
            this.phNo.DataPropertyName = "PhoneNumber";
            this.phNo.HeaderText = "PhoneNumber";
            this.phNo.MinimumWidth = 8;
            this.phNo.Name = "phNo";
            this.phNo.ReadOnly = true;
            this.phNo.Width = 150;
            // 
            // address
            // 
            this.address.DataPropertyName = "Address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 8;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 150;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 150;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 8;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            this.UserId.Width = 150;
            // 
            // button
            // 
            this.button.HeaderText = "Buttons";
            this.button.MinimumWidth = 8;
            this.button.Name = "button";
            this.button.Text = "Edit";
            this.button.UseColumnTextForButtonValue = true;
            this.button.Width = 150;
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
            // payerOrPayeeViewBtn
            // 
            this.payerOrPayeeViewBtn.BackColor = System.Drawing.Color.Silver;
            this.payerOrPayeeViewBtn.Location = new System.Drawing.Point(920, 174);
            this.payerOrPayeeViewBtn.Name = "payerOrPayeeViewBtn";
            this.payerOrPayeeViewBtn.Size = new System.Drawing.Size(75, 33);
            this.payerOrPayeeViewBtn.TabIndex = 3;
            this.payerOrPayeeViewBtn.Text = "View";
            this.payerOrPayeeViewBtn.UseVisualStyleBackColor = false;
            this.payerOrPayeeViewBtn.Click += new System.EventHandler(this.payerOrPayeeViewBtn_Click);
            // 
            // ViewPayerPayee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1095, 685);
            this.Controls.Add(this.payerOrPayeeViewBtn);
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
        private System.Windows.Forms.RadioButton payeeRadioButton1;
        private System.Windows.Forms.RadioButton payerRadioButton;
        private System.Windows.Forms.Button payerOrPayeeViewBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn phNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewButtonColumn button;
    }
}