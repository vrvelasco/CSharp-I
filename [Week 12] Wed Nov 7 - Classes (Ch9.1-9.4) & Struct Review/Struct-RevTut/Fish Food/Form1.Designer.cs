namespace Fish_Food
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
            this.fishTextBox = new System.Windows.Forms.TextBox();
            this.habitatTextBox = new System.Windows.Forms.TextBox();
            this.foodTextBox = new System.Windows.Forms.TextBox();
            this.fishPromptLabel = new System.Windows.Forms.Label();
            this.HabitatPromptLabel = new System.Windows.Forms.Label();
            this.foodPromptLabel = new System.Windows.Forms.Label();
            this.enterFishButton = new System.Windows.Forms.Button();
            this.fishListBox = new System.Windows.Forms.ListBox();
            this.enterFishGroupBox = new System.Windows.Forms.GroupBox();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchFishButton = new System.Windows.Forms.Button();
            this.searchFishPromptLabel = new System.Windows.Forms.Label();
            this.searchFishTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.enterFishGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fishTextBox
            // 
            this.fishTextBox.Location = new System.Drawing.Point(59, 19);
            this.fishTextBox.Name = "fishTextBox";
            this.fishTextBox.Size = new System.Drawing.Size(100, 20);
            this.fishTextBox.TabIndex = 0;
            // 
            // habitatTextBox
            // 
            this.habitatTextBox.Location = new System.Drawing.Point(59, 51);
            this.habitatTextBox.Name = "habitatTextBox";
            this.habitatTextBox.Size = new System.Drawing.Size(100, 20);
            this.habitatTextBox.TabIndex = 1;
            // 
            // foodTextBox
            // 
            this.foodTextBox.Location = new System.Drawing.Point(59, 83);
            this.foodTextBox.Name = "foodTextBox";
            this.foodTextBox.Size = new System.Drawing.Size(100, 20);
            this.foodTextBox.TabIndex = 2;
            // 
            // fishPromptLabel
            // 
            this.fishPromptLabel.AutoSize = true;
            this.fishPromptLabel.Location = new System.Drawing.Point(9, 22);
            this.fishPromptLabel.Name = "fishPromptLabel";
            this.fishPromptLabel.Size = new System.Drawing.Size(29, 13);
            this.fishPromptLabel.TabIndex = 3;
            this.fishPromptLabel.Text = "Fish:";
            // 
            // HabitatPromptLabel
            // 
            this.HabitatPromptLabel.AutoSize = true;
            this.HabitatPromptLabel.Location = new System.Drawing.Point(9, 54);
            this.HabitatPromptLabel.Name = "HabitatPromptLabel";
            this.HabitatPromptLabel.Size = new System.Drawing.Size(44, 13);
            this.HabitatPromptLabel.TabIndex = 4;
            this.HabitatPromptLabel.Text = "Habitat:";
            // 
            // foodPromptLabel
            // 
            this.foodPromptLabel.AutoSize = true;
            this.foodPromptLabel.Location = new System.Drawing.Point(9, 86);
            this.foodPromptLabel.Name = "foodPromptLabel";
            this.foodPromptLabel.Size = new System.Drawing.Size(34, 13);
            this.foodPromptLabel.TabIndex = 5;
            this.foodPromptLabel.Text = "Food:";
            // 
            // enterFishButton
            // 
            this.enterFishButton.Location = new System.Drawing.Point(12, 154);
            this.enterFishButton.Name = "enterFishButton";
            this.enterFishButton.Size = new System.Drawing.Size(504, 23);
            this.enterFishButton.TabIndex = 6;
            this.enterFishButton.Text = "Enter Fish";
            this.enterFishButton.UseVisualStyleBackColor = true;
            this.enterFishButton.Click += new System.EventHandler(this.enterFishButton_Click);
            // 
            // fishListBox
            // 
            this.fishListBox.FormattingEnabled = true;
            this.fishListBox.Location = new System.Drawing.Point(171, 19);
            this.fishListBox.Name = "fishListBox";
            this.fishListBox.Size = new System.Drawing.Size(345, 121);
            this.fishListBox.TabIndex = 7;
            // 
            // enterFishGroupBox
            // 
            this.enterFishGroupBox.Controls.Add(this.label1);
            this.enterFishGroupBox.Controls.Add(this.sizeTextBox);
            this.enterFishGroupBox.Controls.Add(this.fishTextBox);
            this.enterFishGroupBox.Controls.Add(this.fishListBox);
            this.enterFishGroupBox.Controls.Add(this.habitatTextBox);
            this.enterFishGroupBox.Controls.Add(this.enterFishButton);
            this.enterFishGroupBox.Controls.Add(this.foodTextBox);
            this.enterFishGroupBox.Controls.Add(this.foodPromptLabel);
            this.enterFishGroupBox.Controls.Add(this.fishPromptLabel);
            this.enterFishGroupBox.Controls.Add(this.HabitatPromptLabel);
            this.enterFishGroupBox.Location = new System.Drawing.Point(12, 12);
            this.enterFishGroupBox.Name = "enterFishGroupBox";
            this.enterFishGroupBox.Size = new System.Drawing.Size(527, 188);
            this.enterFishGroupBox.TabIndex = 8;
            this.enterFishGroupBox.TabStop = false;
            this.enterFishGroupBox.Text = "Enter Fish";
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchListBox);
            this.searchGroupBox.Controls.Add(this.searchFishButton);
            this.searchGroupBox.Controls.Add(this.searchFishPromptLabel);
            this.searchGroupBox.Controls.Add(this.searchFishTextBox);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 206);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(527, 88);
            this.searchGroupBox.TabIndex = 9;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search for Fish";
            // 
            // searchFishButton
            // 
            this.searchFishButton.Location = new System.Drawing.Point(12, 51);
            this.searchFishButton.Name = "searchFishButton";
            this.searchFishButton.Size = new System.Drawing.Size(147, 23);
            this.searchFishButton.TabIndex = 8;
            this.searchFishButton.Text = "Search Fish";
            this.searchFishButton.UseVisualStyleBackColor = true;
            this.searchFishButton.Click += new System.EventHandler(this.searchFishButton_Click);
            // 
            // searchFishPromptLabel
            // 
            this.searchFishPromptLabel.AutoSize = true;
            this.searchFishPromptLabel.Location = new System.Drawing.Point(9, 22);
            this.searchFishPromptLabel.Name = "searchFishPromptLabel";
            this.searchFishPromptLabel.Size = new System.Drawing.Size(29, 13);
            this.searchFishPromptLabel.TabIndex = 8;
            this.searchFishPromptLabel.Text = "Fish:";
            // 
            // searchFishTextBox
            // 
            this.searchFishTextBox.Location = new System.Drawing.Point(59, 19);
            this.searchFishTextBox.Name = "searchFishTextBox";
            this.searchFishTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchFishTextBox.TabIndex = 0;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(59, 112);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Size:";
            // 
            // searchListBox
            // 
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.Location = new System.Drawing.Point(165, 19);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(351, 56);
            this.searchListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 436);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.enterFishGroupBox);
            this.Name = "Form1";
            this.Text = "Fish Food";
            this.enterFishGroupBox.ResumeLayout(false);
            this.enterFishGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox fishTextBox;
        private System.Windows.Forms.TextBox habitatTextBox;
        private System.Windows.Forms.TextBox foodTextBox;
        private System.Windows.Forms.Label fishPromptLabel;
        private System.Windows.Forms.Label HabitatPromptLabel;
        private System.Windows.Forms.Label foodPromptLabel;
        private System.Windows.Forms.Button enterFishButton;
        private System.Windows.Forms.ListBox fishListBox;
        private System.Windows.Forms.GroupBox enterFishGroupBox;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button searchFishButton;
        private System.Windows.Forms.Label searchFishPromptLabel;
        private System.Windows.Forms.TextBox searchFishTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.ListBox searchListBox;
    }
}

