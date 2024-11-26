using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Lextm.SharpSnmpLib;
using Lextm.SharpSnmpLib.Messaging;
using Lextm.SharpSnmpLib.Mib;
using Lextm.SharpSnmpLib.Objects;
using Lextm.SharpSnmpLib.Pipeline;
using Lextm.SharpSnmpLib.Security;

namespace CounterCollector
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printerCounterCollectorScanSettingsDataSet.ScanSettings' table. You can move, or remove it, as needed.
            this.scanSettingsTableAdapter.Fill(this.printerCounterCollectorScanSettingsDataSet.ScanSettings);

        }

        private void scnipbtn_Click(object sender, EventArgs e)
        {
            if (scniptxt.Text.Length == 0)
            {
                MessageBox.Show("Lütfen Geçerli Bir IP Adresi Giriniz", "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var TotalCounter = Messenger.Get(VersionCode.V1,
                              new IPEndPoint(IPAddress.Parse(scniptxt.Text), 161),
                              new OctetString("public"),
                              //new List<Variable> { new Variable(new ObjectIdentifier("1.3.6.1.2.1.43.10.2")) },
                              new List<Variable> { new Variable(new ObjectIdentifier(scnsettingscmbox.SelectedValue.ToString())) },
                              //new List<Variable> { new Variable(new ObjectIdentifier("1.3.6.1.4.1.367.3.2.1.2.19.1.0")) },
                              60000);
                var TotalCounterValue = TotalCounter.Select(k => k.Data).FirstOrDefault().ToString();
                scnip_totalcountervalutxt.Text = TotalCounterValue;

                //var onetimegetresult = Messenger.Get(VersionCode.V1,
                //              new IPEndPoint(IPAddress.Parse(scniptxt.Text), 161),
                //              new OctetString("public"),
                //              new List<Variable> { new Variable(new ObjectIdentifier("1.3.6.1.4.1.367.3.2.1.2.19.4.0")) },
                //              60000);
                //listBox1.DataSource = onetimegetresult;

                //SNMP WALK
                var walkresult = new List<Variable>();
                Messenger.Walk(VersionCode.V1,
                               new IPEndPoint(IPAddress.Parse(scniptxt.Text), 161),
                               new OctetString("public"),
                               //new ObjectIdentifier("1.3.6.1.2.1.1"),
                               //çok özel durum subsidiary references single level
                               //new ObjectIdentifier("1.3.6.1.2.1.1"), //Generic printerler
                               //new ObjectIdentifier("1.3.6.1.2.1.43.10.2"), //generic counter test
                               new ObjectIdentifier("1.3.6.1.4.1.367.3.2.1.1"), // RicohSys info calisiyor
                               //new ObjectIdentifier("1.3.6.1.4.1.367.3.2.1.2.19"), // RicohEng large counter info calisiyor
                               walkresult,
                               60000,
                               WalkMode.WithinSubtree);
                scnlistbox.DataSource = walkresult;

                // GET-NEXT Operation
                //GetNextRequestMessage message = new GetNextRequestMessage(0,
                //              VersionCode.V1,
                //              new OctetString("public"),
                //              new List<Variable> { new Variable(new ObjectIdentifier("1.3.6.1.2.1.1.6.0")) });
                //ISnmpMessage response = message.GetResponse(60000, new IPEndPoint(IPAddress.Parse(scniptxt.Text), 161));

                ////if (response.Pdu().ErrorStatus.ToInt32() != 0)
                ////{
                ////    throw ErrorException.Create(
                ////        "error in response",
                ////        receiver.Address,
                ////        response);
                ////}

                //var result = response.Pdu().Variables;
                //listBox1.DataSource = result;

                // GET-BULK Operation
                //GetBulkRequestMessage message = new GetBulkRequestMessage(0,
                //      VersionCode.V2,
                //      new OctetString("public"),
                //      0,
                //      10,
                //      new List<Variable> { new Variable(new ObjectIdentifier("1.3.6.1.2.1.1.6.0")) });
                //ISnmpMessage response = message.GetResponse(60000, new IPEndPoint(IPAddress.Parse(scniptxt.Text), 161));

                ////if (response.Pdu().ErrorStatus.ToInt32() != 0)
                ////{
                ////    throw ErrorException.Create(
                ////        "error in response",
                ////        receiver.Address,
                ////        response);
                ////}

                //var result = response.Pdu().Variables;
                //listBox1.DataSource = result;

                // TRAP Operation - No Answer
                //var walkresult = new List<Variable>();
                //Messenger.SendTrapV1(new IPEndPoint(IPAddress.Parse(scniptxt.Text), 162),
                //     IPAddress.Parse(scniptxt.Text),
                //     new OctetString("public"),
                //     new ObjectIdentifier("1.3.6.1.2.1.1"),
                //     GenericCode.ColdStart,
                //     0,
                //     0,
                //     walkresult);
                //listBox1.DataSource = walkresult;

                //INFORM Operation
                //Messenger.SendInform(0,
                //     VersionCode.V2,
                //     new IPEndPoint(IPAddress.Parse(scniptxt.Text), 162),
                //     new OctetString("public"),
                //     new ObjectIdentifier("1.3.6.1.2.1.1"),
                //     0,
                //     new List<Variable>(),
                //     2000,
                //     null,
                //     null);

            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            scnip_totalcountervalutxt.Text = null;
            scnlistbox.DataSource = null;
            scniptxt.Text = null;
            scnsettingscmbox.Text = default;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //InventoryForm inventoryForm = new InventoryForm();
            //this.Visible = false;
            //inventoryForm.Show();
            
            InventoryListForm ınventoryListForm= new InventoryListForm();
            this.Visible = false;
            ınventoryListForm.Show();

        }
    }
}
