namespace BLTransfusion
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
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.bnStart = new System.Windows.Forms.Button();
            this.bnSettings = new System.Windows.Forms.Button();
            this.bnSnapShot = new System.Windows.Forms.Button();
            this.bnImageProc = new System.Windows.Forms.Button();
            this.LbCameraStatus = new System.Windows.Forms.Label();
            this.tBQualifiedCnt = new System.Windows.Forms.TextBox();
            this.tBUnqualifiedCnt = new System.Windows.Forms.TextBox();
            this.tBTotalCnt = new System.Windows.Forms.TextBox();
            this.LbQualifiedCnt = new System.Windows.Forms.Label();
            this.LbUnqualifiedCnt = new System.Windows.Forms.Label();
            this.LbTotalCnt = new System.Windows.Forms.Label();
            this.pB_Image = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_Send = new System.Windows.Forms.Button();
            this.CameraSnapTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDevices
            // 
            this.cmbDevices.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(67, 14);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(193, 20);
            this.cmbDevices.TabIndex = 1;
            this.cmbDevices.SelectedIndexChanged += new System.EventHandler(this.cmbDevices_SelectedIndexChanged);
            // 
            // bnStart
            // 
            this.bnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bnStart.AutoSize = true;
            this.bnStart.Location = new System.Drawing.Point(295, 9);
            this.bnStart.Name = "bnStart";
            this.bnStart.Size = new System.Drawing.Size(78, 28);
            this.bnStart.TabIndex = 2;
            this.bnStart.Text = "开始";
            this.bnStart.UseVisualStyleBackColor = true;
            this.bnStart.Click += new System.EventHandler(this.bnStart_Click);
            // 
            // bnSettings
            // 
            this.bnSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bnSettings.Location = new System.Drawing.Point(379, 9);
            this.bnSettings.Name = "bnSettings";
            this.bnSettings.Size = new System.Drawing.Size(78, 28);
            this.bnSettings.TabIndex = 2;
            this.bnSettings.Text = "设置";
            this.bnSettings.UseVisualStyleBackColor = true;
            this.bnSettings.Click += new System.EventHandler(this.bnSettings_Click);
            // 
            // bnSnapShot
            // 
            this.bnSnapShot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bnSnapShot.Location = new System.Drawing.Point(472, 9);
            this.bnSnapShot.Name = "bnSnapShot";
            this.bnSnapShot.Size = new System.Drawing.Size(78, 28);
            this.bnSnapShot.TabIndex = 2;
            this.bnSnapShot.Text = "拍摄";
            this.bnSnapShot.UseVisualStyleBackColor = true;
            this.bnSnapShot.Click += new System.EventHandler(this.bnSnapShot_Click);
            // 
            // bnImageProc
            // 
            this.bnImageProc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bnImageProc.Location = new System.Drawing.Point(556, 9);
            this.bnImageProc.Name = "bnImageProc";
            this.bnImageProc.Size = new System.Drawing.Size(78, 28);
            this.bnImageProc.TabIndex = 2;
            this.bnImageProc.Text = "图像处理";
            this.bnImageProc.UseVisualStyleBackColor = true;
            this.bnImageProc.Click += new System.EventHandler(this.bnImageProc_Click);
            // 
            // LbCameraStatus
            // 
            this.LbCameraStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LbCameraStatus.AutoSize = true;
            this.LbCameraStatus.Location = new System.Drawing.Point(71, 579);
            this.LbCameraStatus.Name = "LbCameraStatus";
            this.LbCameraStatus.Size = new System.Drawing.Size(59, 12);
            this.LbCameraStatus.TabIndex = 3;
            this.LbCameraStatus.Text = "相机状态:";
            // 
            // tBQualifiedCnt
            // 
            this.tBQualifiedCnt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tBQualifiedCnt.Location = new System.Drawing.Point(254, 579);
            this.tBQualifiedCnt.Name = "tBQualifiedCnt";
            this.tBQualifiedCnt.Size = new System.Drawing.Size(56, 21);
            this.tBQualifiedCnt.TabIndex = 4;
            // 
            // tBUnqualifiedCnt
            // 
            this.tBUnqualifiedCnt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tBUnqualifiedCnt.Location = new System.Drawing.Point(421, 579);
            this.tBUnqualifiedCnt.Name = "tBUnqualifiedCnt";
            this.tBUnqualifiedCnt.Size = new System.Drawing.Size(56, 21);
            this.tBUnqualifiedCnt.TabIndex = 4;
            // 
            // tBTotalCnt
            // 
            this.tBTotalCnt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tBTotalCnt.Location = new System.Drawing.Point(544, 576);
            this.tBTotalCnt.Name = "tBTotalCnt";
            this.tBTotalCnt.Size = new System.Drawing.Size(56, 21);
            this.tBTotalCnt.TabIndex = 4;
            // 
            // LbQualifiedCnt
            // 
            this.LbQualifiedCnt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LbQualifiedCnt.AutoSize = true;
            this.LbQualifiedCnt.Location = new System.Drawing.Point(201, 582);
            this.LbQualifiedCnt.Name = "LbQualifiedCnt";
            this.LbQualifiedCnt.Size = new System.Drawing.Size(47, 12);
            this.LbQualifiedCnt.TabIndex = 5;
            this.LbQualifiedCnt.Text = "合格数:";
            // 
            // LbUnqualifiedCnt
            // 
            this.LbUnqualifiedCnt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LbUnqualifiedCnt.AutoSize = true;
            this.LbUnqualifiedCnt.Location = new System.Drawing.Point(356, 582);
            this.LbUnqualifiedCnt.Name = "LbUnqualifiedCnt";
            this.LbUnqualifiedCnt.Size = new System.Drawing.Size(59, 12);
            this.LbUnqualifiedCnt.TabIndex = 5;
            this.LbUnqualifiedCnt.Text = "不合格数:";
            // 
            // LbTotalCnt
            // 
            this.LbTotalCnt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LbTotalCnt.AutoSize = true;
            this.LbTotalCnt.Location = new System.Drawing.Point(503, 582);
            this.LbTotalCnt.Name = "LbTotalCnt";
            this.LbTotalCnt.Size = new System.Drawing.Size(35, 12);
            this.LbTotalCnt.TabIndex = 5;
            this.LbTotalCnt.Text = "总数:";
            // 
            // pB_Image
            // 
            this.pB_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pB_Image.Location = new System.Drawing.Point(22, 58);
            this.pB_Image.Name = "pB_Image";
            this.pB_Image.Size = new System.Drawing.Size(694, 489);
            this.pB_Image.TabIndex = 6;
            this.pB_Image.TabStop = false;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(657, 9);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(78, 28);
            this.btn_Send.TabIndex = 7;
            this.btn_Send.Text = "Modbus命令";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // CameraSnapTimer
            // 
            this.CameraSnapTimer.Enabled = true;
            this.CameraSnapTimer.Interval = 2000;
            this.CameraSnapTimer.Tick += new System.EventHandler(this.CameraSnapTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 614);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.pB_Image);
            this.Controls.Add(this.LbTotalCnt);
            this.Controls.Add(this.LbUnqualifiedCnt);
            this.Controls.Add(this.LbQualifiedCnt);
            this.Controls.Add(this.tBTotalCnt);
            this.Controls.Add(this.tBUnqualifiedCnt);
            this.Controls.Add(this.tBQualifiedCnt);
            this.Controls.Add(this.LbCameraStatus);
            this.Controls.Add(this.bnImageProc);
            this.Controls.Add(this.bnSnapShot);
            this.Controls.Add(this.bnSettings);
            this.Controls.Add(this.bnStart);
            this.Controls.Add(this.cmbDevices);
            this.Name = "MainForm";
            this.Text = "输液器检测";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.Button bnStart;
        private System.Windows.Forms.Button bnSettings;
        private System.Windows.Forms.Button bnSnapShot;
        private System.Windows.Forms.Button bnImageProc;
        private System.Windows.Forms.Label LbCameraStatus;
        private System.Windows.Forms.TextBox tBQualifiedCnt;
        private System.Windows.Forms.TextBox tBUnqualifiedCnt;
        private System.Windows.Forms.TextBox tBTotalCnt;
        private System.Windows.Forms.Label LbQualifiedCnt;
        private System.Windows.Forms.Label LbUnqualifiedCnt;
        private System.Windows.Forms.Label LbTotalCnt;
        private System.Windows.Forms.PictureBox pB_Image;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Timer CameraSnapTimer;
    }
}

