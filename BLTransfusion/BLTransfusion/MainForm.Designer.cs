﻿namespace BLTransfusion
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.CameraSnapTimer = new System.Windows.Forms.Timer(this.components);
            this.hWindowControl1 = new HalconDotNet.HWindowControl();
            this.pB_Image = new System.Windows.Forms.PictureBox();
            this.TsCameraStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsQualifiedCnt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsUnqualifiedCnt = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.相机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCamConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCamClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCamSnap = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCamSet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemImageProcOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImgProcOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImgProcSet = new System.Windows.Forms.ToolStripMenuItem();
            this.iOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenRelay = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenUART = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCloseUART = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCloseRelay = new System.Windows.Forms.ToolStripMenuItem();
            this.TsUartStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Image)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CameraSnapTimer
            // 
            this.CameraSnapTimer.Enabled = false;
            this.CameraSnapTimer.Interval = 2000;
            this.CameraSnapTimer.Tick += new System.EventHandler(this.CameraSnapTimer_Tick);
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(12, 28);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(921, 551);
            this.hWindowControl1.TabIndex = 8;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(921, 551);
            // 
            // pB_Image
            // 
            this.pB_Image.Location = new System.Drawing.Point(26, 43);
            this.pB_Image.Name = "pB_Image";
            this.pB_Image.Size = new System.Drawing.Size(157, 145);
            this.pB_Image.TabIndex = 9;
            this.pB_Image.TabStop = false;
            // 
            // TsCameraStatus
            // 
            this.TsCameraStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.TsCameraStatus.Name = "TsCameraStatus";
            this.TsCameraStatus.Size = new System.Drawing.Size(108, 21);
            this.TsCameraStatus.Text = "相机状态：未连接";
            // 
            // TsQualifiedCnt
            // 
            this.TsQualifiedCnt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.TsQualifiedCnt.Name = "TsQualifiedCnt";
            this.TsQualifiedCnt.Size = new System.Drawing.Size(71, 21);
            this.TsQualifiedCnt.Text = "合格数： 0";
            // 
            // TsUnqualifiedCnt
            // 
            this.TsUnqualifiedCnt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.TsUnqualifiedCnt.Name = "TsUnqualifiedCnt";
            this.TsUnqualifiedCnt.Size = new System.Drawing.Size(83, 21);
            this.TsUnqualifiedCnt.Text = "不合格数： 0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsCameraStatus,
            this.TsUartStatus,
            this.toolStripStatusLabel1,
            this.TsQualifiedCnt,
            this.TsUnqualifiedCnt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(945, 26);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(573, 21);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.相机ToolStripMenuItem,
            this.MenuItemImageProcOpen,
            this.iOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(945, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 相机ToolStripMenuItem
            // 
            this.相机ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCamConnect,
            this.MenuCamClose,
            this.MenuCamSnap,
            this.MenuCamSet});
            this.相机ToolStripMenuItem.Name = "相机ToolStripMenuItem";
            this.相机ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.相机ToolStripMenuItem.Text = "相机";
            // 
            // MenuCamConnect
            // 
            this.MenuCamConnect.Name = "MenuCamConnect";
            this.MenuCamConnect.Size = new System.Drawing.Size(152, 22);
            this.MenuCamConnect.Text = "连接";
            this.MenuCamConnect.Click += new System.EventHandler(this.MenuCamConnect_Click);
            // 
            // MenuCamClose
            // 
            this.MenuCamClose.Name = "MenuCamClose";
            this.MenuCamClose.Size = new System.Drawing.Size(152, 22);
            this.MenuCamClose.Text = "关闭";
            this.MenuCamClose.Click += new System.EventHandler(this.MenuCamClose_Click);
            // 
            // MenuCamSnap
            // 
            this.MenuCamSnap.Name = "MenuCamSnap";
            this.MenuCamSnap.Size = new System.Drawing.Size(152, 22);
            this.MenuCamSnap.Text = "拍摄";
            this.MenuCamSnap.Click += new System.EventHandler(this.MenuCamSnap_Click);
            // 
            // MenuCamSet
            // 
            this.MenuCamSet.Name = "MenuCamSet";
            this.MenuCamSet.Size = new System.Drawing.Size(152, 22);
            this.MenuCamSet.Text = "设置";
            this.MenuCamSet.Click += new System.EventHandler(this.MenuCamSet_Click);
            // 
            // MenuItemImageProcOpen
            // 
            this.MenuItemImageProcOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuImgProcOpen,
            this.MenuImgProcSet});
            this.MenuItemImageProcOpen.Name = "MenuItemImageProcOpen";
            this.MenuItemImageProcOpen.Size = new System.Drawing.Size(68, 21);
            this.MenuItemImageProcOpen.Text = "图像处理";
            // 
            // MenuImgProcOpen
            // 
            this.MenuImgProcOpen.Name = "MenuImgProcOpen";
            this.MenuImgProcOpen.Size = new System.Drawing.Size(152, 22);
            this.MenuImgProcOpen.Text = "打开";
            this.MenuImgProcOpen.Click += new System.EventHandler(this.MenuImgProcOpen_Click);
            // 
            // MenuImgProcSet
            // 
            this.MenuImgProcSet.Name = "MenuImgProcSet";
            this.MenuImgProcSet.Size = new System.Drawing.Size(100, 22);
            this.MenuImgProcSet.Text = "设置";
            this.MenuImgProcSet.Click += new System.EventHandler(this.MenuImgProcSet_Click);
            // 
            // iOToolStripMenuItem
            // 
            this.iOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpenUART,
            this.MenuCloseUART,
            this.MenuOpenRelay,
            this.MenuCloseRelay});
            this.iOToolStripMenuItem.Name = "iOToolStripMenuItem";
            this.iOToolStripMenuItem.Size = new System.Drawing.Size(34, 21);
            this.iOToolStripMenuItem.Text = "IO";
            // 
            // MenuOpenRelay
            // 
            this.MenuOpenRelay.Name = "MenuOpenRelay";
            this.MenuOpenRelay.Size = new System.Drawing.Size(152, 22);
            this.MenuOpenRelay.Text = "打开继电器";
            this.MenuOpenRelay.Click += new System.EventHandler(this.MenuOpenRelay_Click);
            // 
            // MenuOpenUART
            // 
            this.MenuOpenUART.Name = "MenuOpenUART";
            this.MenuOpenUART.Size = new System.Drawing.Size(152, 22);
            this.MenuOpenUART.Text = "打开串口";
            this.MenuOpenUART.Click += new System.EventHandler(this.MenuOpenUART_Click);
            // 
            // MenuCloseUART
            // 
            this.MenuCloseUART.Name = "MenuCloseUART";
            this.MenuCloseUART.Size = new System.Drawing.Size(152, 22);
            this.MenuCloseUART.Text = "关闭串口";
            this.MenuCloseUART.Click += new System.EventHandler(this.MenuCloseUART_Click);
            // 
            // MenuCloseRelay
            // 
            this.MenuCloseRelay.Name = "MenuCloseRelay";
            this.MenuCloseRelay.Size = new System.Drawing.Size(152, 22);
            this.MenuCloseRelay.Text = "关闭继电器";
            this.MenuCloseRelay.Click += new System.EventHandler(this.MenuCloseRelay_Click);
            // 
            // TsUartStatus
            // 
            this.TsUartStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.TsUartStatus.Name = "TsUartStatus";
            this.TsUartStatus.Size = new System.Drawing.Size(96, 21);
            this.TsUartStatus.Text = "串口状态：关闭";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 614);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pB_Image);
            this.Controls.Add(this.hWindowControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "输液器检测";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Image)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer CameraSnapTimer;
        private HalconDotNet.HWindowControl hWindowControl1;
        private System.Windows.Forms.PictureBox pB_Image;
        private System.Windows.Forms.ToolStripStatusLabel TsCameraStatus;
        private System.Windows.Forms.ToolStripStatusLabel TsQualifiedCnt;
        private System.Windows.Forms.ToolStripStatusLabel TsUnqualifiedCnt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 相机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCamConnect;
        private System.Windows.Forms.ToolStripMenuItem MenuCamSet;
        private System.Windows.Forms.ToolStripMenuItem MenuItemImageProcOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuImgProcOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuImgProcSet;
        private System.Windows.Forms.ToolStripMenuItem MenuCamClose;
        private System.Windows.Forms.ToolStripMenuItem MenuCamSnap;
        private System.Windows.Forms.ToolStripMenuItem iOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenRelay;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenUART;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseUART;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseRelay;
        private System.Windows.Forms.ToolStripStatusLabel TsUartStatus;
    }
}

