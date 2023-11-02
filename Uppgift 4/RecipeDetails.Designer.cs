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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(48, 551);
            richTxtDescription.Margin = new Padding(4, 2, 4, 2);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.ReadOnly = true;
            richTxtDescription.ScrollBars = RichTextBoxScrollBars.Horizontal;
            richTxtDescription.Size = new Size(593, 308);
            richTxtDescription.TabIndex = 0;
            richTxtDescription.Text = "";
            richTxtDescription.DoubleClick += richTxtDescription_DoubleClick;
            // 
            // buttonUpdateRecipe
            // 
            buttonUpdateRecipe.Location = new Point(725, 666);
            buttonUpdateRecipe.Margin = new Padding(4, 2, 4, 2);
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
            buttonDeleteRecipe.Location = new Point(725, 761);
            buttonDeleteRecipe.Margin = new Padding(4, 2, 4, 2);
            buttonDeleteRecipe.Name = "buttonDeleteRecipe";
            buttonDeleteRecipe.Size = new Size(185, 62);
            buttonDeleteRecipe.TabIndex = 2;
            buttonDeleteRecipe.Text = "Delete recipe";
            buttonDeleteRecipe.UseVisualStyleBackColor = true;
            buttonDeleteRecipe.Visible = false;
            buttonDeleteRecipe.Click += buttonDeleteRecipe_Click;
            // 
            // buttonAddRecipe
            // 
            buttonAddRecipe.Location = new Point(725, 573);
            buttonAddRecipe.Margin = new Padding(4, 2, 4, 2);
            buttonAddRecipe.Name = "buttonAddRecipe";
            buttonAddRecipe.Size = new Size(190, 62);
            buttonAddRecipe.TabIndex = 3;
            buttonAddRecipe.Text = "Add new";
            buttonAddRecipe.UseVisualStyleBackColor = true;
            buttonAddRecipe.Visible = false;
            buttonAddRecipe.Click += buttonAddRecipe_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(170, 434);
            textBoxTitle.Margin = new Padding(4, 2, 4, 2);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.ReadOnly = true;
            textBoxTitle.Size = new Size(305, 31);
            textBoxTitle.TabIndex = 4;
            textBoxTitle.DoubleClick += TextBox_DoubleClick;
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(176, 77);
            textBoxType.Margin = new Padding(4, 2, 4, 2);
            textBoxType.Name = "textBoxType";
            textBoxType.ReadOnly = true;
            textBoxType.Size = new Size(305, 31);
            textBoxType.TabIndex = 5;
            textBoxType.TextChanged += textBoxType_TextChanged;
            textBoxType.DoubleClick += TextBox_DoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(298, 52);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 80);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 7;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(49, 438);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 8;
            label2.Text = "Title";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxType);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, 421);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 454);
            panel1.TabIndex = 9;
            // 
            // RecipeDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Startsida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 870);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBoxTitle);
            Controls.Add(buttonAddRecipe);
            Controls.Add(buttonDeleteRecipe);
            Controls.Add(buttonUpdateRecipe);
            Controls.Add(richTxtDescription);
            Controls.Add(panel1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "RecipeDetails";
            Text = "RecipeDetails";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}