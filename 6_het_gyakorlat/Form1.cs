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

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            
            fej_x += irany_x * KigyoElem.Meret;
            fej_y += irany_y * KigyoElem.Meret;
            foreach (KigyoElem item in Controls)
            {
                if (item.Top == fej_y && item.Left == fej_x) 
                { 
                    Application.Exit();
                }
            }

            KigyoElem ujFej = new KigyoElem();

            ujFej.Top = fej_y;
            ujFej.Left = fej_x;
            Controls.Add(ujFej);


            if (Controls.Count > hossz)
            {
                Controls.RemoveAt(0);
            }

            lepesszam++;


         




        }

    }
}