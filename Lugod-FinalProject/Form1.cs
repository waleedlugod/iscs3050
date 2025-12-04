namespace Lugod_FinalProject
{
    public partial class Form1 : Form
    {
        string rootPath = "C:\\Users\\lugod\\source\\repos\\waleedlugod\\iscs3050\\Lugod-FinalProject\\";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateQuestionSet_Click(object sender, EventArgs e)
        {
            CreateQuestionSet cqs = new CreateQuestionSet(rootPath);
            Controls.Add(cqs);
            cqs.BringToFront();
        }

        private void buttonStudy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxFile.Text) && File.Exists(rootPath + textBoxFile.Text + ".xml"))
            {
                Study study = new Study(rootPath + textBoxFile.Text + ".xml");
                Controls.Add(study);
                study.BringToFront();
            }
        }
    }
}
