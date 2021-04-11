
namespace CW2.ViewController
{
    partial class AddPayeeOrPayer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.mailtextBox1 = new System.Windows.Forms.TextBox();
            this.phonetextBox1 = new System.Windows.Forms.TextBox();
            this.addressRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.payerRadioBtn = new System.Windows.Forms.RadioButton();
            this.payeeRadioBtn = new System.Windows.Forms.RadioButton();
            this.payerAddbutton1 = new System.Windows.Forms.Button();
            this.alertLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // nametextBox1
            // 
            this.nametextBox1.Location = new System.Drawing.Point(376, 62);
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(200, 26);
            this.nametextBox1.TabIndex = 5;
            // 
            // mailtextBox1
            // 
            this.mailtextBox1.Location = new System.Drawing.Point(376, 126);
            this.mailtextBox1.Name = "mailtextBox1";
            this.mailtextBox1.Size = new System.Drawing.Size(200, 26);
            this.mailtextBox1.TabIndex = 6;
            // 
            // phonetextBox1
            // 
            this.phonetextBox1.Location = new System.Drawing.Point(376, 194);
            this.phonetextBox1.Name = "phonetextBox1";
            this.phonetextBox1.Size = new System.Drawing.Size(200, 26);
            this.phonetextBox1.TabIndex = 7;
            // 
            // addressRichTextBox1
            // 
            this.addressRichTextBox1.Location = new System.Drawing.Point(376, 268);
            this.addressRichTextBox1.Name = "addressRichTextBox1";
            this.addressRichTextBox1.Size = new System.Drawing.Size(200, 96);
            this.addressRichTextBox1.TabIndex = 8;
            this.addressRichTextBox1.Text = "";
            // 
            // payerRadioBtn
            // 
            this.payerRadioBtn.AutoSize = true;
            this.payerRadioBtn.Location = new System.Drawing.Point(502, 398);
            this.payerRadioBtn.Name = "payerRadioBtn";
            this.payerRadioBtn.Size = new System.Drawing.Size(74, 24);
            this.payerRadioBtn.TabIndex = 10;
            this.payerRadioBtn.Text = "Payer";
            this.payerRadioBtn.UseVisualStyleBackColor = true;
            // 
            // payeeRadioBtn
            // 
            this.payeeRadioBtn.AutoSize = true;
            this.payeeRadioBtn.Checked = true;
            this.payeeRadioBtn.Location = new System.Drawing.Point(376, 398);
            this.payeeRadioBtn.Name = "payeeRadioBtn";
            this.payeeRadioBtn.Size = new System.Drawing.Size(78, 24);
            this.payeeRadioBtn.TabIndex = 9;
            this.payeeRadioBtn.TabStop = true;
            this.payeeRadioBtn.Text = "Payee";
            this.payeeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // payerAddbutton1
            // 
            this.payerAddbutton1.BackColor = System.Drawing.Color.Silver;
            this.payerAddbutton1.Location = new System.Drawing.Point(303, 513);
            this.payerAddbutton1.Name = "payerAddbutton1";
            this.payerAddbutton1.Size = new System.Drawing.Size(75, 35);
            this.payerAddbutton1.TabIndex = 11;
            this.payerAddbutton1.Text = "Add";
            this.payerAddbutton1.UseVisualStyleBackColor = false;
            this.payerAddbutton1.Click += new System.EventHandler(this.payerAddbutton1_Click);
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertLabel.Location = new System.Drawing.Point(12, 9);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(0, 23);
            this.alertLabel.TabIndex = 12;
            // 
            // AddPayeeOrPayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(701, 617);
            this.Controls.Add(this.alertLabel);
            this.Controls.Add(this.payerAddbutton1);
            this.Controls.Add(this.payerRadioBtn);
            this.Controls.Add(this.payeeRadioBtn);
            this.Controls.Add(this.addressRichTextBox1);
            this.Controls.Add(this.phonetextBox1);
            this.Controls.Add(this.mailtextBox1);
            this.Controls.Add(this.nametextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddPayeeOrPayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPayeeOrPayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nametextBox1;
        private System.Windows.Forms.TextBox mailtextBox1;
        private System.Windows.Forms.TextBox phonetextBox1;
        private System.Windows.Forms.RichTextBox addressRichTextBox1;
        private System.Windows.Forms.RadioButton payerRadioBtn;
        private System.Windows.Forms.RadioButton payeeRadioBtn;
        private System.Windows.Forms.Button payerAddbutton1;
        private System.Windows.Forms.Label alertLabel;
    }
}