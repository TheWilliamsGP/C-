namespace POE
{
    partial class AddRecipes
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
            Save_button = new Button();
            label1 = new Label();
            RecipeName_textBox = new TextBox();
            SuspendLayout();
            // 
            // Save_button
            // 
            Save_button.BackColor = Color.LightGreen;
            Save_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Save_button.ForeColor = SystemColors.ActiveCaptionText;
            Save_button.Location = new Point(245, 359);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(252, 92);
            Save_button.TabIndex = 0;
            Save_button.Text = "Save and Next";
            Save_button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(82, 58);
            label1.Name = "label1";
            label1.Size = new Size(618, 72);
            label1.TabIndex = 1;
            label1.Text = "Enter the Recipe Name ";
            // 
            // RecipeName_textBox
            // 
            RecipeName_textBox.BackColor = SystemColors.Info;
            RecipeName_textBox.BorderStyle = BorderStyle.FixedSingle;
            RecipeName_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RecipeName_textBox.Location = new Point(161, 215);
            RecipeName_textBox.Name = "RecipeName_textBox";
            RecipeName_textBox.Size = new Size(435, 50);
            RecipeName_textBox.TabIndex = 2;
            // 
            // AddRecipes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(761, 576);
            Controls.Add(RecipeName_textBox);
            Controls.Add(label1);
            Controls.Add(Save_button);
            Name = "AddRecipes";
            Text = "AddRecipes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Save_button;
        private Label label1;
        private TextBox RecipeName_textBox;
    }
}