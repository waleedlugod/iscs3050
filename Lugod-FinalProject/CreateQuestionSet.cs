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
using System.Windows.Forms.Design;
using System.Xml;

namespace Lugod_FinalProject
{
    public partial class CreateQuestionSet : UserControl
    {
        enum QuestionType { None, Text, List, Radio }
        QuestionType questionType = QuestionType.None;
        string rootPath;
        XmlDocument doc;
        XmlElement root;

        public CreateQuestionSet(string rootPath)
        {
            InitializeComponent();
            this.rootPath = rootPath;
            Dock = DockStyle.Fill;
            doc = new XmlDocument();
            root = doc.CreateElement("questions");
            doc.AppendChild(root);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlCollection cc = panelQuestion.Controls;
            cc.Clear();

            switch (comboBoxType.SelectedItem)
            {
                case "Text":
                    TextQuestionForm formText = new TextQuestionForm();
                    formText.OnAddTextResponse += userControl_ResponseHandler;
                    cc.Add(formText);
                    questionType = QuestionType.Text;
                    break;
                case "List":
                    ListQuestionForm formList = new ListQuestionForm();
                    formList.OnListResponse += userControl_ResponseHandler;
                    cc.Add(formList);
                    questionType = QuestionType.List;
                    break;
                case "Radio":
                    RadioQuestionForm formRadio = new RadioQuestionForm();
                    formRadio.OnRadioResponse += userControl_ResponseHandler;
                    cc.Add(formRadio);
                    questionType = QuestionType.Radio;
                    break;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string filename = textBoxSetname.Text;
            if (string.IsNullOrWhiteSpace(filename))
            {
                textBoxResponse.Text = "Enter a file name";
            }
            else if (root.ChildNodes.Count <= 0)
            {
                textBoxResponse.Text = "No questions added";
            }
            else
            {
                filename = filename + ".xml";
                doc.Save(rootPath + filename);
                textBoxResponse.Text = $"Saved to {filename}";
            }
        }

        private void userControl_ResponseHandler(object sender, Dictionary<string, dynamic> res)
        {
            CreateQuestionXml(res);
        }

        private void CreateQuestionXml(Dictionary<string, dynamic> res)
        {
            if (res.ContainsKey("error"))
            {
                textBoxResponse.Text = res["error"];
            }
            else if (string.IsNullOrWhiteSpace(textBoxQuestion.Text))
            {
                textBoxResponse.Text = "No question is provided";
            }
            else if (res.Count == 1 && res.ContainsKey("log"))
            {
                textBoxResponse.Text = res["log"];
            }
            else
            {
                XmlElement elType = doc.CreateElement(questionType.ToString().ToLower());

                // question element
                XmlElement elQuestion = doc.CreateElement("question");
                elQuestion.AppendChild(doc.CreateTextNode(textBoxQuestion.Text));
                elType.AppendChild(elQuestion);

                // case sensitivity for text question
                res.TryGetValue("isCaseSensitive", out dynamic? isCaseSensitive);
                if (isCaseSensitive != null)
                {
                    XmlElement elCase = doc.CreateElement("case");
                    elCase.AppendChild(doc.CreateTextNode(isCaseSensitive.ToString()));
                    elType.AppendChild(elCase);
                }

                // list of choices for list or radio question
                res.TryGetValue("choices", out dynamic? choices);
                if (choices != null)
                {
                    XmlElement elChoices = doc.CreateElement("choices");
                    foreach (string choice in choices)
                    {
                        XmlElement elChoice = doc.CreateElement("choice");
                        elChoice.AppendChild(doc.CreateTextNode(choice));
                        elChoices.AppendChild(elChoice);
                    }
                    elType.AppendChild(elChoices);
                }

                // single answer
                res.TryGetValue("answer", out dynamic? answer);
                if (!string.IsNullOrWhiteSpace(answer))
                {
                    XmlElement elAns = doc.CreateElement("answer");
                    elAns.AppendChild(doc.CreateTextNode(answer));
                    elType.AppendChild(elAns);
                }

                // list of answers
                res.TryGetValue("answers", out dynamic? answers);
                if (answers != null)
                {
                    // list of answers element
                    XmlElement elAnswers = doc.CreateElement("answers");
                    foreach (string ans in answers)
                    {
                        XmlElement elAnswer = doc.CreateElement("answer");
                        elAnswer.AppendChild(doc.CreateTextNode(ans));
                        elAnswers.AppendChild(elAnswer);
                    }
                    elType.AppendChild(elAnswers);
                }

                // log inputs
                res.TryGetValue("log", out dynamic? log);
                if (string.IsNullOrWhiteSpace(log))
                {
                    textBoxResponse.Text =
                        $"""
                        Added to question set:
                        Question: {textBoxQuestion.Text}

                        """;

                    if (questionType == QuestionType.Text) // log text question
                    {
                        textBoxResponse.Text +=
                            $"""
                            Answer: {answer}
                            Case sensitive?: {isCaseSensitive}
                            """;
                    }
                    else if (questionType == QuestionType.List) // log list question
                    {
                        textBoxResponse.Text +=
                            $"""
                            Choices:

                            """;
                        foreach (string choice in choices)
                        {
                            textBoxResponse.Text +=
                                $"""
                                    {choice}

                                """;
                        }
                        textBoxResponse.Text +=
                            $"""
                            Answers:

                            """;
                        foreach (string ans in answers)
                        {
                            textBoxResponse.Text +=
                                $"""
                                    {ans}

                                """;
                        }
                    }
                    else if (questionType == QuestionType.Radio) // log radio question
                    {
                        textBoxResponse.Text +=
                            $"""
                            Choices:

                            """;
                        foreach (string choice in choices)
                        {
                            textBoxResponse.Text +=
                                $"""
                                    {choice}

                                """;
                        }
                        textBoxResponse.Text +=
                            $"""
                            Answer: {answer}
                            """;
                    }
                }
                else
                {
                    textBoxResponse.Text = log;
                }

                root.AppendChild(elType);

                textBoxQuestion.Text = "";
                comboBoxType.SelectedItem = null;
                panelQuestion.Controls.Clear();
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (root.LastChild == null)
            {
                textBoxResponse.Text = "No questions added";
            }
            else
            {
                XmlNode elLast = root.LastChild;
                textBoxResponse.Text = $"Deleted question: {elLast.FirstChild?.InnerText}";
                root.RemoveChild(root.LastChild);
            }
        }
    }
}
