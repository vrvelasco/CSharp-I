namespace Decisions_HW
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
            this.decideButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.highestGradeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webDevelopmentRadioButton = new System.Windows.Forms.RadioButton();
            this.databaseRadioButton = new System.Windows.Forms.RadioButton();
            this.programmingRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.workStudyCheckBox = new System.Windows.Forms.CheckBox();
            this.loansCheckBox = new System.Windows.Forms.CheckBox();
            this.grantsCheckBox = new System.Windows.Forms.CheckBox();
            this.reasonsListBox = new System.Windows.Forms.ListBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // decideButton
            // 
            this.decideButton.Location = new System.Drawing.Point(252, 12);
            this.decideButton.Name = "decideButton";
            this.decideButton.Size = new System.Drawing.Size(65, 23);
            this.decideButton.TabIndex = 0;
            this.decideButton.Text = "Decide";
            this.decideButton.UseVisualStyleBackColor = true;
            this.decideButton.Click += new System.EventHandler(this.decideButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Highest grade completed:";
            // 
            // highestGradeTextBox
            // 
            this.highestGradeTextBox.Location = new System.Drawing.Point(146, 12);
            this.highestGradeTextBox.Name = "highestGradeTextBox";
            this.highestGradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.highestGradeTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.webDevelopmentRadioButton);
            this.groupBox1.Controls.Add(this.databaseRadioButton);
            this.groupBox1.Controls.Add(this.programmingRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Degree Program:";
            // 
            // webDevelopmentRadioButton
            // 
            this.webDevelopmentRadioButton.AutoSize = true;
            this.webDevelopmentRadioButton.Location = new System.Drawing.Point(6, 65);
            this.webDevelopmentRadioButton.Name = "webDevelopmentRadioButton";
            this.webDevelopmentRadioButton.Size = new System.Drawing.Size(114, 17);
            this.webDevelopmentRadioButton.TabIndex = 2;
            this.webDevelopmentRadioButton.Text = "Web Development";
            this.webDevelopmentRadioButton.UseVisualStyleBackColor = true;
            // 
            // databaseRadioButton
            // 
            this.databaseRadioButton.AutoSize = true;
            this.databaseRadioButton.Location = new System.Drawing.Point(6, 42);
            this.databaseRadioButton.Name = "databaseRadioButton";
            this.databaseRadioButton.Size = new System.Drawing.Size(71, 17);
            this.databaseRadioButton.TabIndex = 1;
            this.databaseRadioButton.Text = "Database";
            this.databaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // programmingRadioButton
            // 
            this.programmingRadioButton.AutoSize = true;
            this.programmingRadioButton.Checked = true;
            this.programmingRadioButton.Location = new System.Drawing.Point(6, 19);
            this.programmingRadioButton.Name = "programmingRadioButton";
            this.programmingRadioButton.Size = new System.Drawing.Size(86, 17);
            this.programmingRadioButton.TabIndex = 0;
            this.programmingRadioButton.TabStop = true;
            this.programmingRadioButton.Text = "Programming";
            this.programmingRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.workStudyCheckBox);
            this.groupBox2.Controls.Add(this.loansCheckBox);
            this.groupBox2.Controls.Add(this.grantsCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(148, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 90);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Financial Aid:";
            // 
            // workStudyCheckBox
            // 
            this.workStudyCheckBox.AutoSize = true;
            this.workStudyCheckBox.Location = new System.Drawing.Point(6, 65);
            this.workStudyCheckBox.Name = "workStudyCheckBox";
            this.workStudyCheckBox.Size = new System.Drawing.Size(82, 17);
            this.workStudyCheckBox.TabIndex = 2;
            this.workStudyCheckBox.Text = "Work-Study";
            this.workStudyCheckBox.UseVisualStyleBackColor = true;
            // 
            // loansCheckBox
            // 
            this.loansCheckBox.AutoSize = true;
            this.loansCheckBox.Location = new System.Drawing.Point(6, 42);
            this.loansCheckBox.Name = "loansCheckBox";
            this.loansCheckBox.Size = new System.Drawing.Size(55, 17);
            this.loansCheckBox.TabIndex = 1;
            this.loansCheckBox.Text = "Loans";
            this.loansCheckBox.UseVisualStyleBackColor = true;
            // 
            // grantsCheckBox
            // 
            this.grantsCheckBox.AutoSize = true;
            this.grantsCheckBox.Location = new System.Drawing.Point(6, 20);
            this.grantsCheckBox.Name = "grantsCheckBox";
            this.grantsCheckBox.Size = new System.Drawing.Size(57, 17);
            this.grantsCheckBox.TabIndex = 0;
            this.grantsCheckBox.Text = "Grants";
            this.grantsCheckBox.UseVisualStyleBackColor = true;
            // 
            // reasonsListBox
            // 
            this.reasonsListBox.FormattingEnabled = true;
            this.reasonsListBox.Items.AddRange(new object[] {
            "I want to start a high-paying career.",
            "I want to contribute to society.",
            "I want to be the best I can be.",
            "I’m tired of living at home.",
            "I want to party all the time."});
            this.reasonsListBox.Location = new System.Drawing.Point(284, 44);
            this.reasonsListBox.Name = "reasonsListBox";
            this.reasonsListBox.Size = new System.Drawing.Size(185, 82);
            this.reasonsListBox.TabIndex = 5;
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(12, 136);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(457, 118);
            this.outputLabel.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(328, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(65, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(404, 10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(65, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.reasonsListBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.highestGradeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decideButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Decisions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decideButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox highestGradeTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton webDevelopmentRadioButton;
        private System.Windows.Forms.RadioButton databaseRadioButton;
        private System.Windows.Forms.RadioButton programmingRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox workStudyCheckBox;
        private System.Windows.Forms.CheckBox loansCheckBox;
        private System.Windows.Forms.CheckBox grantsCheckBox;
        private System.Windows.Forms.ListBox reasonsListBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

