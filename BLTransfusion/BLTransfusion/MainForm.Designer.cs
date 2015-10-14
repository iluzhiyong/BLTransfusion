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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.openCameraMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snapshotMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCameraMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.cameraSettingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemImageProcOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDetect = new System.Windows.Forms.ToolStripMenuItem();
            this.autoDetect = new System.Windows.Forms.ToolStripMenuItem();
            this.stopDetect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearRecordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImgProcAlgorithmSet = new System.Windows.Forms.ToolStripMenuItem();
            this.iOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenUART = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCloseUART = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenRelay = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCloseRelay = new System.Windows.Forms.ToolStripMenuItem();
            this.WndLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.WndLayoutHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.WndLayoutVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.WndLayoutCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_ConnectCamera = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Snap = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_CameraSet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_AutoStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_AutoStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_ClearResult = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TsCameraStatus
            // 
            this.TsCameraStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.TsCameraStatus.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TsCameraStatus.Name = "TsCameraStatus";
            this.TsCameraStatus.Size = new System.Drawing.Size(74, 17);
            this.TsCameraStatus.Text = "相机：关闭";
            // 
            // TsQualifiedCntTitle
            // 
            this.TsQualifiedCntTitle.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.TsQualifiedCntTitle.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TsQualifiedCntTitle.Name = "TsQualifiedCntTitle";
            this.TsQualifiedCntTitle.Size = new System.Drawing.Size(68, 17);
            this.TsQualifiedCntTitle.Text = "合格数： ";
            // 
            // TsUnqualifiedCntTitle
            // 
            this.TsUnqualifiedCntTitle.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.TsUnqualifiedCntTitle.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TsUnqualifiedCntTitle.Name = "TsUnqualifiedCntTitle";
            this.TsUnqualifiedCntTitle.Size = new System.Drawing.Size(81, 17);
            this.TsUnqualifiedCntTitle.Text = "不合格数： ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.statusStrip1.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsCameraStatus,
            this.TsUartStatus,
            this.toolStripStatusLabel1,
            this.TsQualifiedCntTitle,
            this.TsQualifiedCnt,
            this.TsUnqualifiedCntTitle,
            this.TsUnqualifiedCnt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(944, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TsUartStatus
            // 
            this.TsUartStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.TsUartStatus.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TsUartStatus.Name = "TsUartStatus";
            this.TsUartStatus.Size = new System.Drawing.Size(74, 17);
            this.TsUartStatus.Text = "串口：关闭";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(608, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // TsQualifiedCnt
            // 
            this.TsQualifiedCnt.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TsQualifiedCnt.Name = "TsQualifiedCnt";
            this.TsQualifiedCnt.Size = new System.Drawing.Size(12, 17);
            this.TsQualifiedCnt.Text = "0";
            // 
            // TsUnqualifiedCnt
            // 
            this.TsUnqualifiedCnt.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TsUnqualifiedCnt.Name = "TsUnqualifiedCnt";
            this.TsUnqualifiedCnt.Size = new System.Drawing.Size(12, 17);
            this.TsUnqualifiedCnt.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.相机ToolStripMenuItem,
            this.MenuItemImageProcOpen,
            this.iOToolStripMenuItem,
            this.WndLayout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 相机ToolStripMenuItem
            // 
            this.相机ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCameraMenuItem,
            this.snapshotMenuItem,
            this.closeCameraMenuItem,
            this.toolStripMenuItem4,
            this.cameraSettingMenuItem});
            this.相机ToolStripMenuItem.Name = "相机ToolStripMenuItem";
            this.相机ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.相机ToolStripMenuItem.Text = "相机";
            // 
            // openCameraMenuItem
            // 
            this.openCameraMenuItem.Name = "openCameraMenuItem";
            this.openCameraMenuItem.Size = new System.Drawing.Size(122, 22);
            this.openCameraMenuItem.Text = "启动相机";
            this.openCameraMenuItem.Click += new System.EventHandler(this.openCameraMenuItem_Click);
            // 
            // snapshotMenuItem
            // 
            this.snapshotMenuItem.Name = "snapshotMenuItem";
            this.snapshotMenuItem.Size = new System.Drawing.Size(122, 22);
            this.snapshotMenuItem.Text = "拍摄照片";
            this.snapshotMenuItem.Click += new System.EventHandler(this.snapshotMenuItem_Click);
            // 
            // closeCameraMenuItem
            // 
            this.closeCameraMenuItem.Name = "closeCameraMenuItem";
            this.closeCameraMenuItem.Size = new System.Drawing.Size(122, 22);
            this.closeCameraMenuItem.Text = "关闭相机";
            this.closeCameraMenuItem.Click += new System.EventHandler(this.closeCameraMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(119, 6);
            // 
            // cameraSettingMenuItem
            // 
            this.cameraSettingMenuItem.Name = "cameraSettingMenuItem";
            this.cameraSettingMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cameraSettingMenuItem.Text = "相机设定";
            this.cameraSettingMenuItem.Click += new System.EventHandler(this.cameraSettingMenuItem_Click);
            // 
            // MenuItemImageProcOpen
            // 
            this.MenuItemImageProcOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDetect,
            this.autoDetect,
            this.stopDetect,
            this.toolStripMenuItem3,
            this.clearRecordMenuItem,
            this.MenuImgProcAlgorithmSet});
            this.MenuItemImageProcOpen.Name = "MenuItemImageProcOpen";
            this.MenuItemImageProcOpen.Size = new System.Drawing.Size(69, 20);
            this.MenuItemImageProcOpen.Text = "图像处理";
            // 
            // manualDetect
            // 
            this.manualDetect.Name = "manualDetect";
            this.manualDetect.Size = new System.Drawing.Size(122, 22);
            this.manualDetect.Text = "手动检测";
            this.manualDetect.Click += new System.EventHandler(this.manualDetect_Click);
            // 
            // autoDetect
            // 
            this.autoDetect.Name = "autoDetect";
            this.autoDetect.Size = new System.Drawing.Size(122, 22);
            this.autoDetect.Text = "自动检测";
            this.autoDetect.Click += new System.EventHandler(this.autoDetect_Click);
            // 
            // stopDetect
            // 
            this.stopDetect.Name = "stopDetect";
            this.stopDetect.Size = new System.Drawing.Size(122, 22);
            this.stopDetect.Text = "停止检测";
            this.stopDetect.Click += new System.EventHandler(this.stopDetect_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(119, 6);
            // 
            // clearRecordMenuItem
            // 
            this.clearRecordMenuItem.Name = "clearRecordMenuItem";
            this.clearRecordMenuItem.Size = new System.Drawing.Size(122, 22);
            this.clearRecordMenuItem.Text = "清空记录";
            this.clearRecordMenuItem.Click += new System.EventHandler(this.clearRecordMenuItem_Click);
            // 
            // MenuImgProcAlgorithmSet
            // 
            this.MenuImgProcAlgorithmSet.Name = "MenuImgProcAlgorithmSet";
            this.MenuImgProcAlgorithmSet.Size = new System.Drawing.Size(122, 22);
            this.MenuImgProcAlgorithmSet.Text = "算法设置";
            this.MenuImgProcAlgorithmSet.Click += new System.EventHandler(this.MenuImgProcAlgorithmSet_Click);
            // 
            // iOToolStripMenuItem
            // 
            this.iOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpenUART,
            this.MenuCloseUART,
            this.MenuOpenRelay,
            this.MenuCloseRelay});
            this.iOToolStripMenuItem.Name = "iOToolStripMenuItem";
            this.iOToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.iOToolStripMenuItem.Text = "IO";
            // 
            // MenuOpenUART
            // 
            this.MenuOpenUART.Name = "MenuOpenUART";
            this.MenuOpenUART.Size = new System.Drawing.Size(135, 22);
            this.MenuOpenUART.Text = "打开串口";
            this.MenuOpenUART.Click += new System.EventHandler(this.MenuOpenUART_Click);
            // 
            // MenuCloseUART
            // 
            this.MenuCloseUART.Name = "MenuCloseUART";
            this.MenuCloseUART.Size = new System.Drawing.Size(135, 22);
            this.MenuCloseUART.Text = "关闭串口";
            this.MenuCloseUART.Click += new System.EventHandler(this.MenuCloseUART_Click);
            // 
            // MenuOpenRelay
            // 
            this.MenuOpenRelay.Name = "MenuOpenRelay";
            this.MenuOpenRelay.Size = new System.Drawing.Size(135, 22);
            this.MenuOpenRelay.Text = "打开继电器";
            this.MenuOpenRelay.Click += new System.EventHandler(this.MenuOpenRelay_Click);
            // 
            // MenuCloseRelay
            // 
            this.MenuCloseRelay.Name = "MenuCloseRelay";
            this.MenuCloseRelay.Size = new System.Drawing.Size(135, 22);
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
            this.WndLayout.Size = new System.Drawing.Size(43, 20);
            this.WndLayout.Text = "窗口";
            // 
            // WndLayoutHorizontal
            // 
            this.WndLayoutHorizontal.Name = "WndLayoutHorizontal";
            this.WndLayoutHorizontal.Size = new System.Drawing.Size(122, 22);
            this.WndLayoutHorizontal.Text = "水平平铺";
            this.WndLayoutHorizontal.Click += new System.EventHandler(this.WndLayoutHorizontal_Click);
            // 
            // WndLayoutVertical
            // 
            this.WndLayoutVertical.Name = "WndLayoutVertical";
            this.WndLayoutVertical.Size = new System.Drawing.Size(122, 22);
            this.WndLayoutVertical.Text = "垂直平铺";
            this.WndLayoutVertical.Click += new System.EventHandler(this.WndLayoutVertical_Click);
            // 
            // WndLayoutCascade
            // 
            this.WndLayoutCascade.Name = "WndLayoutCascade";
            this.WndLayoutCascade.Size = new System.Drawing.Size(122, 22);
            this.WndLayoutCascade.Text = "层叠排列";
            this.WndLayoutCascade.Click += new System.EventHandler(this.WndLayoutCascade_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_ConnectCamera,
            this.toolStripButton_Snap,
            this.toolStripButton_CameraSet,
            this.toolStripSeparator1,
            this.toolStripButton_AutoStart,
            this.toolStripButton_AutoStop,
            this.toolStripButton_ClearResult});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(944, 39);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_ConnectCamera
            // 
            this.toolStripButton_ConnectCamera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ConnectCamera.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ConnectCamera.Image")));
            this.toolStripButton_ConnectCamera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ConnectCamera.Name = "toolStripButton_ConnectCamera";
            this.toolStripButton_ConnectCamera.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton_ConnectCamera.Text = "toolStripButton_ConnectCame";
            this.toolStripButton_ConnectCamera.ToolTipText = "启动相机";
            this.toolStripButton_ConnectCamera.Click += new System.EventHandler(this.toolStripButton_ConnectCamera_Click);
            // 
            // toolStripButton_Snap
            // 
            this.toolStripButton_Snap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Snap.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Snap.Image")));
            this.toolStripButton_Snap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Snap.Name = "toolStripButton_Snap";
            this.toolStripButton_Snap.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton_Snap.Text = "toolStripButton_Snap";
            this.toolStripButton_Snap.ToolTipText = "拍摄照片";
            this.toolStripButton_Snap.Click += new System.EventHandler(this.toolStripButton_Snap_Click);
            // 
            // toolStripButton_CameraSet
            // 
            this.toolStripButton_CameraSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_CameraSet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_CameraSet.Image")));
            this.toolStripButton_CameraSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_CameraSet.Name = "toolStripButton_CameraSet";
            this.toolStripButton_CameraSet.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton_CameraSet.Text = "toolStripButton_CameraSet";
            this.toolStripButton_CameraSet.ToolTipText = "相机设定";
            this.toolStripButton_CameraSet.Click += new System.EventHandler(this.toolStripButton_CameraSet_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton_AutoStart
            // 
            this.toolStripButton_AutoStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_AutoStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_AutoStart.Image")));
            this.toolStripButton_AutoStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_AutoStart.Name = "toolStripButton_AutoStart";
            this.toolStripButton_AutoStart.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton_AutoStart.Text = "toolStripButton_AutoStart";
            this.toolStripButton_AutoStart.ToolTipText = "自动检测";
            this.toolStripButton_AutoStart.Click += new System.EventHandler(this.toolStripButton_AutoStart_Click);
            // 
            // toolStripButton_AutoStop
            // 
            this.toolStripButton_AutoStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_AutoStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_AutoStop.Image")));
            this.toolStripButton_AutoStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_AutoStop.Name = "toolStripButton_AutoStop";
            this.toolStripButton_AutoStop.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton_AutoStop.Text = "toolStripButton_AutoStop";
            this.toolStripButton_AutoStop.ToolTipText = "停止检测";
            this.toolStripButton_AutoStop.Click += new System.EventHandler(this.toolStripButton_AutoStop_Click);
            // 
            // toolStripButton_ClearResult
            // 
            this.toolStripButton_ClearResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ClearResult.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ClearResult.Image")));
            this.toolStripButton_ClearResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ClearResult.Name = "toolStripButton_ClearResult";
            this.toolStripButton_ClearResult.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton_ClearResult.Text = "toolStripButton_ClearResult";
            this.toolStripButton_ClearResult.ToolTipText = "清空记录";
            this.toolStripButton_ClearResult.Click += new System.EventHandler(this.toolStripButton_ClearResult_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 569);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("YouYuan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem MenuItemImageProcOpen;
        private System.Windows.Forms.ToolStripMenuItem iOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenRelay;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenUART;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseUART;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseRelay;
        private System.Windows.Forms.ToolStripStatusLabel TsUartStatus;
        private System.Windows.Forms.ToolStripStatusLabel TsQualifiedCnt;
        private System.Windows.Forms.ToolStripStatusLabel TsUnqualifiedCnt;
        private System.Windows.Forms.ToolStripMenuItem WndLayout;
        private System.Windows.Forms.ToolStripMenuItem WndLayoutHorizontal;
        private System.Windows.Forms.ToolStripMenuItem WndLayoutVertical;
        private System.Windows.Forms.ToolStripMenuItem WndLayoutCascade;
        private System.Windows.Forms.ToolStripMenuItem manualDetect;
        private System.Windows.Forms.ToolStripMenuItem autoDetect;
        private System.Windows.Forms.ToolStripMenuItem stopDetect;
        private System.Windows.Forms.ToolStripMenuItem openCameraMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snapshotMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCameraMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cameraSettingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearRecordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuImgProcAlgorithmSet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_ConnectCamera;
        private System.Windows.Forms.ToolStripButton toolStripButton_Snap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_AutoStart;
        private System.Windows.Forms.ToolStripButton toolStripButton_AutoStop;
        private System.Windows.Forms.ToolStripButton toolStripButton_CameraSet;
        private System.Windows.Forms.ToolStripButton toolStripButton_ClearResult;
    }
}

