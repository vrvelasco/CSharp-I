namespace Bonus_Average
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
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.testAverageLabel = new System.Windows.Forms.Label();
            this.bonusPointsLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.subtractBonusPointButton = new System.Windows.Forms.Button();
            this.addBonusPointButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bonusAverageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(149, 6);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(100, 20);
            this.test1TextBox.TabIndex = 0;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(149, 32);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(100, 20);
            this.test2TextBox.TabIndex = 1;
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(149, 58);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(100, 20);
            this.test3TextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Test 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Test 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Test 3:";
            // 
            // testAverageLabel
            // 
            this.testAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testAverageLabel.Location = new System.Drawing.Point(111, 81);
            this.testAverageLabel.Name = "testAverageLabel";
            this.testAverageLabel.Size = new System.Drawing.Size(138, 23);
            this.testAverageLabel.TabIndex = 6;
            this.testAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bonusPointsLabel
            // 
            this.bonusPointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bonusPointsLabel.Location = new System.Drawing.Point(93, 145);
            this.bonusPointsLabel.Name = "bonusPointsLabel";
            this.bonusPointsLabel.Size = new System.Drawing.Size(75, 48);
            this.bonusPointsLabel.TabIndex = 7;
            this.bonusPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 116);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calc Avg";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(93, 116);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(174, 116);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // subtractBonusPointButton
            // 
            this.subtractBonusPointButton.Location = new System.Drawing.Point(12, 145);
            this.subtractBonusPointButton.Name = "subtractBonusPointButton";
            this.subtractBonusPointButton.Size = new System.Drawing.Size(75, 48);
            this.subtractBonusPointButton.TabIndex = 11;
            this.subtractBonusPointButton.Text = "Subtract Bonus Points";
            this.subtractBonusPointButton.UseVisualStyleBackColor = true;
            this.subtractBonusPointButton.Click += new System.EventHandler(this.subtractBonusPointButton_Click);
            // 
            // addBonusPointButton
            // 
            this.addBonusPointButton.Location = new System.Drawing.Point(174, 145);
            this.addBonusPointButton.Name = "addBonusPointButton";
            this.addBonusPointButton.Size = new System.Drawing.Size(75, 48);
            this.addBonusPointButton.TabIndex = 12;
            this.addBonusPointButton.Text = "Add Bonus Point";
            this.addBonusPointButton.UseVisualStyleBackColor = true;
            this.addBonusPointButton.Click += new System.EventHandler(this.addBonusPointButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Test Average:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bonus Average:";
            // 
            // bonusAverageLabel
            // 
            this.bonusAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bonusAverageLabel.Location = new System.Drawing.Point(111, 206);
            this.bonusAverageLabel.Name = "bonusAverageLabel";
            this.bonusAverageLabel.Size = new System.Drawing.Size(138, 23);
            this.bonusAverageLabel.TabIndex = 15;
            this.bonusAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 238);
            this.Controls.Add(this.bonusAverageLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addBonusPointButton);
            this.Controls.Add(this.subtractBonusPointButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.bonusPointsLabel);
            this.Controls.Add(this.testAverageLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.test3TextBox);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test1TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bonus Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label testAverageLabel;
        private System.Windows.Forms.Label bonusPointsLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button subtractBonusPointButton;
        private System.Windows.Forms.Button addBonusPointButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bonusAverageLabel;
    }
}

