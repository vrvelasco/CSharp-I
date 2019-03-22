namespace Professor_Search
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
            this.enterButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.professorTextBox = new System.Windows.Forms.TextBox();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.schoolListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.searchLINQButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(6, 70);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(206, 23);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Enter Professor";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(281, 21);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(99, 69);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show Professors";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 47);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(65, 43);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search Professors";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // professorTextBox
            // 
            this.professorTextBox.Location = new System.Drawing.Point(112, 18);
            this.professorTextBox.Name = "professorTextBox";
            this.professorTextBox.Size = new System.Drawing.Size(100, 20);
            this.professorTextBox.TabIndex = 1;
            // 
            // courseTextBox
            // 
            this.courseTextBox.Location = new System.Drawing.Point(112, 44);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name of Professor: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Course Name:";
            // 
            // schoolListBox
            // 
            this.schoolListBox.FormattingEnabled = true;
            this.schoolListBox.Location = new System.Drawing.Point(6, 21);
            this.schoolListBox.Name = "schoolListBox";
            this.schoolListBox.Size = new System.Drawing.Size(269, 69);
            this.schoolListBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.enterButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.professorTextBox);
            this.groupBox1.Controls.Add(this.courseTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Professor: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.schoolListBox);
            this.groupBox2.Controls.Add(this.showButton);
            this.groupBox2.Location = new System.Drawing.Point(241, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show Professor: ";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(6, 21);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(112, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.searchLINQButton);
            this.groupBox3.Controls.Add(this.searchTextBox);
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Location = new System.Drawing.Point(634, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 99);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Professors: ";
            // 
            // searchLINQButton
            // 
            this.searchLINQButton.Location = new System.Drawing.Point(77, 47);
            this.searchLINQButton.Name = "searchLINQButton";
            this.searchLINQButton.Size = new System.Drawing.Size(41, 43);
            this.searchLINQButton.TabIndex = 4;
            this.searchLINQButton.Text = "LINQ";
            this.searchLINQButton.UseVisualStyleBackColor = true;
            this.searchLINQButton.Click += new System.EventHandler(this.searchLINQButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 118);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Professor Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox professorTextBox;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox schoolListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button searchLINQButton;
    }
}

