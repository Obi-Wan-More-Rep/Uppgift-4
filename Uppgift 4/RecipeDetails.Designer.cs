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
            richTxtDescription = new RichTextBox();
            buttonUpdateRecipe = new Button();
            buttonDeleteRecipe = new Button();
            buttonAddRecipe = new Button();
            textBoxTitle = new TextBox();
            textBoxType = new TextBox();
            SuspendLayout();
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(38, 91);
            richTxtDescription.Margin = new Padding(3, 2, 3, 2);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(395, 215);
            richTxtDescription.TabIndex = 0;
            richTxtDescription.Text = "";
            // 
            // buttonUpdateRecipe
            // 
            buttonUpdateRecipe.Location = new Point(508, 112);
            buttonUpdateRecipe.Margin = new Padding(3, 2, 3, 2);
            buttonUpdateRecipe.Name = "buttonUpdateRecipe";
            buttonUpdateRecipe.Size = new Size(133, 36);
            buttonUpdateRecipe.TabIndex = 1;
            buttonUpdateRecipe.Text = "Update";
            buttonUpdateRecipe.UseVisualStyleBackColor = true;
            buttonUpdateRecipe.Visible = false;
            buttonUpdateRecipe.Click += buttonUpdateRecipe_Click;
            // 
            // buttonDeleteRecipe
            // 
            buttonDeleteRecipe.Location = new Point(508, 178);
            buttonDeleteRecipe.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteRecipe.Name = "buttonDeleteRecipe";
            buttonDeleteRecipe.Size = new Size(133, 40);
            buttonDeleteRecipe.TabIndex = 2;
            buttonDeleteRecipe.Text = "Delete recipe";
            buttonDeleteRecipe.UseVisualStyleBackColor = true;
            buttonDeleteRecipe.Visible = false;
            buttonDeleteRecipe.Click += buttonDeleteRecipe_Click;
            // 
            // buttonAddRecipe
            // 
            buttonAddRecipe.Location = new Point(508, 256);
            buttonAddRecipe.Margin = new Padding(3, 2, 3, 2);
            buttonAddRecipe.Name = "buttonAddRecipe";
            buttonAddRecipe.Size = new Size(133, 38);
            buttonAddRecipe.TabIndex = 3;
            buttonAddRecipe.Text = "Add new";
            buttonAddRecipe.UseVisualStyleBackColor = true;
            buttonAddRecipe.Visible = false;
            buttonAddRecipe.Click += buttonAddRecipe_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(38, 43);
            textBoxTitle.Margin = new Padding(3, 2, 3, 2);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(215, 23);
            textBoxTitle.TabIndex = 4;
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(38, 68);
            textBoxType.Margin = new Padding(3, 2, 3, 2);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(110, 23);
            textBoxType.TabIndex = 5;
            // 
            // RecipeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(textBoxType);
            Controls.Add(textBoxTitle);
            Controls.Add(buttonAddRecipe);
            Controls.Add(buttonDeleteRecipe);
            Controls.Add(buttonUpdateRecipe);
            Controls.Add(richTxtDescription);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RecipeDetails";
            Text = "RecipeDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTxtDescription;
        private Button buttonUpdateRecipe;
        private Button buttonDeleteRecipe;
        private Button buttonAddRecipe;
        private TextBox textBoxTitle;
        private TextBox textBoxType;
    }
}