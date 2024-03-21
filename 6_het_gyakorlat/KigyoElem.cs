using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_het_gyakorlat
{
    internal class KigyoElem : PictureBox
    {
        public static int Meret = 20;
        public int hossz = 1;


        public KigyoElem()
        {
            Width = KigyoElem.Meret;
            Height = KigyoElem.Meret;
            BackColor = Color.Fuchsia;
        }
    }
}
