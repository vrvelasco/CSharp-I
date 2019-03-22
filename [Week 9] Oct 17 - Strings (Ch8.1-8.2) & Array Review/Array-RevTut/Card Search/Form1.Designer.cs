namespace Card_Search
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
            this.handListBox = new System.Windows.Forms.ListBox();
            this.foundListBox = new System.Windows.Forms.ListBox();
            this.handListLabel = new System.Windows.Forms.Label();
            this.foundListLabel = new System.Windows.Forms.Label();
            this.searchBoxLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.initButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // handListBox
            // 
            this.handListBox.FormattingEnabled = true;
            this.handListBox.Location = new System.Drawing.Point(12, 26);
            this.handListBox.Name = "handListBox";
            this.handListBox.Size = new System.Drawing.Size(120, 69);
            this.handListBox.TabIndex = 0;
            // 
            // foundListBox
            // 
            this.foundListBox.FormattingEnabled = true;
            this.foundListBox.Location = new System.Drawing.Point(152, 26);
            this.foundListBox.Name = "foundListBox";
            this.foundListBox.Size = new System.Drawing.Size(120, 69);
            this.foundListBox.TabIndex = 1;
            // 
            // handListLabel
            // 
            this.handListLabel.AutoSize = true;
            this.handListLabel.Location = new System.Drawing.Point(12, 10);
            this.handListLabel.Name = "handListLabel";
            this.handListLabel.Size = new System.Drawing.Size(74, 13);
            this.handListLabel.TabIndex = 2;
            this.handListLabel.Text = "Cards in Hand";
            // 
            // foundListLabel
            // 
            this.foundListLabel.AutoSize = true;
            this.foundListLabel.Location = new System.Drawing.Point(149, 10);
            this.foundListLabel.Name = "foundListLabel";
            this.foundListLabel.Size = new System.Drawing.Size(67, 13);
            this.foundListLabel.TabIndex = 3;
            this.foundListLabel.Text = "Cards Found";
            // 
            // searchBoxLabel
            // 
            this.searchBoxLabel.AutoSize = true;
            this.searchBoxLabel.Location = new System.Drawing.Point(11, 119);
            this.searchBoxLabel.Name = "searchBoxLabel";
            this.searchBoxLabel.Size = new System.Drawing.Size(78, 13);
            this.searchBoxLabel.TabIndex = 4;
            this.searchBoxLabel.Text = "Card to Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(91, 116);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(104, 156);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 39);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search for Card";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(196, 156);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 39);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save Found Cards";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // initButton
            // 
            this.initButton.Location = new System.Drawing.Point(10, 156);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(75, 39);
            this.initButton.TabIndex = 9;
            this.initButton.Text = "Initialize Hand";
            this.initButton.UseVisualStyleBackColor = true;
            this.initButton.Click += new System.EventHandler(this.initButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.initButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchBoxLabel);
            this.Controls.Add(this.foundListLabel);
            this.Controls.Add(this.handListLabel);
            this.Controls.Add(this.foundListBox);
            this.Controls.Add(this.handListBox);
            this.Name = "Form1";
            this.Text = "Card Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox handListBox;
        private System.Windows.Forms.ListBox foundListBox;
        private System.Windows.Forms.Label handListLabel;
        private System.Windows.Forms.Label foundListLabel;
        private System.Windows.Forms.Label searchBoxLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button initButton;
    }
}

