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
            this.printerCounterCollectorInventoryGetDataSet = new CounterCollector.PrinterCounterCollectorInventoryGetDataSet();
            this.sP_InventoryGetTableAdapter = new PrinterCounterCollectorInventoryGetDataSetTableAdapters.SP_InventoryGetTableAdapter();

            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
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
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ıInventoryIdDataGridViewTextBoxColumn
            // 
            this.ıInventoryIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ıInventoryIdDataGridViewTextBoxColumn.DataPropertyName = "IInventoryId";
            this.ıInventoryIdDataGridViewTextBoxColumn.HeaderText = "Device ID";
            this.ıInventoryIdDataGridViewTextBoxColumn.Name = "ıInventoryIdDataGridViewTextBoxColumn";
            this.ıInventoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıInventoryIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ıInventoryIdDataGridViewTextBoxColumn.Width = 74;
            // 
            // ıDeviceLocationDataGridViewTextBoxColumn
            // 
            this.ıDeviceLocationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ıDeviceLocationDataGridViewTextBoxColumn.DataPropertyName = "IDeviceLocation";
            this.ıDeviceLocationDataGridViewTextBoxColumn.HeaderText = "Device Location";
            this.ıDeviceLocationDataGridViewTextBoxColumn.Name = "ıDeviceLocationDataGridViewTextBoxColumn";
            this.ıDeviceLocationDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDeviceLocationDataGridViewTextBoxColumn.Width = 101;
            // 
            // ıDeviceNameDataGridViewTextBoxColumn
            // 
            this.ıDeviceNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ıDeviceNameDataGridViewTextBoxColumn.DataPropertyName = "IDeviceName";
            this.ıDeviceNameDataGridViewTextBoxColumn.HeaderText = "Device Name";
            this.ıDeviceNameDataGridViewTextBoxColumn.Name = "ıDeviceNameDataGridViewTextBoxColumn";
            this.ıDeviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDeviceNameDataGridViewTextBoxColumn.Width = 89;
            // 
            // ıIPAddressDataGridViewTextBoxColumn
            // 
            this.ıIPAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ıIPAddressDataGridViewTextBoxColumn.DataPropertyName = "IIPAddress";
            this.ıIPAddressDataGridViewTextBoxColumn.HeaderText = "Device IP Address";
            this.ıIPAddressDataGridViewTextBoxColumn.Name = "ıIPAddressDataGridViewTextBoxColumn";
            this.ıIPAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıIPAddressDataGridViewTextBoxColumn.Width = 110;
            // 
            // ıCommentDataGridViewTextBoxColumn
            // 
            this.ıCommentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ıCommentDataGridViewTextBoxColumn.DataPropertyName = "IComment";
            this.ıCommentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.ıCommentDataGridViewTextBoxColumn.Name = "ıCommentDataGridViewTextBoxColumn";
            this.ıCommentDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıCommentDataGridViewTextBoxColumn.Width = 76;
            // 
            // ıScanIntervalDataGridViewTextBoxColumn
            // 
            this.ıScanIntervalDataGridViewTextBoxColumn.DataPropertyName = "IScanInterval";
            this.ıScanIntervalDataGridViewTextBoxColumn.HeaderText = "IScanInterval";
            this.ıScanIntervalDataGridViewTextBoxColumn.Name = "ıScanIntervalDataGridViewTextBoxColumn";
            this.ıScanIntervalDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıScanIntervalDataGridViewTextBoxColumn.Visible = false;
            // 
            // ıScanTimerIsActiveDataGridViewCheckBoxColumn
            // 
            this.ıScanTimerIsActiveDataGridViewCheckBoxColumn.DataPropertyName = "IScanTimerIsActive";
            this.ıScanTimerIsActiveDataGridViewCheckBoxColumn.HeaderText = "IScanTimerIsActive";
            this.ıScanTimerIsActiveDataGridViewCheckBoxColumn.Name = "ıScanTimerIsActiveDataGridViewCheckBoxColumn";
            this.ıScanTimerIsActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ıScanTimerIsActiveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // ıIsActiveDataGridViewCheckBoxColumn
            // 
            this.ıIsActiveDataGridViewCheckBoxColumn.DataPropertyName = "IIsActive";
            this.ıIsActiveDataGridViewCheckBoxColumn.HeaderText = "IIsActive";
            this.ıIsActiveDataGridViewCheckBoxColumn.Name = "ıIsActiveDataGridViewCheckBoxColumn";
            this.ıIsActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ıIsActiveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // ıIsDeletedDataGridViewCheckBoxColumn
            // 
            this.ıIsDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IIsDeleted";
            this.ıIsDeletedDataGridViewCheckBoxColumn.HeaderText = "IIsDeleted";
            this.ıIsDeletedDataGridViewCheckBoxColumn.Name = "ıIsDeletedDataGridViewCheckBoxColumn";
            this.ıIsDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ıIsDeletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // ıRecordDateTimeDataGridViewTextBoxColumn
            // 
            this.ıRecordDateTimeDataGridViewTextBoxColumn.DataPropertyName = "IRecordDateTime";
            this.ıRecordDateTimeDataGridViewTextBoxColumn.HeaderText = "IRecordDateTime";
            this.ıRecordDateTimeDataGridViewTextBoxColumn.Name = "ıRecordDateTimeDataGridViewTextBoxColumn";
            this.ıRecordDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıRecordDateTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // ıSStatusDataGridViewTextBoxColumn
            // 
            this.ıSStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ıSStatusDataGridViewTextBoxColumn.DataPropertyName = "ISStatus";
            this.ıSStatusDataGridViewTextBoxColumn.HeaderText = "Device Status";
            this.ıSStatusDataGridViewTextBoxColumn.Name = "ıSStatusDataGridViewTextBoxColumn";
            this.ıSStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıSStatusDataGridViewTextBoxColumn.Width = 91;
            // 
            // sSOidNameDataGridViewTextBoxColumn
            // 
            this.sSOidNameDataGridViewTextBoxColumn.DataPropertyName = "SSOidName";
            this.sSOidNameDataGridViewTextBoxColumn.HeaderText = "SSOidName";
            this.sSOidNameDataGridViewTextBoxColumn.Name = "sSOidNameDataGridViewTextBoxColumn";
            this.sSOidNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sSOidNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // sSOidDataGridViewTextBoxColumn
            // 
            this.sSOidDataGridViewTextBoxColumn.DataPropertyName = "SSOid";
            this.sSOidDataGridViewTextBoxColumn.HeaderText = "SSOid";
            this.sSOidDataGridViewTextBoxColumn.Name = "sSOidDataGridViewTextBoxColumn";
            this.sSOidDataGridViewTextBoxColumn.ReadOnly = true;
            this.sSOidDataGridViewTextBoxColumn.Visible = false;
            // 
            // dTTypeDataGridViewTextBoxColumn
            // 
            this.dTTypeDataGridViewTextBoxColumn.DataPropertyName = "DTType";
            this.dTTypeDataGridViewTextBoxColumn.HeaderText = "DTType";
            this.dTTypeDataGridViewTextBoxColumn.Name = "dTTypeDataGridViewTextBoxColumn";
            this.dTTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dTTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // dMModelDataGridViewTextBoxColumn
            // 
            this.dMModelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dMModelDataGridViewTextBoxColumn.DataPropertyName = "DMModel";
            this.dMModelDataGridViewTextBoxColumn.HeaderText = "Device Model";
            this.dMModelDataGridViewTextBoxColumn.Name = "dMModelDataGridViewTextBoxColumn";
            this.dMModelDataGridViewTextBoxColumn.ReadOnly = true;
            this.dMModelDataGridViewTextBoxColumn.Width = 90;
            // 
            // dVVendorDataGridViewTextBoxColumn
            // 
            this.dVVendorDataGridViewTextBoxColumn.DataPropertyName = "DVVendor";
            this.dVVendorDataGridViewTextBoxColumn.HeaderText = "Device Vendor";
            this.dVVendorDataGridViewTextBoxColumn.Name = "dVVendorDataGridViewTextBoxColumn";
            this.dVVendorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRAgreementCompanyNameDataGridViewTextBoxColumn
            // 
            this.cRAgreementCompanyNameDataGridViewTextBoxColumn.DataPropertyName = "CRAgreementCompanyName";
            this.cRAgreementCompanyNameDataGridViewTextBoxColumn.HeaderText = "CRAgreementCompanyName";
            this.cRAgreementCompanyNameDataGridViewTextBoxColumn.Name = "cRAgreementCompanyNameDataGridViewTextBoxColumn";
            this.cRAgreementCompanyNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cRAgreementCompanyNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // cRAgreementStartDataGridViewTextBoxColumn
            // 
            this.cRAgreementStartDataGridViewTextBoxColumn.DataPropertyName = "CRAgreementStart";
            this.cRAgreementStartDataGridViewTextBoxColumn.HeaderText = "CRAgreementStart";
            this.cRAgreementStartDataGridViewTextBoxColumn.Name = "cRAgreementStartDataGridViewTextBoxColumn";
            this.cRAgreementStartDataGridViewTextBoxColumn.ReadOnly = true;
            this.cRAgreementStartDataGridViewTextBoxColumn.Visible = false;
            // 
            // cRAgreementStopDataGridViewTextBoxColumn
            // 
            this.cRAgreementStopDataGridViewTextBoxColumn.DataPropertyName = "CRAgreementStop";
            this.cRAgreementStopDataGridViewTextBoxColumn.HeaderText = "CRAgreementStop";
            this.cRAgreementStopDataGridViewTextBoxColumn.Name = "cRAgreementStopDataGridViewTextBoxColumn";
            this.cRAgreementStopDataGridViewTextBoxColumn.ReadOnly = true;
            this.cRAgreementStopDataGridViewTextBoxColumn.Visible = false;
            // 
            // cuTypeDataGridViewTextBoxColumn
            // 
            this.cuTypeDataGridViewTextBoxColumn.DataPropertyName = "CuType";
            this.cuTypeDataGridViewTextBoxColumn.HeaderText = "CuType";
            this.cuTypeDataGridViewTextBoxColumn.Name = "cuTypeDataGridViewTextBoxColumn";
            this.cuTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // cRAgreementColorPriceDataGridViewTextBoxColumn
            // 
            this.cRAgreementColorPriceDataGridViewTextBoxColumn.DataPropertyName = "CRAgreementColorPrice";
            this.cRAgreementColorPriceDataGridViewTextBoxColumn.HeaderText = "CRAgreementColorPrice";
            this.cRAgreementColorPriceDataGridViewTextBoxColumn.Name = "cRAgreementColorPriceDataGridViewTextBoxColumn";
            this.cRAgreementColorPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.cRAgreementColorPriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // cRAgreementBWPriceDataGridViewTextBoxColumn
            // 
            this.cRAgreementBWPriceDataGridViewTextBoxColumn.DataPropertyName = "CRAgreementBWPrice";
            this.cRAgreementBWPriceDataGridViewTextBoxColumn.HeaderText = "CRAgreementBWPrice";
            this.cRAgreementBWPriceDataGridViewTextBoxColumn.Name = "cRAgreementBWPriceDataGridViewTextBoxColumn";
            this.cRAgreementBWPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.cRAgreementBWPriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // cRCommentDataGridViewTextBoxColumn
            // 
            this.cRCommentDataGridViewTextBoxColumn.DataPropertyName = "CRComment";
            this.cRCommentDataGridViewTextBoxColumn.HeaderText = "CRComment";
            this.cRCommentDataGridViewTextBoxColumn.Name = "cRCommentDataGridViewTextBoxColumn";
            this.cRCommentDataGridViewTextBoxColumn.ReadOnly = true;
            this.cRCommentDataGridViewTextBoxColumn.Visible = false;
            // 
            // cRIsActiveDataGridViewCheckBoxColumn
            // 
            this.cRIsActiveDataGridViewCheckBoxColumn.DataPropertyName = "CRIsActive";
            this.cRIsActiveDataGridViewCheckBoxColumn.HeaderText = "CRIsActive";
            this.cRIsActiveDataGridViewCheckBoxColumn.Name = "cRIsActiveDataGridViewCheckBoxColumn";
            this.cRIsActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.cRIsActiveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // cRIsDeletedDataGridViewCheckBoxColumn
            // 
            this.cRIsDeletedDataGridViewCheckBoxColumn.DataPropertyName = "CRIsDeleted";
            this.cRIsDeletedDataGridViewCheckBoxColumn.HeaderText = "CRIsDeleted";
            this.cRIsDeletedDataGridViewCheckBoxColumn.Name = "cRIsDeletedDataGridViewCheckBoxColumn";
            this.cRIsDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.cRIsDeletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // cRRecordDateTimeDataGridViewTextBoxColumn
            // 
            this.cRRecordDateTimeDataGridViewTextBoxColumn.DataPropertyName = "CRRecordDateTime";
            this.cRRecordDateTimeDataGridViewTextBoxColumn.HeaderText = "CRRecordDateTime";
            this.cRRecordDateTimeDataGridViewTextBoxColumn.Name = "cRRecordDateTimeDataGridViewTextBoxColumn";
            this.cRRecordDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cRRecordDateTimeDataGridViewTextBoxColumn.Visible = false;
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
        private PrinterCounterCollectorInventoryDataSet printerCounterCollectorInventoryDataSet;
        private PrinterCounterCollectorInventoryGetDataSet printerCounterCollectorInventoryGetDataSet;
        private System.Windows.Forms.BindingSource sPInventorySelectBindingSource;
        private PrinterCounterCollectorInventoryDataSetTableAdapters.SP_InventorySelectTableAdapter sP_InventorySelectTableAdapter;
        private PrinterCounterCollectorInventoryGetDataSetTableAdapters.SP_InventoryGetTableAdapter sP_InventoryGetTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
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