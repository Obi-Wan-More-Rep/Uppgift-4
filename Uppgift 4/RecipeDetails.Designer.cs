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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(43, 130);
            richTxtDescription.Margin = new Padding(3, 2, 3, 2);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.ReadOnly = true;
            richTxtDescription.Size = new Size(451, 286);
            richTxtDescription.TabIndex = 0;
            richTxtDescription.Text = "";
            richTxtDescription.DoubleClick += richTxtDescription_DoubleClick;
            // 
            // buttonUpdateRecipe
            // 
            buttonUpdateRecipe.Location = new Point(581, 150);
            buttonUpdateRecipe.Margin = new Padding(3, 2, 3, 2);
            buttonUpdateRecipe.Name = "buttonUpdateRecipe";
            buttonUpdateRecipe.Size = new Size(152, 48);
            buttonUpdateRecipe.TabIndex = 1;
            buttonUpdateRecipe.Text = "Update";
            buttonUpdateRecipe.UseVisualStyleBackColor = true;
            buttonUpdateRecipe.Visible = false;
            buttonUpdateRecipe.Click += buttonUpdateRecipe_Click;
            // 
            // buttonDeleteRecipe
            // 
            buttonDeleteRecipe.Location = new Point(581, 238);
            buttonDeleteRecipe.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteRecipe.Name = "buttonDeleteRecipe";
            buttonDeleteRecipe.Size = new Size(152, 54);
            buttonDeleteRecipe.TabIndex = 2;
            buttonDeleteRecipe.Text = "Delete recipe";
            buttonDeleteRecipe.UseVisualStyleBackColor = true;
            buttonDeleteRecipe.Visible = false;
            buttonDeleteRecipe.Click += buttonDeleteRecipe_Click;
            // 
            // buttonAddRecipe
            // 
            buttonAddRecipe.Location = new Point(581, 342);
            buttonAddRecipe.Margin = new Padding(3, 2, 3, 2);
            buttonAddRecipe.Name = "buttonAddRecipe";
            buttonAddRecipe.Size = new Size(152, 50);
            buttonAddRecipe.TabIndex = 3;
            buttonAddRecipe.Text = "Add new";
            buttonAddRecipe.UseVisualStyleBackColor = true;
            buttonAddRecipe.Visible = false;
            buttonAddRecipe.Click += buttonAddRecipe_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(43, 58);
            textBoxTitle.Margin = new Padding(3, 2, 3, 2);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.ReadOnly = true;
            textBoxTitle.Size = new Size(245, 27);
            textBoxTitle.TabIndex = 4;
            textBoxTitle.DoubleClick += TextBox_DoubleClick;
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(43, 90);
            textBoxType.Margin = new Padding(3, 2, 3, 2);
            textBoxType.Name = "textBoxType";
            textBoxType.ReadOnly = true;
            textBoxType.Size = new Size(125, 27);
            textBoxType.TabIndex = 5;
            textBoxType.DoubleClick += TextBox_DoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(544, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // RecipeDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxType);
            Controls.Add(textBoxTitle);
            Controls.Add(buttonAddRecipe);
            Controls.Add(buttonDeleteRecipe);
            Controls.Add(buttonUpdateRecipe);
            Controls.Add(richTxtDescription);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RecipeDetails";
            Text = "RecipeDetails";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}