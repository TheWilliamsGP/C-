namespace POE
{
    partial class DisplayForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Display_ListBox = new ListBox();
            Filter_button = new Button();
            ingredientTextBox = new TextBox();
            foodGroupComboBox = new ComboBox();
            MaxCalorie_textBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(292, 45);
            label1.Name = "label1";
            label1.Size = new Size(420, 72);
            label1.TabIndex = 0;
            label1.Text = "Display Recipes";
            // 
            // Display_ListBox
            // 
            Display_ListBox.BackColor = Color.LightSalmon;
            Display_ListBox.BorderStyle = BorderStyle.FixedSingle;
            Display_ListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Display_ListBox.FormattingEnabled = true;
            Display_ListBox.ItemHeight = 45;
            Display_ListBox.Location = new Point(99, 137);
            Display_ListBox.Name = "Display_ListBox";
            Display_ListBox.Size = new Size(849, 542);
            Display_ListBox.TabIndex = 1;
            // 
            // Filter_button
            // 
            Filter_button.Location = new Point(446, 858);
            Filter_button.Name = "Filter_button";
            Filter_button.Size = new Size(150, 46);
            Filter_button.TabIndex = 2;
            Filter_button.Text = "Filter";
            Filter_button.UseVisualStyleBackColor = true;
            // 
            // ingredientTextBox
            // 
            ingredientTextBox.Location = new Point(99, 791);
            ingredientTextBox.Name = "ingredientTextBox";
            ingredientTextBox.Size = new Size(200, 39);
            ingredientTextBox.TabIndex = 3;
            ingredientTextBox.TextChanged += ingredientTextBox_TextChanged;
            // 
            // foodGroupComboBox
            // 
            foodGroupComboBox.FormattingEnabled = true;
            foodGroupComboBox.Location = new Point(400, 790);
            foodGroupComboBox.Name = "foodGroupComboBox";
            foodGroupComboBox.Size = new Size(242, 40);
            foodGroupComboBox.TabIndex = 4;
            // 
            // MaxCalorie_textBox
            // 
            MaxCalorie_textBox.Location = new Point(748, 791);
            MaxCalorie_textBox.Name = "MaxCalorie_textBox";
            MaxCalorie_textBox.Size = new Size(200, 39);
            MaxCalorie_textBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 692);
            label2.Name = "label2";
            label2.Size = new Size(488, 32);
            label2.TabIndex = 6;
            label2.Text = "To filter a recipe search use one of the fields";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 746);
            label3.Name = "label3";
            label3.Size = new Size(784, 32);
            label3.TabIndex = 7;
            label3.Text = "Ingredient Name                       Food Group                               Calories";
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1079, 946);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MaxCalorie_textBox);
            Controls.Add(foodGroupComboBox);
            Controls.Add(ingredientTextBox);
            Controls.Add(Filter_button);
            Controls.Add(Display_ListBox);
            Controls.Add(label1);
            Name = "DisplayForm";
            Text = "DisplayForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox Display_ListBox;
        private Button Filter_button;
        private TextBox ingredientTextBox;
        private ComboBox foodGroupComboBox;
        private TextBox MaxCalorie_textBox;
        private Label label2;
        private Label label3;
    }
}