namespace zh_eloadas_gyak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                LoveButton lb = new LoveButton( 20, 40);
                lb.Top = (lb.Height + i) * i;
                lb.Left = ClientRectangle.Width / 2;

                Controls.Add(lb);
            }
        }
    }
}
