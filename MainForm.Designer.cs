
namespace CounterCollector
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.scnstartbtn = new System.Windows.Forms.Button();
            this.scniptxt = new System.Windows.Forms.TextBox();
            this.scniplbl = new System.Windows.Forms.Label();
            this.scnip_totalcountervalutxt = new System.Windows.Forms.TextBox();
            this.scnip_totalcounterlbl = new System.Windows.Forms.Label();
            this.scnlistbox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costumOIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scnsettingscmbox = new System.Windows.Forms.ComboBox();
            this.scanSettingsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.printerCounterCollectorScanSettingsDataSet = new CounterCollector.PrinterCounterCollectorScanSettingsDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.scnclearbtn = new System.Windows.Forms.Button();
            this.scanSettingsTableAdapter = new CounterCollector.PrinterCounterCollectorScanSettingsDataSetTableAdapters.ScanSettingsTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scanSettingsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerCounterCollectorScanSettingsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // scnstartbtn
            // 
            this.scnstartbtn.Location = new System.Drawing.Point(405, 39);
            this.scnstartbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scnstartbtn.Name = "scnstartbtn";
            this.scnstartbtn.Size = new System.Drawing.Size(95, 25);
            this.scnstartbtn.TabIndex = 2;
            this.scnstartbtn.Text = "Start Scan";
            this.scnstartbtn.UseVisualStyleBackColor = true;
            this.scnstartbtn.Click += new System.EventHandler(this.scnipbtn_Click);
            // 
            // scniptxt
            // 
            this.scniptxt.AutoCompleteCustomSource.AddRange(new string[] {
            "172.16.101.216",
            "192.168.1.64"});
            this.scniptxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.scniptxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.scniptxt.Location = new System.Drawing.Point(135, 39);
            this.scniptxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scniptxt.Name = "scniptxt";
            this.scniptxt.Size = new System.Drawing.Size(227, 22);
            this.scniptxt.TabIndex = 1;
            this.scniptxt.Tag = "";
            this.scniptxt.WordWrap = false;
            // 
            // scniplbl
            // 
            this.scniplbl.AutoSize = true;
            this.scniplbl.Location = new System.Drawing.Point(15, 43);
            this.scniplbl.Name = "scniplbl";
            this.scniplbl.Size = new System.Drawing.Size(112, 17);
            this.scniplbl.TabIndex = 0;
            this.scniplbl.Text = "Scan IP Address";
            // 
            // scnip_totalcountervalutxt
            // 
            this.scnip_totalcountervalutxt.Location = new System.Drawing.Point(135, 102);
            this.scnip_totalcountervalutxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scnip_totalcountervalutxt.Name = "scnip_totalcountervalutxt";
            this.scnip_totalcountervalutxt.ReadOnly = true;
            this.scnip_totalcountervalutxt.Size = new System.Drawing.Size(227, 22);
            this.scnip_totalcountervalutxt.TabIndex = 3;
            // 
            // scnip_totalcounterlbl
            // 
            this.scnip_totalcounterlbl.AutoSize = true;
            this.scnip_totalcounterlbl.Location = new System.Drawing.Point(15, 107);
            this.scnip_totalcounterlbl.Name = "scnip_totalcounterlbl";
            this.scnip_totalcounterlbl.Size = new System.Drawing.Size(94, 17);
            this.scnip_totalcounterlbl.TabIndex = 4;
            this.scnip_totalcounterlbl.Text = "Total Counter";
            // 
            // scnlistbox
            // 
            this.scnlistbox.FormattingEnabled = true;
            this.scnlistbox.HorizontalScrollbar = true;
            this.scnlistbox.ItemHeight = 16;
            this.scnlistbox.Location = new System.Drawing.Point(16, 158);
            this.scnlistbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scnlistbox.Name = "scnlistbox";
            this.scnlistbox.ScrollAlwaysVisible = true;
            this.scnlistbox.Size = new System.Drawing.Size(483, 212);
            this.scnlistbox.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(513, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanDeviceToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // scanDeviceToolStripMenuItem
            // 
            this.scanDeviceToolStripMenuItem.Name = "scanDeviceToolStripMenuItem";
            this.scanDeviceToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.scanDeviceToolStripMenuItem.Text = "Scan Device";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem,
            this.costumOIDToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // costumOIDToolStripMenuItem
            // 
            this.costumOIDToolStripMenuItem.Name = "costumOIDToolStripMenuItem";
            this.costumOIDToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.costumOIDToolStripMenuItem.Text = "Costum OID";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // scnsettingscmbox
            // 
            this.scnsettingscmbox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.scanSettingsBindingSource1, "SSOidName", true));
            this.scnsettingscmbox.DataSource = this.scanSettingsBindingSource1;
            this.scnsettingscmbox.DisplayMember = "SSOidName";
            this.scnsettingscmbox.FormattingEnabled = true;
            this.scnsettingscmbox.Location = new System.Drawing.Point(135, 70);
            this.scnsettingscmbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scnsettingscmbox.Name = "scnsettingscmbox";
            this.scnsettingscmbox.Size = new System.Drawing.Size(227, 24);
            this.scnsettingscmbox.TabIndex = 7;
            this.scnsettingscmbox.ValueMember = "SSOid";
            // 
            // scanSettingsBindingSource1
            // 
            this.scanSettingsBindingSource1.DataMember = "ScanSettings";
            this.scanSettingsBindingSource1.DataSource = this.printerCounterCollectorScanSettingsDataSet;
            // 
            // printerCounterCollectorScanSettingsDataSet
            // 
            this.printerCounterCollectorScanSettingsDataSet.DataSetName = "PrinterCounterCollectorScanSettingsDataSet";
            this.printerCounterCollectorScanSettingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Scan Settings";
            // 
            // scnclearbtn
            // 
            this.scnclearbtn.Location = new System.Drawing.Point(405, 69);
            this.scnclearbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scnclearbtn.Name = "scnclearbtn";
            this.scnclearbtn.Size = new System.Drawing.Size(95, 25);
            this.scnclearbtn.TabIndex = 9;
            this.scnclearbtn.Text = "Clear Data";
            this.scnclearbtn.UseVisualStyleBackColor = true;
            this.scnclearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // scanSettingsTableAdapter
            // 
            this.scanSettingsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 383);
            this.Controls.Add(this.scnclearbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scnsettingscmbox);
            this.Controls.Add(this.scnlistbox);
            this.Controls.Add(this.scnip_totalcounterlbl);
            this.Controls.Add(this.scnip_totalcountervalutxt);
            this.Controls.Add(this.scniplbl);
            this.Controls.Add(this.scniptxt);
            this.Controls.Add(this.scnstartbtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printer Counter Collector v0.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scanSettingsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerCounterCollectorScanSettingsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scnstartbtn;
        private System.Windows.Forms.TextBox scniptxt;
        private System.Windows.Forms.Label scniplbl;
        private System.Windows.Forms.TextBox scnip_totalcountervalutxt;
        private System.Windows.Forms.Label scnip_totalcounterlbl;
        private System.Windows.Forms.ListBox scnlistbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costumOIDToolStripMenuItem;
        private System.Windows.Forms.ComboBox scnsettingscmbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scnclearbtn;
        private PrinterCounterCollectorScanSettingsDataSet printerCounterCollectorScanSettingsDataSet;
        private System.Windows.Forms.BindingSource scanSettingsBindingSource1;
        private PrinterCounterCollectorScanSettingsDataSetTableAdapters.ScanSettingsTableAdapter scanSettingsTableAdapter;
    }
}

