namespace List_Homework
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
            this.intButton = new System.Windows.Forms.Button();
            this.intTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.displayListButton = new System.Windows.Forms.Button();
            this.intListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.removeValueButton = new System.Windows.Forms.Button();
            this.removeValueTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.positionButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.sumLabel = new System.Windows.Forms.Label();
            this.sumButton = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.readFileButton = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.searchLINQButton = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.saveLINQResultsButton = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.intButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Part 1: Enter Integers";
            // 
            // intButton
            // 
            this.intButton.Location = new System.Drawing.Point(6, 19);
            this.intButton.Name = "intButton";
            this.intButton.Size = new System.Drawing.Size(152, 23);
            this.intButton.TabIndex = 1;
            this.intButton.Text = "Add Integer";
            this.intButton.UseVisualStyleBackColor = true;
            this.intButton.Click += new System.EventHandler(this.intButton_Click);
            // 
            // intTextBox
            // 
            this.intTextBox.Location = new System.Drawing.Point(6, 19);
            this.intTextBox.Name = "intTextBox";
            this.intTextBox.Size = new System.Drawing.Size(107, 20);
            this.intTextBox.TabIndex = 0;
            this.intTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.displayListButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 49);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Part 2: Display List of Integers";
            // 
            // displayListButton
            // 
            this.displayListButton.Location = new System.Drawing.Point(6, 19);
            this.displayListButton.Name = "displayListButton";
            this.displayListButton.Size = new System.Drawing.Size(152, 23);
            this.displayListButton.TabIndex = 0;
            this.displayListButton.Text = "Display List Of Integers";
            this.displayListButton.UseVisualStyleBackColor = true;
            this.displayListButton.Click += new System.EventHandler(this.displayListButton_Click);
            // 
            // intListBox
            // 
            this.intListBox.FormattingEnabled = true;
            this.intListBox.Location = new System.Drawing.Point(6, 18);
            this.intListBox.Name = "intListBox";
            this.intListBox.Size = new System.Drawing.Size(159, 134);
            this.intListBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.removeValueButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 63);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Part 3: Remove Integer";
            // 
            // removeValueButton
            // 
            this.removeValueButton.Location = new System.Drawing.Point(6, 19);
            this.removeValueButton.Name = "removeValueButton";
            this.removeValueButton.Size = new System.Drawing.Size(152, 37);
            this.removeValueButton.TabIndex = 0;
            this.removeValueButton.Text = "Remove An Integer\r\n By Its Value";
            this.removeValueButton.UseVisualStyleBackColor = true;
            this.removeValueButton.Click += new System.EventHandler(this.removeValueButton_Click);
            // 
            // removeValueTextBox
            // 
            this.removeValueTextBox.Location = new System.Drawing.Point(6, 19);
            this.removeValueTextBox.Name = "removeValueTextBox";
            this.removeValueTextBox.Size = new System.Drawing.Size(107, 20);
            this.removeValueTextBox.TabIndex = 1;
            this.removeValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.positionTextBox);
            this.groupBox4.Controls.Add(this.positionButton);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(182, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 49);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Part 4: Insert Integer";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(6, 16);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(43, 20);
            this.positionTextBox.TabIndex = 1;
            this.positionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // positionButton
            // 
            this.positionButton.Location = new System.Drawing.Point(55, 14);
            this.positionButton.Name = "positionButton";
            this.positionButton.Size = new System.Drawing.Size(103, 23);
            this.positionButton.TabIndex = 2;
            this.positionButton.Text = "Insert Into Index";
            this.positionButton.UseVisualStyleBackColor = true;
            this.positionButton.Click += new System.EventHandler(this.positionButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.searchButton);
            this.groupBox5.Location = new System.Drawing.Point(182, 232);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(164, 49);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Part 5: Search for Integer";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(152, 22);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search For An Integer";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.DimGray;
            this.searchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(6, 14);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(188, 105);
            this.searchLabel.TabIndex = 25;
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(6, 19);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(107, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.sumLabel);
            this.groupBox6.Controls.Add(this.sumButton);
            this.groupBox6.Location = new System.Drawing.Point(182, 287);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(164, 63);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Part 6: Sum of Integers";
            // 
            // sumLabel
            // 
            this.sumLabel.BackColor = System.Drawing.Color.DimGray;
            this.sumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sumLabel.ForeColor = System.Drawing.Color.White;
            this.sumLabel.Location = new System.Drawing.Point(6, 19);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(77, 37);
            this.sumLabel.TabIndex = 1;
            this.sumLabel.Text = "Sum:";
            this.sumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumButton
            // 
            this.sumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumButton.Location = new System.Drawing.Point(89, 19);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(69, 37);
            this.sumButton.TabIndex = 0;
            this.sumButton.Text = "Sum Of \r\nIntegers";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.readFileButton);
            this.groupBox7.Location = new System.Drawing.Point(352, 177);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(164, 49);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Part 7: Read Integer File";
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(6, 18);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(152, 23);
            this.readFileButton.TabIndex = 0;
            this.readFileButton.Text = "Open Integer File...";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.searchLINQButton);
            this.groupBox8.Location = new System.Drawing.Point(352, 232);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(164, 49);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Part 8: LINQ Search";
            // 
            // searchLINQButton
            // 
            this.searchLINQButton.Location = new System.Drawing.Point(6, 19);
            this.searchLINQButton.Name = "searchLINQButton";
            this.searchLINQButton.Size = new System.Drawing.Size(152, 23);
            this.searchLINQButton.TabIndex = 2;
            this.searchLINQButton.Text = "Perform A LINQ Search";
            this.searchLINQButton.UseVisualStyleBackColor = true;
            this.searchLINQButton.Click += new System.EventHandler(this.searchLINQButton_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.saveLINQResultsButton);
            this.groupBox9.Location = new System.Drawing.Point(352, 287);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(164, 63);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Part 9: Save LINQ Results";
            // 
            // saveLINQResultsButton
            // 
            this.saveLINQResultsButton.Location = new System.Drawing.Point(6, 19);
            this.saveLINQResultsButton.Name = "saveLINQResultsButton";
            this.saveLINQResultsButton.Size = new System.Drawing.Size(152, 37);
            this.saveLINQResultsButton.TabIndex = 0;
            this.saveLINQResultsButton.Text = "Save The LINQ \r\nSearch Results To A File";
            this.saveLINQResultsButton.UseVisualStyleBackColor = true;
            this.saveLINQResultsButton.Click += new System.EventHandler(this.saveLINQResultsButton_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.intTextBox);
            this.groupBox10.Location = new System.Drawing.Point(12, 12);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(121, 49);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Add Text Box";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.searchTextBox);
            this.groupBox11.Location = new System.Drawing.Point(12, 122);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(121, 49);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Search Text Box";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.removeValueTextBox);
            this.groupBox12.Location = new System.Drawing.Point(12, 67);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(121, 49);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Remove Text Box";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.intListBox);
            this.groupBox13.Location = new System.Drawing.Point(139, 12);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(171, 159);
            this.groupBox13.TabIndex = 99;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Display List";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.exitButton);
            this.groupBox14.Controls.Add(this.clearButton);
            this.groupBox14.Controls.Add(this.searchLabel);
            this.groupBox14.Location = new System.Drawing.Point(316, 12);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(200, 159);
            this.groupBox14.TabIndex = 13;
            this.groupBox14.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(116, 126);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(78, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(6, 126);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 23);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Clear Everything";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "List";
            this.openFileDialog.Filter = "Text Files|*.txt";
            this.openFileDialog.Title = "Choose a file to read...";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "Result";
            this.saveFileDialog.Filter = "Text File|*.txt";
            this.saveFileDialog.OverwritePrompt = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 361);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "List Homework";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button intButton;
        private System.Windows.Forms.TextBox intTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox intListBox;
        private System.Windows.Forms.Button displayListButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox removeValueTextBox;
        private System.Windows.Forms.Button removeValueButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button positionButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button searchLINQButton;
        private System.Windows.Forms.Button saveLINQResultsButton;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

