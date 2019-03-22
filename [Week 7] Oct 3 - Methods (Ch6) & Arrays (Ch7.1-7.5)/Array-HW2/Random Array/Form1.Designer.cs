namespace Random_Array
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
            this.createButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.randomListBox = new System.Windows.Forms.ListBox();
            this.saveRandomFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.userArrayNumberTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arrayMessageBoxButton = new System.Windows.Forms.Button();
            this.userSelectedButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(6, 48);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(94, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create Array";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 78);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save Array";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // randomListBox
            // 
            this.randomListBox.FormattingEnabled = true;
            this.randomListBox.Location = new System.Drawing.Point(106, 19);
            this.randomListBox.Name = "randomListBox";
            this.randomListBox.Size = new System.Drawing.Size(75, 82);
            this.randomListBox.TabIndex = 2;
            // 
            // saveRandomFileDialog
            // 
            this.saveRandomFileDialog.FileName = "Array";
            this.saveRandomFileDialog.Filter = "Text File|*.txt";
            // 
            // userArrayNumberTextBox
            // 
            this.userArrayNumberTextBox.Location = new System.Drawing.Point(6, 20);
            this.userArrayNumberTextBox.Name = "userArrayNumberTextBox";
            this.userArrayNumberTextBox.Size = new System.Drawing.Size(94, 20);
            this.userArrayNumberTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userArrayNumberTextBox);
            this.groupBox1.Controls.Add(this.randomListBox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter a number greater than zero:";
            // 
            // arrayMessageBoxButton
            // 
            this.arrayMessageBoxButton.Location = new System.Drawing.Point(205, 22);
            this.arrayMessageBoxButton.Name = "arrayMessageBoxButton";
            this.arrayMessageBoxButton.Size = new System.Drawing.Size(175, 39);
            this.arrayMessageBoxButton.TabIndex = 5;
            this.arrayMessageBoxButton.Text = "Display Array in MessageBox";
            this.arrayMessageBoxButton.UseVisualStyleBackColor = true;
            this.arrayMessageBoxButton.Click += new System.EventHandler(this.arrayMessageBoxButton_Click);
            // 
            // userSelectedButton
            // 
            this.userSelectedButton.Enabled = false;
            this.userSelectedButton.Location = new System.Drawing.Point(205, 69);
            this.userSelectedButton.Name = "userSelectedButton";
            this.userSelectedButton.Size = new System.Drawing.Size(175, 46);
            this.userSelectedButton.TabIndex = 6;
            this.userSelectedButton.Text = "Display User-Selected Number in MessageBox";
            this.userSelectedButton.UseVisualStyleBackColor = true;
            this.userSelectedButton.Click += new System.EventHandler(this.userSelectedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 129);
            this.Controls.Add(this.userSelectedButton);
            this.Controls.Add(this.arrayMessageBoxButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Random Array";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox randomListBox;
        private System.Windows.Forms.SaveFileDialog saveRandomFileDialog;
        private System.Windows.Forms.TextBox userArrayNumberTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button arrayMessageBoxButton;
        private System.Windows.Forms.Button userSelectedButton;
    }
}

