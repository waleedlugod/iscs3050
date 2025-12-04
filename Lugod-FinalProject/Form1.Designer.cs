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
            buttonCreateQuestionSet = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxFile = new TextBox();
            label1 = new Label();
            buttonStudy = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCreateQuestionSet
            // 
            buttonCreateQuestionSet.Dock = DockStyle.Fill;
            buttonCreateQuestionSet.Location = new Point(3, 3);
            buttonCreateQuestionSet.Name = "buttonCreateQuestionSet";
            buttonCreateQuestionSet.Size = new Size(203, 55);
            buttonCreateQuestionSet.TabIndex = 2;
            buttonCreateQuestionSet.Text = "Create question set";
            buttonCreateQuestionSet.UseVisualStyleBackColor = true;
            buttonCreateQuestionSet.Click += buttonCreateQuestionSet_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(buttonCreateQuestionSet, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonStudy, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxFile, 2, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Location = new Point(259, 228);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(593, 123);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // textBoxFile
            // 
            textBoxFile.Anchor = AnchorStyles.Left;
            textBoxFile.Location = new Point(279, 80);
            textBoxFile.Name = "textBoxFile";
            textBoxFile.Size = new Size(308, 23);
            textBoxFile.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(212, 84);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 6;
            label1.Text = "File name:";
            // 
            // buttonStudy
            // 
            buttonStudy.Dock = DockStyle.Fill;
            buttonStudy.Location = new Point(3, 64);
            buttonStudy.Name = "buttonStudy";
            buttonStudy.Size = new Size(203, 56);
            buttonStudy.TabIndex = 4;
            buttonStudy.Text = "Start studying";
            buttonStudy.UseVisualStyleBackColor = true;
            buttonStudy.Click += buttonStudy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 670);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonCreateQuestionSet;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonStudy;
        private TextBox textBoxFile;
        private Label label1;
    }
}
