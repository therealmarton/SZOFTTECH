namespace gyakorlas_szorzotabla_gombbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {

                for (int j = 1; j < 11; j++)
                {
                    SzamlaloGomb g = new SzamlaloGomb();
                    g.Text = (i * j).ToString();
                  
                    
                    g.Left = (i - 1) * 40;
                    g.Top = (j - 1) * 40;
                    g.Width = 40;
                    g.Height = 40;

                    Controls.Add(g);
                }
            }
            

        }
      
    }
}
