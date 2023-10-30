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
            buttonSignIn = new Button();
            buttonSignOut = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            textBoxSearch = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Title });
            dataGridView.Location = new Point(158, 125);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(410, 297);
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
            // buttonSignIn
            // 
            buttonSignIn.Location = new Point(3, 125);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(94, 29);
            buttonSignIn.TabIndex = 2;
            buttonSignIn.Text = "Sign in";
            buttonSignIn.UseVisualStyleBackColor = true;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // buttonSignOut
            // 
            buttonSignOut.Location = new Point(3, 191);
            buttonSignOut.Name = "buttonSignOut";
            buttonSignOut.Size = new Size(94, 29);
            buttonSignOut.TabIndex = 3;
            buttonSignOut.Text = "Sign out";
            buttonSignOut.UseVisualStyleBackColor = true;
            buttonSignOut.Click += buttonSignOut_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 265);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(3, 335);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(296, 61);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(257, 27);
            textBoxSearch.TabIndex = 6;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(627, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 68);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 8;
            label1.Text = "Search";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSignOut);
            Controls.Add(buttonSignIn);
            Controls.Add(dataGridView);
            Name = "MainForm";
            Text = "International Food AB";
           
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button buttonSignIn;
        private Button buttonSignOut;
        private Button buttonAdd;
        private Button buttonDelete;
        private TextBox textBoxSearch;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn Title;
        private Label label1;
    }
}