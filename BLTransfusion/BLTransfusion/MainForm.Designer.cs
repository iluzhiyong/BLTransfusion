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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TsCameraStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsQualifiedCntTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsUnqualifiedCntTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TsUartStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsQualifiedCnt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsUnqualifiedCnt = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.相机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCamConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCamClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCamSnap = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCamSet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemImageProcOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImgProcStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImgProcStop = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImgProcCntClear = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImgProcSet = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawRoiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenUART = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCloseUART = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenRelay = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCloseRelay = new System.Windows.Forms.ToolStripMenuItem();
            this.WndLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.WndLayoutHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.WndLayoutVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.WndLayoutCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TsCameraStatus
            // 
            this.TsCameraStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.TsCameraStatus.Name = "TsCameraStatus";
            this.TsCameraStatus.Size = new System.Drawing.Size(108, 21);
            this.TsCameraStatus.Text = "相机状态：未连接";
            this.TsCameraStatus.Click += new System.EventHandler(this.TsCameraStatus_Click);
            // 
            // TsQualifiedCntTitle
            // 
            this.TsQualifiedCntTitle.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.TsQualifiedCntTitle.Name = "TsQualifiedCntTitle";
            this.TsQualifiedCntTitle.Size = new System.Drawing.Size(64, 21);
            this.TsQualifiedCntTitle.Text = "合格数： ";
            // 
            // TsUnqualifiedCntTitle
            // 
            this.TsUnqualifiedCntTitle.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.TsUnqualifiedCntTitle.Name = "TsUnqualifiedCntTitle";
            this.TsUnqualifiedCntTitle.Size = new System.Drawing.Size(76, 21);
            this.TsUnqualifiedCntTitle.Text = "不合格数： ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsCameraStatus,
            this.TsUartStatus,
            this.toolStripStatusLabel1,
            this.TsQualifiedCntTitle,
            this.TsQualifiedCnt,
            this.TsUnqualifiedCntTitle,
            this.TsUnqualifiedCnt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(945, 26);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TsUartStatus
            // 
            this.TsUartStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.TsUartStatus.Name = "TsUartStatus";
            this.TsUartStatus.Size = new System.Drawing.Size(96, 21);
            this.TsUartStatus.Text = "串口状态：关闭";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(556, 21);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // TsQualifiedCnt
            // 
            this.TsQualifiedCnt.Name = "TsQualifiedCnt";
            this.TsQualifiedCnt.Size = new System.Drawing.Size(15, 21);
            this.TsQualifiedCnt.Text = "0";
            // 
            // TsUnqualifiedCnt
            // 
            this.TsUnqualifiedCnt.Name = "TsUnqualifiedCnt";
            this.TsUnqualifiedCnt.Size = new System.Drawing.Size(15, 21);
            this.TsUnqualifiedCnt.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.相机ToolStripMenuItem,
            this.MenuItemImageProcOpen,
            this.iOToolStripMenuItem,
            this.WndLayout});
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
            this.MenuCamConnect.Size = new System.Drawing.Size(100, 22);
            this.MenuCamConnect.Text = "连接";
            this.MenuCamConnect.Click += new System.EventHandler(this.MenuCamConnect_Click);
            // 
            // MenuCamClose
            // 
            this.MenuCamClose.Name = "MenuCamClose";
            this.MenuCamClose.Size = new System.Drawing.Size(100, 22);
            this.MenuCamClose.Text = "关闭";
            this.MenuCamClose.Click += new System.EventHandler(this.MenuCamClose_Click);
            // 
            // MenuCamSnap
            // 
            this.MenuCamSnap.Name = "MenuCamSnap";
            this.MenuCamSnap.Size = new System.Drawing.Size(100, 22);
            this.MenuCamSnap.Text = "拍摄";
            this.MenuCamSnap.Click += new System.EventHandler(this.MenuCamSnap_Click);
            // 
            // MenuCamSet
            // 
            this.MenuCamSet.Name = "MenuCamSet";
            this.MenuCamSet.Size = new System.Drawing.Size(100, 22);
            this.MenuCamSet.Text = "设置";
            this.MenuCamSet.Click += new System.EventHandler(this.MenuCamSet_Click);
            // 
            // MenuItemImageProcOpen
            // 
            this.MenuItemImageProcOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuImgProcStart,
            this.MenuImgProcStop,
            this.MenuImgProcCntClear,
            this.MenuImgProcSet,
            this.DrawRoiMenuItem});
            this.MenuItemImageProcOpen.Name = "MenuItemImageProcOpen";
            this.MenuItemImageProcOpen.Size = new System.Drawing.Size(68, 21);
            this.MenuItemImageProcOpen.Text = "图像处理";
            // 
            // MenuImgProcStart
            // 
            this.MenuImgProcStart.Name = "MenuImgProcStart";
            this.MenuImgProcStart.Size = new System.Drawing.Size(148, 22);
            this.MenuImgProcStart.Text = "启动";
            this.MenuImgProcStart.Click += new System.EventHandler(this.MenuImgProcStart_Click);
            // 
            // MenuImgProcStop
            // 
            this.MenuImgProcStop.Name = "MenuImgProcStop";
            this.MenuImgProcStop.Size = new System.Drawing.Size(148, 22);
            this.MenuImgProcStop.Text = "停止";
            this.MenuImgProcStop.Click += new System.EventHandler(this.MenuImgProcStop_Click);
            // 
            // MenuImgProcCntClear
            // 
            this.MenuImgProcCntClear.Name = "MenuImgProcCntClear";
            this.MenuImgProcCntClear.Size = new System.Drawing.Size(148, 22);
            this.MenuImgProcCntClear.Text = "计数清零";
            this.MenuImgProcCntClear.Click += new System.EventHandler(this.MenuImgProcCntClear_Click);
            // 
            // MenuImgProcSet
            // 
            this.MenuImgProcSet.Name = "MenuImgProcSet";
            this.MenuImgProcSet.Size = new System.Drawing.Size(148, 22);
            this.MenuImgProcSet.Text = "设置";
            this.MenuImgProcSet.Click += new System.EventHandler(this.MenuImgProcSet_Click);
            // 
            // DrawRoiMenuItem
            // 
            this.DrawRoiMenuItem.Name = "DrawRoiMenuItem";
            this.DrawRoiMenuItem.Size = new System.Drawing.Size(148, 22);
            this.DrawRoiMenuItem.Text = "选择目标区域";
            this.DrawRoiMenuItem.Click += new System.EventHandler(this.DrawRoiMenuItem_Click);
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
            // MenuOpenUART
            // 
            this.MenuOpenUART.Name = "MenuOpenUART";
            this.MenuOpenUART.Size = new System.Drawing.Size(136, 22);
            this.MenuOpenUART.Text = "打开串口";
            this.MenuOpenUART.Click += new System.EventHandler(this.MenuOpenUART_Click);
            // 
            // MenuCloseUART
            // 
            this.MenuCloseUART.Name = "MenuCloseUART";
            this.MenuCloseUART.Size = new System.Drawing.Size(136, 22);
            this.MenuCloseUART.Text = "关闭串口";
            this.MenuCloseUART.Click += new System.EventHandler(this.MenuCloseUART_Click);
            // 
            // MenuOpenRelay
            // 
            this.MenuOpenRelay.Name = "MenuOpenRelay";
            this.MenuOpenRelay.Size = new System.Drawing.Size(136, 22);
            this.MenuOpenRelay.Text = "打开继电器";
            this.MenuOpenRelay.Click += new System.EventHandler(this.MenuOpenRelay_Click);
            // 
            // MenuCloseRelay
            // 
            this.MenuCloseRelay.Name = "MenuCloseRelay";
            this.MenuCloseRelay.Size = new System.Drawing.Size(136, 22);
            this.MenuCloseRelay.Text = "关闭继电器";
            this.MenuCloseRelay.Click += new System.EventHandler(this.MenuCloseRelay_Click);
            // 
            // WndLayout
            // 
            this.WndLayout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WndLayoutHorizontal,
            this.WndLayoutVertical,
            this.WndLayoutCascade});
            this.WndLayout.Name = "WndLayout";
            this.WndLayout.Size = new System.Drawing.Size(44, 21);
            this.WndLayout.Text = "窗口";
            // 
            // WndLayoutHorizontal
            // 
            this.WndLayoutHorizontal.Name = "WndLayoutHorizontal";
            this.WndLayoutHorizontal.Size = new System.Drawing.Size(124, 22);
            this.WndLayoutHorizontal.Text = "水平平铺";
            this.WndLayoutHorizontal.Click += new System.EventHandler(this.WndLayoutHorizontal_Click);
            // 
            // WndLayoutVertical
            // 
            this.WndLayoutVertical.Name = "WndLayoutVertical";
            this.WndLayoutVertical.Size = new System.Drawing.Size(124, 22);
            this.WndLayoutVertical.Text = "垂直平铺";
            this.WndLayoutVertical.Click += new System.EventHandler(this.WndLayoutVertical_Click);
            // 
            // WndLayoutCascade
            // 
            this.WndLayoutCascade.Name = "WndLayoutCascade";
            this.WndLayoutCascade.Size = new System.Drawing.Size(124, 22);
            this.WndLayoutCascade.Text = "层叠排列";
            this.WndLayoutCascade.Click += new System.EventHandler(this.WndLayoutCascade_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 614);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "输液器检测";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripStatusLabel TsCameraStatus;
        private System.Windows.Forms.ToolStripStatusLabel TsQualifiedCntTitle;
        private System.Windows.Forms.ToolStripStatusLabel TsUnqualifiedCntTitle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 相机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCamConnect;
        private System.Windows.Forms.ToolStripMenuItem MenuCamSet;
        private System.Windows.Forms.ToolStripMenuItem MenuItemImageProcOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuImgProcStart;
        private System.Windows.Forms.ToolStripMenuItem MenuImgProcSet;
        private System.Windows.Forms.ToolStripMenuItem MenuCamClose;
        private System.Windows.Forms.ToolStripMenuItem MenuCamSnap;
        private System.Windows.Forms.ToolStripMenuItem iOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenRelay;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenUART;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseUART;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseRelay;
        private System.Windows.Forms.ToolStripStatusLabel TsUartStatus;
        private System.Windows.Forms.ToolStripMenuItem MenuImgProcStop;
        private System.Windows.Forms.ToolStripStatusLabel TsQualifiedCnt;
        private System.Windows.Forms.ToolStripStatusLabel TsUnqualifiedCnt;
        private System.Windows.Forms.ToolStripMenuItem MenuImgProcCntClear;
        private System.Windows.Forms.ToolStripMenuItem WndLayout;
        private System.Windows.Forms.ToolStripMenuItem WndLayoutHorizontal;
        private System.Windows.Forms.ToolStripMenuItem WndLayoutVertical;
        private System.Windows.Forms.ToolStripMenuItem WndLayoutCascade;
        private System.Windows.Forms.ToolStripMenuItem DrawRoiMenuItem;
    }
}

