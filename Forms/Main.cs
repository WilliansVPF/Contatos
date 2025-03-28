namespace Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
