namespace Number_Sum
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
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.whileButton = new System.Windows.Forms.Button();
            this.sumDescriptionLabel = new System.Windows.Forms.Label();
            this.numberDescriptionLabel = new System.Windows.Forms.Label();
            this.sumListBox = new System.Windows.Forms.ListBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.endPromptLabel = new System.Windows.Forms.Label();
            this.forButton = new System.Windows.Forms.Button();
            this.doWhileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(175, 224);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(26, 224);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // whileButton
            // 
            this.whileButton.Location = new System.Drawing.Point(26, 80);
            this.whileButton.Name = "whileButton";
            this.whileButton.Size = new System.Drawing.Size(75, 23);
            this.whileButton.TabIndex = 15;
            this.whileButton.Text = "While";
            this.whileButton.UseVisualStyleBackColor = true;
            this.whileButton.Click += new System.EventHandler(this.whileButton_Click);
            // 
            // sumDescriptionLabel
            // 
            this.sumDescriptionLabel.AutoSize = true;
            this.sumDescriptionLabel.Location = new System.Drawing.Point(237, 13);
            this.sumDescriptionLabel.Name = "sumDescriptionLabel";
            this.sumDescriptionLabel.Size = new System.Drawing.Size(28, 13);
            this.sumDescriptionLabel.TabIndex = 14;
            this.sumDescriptionLabel.Text = "Sum";
            // 
            // numberDescriptionLabel
            // 
            this.numberDescriptionLabel.AutoSize = true;
            this.numberDescriptionLabel.Location = new System.Drawing.Point(161, 13);
            this.numberDescriptionLabel.Name = "numberDescriptionLabel";
            this.numberDescriptionLabel.Size = new System.Drawing.Size(44, 13);
            this.numberDescriptionLabel.TabIndex = 13;
            this.numberDescriptionLabel.Text = "Number";
            // 
            // sumListBox
            // 
            this.sumListBox.FormattingEnabled = true;
            this.sumListBox.Location = new System.Drawing.Point(152, 39);
            this.sumListBox.Name = "sumListBox";
            this.sumListBox.Size = new System.Drawing.Size(120, 173);
            this.sumListBox.TabIndex = 12;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(15, 39);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 11;
            // 
            // endPromptLabel
            // 
            this.endPromptLabel.AutoSize = true;
            this.endPromptLabel.Location = new System.Drawing.Point(12, 13);
            this.endPromptLabel.Name = "endPromptLabel";
            this.endPromptLabel.Size = new System.Drawing.Size(105, 13);
            this.endPromptLabel.TabIndex = 10;
            this.endPromptLabel.Text = "Enter ending number";
            // 
            // forButton
            // 
            this.forButton.Location = new System.Drawing.Point(26, 124);
            this.forButton.Name = "forButton";
            this.forButton.Size = new System.Drawing.Size(75, 23);
            this.forButton.TabIndex = 18;
            this.forButton.Text = "For";
            this.forButton.UseVisualStyleBackColor = true;
            this.forButton.Click += new System.EventHandler(this.forButton_Click);
            // 
            // doWhileButton
            // 
            this.doWhileButton.Location = new System.Drawing.Point(26, 172);
            this.doWhileButton.Name = "doWhileButton";
            this.doWhileButton.Size = new System.Drawing.Size(75, 23);
            this.doWhileButton.TabIndex = 19;
            this.doWhileButton.Text = "Do While";
            this.doWhileButton.UseVisualStyleBackColor = true;
            this.doWhileButton.Click += new System.EventHandler(this.doWhileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.doWhileButton);
            this.Controls.Add(this.forButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.whileButton);
            this.Controls.Add(this.sumDescriptionLabel);
            this.Controls.Add(this.numberDescriptionLabel);
            this.Controls.Add(this.sumListBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.endPromptLabel);
            this.Name = "Form1";
            this.Text = "Number Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button whileButton;
        private System.Windows.Forms.Label sumDescriptionLabel;
        private System.Windows.Forms.Label numberDescriptionLabel;
        private System.Windows.Forms.ListBox sumListBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label endPromptLabel;
        private System.Windows.Forms.Button forButton;
        private System.Windows.Forms.Button doWhileButton;
    }
}

