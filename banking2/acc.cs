﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking2
{
    public partial class acc : UserControl
    {
        public acc()
        {
            InitializeComponent();
            account.Text =connection.accno;
        }
    }
}
