
namespace CW2.ViewController
{
    partial class ViewEvents
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
            this.eventDataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OccurenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.taskRadioButton1 = new System.Windows.Forms.RadioButton();
            this.appointmentRadioButton1 = new System.Windows.Forms.RadioButton();
            this.viewButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventDataGridView1
            // 
            this.eventDataGridView1.AllowUserToAddRows = false;
            this.eventDataGridView1.AllowUserToDeleteRows = false;
            this.eventDataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.eventDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EventType,
            this.OccurenceType,
            this.Date,
            this.Description,
            this.Button});
            this.eventDataGridView1.Location = new System.Drawing.Point(0, 2);
            this.eventDataGridView1.Name = "eventDataGridView1";
            this.eventDataGridView1.RowHeadersWidth = 62;
            this.eventDataGridView1.RowTemplate.Height = 28;
            this.eventDataGridView1.Size = new System.Drawing.Size(967, 636);
            this.eventDataGridView1.TabIndex = 0;
            this.eventDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventDataGridView1_CellClick);
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
            // EventType
            // 
            this.EventType.DataPropertyName = "EventType";
            this.EventType.HeaderText = "EventType";
            this.EventType.MinimumWidth = 8;
            this.EventType.Name = "EventType";
            this.EventType.ReadOnly = true;
            this.EventType.Width = 150;
            // 
            // OccurenceType
            // 
            this.OccurenceType.DataPropertyName = "OccurenceType";
            this.OccurenceType.HeaderText = "OccurenceType";
            this.OccurenceType.MinimumWidth = 8;
            this.OccurenceType.Name = "OccurenceType";
            this.OccurenceType.ReadOnly = true;
            this.OccurenceType.Width = 150;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
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
            // Button
            // 
            this.Button.HeaderText = "Button";
            this.Button.MinimumWidth = 8;
            this.Button.Name = "Button";
            this.Button.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Button.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Button.Text = "Edit";
            this.Button.UseColumnTextForButtonValue = true;
            this.Button.Width = 150;
            // 
            // taskRadioButton1
            // 
            this.taskRadioButton1.AutoSize = true;
            this.taskRadioButton1.Location = new System.Drawing.Point(1018, 56);
            this.taskRadioButton1.Name = "taskRadioButton1";
            this.taskRadioButton1.Size = new System.Drawing.Size(68, 24);
            this.taskRadioButton1.TabIndex = 1;
            this.taskRadioButton1.TabStop = true;
            this.taskRadioButton1.Text = "Task";
            this.taskRadioButton1.UseVisualStyleBackColor = true;
            // 
            // appointmentRadioButton1
            // 
            this.appointmentRadioButton1.AutoSize = true;
            this.appointmentRadioButton1.Location = new System.Drawing.Point(1126, 56);
            this.appointmentRadioButton1.Name = "appointmentRadioButton1";
            this.appointmentRadioButton1.Size = new System.Drawing.Size(125, 24);
            this.appointmentRadioButton1.TabIndex = 2;
            this.appointmentRadioButton1.TabStop = true;
            this.appointmentRadioButton1.Text = "Appointment";
            this.appointmentRadioButton1.UseVisualStyleBackColor = true;
            // 
            // viewButton1
            // 
            this.viewButton1.BackColor = System.Drawing.Color.Silver;
            this.viewButton1.Location = new System.Drawing.Point(1068, 115);
            this.viewButton1.Name = "viewButton1";
            this.viewButton1.Size = new System.Drawing.Size(84, 30);
            this.viewButton1.TabIndex = 3;
            this.viewButton1.Text = "View";
            this.viewButton1.UseVisualStyleBackColor = false;
            this.viewButton1.Click += new System.EventHandler(this.viewButton1_Click);
            // 
            // ViewEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1276, 638);
            this.Controls.Add(this.viewButton1);
            this.Controls.Add(this.appointmentRadioButton1);
            this.Controls.Add(this.taskRadioButton1);
            this.Controls.Add(this.eventDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewEvents";
            this.Text = "ViewEvents";
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView eventDataGridView1;
        private System.Windows.Forms.RadioButton taskRadioButton1;
        private System.Windows.Forms.RadioButton appointmentRadioButton1;
        private System.Windows.Forms.Button viewButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OccurenceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewButtonColumn Button;
    }
}