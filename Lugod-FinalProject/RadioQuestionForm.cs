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
    public delegate void RadioResponseEventHanlder(object source, Dictionary<string, dynamic> res);
    public partial class RadioQuestionForm : UserControl
    {
        public event RadioResponseEventHanlder? OnRadioResponse;
        private int answerIdx = -1;
        public RadioQuestionForm()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void buttonAddChoice_Click(object sender, EventArgs e)
        {

            string choice = textBoxChoice.Text;
            if (string.IsNullOrWhiteSpace(choice))
            {
                OnRadioResponse?.Invoke(this, new Dictionary<string, dynamic> { { "error", "No choice specified" } });
            }
            else
            {
                listBoxChoices.Items.Add(choice);
            }
        }

        private void buttonSetAnswer_Click(object sender, EventArgs e)
        {
            int choice = listBoxChoices.SelectedIndex;
            if (choice == -1)
            {
                OnRadioResponse?.Invoke(this, new Dictionary<string, dynamic> { { "error", "No choice selected" } });
            }
            else
            {
                answerIdx = choice;
                OnRadioResponse?.Invoke(this, new Dictionary<string, dynamic> { { "log", $"Set answer to: {listBoxChoices.SelectedItem}" } });
            }
        }

        private void buttonDeleteChoice_Click(object sender, EventArgs e)
        {
            int choice = listBoxChoices.SelectedIndex;
            if (choice == -1)
            {
                OnRadioResponse?.Invoke(this, new Dictionary<string, dynamic> { { "error", "No choice selected"} });
            }
            else
            {
                listBoxChoices.Items.RemoveAt(choice);
                if (choice == answerIdx) { answerIdx = -1; }
            }
        }

        private void buttonUpdateChoice_Click(object sender, EventArgs e)
        {
            int choice = listBoxChoices.SelectedIndex;
            if (choice == -1)
            {
                OnRadioResponse?.Invoke(this, new Dictionary<string, dynamic> { { "error", "No choice selected" } });
            }
            else if (string.IsNullOrWhiteSpace(textBoxChoice.Text))
            {
                OnRadioResponse?.Invoke(this, new Dictionary<string, dynamic> { { "error", "No choice specified" } });
            }
            else
            {
                listBoxChoices.Items.RemoveAt(choice);
                listBoxChoices.Items.Insert(choice, textBoxChoice.Text);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxChoices.Items.Count <= 0)
            {
                OnRadioResponse?.Invoke(this, new Dictionary<string, dynamic> { { "error", "No choices are set" } });
            }
            else if (answerIdx == -1)
            {
                OnRadioResponse?.Invoke(this, new Dictionary<string, dynamic> { { "error", "No answer is set" } });
            }
            else
            {
                OnRadioResponse?.Invoke(this, new Dictionary<string, dynamic>
                {
                    { "choices", listBoxChoices.Items },
                    { "answer", listBoxChoices.Items[answerIdx] }
                });
            }
        }
    }
}
