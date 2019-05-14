namespace PersonalLoanOffer.CreditProducts
{
    partial class DeleteCreditProduct
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
            this.label3 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sumToLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.sumToUpDown = new System.Windows.Forms.NumericUpDown();
            this.sumFromLabel = new System.Windows.Forms.Label();
            this.sumFromUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crediT_PRODUCTTableAdapter1 = new PersonalLoanOffer.PersonalLoanOfferDataSetTableAdapters.CREDIT_PRODUCTTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumToUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumFromUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(85, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Delete Credit Product";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.deleteButton.Location = new System.Drawing.Point(102, 225);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 186);
            this.groupBox1.TabIndex = 6;
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
            this.statusComboBox.Enabled = false;
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
            this.sumToUpDown.Enabled = false;
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
            this.sumFromUpDown.Enabled = false;
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
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(90, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(158, 20);
            this.nameTextBox.TabIndex = 1;
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
            // crediT_PRODUCTTableAdapter1
            // 
            this.crediT_PRODUCTTableAdapter1.ClearBeforeFill = true;
            // 
            // DeleteCreditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 258);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeleteCreditProduct";
            this.Text = "DeleteCreditProduct";
            this.Load += new System.EventHandler(this.DeleteCreditProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumToUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumFromUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sumToLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.NumericUpDown sumToUpDown;
        private System.Windows.Forms.Label sumFromLabel;
        private System.Windows.Forms.NumericUpDown sumFromUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private PersonalLoanOfferDataSetTableAdapters.CREDIT_PRODUCTTableAdapter crediT_PRODUCTTableAdapter1;
    }
}