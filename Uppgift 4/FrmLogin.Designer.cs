namespace Uppgift_4
{
    partial class FrmLogin
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
            nameBox = new TextBox();
            passwordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Loginbtn = new Button();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.Location = new Point(141, 56);
            nameBox.Margin = new Padding(4);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(293, 31);
            nameBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(141, 147);
            passwordBox.Margin = new Padding(4);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(293, 31);
            passwordBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // Loginbtn
            // 
            Loginbtn.Location = new Point(231, 227);
            Loginbtn.Margin = new Padding(4);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(118, 36);
            Loginbtn.TabIndex = 6;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = true;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Startsida;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(567, 320);
            Controls.Add(Loginbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordBox);
            Controls.Add(nameBox);
            Margin = new Padding(4);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox nameBox;
        private TextBox passwordBox;
        private Label label1;
        private Label label2;
        private Button Loginbtn;
    }
}