namespace Color_Theme
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
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.yellowRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadionButton = new System.Windows.Forms.RadioButton();
            this.whiteRadioButton = new System.Windows.Forms.RadioButton();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.colorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.normalRadioButton);
            this.colorGroupBox.Controls.Add(this.whiteRadioButton);
            this.colorGroupBox.Controls.Add(this.yellowRadioButton);
            this.colorGroupBox.Controls.Add(this.redRadionButton);
            this.colorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorGroupBox.Location = new System.Drawing.Point(12, 12);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(218, 128);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Select a Background Color:";
            // 
            // yellowRadioButton
            // 
            this.yellowRadioButton.AutoSize = true;
            this.yellowRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowRadioButton.Location = new System.Drawing.Point(60, 21);
            this.yellowRadioButton.Name = "yellowRadioButton";
            this.yellowRadioButton.Size = new System.Drawing.Size(66, 20);
            this.yellowRadioButton.TabIndex = 1;
            this.yellowRadioButton.Text = "Yellow";
            this.yellowRadioButton.UseVisualStyleBackColor = true;
            this.yellowRadioButton.CheckedChanged += new System.EventHandler(this.yellowRadioButton_CheckedChanged);
            // 
            // redRadionButton
            // 
            this.redRadionButton.AutoSize = true;
            this.redRadionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redRadionButton.Location = new System.Drawing.Point(60, 47);
            this.redRadionButton.Name = "redRadionButton";
            this.redRadionButton.Size = new System.Drawing.Size(52, 20);
            this.redRadionButton.TabIndex = 2;
            this.redRadionButton.TabStop = true;
            this.redRadionButton.Text = "Red";
            this.redRadionButton.UseVisualStyleBackColor = true;
            this.redRadionButton.CheckedChanged += new System.EventHandler(this.redRadionButton_CheckedChanged);
            // 
            // whiteRadioButton
            // 
            this.whiteRadioButton.AutoSize = true;
            this.whiteRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteRadioButton.Location = new System.Drawing.Point(60, 73);
            this.whiteRadioButton.Name = "whiteRadioButton";
            this.whiteRadioButton.Size = new System.Drawing.Size(60, 20);
            this.whiteRadioButton.TabIndex = 3;
            this.whiteRadioButton.TabStop = true;
            this.whiteRadioButton.Text = "White";
            this.whiteRadioButton.UseVisualStyleBackColor = true;
            this.whiteRadioButton.CheckedChanged += new System.EventHandler(this.whiteRadioButton_CheckedChanged);
            // 
            // normalRadioButton
            // 
            this.normalRadioButton.AutoSize = true;
            this.normalRadioButton.Checked = true;
            this.normalRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalRadioButton.Location = new System.Drawing.Point(60, 99);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(118, 20);
            this.normalRadioButton.TabIndex = 4;
            this.normalRadioButton.TabStop = true;
            this.normalRadioButton.Text = "Back to Normal";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            this.normalRadioButton.CheckedChanged += new System.EventHandler(this.normalRadioButton_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 146);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(218, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 181);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.colorGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Color Theme";
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.RadioButton normalRadioButton;
        private System.Windows.Forms.RadioButton whiteRadioButton;
        private System.Windows.Forms.RadioButton yellowRadioButton;
        private System.Windows.Forms.RadioButton redRadionButton;
        private System.Windows.Forms.Button exitButton;
    }
}

