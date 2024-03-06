using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh_eloadas_gyak2
{
    internal class LoveButton : Label
    {
        int szam = 1;
        public LoveButton()
        {
            Click += LoveButton_Click;
            BackColor = Color.Fuchsia;
            AutoSize = true;
            Text = ".";
        }
        public LoveButton(int x, int y)
        {
            Click += LoveButton_Click;
            BackColor = Color.Fuchsia;
            AutoSize = true;
            Text = ".";
            Left = x;
            Top = y;    


        }

        private void LoveButton_Click(object? sender, EventArgs e)
        {
            szam++;
            if (szam == 4) szam = 1;
            Text = szam.ToString();
            for (int i = 0; i < szam; i++)
            {
                Text += ".";
            }

        }
    }
}
