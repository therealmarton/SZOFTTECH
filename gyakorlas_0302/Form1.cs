namespace gyakorlas_0302
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        class Sor
        {
            public int Honap { get; set; }
            public decimal Hatralek { get; set; }
        }
        class GombOsztaly : Button
        {
            public GombOsztaly()
            {
                MouseEnter += GombOsztaly_MouseEnter;
                MouseLeave += GombOsztaly_MouseLeave;
            }
            private void GombOsztaly_MouseLeave(object sender, EventArgs e) {
                BackColor = Color.Fuchsia;

            
            }
            private void GombOsztaly_MouseEnter(object sender, EventArgs e) {

                BackColor = Color.Yellow;
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    GombOsztaly gomb1 = new GombOsztaly();
                    Controls.Add(gomb1);
                    Sor ujsor = new Sor();
                    ujsor.Hatralek = i;
                    ujsor.Honap = j;
                    gomb1.Text = ($"Ha:{i} Ho:{j}");
                    gomb1.Height = 50;
                    gomb1.Width = 50;
                    gomb1.Top = i * 50;
                    gomb1.Left = j * 50;

                }
            }
        }
    }
}
