namespace Class_HW
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newBankButton = new System.Windows.Forms.Button();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.bankNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.customerBankButton = new System.Windows.Forms.Button();
            this.custAccountTextBox = new System.Windows.Forms.TextBox();
            this.locTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.displayBankButton = new System.Windows.Forms.Button();
            this.displayCustomerButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newBankButton);
            this.groupBox1.Controls.Add(this.locationTextBox);
            this.groupBox1.Controls.Add(this.bankNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Branch:";
            // 
            // newBankButton
            // 
            this.newBankButton.Location = new System.Drawing.Point(6, 70);
            this.newBankButton.Name = "newBankButton";
            this.newBankButton.Size = new System.Drawing.Size(163, 25);
            this.newBankButton.TabIndex = 4;
            this.newBankButton.Text = "Create Branch";
            this.newBankButton.UseVisualStyleBackColor = true;
            this.newBankButton.Click += new System.EventHandler(this.newBankButton_Click);
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(67, 44);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(102, 20);
            this.locationTextBox.TabIndex = 3;
            // 
            // bankNameTextBox
            // 
            this.bankNameTextBox.Location = new System.Drawing.Point(67, 18);
            this.bankNameTextBox.Name = "bankNameTextBox";
            this.bankNameTextBox.Size = new System.Drawing.Size(102, 20);
            this.bankNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addCustomerButton);
            this.groupBox2.Controls.Add(this.depositTextBox);
            this.groupBox2.Controls.Add(this.customerNameTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 104);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer:";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(9, 73);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(160, 23);
            this.addCustomerButton.TabIndex = 4;
            this.addCustomerButton.Text = "Create Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(67, 47);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(102, 20);
            this.depositTextBox.TabIndex = 3;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(67, 19);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(102, 20);
            this.customerNameTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Account:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.locTextBox);
            this.groupBox3.Controls.Add(this.customerBankButton);
            this.groupBox3.Controls.Add(this.custAccountTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bank:";
            // 
            // customerBankButton
            // 
            this.customerBankButton.Location = new System.Drawing.Point(9, 71);
            this.customerBankButton.Name = "customerBankButton";
            this.customerBankButton.Size = new System.Drawing.Size(160, 23);
            this.customerBankButton.TabIndex = 4;
            this.customerBankButton.Text = "Add Customer to Bank";
            this.customerBankButton.UseVisualStyleBackColor = true;
            this.customerBankButton.Click += new System.EventHandler(this.customerBankButton_Click);
            // 
            // custAccountTextBox
            // 
            this.custAccountTextBox.Location = new System.Drawing.Point(67, 19);
            this.custAccountTextBox.Name = "custAccountTextBox";
            this.custAccountTextBox.Size = new System.Drawing.Size(102, 20);
            this.custAccountTextBox.TabIndex = 4;
            // 
            // locTextBox
            // 
            this.locTextBox.Location = new System.Drawing.Point(67, 45);
            this.locTextBox.Name = "locTextBox";
            this.locTextBox.Size = new System.Drawing.Size(102, 20);
            this.locTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Account:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Location:";
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.Location = new System.Drawing.Point(195, 19);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(237, 264);
            this.displayListBox.TabIndex = 4;
            // 
            // displayBankButton
            // 
            this.displayBankButton.Location = new System.Drawing.Point(195, 289);
            this.displayBankButton.Name = "displayBankButton";
            this.displayBankButton.Size = new System.Drawing.Size(75, 41);
            this.displayBankButton.TabIndex = 5;
            this.displayBankButton.Text = "Display Bank";
            this.displayBankButton.UseVisualStyleBackColor = true;
            this.displayBankButton.Click += new System.EventHandler(this.displayBankButton_Click);
            // 
            // displayCustomerButton
            // 
            this.displayCustomerButton.Location = new System.Drawing.Point(276, 289);
            this.displayCustomerButton.Name = "displayCustomerButton";
            this.displayCustomerButton.Size = new System.Drawing.Size(75, 41);
            this.displayCustomerButton.TabIndex = 6;
            this.displayCustomerButton.Text = "Display Customer";
            this.displayCustomerButton.UseVisualStyleBackColor = true;
            this.displayCustomerButton.Click += new System.EventHandler(this.displayCustomerButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(357, 289);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 41);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 342);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.displayCustomerButton);
            this.Controls.Add(this.displayBankButton);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Class-HW";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button newBankButton;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox bankNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox locTextBox;
        private System.Windows.Forms.Button customerBankButton;
        private System.Windows.Forms.TextBox custAccountTextBox;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.Button displayBankButton;
        private System.Windows.Forms.Button displayCustomerButton;
        private System.Windows.Forms.Button saveButton;
    }
}

