﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mintazh
{
    public partial class Form2 : Form
    {   
        public Futo ujFutok  = new Futo();
        public Form2()
        {
            InitializeComponent();
            futoBindingSource.DataSource = ujFutok;
        }
        
    }
}
