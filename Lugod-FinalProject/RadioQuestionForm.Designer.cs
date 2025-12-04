namespace Lugod_FinalProject
{
    partial class RadioQuestionForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            textBoxChoice = new TextBox();
            buttonAddChoice = new Button();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonSetAnswer = new Button();
            buttonDeleteChoice = new Button();
            buttonUpdateChoice = new Button();
            listBoxChoices = new ListBox();
            buttonAdd = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxChoice, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonAddChoice, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 3);
            tableLayoutPanel1.Controls.Add(listBoxChoices, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonAdd, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(413, 231);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Choice:";
            // 
            // textBoxChoice
            // 
            textBoxChoice.Anchor = AnchorStyles.Left;
            textBoxChoice.Location = new Point(61, 3);
            textBoxChoice.Name = "textBoxChoice";
            textBoxChoice.Size = new Size(349, 23);
            textBoxChoice.TabIndex = 1;
            // 
            // buttonAddChoice
            // 
            buttonAddChoice.Location = new Point(61, 32);
            buttonAddChoice.Name = "buttonAddChoice";
            buttonAddChoice.Size = new Size(75, 23);
            buttonAddChoice.TabIndex = 2;
            buttonAddChoice.Text = "Add choice";
            buttonAddChoice.UseVisualStyleBackColor = true;
            buttonAddChoice.Click += buttonAddChoice_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 58);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Choices:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonSetAnswer);
            flowLayoutPanel1.Controls.Add(buttonDeleteChoice);
            flowLayoutPanel1.Controls.Add(buttonUpdateChoice);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(58, 170);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(355, 32);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // buttonSetAnswer
            // 
            buttonSetAnswer.Location = new Point(3, 3);
            buttonSetAnswer.Name = "buttonSetAnswer";
            buttonSetAnswer.Size = new Size(91, 23);
            buttonSetAnswer.TabIndex = 0;
            buttonSetAnswer.Text = "Set as answer";
            buttonSetAnswer.UseVisualStyleBackColor = true;
            buttonSetAnswer.Click += buttonSetAnswer_Click;
            // 
            // buttonDeleteChoice
            // 
            buttonDeleteChoice.Location = new Point(100, 3);
            buttonDeleteChoice.Name = "buttonDeleteChoice";
            buttonDeleteChoice.Size = new Size(112, 23);
            buttonDeleteChoice.TabIndex = 1;
            buttonDeleteChoice.Text = "Delete choice";
            buttonDeleteChoice.UseVisualStyleBackColor = true;
            buttonDeleteChoice.Click += buttonDeleteChoice_Click;
            // 
            // buttonUpdateChoice
            // 
            buttonUpdateChoice.Location = new Point(218, 3);
            buttonUpdateChoice.Name = "buttonUpdateChoice";
            buttonUpdateChoice.Size = new Size(106, 23);
            buttonUpdateChoice.TabIndex = 2;
            buttonUpdateChoice.Text = "Update choice";
            buttonUpdateChoice.UseVisualStyleBackColor = true;
            buttonUpdateChoice.Click += buttonUpdateChoice_Click;
            // 
            // listBoxChoices
            // 
            listBoxChoices.Dock = DockStyle.Fill;
            listBoxChoices.FormattingEnabled = true;
            listBoxChoices.Location = new Point(61, 61);
            listBoxChoices.MultiColumn = true;
            listBoxChoices.Name = "listBoxChoices";
            listBoxChoices.Size = new Size(349, 106);
            listBoxChoices.TabIndex = 6;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(61, 205);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(125, 23);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add to question set";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // RadioQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "RadioQuestionForm";
            Size = new Size(413, 231);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBoxChoice;
        private Button buttonAddChoice;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonSetAnswer;
        private Button buttonDeleteChoice;
        private Button buttonUpdateChoice;
        private ListBox listBoxChoices;
        private Button buttonAdd;
    }
}
