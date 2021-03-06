﻿namespace PersonalLoanOffer
{
    partial class OfferList
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
            this.personalLoanOfferDataSet = new PersonalLoanOffer.PersonalLoanOfferDataSet();
            this.personalLoanOfferDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cREDITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cREDITTableAdapter = new PersonalLoanOffer.PersonalLoanOfferDataSetTableAdapters.CREDITTableAdapter();
            this.tableAdapterManager = new PersonalLoanOffer.PersonalLoanOfferDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cREDITIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREDITNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREDITDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREDITPERIODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREDITENDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREDITBEGINDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREDITSUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREDITNOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODIFDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.offerNumberLabel = new System.Windows.Forms.Label();
            this.offerNumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.creditSumLabel = new System.Windows.Forms.Label();
            this.creditAmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.interestRateUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.personalLoanOfferDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLoanOfferDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.controlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offerNumberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditAmountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestRateUpDown)).BeginInit();
            this.SuspendLayout();
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
            // cREDITBindingSource
            // 
            this.cREDITBindingSource.DataMember = "CREDIT";
            this.cREDITBindingSource.DataSource = this.personalLoanOfferDataSet;
            // 
            // cREDITTableAdapter
            // 
            this.cREDITTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.CREDIT_PLANTableAdapter = null;
            this.tableAdapterManager.CREDIT_PRODUCTTableAdapter = null;
            this.tableAdapterManager.CREDITTableAdapter = this.cREDITTableAdapter;
            this.tableAdapterManager.INTERESTTableAdapter = null;
            this.tableAdapterManager.PROD_PERIODSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PersonalLoanOffer.PersonalLoanOfferDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cREDITIDDataGridViewTextBoxColumn,
            this.cREDITNODataGridViewTextBoxColumn,
            this.cREDITDATEDataGridViewTextBoxColumn,
            this.cREDITPERIODDataGridViewTextBoxColumn,
            this.cREDITENDDATEDataGridViewTextBoxColumn,
            this.cREDITBEGINDATEDataGridViewTextBoxColumn,
            this.cLIENTIDDataGridViewTextBoxColumn,
            this.pRODCODEDataGridViewTextBoxColumn,
            this.cREDITSUMDataGridViewTextBoxColumn,
            this.cREDITNOTEDataGridViewTextBoxColumn,
            this.mODIFDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cREDITBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cREDITIDDataGridViewTextBoxColumn
            // 
            this.cREDITIDDataGridViewTextBoxColumn.DataPropertyName = "CREDIT_ID";
            this.cREDITIDDataGridViewTextBoxColumn.HeaderText = "CREDIT_ID";
            this.cREDITIDDataGridViewTextBoxColumn.Name = "cREDITIDDataGridViewTextBoxColumn";
            this.cREDITIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cREDITNODataGridViewTextBoxColumn
            // 
            this.cREDITNODataGridViewTextBoxColumn.DataPropertyName = "CREDIT_NO";
            this.cREDITNODataGridViewTextBoxColumn.HeaderText = "CREDIT_NO";
            this.cREDITNODataGridViewTextBoxColumn.Name = "cREDITNODataGridViewTextBoxColumn";
            // 
            // cREDITDATEDataGridViewTextBoxColumn
            // 
            this.cREDITDATEDataGridViewTextBoxColumn.DataPropertyName = "CREDIT_DATE";
            this.cREDITDATEDataGridViewTextBoxColumn.HeaderText = "CREDIT_DATE";
            this.cREDITDATEDataGridViewTextBoxColumn.Name = "cREDITDATEDataGridViewTextBoxColumn";
            // 
            // cREDITPERIODDataGridViewTextBoxColumn
            // 
            this.cREDITPERIODDataGridViewTextBoxColumn.DataPropertyName = "CREDIT_PERIOD";
            this.cREDITPERIODDataGridViewTextBoxColumn.HeaderText = "CREDIT_PERIOD";
            this.cREDITPERIODDataGridViewTextBoxColumn.Name = "cREDITPERIODDataGridViewTextBoxColumn";
            // 
            // cREDITENDDATEDataGridViewTextBoxColumn
            // 
            this.cREDITENDDATEDataGridViewTextBoxColumn.DataPropertyName = "CREDIT_END_DATE";
            this.cREDITENDDATEDataGridViewTextBoxColumn.HeaderText = "CREDIT_END_DATE";
            this.cREDITENDDATEDataGridViewTextBoxColumn.Name = "cREDITENDDATEDataGridViewTextBoxColumn";
            // 
            // cREDITBEGINDATEDataGridViewTextBoxColumn
            // 
            this.cREDITBEGINDATEDataGridViewTextBoxColumn.DataPropertyName = "CREDIT_BEGIN_DATE";
            this.cREDITBEGINDATEDataGridViewTextBoxColumn.HeaderText = "CREDIT_BEGIN_DATE";
            this.cREDITBEGINDATEDataGridViewTextBoxColumn.Name = "cREDITBEGINDATEDataGridViewTextBoxColumn";
            // 
            // cLIENTIDDataGridViewTextBoxColumn
            // 
            this.cLIENTIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.HeaderText = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.Name = "cLIENTIDDataGridViewTextBoxColumn";
            // 
            // pRODCODEDataGridViewTextBoxColumn
            // 
            this.pRODCODEDataGridViewTextBoxColumn.DataPropertyName = "PROD_CODE";
            this.pRODCODEDataGridViewTextBoxColumn.HeaderText = "PROD_CODE";
            this.pRODCODEDataGridViewTextBoxColumn.Name = "pRODCODEDataGridViewTextBoxColumn";
            // 
            // cREDITSUMDataGridViewTextBoxColumn
            // 
            this.cREDITSUMDataGridViewTextBoxColumn.DataPropertyName = "CREDIT_SUM";
            this.cREDITSUMDataGridViewTextBoxColumn.HeaderText = "CREDIT_SUM";
            this.cREDITSUMDataGridViewTextBoxColumn.Name = "cREDITSUMDataGridViewTextBoxColumn";
            // 
            // cREDITNOTEDataGridViewTextBoxColumn
            // 
            this.cREDITNOTEDataGridViewTextBoxColumn.DataPropertyName = "CREDIT_NOTE";
            this.cREDITNOTEDataGridViewTextBoxColumn.HeaderText = "CREDIT_NOTE";
            this.cREDITNOTEDataGridViewTextBoxColumn.Name = "cREDITNOTEDataGridViewTextBoxColumn";
            // 
            // mODIFDATEDataGridViewTextBoxColumn
            // 
            this.mODIFDATEDataGridViewTextBoxColumn.DataPropertyName = "MODIF_DATE";
            this.mODIFDATEDataGridViewTextBoxColumn.HeaderText = "MODIF_DATE";
            this.mODIFDATEDataGridViewTextBoxColumn.Name = "mODIFDATEDataGridViewTextBoxColumn";
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.interestRateUpDown);
            this.controlGroupBox.Controls.Add(this.searchButton);
            this.controlGroupBox.Controls.Add(this.interestRateLabel);
            this.controlGroupBox.Controls.Add(this.endDateLabel);
            this.controlGroupBox.Controls.Add(this.startDateLabel);
            this.controlGroupBox.Controls.Add(this.dateTimePicker2);
            this.controlGroupBox.Controls.Add(this.dateTimePicker1);
            this.controlGroupBox.Controls.Add(this.creditAmountUpDown);
            this.controlGroupBox.Controls.Add(this.creditSumLabel);
            this.controlGroupBox.Controls.Add(this.textBox1);
            this.controlGroupBox.Controls.Add(this.descriptionLabel);
            this.controlGroupBox.Controls.Add(this.offerNumberUpDown);
            this.controlGroupBox.Controls.Add(this.offerNumberLabel);
            this.controlGroupBox.Location = new System.Drawing.Point(13, 13);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(621, 131);
            this.controlGroupBox.TabIndex = 1;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Controls";
            // 
            // offerNumberLabel
            // 
            this.offerNumberLabel.AutoSize = true;
            this.offerNumberLabel.Location = new System.Drawing.Point(7, 21);
            this.offerNumberLabel.Name = "offerNumberLabel";
            this.offerNumberLabel.Size = new System.Drawing.Size(70, 13);
            this.offerNumberLabel.TabIndex = 1;
            this.offerNumberLabel.Text = "Offer Number";
            this.offerNumberLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // offerNumberUpDown
            // 
            this.offerNumberUpDown.Location = new System.Drawing.Point(10, 38);
            this.offerNumberUpDown.Name = "offerNumberUpDown";
            this.offerNumberUpDown.Size = new System.Drawing.Size(120, 20);
            this.offerNumberUpDown.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(169, 20);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            this.descriptionLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 4;
            // 
            // creditSumLabel
            // 
            this.creditSumLabel.AutoSize = true;
            this.creditSumLabel.Location = new System.Drawing.Point(305, 21);
            this.creditSumLabel.Name = "creditSumLabel";
            this.creditSumLabel.Size = new System.Drawing.Size(73, 13);
            this.creditSumLabel.TabIndex = 5;
            this.creditSumLabel.Text = "Credit Amount";
            this.creditSumLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // creditAmountUpDown
            // 
            this.creditAmountUpDown.Location = new System.Drawing.Point(308, 38);
            this.creditAmountUpDown.Name = "creditAmountUpDown";
            this.creditAmountUpDown.Size = new System.Drawing.Size(120, 20);
            this.creditAmountUpDown.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(185, 105);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(10, 86);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(55, 13);
            this.startDateLabel.TabIndex = 9;
            this.startDateLabel.Text = "Start Date";
            this.startDateLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(185, 86);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(52, 13);
            this.endDateLabel.TabIndex = 10;
            this.endDateLabel.Text = "End Date";
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(469, 21);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(68, 13);
            this.interestRateLabel.TabIndex = 11;
            this.interestRateLabel.Text = "Interest Rate";
            this.interestRateLabel.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(472, 102);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(110, 23);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // interestRateUpDown
            // 
            this.interestRateUpDown.Location = new System.Drawing.Point(472, 38);
            this.interestRateUpDown.Name = "interestRateUpDown";
            this.interestRateUpDown.Size = new System.Drawing.Size(120, 20);
            this.interestRateUpDown.TabIndex = 14;
            // 
            // OfferList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OfferList";
            this.Text = "OfferList";
            this.Load += new System.EventHandler(this.OfferList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalLoanOfferDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLoanOfferDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cREDITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.controlGroupBox.ResumeLayout(false);
            this.controlGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offerNumberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditAmountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestRateUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource personalLoanOfferDataSetBindingSource;
        private PersonalLoanOfferDataSet personalLoanOfferDataSet;
        private System.Windows.Forms.BindingSource cREDITBindingSource;
        private PersonalLoanOfferDataSetTableAdapters.CREDITTableAdapter cREDITTableAdapter;
        private PersonalLoanOfferDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREDITIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREDITNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREDITDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREDITPERIODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREDITENDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREDITBEGINDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREDITSUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREDITNOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODIFDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.Label offerNumberLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.NumericUpDown offerNumberUpDown;
        private System.Windows.Forms.Label creditSumLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown creditAmountUpDown;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.NumericUpDown interestRateUpDown;
    }
}