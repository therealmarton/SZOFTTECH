namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal hitelOsszeg = decimal.Parse(tbHitelOsszege.Text);
            decimal haviKamat = decimal.Parse(tbHaviKamat.Text);
            decimal haviToleszto = decimal.Parse(cbHaviTorleszto.Text);

            decimal hatralek = hitelOsszeg;
            decimal befizetes = 0;

            List<Sor> sorok = new List<Sor>();

            int honap = 1;

            while (hatralek > 0)
            {
                hatralek += haviKamat * (hatralek / 100m);
                hatralek -= haviToleszto;
                befizetes += haviToleszto;
                honap++;

                Sor �jSor = new Sor();

                if (hatralek < 0) {  break; } else { �jSor.KommunaltOsszeg += befizetes; }
               
            
    
                �jSor.Hatralek = Math.Round(hatralek);
                �jSor.Honap = honap;

                sorok.Add(�jSor);
            }

            dataGridView1.DataSource = sorok;


        }
        class Sor
        {
            public int Honap { get; set; }
            public decimal Hatralek { get; set; }
            public decimal KommunaltOsszeg { get; set; }    
        }
    }
}
