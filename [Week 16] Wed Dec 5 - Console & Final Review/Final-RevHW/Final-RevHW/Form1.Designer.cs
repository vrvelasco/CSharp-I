namespace Final_RevHW
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
            this.vehicleGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.modelRadioButton = new System.Windows.Forms.RadioButton();
            this.makeRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.vehicleCountLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.titleGroupBox = new System.Windows.Forms.GroupBox();
            this.bonusGroupBox = new System.Windows.Forms.GroupBox();
            this.searchLINQTextBox = new System.Windows.Forms.TextBox();
            this.searchLINQButton = new System.Windows.Forms.Button();
            this.introGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.vehicleGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.titleGroupBox.SuspendLayout();
            this.bonusGroupBox.SuspendLayout();
            this.introGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicleGroupBox
            // 
            this.vehicleGroupBox.Controls.Add(this.label3);
            this.vehicleGroupBox.Controls.Add(this.label2);
            this.vehicleGroupBox.Controls.Add(this.label1);
            this.vehicleGroupBox.Controls.Add(this.addButton);
            this.vehicleGroupBox.Controls.Add(this.priceTextBox);
            this.vehicleGroupBox.Controls.Add(this.modelTextBox);
            this.vehicleGroupBox.Controls.Add(this.makeTextBox);
            this.vehicleGroupBox.Enabled = false;
            this.vehicleGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleGroupBox.Location = new System.Drawing.Point(382, 120);
            this.vehicleGroupBox.Name = "vehicleGroupBox";
            this.vehicleGroupBox.Size = new System.Drawing.Size(227, 158);
            this.vehicleGroupBox.TabIndex = 2;
            this.vehicleGroupBox.TabStop = false;
            this.vehicleGroupBox.Text = "Vehicle Information:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Make:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(10, 119);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(209, 29);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add Vehicle";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(61, 87);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(155, 22);
            this.priceTextBox.TabIndex = 2;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextBox.Location = new System.Drawing.Point(61, 55);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(155, 22);
            this.modelTextBox.TabIndex = 1;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeTextBox.Location = new System.Drawing.Point(61, 23);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(155, 22);
            this.makeTextBox.TabIndex = 0;
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.LightGray;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.ForeColor = System.Drawing.Color.DimGray;
            this.loadButton.Location = new System.Drawing.Point(285, 252);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(91, 25);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load File...";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.ItemHeight = 16;
            this.displayListBox.Location = new System.Drawing.Point(12, 89);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(364, 164);
            this.displayListBox.TabIndex = 3;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.modelRadioButton);
            this.searchGroupBox.Controls.Add(this.makeRadioButton);
            this.searchGroupBox.Controls.Add(this.label4);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Enabled = false;
            this.searchGroupBox.Location = new System.Drawing.Point(382, 12);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(227, 73);
            this.searchGroupBox.TabIndex = 1;
            this.searchGroupBox.TabStop = false;
            // 
            // modelRadioButton
            // 
            this.modelRadioButton.AutoSize = true;
            this.modelRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelRadioButton.Location = new System.Drawing.Point(156, 16);
            this.modelRadioButton.Name = "modelRadioButton";
            this.modelRadioButton.Size = new System.Drawing.Size(60, 20);
            this.modelRadioButton.TabIndex = 1;
            this.modelRadioButton.Text = "Model";
            this.modelRadioButton.UseVisualStyleBackColor = true;
            // 
            // makeRadioButton
            // 
            this.makeRadioButton.AutoSize = true;
            this.makeRadioButton.Checked = true;
            this.makeRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeRadioButton.Location = new System.Drawing.Point(90, 16);
            this.makeRadioButton.Name = "makeRadioButton";
            this.makeRadioButton.Size = new System.Drawing.Size(58, 20);
            this.makeRadioButton.TabIndex = 0;
            this.makeRadioButton.TabStop = true;
            this.makeRadioButton.Text = "Make";
            this.makeRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Search for:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(170, 42);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(51, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Find";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(8, 42);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(158, 22);
            this.searchTextBox.TabIndex = 2;
            // 
            // vehicleCountLabel
            // 
            this.vehicleCountLabel.BackColor = System.Drawing.Color.DimGray;
            this.vehicleCountLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleCountLabel.ForeColor = System.Drawing.Color.White;
            this.vehicleCountLabel.Location = new System.Drawing.Point(12, 252);
            this.vehicleCountLabel.Name = "vehicleCountLabel";
            this.vehicleCountLabel.Size = new System.Drawing.Size(128, 25);
            this.vehicleCountLabel.TabIndex = 6;
            this.vehicleCountLabel.Text = "Vehicle(s): 0 / 10";
            this.vehicleCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageLabel
            // 
            this.averageLabel.BackColor = System.Drawing.Color.DimGray;
            this.averageLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageLabel.ForeColor = System.Drawing.Color.White;
            this.averageLabel.Location = new System.Drawing.Point(140, 252);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(145, 25);
            this.averageLabel.TabIndex = 7;
            this.averageLabel.Text = "[ Average: $0.00 ]";
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(352, 46);
            this.label6.TabIndex = 8;
            this.label6.Text = "Final Review Homework";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleGroupBox
            // 
            this.titleGroupBox.Controls.Add(this.label6);
            this.titleGroupBox.Location = new System.Drawing.Point(12, 12);
            this.titleGroupBox.Name = "titleGroupBox";
            this.titleGroupBox.Size = new System.Drawing.Size(364, 73);
            this.titleGroupBox.TabIndex = 9;
            this.titleGroupBox.TabStop = false;
            // 
            // bonusGroupBox
            // 
            this.bonusGroupBox.Controls.Add(this.searchLINQTextBox);
            this.bonusGroupBox.Controls.Add(this.searchLINQButton);
            this.bonusGroupBox.Enabled = false;
            this.bonusGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusGroupBox.Location = new System.Drawing.Point(12, 12);
            this.bonusGroupBox.Name = "bonusGroupBox";
            this.bonusGroupBox.Size = new System.Drawing.Size(364, 73);
            this.bonusGroupBox.TabIndex = 10;
            this.bonusGroupBox.TabStop = false;
            this.bonusGroupBox.Text = "BONUS:";
            // 
            // searchLINQTextBox
            // 
            this.searchLINQTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLINQTextBox.Location = new System.Drawing.Point(6, 31);
            this.searchLINQTextBox.Name = "searchLINQTextBox";
            this.searchLINQTextBox.Size = new System.Drawing.Size(241, 22);
            this.searchLINQTextBox.TabIndex = 3;
            // 
            // searchLINQButton
            // 
            this.searchLINQButton.Location = new System.Drawing.Point(253, 16);
            this.searchLINQButton.Name = "searchLINQButton";
            this.searchLINQButton.Size = new System.Drawing.Size(105, 48);
            this.searchLINQButton.TabIndex = 1;
            this.searchLINQButton.Text = "LINQ Search For Make";
            this.searchLINQButton.UseVisualStyleBackColor = true;
            this.searchLINQButton.Click += new System.EventHandler(this.searchLINQButton_Click);
            // 
            // introGroupBox
            // 
            this.introGroupBox.Controls.Add(this.label5);
            this.introGroupBox.Controls.Add(this.label8);
            this.introGroupBox.Controls.Add(this.label7);
            this.introGroupBox.Location = new System.Drawing.Point(382, 12);
            this.introGroupBox.Name = "introGroupBox";
            this.introGroupBox.Size = new System.Drawing.Size(227, 265);
            this.introGroupBox.TabIndex = 11;
            this.introGroupBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 60);
            this.label8.TabIndex = 2;
            this.label8.Text = "To Begin Click\r\nThe \"Load File...\" Button";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 76);
            this.label7.TabIndex = 1;
            this.label7.Text = "Welcome!";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "◄══════════╝\r\n";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "Results.txt";
            this.saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            this.saveFileDialog.OverwritePrompt = false;
            this.saveFileDialog.Title = "Save Vehicles...";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Vehicles.csv";
            this.openFileDialog.Filter = "Comma-Separated Values|*.csv|All Files|*.*";
            this.openFileDialog.Title = "Open Vehicle Data...";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(388, 91);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(215, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save Results Of Make Search...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 285);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.vehicleCountLabel);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.vehicleGroupBox);
            this.Controls.Add(this.titleGroupBox);
            this.Controls.Add(this.bonusGroupBox);
            this.Controls.Add(this.introGroupBox);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Final Review Homework";
            this.vehicleGroupBox.ResumeLayout(false);
            this.vehicleGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.titleGroupBox.ResumeLayout(false);
            this.bonusGroupBox.ResumeLayout(false);
            this.bonusGroupBox.PerformLayout();
            this.introGroupBox.ResumeLayout(false);
            this.introGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox vehicleGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RadioButton modelRadioButton;
        private System.Windows.Forms.RadioButton makeRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label vehicleCountLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox titleGroupBox;
        private System.Windows.Forms.GroupBox bonusGroupBox;
        private System.Windows.Forms.Button searchLINQButton;
        private System.Windows.Forms.TextBox searchLINQTextBox;
        private System.Windows.Forms.GroupBox introGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button saveButton;
    }
}

