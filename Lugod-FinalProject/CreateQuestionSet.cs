using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lugod_FinalProject
{
    public partial class CreateQuestionSet : UserControl
    {
        public CreateQuestionSet()
        {
            InitializeComponent();
            this.Visible = false;
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlCollection cc = panelQuestion.Controls;
            cc.Clear();
            Console.WriteLine(comboBoxType.SelectedItem);


            switch (comboBoxType.SelectedItem)
            {
                case "Text": cc.Add(new TextQuestionForm()); break;
                case "List": cc.Add(new ListQuestionForm()); break;
                case "Radio": cc.Add(new RadioQuestionForm()); break;
            }
        }
    }
}
