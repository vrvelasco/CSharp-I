namespace Array_RevHW
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openButton = new System.Windows.Forms.Button();
            this.integerArrayListBox = new System.Windows.Forms.ListBox();
            this.wordsArrayListBox = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.savePictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.convertPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loopPictureBox = new System.Windows.Forms.PictureBox();
            this.readPictureBox = new System.Windows.Forms.PictureBox();
            this.displayPictureBox = new System.Windows.Forms.PictureBox();
            this.openPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.correctPictureBox = new System.Windows.Forms.PictureBox();
            this.wrongPictureBox = new System.Windows.Forms.PictureBox();
            this.defaultPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convertPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Numbers";
            this.openFileDialog.Filter = "Text Files|*.txt";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(10, 120);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(196, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open File And Process...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // integerArrayListBox
            // 
            this.integerArrayListBox.FormattingEnabled = true;
            this.integerArrayListBox.Location = new System.Drawing.Point(10, 19);
            this.integerArrayListBox.Name = "integerArrayListBox";
            this.integerArrayListBox.Size = new System.Drawing.Size(95, 95);
            this.integerArrayListBox.TabIndex = 1;
            // 
            // wordsArrayListBox
            // 
            this.wordsArrayListBox.FormattingEnabled = true;
            this.wordsArrayListBox.Location = new System.Drawing.Point(111, 19);
            this.wordsArrayListBox.Name = "wordsArrayListBox";
            this.wordsArrayListBox.Size = new System.Drawing.Size(95, 95);
            this.wordsArrayListBox.TabIndex = 2;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Results";
            this.saveFileDialog1.Filter = "Text Files|*.txt";
            this.saveFileDialog1.OverwritePrompt = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.integerArrayListBox);
            this.groupBox1.Controls.Add(this.openButton);
            this.groupBox1.Controls.Add(this.wordsArrayListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.savePictureBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.convertPictureBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.loopPictureBox);
            this.groupBox2.Controls.Add(this.readPictureBox);
            this.groupBox2.Controls.Add(this.displayPictureBox);
            this.groupBox2.Controls.Add(this.openPictureBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 205);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // savePictureBox
            // 
            this.savePictureBox.Location = new System.Drawing.Point(10, 169);
            this.savePictureBox.Name = "savePictureBox";
            this.savePictureBox.Size = new System.Drawing.Size(24, 24);
            this.savePictureBox.TabIndex = 11;
            this.savePictureBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Save File";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // convertPictureBox
            // 
            this.convertPictureBox.Location = new System.Drawing.Point(10, 139);
            this.convertPictureBox.Name = "convertPictureBox";
            this.convertPictureBox.Size = new System.Drawing.Size(24, 24);
            this.convertPictureBox.TabIndex = 9;
            this.convertPictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Convert Integers To Words";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loopPictureBox
            // 
            this.loopPictureBox.Location = new System.Drawing.Point(10, 109);
            this.loopPictureBox.Name = "loopPictureBox";
            this.loopPictureBox.Size = new System.Drawing.Size(24, 24);
            this.loopPictureBox.TabIndex = 7;
            this.loopPictureBox.TabStop = false;
            // 
            // readPictureBox
            // 
            this.readPictureBox.Location = new System.Drawing.Point(10, 49);
            this.readPictureBox.Name = "readPictureBox";
            this.readPictureBox.Size = new System.Drawing.Size(24, 24);
            this.readPictureBox.TabIndex = 6;
            this.readPictureBox.TabStop = false;
            // 
            // displayPictureBox
            // 
            this.displayPictureBox.Location = new System.Drawing.Point(10, 79);
            this.displayPictureBox.Name = "displayPictureBox";
            this.displayPictureBox.Size = new System.Drawing.Size(24, 24);
            this.displayPictureBox.TabIndex = 5;
            this.displayPictureBox.TabStop = false;
            // 
            // openPictureBox
            // 
            this.openPictureBox.Location = new System.Drawing.Point(10, 19);
            this.openPictureBox.Name = "openPictureBox";
            this.openPictureBox.Size = new System.Drawing.Size(24, 24);
            this.openPictureBox.TabIndex = 4;
            this.openPictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loop Through Array";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Display Integers";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Read";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Opened";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // correctPictureBox
            // 
            this.correctPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("correctPictureBox.Image")));
            this.correctPictureBox.Location = new System.Drawing.Point(26, 49);
            this.correctPictureBox.Name = "correctPictureBox";
            this.correctPictureBox.Size = new System.Drawing.Size(24, 24);
            this.correctPictureBox.TabIndex = 8;
            this.correctPictureBox.TabStop = false;
            // 
            // wrongPictureBox
            // 
            this.wrongPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("wrongPictureBox.Image")));
            this.wrongPictureBox.Location = new System.Drawing.Point(26, 19);
            this.wrongPictureBox.Name = "wrongPictureBox";
            this.wrongPictureBox.Size = new System.Drawing.Size(24, 24);
            this.wrongPictureBox.TabIndex = 9;
            this.wrongPictureBox.TabStop = false;
            // 
            // defaultPictureBox
            // 
            this.defaultPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("defaultPictureBox.Image")));
            this.defaultPictureBox.Location = new System.Drawing.Point(26, 79);
            this.defaultPictureBox.Name = "defaultPictureBox";
            this.defaultPictureBox.Size = new System.Drawing.Size(24, 24);
            this.defaultPictureBox.TabIndex = 10;
            this.defaultPictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.wrongPictureBox);
            this.groupBox3.Controls.Add(this.defaultPictureBox);
            this.groupBox3.Controls.Add(this.correctPictureBox);
            this.groupBox3.Location = new System.Drawing.Point(410, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(77, 113);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "- HIDDEN -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 393);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Array-RevHW";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.savePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convertPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrongPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ListBox integerArrayListBox;
        private System.Windows.Forms.ListBox wordsArrayListBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox convertPictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox loopPictureBox;
        private System.Windows.Forms.PictureBox readPictureBox;
        private System.Windows.Forms.PictureBox displayPictureBox;
        private System.Windows.Forms.PictureBox openPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox savePictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox correctPictureBox;
        private System.Windows.Forms.PictureBox wrongPictureBox;
        private System.Windows.Forms.PictureBox defaultPictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

