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
            Title = new DataGridViewTextBoxColumn();
            buttonSearch = new Button();
            buttonSignIn = new Button();
            buttonSignOut = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            textBoxSearch = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Title });
            dataGridView.Location = new Point(138, 94);
            dataGridView.Margin = new Padding(3, 2, 3, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(359, 223);
            dataGridView.TabIndex = 0;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(138, 46);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(82, 22);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonSignIn
            // 
            buttonSignIn.Location = new Point(3, 94);
            buttonSignIn.Margin = new Padding(3, 2, 3, 2);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(82, 22);
            buttonSignIn.TabIndex = 2;
            buttonSignIn.Text = "Sign in";
            buttonSignIn.UseVisualStyleBackColor = true;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // buttonSignOut
            // 
            buttonSignOut.Location = new Point(3, 143);
            buttonSignOut.Margin = new Padding(3, 2, 3, 2);
            buttonSignOut.Name = "buttonSignOut";
            buttonSignOut.Size = new Size(82, 22);
            buttonSignOut.TabIndex = 3;
            buttonSignOut.Text = "Sign out";
            buttonSignOut.UseVisualStyleBackColor = true;
            buttonSignOut.Click += buttonSignOut_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 199);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(82, 22);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(3, 251);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(82, 22);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(259, 46);
            textBoxSearch.Margin = new Padding(3, 2, 3, 2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(225, 23);
            textBoxSearch.TabIndex = 6;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(549, 47);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(comboBox1);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSignOut);
            Controls.Add(buttonSignIn);
            Controls.Add(buttonSearch);
            Controls.Add(dataGridView);
            Margin = new Padding(3, 2, 3, 2);
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