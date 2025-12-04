using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lugod_FinalProject
{
    public delegate void TextResponseEventHanlder(object source, Dictionary<string, dynamic> res);
    public partial class TextQuestionForm : UserControl
    {
        public event TextResponseEventHanlder? OnAddTextResponse;

        public TextQuestionForm()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> res = new Dictionary<string, dynamic>();

            if (string.IsNullOrWhiteSpace(textBoxTextAnswer.Text))
            {
                res.Add("error", "No answer is provided");
            }
            else
            {
                res.Add("answer", textBoxTextAnswer.Text);
                res.Add("isCaseSensitive", checkBoxTextSensitivity.Checked);
            }
                
            OnAddTextResponse?.Invoke(this, res);
        }
    }
}
