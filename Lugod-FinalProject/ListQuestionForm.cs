using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lugod_FinalProject
{
    public delegate void ListResponseEventHanlder(object source, Dictionary<string, dynamic> res);
    public partial class ListQuestionForm : UserControl
    {
        public event ListResponseEventHanlder? OnListResponse;
        private HashSet<int> answerIndeces = new HashSet<int>();
        public ListQuestionForm()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void buttonAddChoice_Click(object sender, EventArgs e)
        {
            string choice = textBoxChoice.Text;
            if (string.IsNullOrWhiteSpace(choice))
            {
                OnListResponse?.Invoke(this, new Dictionary<string, dynamic> { { "error", "No choice specified" } });
            }
            else
            {
                listBoxChoices.Items.Add(choice);
            }
        }

        private void buttonSetAnswers_Click(object sender, EventArgs e)
        {
            if (listBoxChoices.SelectedIndices.Count <= 0)
            {
                OnListResponse?.Invoke(this, new Dictionary<string, dynamic> { { "error", "No choices specified" } });
            }
            else
            {
                string log =
                    $"""
                    Set answer(s) to:

                    """;
                foreach (int choice in listBoxChoices.SelectedIndices)
                {
                    answerIndeces.Add(choice);
                    log +=
                        $"""
                            {listBoxChoices.Items[choice]}

                        """;
                }
                OnListResponse?.Invoke(this, new Dictionary<string, dynamic> { { "log", log } });
            }
        }

        private void buttonDeleteChoices_Click(object sender, EventArgs e)
        {
            if (listBoxChoices.SelectedIndices.Count <= 0)
            {
                OnListResponse?.Invoke(this, new Dictionary<string, dynamic> { { "error", "No choices selected" } });
            }
            else
            {
                ListBox.SelectedIndexCollection selected = listBoxChoices.SelectedIndices;
                for (int i = selected.Count - 1; i >= 0; i--)
                {
                    listBoxChoices.Items.RemoveAt(selected[i]);
                    answerIndeces.Remove(selected[i]);
                }
            }
        }

        private void buttonUpdateChoice_Click(object sender, EventArgs e)
        {
            int choice = listBoxChoices.SelectedIndex;
            if (choice == -1)
            {
                OnListResponse?.Invoke(this, new Dictionary<string, dynamic> { { "error", "No choices selected" } });
            }
            else if (string.IsNullOrWhiteSpace(textBoxChoice.Text))
            {
                OnListResponse?.Invoke(this, new Dictionary<string, dynamic> { { "error", "No choices specified" } });
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
                OnListResponse?.Invoke(this, new Dictionary<string, dynamic> { { "error", "No choices are set" } });
            }
            else if (answerIndeces.Count == 0)
            {
                OnListResponse?.Invoke(this, new Dictionary<string, dynamic> { { "error", "No answer is set" } });
            }
            else
            {
                List<string?> answers = new List<string?>();
                foreach (int ans in answerIndeces)
                {
                    answers.Add(listBoxChoices.Items[ans].ToString());
                }
                OnListResponse?.Invoke(this, new Dictionary<string, dynamic>
                {
                    { "choices", listBoxChoices.Items },
                    { "answers", answers }
                });
            }
        }
    }
}
