using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countrylist = new();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countrylist;
            dataGridView1.DataSource = countrylist;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tomb = csv.GetRecords<CountryData>();
            foreach (var item in tomb)
            {
                countrylist.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fce = new Form2();
            fce.CountryData = countryDataBindingSource.Current as CountryData;
            fce.Show();
        }
    }
}