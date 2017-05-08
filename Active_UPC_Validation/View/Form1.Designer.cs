namespace Active_UPC_Validation
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
            this.startButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.importButton = new System.Windows.Forms.Button();
            this.importStoreBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.importBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outputFolderButton = new System.Windows.Forms.Button();
            this.outputFolderBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.itemMovementBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.regPriceBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.catalogBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(469, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(125, 25);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(469, 44);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(125, 25);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update Pricing Sheets";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.importButton);
            this.groupBox1.Controls.Add(this.importStoreBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.importBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import Sheet";
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(352, 25);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 4;
            this.importButton.Text = "Browse...";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // importStoreBox
            // 
            this.importStoreBox.Location = new System.Drawing.Point(96, 53);
            this.importStoreBox.Name = "importStoreBox";
            this.importStoreBox.ReadOnly = true;
            this.importStoreBox.Size = new System.Drawing.Size(250, 20);
            this.importStoreBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Store:";
            // 
            // importBox
            // 
            this.importBox.Location = new System.Drawing.Point(96, 27);
            this.importBox.Name = "importBox";
            this.importBox.ReadOnly = true;
            this.importBox.Size = new System.Drawing.Size(250, 20);
            this.importBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Active Sheet:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputFolderButton);
            this.groupBox2.Controls.Add(this.outputFolderBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.outputBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Sheet";
            // 
            // outputFolderButton
            // 
            this.outputFolderButton.Location = new System.Drawing.Point(352, 46);
            this.outputFolderButton.Name = "outputFolderButton";
            this.outputFolderButton.Size = new System.Drawing.Size(75, 23);
            this.outputFolderButton.TabIndex = 8;
            this.outputFolderButton.Text = "Browse...";
            this.outputFolderButton.UseVisualStyleBackColor = true;
            this.outputFolderButton.Click += new System.EventHandler(this.outputFolderButton_Click);
            // 
            // outputFolderBox
            // 
            this.outputFolderBox.Location = new System.Drawing.Point(96, 48);
            this.outputFolderBox.Name = "outputFolderBox";
            this.outputFolderBox.ReadOnly = true;
            this.outputFolderBox.Size = new System.Drawing.Size(250, 20);
            this.outputFolderBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Folder:";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(96, 22);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(250, 20);
            this.outputBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Output Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.itemMovementBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.regPriceBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.catalogBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(13, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 121);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pricing Reference Sheets";
            // 
            // itemMovementBox
            // 
            this.itemMovementBox.Location = new System.Drawing.Point(96, 74);
            this.itemMovementBox.Name = "itemMovementBox";
            this.itemMovementBox.ReadOnly = true;
            this.itemMovementBox.Size = new System.Drawing.Size(250, 20);
            this.itemMovementBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Item Movement:";
            // 
            // regPriceBox
            // 
            this.regPriceBox.Location = new System.Drawing.Point(96, 48);
            this.regPriceBox.Name = "regPriceBox";
            this.regPriceBox.ReadOnly = true;
            this.regPriceBox.Size = new System.Drawing.Size(250, 20);
            this.regPriceBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Reg. Price:";
            // 
            // catalogBox
            // 
            this.catalogBox.Location = new System.Drawing.Point(96, 22);
            this.catalogBox.Name = "catalogBox";
            this.catalogBox.ReadOnly = true;
            this.catalogBox.Size = new System.Drawing.Size(250, 20);
            this.catalogBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Catalog:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(469, 323);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(125, 25);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 360);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Active UPC Validation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox importStoreBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox importBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox outputFolderBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox itemMovementBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox regPriceBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox catalogBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button outputFolderButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

