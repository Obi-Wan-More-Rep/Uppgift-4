namespace Uppgift_4
{
    partial class RecipeDetails
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
            richTextBox1 = new RichTextBox();
            buttonUpdateRecipe = new Button();
            buttonDeleteRecipe = new Button();
            buttonAddRecipe = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(43, 121);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(451, 285);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // buttonUpdateRecipe
            // 
            buttonUpdateRecipe.Location = new Point(581, 149);
            buttonUpdateRecipe.Name = "buttonUpdateRecipe";
            buttonUpdateRecipe.Size = new Size(152, 48);
            buttonUpdateRecipe.TabIndex = 1;
            buttonUpdateRecipe.Text = "Update";
            buttonUpdateRecipe.UseVisualStyleBackColor = true;
            buttonUpdateRecipe.Visible = false;
            // 
            // buttonDeleteRecipe
            // 
            buttonDeleteRecipe.Location = new Point(581, 238);
            buttonDeleteRecipe.Name = "buttonDeleteRecipe";
            buttonDeleteRecipe.Size = new Size(152, 54);
            buttonDeleteRecipe.TabIndex = 2;
            buttonDeleteRecipe.Text = "Delete recipe";
            buttonDeleteRecipe.UseVisualStyleBackColor = true;
            buttonDeleteRecipe.Visible = false;
            // 
            // buttonAddRecipe
            // 
            buttonAddRecipe.Location = new Point(581, 342);
            buttonAddRecipe.Name = "buttonAddRecipe";
            buttonAddRecipe.Size = new Size(152, 50);
            buttonAddRecipe.TabIndex = 3;
            buttonAddRecipe.Text = "Add new";
            buttonAddRecipe.UseVisualStyleBackColor = true;
            buttonAddRecipe.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(43, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // RecipeDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonAddRecipe);
            Controls.Add(buttonDeleteRecipe);
            Controls.Add(buttonUpdateRecipe);
            Controls.Add(richTextBox1);
            Name = "RecipeDetails";
            Text = "RecipeDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button buttonUpdateRecipe;
        private Button buttonDeleteRecipe;
        private Button buttonAddRecipe;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}