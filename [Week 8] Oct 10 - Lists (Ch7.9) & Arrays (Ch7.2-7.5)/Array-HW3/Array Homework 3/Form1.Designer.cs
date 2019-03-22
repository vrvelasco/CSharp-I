namespace Array_Homework_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.readButton = new System.Windows.Forms.Button();
            this.arrayListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTraditionalTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.searchLINQButton = new System.Windows.Forms.Button();
            this.searchLINQTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.clearCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.readButton);
            this.groupBox1.Location = new System.Drawing.Point(124, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Part 1: Read File into Array";
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(7, 21);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(117, 21);
            this.readButton.TabIndex = 1;
            this.readButton.Text = "Read File Into Array";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // arrayListBox
            // 
            this.arrayListBox.FormattingEnabled = true;
            this.arrayListBox.Location = new System.Drawing.Point(7, 15);
            this.arrayListBox.Name = "arrayListBox";
            this.arrayListBox.Size = new System.Drawing.Size(90, 186);
            this.arrayListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.addTextBox);
            this.groupBox2.Location = new System.Drawing.Point(124, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Part 2: Enter Number into Array";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(119, 19);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Number";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(7, 21);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(106, 20);
            this.addTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Controls.Add(this.searchTraditionalTextBox);
            this.groupBox3.Location = new System.Drawing.Point(124, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 47);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Part 3: Regular Search for Number";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(119, 17);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTraditionalTextBox
            // 
            this.searchTraditionalTextBox.Location = new System.Drawing.Point(7, 19);
            this.searchTraditionalTextBox.Name = "searchTraditionalTextBox";
            this.searchTraditionalTextBox.Size = new System.Drawing.Size(106, 20);
            this.searchTraditionalTextBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.searchLINQButton);
            this.groupBox4.Controls.Add(this.searchLINQTextBox);
            this.groupBox4.Location = new System.Drawing.Point(124, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 47);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Part 4: LINQ Search for Number";
            // 
            // searchLINQButton
            // 
            this.searchLINQButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLINQButton.Location = new System.Drawing.Point(119, 17);
            this.searchLINQButton.Name = "searchLINQButton";
            this.searchLINQButton.Size = new System.Drawing.Size(75, 23);
            this.searchLINQButton.TabIndex = 2;
            this.searchLINQButton.Text = "LINQ Search";
            this.searchLINQButton.UseVisualStyleBackColor = true;
            this.searchLINQButton.Click += new System.EventHandler(this.searchLINQButton_Click);
            // 
            // searchLINQTextBox
            // 
            this.searchLINQTextBox.Location = new System.Drawing.Point(6, 19);
            this.searchLINQTextBox.Name = "searchLINQTextBox";
            this.searchLINQTextBox.Size = new System.Drawing.Size(107, 20);
            this.searchLINQTextBox.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Default";
            this.openFileDialog.Filter = "Text File|*.txt";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.arrayListBox);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(106, 211);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // clearCheckBox
            // 
            this.clearCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clearCheckBox.Checked = true;
            this.clearCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearCheckBox.Location = new System.Drawing.Point(281, 12);
            this.clearCheckBox.Name = "clearCheckBox";
            this.clearCheckBox.Size = new System.Drawing.Size(43, 50);
            this.clearCheckBox.TabIndex = 5;
            this.clearCheckBox.Text = "Clear List";
            this.clearCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 232);
            this.Controls.Add(this.clearCheckBox);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Array Homework 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.ListBox arrayListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox searchTraditionalTextBox;
        private System.Windows.Forms.TextBox searchLINQTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button searchLINQButton;
        private System.Windows.Forms.CheckBox clearCheckBox;
    }
}

