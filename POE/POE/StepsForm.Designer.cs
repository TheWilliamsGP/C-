namespace POE
{
    partial class StepsForm
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
            Steps_textBox = new TextBox();
            Add_button = new Button();
            Finish_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(29, 59);
            label1.Name = "label1";
            label1.Size = new Size(715, 54);
            label1.TabIndex = 0;
            label1.Text = "Enter in the steps to make the recipe ";
            // 
            // Steps_textBox
            // 
            Steps_textBox.BorderStyle = BorderStyle.FixedSingle;
            Steps_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Steps_textBox.Location = new Point(125, 162);
            Steps_textBox.Multiline = true;
            Steps_textBox.Name = "Steps_textBox";
            Steps_textBox.Size = new Size(505, 78);
            Steps_textBox.TabIndex = 1;
            // 
            // Add_button
            // 
            Add_button.BackColor = Color.PeachPuff;
            Add_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Add_button.Location = new Point(114, 353);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(208, 74);
            Add_button.TabIndex = 2;
            Add_button.Text = "Add Step";
            Add_button.UseVisualStyleBackColor = false;
            // 
            // Finish_button
            // 
            Finish_button.BackColor = Color.LightGreen;
            Finish_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Finish_button.Location = new Point(454, 353);
            Finish_button.Name = "Finish_button";
            Finish_button.Size = new Size(176, 74);
            Finish_button.TabIndex = 3;
            Finish_button.Text = "Finish";
            Finish_button.UseVisualStyleBackColor = false;
            // 
            // StepsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(779, 524);
            Controls.Add(Finish_button);
            Controls.Add(Add_button);
            Controls.Add(Steps_textBox);
            Controls.Add(label1);
            Name = "StepsForm";
            Text = "StepsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Steps_textBox;
        private Button Add_button;
        private Button Finish_button;
    }
}