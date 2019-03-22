namespace Final_Exam___Caves
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
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.averageLabel = new System.Windows.Forms.Label();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.searchLINQGroupBox = new System.Windows.Forms.GroupBox();
            this.searchLINQTextBox = new System.Windows.Forms.TextBox();
            this.searchLINQButton = new System.Windows.Forms.Button();
            this.searchGroupBox.SuspendLayout();
            this.searchLINQGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.Items.AddRange(new object[] {
            "To Begin: Click the \"Load File...\" button below."});
            this.displayListBox.Location = new System.Drawing.Point(12, 12);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(497, 95);
            this.displayListBox.TabIndex = 0;
            // 
            // averageLabel
            // 
            this.averageLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageLabel.Location = new System.Drawing.Point(12, 106);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(425, 21);
            this.averageLabel.TabIndex = 1;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Enabled = false;
            this.searchGroupBox.Location = new System.Drawing.Point(516, 12);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(193, 46);
            this.searchGroupBox.TabIndex = 1;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search By Name:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(6, 19);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(112, 17);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Find!";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(435, 105);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load File...";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // searchLINQGroupBox
            // 
            this.searchLINQGroupBox.Controls.Add(this.searchLINQTextBox);
            this.searchLINQGroupBox.Controls.Add(this.searchLINQButton);
            this.searchLINQGroupBox.Enabled = false;
            this.searchLINQGroupBox.Location = new System.Drawing.Point(516, 81);
            this.searchLINQGroupBox.Name = "searchLINQGroupBox";
            this.searchLINQGroupBox.Size = new System.Drawing.Size(193, 46);
            this.searchLINQGroupBox.TabIndex = 2;
            this.searchLINQGroupBox.TabStop = false;
            this.searchLINQGroupBox.Text = "LINQ Search By Name:";
            // 
            // searchLINQTextBox
            // 
            this.searchLINQTextBox.Location = new System.Drawing.Point(6, 19);
            this.searchLINQTextBox.Name = "searchLINQTextBox";
            this.searchLINQTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchLINQTextBox.TabIndex = 0;
            // 
            // searchLINQButton
            // 
            this.searchLINQButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLINQButton.Location = new System.Drawing.Point(112, 17);
            this.searchLINQButton.Name = "searchLINQButton";
            this.searchLINQButton.Size = new System.Drawing.Size(75, 23);
            this.searchLINQButton.TabIndex = 1;
            this.searchLINQButton.Text = "Find!";
            this.searchLINQButton.UseVisualStyleBackColor = true;
            this.searchLINQButton.Click += new System.EventHandler(this.searchLINQButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 139);
            this.Controls.Add(this.searchLINQGroupBox);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.searchGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Final Exam: Caves";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.searchLINQGroupBox.ResumeLayout(false);
            this.searchLINQGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.GroupBox searchLINQGroupBox;
        private System.Windows.Forms.TextBox searchLINQTextBox;
        private System.Windows.Forms.Button searchLINQButton;
    }
}

