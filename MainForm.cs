using SLMPTcp;
using System;
using System.Windows.Forms;

namespace PLCWinFormsUI
{
    public partial class MainForm : Form
    {
        private SLMPClient plc;

        public MainForm()
        {
            InitializeComponent();
         
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            plc = new SLMPClient("192.168.9.99", 12234);
            plc.BitMode = 16;
            plc.Connect();

            if (plc.IsConnected)
                lblStatus.Text = "Status: Connected";
            else
                lblStatus.Text = "Status: Failed - " + plc.ErrMessage;
        }

        private void btnReadBit_Click(object sender, EventArgs e)
        {
            bool success;
            int value = plc.ReadBit(txtBitAddr.Text, out success);
            txtBitResult.Text = success ? value.ToString() : "Lỗi";
        }

        private void btnWriteBit_Click(object sender, EventArgs e)
        {
            int data = int.TryParse(txtBitWriteValue.Text, out data) ? data : 0;
            bool result = plc.WriteBit(txtBitAddr.Text, data);
            MessageBox.Show(result ? "Ghi thành công" : "Ghi thất bại");
        }

        private void btnReadWord_Click(object sender, EventArgs e)
        {
            bool success;
            int value = plc.ReadWord(txtWordAddr.Text, out success);
            txtWordResult.Text = success ? value.ToString() : "Lỗi";
        }

        private void btnWriteWord_Click(object sender, EventArgs e)
        {
            int data = int.TryParse(txtWordWriteValue.Text, out data) ? data : 0;
            bool result = plc.WriteInt(txtWordAddr.Text, data);
            MessageBox.Show(result ? "Ghi thành công" : "Ghi thất bại");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
