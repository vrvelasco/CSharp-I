namespace String_Theory
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
            this.validEmailLabel = new System.Windows.Forms.Label();
            this.validateEmailButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.textPromptLabel = new System.Windows.Forms.Label();
            this.formattedPhoneLabel = new System.Windows.Forms.Label();
            this.formatPhoneButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.replaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // validEmailLabel
            // 
            this.validEmailLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.validEmailLabel.Location = new System.Drawing.Point(12, 131);
            this.validEmailLabel.Name = "validEmailLabel";
            this.validEmailLabel.Size = new System.Drawing.Size(100, 23);
            this.validEmailLabel.TabIndex = 15;
            this.validEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // validateEmailButton
            // 
            this.validateEmailButton.Location = new System.Drawing.Point(12, 87);
            this.validateEmailButton.Name = "validateEmailButton";
            this.validateEmailButton.Size = new System.Drawing.Size(100, 23);
            this.validateEmailButton.TabIndex = 14;
            this.validateEmailButton.Text = "Validate Email";
            this.validateEmailButton.UseVisualStyleBackColor = true;
            this.validateEmailButton.Click += new System.EventHandler(this.validateEmailButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.inputTextBox.Location = new System.Drawing.Point(12, 46);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(217, 20);
            this.inputTextBox.TabIndex = 13;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPromptLabel
            // 
            this.textPromptLabel.AutoSize = true;
            this.textPromptLabel.Location = new System.Drawing.Point(80, 15);
            this.textPromptLabel.Name = "textPromptLabel";
            this.textPromptLabel.Size = new System.Drawing.Size(86, 13);
            this.textPromptLabel.TabIndex = 12;
            this.textPromptLabel.Text = "Enter Some Text";
            // 
            // formattedPhoneLabel
            // 
            this.formattedPhoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.formattedPhoneLabel.Location = new System.Drawing.Point(12, 216);
            this.formattedPhoneLabel.Name = "formattedPhoneLabel";
            this.formattedPhoneLabel.Size = new System.Drawing.Size(100, 23);
            this.formattedPhoneLabel.TabIndex = 17;
            this.formattedPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formatPhoneButton
            // 
            this.formatPhoneButton.Location = new System.Drawing.Point(12, 172);
            this.formatPhoneButton.Name = "formatPhoneButton";
            this.formatPhoneButton.Size = new System.Drawing.Size(100, 23);
            this.formatPhoneButton.TabIndex = 16;
            this.formatPhoneButton.Text = "Format Phone";
            this.formatPhoneButton.UseVisualStyleBackColor = true;
            this.formatPhoneButton.Click += new System.EventHandler(this.formatPhoneButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(129, 89);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 19;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(129, 131);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 23);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Location = new System.Drawing.Point(129, 174);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.replaceTextBox.TabIndex = 21;
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(129, 216);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(100, 23);
            this.replaceButton.TabIndex = 20;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 252);
            this.Controls.Add(this.replaceTextBox);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.formattedPhoneLabel);
            this.Controls.Add(this.formatPhoneButton);
            this.Controls.Add(this.validEmailLabel);
            this.Controls.Add(this.validateEmailButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.textPromptLabel);
            this.Name = "Form1";
            this.Text = "String Theory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label validEmailLabel;
        private System.Windows.Forms.Button validateEmailButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label textPromptLabel;
        private System.Windows.Forms.Label formattedPhoneLabel;
        private System.Windows.Forms.Button formatPhoneButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox replaceTextBox;
        private System.Windows.Forms.Button replaceButton;
    }
}

