using CsvHelper;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Globalization;

namespace mintazh
{
    public partial class Form1 : Form
    {
        BindingList<Futo> futok = new BindingList<Futo>();
        public Form1()
        {
            InitializeComponent();
            futoBindingSource.DataSource = futok;
            dataGridView1.DataSource = futoBindingSource;
            //dataGridView1.DataSource = futok; //!!!!!!!
        }

        private void button1Betoltes_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Futofile.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t = csv.GetRecords<Futo>();
                foreach (var item in t)
                {
                    futok.Add(item);
                }
                sr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Valoszinu hibatortent");
            }
        }

        private void button1Mentes_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                    csv.WriteRecords(futok);
                    streamWriter.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Valoszinu hibatortent");
                }
            }

        }

        private void button1Torles_Click(object sender, EventArgs e)
        {
            if (futoBindingSource.Current != null) { return; }
            if (MessageBox.Show("BIztos", "Biztos torlod?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                futoBindingSource.RemoveCurrent();
            }
        }

        private void button2Ujsor_Click(object sender, EventArgs e)
        {
            Form2 ujFuto = new Form2();
            if (ujFuto.ShowDialog() == DialogResult.OK)
            {


                futoBindingSource.Add(ujFuto.ujFutok);
            }


        }

        private void buttonErdekes_Click(object sender, EventArgs e)
        {
            double osszeg = 0;
            double legjobbido = double.PositiveInfinity;
            string nev = string.Empty;
            foreach (var item in futok)
            {
                if (item.Nemzetiseg == "USA")
                {
                    osszeg += 1;
                }
                if (item.EredmenyPerc < legjobbido)
                {
                    legjobbido = item.EredmenyPerc;
                    nev = item.Nev;

                }
                
            }
            MessageBox.Show($" Versenyzok USA-bol {osszeg} an  vannak es a legjobbido {legjobbido} es a neve {nev} ");
        }
    }
}
