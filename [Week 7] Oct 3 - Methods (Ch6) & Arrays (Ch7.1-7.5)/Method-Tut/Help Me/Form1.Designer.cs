namespace Help_Me
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
            this.helpMeButton = new System.Windows.Forms.Button();
            this.requestTextBox = new System.Windows.Forms.TextBox();
            this.helpMeWithButton = new System.Windows.Forms.Button();
            this.requestPromptLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.giveMeButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.spellButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helpMeButton
            // 
            this.helpMeButton.Location = new System.Drawing.Point(12, 12);
            this.helpMeButton.Name = "helpMeButton";
            this.helpMeButton.Size = new System.Drawing.Size(260, 23);
            this.helpMeButton.TabIndex = 1;
            this.helpMeButton.Text = "Help Me";
            this.helpMeButton.UseVisualStyleBackColor = true;
            this.helpMeButton.Click += new System.EventHandler(this.helpMeButton_Click);
            // 
            // requestTextBox
            // 
            this.requestTextBox.Location = new System.Drawing.Point(97, 51);
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.Size = new System.Drawing.Size(175, 20);
            this.requestTextBox.TabIndex = 7;
            // 
            // helpMeWithButton
            // 
            this.helpMeWithButton.Location = new System.Drawing.Point(12, 91);
            this.helpMeWithButton.Name = "helpMeWithButton";
            this.helpMeWithButton.Size = new System.Drawing.Size(75, 45);
            this.helpMeWithButton.TabIndex = 6;
            this.helpMeWithButton.Text = "Help Me With";
            this.helpMeWithButton.UseVisualStyleBackColor = true;
            this.helpMeWithButton.Click += new System.EventHandler(this.helpMeWithButton_Click);
            // 
            // requestPromptLabel
            // 
            this.requestPromptLabel.AutoSize = true;
            this.requestPromptLabel.Location = new System.Drawing.Point(27, 54);
            this.requestPromptLabel.Name = "requestPromptLabel";
            this.requestPromptLabel.Size = new System.Drawing.Size(50, 13);
            this.requestPromptLabel.TabIndex = 8;
            this.requestPromptLabel.Text = "Request:";
            // 
            // answerLabel
            // 
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerLabel.Location = new System.Drawing.Point(14, 156);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(260, 45);
            this.answerLabel.TabIndex = 10;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // giveMeButton
            // 
            this.giveMeButton.Location = new System.Drawing.Point(106, 91);
            this.giveMeButton.Name = "giveMeButton";
            this.giveMeButton.Size = new System.Drawing.Size(75, 45);
            this.giveMeButton.TabIndex = 9;
            this.giveMeButton.Text = "Give Me an Answer";
            this.giveMeButton.UseVisualStyleBackColor = true;
            this.giveMeButton.Click += new System.EventHandler(this.giveMeButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(197, 91);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 45);
            this.returnButton.TabIndex = 11;
            this.returnButton.Text = "Return My Answer";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // spellButton
            // 
            this.spellButton.Location = new System.Drawing.Point(14, 214);
            this.spellButton.Name = "spellButton";
            this.spellButton.Size = new System.Drawing.Size(260, 23);
            this.spellButton.TabIndex = 12;
            this.spellButton.Text = "Help Me Spell";
            this.spellButton.UseVisualStyleBackColor = true;
            this.spellButton.Click += new System.EventHandler(this.spellButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 246);
            this.Controls.Add(this.spellButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.giveMeButton);
            this.Controls.Add(this.requestPromptLabel);
            this.Controls.Add(this.requestTextBox);
            this.Controls.Add(this.helpMeWithButton);
            this.Controls.Add(this.helpMeButton);
            this.Name = "Form1";
            this.Text = "Help Me! Help Me!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button helpMeButton;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.Button helpMeWithButton;
        private System.Windows.Forms.Label requestPromptLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button giveMeButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button spellButton;
    }
}

