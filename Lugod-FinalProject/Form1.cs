namespace Lugod_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createQuestionSet1_Load(object sender, EventArgs e)
        {
            createQuestionSet1.Dock = DockStyle.Fill;
        }

        private void buttonCreateQuestionSet_Click(object sender, EventArgs e)
        {
            createQuestionSet1.Visible = true;
        }
    }
}
