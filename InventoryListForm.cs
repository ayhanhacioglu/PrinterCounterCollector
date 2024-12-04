using CounterCollector.PrinterCounterCollectorInventoryDataSetTableAdapters;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils.Extensions;
using DevExpress.XtraExport.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CounterCollector.PrinterCounterCollectorInventoryGetDataSetTableAdapters;

namespace CounterCollector
{
    public partial class InventoryListForm : Form
    {
        public InventoryListForm()
        {
            InitializeComponent();
            FormClosing += InventoryListForm_Closing;
                
        }
        
        private void InventoryListForm_Closing (object sender, EventArgs e)
        {
            //if ()
            //{

            //}
            MainForm mainForm = new MainForm();
            mainForm.Visible = true;
        }

        private void InventoryListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printerCounterCollectorInventoryDataSet.SP_InventorySelect' table. You can move, or remove it, as needed.
            this.sP_InventorySelectTableAdapter.Fill(this.printerCounterCollectorInventoryDataSet.SP_InventorySelect);
            

        }

        private void dataGridView1_SelectedIndexChange(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            string a = row.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            int deviceid = Convert.ToInt32(row.Cells[0].Value);
            var result = this.printerCounterCollectorInventoryGetDataSet.SP_InventoryGet.Where(x => x.IInventoryId == deviceid);

            //printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IInventoryId = deviceid);

            InventoryDetailForm inventoryDetailForm = new InventoryDetailForm();
            //var result2 = PrinterCounterCollectorInventoryGetDataSet.SP_InventoryGet.Where(x => x.IInventoryId == deviceid).ToList();
            //textBox2.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IDeviceName).LastOrDefault().ToString();
            //textBox4.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IIPAddress).LastOrDefault().ToString();
            //textBox5.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.SSOidName).LastOrDefault().ToString();
            //textBox6.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.SSOid).LastOrDefault().ToString();
            //comboBox1.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IDeviceLocation).LastOrDefault();
            //comboBox2.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.DVVendor).LastOrDefault().ToString();
            //comboBox3.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.DTType).LastOrDefault().ToString();
            //comboBox4.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.DMModel).LastOrDefault().ToString();
            //comboBox5.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.ISStatus).LastOrDefault().ToString();
            //textBox10.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.CRAgreementCompanyName).LastOrDefault().ToString();
            //dateTimePicker1.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.CRAgreementStart).LastOrDefault().ToString("d");
            //dateTimePicker2.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.CRAgreementStop).LastOrDefault().ToString("d");
            //textBox14.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IComment).LastOrDefault().ToString();
            //textBox15.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IScanInterval).LastOrDefault().ToString();
            //textBox16.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.CuType).LastOrDefault().ToString();
            //textBox17.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.CRAgreementBWPrice).LastOrDefault().ToString();
            //textBox18.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.CRAgreementColorPrice).LastOrDefault().ToString();
            //checkBox1.Checked = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IScanTimerIsActive).LastOrDefault();
            //checkBox2.Checked = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IIsActive).LastOrDefault();


            inventoryDetailForm.Show();
            




            //inventoryForm.sP_InventorySelectTableAdapter.Fill(this.printerCounterCollectorInventoryDataSet.SP_InventorySelect);
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter )
            {
                InventoryDetailForm inventoryForm = new InventoryDetailForm();
                inventoryForm.Show();
            }
            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_InventoryGetTableAdapter.Fill(this.printerCounterCollectorInventoryGetDataSet.SP_InventoryGet, new System.Nullable<int>(((int)(System.Convert.ChangeType(iNVENTORYIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
