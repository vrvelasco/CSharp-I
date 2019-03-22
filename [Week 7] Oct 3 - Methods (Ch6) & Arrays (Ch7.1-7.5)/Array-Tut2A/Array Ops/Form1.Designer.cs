namespace Array_Ops
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
            this.processNumbersButton = new System.Windows.Forms.Button();
            this.numbersListBox = new System.Windows.Forms.ListBox();
            this.searchWordButton = new System.Windows.Forms.Button();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // processNumbersButton
            // 
            this.processNumbersButton.Location = new System.Drawing.Point(12, 12);
            this.processNumbersButton.Name = "processNumbersButton";
            this.processNumbersButton.Size = new System.Drawing.Size(75, 45);
            this.processNumbersButton.TabIndex = 0;
            this.processNumbersButton.Text = "Process Numbers";
            this.processNumbersButton.UseVisualStyleBackColor = true;
            this.processNumbersButton.Click += new System.EventHandler(this.processNumbersButton_Click);
            // 
            // numbersListBox
            // 
            this.numbersListBox.FormattingEnabled = true;
            this.numbersListBox.Location = new System.Drawing.Point(99, 12);
            this.numbersListBox.Name = "numbersListBox";
            this.numbersListBox.Size = new System.Drawing.Size(120, 173);
            this.numbersListBox.TabIndex = 1;
            // 
            // searchWordButton
            // 
            this.searchWordButton.Location = new System.Drawing.Point(12, 197);
            this.searchWordButton.Name = "searchWordButton";
            this.searchWordButton.Size = new System.Drawing.Size(75, 45);
            this.searchWordButton.TabIndex = 2;
            this.searchWordButton.Text = "Search for Word";
            this.searchWordButton.UseVisualStyleBackColor = true;
            this.searchWordButton.Click += new System.EventHandler(this.searchWordButton_Click);
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(108, 210);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(100, 20);
            this.wordTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 254);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.searchWordButton);
            this.Controls.Add(this.numbersListBox);
            this.Controls.Add(this.processNumbersButton);
            this.Name = "Form1";
            this.Text = "Array Ops";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button processNumbersButton;
        private System.Windows.Forms.ListBox numbersListBox;
        private System.Windows.Forms.Button searchWordButton;
        private System.Windows.Forms.TextBox wordTextBox;
    }
}

