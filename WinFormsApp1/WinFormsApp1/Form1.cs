namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            UserControl userControl = new UserControl();
            panel1.Controls.Add(userControl);
            userControl
        }
    }
}