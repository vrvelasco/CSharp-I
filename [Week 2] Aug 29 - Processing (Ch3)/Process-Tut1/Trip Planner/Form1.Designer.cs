namespace Trip_Planner
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
            this.dayOfWeekTextBox = new System.Windows.Forms.TextBox();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayOfMonthTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.milesPerGallonTextBox = new System.Windows.Forms.TextBox();
            this.milesToTravelTextBox = new System.Windows.Forms.TextBox();
            this.pricePerGallonTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.planTripButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalFuelLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayOfWeekTextBox
            // 
            this.dayOfWeekTextBox.Location = new System.Drawing.Point(165, 12);
            this.dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            this.dayOfWeekTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayOfWeekTextBox.TabIndex = 0;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(165, 38);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthTextBox.TabIndex = 1;
            // 
            // dayOfMonthTextBox
            // 
            this.dayOfMonthTextBox.Location = new System.Drawing.Point(165, 64);
            this.dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            this.dayOfMonthTextBox.Size = new System.Drawing.Size(100, 20);
            this.dayOfMonthTextBox.TabIndex = 2;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(165, 90);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 3;
            // 
            // milesPerGallonTextBox
            // 
            this.milesPerGallonTextBox.Location = new System.Drawing.Point(403, 12);
            this.milesPerGallonTextBox.Name = "milesPerGallonTextBox";
            this.milesPerGallonTextBox.Size = new System.Drawing.Size(100, 20);
            this.milesPerGallonTextBox.TabIndex = 4;
            // 
            // milesToTravelTextBox
            // 
            this.milesToTravelTextBox.Location = new System.Drawing.Point(403, 38);
            this.milesToTravelTextBox.Name = "milesToTravelTextBox";
            this.milesToTravelTextBox.Size = new System.Drawing.Size(100, 20);
            this.milesToTravelTextBox.TabIndex = 5;
            // 
            // pricePerGallonTextBox
            // 
            this.pricePerGallonTextBox.Location = new System.Drawing.Point(403, 64);
            this.pricePerGallonTextBox.Name = "pricePerGallonTextBox";
            this.pricePerGallonTextBox.Size = new System.Drawing.Size(100, 20);
            this.pricePerGallonTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter the Day of the Week:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter the Name of the Month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter the Day of the Month:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter the Year:";
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateOutputLabel.Location = new System.Drawing.Point(15, 118);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(250, 20);
            this.dateOutputLabel.TabIndex = 11;
            this.dateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // planTripButton
            // 
            this.planTripButton.Location = new System.Drawing.Point(15, 144);
            this.planTripButton.Name = "planTripButton";
            this.planTripButton.Size = new System.Drawing.Size(75, 30);
            this.planTripButton.TabIndex = 12;
            this.planTripButton.Text = "Plan Trip";
            this.planTripButton.UseVisualStyleBackColor = true;
            this.planTripButton.Click += new System.EventHandler(this.planTripButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(103, 144);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 30);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(190, 144);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 30);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enter Miles per Gallon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Enter Miles to Travel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Enter Price per Gallon:";
            // 
            // totalFuelLabel
            // 
            this.totalFuelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalFuelLabel.Location = new System.Drawing.Point(287, 118);
            this.totalFuelLabel.Name = "totalFuelLabel";
            this.totalFuelLabel.Size = new System.Drawing.Size(100, 20);
            this.totalFuelLabel.TabIndex = 18;
            this.totalFuelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(287, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fuel Required";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostLabel.Location = new System.Drawing.Point(403, 118);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(100, 20);
            this.totalCostLabel.TabIndex = 20;
            this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(403, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Total Cost";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 183);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalFuelLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.planTripButton);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pricePerGallonTextBox);
            this.Controls.Add(this.milesToTravelTextBox);
            this.Controls.Add(this.milesPerGallonTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayOfMonthTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayOfWeekTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Trip Planner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dayOfWeekTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayOfMonthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox milesPerGallonTextBox;
        private System.Windows.Forms.TextBox milesToTravelTextBox;
        private System.Windows.Forms.TextBox pricePerGallonTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Button planTripButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalFuelLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label label11;
    }
}

