namespace NCKH_Official
{
    public partial class ChooseRole : Form
    {
        public ChooseRole()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            StudentHome studentHome = new StudentHome();
            studentHome.Show();
            this.Hide();
        }
    }
}
