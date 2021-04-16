using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW2.ViewController
{
    public partial class DeletedDetailView : Form
    {
        public DeletedDetailView()
        {
            InitializeComponent();
        }
        public bool val = false;
        public bool SetText(CW2_SystemDB dataset)
        {
            Button button = new Button();
            int pos = 0;
            if (dataset.Events.Rows.Count>0)
            {
                
                LblandText[] lblandText = new LblandText[dataset.Events.Columns.Count];
                for (int i = 0; i < dataset.Events.Columns.Count; i++)
                {
                    lblandText[i] = new LblandText();
                    System.Drawing.Point p = new System.Drawing.Point(150, 114 + i * 30);
                    lblandText[i].Location = p;
                    lblandText[i].Size = new System.Drawing.Size(183, 25);
                    lblandText[i].Lbltext = dataset.Events.Columns[i].ColumnName;
                    lblandText[i].Datatext = dataset.Events.Rows[0][dataset.Events.Columns[i].ColumnName].ToString();
                    this.Controls.Add(lblandText[i]);
                    pos = i;
                }
                button.Location = new Point(190, 150 + pos * 30);
                button.Text = "Confirm";
                this.Controls.Add(button);
                button.Click += Button_Click;
                this.ShowDialog();
                return val;
            }
            if (dataset.Transactions.Rows.Count > 0)
            {
                
                LblandText[] lblandText = new LblandText[dataset.Transactions.Columns.Count];

                for (int i = 0; i < dataset.Transactions.Columns.Count; i++)
                {
                    lblandText[i] = new LblandText();
                    System.Drawing.Point p = new System.Drawing.Point(150, 114 + i * 30);
                    lblandText[i].Location = p;
                    lblandText[i].Size = new System.Drawing.Size(183, 25);
                    lblandText[i].Lbltext = dataset.Transactions.Columns[i].ColumnName;
                    lblandText[i].Datatext = dataset.Transactions.Rows[0][dataset.Transactions.Columns[i].ColumnName].ToString();
                    this.Controls.Add(lblandText[i]);
                    pos = i;
                }
                button.Location = new Point(190, 150 + pos * 30);
                button.Text = "Confirm";
                this.Controls.Add(button);
                button.Click += Button_Click;
                this.ShowDialog();
                return val;
            }
            if (dataset.PayerOrPayees.Rows.Count > 0)
            {
                LblandText[] lblandText = new LblandText[dataset.PayerOrPayees.Columns.Count];
                for (int i = 0; i < dataset.PayerOrPayees.Columns.Count; i++)
                {
                    lblandText[i] = new LblandText();
                    System.Drawing.Point p = new System.Drawing.Point(150, 114 + i * 30);
                    lblandText[i].Location = p;
                    lblandText[i].Size = new System.Drawing.Size(183, 25);
                    lblandText[i].Lbltext = dataset.PayerOrPayees.Columns[i].ColumnName;
                    lblandText[i].Datatext = dataset.PayerOrPayees.Rows[0][dataset.PayerOrPayees.Columns[i].ColumnName].ToString();
                    this.Controls.Add(lblandText[i]);
                    pos = i;
                }
                button.Location = new Point(190, 150 + pos * 30);
                button.Text = "Confirm";
                this.Controls.Add(button);
                button.Click += Button_Click;
                this.ShowDialog();
                return val;
            }
            return val;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            val = true;
            this.Close();
        }
    }
}
