namespace POE
{
    partial class IngredientForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Ingredient_textBox = new TextBox();
            Quantity_textBox = new TextBox();
            UnitOfMeasure_textBox = new TextBox();
            Calories_textBox = new TextBox();
            FoodGroup_comboBox = new ComboBox();
            Add_button = new Button();
            Save_button = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(124, 40);
            label1.Name = "label1";
            label1.Size = new Size(675, 72);
            label1.TabIndex = 0;
            label1.Text = "Enter the list of Ingredients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(134, 172);
            label2.Name = "label2";
            label2.Size = new Size(251, 45);
            label2.TabIndex = 1;
            label2.Text = "Ingredint Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(134, 253);
            label3.Name = "label3";
            label3.Size = new Size(157, 45);
            label3.TabIndex = 2;
            label3.Text = "Quantity: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(134, 352);
            label4.Name = "label4";
            label4.Size = new Size(255, 45);
            label4.TabIndex = 3;
            label4.Text = "Unit of Measure:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(134, 451);
            label5.Name = "label5";
            label5.Size = new Size(140, 45);
            label5.TabIndex = 4;
            label5.Text = "Calories:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(134, 535);
            label6.Name = "label6";
            label6.Size = new Size(198, 45);
            label6.TabIndex = 5;
            label6.Text = "Food Group:";
            // 
            // Ingredient_textBox
            // 
            Ingredient_textBox.BorderStyle = BorderStyle.FixedSingle;
            Ingredient_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Ingredient_textBox.Location = new Point(507, 169);
            Ingredient_textBox.Name = "Ingredient_textBox";
            Ingredient_textBox.Size = new Size(242, 50);
            Ingredient_textBox.TabIndex = 6;
            // 
            // Quantity_textBox
            // 
            Quantity_textBox.BorderStyle = BorderStyle.FixedSingle;
            Quantity_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Quantity_textBox.Location = new Point(507, 250);
            Quantity_textBox.Name = "Quantity_textBox";
            Quantity_textBox.Size = new Size(242, 50);
            Quantity_textBox.TabIndex = 7;
            // 
            // UnitOfMeasure_textBox
            // 
            UnitOfMeasure_textBox.BorderStyle = BorderStyle.FixedSingle;
            UnitOfMeasure_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UnitOfMeasure_textBox.Location = new Point(507, 345);
            UnitOfMeasure_textBox.Name = "UnitOfMeasure_textBox";
            UnitOfMeasure_textBox.Size = new Size(242, 50);
            UnitOfMeasure_textBox.TabIndex = 8;
            // 
            // Calories_textBox
            // 
            Calories_textBox.BorderStyle = BorderStyle.FixedSingle;
            Calories_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Calories_textBox.Location = new Point(507, 451);
            Calories_textBox.Name = "Calories_textBox";
            Calories_textBox.Size = new Size(242, 50);
            Calories_textBox.TabIndex = 9;
            // 
            // FoodGroup_comboBox
            // 
            FoodGroup_comboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FoodGroup_comboBox.FormattingEnabled = true;
            FoodGroup_comboBox.Location = new Point(507, 546);
            FoodGroup_comboBox.Name = "FoodGroup_comboBox";
            FoodGroup_comboBox.Size = new Size(242, 53);
            FoodGroup_comboBox.TabIndex = 10;
            // 
            // Add_button
            // 
            Add_button.BackColor = Color.PeachPuff;
            Add_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Add_button.Location = new Point(134, 645);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(264, 58);
            Add_button.TabIndex = 11;
            Add_button.Text = "Add Ingredient";
            Add_button.UseVisualStyleBackColor = false;
            // 
            // Save_button
            // 
            Save_button.BackColor = Color.LightGreen;
            Save_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Save_button.Location = new Point(522, 645);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(245, 58);
            Save_button.TabIndex = 12;
            Save_button.Text = "Save and Next";
            Save_button.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(72, 764);
            label7.Name = "label7";
            label7.Size = new Size(740, 96);
            label7.TabIndex = 13;
            label7.Text = "Note: Once ingredients boxes are filled click the Add ingredient button\r\n add more ingrendients once finished\r\n select save and next to continue";
            // 
            // IngredientForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(944, 888);
            Controls.Add(label7);
            Controls.Add(Save_button);
            Controls.Add(Add_button);
            Controls.Add(FoodGroup_comboBox);
            Controls.Add(Calories_textBox);
            Controls.Add(UnitOfMeasure_textBox);
            Controls.Add(Quantity_textBox);
            Controls.Add(Ingredient_textBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IngredientForm";
            Text = "IngredientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Ingredient_textBox;
        private TextBox Quantity_textBox;
        private TextBox UnitOfMeasure_textBox;
        private TextBox Calories_textBox;
        private ComboBox FoodGroup_comboBox;
        private Button Add_button;
        private Button Save_button;
        private Label label7;
    }
}