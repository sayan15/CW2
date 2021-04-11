
namespace CW2.ViewController
{
    partial class EditPayerOrPayee
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
            this.alertLabel = new System.Windows.Forms.Label();
            this.IdtextBox1 = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.Updatebutton1 = new System.Windows.Forms.Button();
            this.editPayerRadioBtn = new System.Windows.Forms.RadioButton();
            this.editPayeeRadioBtn = new System.Windows.Forms.RadioButton();
            this.editAddressRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.editPhonetextBox1 = new System.Windows.Forms.TextBox();
            this.editMailtextBox1 = new System.Windows.Forms.TextBox();
            this.editNametextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.alertLabel);
            this.panel1.Controls.Add(this.IdtextBox1);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.Updatebutton1);
            this.panel1.Controls.Add(this.editPayerRadioBtn);
            this.panel1.Controls.Add(this.editPayeeRadioBtn);
            this.panel1.Controls.Add(this.editAddressRichTextBox1);
            this.panel1.Controls.Add(this.editPhonetextBox1);
            this.panel1.Controls.Add(this.editMailtextBox1);
            this.panel1.Controls.Add(this.editNametextBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 620);
            this.panel1.TabIndex = 0;
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.Location = new System.Drawing.Point(10, 10);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(0, 20);
            this.alertLabel.TabIndex = 26;
            // 
            // IdtextBox1
            // 
            this.IdtextBox1.Location = new System.Drawing.Point(376, 48);
            this.IdtextBox1.Name = "IdtextBox1";
            this.IdtextBox1.ReadOnly = true;
            this.IdtextBox1.Size = new System.Drawing.Size(200, 26);
            this.IdtextBox1.TabIndex = 25;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Silver;
            this.deleteBtn.Location = new System.Drawing.Point(361, 559);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 35);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Updatebutton1
            // 
            this.Updatebutton1.BackColor = System.Drawing.Color.Silver;
            this.Updatebutton1.Location = new System.Drawing.Point(226, 559);
            this.Updatebutton1.Name = "Updatebutton1";
            this.Updatebutton1.Size = new System.Drawing.Size(75, 35);
            this.Updatebutton1.TabIndex = 23;
            this.Updatebutton1.Text = "Update";
            this.Updatebutton1.UseVisualStyleBackColor = false;
            this.Updatebutton1.Click += new System.EventHandler(this.Updatebutton1_Click);
            // 
            // editPayerRadioBtn
            // 
            this.editPayerRadioBtn.AutoSize = true;
            this.editPayerRadioBtn.Location = new System.Drawing.Point(502, 447);
            this.editPayerRadioBtn.Name = "editPayerRadioBtn";
            this.editPayerRadioBtn.Size = new System.Drawing.Size(74, 24);
            this.editPayerRadioBtn.TabIndex = 22;
            this.editPayerRadioBtn.Text = "Payer";
            this.editPayerRadioBtn.UseVisualStyleBackColor = true;
            // 
            // editPayeeRadioBtn
            // 
            this.editPayeeRadioBtn.AutoSize = true;
            this.editPayeeRadioBtn.Checked = true;
            this.editPayeeRadioBtn.Location = new System.Drawing.Point(376, 447);
            this.editPayeeRadioBtn.Name = "editPayeeRadioBtn";
            this.editPayeeRadioBtn.Size = new System.Drawing.Size(78, 24);
            this.editPayeeRadioBtn.TabIndex = 21;
            this.editPayeeRadioBtn.TabStop = true;
            this.editPayeeRadioBtn.Text = "Payee";
            this.editPayeeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // editAddressRichTextBox1
            // 
            this.editAddressRichTextBox1.Location = new System.Drawing.Point(376, 317);
            this.editAddressRichTextBox1.Name = "editAddressRichTextBox1";
            this.editAddressRichTextBox1.Size = new System.Drawing.Size(200, 96);
            this.editAddressRichTextBox1.TabIndex = 20;
            this.editAddressRichTextBox1.Text = "";
            // 
            // editPhonetextBox1
            // 
            this.editPhonetextBox1.Location = new System.Drawing.Point(376, 243);
            this.editPhonetextBox1.Name = "editPhonetextBox1";
            this.editPhonetextBox1.Size = new System.Drawing.Size(200, 26);
            this.editPhonetextBox1.TabIndex = 19;
            // 
            // editMailtextBox1
            // 
            this.editMailtextBox1.Location = new System.Drawing.Point(376, 175);
            this.editMailtextBox1.Name = "editMailtextBox1";
            this.editMailtextBox1.Size = new System.Drawing.Size(200, 26);
            this.editMailtextBox1.TabIndex = 18;
            // 
            // editNametextBox1
            // 
            this.editNametextBox1.Location = new System.Drawing.Point(376, 111);
            this.editNametextBox1.Name = "editNametextBox1";
            this.editNametextBox1.Size = new System.Drawing.Size(200, 26);
            this.editNametextBox1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // EditPayerOrPayee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 622);
            this.Controls.Add(this.panel1);
            this.Name = "EditPayerOrPayee";
            this.Text = "EditPayerOrPayee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button Updatebutton1;
        private System.Windows.Forms.RadioButton editPayerRadioBtn;
        private System.Windows.Forms.RadioButton editPayeeRadioBtn;
        private System.Windows.Forms.RichTextBox editAddressRichTextBox1;
        private System.Windows.Forms.TextBox editPhonetextBox1;
        private System.Windows.Forms.TextBox editMailtextBox1;
        private System.Windows.Forms.TextBox editNametextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdtextBox1;
        private System.Windows.Forms.Label alertLabel;
    }
}