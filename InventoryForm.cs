using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterCollector
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            FormClosing += InventoryForm_FormClosing;
        }

        private void InventoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Visible = true;
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printerCounterCollectorInventoryDataSet.SP_InventorySelect' table. You can move, or remove it, as needed.
            this.sP_InventorySelectTableAdapter.Fill(this.printerCounterCollectorInventoryDataSet.SP_InventorySelect);
            // TODO: This line of code loads data into the 'printerCounterCollectorDataSetInventory.SP_InventorySelect' table. You can move, or remove it, as needed.
            this.sP_InventorySelectTableAdapter.Fill(this.printerCounterCollectorInventoryDataSet.SP_InventorySelect);
            textBox1.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IInventoryId).LastOrDefault().ToString();
            textBox2.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IDeviceName).LastOrDefault().ToString();
            textBox4.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IIPAddress).LastOrDefault().ToString();
            textBox5.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.SSOidName).LastOrDefault().ToString();
            textBox6.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.SSOid).LastOrDefault().ToString();
            comboBox1.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IDeviceLocation).LastOrDefault();
            comboBox2.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.DVVendor).LastOrDefault().ToString();
            comboBox3.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.DTType).LastOrDefault().ToString();
            comboBox4.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.DMModel).LastOrDefault().ToString();
            comboBox5.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.ISStatus).LastOrDefault().ToString();
            textBox10.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.CRAgreementCompanyName).LastOrDefault().ToString();
            dateTimePicker1.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.CRAgreementStart).LastOrDefault().ToString("d");
            dateTimePicker2.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.CRAgreementStop).LastOrDefault().ToString("d");
            textBox14.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IComment).LastOrDefault().ToString();
            textBox15.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IScanInterval).LastOrDefault().ToString();
            textBox16.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.CuType).LastOrDefault().ToString();
            textBox17.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.CRAgreementBWPrice).LastOrDefault().ToString();
            textBox18.Text = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.CRAgreementColorPrice).LastOrDefault().ToString();
            checkBox1.Checked = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IScanTimerIsActive).LastOrDefault();
            checkBox2.Checked = printerCounterCollectorInventoryDataSet.SP_InventorySelect.Select(k => k.IIsActive).LastOrDefault();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
