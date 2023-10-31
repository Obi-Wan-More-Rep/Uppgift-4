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
            richTxtDescription.Location = new Point(54, 163);
            richTxtDescription.Margin = new Padding(4, 3, 4, 3);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.ReadOnly = true;
            richTxtDescription.Size = new Size(563, 356);
            richTxtDescription.TabIndex = 0;
            richTxtDescription.Text = "";
            richTxtDescription.DoubleClick += richTxtDescription_DoubleClick;
            // 
            // buttonUpdateRecipe
            // 
            buttonUpdateRecipe.Location = new Point(726, 187);
            buttonUpdateRecipe.Margin = new Padding(4, 3, 4, 3);
            buttonUpdateRecipe.Name = "buttonUpdateRecipe";
            buttonUpdateRecipe.Size = new Size(190, 60);
            buttonUpdateRecipe.TabIndex = 1;
            buttonUpdateRecipe.Text = "Update";
            buttonUpdateRecipe.UseVisualStyleBackColor = true;
            buttonUpdateRecipe.Visible = false;
            buttonUpdateRecipe.Click += buttonUpdateRecipe_Click;
            // 
            // buttonDeleteRecipe
            // 
            buttonDeleteRecipe.Location = new Point(726, 297);
            buttonDeleteRecipe.Margin = new Padding(4, 3, 4, 3);
            buttonDeleteRecipe.Name = "buttonDeleteRecipe";
            buttonDeleteRecipe.Size = new Size(190, 67);
            buttonDeleteRecipe.TabIndex = 2;
            buttonDeleteRecipe.Text = "Delete recipe";
            buttonDeleteRecipe.UseVisualStyleBackColor = true;
            buttonDeleteRecipe.Visible = false;
            buttonDeleteRecipe.Click += buttonDeleteRecipe_Click;
            // 
            // buttonAddRecipe
            // 
            buttonAddRecipe.Location = new Point(726, 427);
            buttonAddRecipe.Margin = new Padding(4, 3, 4, 3);
            buttonAddRecipe.Name = "buttonAddRecipe";
            buttonAddRecipe.Size = new Size(190, 63);
            buttonAddRecipe.TabIndex = 3;
            buttonAddRecipe.Text = "Add new";
            buttonAddRecipe.UseVisualStyleBackColor = true;
            buttonAddRecipe.Visible = false;
            buttonAddRecipe.Click += buttonAddRecipe_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(54, 72);
            textBoxTitle.Margin = new Padding(4, 3, 4, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.ReadOnly = true;
            textBoxTitle.Size = new Size(305, 31);
            textBoxTitle.TabIndex = 4;
            textBoxTitle.DoubleClick += TextBox_DoubleClick;
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(54, 113);
            textBoxType.Margin = new Padding(4, 3, 4, 3);
            textBoxType.Name = "textBoxType";
            textBoxType.ReadOnly = true;
            textBoxType.Size = new Size(155, 31);
            textBoxType.TabIndex = 5;
            textBoxType.DoubleClick += TextBox_DoubleClick;
            // 
            // RecipeDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 563);
            Controls.Add(textBoxType);
            Controls.Add(textBoxTitle);
            Controls.Add(buttonAddRecipe);
            Controls.Add(buttonDeleteRecipe);
            Controls.Add(buttonUpdateRecipe);
            Controls.Add(richTxtDescription);
            Margin = new Padding(4, 3, 4, 3);
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