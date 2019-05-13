namespace PersonalLoanOffer.CreditProducts
{
    partial class EditCreditProduct
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
            this.editButton = new System.Windows.Forms.Button();
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
            this.personalLoanOfferDataSet1 = new PersonalLoanOffer.PersonalLoanOfferDataSet();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumToUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumFromUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLoanOfferDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(85, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edit Credit Product";
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.editButton.Location = new System.Drawing.Point(102, 226);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 186);
            this.groupBox1.TabIndex = 3;
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
            // nameTextBox
            // 
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
            // personalLoanOfferDataSet1
            // 
            this.personalLoanOfferDataSet1.DataSetName = "PersonalLoanOfferDataSet";
            this.personalLoanOfferDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EditCreditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditCreditProduct";
            this.Text = "EditCreditProduct";
            this.Load += new System.EventHandler(this.EditCreditProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumToUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumFromUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLoanOfferDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editButton;
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
        private PersonalLoanOfferDataSet personalLoanOfferDataSet1;
    }
}