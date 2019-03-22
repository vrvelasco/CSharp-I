namespace Bug_List
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
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.removeTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.searchLINQButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(99, 25);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(100, 20);
            this.addTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 45);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Bug";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.Location = new System.Drawing.Point(99, 69);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(100, 108);
            this.displayListBox.TabIndex = 5;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(12, 69);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 45);
            this.displayButton.TabIndex = 4;
            this.displayButton.Text = "Display Bugs";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(12, 132);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 45);
            this.countButton.TabIndex = 6;
            this.countButton.Text = "Count Bugs";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(99, 202);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 8;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 189);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 45);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search for Bug";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // removeTextBox
            // 
            this.removeTextBox.Location = new System.Drawing.Point(99, 259);
            this.removeTextBox.Name = "removeTextBox";
            this.removeTextBox.Size = new System.Drawing.Size(100, 20);
            this.removeTextBox.TabIndex = 10;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(12, 246);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 45);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove Bug";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 303);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 45);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save Bugs";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // searchLINQButton
            // 
            this.searchLINQButton.Location = new System.Drawing.Point(12, 354);
            this.searchLINQButton.Name = "searchLINQButton";
            this.searchLINQButton.Size = new System.Drawing.Size(187, 45);
            this.searchLINQButton.TabIndex = 12;
            this.searchLINQButton.Text = "Search Using LINQ";
            this.searchLINQButton.UseVisualStyleBackColor = true;
            this.searchLINQButton.Click += new System.EventHandler(this.searchLINQButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(93, 303);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(106, 45);
            this.insertButton.TabIndex = 13;
            this.insertButton.Text = "Insert bug";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 409);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.searchLINQButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.removeTextBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Bug List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox removeTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button searchLINQButton;
        private System.Windows.Forms.Button insertButton;
    }
}

