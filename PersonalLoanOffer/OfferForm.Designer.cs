namespace PersonalLoanOffer
{
    partial class OfferForm
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
            this.components = new System.ComponentModel.Container();
            this.creditProductComboBox = new System.Windows.Forms.ComboBox();
            this.cREDIT_PRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalLoanOfferDataSet = new PersonalLoanOffer.PersonalLoanOfferDataSet();
            this.creditProductLabel = new System.Windows.Forms.Label();
            this.creditAmountLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.creditOfferGroupBox = new System.Windows.Forms.GroupBox();
            this.periodValueLabel = new System.Windows.Forms.Label();
            this.creditAmountValueLabel = new System.Windows.Forms.Label();
            this.periodTrackBar = new System.Windows.Forms.TrackBar();
            this.creditAmountTrackBar = new System.Windows.Forms.TrackBar();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.generateOfferButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.calculatePaymentButton = new System.Windows.Forms.Button();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.repaymentScheduleGroupBox = new System.Windows.Forms.GroupBox();
            this.printButton = new System.Windows.Forms.Button();
            this.repaymentScheduleGrid = new System.Windows.Forms.DataGridView();
            this.payment_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maturity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.row_sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crediT_PRODUCTTableAdapter1 = new PersonalLoanOffer.PersonalLoanOfferDataSetTableAdapters.CREDIT_PRODUCTTableAdapter();
            this.repaymentPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.clientTableAdapter1 = new PersonalLoanOffer.PersonalLoanOfferDataSetTableAdapters.CLIENTTableAdapter();
            this.saveOfferButton = new System.Windows.Forms.Button();
            this.offerTabsView = new System.Windows.Forms.TabControl();
            this.offer1Tab = new System.Windows.Forms.TabPage();
            this.offerTab2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proD_PERIODSTableAdapter = new PersonalLoanOffer.PersonalLoanOfferDataSetTableAdapters.PROD_PERIODSTableAdapter();
            this.interestTableAdapter = new PersonalLoanOffer.PersonalLoanOfferDataSetTableAdapters.INTERESTTableAdapter();
            this.creditTableAdapter = new PersonalLoanOffer.PersonalLoanOfferDataSetTableAdapters.CREDITTableAdapter();
            this.crediT_PLANTableAdapter1 = new PersonalLoanOffer.PersonalLoanOfferDataSetTableAdapters.CREDIT_PLANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cREDIT_PRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLoanOfferDataSet)).BeginInit();
            this.creditOfferGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditAmountTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.repaymentScheduleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repaymentScheduleGrid)).BeginInit();
            this.offerTabsView.SuspendLayout();
            this.offer1Tab.SuspendLayout();
            this.offerTab2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // creditProductComboBox
            // 
            this.creditProductComboBox.DataSource = this.cREDIT_PRODUCTBindingSource;
            this.creditProductComboBox.DisplayMember = "PROD_NAME";
            this.creditProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creditProductComboBox.FormattingEnabled = true;
            this.creditProductComboBox.Location = new System.Drawing.Point(117, 37);
            this.creditProductComboBox.Name = "creditProductComboBox";
            this.creditProductComboBox.Size = new System.Drawing.Size(148, 21);
            this.creditProductComboBox.TabIndex = 0;
            this.creditProductComboBox.ValueMember = "PROD_CODE";
            // 
            // cREDIT_PRODUCTBindingSource
            // 
            this.cREDIT_PRODUCTBindingSource.DataMember = "CREDIT_PRODUCT";
            this.cREDIT_PRODUCTBindingSource.DataSource = this.personalLoanOfferDataSet;
            // 
            // personalLoanOfferDataSet
            // 
            this.personalLoanOfferDataSet.DataSetName = "PersonalLoanOfferDataSet";
            this.personalLoanOfferDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // creditProductLabel
            // 
            this.creditProductLabel.AutoSize = true;
            this.creditProductLabel.Location = new System.Drawing.Point(17, 40);
            this.creditProductLabel.Name = "creditProductLabel";
            this.creditProductLabel.Size = new System.Drawing.Size(74, 13);
            this.creditProductLabel.TabIndex = 1;
            this.creditProductLabel.Text = "Credit Product";
            // 
            // creditAmountLabel
            // 
            this.creditAmountLabel.AutoSize = true;
            this.creditAmountLabel.Location = new System.Drawing.Point(17, 66);
            this.creditAmountLabel.Name = "creditAmountLabel";
            this.creditAmountLabel.Size = new System.Drawing.Size(73, 13);
            this.creditAmountLabel.TabIndex = 2;
            this.creditAmountLabel.Text = "Credit Amount";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Location = new System.Drawing.Point(20, 127);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(37, 13);
            this.periodLabel.TabIndex = 7;
            this.periodLabel.Text = "Period";
            // 
            // creditOfferGroupBox
            // 
            this.creditOfferGroupBox.Controls.Add(this.periodValueLabel);
            this.creditOfferGroupBox.Controls.Add(this.creditAmountValueLabel);
            this.creditOfferGroupBox.Controls.Add(this.periodTrackBar);
            this.creditOfferGroupBox.Controls.Add(this.creditAmountTrackBar);
            this.creditOfferGroupBox.Controls.Add(this.interestRateTextBox);
            this.creditOfferGroupBox.Controls.Add(this.generateOfferButton);
            this.creditOfferGroupBox.Controls.Add(this.groupBox1);
            this.creditOfferGroupBox.Controls.Add(this.interestRateLabel);
            this.creditOfferGroupBox.Controls.Add(this.creditProductLabel);
            this.creditOfferGroupBox.Controls.Add(this.periodLabel);
            this.creditOfferGroupBox.Controls.Add(this.creditProductComboBox);
            this.creditOfferGroupBox.Controls.Add(this.creditAmountLabel);
            this.creditOfferGroupBox.Location = new System.Drawing.Point(12, 12);
            this.creditOfferGroupBox.Name = "creditOfferGroupBox";
            this.creditOfferGroupBox.Size = new System.Drawing.Size(332, 319);
            this.creditOfferGroupBox.TabIndex = 8;
            this.creditOfferGroupBox.TabStop = false;
            this.creditOfferGroupBox.Text = "Credit Offer";
            // 
            // periodValueLabel
            // 
            this.periodValueLabel.AutoSize = true;
            this.periodValueLabel.Location = new System.Drawing.Point(275, 127);
            this.periodValueLabel.Name = "periodValueLabel";
            this.periodValueLabel.Size = new System.Drawing.Size(13, 13);
            this.periodValueLabel.TabIndex = 21;
            this.periodValueLabel.Text = "1";
            // 
            // creditAmountValueLabel
            // 
            this.creditAmountValueLabel.AutoSize = true;
            this.creditAmountValueLabel.Location = new System.Drawing.Point(272, 76);
            this.creditAmountValueLabel.Name = "creditAmountValueLabel";
            this.creditAmountValueLabel.Size = new System.Drawing.Size(25, 13);
            this.creditAmountValueLabel.TabIndex = 20;
            this.creditAmountValueLabel.Text = "100";
            // 
            // periodTrackBar
            // 
            this.periodTrackBar.Location = new System.Drawing.Point(106, 117);
            this.periodTrackBar.Name = "periodTrackBar";
            this.periodTrackBar.Size = new System.Drawing.Size(159, 45);
            this.periodTrackBar.TabIndex = 19;
            this.periodTrackBar.Scroll += new System.EventHandler(this.periodTrackBar_Scroll);
            // 
            // creditAmountTrackBar
            // 
            this.creditAmountTrackBar.Location = new System.Drawing.Point(106, 66);
            this.creditAmountTrackBar.Name = "creditAmountTrackBar";
            this.creditAmountTrackBar.Size = new System.Drawing.Size(160, 45);
            this.creditAmountTrackBar.TabIndex = 18;
            this.creditAmountTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Enabled = false;
            this.interestRateTextBox.Location = new System.Drawing.Point(106, 179);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.ReadOnly = true;
            this.interestRateTextBox.Size = new System.Drawing.Size(159, 20);
            this.interestRateTextBox.TabIndex = 17;
            this.interestRateTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // generateOfferButton
            // 
            this.generateOfferButton.BackColor = System.Drawing.Color.AliceBlue;
            this.generateOfferButton.Location = new System.Drawing.Point(132, 279);
            this.generateOfferButton.Name = "generateOfferButton";
            this.generateOfferButton.Size = new System.Drawing.Size(75, 23);
            this.generateOfferButton.TabIndex = 16;
            this.generateOfferButton.Text = "Generate Schedule";
            this.generateOfferButton.UseVisualStyleBackColor = false;
            this.generateOfferButton.Click += new System.EventHandler(this.generateOfferButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paymentLabel);
            this.groupBox1.Controls.Add(this.calculatePaymentButton);
            this.groupBox1.Controls.Add(this.paymentTextBox);
            this.groupBox1.Location = new System.Drawing.Point(20, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 53);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Location = new System.Drawing.Point(6, 26);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(48, 13);
            this.paymentLabel.TabIndex = 12;
            this.paymentLabel.Text = "Payment";
            // 
            // calculatePaymentButton
            // 
            this.calculatePaymentButton.BackColor = System.Drawing.Color.AliceBlue;
            this.calculatePaymentButton.Location = new System.Drawing.Point(218, 16);
            this.calculatePaymentButton.Name = "calculatePaymentButton";
            this.calculatePaymentButton.Size = new System.Drawing.Size(75, 23);
            this.calculatePaymentButton.TabIndex = 13;
            this.calculatePaymentButton.Text = "Calculate";
            this.calculatePaymentButton.UseVisualStyleBackColor = false;
            this.calculatePaymentButton.Click += new System.EventHandler(this.calculatePaymentButton_Click);
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Enabled = false;
            this.paymentTextBox.Location = new System.Drawing.Point(97, 19);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentTextBox.TabIndex = 14;
            this.paymentTextBox.TextChanged += new System.EventHandler(this.paymentTextBox_TextChanged);
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(17, 182);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(68, 13);
            this.interestRateLabel.TabIndex = 8;
            this.interestRateLabel.Text = "Interest Rate";
            // 
            // repaymentScheduleGroupBox
            // 
            this.repaymentScheduleGroupBox.Controls.Add(this.printButton);
            this.repaymentScheduleGroupBox.Controls.Add(this.repaymentScheduleGrid);
            this.repaymentScheduleGroupBox.Location = new System.Drawing.Point(0, 6);
            this.repaymentScheduleGroupBox.Name = "repaymentScheduleGroupBox";
            this.repaymentScheduleGroupBox.Size = new System.Drawing.Size(448, 319);
            this.repaymentScheduleGroupBox.TabIndex = 9;
            this.repaymentScheduleGroupBox.TabStop = false;
            this.repaymentScheduleGroupBox.Text = "Repayment Schedule";
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.AliceBlue;
            this.printButton.Location = new System.Drawing.Point(367, 19);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click_1);
            // 
            // repaymentScheduleGrid
            // 
            this.repaymentScheduleGrid.AllowUserToAddRows = false;
            this.repaymentScheduleGrid.AllowUserToDeleteRows = false;
            this.repaymentScheduleGrid.BackgroundColor = System.Drawing.Color.Azure;
            this.repaymentScheduleGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repaymentScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repaymentScheduleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payment_number,
            this.maturity,
            this.payment_amount,
            this.row_sum});
            this.repaymentScheduleGrid.Location = new System.Drawing.Point(0, 48);
            this.repaymentScheduleGrid.Name = "repaymentScheduleGrid";
            this.repaymentScheduleGrid.Size = new System.Drawing.Size(448, 275);
            this.repaymentScheduleGrid.TabIndex = 0;
            // 
            // payment_number
            // 
            this.payment_number.HeaderText = "Payment Number";
            this.payment_number.Name = "payment_number";
            this.payment_number.ReadOnly = true;
            // 
            // maturity
            // 
            this.maturity.HeaderText = "Maturity";
            this.maturity.Name = "maturity";
            this.maturity.ReadOnly = true;
            // 
            // payment_amount
            // 
            this.payment_amount.HeaderText = "Payment Amount";
            this.payment_amount.Name = "payment_amount";
            this.payment_amount.ReadOnly = true;
            // 
            // row_sum
            // 
            this.row_sum.HeaderText = "Sum";
            this.row_sum.Name = "row_sum";
            this.row_sum.ReadOnly = true;
            // 
            // crediT_PRODUCTTableAdapter1
            // 
            this.crediT_PRODUCTTableAdapter1.ClearBeforeFill = true;
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // saveOfferButton
            // 
            this.saveOfferButton.BackColor = System.Drawing.Color.AliceBlue;
            this.saveOfferButton.ForeColor = System.Drawing.Color.Black;
            this.saveOfferButton.Location = new System.Drawing.Point(314, 415);
            this.saveOfferButton.Name = "saveOfferButton";
            this.saveOfferButton.Size = new System.Drawing.Size(75, 23);
            this.saveOfferButton.TabIndex = 10;
            this.saveOfferButton.Text = "Save";
            this.saveOfferButton.UseVisualStyleBackColor = false;
            this.saveOfferButton.Click += new System.EventHandler(this.saveOfferButton_Click);
            // 
            // offerTabsView
            // 
            this.offerTabsView.Controls.Add(this.offer1Tab);
            this.offerTabsView.Controls.Add(this.offerTab2);
            this.offerTabsView.Location = new System.Drawing.Point(368, 12);
            this.offerTabsView.Name = "offerTabsView";
            this.offerTabsView.SelectedIndex = 0;
            this.offerTabsView.Size = new System.Drawing.Size(469, 319);
            this.offerTabsView.TabIndex = 2;
            this.offerTabsView.Visible = false;
            // 
            // offer1Tab
            // 
            this.offer1Tab.Controls.Add(this.repaymentScheduleGroupBox);
            this.offer1Tab.Location = new System.Drawing.Point(4, 22);
            this.offer1Tab.Name = "offer1Tab";
            this.offer1Tab.Padding = new System.Windows.Forms.Padding(3);
            this.offer1Tab.Size = new System.Drawing.Size(461, 293);
            this.offer1Tab.TabIndex = 0;
            this.offer1Tab.Text = "Offer 1";
            this.offer1Tab.UseVisualStyleBackColor = true;
            // 
            // offerTab2
            // 
            this.offerTab2.Controls.Add(this.groupBox2);
            this.offerTab2.Location = new System.Drawing.Point(4, 22);
            this.offerTab2.Name = "offerTab2";
            this.offerTab2.Padding = new System.Windows.Forms.Padding(3);
            this.offerTab2.Size = new System.Drawing.Size(461, 293);
            this.offerTab2.TabIndex = 1;
            this.offerTab2.Text = "Offer 2";
            this.offerTab2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(0, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 324);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Repayment Schedule";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(367, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Location = new System.Drawing.Point(0, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Payment Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Maturity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Payment Amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Sum";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // proD_PERIODSTableAdapter
            // 
            this.proD_PERIODSTableAdapter.ClearBeforeFill = true;
            // 
            // interestTableAdapter
            // 
            this.interestTableAdapter.ClearBeforeFill = true;
            // 
            // creditTableAdapter
            // 
            this.creditTableAdapter.ClearBeforeFill = true;
            // 
            // crediT_PLANTableAdapter1
            // 
            this.crediT_PLANTableAdapter1.ClearBeforeFill = true;
            // 
            // OfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.offerTabsView);
            this.Controls.Add(this.saveOfferButton);
            this.Controls.Add(this.creditOfferGroupBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "OfferForm";
            this.Text = "OfferForm";
            this.Load += new System.EventHandler(this.OfferForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cREDIT_PRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLoanOfferDataSet)).EndInit();
            this.creditOfferGroupBox.ResumeLayout(false);
            this.creditOfferGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditAmountTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.repaymentScheduleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repaymentScheduleGrid)).EndInit();
            this.offerTabsView.ResumeLayout(false);
            this.offer1Tab.ResumeLayout(false);
            this.offerTab2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox creditProductComboBox;
        private System.Windows.Forms.Label creditProductLabel;
        private System.Windows.Forms.Label creditAmountLabel;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.GroupBox creditOfferGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Button calculatePaymentButton;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Button generateOfferButton;
        private System.Windows.Forms.GroupBox repaymentScheduleGroupBox;
        private System.Windows.Forms.DataGridView repaymentScheduleGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn maturity;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn row_sum;
        private PersonalLoanOfferDataSetTableAdapters.CREDIT_PRODUCTTableAdapter crediT_PRODUCTTableAdapter1;
        private System.Windows.Forms.Button printButton;
        private System.Drawing.Printing.PrintDocument repaymentPrintDocument;
        private PersonalLoanOfferDataSetTableAdapters.CLIENTTableAdapter clientTableAdapter1;
        private System.Windows.Forms.TabControl offerTabsView;
        private System.Windows.Forms.TabPage offer1Tab;
        private System.Windows.Forms.TabPage offerTab2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        protected System.Windows.Forms.Button saveOfferButton;
        private PersonalLoanOfferDataSet personalLoanOfferDataSet;
        private System.Windows.Forms.BindingSource cREDIT_PRODUCTBindingSource;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.Label periodValueLabel;
        private System.Windows.Forms.Label creditAmountValueLabel;
        private System.Windows.Forms.TrackBar periodTrackBar;
        private System.Windows.Forms.TrackBar creditAmountTrackBar;
        private PersonalLoanOfferDataSetTableAdapters.PROD_PERIODSTableAdapter proD_PERIODSTableAdapter;
        private PersonalLoanOfferDataSetTableAdapters.INTERESTTableAdapter interestTableAdapter;
        private PersonalLoanOfferDataSetTableAdapters.CREDITTableAdapter creditTableAdapter;
        private PersonalLoanOfferDataSetTableAdapters.CREDIT_PLANTableAdapter crediT_PLANTableAdapter1;
    }
}