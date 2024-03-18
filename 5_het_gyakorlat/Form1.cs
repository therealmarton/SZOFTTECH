namespace _5_het_gyakorlat
{
    public partial class Form1 : Form
    {

        public Form1()

        {
            InitializeComponent();

        }
        List<Kerdes> OsszesKerdes;
        List<Kerdes> AktivKerdesek;
        int AktivKerdes = 5;

        List<Kerdes> KerdesBeolvasas()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();
            StreamReader sr = new StreamReader("fileok/hajo.txt", true);

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? string.Empty; // null ertek kezelese uressorral

                string[] tomb = sor.Split("\t");

                if (tomb.Length != 7) continue; //ha nem 6 reszre osztja fel a tab akkor rossz a sor, kezeljuk

                Kerdes k = new Kerdes();
                k.KerdesSzoveg = tomb[1];
                k.Valasz1 = tomb[2];
                k.Valasz2 = tomb[3];
                k.Valasz3 = tomb[4];
                k.URL = tomb[5];

                int.TryParse(tomb[6], out int jovalasz); //igy kell csinalni az atalakitast

                k.HelyesValasz = jovalasz;

                kerdesek.Add(k);

            }
            sr.Close();
            return kerdesek;
        }
        void KerdesMegjelenites(Kerdes kerdes)
        {

            label1.Text = kerdes.KerdesSzoveg;
            valaszGomb1.Text = kerdes.Valasz1;
            valaszGomb2.Text = kerdes.Valasz2;
            valaszGomb3.Text = kerdes.Valasz3;
            if (!string.IsNullOrEmpty(kerdes.URL))
            {
                pictureBox1.Load("https://storage.altium.hu/hajo/" + kerdes.URL);
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible=false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Kerdes> AktivKerdesek;
            List<Kerdes> OsszesKerdes;

            AktivKerdesek = new List<Kerdes>();
            OsszesKerdes = KerdesBeolvasas();
            for (int i = 0; i < 7; i++)
            {
                AktivKerdesek.Add(OsszesKerdes[i]);
                OsszesKerdes.RemoveAt(i);
                

                
            }
            
          


        }
    }
}
