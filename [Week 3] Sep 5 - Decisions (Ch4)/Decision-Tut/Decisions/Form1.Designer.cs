namespace Decisions
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iPhoneCheckBox = new System.Windows.Forms.CheckBox();
            this.carCheckBox = new System.Windows.Forms.CheckBox();
            this.houseCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.poorRadioButton = new System.Windows.Forms.RadioButton();
            this.middleClassRadioButton = new System.Windows.Forms.RadioButton();
            this.richRadioButton = new System.Windows.Forms.RadioButton();
            this.situationLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.decideButton = new System.Windows.Forms.Button();
            this.childrenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.decisionListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iPhoneCheckBox);
            this.groupBox2.Controls.Add(this.carCheckBox);
            this.groupBox2.Controls.Add(this.houseCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(148, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 90);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Posessions";
            // 
            // iPhoneCheckBox
            // 
            this.iPhoneCheckBox.AutoSize = true;
            this.iPhoneCheckBox.Location = new System.Drawing.Point(6, 65);
            this.iPhoneCheckBox.Name = "iPhoneCheckBox";
            this.iPhoneCheckBox.Size = new System.Drawing.Size(59, 17);
            this.iPhoneCheckBox.TabIndex = 2;
            this.iPhoneCheckBox.Text = "iPhone";
            this.iPhoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // carCheckBox
            // 
            this.carCheckBox.AutoSize = true;
            this.carCheckBox.Location = new System.Drawing.Point(6, 42);
            this.carCheckBox.Name = "carCheckBox";
            this.carCheckBox.Size = new System.Drawing.Size(42, 17);
            this.carCheckBox.TabIndex = 1;
            this.carCheckBox.Text = "Car";
            this.carCheckBox.UseVisualStyleBackColor = true;
            // 
            // houseCheckBox
            // 
            this.houseCheckBox.AutoSize = true;
            this.houseCheckBox.Location = new System.Drawing.Point(6, 19);
            this.houseCheckBox.Name = "houseCheckBox";
            this.houseCheckBox.Size = new System.Drawing.Size(57, 17);
            this.houseCheckBox.TabIndex = 0;
            this.houseCheckBox.Text = "House";
            this.houseCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.poorRadioButton);
            this.groupBox1.Controls.Add(this.middleClassRadioButton);
            this.groupBox1.Controls.Add(this.richRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 90);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Social Class";
            // 
            // poorRadioButton
            // 
            this.poorRadioButton.AutoSize = true;
            this.poorRadioButton.Location = new System.Drawing.Point(6, 65);
            this.poorRadioButton.Name = "poorRadioButton";
            this.poorRadioButton.Size = new System.Drawing.Size(47, 17);
            this.poorRadioButton.TabIndex = 2;
            this.poorRadioButton.Text = "Poor";
            this.poorRadioButton.UseVisualStyleBackColor = true;
            // 
            // middleClassRadioButton
            // 
            this.middleClassRadioButton.AutoSize = true;
            this.middleClassRadioButton.Location = new System.Drawing.Point(6, 42);
            this.middleClassRadioButton.Name = "middleClassRadioButton";
            this.middleClassRadioButton.Size = new System.Drawing.Size(84, 17);
            this.middleClassRadioButton.TabIndex = 1;
            this.middleClassRadioButton.Text = "Middle Class";
            this.middleClassRadioButton.UseVisualStyleBackColor = true;
            // 
            // richRadioButton
            // 
            this.richRadioButton.AutoSize = true;
            this.richRadioButton.Checked = true;
            this.richRadioButton.Location = new System.Drawing.Point(6, 19);
            this.richRadioButton.Name = "richRadioButton";
            this.richRadioButton.Size = new System.Drawing.Size(47, 17);
            this.richRadioButton.TabIndex = 0;
            this.richRadioButton.TabStop = true;
            this.richRadioButton.Text = "Rich";
            this.richRadioButton.UseVisualStyleBackColor = true;
            // 
            // situationLabel
            // 
            this.situationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.situationLabel.Location = new System.Drawing.Point(12, 163);
            this.situationLabel.Name = "situationLabel";
            this.situationLabel.Size = new System.Drawing.Size(414, 79);
            this.situationLabel.TabIndex = 29;
            this.situationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(301, 134);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 23);
            this.exitButton.TabIndex = 28;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(153, 134);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 23);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // decideButton
            // 
            this.decideButton.Location = new System.Drawing.Point(12, 134);
            this.decideButton.Name = "decideButton";
            this.decideButton.Size = new System.Drawing.Size(125, 23);
            this.decideButton.TabIndex = 26;
            this.decideButton.Text = "Decide";
            this.decideButton.UseVisualStyleBackColor = true;
            this.decideButton.Click += new System.EventHandler(this.decideButton_Click);
            // 
            // childrenTextBox
            // 
            this.childrenTextBox.Location = new System.Drawing.Point(146, 12);
            this.childrenTextBox.Name = "childrenTextBox";
            this.childrenTextBox.Size = new System.Drawing.Size(100, 20);
            this.childrenTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Number of Children:";
            // 
            // decisionListBox
            // 
            this.decisionListBox.FormattingEnabled = true;
            this.decisionListBox.Items.AddRange(new object[] {
            "winner take nothing",
            "you get what you need",
            "you can have it all",
            "you still have made a choise",
            "the choice is yours"});
            this.decisionListBox.Location = new System.Drawing.Point(284, 45);
            this.decisionListBox.Name = "decisionListBox";
            this.decisionListBox.Size = new System.Drawing.Size(142, 82);
            this.decisionListBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "If you choose not to decide...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 248);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decisionListBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.situationLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.decideButton);
            this.Controls.Add(this.childrenTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Decisions Decisions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox iPhoneCheckBox;
        private System.Windows.Forms.CheckBox carCheckBox;
        private System.Windows.Forms.CheckBox houseCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton poorRadioButton;
        private System.Windows.Forms.RadioButton middleClassRadioButton;
        private System.Windows.Forms.RadioButton richRadioButton;
        private System.Windows.Forms.Label situationLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button decideButton;
        private System.Windows.Forms.TextBox childrenTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox decisionListBox;
        private System.Windows.Forms.Label label2;
    }
}

