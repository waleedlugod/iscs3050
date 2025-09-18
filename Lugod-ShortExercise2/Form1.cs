namespace Lugod_ShortExercise2
{
    public partial class Form1 : Form
    {
        private float operandLeft;
        private float operandRight;
        private char mathOperator;
        private bool isLeftValid;
        private bool isRightValid;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mathOperator = char.Parse(comboBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isLeftValid = float.TryParse(textBox1.Text, out operandLeft);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            isRightValid = float.TryParse(textBox2.Text, out operandRight);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            switch (mathOperator)
            {
                case '+': result = (operandLeft + operandRight).ToString(); break;
                case '-': result = (operandLeft - operandRight).ToString(); break;
                case '*': result = (operandLeft * operandRight).ToString(); break;
                case '/': result = (operandLeft / operandRight).ToString(); break;
                default: result = "invalid operation"; break;
            }
            if ((mathOperator == '/' && operandRight == 0) || !isLeftValid || !isRightValid) { result = "invalid operation"; }
            label4.Text = result;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Exit the application?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
