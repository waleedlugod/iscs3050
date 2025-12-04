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
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxResponse = new TextBox();
            panelQuestion = new Panel();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            textBoxSetname = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonDone = new Button();
            buttonSave = new Button();
            buttonDelete = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panelQuestion.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // CreateQuestionSetLabel
            // 
            CreateQuestionSetLabel.Anchor = AnchorStyles.Left;
            CreateQuestionSetLabel.AutoSize = true;
            CreateQuestionSetLabel.Location = new Point(3, 8);
            CreateQuestionSetLabel.Name = "CreateQuestionSetLabel";
            CreateQuestionSetLabel.Size = new Size(108, 15);
            CreateQuestionSetLabel.TabIndex = 0;
            CreateQuestionSetLabel.Text = "Create question set";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Question:";
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.Anchor = AnchorStyles.Left;
            textBoxQuestion.Location = new Point(67, 4);
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.Size = new Size(697, 23);
            textBoxQuestion.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(26, 39);
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
            tableLayoutPanel1.Location = new Point(3, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1157, 63);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // comboBoxType
            // 
            comboBoxType.Anchor = AnchorStyles.Left;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Text", "List", "Radio" });
            comboBoxType.Location = new Point(67, 35);
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
            tableLayoutPanelMain.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanel1, 0, 4);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 5;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle());
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMain.Size = new Size(1163, 720);
            tableLayoutPanelMain.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.53846F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.46154F));
            tableLayoutPanel2.Controls.Add(textBoxResponse, 1, 0);
            tableLayoutPanel2.Controls.Add(panelQuestion, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 104);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1157, 533);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // textBoxResponse
            // 
            textBoxResponse.Dock = DockStyle.Fill;
            textBoxResponse.Location = new Point(715, 3);
            textBoxResponse.Multiline = true;
            textBoxResponse.Name = "textBoxResponse";
            textBoxResponse.ReadOnly = true;
            textBoxResponse.ScrollBars = ScrollBars.Both;
            textBoxResponse.Size = new Size(439, 527);
            textBoxResponse.TabIndex = 10;
            // 
            // panelQuestion
            // 
            panelQuestion.Controls.Add(label4);
            panelQuestion.Dock = DockStyle.Fill;
            panelQuestion.Location = new Point(3, 3);
            panelQuestion.Name = "panelQuestion";
            panelQuestion.Size = new Size(706, 527);
            panelQuestion.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 0;
            label4.Text = "Choose a question type";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(textBoxSetname, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 643);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(1157, 42);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 13);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 0;
            label3.Text = "Name of set:";
            // 
            // textBoxSetname
            // 
            textBoxSetname.Anchor = AnchorStyles.Left;
            textBoxSetname.Location = new Point(83, 9);
            textBoxSetname.Name = "textBoxSetname";
            textBoxSetname.Size = new Size(703, 23);
            textBoxSetname.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonDone);
            flowLayoutPanel1.Controls.Add(buttonSave);
            flowLayoutPanel1.Controls.Add(buttonDelete);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 688);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1163, 32);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.Left;
            buttonDone.Location = new Point(3, 3);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 23);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Done";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(84, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(165, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(135, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete last question";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
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
            panelQuestion.ResumeLayout(false);
            panelQuestion.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
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
        private TextBox textBoxResponse;
        private Panel panelQuestion;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private TextBox textBoxSetname;
        private Label label4;
        private Button buttonDone;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonSave;
        private Button buttonDelete;
    }
}
