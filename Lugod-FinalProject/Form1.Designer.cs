namespace Lugod_FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            createQuestionSet1 = new CreateQuestionSet();
            buttonCreateQuestionSet = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // createQuestionSet1
            // 
            createQuestionSet1.Location = new Point(935, 12);
            createQuestionSet1.Name = "createQuestionSet1";
            createQuestionSet1.Size = new Size(143, 60);
            createQuestionSet1.TabIndex = 1;
            createQuestionSet1.Visible = false;
            createQuestionSet1.Load += createQuestionSet1_Load;
            // 
            // buttonCreateQuestionSet
            // 
            buttonCreateQuestionSet.Dock = DockStyle.Fill;
            buttonCreateQuestionSet.Location = new Point(3, 3);
            buttonCreateQuestionSet.Name = "buttonCreateQuestionSet";
            buttonCreateQuestionSet.Size = new Size(289, 42);
            buttonCreateQuestionSet.TabIndex = 2;
            buttonCreateQuestionSet.Text = "Create Question Set";
            buttonCreateQuestionSet.UseVisualStyleBackColor = true;
            buttonCreateQuestionSet.Click += buttonCreateQuestionSet_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonCreateQuestionSet, 0, 0);
            tableLayoutPanel1.Location = new Point(408, 237);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(295, 144);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 670);
            Controls.Add(createQuestionSet1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CreateQuestionSet createQuestionSet1;
        private Button buttonCreateQuestionSet;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
