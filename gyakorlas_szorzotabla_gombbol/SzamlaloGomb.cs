using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas_szorzotabla_gombbol
{
    internal class SzamlaloGomb : Button
    {
        int szam;
        public SzamlaloGomb()
        {
               Height = 20;
               Width = 20;
                szam = 0;
                Click += SzamlaloGomb_Click;
             
               

        }

        private void SzamlaloGomb_Click(object sender, EventArgs e)
        {
            if(szam==5) { szam = 0; }
            szam++;
            Text = szam.ToString();
        }
    }
}
