namespace Uppgift_4
{
    partial class MainForm
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
            dataGridView = new DataGridView();
            buttonSearch = new Button();
            buttonSignIn = new Button();
            buttonSignOut = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            textBoxSearch = new TextBox();
            comboBox1 = new ComboBox();
            Title = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Title });
            dataGridView.Location = new Point(158, 126);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(410, 297);
            dataGridView.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(158, 62);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonSignIn
            // 
            buttonSignIn.Location = new Point(3, 126);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(94, 29);
            buttonSignIn.TabIndex = 2;
            buttonSignIn.Text = "Sign in";
            buttonSignIn.UseVisualStyleBackColor = true;
            // 
            // buttonSignOut
            // 
            buttonSignOut.Location = new Point(3, 191);
            buttonSignOut.Name = "buttonSignOut";
            buttonSignOut.Size = new Size(94, 29);
            buttonSignOut.TabIndex = 3;
            buttonSignOut.Text = "Sign out";
            buttonSignOut.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 265);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(12, 335);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(296, 62);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(257, 27);
            textBoxSearch.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(627, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSignOut);
            Controls.Add(buttonSignIn);
            Controls.Add(buttonSearch);
            Controls.Add(dataGridView);
            Name = "MainForm";
            Text = "International Food AB";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button buttonSearch;
        private Button buttonSignIn;
        private Button buttonSignOut;
        private Button buttonAdd;
        private Button buttonDelete;
        private TextBox textBoxSearch;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn Title;
    }
}