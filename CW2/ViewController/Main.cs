﻿using System;
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
        public User newUser;
    
        private void Main_Load(object sender, EventArgs e)
        {
            this.usrLbl.Text = this.newUser.userName;
        }

    }
}
