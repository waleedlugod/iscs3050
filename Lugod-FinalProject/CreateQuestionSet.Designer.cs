namespace Lugod_FinalProject
{
    partial class CreateQuestionSet : UserControl
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
            CreateQuestionSetLabel = new Label();
            label1 = new Label();
            textBoxQuestion = new TextBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBoxType = new ComboBox();
            tableLayoutPanelMain = new TableLayoutPanel();
            finishButton = new Button();
            panelQuestion = new Panel();
            textBox2 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // CreateQuestionSetLabel
            // 
            CreateQuestionSetLabel.Anchor = AnchorStyles.Left;
            CreateQuestionSetLabel.AutoSize = true;
            CreateQuestionSetLabel.Location = new Point(3, 19);
            CreateQuestionSetLabel.Name = "CreateQuestionSetLabel";
            CreateQuestionSetLabel.Size = new Size(111, 15);
            CreateQuestionSetLabel.TabIndex = 0;
            CreateQuestionSetLabel.Text = "Create Question Set";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Question:";
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.Anchor = AnchorStyles.Left;
            textBoxQuestion.Location = new Point(67, 12);
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.Size = new Size(697, 23);
            textBoxQuestion.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 64);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "Type:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(comboBoxType, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxQuestion, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 56);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1157, 96);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // comboBoxType
            // 
            comboBoxType.Anchor = AnchorStyles.Left;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Text", "List", "Radio" });
            comboBoxType.Location = new Point(67, 60);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(149, 23);
            comboBoxType.TabIndex = 6;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(CreateQuestionSetLabel, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanelMain.Controls.Add(finishButton, 0, 3);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.Size = new Size(1163, 720);
            tableLayoutPanelMain.TabIndex = 7;
            // 
            // finishButton
            // 
            finishButton.Anchor = AnchorStyles.Left;
            finishButton.Location = new Point(3, 694);
            finishButton.Name = "finishButton";
            finishButton.Size = new Size(75, 23);
            finishButton.TabIndex = 1;
            finishButton.Text = "Finish";
            finishButton.UseVisualStyleBackColor = true;
            finishButton.Click += finishButton_Click;
            // 
            // panelQuestion
            // 
            panelQuestion.Dock = DockStyle.Fill;
            panelQuestion.Location = new Point(3, 3);
            panelQuestion.Name = "panelQuestion";
            panelQuestion.Size = new Size(706, 524);
            panelQuestion.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(715, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(439, 524);
            textBox2.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.53846F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.46154F));
            tableLayoutPanel2.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel2.Controls.Add(panelQuestion, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 158);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1157, 530);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // CreateQuestionSet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelMain);
            Name = "CreateQuestionSet";
            Size = new Size(1163, 720);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label CreateQuestionSetLabel;
        private Label label1;
        private TextBox textBoxQuestion;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBoxType;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox2;
        private Panel panelQuestion;
        private Button finishButton;
    }
}
