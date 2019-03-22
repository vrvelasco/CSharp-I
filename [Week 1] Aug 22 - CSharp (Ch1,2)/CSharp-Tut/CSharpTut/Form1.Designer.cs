namespace CSharpTut
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
            this.messageButton = new System.Windows.Forms.Button();
            this.messagePromptLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.morningButton = new System.Windows.Forms.Button();
            this.afternoonButton = new System.Windows.Forms.Button();
            this.illinoisPictureBox = new System.Windows.Forms.PictureBox();
            this.missouriPictureBox = new System.Windows.Forms.PictureBox();
            this.petPromptLabel = new System.Windows.Forms.Label();
            this.flagNameLabel = new System.Windows.Forms.Label();
            this.showIllinoisButton = new System.Windows.Forms.Button();
            this.showMissouriButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.illinoisPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missouriPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(12, 12);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(80, 80);
            this.messageButton.TabIndex = 0;
            this.messageButton.Text = "Display MessageBox";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // messagePromptLabel
            // 
            this.messagePromptLabel.Location = new System.Drawing.Point(112, 11);
            this.messagePromptLabel.Name = "messagePromptLabel";
            this.messagePromptLabel.Size = new System.Drawing.Size(156, 14);
            this.messagePromptLabel.TabIndex = 1;
            this.messagePromptLabel.Text = "Display a message in the label:";
            this.messagePromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messageLabel
            // 
            this.messageLabel.BackColor = System.Drawing.Color.OliveDrab;
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.messageLabel.Location = new System.Drawing.Point(112, 69);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(156, 23);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // morningButton
            // 
            this.morningButton.Location = new System.Drawing.Point(112, 28);
            this.morningButton.Name = "morningButton";
            this.morningButton.Size = new System.Drawing.Size(75, 38);
            this.morningButton.TabIndex = 3;
            this.morningButton.Text = "Morning";
            this.morningButton.UseVisualStyleBackColor = true;
            this.morningButton.Click += new System.EventHandler(this.morningButton_Click);
            // 
            // afternoonButton
            // 
            this.afternoonButton.Location = new System.Drawing.Point(193, 28);
            this.afternoonButton.Name = "afternoonButton";
            this.afternoonButton.Size = new System.Drawing.Size(75, 38);
            this.afternoonButton.TabIndex = 4;
            this.afternoonButton.Text = "Afternoon";
            this.afternoonButton.UseVisualStyleBackColor = true;
            this.afternoonButton.Click += new System.EventHandler(this.afternoonButton_Click);
            // 
            // illinoisPictureBox
            // 
            this.illinoisPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("illinoisPictureBox.Image")));
            this.illinoisPictureBox.Location = new System.Drawing.Point(12, 126);
            this.illinoisPictureBox.Name = "illinoisPictureBox";
            this.illinoisPictureBox.Size = new System.Drawing.Size(125, 75);
            this.illinoisPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.illinoisPictureBox.TabIndex = 5;
            this.illinoisPictureBox.TabStop = false;
            this.illinoisPictureBox.Click += new System.EventHandler(this.illinoisPictureBox_Click);
            // 
            // missouriPictureBox
            // 
            this.missouriPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("missouriPictureBox.Image")));
            this.missouriPictureBox.Location = new System.Drawing.Point(143, 126);
            this.missouriPictureBox.Name = "missouriPictureBox";
            this.missouriPictureBox.Size = new System.Drawing.Size(125, 75);
            this.missouriPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.missouriPictureBox.TabIndex = 6;
            this.missouriPictureBox.TabStop = false;
            this.missouriPictureBox.Click += new System.EventHandler(this.missouriPictureBox_Click);
            // 
            // petPromptLabel
            // 
            this.petPromptLabel.Location = new System.Drawing.Point(12, 100);
            this.petPromptLabel.Name = "petPromptLabel";
            this.petPromptLabel.Size = new System.Drawing.Size(256, 23);
            this.petPromptLabel.TabIndex = 7;
            this.petPromptLabel.Text = "Click the flag to learn its name:";
            this.petPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flagNameLabel
            // 
            this.flagNameLabel.BackColor = System.Drawing.Color.Maroon;
            this.flagNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flagNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flagNameLabel.ForeColor = System.Drawing.Color.White;
            this.flagNameLabel.Location = new System.Drawing.Point(12, 209);
            this.flagNameLabel.Name = "flagNameLabel";
            this.flagNameLabel.Size = new System.Drawing.Size(254, 23);
            this.flagNameLabel.TabIndex = 8;
            this.flagNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showIllinoisButton
            // 
            this.showIllinoisButton.Location = new System.Drawing.Point(12, 245);
            this.showIllinoisButton.Name = "showIllinoisButton";
            this.showIllinoisButton.Size = new System.Drawing.Size(125, 23);
            this.showIllinoisButton.TabIndex = 9;
            this.showIllinoisButton.Text = "Show Illinois";
            this.showIllinoisButton.UseVisualStyleBackColor = true;
            this.showIllinoisButton.Click += new System.EventHandler(this.showIllinoisButton_Click);
            // 
            // showMissouriButton
            // 
            this.showMissouriButton.Location = new System.Drawing.Point(143, 245);
            this.showMissouriButton.Name = "showMissouriButton";
            this.showMissouriButton.Size = new System.Drawing.Size(123, 23);
            this.showMissouriButton.TabIndex = 10;
            this.showMissouriButton.Text = "Show Missouri";
            this.showMissouriButton.UseVisualStyleBackColor = true;
            this.showMissouriButton.Click += new System.EventHandler(this.showMissouriButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 274);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(254, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 306);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showMissouriButton);
            this.Controls.Add(this.showIllinoisButton);
            this.Controls.Add(this.flagNameLabel);
            this.Controls.Add(this.petPromptLabel);
            this.Controls.Add(this.missouriPictureBox);
            this.Controls.Add(this.illinoisPictureBox);
            this.Controls.Add(this.afternoonButton);
            this.Controls.Add(this.morningButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.messagePromptLabel);
            this.Controls.Add(this.messageButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "C Sharp Tutorial";
            ((System.ComponentModel.ISupportInitialize)(this.illinoisPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missouriPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Label messagePromptLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button morningButton;
        private System.Windows.Forms.Button afternoonButton;
        private System.Windows.Forms.PictureBox illinoisPictureBox;
        private System.Windows.Forms.PictureBox missouriPictureBox;
        private System.Windows.Forms.Label petPromptLabel;
        private System.Windows.Forms.Label flagNameLabel;
        private System.Windows.Forms.Button showIllinoisButton;
        private System.Windows.Forms.Button showMissouriButton;
        private System.Windows.Forms.Button exitButton;
    }
}

