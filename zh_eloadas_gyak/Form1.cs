namespace zh_eloadas_gyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 13;
            byte b = (byte)a;

            byte c = 12;
            int d = c;

            double d2 = 3.14f;
            int g = (int)d2;

            double xxx = double.Parse(textBox1.Text);

        }

        int Fibonacci(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            List<Racs> sorok = new List<Racs>();
            dataGridView1.DataSource = sorok;


            for (int i = int.Parse(textBox1.Text); i < 10; i++)
            {
                int veletlen = rnd.Next(1, 7);


                Racs racsegysora = new Racs();


                racsegysora.Sorszam = i;
                racsegysora.VeletlenSzam = veletlen;
                racsegysora.Fibo = Fibonacci(i);

                sorok.Add(racsegysora);

            }



        }
    }
}
