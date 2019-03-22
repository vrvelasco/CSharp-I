namespace Wish_List
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
            this.wishTextBox = new System.Windows.Forms.TextBox();
            this.wishPromptLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.appendButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.wishListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // wishTextBox
            // 
            this.wishTextBox.Location = new System.Drawing.Point(91, 12);
            this.wishTextBox.Name = "wishTextBox";
            this.wishTextBox.Size = new System.Drawing.Size(181, 20);
            this.wishTextBox.TabIndex = 3;
            // 
            // wishPromptLabel
            // 
            this.wishPromptLabel.AutoSize = true;
            this.wishPromptLabel.Location = new System.Drawing.Point(12, 15);
            this.wishPromptLabel.Name = "wishPromptLabel";
            this.wishPromptLabel.Size = new System.Drawing.Size(73, 13);
            this.wishPromptLabel.TabIndex = 2;
            this.wishPromptLabel.Text = "Make a Wish:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(53, 204);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 45);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear (Form)";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(157, 204);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 45);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(12, 142);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(73, 45);
            this.writeButton.TabIndex = 5;
            this.writeButton.Text = "Write Wish to File";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // appendButton
            // 
            this.appendButton.Location = new System.Drawing.Point(100, 142);
            this.appendButton.Name = "appendButton";
            this.appendButton.Size = new System.Drawing.Size(80, 45);
            this.appendButton.TabIndex = 8;
            this.appendButton.Text = "Append Wish to File";
            this.appendButton.UseVisualStyleBackColor = true;
            this.appendButton.Click += new System.EventHandler(this.appendButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(192, 142);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(80, 45);
            this.readButton.TabIndex = 10;
            this.readButton.Text = "Read Wishes from File";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // wishListBox
            // 
            this.wishListBox.FormattingEnabled = true;
            this.wishListBox.Location = new System.Drawing.Point(53, 54);
            this.wishListBox.Name = "wishListBox";
            this.wishListBox.Size = new System.Drawing.Size(179, 69);
            this.wishListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.wishListBox);
            this.Controls.Add(this.appendButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.wishTextBox);
            this.Controls.Add(this.wishPromptLabel);
            this.Name = "Form1";
            this.Text = "Wish List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wishTextBox;
        private System.Windows.Forms.Label wishPromptLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button appendButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.ListBox wishListBox;
    }
}

