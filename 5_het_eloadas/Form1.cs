using System.Diagnostics;
using System.Text;

namespace _5_het_eloadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Kerdesek/jatek.csv", Encoding.Default);

            int sorszam = 0;
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] st = sor.Split(';');

                string kerdes = st[0];
                string valasz1 = st[1];
                string valasz2 = st[2];
                string valasz3 = st[3];
                string valasz4 = st[4];
                int joValasz = int.Parse(st[5]);

                //KerdesUC uc = new KerdesUC();
                KerdesUC  uc = new KerdesUC(kerdes, valasz1, valasz2, valasz3, valasz4, joValasz);
                Controls.Add(uc);
                uc.Top = sorszam * (uc.Height + 3);
                uc.label1.Text = ($"#{sorszam + 1}. {kerdes}");
           

                Trace.WriteLine($"#{sorszam} - {kerdes}");
                sorszam++;
                if (sorszam == 100) break; 



            }
            
            sr.Close();
        }
    }
}
