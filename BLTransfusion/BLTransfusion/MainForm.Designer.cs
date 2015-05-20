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
            this.panelVideo = new System.Windows.Forms.Panel();
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
            this.SuspendLayout();
            // 
            // panelVideo
            // 
            this.panelVideo.Location = new System.Drawing.Point(10, 58);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(824, 406);
            this.panelVideo.TabIndex = 0;
            // 
            // cmbDevices
            // 
            this.cmbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(14, 19);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(312, 20);
            this.cmbDevices.TabIndex = 1;
            this.cmbDevices.SelectedIndexChanged += new System.EventHandler(this.cmbDevices_SelectedIndexChanged);
            // 
            // bnStart
            // 
            this.bnStart.Location = new System.Drawing.Point(387, 14);
            this.bnStart.Name = "bnStart";
            this.bnStart.Size = new System.Drawing.Size(78, 28);
            this.bnStart.TabIndex = 2;
            this.bnStart.Text = "开始";
            this.bnStart.UseVisualStyleBackColor = true;
            this.bnStart.Click += new System.EventHandler(this.bnStart_Click);
            // 
            // bnSettings
            // 
            this.bnSettings.Location = new System.Drawing.Point(504, 14);
            this.bnSettings.Name = "bnSettings";
            this.bnSettings.Size = new System.Drawing.Size(78, 28);
            this.bnSettings.TabIndex = 2;
            this.bnSettings.Text = "设置";
            this.bnSettings.UseVisualStyleBackColor = true;
            this.bnSettings.Click += new System.EventHandler(this.bnSettings_Click);
            // 
            // bnSnapShot
            // 
            this.bnSnapShot.Location = new System.Drawing.Point(618, 14);
            this.bnSnapShot.Name = "bnSnapShot";
            this.bnSnapShot.Size = new System.Drawing.Size(78, 28);
            this.bnSnapShot.TabIndex = 2;
            this.bnSnapShot.Text = "拍摄";
            this.bnSnapShot.UseVisualStyleBackColor = true;
            this.bnSnapShot.Click += new System.EventHandler(this.bnSnapShot_Click);
            // 
            // bnImageProc
            // 
            this.bnImageProc.Location = new System.Drawing.Point(730, 14);
            this.bnImageProc.Name = "bnImageProc";
            this.bnImageProc.Size = new System.Drawing.Size(78, 28);
            this.bnImageProc.TabIndex = 2;
            this.bnImageProc.Text = "图像处理";
            this.bnImageProc.UseVisualStyleBackColor = true;
            this.bnImageProc.Click += new System.EventHandler(this.bnImageProc_Click);
            // 
            // LbCameraStatus
            // 
            this.LbCameraStatus.AutoSize = true;
            this.LbCameraStatus.Location = new System.Drawing.Point(12, 480);
            this.LbCameraStatus.Name = "LbCameraStatus";
            this.LbCameraStatus.Size = new System.Drawing.Size(59, 12);
            this.LbCameraStatus.TabIndex = 3;
            this.LbCameraStatus.Text = "相机状态:";
            // 
            // tBQualifiedCnt
            // 
            this.tBQualifiedCnt.Location = new System.Drawing.Point(466, 477);
            this.tBQualifiedCnt.Name = "tBQualifiedCnt";
            this.tBQualifiedCnt.Size = new System.Drawing.Size(56, 21);
            this.tBQualifiedCnt.TabIndex = 4;
            // 
            // tBUnqualifiedCnt
            // 
            this.tBUnqualifiedCnt.Location = new System.Drawing.Point(633, 477);
            this.tBUnqualifiedCnt.Name = "tBUnqualifiedCnt";
            this.tBUnqualifiedCnt.Size = new System.Drawing.Size(56, 21);
            this.tBUnqualifiedCnt.TabIndex = 4;
            // 
            // tBTotalCnt
            // 
            this.tBTotalCnt.Location = new System.Drawing.Point(765, 477);
            this.tBTotalCnt.Name = "tBTotalCnt";
            this.tBTotalCnt.Size = new System.Drawing.Size(56, 21);
            this.tBTotalCnt.TabIndex = 4;
            // 
            // LbQualifiedCnt
            // 
            this.LbQualifiedCnt.AutoSize = true;
            this.LbQualifiedCnt.Location = new System.Drawing.Point(413, 480);
            this.LbQualifiedCnt.Name = "LbQualifiedCnt";
            this.LbQualifiedCnt.Size = new System.Drawing.Size(47, 12);
            this.LbQualifiedCnt.TabIndex = 5;
            this.LbQualifiedCnt.Text = "合格数:";
            // 
            // LbUnqualifiedCnt
            // 
            this.LbUnqualifiedCnt.AutoSize = true;
            this.LbUnqualifiedCnt.Location = new System.Drawing.Point(568, 480);
            this.LbUnqualifiedCnt.Name = "LbUnqualifiedCnt";
            this.LbUnqualifiedCnt.Size = new System.Drawing.Size(59, 12);
            this.LbUnqualifiedCnt.TabIndex = 5;
            this.LbUnqualifiedCnt.Text = "不合格数:";
            // 
            // LbTotalCnt
            // 
            this.LbTotalCnt.AutoSize = true;
            this.LbTotalCnt.Location = new System.Drawing.Point(728, 480);
            this.LbTotalCnt.Name = "LbTotalCnt";
            this.LbTotalCnt.Size = new System.Drawing.Size(35, 12);
            this.LbTotalCnt.TabIndex = 5;
            this.LbTotalCnt.Text = "总数:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 521);
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
            this.Controls.Add(this.panelVideo);
            this.Name = "MainForm";
            this.Text = "输液器检测";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVideo;
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
    }
}

