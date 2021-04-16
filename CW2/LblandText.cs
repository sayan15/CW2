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
    public partial class LblandText : UserControl
    {
        public LblandText()
        {
            InitializeComponent();
        }
        public String Lbltext
        {
            set { this.lbl.Text = value; }
        }
        public String Datatext
        {
            set { this.txtBox.Text = value; }
        }
    }
}
