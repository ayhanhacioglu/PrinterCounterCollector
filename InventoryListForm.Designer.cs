namespace CounterCollector
{
    partial class InventoryListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryListForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıInventoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıDeviceLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıDeviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıIPAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıScanIntervalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıScanTimerIsActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ıIsActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ıIsDeletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ıRecordDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıSStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSOidNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSOidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVVendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRAgreementCompanyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRAgreementStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRAgreementStopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRAgreementColorPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRAgreementBWPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRIsActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cRIsDeletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cRRecordDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPInventorySelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printerCounterCollectorInventoryDataSet = new CounterCollector.PrinterCounterCollectorInventoryDataSet();
            this.sP_InventorySelectTableAdapter = new CounterCollector.PrinterCounterCollectorInventoryDataSetTableAdapters.SP_InventorySelectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPInventorySelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerCounterCollectorInventoryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıInventoryIdDataGridViewTextBoxColumn,
            this.ıDeviceLocationDataGridViewTextBoxColumn,
            this.ıDeviceNameDataGridViewTextBoxColumn,
            this.ıIPAddressDataGridViewTextBoxColumn,
            this.ıCommentDataGridViewTextBoxColumn,
            this.ıScanIntervalDataGridViewTextBoxColumn,
            this.ıScanTimerIsActiveDataGridViewCheckBoxColumn,
            this.ıIsActiveDataGridViewCheckBoxColumn,
            this.ıIsDeletedDataGridViewCheckBoxColumn,
            this.ıRecordDateTimeDataGridViewTextBoxColumn,
            this.ıSStatusDataGridViewTextBoxColumn,
            this.sSOidNameDataGridViewTextBoxColumn,
            this.sSOidDataGridViewTextBoxColumn,
            this.dTTypeDataGridViewTextBoxColumn,
            this.dMModelDataGridViewTextBoxColumn,
            this.dVVendorDataGridViewTextBoxColumn,
            this.cRAgreementCompanyNameDataGridViewTextBoxColumn,
            this.cRAgreementStartDataGridViewTextBoxColumn,
            this.cRAgreementStopDataGridViewTextBoxColumn,
            this.cuTypeDataGridViewTextBoxColumn,
            this.cRAgreementColorPriceDataGridViewTextBoxColumn,
            this.cRAgreementBWPriceDataGridViewTextBoxColumn,
            this.cRCommentDataGridViewTextBoxColumn,
            this.cRIsActiveDataGridViewCheckBoxColumn,
            this.cRIsDeletedDataGridViewCheckBoxColumn,
            this.cRRecordDateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sPInventorySelectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 110);
            this.dataGridView1.TabIndex = 0;
            // 
            // ıInventoryIdDataGridViewTextBoxColumn
            // 
            this.ıInventoryIdDataGridViewTextBoxColumn.DataPropertyName = "IInventoryId";
            this.ıInventoryIdDataGridViewTextBoxColumn.HeaderText = "IInventoryId";
            this.ıInventoryIdDataGridViewTextBoxColumn.Name = "ıInventoryIdDataGridViewTextBoxColumn";
            this.ıInventoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıDeviceLocationDataGridViewTextBoxColumn
            // 
            this.ıDeviceLocationDataGridViewTextBoxColumn.DataPropertyName = "IDeviceLocation";
            this.ıDeviceLocationDataGridViewTextBoxColumn.HeaderText = "IDeviceLocation";
            this.ıDeviceLocationDataGridViewTextBoxColumn.Name = "ıDeviceLocationDataGridViewTextBoxColumn";
            this.ıDeviceLocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıDeviceNameDataGridViewTextBoxColumn
            // 
            this.ıDeviceNameDataGridViewTextBoxColumn.DataPropertyName = "IDeviceName";
            this.ıDeviceNameDataGridViewTextBoxColumn.HeaderText = "IDeviceName";
            this.ıDeviceNameDataGridViewTextBoxColumn.Name = "ıDeviceNameDataGridViewTextBoxColumn";
            this.ıDeviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıIPAddressDataGridViewTextBoxColumn
            // 
            this.ıIPAddressDataGridViewTextBoxColumn.DataPropertyName = "IIPAddress";
            this.ıIPAddressDataGridViewTextBoxColumn.HeaderText = "IIPAddress";
            this.ıIPAddressDataGridViewTextBoxColumn.Name = "ıIPAddressDataGridViewTextBoxColumn";
            this.ıIPAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıCommentDataGridViewTextBoxColumn
            // 
            this.ıCommentDataGridViewTextBoxColumn.DataPropertyName = "IComment";
            this.ıCommentDataGridViewTextBoxColumn.HeaderText = "IComment";
            this.ıCommentDataGridViewTextBoxColumn.Name = "ıCommentDataGridViewTextBoxColumn";
            this.ıCommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıScanIntervalDataGridViewTextBoxColumn
            // 
            this.ıScanIntervalDataGridViewTextBoxColumn.DataPropertyName = "IScanInterval";
            this.ıScanIntervalDataGridViewTextBoxColumn.HeaderText = "IScanInterval";
            this.ıScanIntervalDataGridViewTextBoxColumn.Name = "ıScanIntervalDataGridViewTextBoxColumn";
            this.ıScanIntervalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıScanTimerIsActiveDataGridViewCheckBoxColumn
            // 
            this.ıScanTimerIsActiveDataGridViewCheckBoxColumn.DataPropertyName = "IScanTimerIsActive";
            this.ıScanTimerIsActiveDataGridViewCheckBoxColumn.HeaderText = "IScanTimerIsActive";
            this.ıScanTimerIsActiveDataGridViewCheckBoxColumn.Name = "ıScanTimerIsActiveDataGridViewCheckBoxColumn";
            this.ıScanTimerIsActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ıIsActiveDataGridViewCheckBoxColumn
            // 
            this.ıIsActiveDataGridViewCheckBoxColumn.DataPropertyName = "IIsActive";
            this.ıIsActiveDataGridViewCheckBoxColumn.HeaderText = "IIsActive";
            this.ıIsActiveDataGridViewCheckBoxColumn.Name = "ıIsActiveDataGridViewCheckBoxColumn";
            this.ıIsActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ıIsDeletedDataGridViewCheckBoxColumn
            // 
            this.ıIsDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IIsDeleted";
            this.ıIsDeletedDataGridViewCheckBoxColumn.HeaderText = "IIsDeleted";
            this.ıIsDeletedDataGridViewCheckBoxColumn.Name = "ıIsDeletedDataGridViewCheckBoxColumn";
            this.ıIsDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ıRecordDateTimeDataGridViewTextBoxColumn
            // 
            this.ıRecordDateTimeDataGridViewTextBoxColumn.DataPropertyName = "IRecordDateTime";
            this.ıRecordDateTimeDataGridViewTextBoxColumn.HeaderText = "IRecordDateTime";
            this.ıRecordDateTimeDataGridViewTextBoxColumn.Name = "ıRecordDateTimeDataGridViewTextBoxColumn";
            this.ıRecordDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıSStatusDataGridViewTextBoxColumn
            // 
            this.ıSStatusDataGridViewTextBoxColumn.DataPropertyName = "ISStatus";
            this.ıSStatusDataGridViewTextBoxColumn.HeaderText = "ISStatus";
            this.ıSStatusDataGridViewTextBoxColumn.Name = "ıSStatusDataGridViewTextBoxColumn";
            this.ıSStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sSOidNameDataGridViewTextBoxColumn
            // 
            this.sSOidNameDataGridViewTextBoxColumn.DataPropertyName = "SSOidName";
            this.sSOidNameDataGridViewTextBoxColumn.HeaderText = "SSOidName";
            this.sSOidNameDataGridViewTextBoxColumn.Name = "sSOidNameDataGridViewTextBoxColumn";
            this.sSOidNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sSOidDataGridViewTextBoxColumn
            // 
            this.sSOidDataGridViewTextBoxColumn.DataPropertyName = "SSOid";
            this.sSOidDataGridViewTextBoxColumn.HeaderText = "SSOid";
            this.sSOidDataGridViewTextBoxColumn.Name = "sSOidDataGridViewTextBoxColumn";
            this.sSOidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTTypeDataGridViewTextBoxColumn
            // 
            this.dTTypeDataGridViewTextBoxColumn.DataPropertyName = "DTType";
            this.dTTypeDataGridViewTextBoxColumn.HeaderText = "DTType";
            this.dTTypeDataGridViewTextBoxColumn.Name = "dTTypeDataGridViewTextBoxColumn";
            this.dTTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dMModelDataGridViewTextBoxColumn
            // 
            this.dMModelDataGridViewTextBoxColumn.DataPropertyName = "DMModel";
            this.dMModelDataGridViewTextBoxColumn.HeaderText = "DMModel";
            this.dMModelDataGridViewTextBoxColumn.Name = "dMModelDataGridViewTextBoxColumn";
            this.dMModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dVVendorDataGridViewTextBoxColumn
            // 
            this.dVVendorDataGridViewTextBoxColumn.DataPropertyName = "DVVendor";
            this.dVVendorDataGridViewTextBoxColumn.HeaderText = "DVVendor";
            this.dVVendorDataGridViewTextBoxColumn.Name = "dVVendorDataGridViewTextBoxColumn";
            this.dVVendorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRAgreementCompanyNameDataGridViewTextBoxColumn
            // 
            this.cRAgreementCompanyNameDataGridViewTextBoxColumn.DataPropertyName = "CRAgreementCompanyName";
            this.cRAgreementCompanyNameDataGridViewTextBoxColumn.HeaderText = "CRAgreementCompanyName";
            this.cRAgreementCompanyNameDataGridViewTextBoxColumn.Name = "cRAgreementCompanyNameDataGridViewTextBoxColumn";
            this.cRAgreementCompanyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRAgreementStartDataGridViewTextBoxColumn
            // 
            this.cRAgreementStartDataGridViewTextBoxColumn.DataPropertyName = "CRAgreementStart";
            this.cRAgreementStartDataGridViewTextBoxColumn.HeaderText = "CRAgreementStart";
            this.cRAgreementStartDataGridViewTextBoxColumn.Name = "cRAgreementStartDataGridViewTextBoxColumn";
            this.cRAgreementStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRAgreementStopDataGridViewTextBoxColumn
            // 
            this.cRAgreementStopDataGridViewTextBoxColumn.DataPropertyName = "CRAgreementStop";
            this.cRAgreementStopDataGridViewTextBoxColumn.HeaderText = "CRAgreementStop";
            this.cRAgreementStopDataGridViewTextBoxColumn.Name = "cRAgreementStopDataGridViewTextBoxColumn";
            this.cRAgreementStopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuTypeDataGridViewTextBoxColumn
            // 
            this.cuTypeDataGridViewTextBoxColumn.DataPropertyName = "CuType";
            this.cuTypeDataGridViewTextBoxColumn.HeaderText = "CuType";
            this.cuTypeDataGridViewTextBoxColumn.Name = "cuTypeDataGridViewTextBoxColumn";
            this.cuTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRAgreementColorPriceDataGridViewTextBoxColumn
            // 
            this.cRAgreementColorPriceDataGridViewTextBoxColumn.DataPropertyName = "CRAgreementColorPrice";
            this.cRAgreementColorPriceDataGridViewTextBoxColumn.HeaderText = "CRAgreementColorPrice";
            this.cRAgreementColorPriceDataGridViewTextBoxColumn.Name = "cRAgreementColorPriceDataGridViewTextBoxColumn";
            this.cRAgreementColorPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRAgreementBWPriceDataGridViewTextBoxColumn
            // 
            this.cRAgreementBWPriceDataGridViewTextBoxColumn.DataPropertyName = "CRAgreementBWPrice";
            this.cRAgreementBWPriceDataGridViewTextBoxColumn.HeaderText = "CRAgreementBWPrice";
            this.cRAgreementBWPriceDataGridViewTextBoxColumn.Name = "cRAgreementBWPriceDataGridViewTextBoxColumn";
            this.cRAgreementBWPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRCommentDataGridViewTextBoxColumn
            // 
            this.cRCommentDataGridViewTextBoxColumn.DataPropertyName = "CRComment";
            this.cRCommentDataGridViewTextBoxColumn.HeaderText = "CRComment";
            this.cRCommentDataGridViewTextBoxColumn.Name = "cRCommentDataGridViewTextBoxColumn";
            this.cRCommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRIsActiveDataGridViewCheckBoxColumn
            // 
            this.cRIsActiveDataGridViewCheckBoxColumn.DataPropertyName = "CRIsActive";
            this.cRIsActiveDataGridViewCheckBoxColumn.HeaderText = "CRIsActive";
            this.cRIsActiveDataGridViewCheckBoxColumn.Name = "cRIsActiveDataGridViewCheckBoxColumn";
            this.cRIsActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // cRIsDeletedDataGridViewCheckBoxColumn
            // 
            this.cRIsDeletedDataGridViewCheckBoxColumn.DataPropertyName = "CRIsDeleted";
            this.cRIsDeletedDataGridViewCheckBoxColumn.HeaderText = "CRIsDeleted";
            this.cRIsDeletedDataGridViewCheckBoxColumn.Name = "cRIsDeletedDataGridViewCheckBoxColumn";
            this.cRIsDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // cRRecordDateTimeDataGridViewTextBoxColumn
            // 
            this.cRRecordDateTimeDataGridViewTextBoxColumn.DataPropertyName = "CRRecordDateTime";
            this.cRRecordDateTimeDataGridViewTextBoxColumn.HeaderText = "CRRecordDateTime";
            this.cRRecordDateTimeDataGridViewTextBoxColumn.Name = "cRRecordDateTimeDataGridViewTextBoxColumn";
            this.cRRecordDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPInventorySelectBindingSource
            // 
            this.sPInventorySelectBindingSource.DataMember = "SP_InventorySelect";
            this.sPInventorySelectBindingSource.DataSource = this.printerCounterCollectorInventoryDataSet;
            // 
            // printerCounterCollectorInventoryDataSet
            // 
            this.printerCounterCollectorInventoryDataSet.DataSetName = "PrinterCounterCollectorInventoryDataSet";
            this.printerCounterCollectorInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_InventorySelectTableAdapter
            // 
            this.sP_InventorySelectTableAdapter.ClearBeforeFill = true;
            // 
            // InventoryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Inventory";
            this.Load += new System.EventHandler(this.InventoryListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPInventorySelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerCounterCollectorInventoryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PrinterCounterCollectorInventoryDataSet printerCounterCollectorInventoryDataSet;
        private System.Windows.Forms.BindingSource sPInventorySelectBindingSource;
        private PrinterCounterCollectorInventoryDataSetTableAdapters.SP_InventorySelectTableAdapter sP_InventorySelectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıInventoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDeviceLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDeviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıIPAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıScanIntervalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ıScanTimerIsActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ıIsActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ıIsDeletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıRecordDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıSStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSOidNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSOidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVVendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRAgreementCompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRAgreementStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRAgreementStopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRAgreementColorPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRAgreementBWPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cRIsActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cRIsDeletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRRecordDateTimeDataGridViewTextBoxColumn;
    }
}