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
using System.Xml;

namespace Lugod_FinalProject
{
    public partial class Study : UserControl
    {
        private XmlDocument doc = new XmlDocument();
        enum QuestionType { None, Text, List, Radio }
        private QuestionType questionType = QuestionType.None;
        private XmlNodeList questions;
        private List<string> answers = new List<string>();
        private bool isCaseSensitive = false;
        private int qIdx = 0;
        private TextBox tb;
        private ListBox lb;
        private int correctCount = 0;
        public Study(string filepath)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            doc.Load(filepath);
            questions = doc.DocumentElement.ChildNodes;

            SetQuestion(questions[0]);
            buttonNext.Enabled = false;
        }

        private void SetQuestion(XmlNode question)
        {
            string questionType = question.Name;
            panelAnswer.Controls.Clear();
            switch (questionType)
            {
                case "text":
                    SetTextQuestion(question.ChildNodes);
                    this.questionType = QuestionType.Text;
                    break;
                case "list":
                    SetListQuestion(question.ChildNodes);
                    this.questionType = QuestionType.List;
                    break;
                case "radio":
                    SetRadioQuestion(question.ChildNodes);
                    this.questionType = QuestionType.Radio;
                    break;
            }
        }

        private void SetTextQuestion(XmlNodeList attributes)
        {
            foreach (XmlNode att in attributes)
            {
                if (att.Name == "question")
                {
                    labelQuestion.Text = att.InnerText;
                }
                else if (att.Name == "answer")
                {
                    answers = new List<string> { att.InnerText };
                    tb = new TextBox();
                    tb.Dock = DockStyle.Fill;
                    panelAnswer.Controls.Add(tb);
                }
                else if (att.Name == "case")
                {
                    isCaseSensitive = att.InnerText == "True";
                    if (isCaseSensitive)
                    {
                        labelQuestion.Text += " (case sensitive)";
                    }
                }
            }
        }
        private void SetListQuestion(XmlNodeList attributes)
        {
            foreach (XmlNode att in attributes)
            {
                if (att.Name == "question")
                {
                    labelQuestion.Text = att.InnerText;
                }
                else if (att.Name == "answers")
                {
                    answers = new List<string>();
                    foreach (XmlNode ans in att)
                    {
                        answers.Add(ans.InnerText);
                    }
                }
                else if (att.Name == "choices")
                {
                    List<string> choices = new List<string>();
                    foreach (XmlNode choice in att)
                    {
                        choices.Add(choice.InnerText);
                    }
                    lb = new ListBox();
                    lb.Items.AddRange(choices.ToArray());
                    lb.Dock = DockStyle.Fill;
                    lb.SelectionMode = SelectionMode.MultiSimple;
                    panelAnswer.Controls.Add(lb);
                }
            }
        }
        private void SetRadioQuestion(XmlNodeList attributes)
        {
            foreach (XmlNode att in attributes)
            {
                if (att.Name == "question")
                {
                    labelQuestion.Text = att.InnerText;
                }
                else if (att.Name == "answer")
                {
                    answers = new List<string> { att.InnerText };
                }
                else if (att.Name == "choices")
                {
                    List<string> choices = new List<string>();
                    foreach (XmlNode choice in att)
                    {
                        choices.Add(choice.InnerText);
                    }
                    lb = new ListBox();
                    lb.Items.AddRange(choices.ToArray());
                    lb.Dock = DockStyle.Fill;
                    panelAnswer.Controls.Add(lb);
                }
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxResponse.Text == "")
            {
                buttonNext.Enabled = true;
                if (questionType == QuestionType.Text)
                {
                    string userAnswer = tb.Text;
                    string correct = answers[0];
                    if (!isCaseSensitive)
                    {
                        userAnswer = userAnswer.ToLower();
                        correct = correct.ToLower();
                    }
                    if (userAnswer == correct)
                    {
                        textBoxResponse.Text = "Correct!";
                        correctCount++;
                    }
                    else
                    {
                        textBoxResponse.Text = $"Wrong. The correct answer is {correct}";
                    }
                }
                else if (questionType == QuestionType.List)
                {
                    bool isCorrect = true;
                    ListBox.SelectedObjectCollection userAnswers = lb.SelectedItems;
                    foreach (string ans in answers)
                    {
                        if (!userAnswers.Contains(ans)) isCorrect = false;
                    }
                    if (isCorrect)
                    {
                        textBoxResponse.Text = "Correct!";
                        correctCount++;
                    }
                    else if (answers.Count == 1)
                    {
                        textBoxResponse.Text = $"Wrong. The correct answer is {answers[0]}";
                    }
                    else
                    {
                        textBoxResponse.Text = "Wrong. The correct answers are ";
                        for (int i = 0; i < answers.Count; i++)
                        {
                            string ans = answers[i].ToString();
                            textBoxResponse.Text += i == answers.Count() - 1 && answers.Count() > 1 ? $"and {ans}" : $"{ans}, ";
                        }
                    }
                }
                else if (questionType == QuestionType.Radio)
                {
                    string userAnswer = lb.GetItemText(lb.SelectedItem);
                    string correct = answers[0];
                    if (userAnswer == correct)
                    {
                        textBoxResponse.Text = "Correct!";
                        correctCount++;
                    }
                    else
                    {
                        textBoxResponse.Text = $"Wrong. The correct answer is {correct}";
                    }
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (qIdx + 1 < questions.Count)
            {
                SetQuestion(questions[++qIdx]);
                textBoxResponse.Text = "";
                buttonNext.Enabled = false;
            }
            else if (qIdx + 1 == questions.Count)
            {
                qIdx++;
                panelAnswer.Controls.Clear();
                labelQuestion.Text = "Results";
                textBoxResponse.Text = $"You got {correctCount} question{(correctCount > 1 ? "s" : "")} correct out of {questions.Count}";
                buttonSubmit.Visible = false;
                buttonNext.Text = "Done";
            } else
            {
                Parent.Controls.Remove(this);
            }
        }
    }
}
