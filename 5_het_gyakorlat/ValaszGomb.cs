﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_het_gyakorlat
{
    internal class ValaszGomb : TextBox
    {
        public ValaszGomb()
        {
            BackColor = Color.LightCoral;
            Multiline = true;
            ReadOnly = true;

            MouseEnter += ValaszGomb_MouseEnter;
            MouseLeave += ValaszGomb_MouseLeave;

            BorderStyle = BorderStyle.None;
            Cursor = Cursors.Hand;
           
        }

        private void ValaszGomb_MouseLeave(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }

        private void ValaszGomb_MouseEnter(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
