namespace WindowsFormsApp1
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
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.ageRangeLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.whileButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.forButton = new System.Windows.Forms.Button();
            this.whileListBox = new System.Windows.Forms.ListBox();
            this.forListBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(6, 13);
            this.ageTextBox.MaxLength = 2;
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(35, 20);
            this.ageTextBox.TabIndex = 0;
            this.ageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ageRangeLabel
            // 
            this.ageRangeLabel.Location = new System.Drawing.Point(47, 16);
            this.ageRangeLabel.Name = "ageRangeLabel";
            this.ageRangeLabel.Size = new System.Drawing.Size(94, 14);
            this.ageRangeLabel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.ageRangeLabel);
            this.groupBox1.Controls.Add(this.ageTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 39);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please enter your age (18-99):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.whileListBox);
            this.groupBox2.Controls.Add(this.whileButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 151);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "While Loop";
            // 
            // whileButton
            // 
            this.whileButton.Location = new System.Drawing.Point(6, 120);
            this.whileButton.Name = "whileButton";
            this.whileButton.Size = new System.Drawing.Size(196, 23);
            this.whileButton.TabIndex = 4;
            this.whileButton.Text = "Calculate with While Loop";
            this.whileButton.UseVisualStyleBackColor = true;
            this.whileButton.Click += new System.EventHandler(this.whileButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.forListBox);
            this.groupBox3.Controls.Add(this.forButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 151);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "For Loop";
            // 
            // forButton
            // 
            this.forButton.Location = new System.Drawing.Point(6, 120);
            this.forButton.Name = "forButton";
            this.forButton.Size = new System.Drawing.Size(196, 23);
            this.forButton.TabIndex = 4;
            this.forButton.Text = "Calculate with For Loop";
            this.forButton.UseVisualStyleBackColor = true;
            this.forButton.Click += new System.EventHandler(this.forButton_Click);
            // 
            // whileListBox
            // 
            this.whileListBox.FormattingEnabled = true;
            this.whileListBox.Location = new System.Drawing.Point(6, 19);
            this.whileListBox.Name = "whileListBox";
            this.whileListBox.Size = new System.Drawing.Size(196, 95);
            this.whileListBox.TabIndex = 5;
            // 
            // forListBox
            // 
            this.forListBox.FormattingEnabled = true;
            this.forListBox.Location = new System.Drawing.Point(6, 19);
            this.forListBox.Name = "forListBox";
            this.forListBox.Size = new System.Drawing.Size(196, 95);
            this.forListBox.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(147, 13);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(55, 20);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(18, 371);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(196, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 400);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ages [Loop Test]";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label ageRangeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button whileButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button forButton;
        private System.Windows.Forms.ListBox whileListBox;
        private System.Windows.Forms.ListBox forListBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

