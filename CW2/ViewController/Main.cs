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
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();  
        }
        public UserDetails newUser;
    
        private void Main_Load(object sender, EventArgs e)
        {
            this.usrLbl.Text = this.newUser.UserName;
        }

        private void addTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTransaction ad = new AddTransaction();
            ad.Activate();
            ad.ShowDialog();
        }

        private void viewEditTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinancialReport financialReport = new FinancialReport();
            financialReport.Activate();
            financialReport.ShowDialog();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEvent addEvent = new AddEvent();
            addEvent.Activate();
            addEvent.ShowDialog();
        }

        private void viewEditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditEvent editevent = new EditEvent();
            editevent.Activate();
            editevent.ShowDialog();
        }

        private void addDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPayeeOrPayer addPayeeorPayer = new AddPayeeOrPayer();
            addPayeeorPayer.Activate();
            addPayeeorPayer.ShowDialog();
        }

        private void viewEditToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewPayerPayee viewPayerPayee = new ViewPayerPayee();
            viewPayerPayee.Activate();
            viewPayerPayee.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
