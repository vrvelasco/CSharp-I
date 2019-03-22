namespace C_Sharp_Homework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.messageBoxButton = new System.Windows.Forms.Button();
            this.englishButton = new System.Windows.Forms.Button();
            this.spanishButton = new System.Windows.Forms.Button();
            this.languageLabel = new System.Windows.Forms.Label();
            this.firstGroupBox = new System.Windows.Forms.GroupBox();
            this.secondGroupBox = new System.Windows.Forms.GroupBox();
            this.jobLabel = new System.Windows.Forms.Label();
            this.redCrossPictureBox = new System.Windows.Forms.PictureBox();
            this.commerceBankPictureBox = new System.Windows.Forms.PictureBox();
            this.showARCButton = new System.Windows.Forms.Button();
            this.showCBIButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstGroupBox.SuspendLayout();
            this.secondGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redCrossPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commerceBankPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageBoxButton
            // 
            this.messageBoxButton.Location = new System.Drawing.Point(12, 12);
            this.messageBoxButton.Name = "messageBoxButton";
            this.messageBoxButton.Size = new System.Drawing.Size(80, 80);
            this.messageBoxButton.TabIndex = 0;
            this.messageBoxButton.Text = "Display MessageBox";
            this.messageBoxButton.UseVisualStyleBackColor = true;
            this.messageBoxButton.Click += new System.EventHandler(this.messageBoxButton_Click);
            // 
            // englishButton
            // 
            this.englishButton.Location = new System.Drawing.Point(6, 44);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(75, 35);
            this.englishButton.TabIndex = 1;
            this.englishButton.Text = "English";
            this.englishButton.UseVisualStyleBackColor = true;
            this.englishButton.Click += new System.EventHandler(this.englishButton_Click);
            // 
            // spanishButton
            // 
            this.spanishButton.Location = new System.Drawing.Point(87, 44);
            this.spanishButton.Name = "spanishButton";
            this.spanishButton.Size = new System.Drawing.Size(75, 35);
            this.spanishButton.TabIndex = 2;
            this.spanishButton.Text = "Español";
            this.spanishButton.UseVisualStyleBackColor = true;
            this.spanishButton.Click += new System.EventHandler(this.spanishButton_Click);
            // 
            // languageLabel
            // 
            this.languageLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.languageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.languageLabel.Location = new System.Drawing.Point(6, 16);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(156, 23);
            this.languageLabel.TabIndex = 3;
            this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstGroupBox
            // 
            this.firstGroupBox.Controls.Add(this.languageLabel);
            this.firstGroupBox.Controls.Add(this.spanishButton);
            this.firstGroupBox.Controls.Add(this.englishButton);
            this.firstGroupBox.Location = new System.Drawing.Point(98, 7);
            this.firstGroupBox.Name = "firstGroupBox";
            this.firstGroupBox.Size = new System.Drawing.Size(170, 85);
            this.firstGroupBox.TabIndex = 4;
            this.firstGroupBox.TabStop = false;
            this.firstGroupBox.Text = "Select the language:";
            // 
            // secondGroupBox
            // 
            this.secondGroupBox.Controls.Add(this.showCBIButton);
            this.secondGroupBox.Controls.Add(this.showARCButton);
            this.secondGroupBox.Controls.Add(this.jobLabel);
            this.secondGroupBox.Controls.Add(this.redCrossPictureBox);
            this.secondGroupBox.Controls.Add(this.commerceBankPictureBox);
            this.secondGroupBox.Location = new System.Drawing.Point(12, 98);
            this.secondGroupBox.Name = "secondGroupBox";
            this.secondGroupBox.Size = new System.Drawing.Size(256, 239);
            this.secondGroupBox.TabIndex = 5;
            this.secondGroupBox.TabStop = false;
            this.secondGroupBox.Text = "Click the picture for information:";
            // 
            // jobLabel
            // 
            this.jobLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.jobLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobLabel.ForeColor = System.Drawing.Color.PowderBlue;
            this.jobLabel.Location = new System.Drawing.Point(6, 151);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(242, 23);
            this.jobLabel.TabIndex = 6;
            this.jobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redCrossPictureBox
            // 
            this.redCrossPictureBox.BackColor = System.Drawing.Color.White;
            this.redCrossPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redCrossPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("redCrossPictureBox.Image")));
            this.redCrossPictureBox.Location = new System.Drawing.Point(6, 19);
            this.redCrossPictureBox.Name = "redCrossPictureBox";
            this.redCrossPictureBox.Size = new System.Drawing.Size(242, 60);
            this.redCrossPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redCrossPictureBox.TabIndex = 6;
            this.redCrossPictureBox.TabStop = false;
            this.redCrossPictureBox.Click += new System.EventHandler(this.redCrossPictureBox_Click);
            // 
            // commerceBankPictureBox
            // 
            this.commerceBankPictureBox.BackColor = System.Drawing.Color.White;
            this.commerceBankPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commerceBankPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("commerceBankPictureBox.Image")));
            this.commerceBankPictureBox.Location = new System.Drawing.Point(6, 85);
            this.commerceBankPictureBox.Name = "commerceBankPictureBox";
            this.commerceBankPictureBox.Size = new System.Drawing.Size(242, 60);
            this.commerceBankPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.commerceBankPictureBox.TabIndex = 7;
            this.commerceBankPictureBox.TabStop = false;
            this.commerceBankPictureBox.Click += new System.EventHandler(this.commerceBankPictureBox_Click);
            // 
            // showARCButton
            // 
            this.showARCButton.Location = new System.Drawing.Point(6, 180);
            this.showARCButton.Name = "showARCButton";
            this.showARCButton.Size = new System.Drawing.Size(115, 50);
            this.showARCButton.TabIndex = 8;
            this.showARCButton.Text = "Show\r\nAmerican Red Cross";
            this.showARCButton.UseVisualStyleBackColor = true;
            this.showARCButton.Click += new System.EventHandler(this.showARCButton_Click);
            // 
            // showCBIButton
            // 
            this.showCBIButton.Location = new System.Drawing.Point(127, 180);
            this.showCBIButton.Name = "showCBIButton";
            this.showCBIButton.Size = new System.Drawing.Size(121, 50);
            this.showCBIButton.TabIndex = 9;
            this.showCBIButton.Text = "Show\r\nCommerce Bank";
            this.showCBIButton.UseVisualStyleBackColor = true;
            this.showCBIButton.Click += new System.EventHandler(this.showCBIButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(127, 16);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(121, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(6, 16);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(115, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear and Reset";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 48);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 400);
            this.Controls.Add(this.secondGroupBox);
            this.Controls.Add(this.firstGroupBox);
            this.Controls.Add(this.messageBoxButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "C Sharp Homework";
            this.firstGroupBox.ResumeLayout(false);
            this.secondGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.redCrossPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commerceBankPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button messageBoxButton;
        private System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Button spanishButton;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.GroupBox firstGroupBox;
        private System.Windows.Forms.GroupBox secondGroupBox;
        private System.Windows.Forms.PictureBox redCrossPictureBox;
        private System.Windows.Forms.PictureBox commerceBankPictureBox;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.Button showCBIButton;
        private System.Windows.Forms.Button showARCButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

