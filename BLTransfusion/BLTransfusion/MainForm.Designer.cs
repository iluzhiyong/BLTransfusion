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
            this.openCameraMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snapshotMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCameraMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.cameraSettingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemImageProcOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuImgProcSet = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDetect = new System.Windows.Forms.ToolStripMenuItem();
            this.autoDetect = new System.Windows.Forms.ToolStripMenuItem();
            this.stopDetect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearRecordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectModelsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 315);
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
            this.openCameraMenuItem,
            this.snapshotMenuItem,
            this.closeCameraMenuItem,
            this.toolStripMenuItem4,
            this.cameraSettingMenuItem});
            this.相机ToolStripMenuItem.Name = "相机ToolStripMenuItem";
            this.相机ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.相机ToolStripMenuItem.Text = "相机";
            // 
            // openCameraMenuItem
            // 
            this.openCameraMenuItem.Name = "openCameraMenuItem";
            this.openCameraMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openCameraMenuItem.Text = "启动相机";
            this.openCameraMenuItem.Click += new System.EventHandler(this.openCameraMenuItem_Click);
            // 
            // snapshotMenuItem
            // 
            this.snapshotMenuItem.Name = "snapshotMenuItem";
            this.snapshotMenuItem.Size = new System.Drawing.Size(152, 22);
            this.snapshotMenuItem.Text = "拍摄照片";
            this.snapshotMenuItem.Click += new System.EventHandler(this.snapshotMenuItem_Click);
            // 
            // closeCameraMenuItem
            // 
            this.closeCameraMenuItem.Name = "closeCameraMenuItem";
            this.closeCameraMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeCameraMenuItem.Text = "关闭相机";
            this.closeCameraMenuItem.Click += new System.EventHandler(this.closeCameraMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(149, 6);
            // 
            // cameraSettingMenuItem
            // 
            this.cameraSettingMenuItem.Name = "cameraSettingMenuItem";
            this.cameraSettingMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.selectModelsMenuItem,
            this.MenuImgProcSet});
            this.MenuItemImageProcOpen.Name = "MenuItemImageProcOpen";
            this.MenuItemImageProcOpen.Size = new System.Drawing.Size(68, 21);
            this.MenuItemImageProcOpen.Text = "图像处理";
            // 
            // MenuImgProcSet
            // 
            this.MenuImgProcSet.Name = "MenuImgProcSet";
            this.MenuImgProcSet.Size = new System.Drawing.Size(152, 22);
            this.MenuImgProcSet.Text = "设置";
            this.MenuImgProcSet.Click += new System.EventHandler(this.MenuImgProcSet_Click);
            // 
            // manualDetect
            // 
            this.manualDetect.Name = "manualDetect";
            this.manualDetect.Size = new System.Drawing.Size(152, 22);
            this.manualDetect.Text = "手动检测";
            this.manualDetect.Click += new System.EventHandler(this.manualDetect_Click);
            // 
            // autoDetect
            // 
            this.autoDetect.Name = "autoDetect";
            this.autoDetect.Size = new System.Drawing.Size(152, 22);
            this.autoDetect.Text = "自动检测";
            this.autoDetect.Click += new System.EventHandler(this.autoDetect_Click);
            // 
            // stopDetect
            // 
            this.stopDetect.Name = "stopDetect";
            this.stopDetect.Size = new System.Drawing.Size(152, 22);
            this.stopDetect.Text = "停止检测";
            this.stopDetect.Click += new System.EventHandler(this.stopDetect_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // clearRecordMenuItem
            // 
            this.clearRecordMenuItem.Name = "clearRecordMenuItem";
            this.clearRecordMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearRecordMenuItem.Text = "清空记录";
            this.clearRecordMenuItem.Click += new System.EventHandler(this.clearRecordMenuItem_Click);
            // 
            // selectModelsMenuItem
            // 
            this.selectModelsMenuItem.Name = "selectModelsMenuItem";
            this.selectModelsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectModelsMenuItem.Text = "模板设定";
            this.selectModelsMenuItem.Click += new System.EventHandler(this.selectModelsMenuItem_Click);
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
            // MenuOpenRelay
            // 
            this.MenuOpenRelay.Name = "MenuOpenRelay";
            this.MenuOpenRelay.Size = new System.Drawing.Size(152, 22);
            this.MenuOpenRelay.Text = "打开继电器";
            this.MenuOpenRelay.Click += new System.EventHandler(this.MenuOpenRelay_Click);
            // 
            // MenuCloseRelay
            // 
            this.MenuCloseRelay.Name = "MenuCloseRelay";
            this.MenuCloseRelay.Size = new System.Drawing.Size(152, 22);
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
            this.WndLayoutHorizontal.Size = new System.Drawing.Size(152, 22);
            this.WndLayoutHorizontal.Text = "水平平铺";
            this.WndLayoutHorizontal.Click += new System.EventHandler(this.WndLayoutHorizontal_Click);
            // 
            // WndLayoutVertical
            // 
            this.WndLayoutVertical.Name = "WndLayoutVertical";
            this.WndLayoutVertical.Size = new System.Drawing.Size(152, 22);
            this.WndLayoutVertical.Text = "垂直平铺";
            this.WndLayoutVertical.Click += new System.EventHandler(this.WndLayoutVertical_Click);
            // 
            // WndLayoutCascade
            // 
            this.WndLayoutCascade.Name = "WndLayoutCascade";
            this.WndLayoutCascade.Size = new System.Drawing.Size(152, 22);
            this.WndLayoutCascade.Text = "层叠排列";
            this.WndLayoutCascade.Click += new System.EventHandler(this.WndLayoutCascade_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 341);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "输液器检测";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
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
        private System.Windows.Forms.ToolStripMenuItem MenuItemImageProcOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuImgProcSet;
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
        private System.Windows.Forms.ToolStripMenuItem selectModelsMenuItem;
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
    }
}

