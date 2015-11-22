namespace BLTransfusion.View
{
    partial class SerialPortSetForm
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
            if (serialPortSet.IsOpen)
            {
                serialPortSet.Close();
            }
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbSerial = new System.Windows.Forms.ComboBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbRcvStr = new System.Windows.Forms.RadioButton();
            this.rbRcv16 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbSendStr = new System.Windows.Forms.RadioButton();
            this.rbSend16 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtRcv = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.serialPortSet = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cbSerial);
            this.groupBox1.Controls.Add(this.btnSwitch);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口：";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(208, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbSerial
            // 
            this.cbSerial.FormattingEnabled = true;
            this.cbSerial.Location = new System.Drawing.Point(64, 21);
            this.cbSerial.Name = "cbSerial";
            this.cbSerial.Size = new System.Drawing.Size(56, 20);
            this.cbSerial.TabIndex = 0;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(138, 19);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(64, 23);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "打开串口";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbParity);
            this.groupBox2.Controls.Add(this.cbStop);
            this.groupBox2.Controls.Add(this.cbDataBits);
            this.groupBox2.Controls.Add(this.cbBaudRate);
            this.groupBox2.Location = new System.Drawing.Point(17, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 77);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "串口设置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "校验位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "停止位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.cbParity.Location = new System.Drawing.Point(212, 46);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(56, 20);
            this.cbParity.TabIndex = 0;
            // 
            // cbStop
            // 
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "1.5"});
            this.cbStop.Location = new System.Drawing.Point(60, 46);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(56, 20);
            this.cbStop.TabIndex = 0;
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(212, 20);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(56, 20);
            this.cbDataBits.TabIndex = 0;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(60, 20);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(56, 20);
            this.cbBaudRate.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbRcvStr);
            this.groupBox4.Controls.Add(this.rbRcv16);
            this.groupBox4.Location = new System.Drawing.Point(177, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(131, 50);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收数据格式";
            // 
            // rbRcvStr
            // 
            this.rbRcvStr.AutoSize = true;
            this.rbRcvStr.Location = new System.Drawing.Point(66, 20);
            this.rbRcvStr.Name = "rbRcvStr";
            this.rbRcvStr.Size = new System.Drawing.Size(59, 16);
            this.rbRcvStr.TabIndex = 0;
            this.rbRcvStr.TabStop = true;
            this.rbRcvStr.Text = "字符串";
            this.rbRcvStr.UseVisualStyleBackColor = true;
            // 
            // rbRcv16
            // 
            this.rbRcv16.AutoSize = true;
            this.rbRcv16.Location = new System.Drawing.Point(6, 20);
            this.rbRcv16.Name = "rbRcv16";
            this.rbRcv16.Size = new System.Drawing.Size(59, 16);
            this.rbRcv16.TabIndex = 0;
            this.rbRcv16.TabStop = true;
            this.rbRcv16.Text = "16进制";
            this.rbRcv16.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbSendStr);
            this.groupBox3.Controls.Add(this.rbSend16);
            this.groupBox3.Location = new System.Drawing.Point(17, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 50);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送数据格式";
            // 
            // rbSendStr
            // 
            this.rbSendStr.AutoSize = true;
            this.rbSendStr.Location = new System.Drawing.Point(65, 20);
            this.rbSendStr.Name = "rbSendStr";
            this.rbSendStr.Size = new System.Drawing.Size(59, 16);
            this.rbSendStr.TabIndex = 0;
            this.rbSendStr.TabStop = true;
            this.rbSendStr.Text = "字符串";
            this.rbSendStr.UseVisualStyleBackColor = true;
            // 
            // rbSend16
            // 
            this.rbSend16.AutoSize = true;
            this.rbSend16.Location = new System.Drawing.Point(6, 20);
            this.rbSend16.Name = "rbSend16";
            this.rbSend16.Size = new System.Drawing.Size(59, 16);
            this.rbSend16.TabIndex = 0;
            this.rbSend16.TabStop = true;
            this.rbSend16.Text = "16进制";
            this.rbSend16.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "发送数据：";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(221, 267);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(17, 239);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(291, 21);
            this.txtSend.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtRcv);
            this.groupBox5.Location = new System.Drawing.Point(332, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(298, 248);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "接收数据";
            // 
            // txtRcv
            // 
            this.txtRcv.Location = new System.Drawing.Point(9, 17);
            this.txtRcv.Multiline = true;
            this.txtRcv.Name = "txtRcv";
            this.txtRcv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRcv.Size = new System.Drawing.Size(279, 225);
            this.txtRcv.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(556, 266);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SerialPortSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 305);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SerialPortSetForm";
            this.Text = "串口设定";
            this.Load += new System.EventHandler(this.SerialPortSetForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbSerial;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbRcvStr;
        private System.Windows.Forms.RadioButton rbRcv16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbSendStr;
        private System.Windows.Forms.RadioButton rbSend16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtRcv;
        private System.Windows.Forms.Button btnClear;
        private System.IO.Ports.SerialPort serialPortSet;
    }
}