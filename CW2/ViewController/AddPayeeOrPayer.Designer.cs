
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
            this.payer = new System.Windows.Forms.RadioButton();
            this.payee = new System.Windows.Forms.RadioButton();
            this.payerAddbutton1 = new System.Windows.Forms.Button();
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
            // payer
            // 
            this.payer.AutoSize = true;
            this.payer.Location = new System.Drawing.Point(502, 398);
            this.payer.Name = "payer";
            this.payer.Size = new System.Drawing.Size(74, 24);
            this.payer.TabIndex = 10;
            this.payer.TabStop = true;
            this.payer.Text = "Payer";
            this.payer.UseVisualStyleBackColor = true;
            // 
            // payee
            // 
            this.payee.AutoSize = true;
            this.payee.Location = new System.Drawing.Point(376, 398);
            this.payee.Name = "payee";
            this.payee.Size = new System.Drawing.Size(78, 24);
            this.payee.TabIndex = 9;
            this.payee.TabStop = true;
            this.payee.Text = "Payee";
            this.payee.UseVisualStyleBackColor = true;
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
            // 
            // AddPayeeOrPayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(701, 617);
            this.Controls.Add(this.payerAddbutton1);
            this.Controls.Add(this.payer);
            this.Controls.Add(this.payee);
            this.Controls.Add(this.addressRichTextBox1);
            this.Controls.Add(this.phonetextBox1);
            this.Controls.Add(this.mailtextBox1);
            this.Controls.Add(this.nametextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddPayeeOrPayer";
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
        private System.Windows.Forms.RadioButton payer;
        private System.Windows.Forms.RadioButton payee;
        private System.Windows.Forms.Button payerAddbutton1;
    }
}