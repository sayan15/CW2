
namespace CW2.ViewController
{
    partial class Main
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
            this.leftLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transactioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEditTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEditToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.payeePayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEditToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.topLayout = new System.Windows.Forms.Panel();
            this.refreshPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usrLbl = new System.Windows.Forms.Label();
            this.weekEventdataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyTransdataGridView1 = new System.Windows.Forms.DataGridView();
            this.TransDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predictDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.predictbtn = new System.Windows.Forms.Button();
            this.predictedRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Predictpanel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftLayout.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.topLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekEventdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyTransdataGridView1)).BeginInit();
            this.Predictpanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftLayout
            // 
            this.leftLayout.BackColor = System.Drawing.Color.AliceBlue;
            this.leftLayout.Controls.Add(this.menuStrip1);
            this.leftLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftLayout.Location = new System.Drawing.Point(0, 71);
            this.leftLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leftLayout.Name = "leftLayout";
            this.leftLayout.Size = new System.Drawing.Size(224, 422);
            this.leftLayout.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactioToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.payeePayerToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(149, 120);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transactioToolStripMenuItem
            // 
            this.transactioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactionToolStripMenuItem,
            this.viewEditTransactionToolStripMenuItem});
            this.transactioToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactioToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.transactioToolStripMenuItem.Name = "transactioToolStripMenuItem";
            this.transactioToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
            this.transactioToolStripMenuItem.Text = "Transaction";
            // 
            // addTransactionToolStripMenuItem
            // 
            this.addTransactionToolStripMenuItem.Name = "addTransactionToolStripMenuItem";
            this.addTransactionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addTransactionToolStripMenuItem.Text = "Add Transaction";
            this.addTransactionToolStripMenuItem.Click += new System.EventHandler(this.addTransactionToolStripMenuItem_Click);
            // 
            // viewEditTransactionToolStripMenuItem
            // 
            this.viewEditTransactionToolStripMenuItem.Name = "viewEditTransactionToolStripMenuItem";
            this.viewEditTransactionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewEditTransactionToolStripMenuItem.Text = "View/Edit";
            this.viewEditTransactionToolStripMenuItem.Click += new System.EventHandler(this.viewEditTransactionToolStripMenuItem_Click);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventToolStripMenuItem,
            this.viewEditToolStripMenuItem1});
            this.eventsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.addEventToolStripMenuItem.Text = "Add Event";
            this.addEventToolStripMenuItem.Click += new System.EventHandler(this.addEventToolStripMenuItem_Click);
            // 
            // viewEditToolStripMenuItem1
            // 
            this.viewEditToolStripMenuItem1.Name = "viewEditToolStripMenuItem1";
            this.viewEditToolStripMenuItem1.Size = new System.Drawing.Size(215, 34);
            this.viewEditToolStripMenuItem1.Text = "View/Edit";
            this.viewEditToolStripMenuItem1.Click += new System.EventHandler(this.viewEditToolStripMenuItem1_Click);
            // 
            // payeePayerToolStripMenuItem
            // 
            this.payeePayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDetailsToolStripMenuItem,
            this.viewEditToolStripMenuItem2});
            this.payeePayerToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payeePayerToolStripMenuItem.Name = "payeePayerToolStripMenuItem";
            this.payeePayerToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.payeePayerToolStripMenuItem.Text = "Payee/Payer";
            // 
            // addDetailsToolStripMenuItem
            // 
            this.addDetailsToolStripMenuItem.Name = "addDetailsToolStripMenuItem";
            this.addDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.addDetailsToolStripMenuItem.Text = "Add Details";
            this.addDetailsToolStripMenuItem.Click += new System.EventHandler(this.addDetailsToolStripMenuItem_Click);
            // 
            // viewEditToolStripMenuItem2
            // 
            this.viewEditToolStripMenuItem2.Name = "viewEditToolStripMenuItem2";
            this.viewEditToolStripMenuItem2.Size = new System.Drawing.Size(224, 34);
            this.viewEditToolStripMenuItem2.Text = "View/Edit";
            this.viewEditToolStripMenuItem2.Click += new System.EventHandler(this.viewEditToolStripMenuItem2_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(225, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1207, 619);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "DASHBOARD";
            // 
            // topLayout
            // 
            this.topLayout.BackColor = System.Drawing.Color.RoyalBlue;
            this.topLayout.Controls.Add(this.refreshPicBox);
            this.topLayout.Controls.Add(this.pictureBox1);
            this.topLayout.Controls.Add(this.usrLbl);
            this.topLayout.Controls.Add(this.label1);
            this.topLayout.Controls.Add(this.panel2);
            this.topLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayout.Location = new System.Drawing.Point(0, 0);
            this.topLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topLayout.Name = "topLayout";
            this.topLayout.Size = new System.Drawing.Size(1622, 71);
            this.topLayout.TabIndex = 0;
            // 
            // refreshPicBox
            // 
            this.refreshPicBox.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.refreshPicBox.Image = global::CW2.Properties.Resources.refresh_;
            this.refreshPicBox.Location = new System.Drawing.Point(1522, 19);
            this.refreshPicBox.Name = "refreshPicBox";
            this.refreshPicBox.Size = new System.Drawing.Size(30, 28);
            this.refreshPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshPicBox.TabIndex = 6;
            this.refreshPicBox.TabStop = false;
            this.refreshPicBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CW2.Properties.Resources.Man;
            this.pictureBox1.Location = new System.Drawing.Point(1558, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // usrLbl
            // 
            this.usrLbl.AutoSize = true;
            this.usrLbl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrLbl.Location = new System.Drawing.Point(1420, 19);
            this.usrLbl.Name = "usrLbl";
            this.usrLbl.Size = new System.Drawing.Size(0, 23);
            this.usrLbl.TabIndex = 4;
            // 
            // weekEventdataGridView1
            // 
            this.weekEventdataGridView1.AllowUserToAddRows = false;
            this.weekEventdataGridView1.AllowUserToDeleteRows = false;
            this.weekEventdataGridView1.AllowUserToResizeColumns = false;
            this.weekEventdataGridView1.AllowUserToResizeRows = false;
            this.weekEventdataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.weekEventdataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weekEventdataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.weekEventdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weekEventdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.eventDate,
            this.Type,
            this.Description});
            this.weekEventdataGridView1.Location = new System.Drawing.Point(0, 0);
            this.weekEventdataGridView1.Name = "weekEventdataGridView1";
            this.weekEventdataGridView1.RowHeadersWidth = 62;
            this.weekEventdataGridView1.RowTemplate.Height = 28;
            this.weekEventdataGridView1.Size = new System.Drawing.Size(702, 422);
            this.weekEventdataGridView1.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Original Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // eventDate
            // 
            this.eventDate.HeaderText = "Next Occurence";
            this.eventDate.MinimumWidth = 8;
            this.eventDate.Name = "eventDate";
            this.eventDate.ReadOnly = true;
            this.eventDate.Width = 150;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "EventType";
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 150;
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
            // dailyTransdataGridView1
            // 
            this.dailyTransdataGridView1.AllowUserToAddRows = false;
            this.dailyTransdataGridView1.AllowUserToDeleteRows = false;
            this.dailyTransdataGridView1.AllowUserToResizeColumns = false;
            this.dailyTransdataGridView1.AllowUserToResizeRows = false;
            this.dailyTransdataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
            this.dailyTransdataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dailyTransdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyTransdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransDate,
            this.TransType,
            this.Amount,
            this.transDescription});
            this.dailyTransdataGridView1.Location = new System.Drawing.Point(708, 0);
            this.dailyTransdataGridView1.Name = "dailyTransdataGridView1";
            this.dailyTransdataGridView1.RowHeadersWidth = 62;
            this.dailyTransdataGridView1.RowTemplate.Height = 28;
            this.dailyTransdataGridView1.Size = new System.Drawing.Size(708, 422);
            this.dailyTransdataGridView1.TabIndex = 2;
            // 
            // TransDate
            // 
            this.TransDate.DataPropertyName = "Date";
            this.TransDate.HeaderText = "TransDate";
            this.TransDate.MinimumWidth = 8;
            this.TransDate.Name = "TransDate";
            this.TransDate.ReadOnly = true;
            this.TransDate.Width = 150;
            // 
            // TransType
            // 
            this.TransType.DataPropertyName = "TransactionType";
            this.TransType.HeaderText = "Transaction Type";
            this.TransType.MinimumWidth = 8;
            this.TransType.Name = "TransType";
            this.TransType.ReadOnly = true;
            this.TransType.Width = 150;
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
            // transDescription
            // 
            this.transDescription.DataPropertyName = "Description";
            this.transDescription.HeaderText = "Description";
            this.transDescription.MinimumWidth = 8;
            this.transDescription.Name = "transDescription";
            this.transDescription.ReadOnly = true;
            this.transDescription.Width = 150;
            // 
            // predictDateTimePicker1
            // 
            this.predictDateTimePicker1.Location = new System.Drawing.Point(331, 86);
            this.predictDateTimePicker1.Name = "predictDateTimePicker1";
            this.predictDateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.predictDateTimePicker1.TabIndex = 3;
            // 
            // predictbtn
            // 
            this.predictbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.predictbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictbtn.ForeColor = System.Drawing.Color.Orange;
            this.predictbtn.Location = new System.Drawing.Point(372, 147);
            this.predictbtn.Name = "predictbtn";
            this.predictbtn.Size = new System.Drawing.Size(102, 42);
            this.predictbtn.TabIndex = 4;
            this.predictbtn.Text = "Predict";
            this.predictbtn.UseVisualStyleBackColor = false;
            this.predictbtn.Click += new System.EventHandler(this.predictbtn_Click);
            // 
            // predictedRichTextBox1
            // 
            this.predictedRichTextBox1.Location = new System.Drawing.Point(663, 35);
            this.predictedRichTextBox1.Name = "predictedRichTextBox1";
            this.predictedRichTextBox1.Size = new System.Drawing.Size(520, 232);
            this.predictedRichTextBox1.TabIndex = 5;
            this.predictedRichTextBox1.Text = "";
            // 
            // Predictpanel1
            // 
            this.Predictpanel1.BackColor = System.Drawing.Color.Lavender;
            this.Predictpanel1.Controls.Add(this.predictbtn);
            this.Predictpanel1.Controls.Add(this.predictedRichTextBox1);
            this.Predictpanel1.Controls.Add(this.predictDateTimePicker1);
            this.Predictpanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Predictpanel1.Location = new System.Drawing.Point(0, 493);
            this.Predictpanel1.Name = "Predictpanel1";
            this.Predictpanel1.Size = new System.Drawing.Size(1622, 336);
            this.Predictpanel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(0, 836);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1644, 49);
            this.panel3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dailyTransdataGridView1);
            this.panel1.Controls.Add(this.weekEventdataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(224, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1398, 422);
            this.panel1.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1622, 829);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.leftLayout);
            this.Controls.Add(this.topLayout);
            this.Controls.Add(this.Predictpanel1);
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1644, 885);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.leftLayout.ResumeLayout(false);
            this.leftLayout.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.topLayout.ResumeLayout(false);
            this.topLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekEventdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyTransdataGridView1)).EndInit();
            this.Predictpanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel leftLayout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel topLayout;
        private System.Windows.Forms.Label usrLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transactioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEditTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEditToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem payeePayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEditToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView weekEventdataGridView1;
        private System.Windows.Forms.DataGridView dailyTransdataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DateTimePicker predictDateTimePicker1;
        private System.Windows.Forms.Button predictbtn;
        private System.Windows.Forms.RichTextBox predictedRichTextBox1;
        private System.Windows.Forms.Panel Predictpanel1;
        private System.Windows.Forms.PictureBox refreshPicBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}