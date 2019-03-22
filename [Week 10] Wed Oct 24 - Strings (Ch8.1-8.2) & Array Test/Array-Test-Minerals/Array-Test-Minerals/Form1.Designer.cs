namespace Array_Test_Minerals
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
            this.readFileButton = new System.Windows.Forms.Button();
            this.mineralsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchMineralsButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(144, 12);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(94, 23);
            this.readFileButton.TabIndex = 0;
            this.readFileButton.Text = "Read File";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // mineralsListBox
            // 
            this.mineralsListBox.FormattingEnabled = true;
            this.mineralsListBox.Location = new System.Drawing.Point(12, 12);
            this.mineralsListBox.Name = "mineralsListBox";
            this.mineralsListBox.Size = new System.Drawing.Size(120, 108);
            this.mineralsListBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.searchMineralsButton);
            this.groupBox1.Location = new System.Drawing.Point(138, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(6, 20);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(94, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // searchMineralsButton
            // 
            this.searchMineralsButton.Location = new System.Drawing.Point(6, 50);
            this.searchMineralsButton.Name = "searchMineralsButton";
            this.searchMineralsButton.Size = new System.Drawing.Size(94, 23);
            this.searchMineralsButton.TabIndex = 2;
            this.searchMineralsButton.Text = "Search Minerals ";
            this.searchMineralsButton.UseVisualStyleBackColor = true;
            this.searchMineralsButton.Click += new System.EventHandler(this.searchMineralsButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Minerals";
            this.openFileDialog.Filter = "Text Files|*.txt";
            this.openFileDialog.Title = "Open Minerals Text File...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 127);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mineralsListBox);
            this.Controls.Add(this.readFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mineral Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.ListBox mineralsListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchMineralsButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

