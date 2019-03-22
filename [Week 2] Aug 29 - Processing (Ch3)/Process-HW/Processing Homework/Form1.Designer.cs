namespace Processing_Homework
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
            this.equationLabel = new System.Windows.Forms.Label();
            this.varATextBox = new System.Windows.Forms.TextBox();
            this.varBTextBox = new System.Windows.Forms.TextBox();
            this.varCTextBox = new System.Windows.Forms.TextBox();
            this.varXTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xResultLabel = new System.Windows.Forms.Label();
            this.yResultLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.incXButton = new System.Windows.Forms.Button();
            this.decXButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // equationLabel
            // 
            this.equationLabel.BackColor = System.Drawing.Color.Black;
            this.equationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equationLabel.ForeColor = System.Drawing.Color.White;
            this.equationLabel.Location = new System.Drawing.Point(12, 9);
            this.equationLabel.Name = "equationLabel";
            this.equationLabel.Size = new System.Drawing.Size(487, 50);
            this.equationLabel.TabIndex = 0;
            this.equationLabel.Text = "y = ax² + bx + c";
            this.equationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // varATextBox
            // 
            this.varATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varATextBox.Location = new System.Drawing.Point(9, 44);
            this.varATextBox.Name = "varATextBox";
            this.varATextBox.Size = new System.Drawing.Size(40, 38);
            this.varATextBox.TabIndex = 1;
            this.varATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // varBTextBox
            // 
            this.varBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varBTextBox.Location = new System.Drawing.Point(55, 44);
            this.varBTextBox.Name = "varBTextBox";
            this.varBTextBox.Size = new System.Drawing.Size(40, 38);
            this.varBTextBox.TabIndex = 2;
            this.varBTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // varCTextBox
            // 
            this.varCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varCTextBox.Location = new System.Drawing.Point(101, 44);
            this.varCTextBox.Name = "varCTextBox";
            this.varCTextBox.Size = new System.Drawing.Size(40, 38);
            this.varCTextBox.TabIndex = 3;
            this.varCTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // varXTextBox
            // 
            this.varXTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varXTextBox.Location = new System.Drawing.Point(147, 44);
            this.varXTextBox.Name = "varXTextBox";
            this.varXTextBox.Size = new System.Drawing.Size(40, 38);
            this.varXTextBox.TabIndex = 4;
            this.varXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(303, 81);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(85, 23);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "a";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "b";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "c";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "x";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.varATextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.varBTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.varCTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.varXTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 94);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variables:";
            // 
            // xResultLabel
            // 
            this.xResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xResultLabel.Location = new System.Drawing.Point(6, 18);
            this.xResultLabel.Name = "xResultLabel";
            this.xResultLabel.Size = new System.Drawing.Size(65, 23);
            this.xResultLabel.TabIndex = 11;
            this.xResultLabel.Text = "x =";
            this.xResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yResultLabel
            // 
            this.yResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yResultLabel.Location = new System.Drawing.Point(6, 59);
            this.yResultLabel.Name = "yResultLabel";
            this.yResultLabel.Size = new System.Drawing.Size(65, 23);
            this.yResultLabel.TabIndex = 12;
            this.yResultLabel.Text = "y =";
            this.yResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.yResultLabel);
            this.groupBox2.Controls.Add(this.xResultLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(214, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 94);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Location = new System.Drawing.Point(9, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 1);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(303, 109);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(85, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(303, 138);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 23);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // incXButton
            // 
            this.incXButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incXButton.Location = new System.Drawing.Point(394, 81);
            this.incXButton.Name = "incXButton";
            this.incXButton.Size = new System.Drawing.Size(105, 37);
            this.incXButton.TabIndex = 16;
            this.incXButton.Text = "Increment X";
            this.incXButton.UseVisualStyleBackColor = true;
            this.incXButton.Click += new System.EventHandler(this.incXButton_Click);
            // 
            // decXButton
            // 
            this.decXButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decXButton.Location = new System.Drawing.Point(394, 124);
            this.decXButton.Name = "decXButton";
            this.decXButton.Size = new System.Drawing.Size(105, 37);
            this.decXButton.TabIndex = 17;
            this.decXButton.Text = "Decrement X";
            this.decXButton.UseVisualStyleBackColor = true;
            this.decXButton.Click += new System.EventHandler(this.decXButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 174);
            this.Controls.Add(this.decXButton);
            this.Controls.Add(this.incXButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.equationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Processing Homework";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label equationLabel;
        private System.Windows.Forms.TextBox varATextBox;
        private System.Windows.Forms.TextBox varBTextBox;
        private System.Windows.Forms.TextBox varCTextBox;
        private System.Windows.Forms.TextBox varXTextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label xResultLabel;
        private System.Windows.Forms.Label yResultLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button incXButton;
        private System.Windows.Forms.Button decXButton;
    }
}

