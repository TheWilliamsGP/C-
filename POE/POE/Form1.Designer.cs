namespace POE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            AddRecipe_button = new Button();
            Display_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(219, 70);
            label1.Name = "label1";
            label1.Size = new Size(660, 72);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Recipe Book";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 339);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(474, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // AddRecipe_button
            // 
            AddRecipe_button.BackColor = SystemColors.Info;
            AddRecipe_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddRecipe_button.Location = new Point(737, 339);
            AddRecipe_button.Name = "AddRecipe_button";
            AddRecipe_button.Size = new Size(275, 101);
            AddRecipe_button.TabIndex = 2;
            AddRecipe_button.Text = "Add Recipe";
            AddRecipe_button.UseVisualStyleBackColor = false;
            AddRecipe_button.Click += AddRecipe_button_Click;
            // 
            // Display_button
            // 
            Display_button.BackColor = Color.LightSalmon;
            Display_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Display_button.Location = new Point(737, 518);
            Display_button.Name = "Display_button";
            Display_button.Size = new Size(275, 111);
            Display_button.TabIndex = 3;
            Display_button.Text = "Display Recipe";
            Display_button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1123, 865);
            Controls.Add(Display_button);
            Controls.Add(AddRecipe_button);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button AddRecipe_button;
        private Button Display_button;
    }
}