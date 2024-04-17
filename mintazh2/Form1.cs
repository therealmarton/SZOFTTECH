using CsvHelper;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Globalization;

namespace mintazh2
{
    public partial class Form1 : Form
    {
        BindingList<Futo> futok = new BindingList<Futo>();
        public Form1()
        {
            InitializeComponent();
            futoBindingSource.DataSource = futok;
            dataGridView1.DataSource = futoBindingSource;

        }
        //betoltes
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("file.txt");
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
                MessageBox.Show(ex.Message);
            }

        }








        //torles
        private void button4_Click(object sender, EventArgs e)
        {
            if(futoBindingSource.Current != null) { return; }
            if(MessageBox.Show("b","t", MessageBoxButtons.YesNo) == DialogResult.Yes) {
               futoBindingSource.RemoveCurrent();
            }
        }
        //mentes
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
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

                    MessageBox.Show("Valoszinu hiba");
                }
            }
        }
        //ujsor
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
