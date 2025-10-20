namespace Lugod_LongExercise2
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
            textBoxResponse = new TextBox();
            textBoxBurgerPatties = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            buttonOrderBurger = new Button();
            buttonOrderSide = new Button();
            buttonOrderWrap = new Button();
            label2 = new Label();
            textBoxBurgerCheese = new TextBox();
            checkBoxVeggies = new CheckBox();
            comboBoxSideType = new ComboBox();
            labelSide = new Label();
            labelSize = new Label();
            comboBoxSideSize = new ComboBox();
            label3 = new Label();
            textBoxWrapCheese = new TextBox();
            checkBoxWrapMeat = new CheckBox();
            label4 = new Label();
            comboBoxWrapSpice = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxDelete = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // textBoxResponse
            // 
            textBoxResponse.Location = new Point(18, 288);
            textBoxResponse.Multiline = true;
            textBoxResponse.Name = "textBoxResponse";
            textBoxResponse.ReadOnly = true;
            textBoxResponse.ScrollBars = ScrollBars.Both;
            textBoxResponse.Size = new Size(770, 150);
            textBoxResponse.TabIndex = 28;
            // 
            // textBoxBurgerPatties
            // 
            textBoxBurgerPatties.Location = new Point(190, 34);
            textBoxBurgerPatties.Name = "textBoxBurgerPatties";
            textBoxBurgerPatties.Size = new Size(100, 23);
            textBoxBurgerPatties.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 37);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 1;
            label1.Text = "Extra Patties (50 PHP per slice):";
            // 
            // button1
            // 
            button1.Location = new Point(352, 230);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "view order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(348, 181);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 5;
            button2.Text = "delete meal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(467, 259);
            button3.Name = "button3";
            button3.Size = new Size(103, 23);
            button3.TabIndex = 6;
            button3.Text = "delete last order";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(352, 259);
            button4.Name = "button4";
            button4.Size = new Size(109, 23);
            button4.TabIndex = 7;
            button4.Text = "view all orders";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(433, 230);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 8;
            button5.Text = "finish order";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // buttonOrderBurger
            // 
            buttonOrderBurger.Location = new Point(19, 113);
            buttonOrderBurger.Name = "buttonOrderBurger";
            buttonOrderBurger.Size = new Size(100, 23);
            buttonOrderBurger.TabIndex = 10;
            buttonOrderBurger.Text = "order burger";
            buttonOrderBurger.UseVisualStyleBackColor = true;
            buttonOrderBurger.Click += buttonOrderBurger_Click;
            // 
            // buttonOrderSide
            // 
            buttonOrderSide.Location = new Point(343, 87);
            buttonOrderSide.Name = "buttonOrderSide";
            buttonOrderSide.Size = new Size(75, 23);
            buttonOrderSide.TabIndex = 11;
            buttonOrderSide.Text = "order side";
            buttonOrderSide.UseVisualStyleBackColor = true;
            buttonOrderSide.Click += buttonOrderSide_Click;
            // 
            // buttonOrderWrap
            // 
            buttonOrderWrap.Location = new Point(19, 259);
            buttonOrderWrap.Name = "buttonOrderWrap";
            buttonOrderWrap.Size = new Size(75, 23);
            buttonOrderWrap.TabIndex = 12;
            buttonOrderWrap.Text = "order wrap";
            buttonOrderWrap.UseVisualStyleBackColor = true;
            buttonOrderWrap.Click += buttonOrderWrap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 65);
            label2.Name = "label2";
            label2.Size = new Size(171, 15);
            label2.TabIndex = 14;
            label2.Text = "Extra Cheese (25 PHP per slice):";
            // 
            // textBoxBurgerCheese
            // 
            textBoxBurgerCheese.Location = new Point(191, 62);
            textBoxBurgerCheese.Name = "textBoxBurgerCheese";
            textBoxBurgerCheese.Size = new Size(100, 23);
            textBoxBurgerCheese.TabIndex = 13;
            // 
            // checkBoxVeggies
            // 
            checkBoxVeggies.AutoSize = true;
            checkBoxVeggies.Location = new Point(19, 89);
            checkBoxVeggies.Name = "checkBoxVeggies";
            checkBoxVeggies.Size = new Size(71, 19);
            checkBoxVeggies.TabIndex = 15;
            checkBoxVeggies.Text = "veggies?";
            checkBoxVeggies.UseVisualStyleBackColor = true;
            // 
            // comboBoxSideType
            // 
            comboBoxSideType.FormattingEnabled = true;
            comboBoxSideType.Location = new Point(383, 32);
            comboBoxSideType.Name = "comboBoxSideType";
            comboBoxSideType.Size = new Size(324, 23);
            comboBoxSideType.TabIndex = 16;
            // 
            // labelSide
            // 
            labelSide.AutoSize = true;
            labelSide.Location = new Point(343, 37);
            labelSide.Name = "labelSide";
            labelSide.Size = new Size(32, 15);
            labelSide.TabIndex = 17;
            labelSide.Text = "Side:";
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(343, 63);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(30, 15);
            labelSize.TabIndex = 19;
            labelSize.Text = "Size:";
            // 
            // comboBoxSideSize
            // 
            comboBoxSideSize.FormattingEnabled = true;
            comboBoxSideSize.Location = new Point(383, 58);
            comboBoxSideSize.Name = "comboBoxSideSize";
            comboBoxSideSize.Size = new Size(121, 23);
            comboBoxSideSize.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 179);
            label3.Name = "label3";
            label3.Size = new Size(171, 15);
            label3.TabIndex = 21;
            label3.Text = "Extra Cheese (20 PHP per slice):";
            // 
            // textBoxWrapCheese
            // 
            textBoxWrapCheese.Location = new Point(192, 176);
            textBoxWrapCheese.Name = "textBoxWrapCheese";
            textBoxWrapCheese.Size = new Size(100, 23);
            textBoxWrapCheese.TabIndex = 20;
            // 
            // checkBoxWrapMeat
            // 
            checkBoxWrapMeat.AutoSize = true;
            checkBoxWrapMeat.Location = new Point(18, 205);
            checkBoxWrapMeat.Name = "checkBoxWrapMeat";
            checkBoxWrapMeat.Size = new Size(73, 19);
            checkBoxWrapMeat.TabIndex = 22;
            checkBoxWrapMeat.Text = "all meat?";
            checkBoxWrapMeat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 235);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 24;
            label4.Text = "Spice:";
            // 
            // comboBoxWrapSpice
            // 
            comboBoxWrapSpice.FormattingEnabled = true;
            comboBoxWrapSpice.Location = new Point(59, 230);
            comboBoxWrapSpice.Name = "comboBoxWrapSpice";
            comboBoxWrapSpice.Size = new Size(121, 23);
            comboBoxWrapSpice.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 14);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 25;
            label5.Text = "Order Burger";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 14);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 26;
            label6.Text = "Order Side";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 158);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 27;
            label7.Text = "Order Wrap";
            // 
            // textBoxDelete
            // 
            textBoxDelete.Location = new Point(439, 155);
            textBoxDelete.Name = "textBoxDelete";
            textBoxDelete.Size = new Size(110, 23);
            textBoxDelete.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(348, 158);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 30;
            label8.Text = "Meal to delete:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(textBoxDelete);
            Controls.Add(textBoxResponse);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxWrapSpice);
            Controls.Add(checkBoxWrapMeat);
            Controls.Add(label3);
            Controls.Add(textBoxWrapCheese);
            Controls.Add(labelSize);
            Controls.Add(comboBoxSideSize);
            Controls.Add(labelSide);
            Controls.Add(comboBoxSideType);
            Controls.Add(checkBoxVeggies);
            Controls.Add(label2);
            Controls.Add(textBoxBurgerCheese);
            Controls.Add(buttonOrderWrap);
            Controls.Add(buttonOrderSide);
            Controls.Add(buttonOrderBurger);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBoxBurgerPatties);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxBurgerPatties;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button buttonOrderBurger;
        private Button buttonOrderSide;
        private Button buttonOrderWrap;
        private Label label2;
        private TextBox textBoxBurgerCheese;
        private CheckBox checkBoxVeggies;
        private ComboBox comboBoxSideType;
        private Label labelSide;
        private Label labelSize;
        private ComboBox comboBoxSideSize;
        private Label label3;
        private TextBox textBoxWrapCheese;
        private CheckBox checkBoxWrapMeat;
        private Label label4;
        private ComboBox comboBoxWrapSpice;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxResponse;
        private TextBox textBoxDelete;
        private Label label8;
    }
}
