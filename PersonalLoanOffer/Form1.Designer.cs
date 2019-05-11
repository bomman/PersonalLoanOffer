namespace PersonalLoanOffer
{
    partial class CreditProductsForm
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
            this.clientProductsGridView = new System.Windows.Forms.DataGridView();
            this.cREDIT_PRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalLoanOfferDataSet = new PersonalLoanOffer.PersonalLoanOfferDataSet();
            this.personalLoanOfferDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cREDIT_PRODUCTTableAdapter = new PersonalLoanOffer.PersonalLoanOfferDataSetTableAdapters.CREDIT_PRODUCTTableAdapter();
            this.tableAdapterManager = new PersonalLoanOffer.PersonalLoanOfferDataSetTableAdapters.TableAdapterManager();
            this.searchLabel = new System.Windows.Forms.Label();
            this.cREDIT_PRODUCTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.sumToLabel = new System.Windows.Forms.Label();
            this.sumFromLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sumToUpDown = new System.Windows.Forms.NumericUpDown();
            this.sumFromUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.personalLoanOfferDataSet1 = new PersonalLoanOffer.PersonalLoanOfferDataSet();
            this.pRODCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODACTIVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODSUMFROMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODSUMTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODIFDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientProductsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDIT_PRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLoanOfferDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLoanOfferDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDIT_PRODUCTBindingSource1)).BeginInit();
            this.controlsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumToUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumFromUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLoanOfferDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientProductsGridView
            // 
            this.clientProductsGridView.AllowUserToOrderColumns = true;
            this.clientProductsGridView.AutoGenerateColumns = false;
            this.clientProductsGridView.BackgroundColor = System.Drawing.Color.Azure;
            this.clientProductsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clientProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRODCODEDataGridViewTextBoxColumn,
            this.pRODNAMEDataGridViewTextBoxColumn,
            this.pRODACTIVEDataGridViewTextBoxColumn,
            this.pRODSUMFROMDataGridViewTextBoxColumn,
            this.pRODSUMTODataGridViewTextBoxColumn,
            this.mODIFDATEDataGridViewTextBoxColumn});
            this.clientProductsGridView.DataSource = this.cREDIT_PRODUCTBindingSource;
            this.clientProductsGridView.Location = new System.Drawing.Point(12, 96);
            this.clientProductsGridView.Name = "clientProductsGridView";
            this.clientProductsGridView.Size = new System.Drawing.Size(784, 342);
            this.clientProductsGridView.TabIndex = 0;
            this.clientProductsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // personalLoanOfferDataSetBindingSource
            // 
            this.personalLoanOfferDataSetBindingSource.DataSource = this.personalLoanOfferDataSet;
            this.personalLoanOfferDataSetBindingSource.Position = 0;
            // 
            // cREDIT_PRODUCTTableAdapter
            // 
            this.cREDIT_PRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.CREDIT_PLANTableAdapter = null;
            this.tableAdapterManager.CREDIT_PRODUCTTableAdapter = this.cREDIT_PRODUCTTableAdapter;
            this.tableAdapterManager.CREDITTableAdapter = null;
            this.tableAdapterManager.INTERESTTableAdapter = null;
            this.tableAdapterManager.PROD_PERIODSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PersonalLoanOffer.PersonalLoanOfferDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(6, 27);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(32, 13);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Code";
            this.searchLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // cREDIT_PRODUCTBindingSource1
            // 
            this.cREDIT_PRODUCTBindingSource1.DataMember = "CREDIT_PRODUCT";
            this.cREDIT_PRODUCTBindingSource1.DataSource = this.personalLoanOfferDataSet;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(6, 43);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.calendarLabel);
            this.controlsGroupBox.Controls.Add(this.sumToLabel);
            this.controlsGroupBox.Controls.Add(this.sumFromLabel);
            this.controlsGroupBox.Controls.Add(this.nameTextBox);
            this.controlsGroupBox.Controls.Add(this.label2);
            this.controlsGroupBox.Controls.Add(this.label1);
            this.controlsGroupBox.Controls.Add(this.modifiedDateTimePicker);
            this.controlsGroupBox.Controls.Add(this.sumToUpDown);
            this.controlsGroupBox.Controls.Add(this.sumFromUpDown);
            this.controlsGroupBox.Controls.Add(this.comboBox1);
            this.controlsGroupBox.Controls.Add(this.searchTextBox);
            this.controlsGroupBox.Controls.Add(this.searchLabel);
            this.controlsGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.controlsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(798, 84);
            this.controlsGroupBox.TabIndex = 3;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Controls";
            this.controlsGroupBox.Enter += new System.EventHandler(this.controlsGroupBox_Enter);
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Location = new System.Drawing.Point(575, 27);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(73, 13);
            this.calendarLabel.TabIndex = 13;
            this.calendarLabel.Text = "Modified Date";
            // 
            // sumToLabel
            // 
            this.sumToLabel.AutoSize = true;
            this.sumToLabel.Location = new System.Drawing.Point(502, 28);
            this.sumToLabel.Name = "sumToLabel";
            this.sumToLabel.Size = new System.Drawing.Size(44, 13);
            this.sumToLabel.TabIndex = 12;
            this.sumToLabel.Text = "Sum To";
            this.sumToLabel.Click += new System.EventHandler(this.sumToLabel_Click);
            // 
            // sumFromLabel
            // 
            this.sumFromLabel.AutoSize = true;
            this.sumFromLabel.Location = new System.Drawing.Point(442, 27);
            this.sumFromLabel.Name = "sumFromLabel";
            this.sumFromLabel.Size = new System.Drawing.Size(54, 13);
            this.sumFromLabel.TabIndex = 11;
            this.sumFromLabel.Text = "Sum From";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(112, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Status";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // modifiedDateTimePicker
            // 
            this.modifiedDateTimePicker.Location = new System.Drawing.Point(578, 43);
            this.modifiedDateTimePicker.Name = "modifiedDateTimePicker";
            this.modifiedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.modifiedDateTimePicker.TabIndex = 7;
            // 
            // sumToUpDown
            // 
            this.sumToUpDown.Location = new System.Drawing.Point(505, 43);
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
            this.sumToUpDown.Size = new System.Drawing.Size(67, 20);
            this.sumToUpDown.TabIndex = 5;
            this.sumToUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // sumFromUpDown
            // 
            this.sumFromUpDown.Location = new System.Drawing.Point(445, 43);
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
            this.sumFromUpDown.Size = new System.Drawing.Size(51, 20);
            this.sumFromUpDown.TabIndex = 4;
            this.sumFromUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.comboBox1.Location = new System.Drawing.Point(318, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // personalLoanOfferDataSet1
            // 
            this.personalLoanOfferDataSet1.DataSetName = "PersonalLoanOfferDataSet";
            this.personalLoanOfferDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODCODEDataGridViewTextBoxColumn
            // 
            this.pRODCODEDataGridViewTextBoxColumn.DataPropertyName = "PROD_CODE";
            this.pRODCODEDataGridViewTextBoxColumn.HeaderText = "Product code";
            this.pRODCODEDataGridViewTextBoxColumn.Name = "pRODCODEDataGridViewTextBoxColumn";
            this.pRODCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODNAMEDataGridViewTextBoxColumn
            // 
            this.pRODNAMEDataGridViewTextBoxColumn.DataPropertyName = "PROD_NAME";
            this.pRODNAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pRODNAMEDataGridViewTextBoxColumn.Name = "pRODNAMEDataGridViewTextBoxColumn";
            // 
            // pRODACTIVEDataGridViewTextBoxColumn
            // 
            this.pRODACTIVEDataGridViewTextBoxColumn.DataPropertyName = "PROD_ACTIVE";
            this.pRODACTIVEDataGridViewTextBoxColumn.HeaderText = "Is product active";
            this.pRODACTIVEDataGridViewTextBoxColumn.Name = "pRODACTIVEDataGridViewTextBoxColumn";
            // 
            // pRODSUMFROMDataGridViewTextBoxColumn
            // 
            this.pRODSUMFROMDataGridViewTextBoxColumn.DataPropertyName = "PROD_SUM_FROM";
            this.pRODSUMFROMDataGridViewTextBoxColumn.HeaderText = "Initial sum";
            this.pRODSUMFROMDataGridViewTextBoxColumn.Name = "pRODSUMFROMDataGridViewTextBoxColumn";
            // 
            // pRODSUMTODataGridViewTextBoxColumn
            // 
            this.pRODSUMTODataGridViewTextBoxColumn.DataPropertyName = "PROD_SUM_TO";
            this.pRODSUMTODataGridViewTextBoxColumn.HeaderText = "Final Sum";
            this.pRODSUMTODataGridViewTextBoxColumn.Name = "pRODSUMTODataGridViewTextBoxColumn";
            // 
            // mODIFDATEDataGridViewTextBoxColumn
            // 
            this.mODIFDATEDataGridViewTextBoxColumn.DataPropertyName = "MODIF_DATE";
            this.mODIFDATEDataGridViewTextBoxColumn.HeaderText = "Date of change";
            this.mODIFDATEDataGridViewTextBoxColumn.Name = "mODIFDATEDataGridViewTextBoxColumn";
            // 
            // CreditProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.controlsGroupBox);
            this.Controls.Add(this.clientProductsGridView);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CreditProductsForm";
            this.Text = "Credit Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientProductsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDIT_PRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLoanOfferDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLoanOfferDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDIT_PRODUCTBindingSource1)).EndInit();
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumToUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumFromUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLoanOfferDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientProductsGridView;
        private System.Windows.Forms.BindingSource personalLoanOfferDataSetBindingSource;
        private PersonalLoanOfferDataSet personalLoanOfferDataSet;
        private System.Windows.Forms.BindingSource cREDIT_PRODUCTBindingSource;
        private PersonalLoanOfferDataSetTableAdapters.CREDIT_PRODUCTTableAdapter cREDIT_PRODUCTTableAdapter;
        private PersonalLoanOfferDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.BindingSource cREDIT_PRODUCTBindingSource1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.DateTimePicker modifiedDateTimePicker;
        private System.Windows.Forms.NumericUpDown sumToUpDown;
        private System.Windows.Forms.NumericUpDown sumFromUpDown;
        private System.Windows.Forms.ComboBox comboBox1;
        private PersonalLoanOfferDataSet personalLoanOfferDataSet1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sumToLabel;
        private System.Windows.Forms.Label sumFromLabel;
        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODACTIVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODSUMFROMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODSUMTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODIFDATEDataGridViewTextBoxColumn;
    }
}

