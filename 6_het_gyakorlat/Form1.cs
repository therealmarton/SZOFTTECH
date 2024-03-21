using Microsoft.VisualBasic;

namespace _6_het_gyakorlat
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int irany_x = 1;
        int irany_y = 0;
        int lepesszam = 0;
        int hossz = 5;
        public Form1()
        {
            InitializeComponent();

            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                irany_y = -1;
                irany_x = 0;
            }

            if (e.KeyCode == Keys.S)
            {
                irany_y = 1;
                irany_x = 0;
            }

            if (e.KeyCode == Keys.A)
            {
                irany_y = 0;
                irany_x = -1;
            }

            if (e.KeyCode == Keys.D)
            {
                irany_y = 0;
                irany_x = 1;
            }
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
        

          

        }
        List<KigyoElem> kigyo = new List<KigyoElem>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            lepesszam++;


            fej_x += irany_x * KigyoElem.Meret;
            fej_y += irany_y * KigyoElem.Meret;

            foreach (object item in Controls)
            {
                if (item is KigyoElem)
                {
                    KigyoElem k = (KigyoElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }
            

            KigyoElem ke = new KigyoElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            kigyo.Add(ke); 
            Controls.Add(ke); 


            if (kigyo.Count > hossz)
            {
                KigyoElem levagando = kigyo[0];
                kigyo.RemoveAt(0);
                Controls.Remove(levagando);
            }
           






            if (lepesszam % 2 == 0) ke.BackColor = Color.Yellow;








        }

    }
}