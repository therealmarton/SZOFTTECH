namespace gyakorlo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            for (int j = 0; j < 10; j++)
            {

            
                for (int i = 0; i < 10; i++)
                {


                    Button uj = new Button();

                    uj.Width = 100;
                    uj.Height = 50;
                    uj.Left = i*110;
                    uj.Height =j*555;


                    uj.Left = ClientRectangle.Width / 2 - 50;
                    uj.Top = ClientRectangle.Height / 2 - 25;
                    Controls.Add(uj);
                }

        }
    }
    }
}