
namespace CW2.ViewController
{
    partial class EditEvent
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
            this.occurenceTypeRadBtn = new CW2.TypeRadioButton();
            this.eventDeleteBtn = new System.Windows.Forms.Button();
            this.eventUpdateBtn = new System.Windows.Forms.Button();
            this.evntIDTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eventDescTextBox1 = new System.Windows.Forms.RichTextBox();
            this.eventDate = new System.Windows.Forms.DateTimePicker();
            this.appointRadioButton2 = new System.Windows.Forms.RadioButton();
            this.taskradioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.occurenceTypeRadBtn);
            this.panel1.Controls.Add(this.eventDeleteBtn);
            this.panel1.Controls.Add(this.eventUpdateBtn);
            this.panel1.Controls.Add(this.evntIDTxtBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.eventDescTextBox1);
            this.panel1.Controls.Add(this.eventDate);
            this.panel1.Controls.Add(this.appointRadioButton2);
            this.panel1.Controls.Add(this.taskradioButton1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 544);
            this.panel1.TabIndex = 0;
            // 
            // occurenceTypeRadBtn
            // 
            this.occurenceTypeRadBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.occurenceTypeRadBtn.Location = new System.Drawing.Point(342, 157);
            this.occurenceTypeRadBtn.Name = "occurenceTypeRadBtn";
            this.occurenceTypeRadBtn.OneTime = false;
            this.occurenceTypeRadBtn.Repeat = false;
            this.occurenceTypeRadBtn.Size = new System.Drawing.Size(265, 58);
            this.occurenceTypeRadBtn.TabIndex = 33;
            // 
            // eventDeleteBtn
            // 
            this.eventDeleteBtn.BackColor = System.Drawing.Color.Silver;
            this.eventDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventDeleteBtn.Location = new System.Drawing.Point(354, 452);
            this.eventDeleteBtn.Name = "eventDeleteBtn";
            this.eventDeleteBtn.Size = new System.Drawing.Size(75, 32);
            this.eventDeleteBtn.TabIndex = 32;
            this.eventDeleteBtn.Text = "Delete";
            this.eventDeleteBtn.UseVisualStyleBackColor = false;
            this.eventDeleteBtn.Click += new System.EventHandler(this.eventDeleteBtn_Click);
            // 
            // eventUpdateBtn
            // 
            this.eventUpdateBtn.BackColor = System.Drawing.Color.Silver;
            this.eventUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventUpdateBtn.Location = new System.Drawing.Point(211, 452);
            this.eventUpdateBtn.Name = "eventUpdateBtn";
            this.eventUpdateBtn.Size = new System.Drawing.Size(75, 32);
            this.eventUpdateBtn.TabIndex = 31;
            this.eventUpdateBtn.Text = "Update";
            this.eventUpdateBtn.UseVisualStyleBackColor = false;
            this.eventUpdateBtn.Click += new System.EventHandler(this.eventUpdateBtn_Click);
            // 
            // evntIDTxtBox
            // 
            this.evntIDTxtBox.Location = new System.Drawing.Point(342, 46);
            this.evntIDTxtBox.Name = "evntIDTxtBox";
            this.evntIDTxtBox.ReadOnly = true;
            this.evntIDTxtBox.Size = new System.Drawing.Size(265, 26);
            this.evntIDTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "EventId";
            // 
            // eventDescTextBox1
            // 
            this.eventDescTextBox1.Location = new System.Drawing.Point(342, 297);
            this.eventDescTextBox1.Name = "eventDescTextBox1";
            this.eventDescTextBox1.Size = new System.Drawing.Size(265, 96);
            this.eventDescTextBox1.TabIndex = 7;
            this.eventDescTextBox1.Text = "";
            // 
            // eventDate
            // 
            this.eventDate.Location = new System.Drawing.Point(342, 232);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(265, 26);
            this.eventDate.TabIndex = 6;
            // 
            // appointRadioButton2
            // 
            this.appointRadioButton2.AutoSize = true;
            this.appointRadioButton2.Location = new System.Drawing.Point(493, 107);
            this.appointRadioButton2.Name = "appointRadioButton2";
            this.appointRadioButton2.Size = new System.Drawing.Size(125, 24);
            this.appointRadioButton2.TabIndex = 3;
            this.appointRadioButton2.TabStop = true;
            this.appointRadioButton2.Text = "Appointment";
            this.appointRadioButton2.UseVisualStyleBackColor = true;
            // 
            // taskradioButton1
            // 
            this.taskradioButton1.AutoSize = true;
            this.taskradioButton1.Location = new System.Drawing.Point(342, 109);
            this.taskradioButton1.Name = "taskradioButton1";
            this.taskradioButton1.Size = new System.Drawing.Size(68, 24);
            this.taskradioButton1.TabIndex = 2;
            this.taskradioButton1.TabStop = true;
            this.taskradioButton1.Text = "Task";
            this.taskradioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Occcurence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Event Type";
            // 
            // EditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 542);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditEvent";
            this.Text = "EditEvent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox evntIDTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox eventDescTextBox1;
        private System.Windows.Forms.DateTimePicker eventDate;
        private System.Windows.Forms.RadioButton appointRadioButton2;
        private System.Windows.Forms.RadioButton taskradioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button eventUpdateBtn;
        private System.Windows.Forms.Button eventDeleteBtn;
        private TypeRadioButton occurenceTypeRadBtn;
    }
}