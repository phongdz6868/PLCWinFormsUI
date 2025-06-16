namespace PLCWinFormsUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtBitAddr;
        private System.Windows.Forms.TextBox txtBitResult;
        private System.Windows.Forms.TextBox txtBitWriteValue;
        private System.Windows.Forms.TextBox txtWordAddr;
        private System.Windows.Forms.TextBox txtWordResult;
        private System.Windows.Forms.TextBox txtWordWriteValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnReadBit;
        private System.Windows.Forms.Button btnWriteBit;
        private System.Windows.Forms.Button btnReadWord;
        private System.Windows.Forms.Button btnWriteWord;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtBitAddr = new System.Windows.Forms.TextBox();
            this.txtBitResult = new System.Windows.Forms.TextBox();
            this.txtBitWriteValue = new System.Windows.Forms.TextBox();
            this.txtWordAddr = new System.Windows.Forms.TextBox();
            this.txtWordResult = new System.Windows.Forms.TextBox();
            this.txtWordWriteValue = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnReadBit = new System.Windows.Forms.Button();
            this.btnWriteBit = new System.Windows.Forms.Button();
            this.btnReadWord = new System.Windows.Forms.Button();
            this.btnWriteWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBitAddr
            // 
            this.txtBitAddr.Location = new System.Drawing.Point(30, 60);
            this.txtBitAddr.Name = "txtBitAddr";
            this.txtBitAddr.Size = new System.Drawing.Size(100, 22);
            this.txtBitAddr.TabIndex = 2;
            this.txtBitAddr.Text = "M100";
            // 
            // txtBitResult
            // 
            this.txtBitResult.Location = new System.Drawing.Point(230, 60);
            this.txtBitResult.Name = "txtBitResult";
            this.txtBitResult.Size = new System.Drawing.Size(60, 22);
            this.txtBitResult.TabIndex = 4;
            // 
            // txtBitWriteValue
            // 
            this.txtBitWriteValue.Location = new System.Drawing.Point(300, 60);
            this.txtBitWriteValue.Name = "txtBitWriteValue";
            this.txtBitWriteValue.Size = new System.Drawing.Size(50, 22);
            this.txtBitWriteValue.TabIndex = 5;
            this.txtBitWriteValue.Text = "1";
            // 
            // txtWordAddr
            // 
            this.txtWordAddr.Location = new System.Drawing.Point(30, 100);
            this.txtWordAddr.Name = "txtWordAddr";
            this.txtWordAddr.Size = new System.Drawing.Size(100, 22);
            this.txtWordAddr.TabIndex = 7;
            this.txtWordAddr.Text = "D100";
            // 
            // txtWordResult
            // 
            this.txtWordResult.Location = new System.Drawing.Point(230, 100);
            this.txtWordResult.Name = "txtWordResult";
            this.txtWordResult.Size = new System.Drawing.Size(60, 22);
            this.txtWordResult.TabIndex = 9;
            // 
            // txtWordWriteValue
            // 
            this.txtWordWriteValue.Location = new System.Drawing.Point(300, 100);
            this.txtWordWriteValue.Name = "txtWordWriteValue";
            this.txtWordWriteValue.Size = new System.Drawing.Size(50, 22);
            this.txtWordWriteValue.TabIndex = 10;
            this.txtWordWriteValue.Text = "1234";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(30, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(300, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Chưa kết nối";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(350, 20);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 25);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Kết nối PLC";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnReadBit
            // 
            this.btnReadBit.Location = new System.Drawing.Point(140, 60);
            this.btnReadBit.Name = "btnReadBit";
            this.btnReadBit.Size = new System.Drawing.Size(80, 25);
            this.btnReadBit.TabIndex = 3;
            this.btnReadBit.Text = "Đọc Bit";
            this.btnReadBit.Click += new System.EventHandler(this.btnReadBit_Click);
            // 
            // btnWriteBit
            // 
            this.btnWriteBit.Location = new System.Drawing.Point(360, 60);
            this.btnWriteBit.Name = "btnWriteBit";
            this.btnWriteBit.Size = new System.Drawing.Size(90, 25);
            this.btnWriteBit.TabIndex = 6;
            this.btnWriteBit.Text = "Ghi Bit";
            this.btnWriteBit.Click += new System.EventHandler(this.btnWriteBit_Click);
            // 
            // btnReadWord
            // 
            this.btnReadWord.Location = new System.Drawing.Point(140, 100);
            this.btnReadWord.Name = "btnReadWord";
            this.btnReadWord.Size = new System.Drawing.Size(80, 25);
            this.btnReadWord.TabIndex = 8;
            this.btnReadWord.Text = "Đọc Word";
            this.btnReadWord.Click += new System.EventHandler(this.btnReadWord_Click);
            // 
            // btnWriteWord
            // 
            this.btnWriteWord.Location = new System.Drawing.Point(360, 100);
            this.btnWriteWord.Name = "btnWriteWord";
            this.btnWriteWord.Size = new System.Drawing.Size(90, 25);
            this.btnWriteWord.TabIndex = 11;
            this.btnWriteWord.Text = "Ghi Word";
            this.btnWriteWord.Click += new System.EventHandler(this.btnWriteWord_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 160);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtBitAddr);
            this.Controls.Add(this.btnReadBit);
            this.Controls.Add(this.txtBitResult);
            this.Controls.Add(this.txtBitWriteValue);
            this.Controls.Add(this.btnWriteBit);
            this.Controls.Add(this.txtWordAddr);
            this.Controls.Add(this.btnReadWord);
            this.Controls.Add(this.txtWordResult);
            this.Controls.Add(this.txtWordWriteValue);
            this.Controls.Add(this.btnWriteWord);
            this.Name = "MainForm";
            this.Text = "PLC Mitsubishi TCP - Demo Giao Diện";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
