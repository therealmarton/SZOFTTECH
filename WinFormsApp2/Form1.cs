namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Button b = new Button();
                b.Top= i*30;
                b.Text = Fibonacci(i).ToString();
                Controls.Add(b);    
            }
        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci (n - 1) + Fibonacci(n - 2);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            List<Elem> elemek = new List<Elem>();

            for (int i = 0; i < 10; i++)
            {
                Button b = new Button();
                b.Top = i * 30;
                b.Text = Fibonacci(i).ToString();
                Controls.Add(b);
                Elem ujElem = new Elem();
                ujElem.Sorszam = i;
                ujElem.Ertek = i * 30;
                elemek.Add(ujElem);
            }
            dataGridView1.DataSource = elemek;

        }
        class Elem
        {
            public int Sorszam {get;set;}  
            public long Ertek { get; set; }
        }

    }
}