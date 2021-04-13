using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW2
{
    public partial class TypeRadioButton : UserControl
    {
        bool oneTime;

        public bool OneTime
        {
            get { return oneTime; }
            set { oneTime = value; }
        }
        bool repeat;

        public bool Repeat
        {
            get { return repeat; }
            set { repeat = value; }
        }
        public TypeRadioButton()
        {
            InitializeComponent();
        }

        private void oneTimeRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(oneTimeRadioButton1.Checked)
            {
                oneTimeRadioButton1.Checked = true;
            }
            this.OneTime= true;
            this.Repeat = false;
        }

        private void repeatRadioButton1_CheckedChanged(object sender, EventArgs e)
        {   
            if(repeatRadioButton1.Checked)
            {
                repeatRadioButton1.Checked = true;
            }
            this.Repeat = true;
            this.OneTime = false;
        }

        public void setRadioButton()
        {
            if(this.OneTime==true)
            {
                oneTimeRadioButton1.Checked = true;
            }
            else
            {
                repeatRadioButton1.Checked = true;
            }
        }
    }
}
