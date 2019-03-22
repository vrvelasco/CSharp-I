namespace Score_File
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
            this.readButton = new System.Windows.Forms.Button();
            this.averageLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.averageDescriptionLabel = new System.Windows.Forms.Label();
            this.totalDescriptionLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.countDescriptionLabel = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.randomGradeButton = new System.Windows.Forms.Button();
            this.sayingLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.resultFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(97, 202);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 45);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(12, 202);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 45);
            this.readButton.TabIndex = 18;
            this.readButton.Text = "Read Scores";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(97, 152);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(75, 25);
            this.averageLabel.TabIndex = 17;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(97, 106);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(75, 25);
            this.totalLabel.TabIndex = 16;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageDescriptionLabel
            // 
            this.averageDescriptionLabel.AutoSize = true;
            this.averageDescriptionLabel.Location = new System.Drawing.Point(12, 158);
            this.averageDescriptionLabel.Name = "averageDescriptionLabel";
            this.averageDescriptionLabel.Size = new System.Drawing.Size(47, 13);
            this.averageDescriptionLabel.TabIndex = 15;
            this.averageDescriptionLabel.Text = "Average";
            // 
            // totalDescriptionLabel
            // 
            this.totalDescriptionLabel.AutoSize = true;
            this.totalDescriptionLabel.Location = new System.Drawing.Point(12, 112);
            this.totalDescriptionLabel.Name = "totalDescriptionLabel";
            this.totalDescriptionLabel.Size = new System.Drawing.Size(34, 13);
            this.totalDescriptionLabel.TabIndex = 14;
            this.totalDescriptionLabel.Text = "Total:";
            // 
            // countLabel
            // 
            this.countLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countLabel.Location = new System.Drawing.Point(97, 60);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(75, 25);
            this.countLabel.TabIndex = 13;
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countDescriptionLabel
            // 
            this.countDescriptionLabel.AutoSize = true;
            this.countDescriptionLabel.Location = new System.Drawing.Point(12, 66);
            this.countDescriptionLabel.Name = "countDescriptionLabel";
            this.countDescriptionLabel.Size = new System.Drawing.Size(38, 13);
            this.countDescriptionLabel.TabIndex = 12;
            this.countDescriptionLabel.Text = "Count:";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(196, 60);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(160, 45);
            this.openFileButton.TabIndex = 20;
            this.openFileButton.Text = "Open File and Read Scores";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(196, 132);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(160, 45);
            this.saveFileButton.TabIndex = 21;
            this.saveFileButton.Text = "Save Results to New File";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // randomGradeButton
            // 
            this.randomGradeButton.Location = new System.Drawing.Point(197, 202);
            this.randomGradeButton.Name = "randomGradeButton";
            this.randomGradeButton.Size = new System.Drawing.Size(160, 45);
            this.randomGradeButton.TabIndex = 22;
            this.randomGradeButton.Text = "Append Random Grade to Results File";
            this.randomGradeButton.UseVisualStyleBackColor = true;
            this.randomGradeButton.Click += new System.EventHandler(this.randomGradeButton_Click);
            // 
            // sayingLabel
            // 
            this.sayingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sayingLabel.Location = new System.Drawing.Point(12, 12);
            this.sayingLabel.Name = "sayingLabel";
            this.sayingLabel.Size = new System.Drawing.Size(347, 25);
            this.sayingLabel.TabIndex = 23;
            this.sayingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Scores.txt";
            // 
            // resultFileDialog
            // 
            this.resultFileDialog.FileName = "Results.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 261);
            this.Controls.Add(this.sayingLabel);
            this.Controls.Add(this.randomGradeButton);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.averageDescriptionLabel);
            this.Controls.Add(this.totalDescriptionLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.countDescriptionLabel);
            this.Name = "Form1";
            this.Text = "Score File";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label averageDescriptionLabel;
        private System.Windows.Forms.Label totalDescriptionLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label countDescriptionLabel;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button randomGradeButton;
        private System.Windows.Forms.Label sayingLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog resultFileDialog;
    }
}

