namespace SearchDojo
{
    partial class Form1
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
            this.MatchesListBox = new System.Windows.Forms.ListBox();
            this.PatternInputTextBox = new System.Windows.Forms.TextBox();
            this.PatternLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MatchesListBox
            // 
            this.MatchesListBox.FormattingEnabled = true;
            this.MatchesListBox.Location = new System.Drawing.Point(291, 41);
            this.MatchesListBox.Name = "MatchesListBox";
            this.MatchesListBox.Size = new System.Drawing.Size(120, 160);
            this.MatchesListBox.TabIndex = 1;
            // 
            // PatternInputTextBox
            // 
            this.PatternInputTextBox.Location = new System.Drawing.Point(103, 220);
            this.PatternInputTextBox.Name = "PatternInputTextBox";
            this.PatternInputTextBox.Size = new System.Drawing.Size(151, 20);
            this.PatternInputTextBox.TabIndex = 2;
            // 
            // PatternLabel
            // 
            this.PatternLabel.AutoSize = true;
            this.PatternLabel.Location = new System.Drawing.Point(35, 223);
            this.PatternLabel.Name = "PatternLabel";
            this.PatternLabel.Size = new System.Drawing.Size(41, 13);
            this.PatternLabel.TabIndex = 3;
            this.PatternLabel.Text = "Pattern";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(291, 218);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(38, 41);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(230, 160);
            this.InputTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 267);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PatternLabel);
            this.Controls.Add(this.PatternInputTextBox);
            this.Controls.Add(this.MatchesListBox);
            this.Name = "Form1";
            this.Text = "Matcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox MatchesListBox;
        private System.Windows.Forms.TextBox PatternInputTextBox;
        private System.Windows.Forms.Label PatternLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox InputTextBox;
    }
}

