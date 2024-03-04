using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas_szorzotabla_gombbol
{
    internal class SzinezodoGomb : Button
    {
        public SzinezodoGomb()
        {
            Height = 20;
            Width = 20;
            Click += SzinezodoGomb_Click;
        }

        private void SzinezodoGomb_Click(object sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
