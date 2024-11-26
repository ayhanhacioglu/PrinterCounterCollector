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
    public partial class InventoryListForm : Form
    {
        public InventoryListForm()
        {
            InitializeComponent();
            FormClosing += InventoryListForm_Closing;
                
        }

        private void InventoryListForm_Closing (object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Visible = true;
        }

        private void InventoryListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printerCounterCollectorInventoryDataSet.SP_InventorySelect' table. You can move, or remove it, as needed.
            this.sP_InventorySelectTableAdapter.Fill(this.printerCounterCollectorInventoryDataSet.SP_InventorySelect);

        }
    }
}
