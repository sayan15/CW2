
namespace CW2.ViewController
{
    partial class AddEvent
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
            this.typeRadioButton1 = new CW2.TypeRadioButton();
            this.saveBtn = new System.Windows.Forms.Button();
            this.eventDescTextBox1 = new System.Windows.Forms.RichTextBox();
            this.eventTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.appointRadioButton2 = new System.Windows.Forms.RadioButton();
            this.taskradioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alertLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.alertLabel);
            this.panel1.Controls.Add(this.typeRadioButton1);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.eventDescTextBox1);
            this.panel1.Controls.Add(this.eventTransactionDate);
            this.panel1.Controls.Add(this.appointRadioButton2);
            this.panel1.Controls.Add(this.taskradioButton1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 515);
            this.panel1.TabIndex = 0;
            // 
            // typeRadioButton1
            // 
            this.typeRadioButton1.BackColor = System.Drawing.Color.AliceBlue;
            this.typeRadioButton1.Location = new System.Drawing.Point(388, 102);
            this.typeRadioButton1.Name = "typeRadioButton1";
            this.typeRadioButton1.OneTime = false;
            this.typeRadioButton1.Repeat = false;
            this.typeRadioButton1.Size = new System.Drawing.Size(265, 58);
            this.typeRadioButton1.TabIndex = 21;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Silver;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Location = new System.Drawing.Point(333, 409);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 34);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // eventDescTextBox1
            // 
            this.eventDescTextBox1.Location = new System.Drawing.Point(388, 245);
            this.eventDescTextBox1.Name = "eventDescTextBox1";
            this.eventDescTextBox1.Size = new System.Drawing.Size(200, 96);
            this.eventDescTextBox1.TabIndex = 19;
            this.eventDescTextBox1.Text = "";
            // 
            // eventTransactionDate
            // 
            this.eventTransactionDate.Location = new System.Drawing.Point(388, 180);
            this.eventTransactionDate.Name = "eventTransactionDate";
            this.eventTransactionDate.Size = new System.Drawing.Size(200, 26);
            this.eventTransactionDate.TabIndex = 18;
            // 
            // appointRadioButton2
            // 
            this.appointRadioButton2.AutoSize = true;
            this.appointRadioButton2.Location = new System.Drawing.Point(540, 57);
            this.appointRadioButton2.Name = "appointRadioButton2";
            this.appointRadioButton2.Size = new System.Drawing.Size(125, 24);
            this.appointRadioButton2.TabIndex = 6;
            this.appointRadioButton2.Text = "Appointment";
            this.appointRadioButton2.UseVisualStyleBackColor = true;
            // 
            // taskradioButton1
            // 
            this.taskradioButton1.AutoSize = true;
            this.taskradioButton1.Checked = true;
            this.taskradioButton1.Location = new System.Drawing.Point(388, 57);
            this.taskradioButton1.Name = "taskradioButton1";
            this.taskradioButton1.Size = new System.Drawing.Size(68, 24);
            this.taskradioButton1.TabIndex = 5;
            this.taskradioButton1.TabStop = true;
            this.taskradioButton1.Text = "Task";
            this.taskradioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Occcurence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Type";
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.Location = new System.Drawing.Point(15, 11);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(0, 20);
            this.alertLabel.TabIndex = 22;
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 505);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton appointRadioButton2;
        private System.Windows.Forms.RadioButton taskradioButton1;
        private System.Windows.Forms.DateTimePicker eventTransactionDate;
        private System.Windows.Forms.RichTextBox eventDescTextBox1;
        private System.Windows.Forms.Button saveBtn;
        private TypeRadioButton typeRadioButton1;
        private System.Windows.Forms.Label alertLabel;
    }
}