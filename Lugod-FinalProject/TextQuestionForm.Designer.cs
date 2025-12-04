namespace Lugod_FinalProject
{
    partial class TextQuestionForm
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
            label2 = new Label();
            textBoxTextAnswer = new TextBox();
            checkBoxTextSensitivity = new CheckBox();
            buttonAdd = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxTextAnswer, 1, 0);
            tableLayoutPanel1.Controls.Add(checkBoxTextSensitivity, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonAdd, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(282, 128);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Answer:";
            // 
            // textBoxTextAnswer
            // 
            textBoxTextAnswer.Anchor = AnchorStyles.Left;
            textBoxTextAnswer.Location = new Point(58, 3);
            textBoxTextAnswer.Name = "textBoxTextAnswer";
            textBoxTextAnswer.Size = new Size(221, 23);
            textBoxTextAnswer.TabIndex = 2;
            // 
            // checkBoxTextSensitivity
            // 
            checkBoxTextSensitivity.Anchor = AnchorStyles.Left;
            checkBoxTextSensitivity.AutoSize = true;
            checkBoxTextSensitivity.Location = new Point(58, 32);
            checkBoxTextSensitivity.Name = "checkBoxTextSensitivity";
            checkBoxTextSensitivity.Size = new Size(102, 19);
            checkBoxTextSensitivity.TabIndex = 5;
            checkBoxTextSensitivity.Text = "case sensitive?";
            checkBoxTextSensitivity.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(58, 57);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(131, 23);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add to question set";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // TextQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TextQuestionForm";
            Size = new Size(282, 128);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox textBoxTextAnswer;
        private CheckBox checkBoxTextSensitivity;
        private Button buttonAdd;
    }
}
