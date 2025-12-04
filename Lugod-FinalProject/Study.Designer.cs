namespace Lugod_FinalProject
{
    partial class Study
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
            labelQuestion = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panelAnswer = new Panel();
            textBoxResponse = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonSubmit = new Button();
            buttonNext = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelQuestion, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(922, 504);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelQuestion
            // 
            labelQuestion.Anchor = AnchorStyles.Bottom;
            labelQuestion.AutoSize = true;
            labelQuestion.Location = new Point(442, 16);
            labelQuestion.Margin = new Padding(3, 16, 3, 16);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(38, 15);
            labelQuestion.TabIndex = 0;
            labelQuestion.Text = "label1";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panelAnswer, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxResponse, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 50);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(916, 411);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // panelAnswer
            // 
            panelAnswer.Dock = DockStyle.Fill;
            panelAnswer.Location = new Point(3, 3);
            panelAnswer.Name = "panelAnswer";
            panelAnswer.Size = new Size(452, 405);
            panelAnswer.TabIndex = 0;
            // 
            // textBoxResponse
            // 
            textBoxResponse.Dock = DockStyle.Fill;
            textBoxResponse.Location = new Point(461, 3);
            textBoxResponse.Multiline = true;
            textBoxResponse.Name = "textBoxResponse";
            textBoxResponse.ReadOnly = true;
            textBoxResponse.ScrollBars = ScrollBars.Vertical;
            textBoxResponse.Size = new Size(452, 405);
            textBoxResponse.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(buttonSubmit, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonNext, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 467);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(916, 34);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Anchor = AnchorStyles.Top;
            buttonSubmit.Location = new Point(191, 3);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonNext
            // 
            buttonNext.Anchor = AnchorStyles.Top;
            buttonNext.Location = new Point(649, 3);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(75, 23);
            buttonNext.TabIndex = 3;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // Study
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "Study";
            Size = new Size(922, 504);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelQuestion;
        private Button buttonSubmit;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panelAnswer;
        private TextBox textBoxResponse;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonNext;
    }
}
