﻿namespace PersonalLoanOffer.CreditProducts
{
    partial class AddCreditProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sumToLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.sumToUpDown = new System.Windows.Forms.NumericUpDown();
            this.sumFromLabel = new System.Windows.Forms.Label();
            this.sumFromUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumToUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumFromUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.sumToLabel);
            this.groupBox1.Controls.Add(this.statusComboBox);
            this.groupBox1.Controls.Add(this.sumToUpDown);
            this.groupBox1.Controls.Add(this.sumFromLabel);
            this.groupBox1.Controls.Add(this.sumFromUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sumToLabel
            // 
            this.sumToLabel.AutoSize = true;
            this.sumToLabel.Location = new System.Drawing.Point(7, 142);
            this.sumToLabel.Name = "sumToLabel";
            this.sumToLabel.Size = new System.Drawing.Size(44, 13);
            this.sumToLabel.TabIndex = 16;
            this.sumToLabel.Text = "Sum To";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.statusComboBox.Location = new System.Drawing.Point(90, 56);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(158, 21);
            this.statusComboBox.TabIndex = 10;
            // 
            // sumToUpDown
            // 
            this.sumToUpDown.Location = new System.Drawing.Point(90, 142);
            this.sumToUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sumToUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sumToUpDown.Name = "sumToUpDown";
            this.sumToUpDown.Size = new System.Drawing.Size(158, 20);
            this.sumToUpDown.TabIndex = 14;
            this.sumToUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // sumFromLabel
            // 
            this.sumFromLabel.AutoSize = true;
            this.sumFromLabel.Location = new System.Drawing.Point(7, 100);
            this.sumFromLabel.Name = "sumFromLabel";
            this.sumFromLabel.Size = new System.Drawing.Size(54, 13);
            this.sumFromLabel.TabIndex = 15;
            this.sumFromLabel.Text = "Sum From";
            // 
            // sumFromUpDown
            // 
            this.sumFromUpDown.Location = new System.Drawing.Point(90, 100);
            this.sumFromUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sumFromUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sumFromUpDown.Name = "sumFromUpDown";
            this.sumFromUpDown.Size = new System.Drawing.Size(158, 20);
            this.sumFromUpDown.TabIndex = 13;
            this.sumFromUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.createButton.Location = new System.Drawing.Point(115, 221);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Add";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(85, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add Credit Product";
            // 
            // AddCreditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 258);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddCreditProduct";
            this.Text = "AddCreditProduct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumToUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumFromUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label sumToLabel;
        private System.Windows.Forms.NumericUpDown sumToUpDown;
        private System.Windows.Forms.Label sumFromLabel;
        private System.Windows.Forms.NumericUpDown sumFromUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label3;
    }
}