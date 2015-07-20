using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HalconDotNet;
using BLTransfusion.Model;
using BLTransfusion.View;
using System.Windows.Input;
using CGSDK;
using CGAPI = CGSDK.CGAPI;

using FactoryHandle = System.IntPtr;
using DeviceHandle = System.IntPtr;
using System.Runtime.InteropServices;


namespace BLTransfusion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            imageDispWnd = ImageDispForm.CreateFrom();
            imageDispWnd.MdiParent = this;
            imageDispWnd.Show();

            imageProcWnd = ImageProcForm.CreateFrom();
            imageProcWnd.MdiParent = this;
            imageProcWnd.Show();
        }

        private ImageDispForm imageDispWnd;
        private ImageProcForm imageProcWnd;


        #region Old 代码
        
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Camera_Closed();
        }

        private void MenuCamConnect_Click(object sender, EventArgs e)
        {
            Camera_Init();
        }

        private void MenuCamSet_Click(object sender, EventArgs e)
        {
            Camera_SettingPage();
        }

        private void MenuCamSnap_Click(object sender, EventArgs e)
        {
            Camera_Snapshot();
        }

        private void MenuCamClose_Click(object sender, EventArgs e)
        {
            Camera_Closed();
        }

        private void MenuOpenUART_Click(object sender, EventArgs e)
        {
            try
            {
                SP_Open();
                this.TsUartStatus.Text = "串口状态：打开";
            }
            catch (Exception)
            {
                MessageBox.Show("打开串口失败！");
            }
        }

        private void MenuCloseUART_Click(object sender, EventArgs e)
        {
            SP_Close();
            this.TsUartStatus.Text = "串口状态：关闭";
        }

        private void MenuOpenRelay_Click(object sender, EventArgs e)
        {
            try
            {
                SPCommand_OpenRelay1();
                //SPCommand_OpenRelay2();
            }
            catch (Exception)
            {
                MessageBox.Show("打开继电器失败!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuCloseRelay_Click(object sender, EventArgs e)
        {
            try
            {
                SPCommand_CloseRelay1();
                //SPCommand_CloseRelay2();
            }
            catch (Exception)
            {
                MessageBox.Show("关闭继电器失败!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ImageProcess imageProcess;
        public ImageProcess ImageProcess
        {
            get
            {
                if (imageProcess == null)
                {
                    imageProcess = new ImageProcess(GetHalconWindow());
                }
                return imageProcess; 
            }
        }

        BackgroundWorker processWorker;
        public BackgroundWorker ProcessWorker
        {
            get 
            {
                if (processWorker == null)
                {
                    processWorker = new BackgroundWorker();
                    processWorker.WorkerSupportsCancellation = true;
                    processWorker.WorkerReportsProgress = true;
                    processWorker.ProgressChanged += new ProgressChangedEventHandler(OnProgressChanged);
                    processWorker.DoWork += new DoWorkEventHandler(OnProcessDoWork);
                    processWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnProcessWorkerCompleted);
                }
                return processWorker; 
            }
        }

        private void OnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.UpdateQualifiedCount();
            this.UpdateUnqualifiedCount();
            this.UpdateIOResult();
        }

        private void OnProcessWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
        }
        
        private void OnProcessDoWork(object sender, DoWorkEventArgs e)
        {
            this.ImageProcess.QualifiedCnt = 0;
            this.ImageProcess.UnqualifiedCnt = 0;
            try
            {
                while (true)
                {
                    if (this.ProcessWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }

                    System.Threading.Thread.Sleep(100);
                    if (Camera_Snapshot() == true)
                    {
                        System.Threading.Thread.Sleep(100);
                        if (this.ProcessWorker.CancellationPending)
                        {
                            e.Cancel = true;
                            break;
                        }

                        this.ImageProcess.LoadImage(ImagePath);

                        if (this.ImageProcess.SelectROI())
                        {
                            if (this.ProcessWorker.CancellationPending)
                            {
                                e.Cancel = true;
                                break;
                            }
                            if (this.ImageProcess.DoProcess())
                            {
                                if (this.ProcessWorker.CancellationPending)
                                {
                                    e.Cancel = true;
                                    break;
                                }
                                if (this.ImageProcess.CalculateResult())
                                {
                                    this.QualifiedCount = this.ImageProcess.QualifiedCnt;
                                    this.UnqualifiedCount = this.ImageProcess.UnqualifiedCnt;
                                    this.CurRetIsUnQualified = this.ImageProcess.IsUnqualified;
                                    this.ProcessWorker.ReportProgress(0);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ResetControl()
        {
            GetHalconWindow().ClearWindow();
        }

        private void MenuImgProcStart_Click(object sender, EventArgs e)
        {
            if (this.ProcessWorker != null && this.ProcessWorker.IsBusy)
            {
                return;
            }
            try
            {
                this.ImageProcess.LoadImage(ImagePath);

                this.ClearQualifiedCount();
                this.ClearUnqualifiedCount();
                this.ProcessWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("启动失败！\r\n{0}", ex.Message), "图相处理错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ImgProcSetWnd imgProcWnd;
        private void MenuImgProcSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgProcWnd == null || imgProcWnd.IsDisposed)
                {
                    this.ImageProcess.LoadImage(ImagePath);

                    this.imgProcWnd = new ImgProcSetWnd();
                    this.imgProcWnd.ImageProcess = this.ImageProcess;
                    this.imgProcWnd.Show();
                }
                else
                {
                    imgProcWnd.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("设定窗口打开失败！", "图相处理错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuImgProcStop_Click(object sender, EventArgs e)
        {
            if (this.ProcessWorker != null && this.ProcessWorker.IsBusy)
            {
                this.ProcessWorker.CancelAsync();
            }
        }

        private void MenuImgProcCntClear_Click(object sender, EventArgs e)
        {
            this.ClearQualifiedCount();
            this.ClearUnqualifiedCount();
            this.OkCount = 0;
            this.NgCount = 0;
        }

        private int qualifiedCount;
        public int QualifiedCount
        {
            get { return qualifiedCount; }
            set { qualifiedCount = value; }
        }

        private bool curRetIsUnQualified = false;
        public bool CurRetIsUnQualified
        {
            get { return curRetIsUnQualified; }
            set { curRetIsUnQualified = value; }
        }

        public void UpdateIOResult()
        {
            if (curRetIsUnQualified == true)
            {
                SPCommand_OpenRelay1();
                //MessageBox.Show("不合格");
            }
            else
            {
                //MessageBox.Show("合格");
            }
        }

        public void ClearQualifiedCount()
        {
            this.QualifiedCount = 0;
            UpdateQualifiedCount();
        }

        public void UpdateQualifiedCount()
        {
           this.TsQualifiedCnt.Text = this.QualifiedCount.ToString();
        }

        private int unqualifiedCount;
        public int UnqualifiedCount
        {
            get { return unqualifiedCount; }
            set { unqualifiedCount = value; }
        }

        public void ClearUnqualifiedCount()
        {
            this.UnqualifiedCount = 0;
            UpdateUnqualifiedCount();
        }

        public void UpdateUnqualifiedCount()
        {
            this.TsUnqualifiedCnt.Text = this.UnqualifiedCount.ToString();
        }

        private void WndLayoutHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void WndLayoutVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void WndLayoutCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
            UpdateMenuItems();
        }

        private void TsCameraStatus_Click(object sender, EventArgs e)
        {

        }

        private void DrawRoiMenuItem_Click(object sender, EventArgs e)
        {
        }

        #region Old 相机处理

        static MainForm mThis;
        DeviceHandle mDeviceHandle = IntPtr.Zero;

        private int Camera_Init()
        {
            mThis = this;
            uint[] adwVersion = new uint[4];
            CGAPI.DeviceGetSDKVersion(adwVersion);
            SearchDevices();
            if (mDeviceHandle != IntPtr.Zero)
            {
                CGAPI.Start(mDeviceHandle);
                return 0;
            }
            else
            {
                return -1;
            }
        }

        private void SearchDevices()
        {
            DeviceStatus devSatus = CGAPI.DeviceInitialSDK(this.Handle, false);
            if (DeviceStatus.STATUS_OK == devSatus)
            {
                int iCameraCounts = 0;
                devSatus = CGAPI.EnumDevice(IntPtr.Zero, ref iCameraCounts);
                if (DeviceStatus.STATUS_OK == devSatus)
                {
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(new EnumDeviceParam()) * iCameraCounts);
                    devSatus = CGAPI.EnumDevice(ptr, ref iCameraCounts);
                    if (DeviceStatus.STATUS_OK == devSatus)
                    {
                        TsCameraStatus.Text = String.Format("相机状态： 未连接");
                        if (IntPtr.Zero != mDeviceHandle)
                        {
                            CGAPI.Stop(mDeviceHandle);
                            CGAPI.SyncCloseDevice(mDeviceHandle);
                            CGAPI.DeviceUnInit(mDeviceHandle);
                            CGAPI.DeviceRelease(mDeviceHandle);
                            mDeviceHandle = IntPtr.Zero;
                        }
                        else
                        {
                            DeviceStatus devStatus = CGAPI.OpenDeviceByUSBAddress(0, ref mDeviceHandle);
                            if (DeviceStatus.STATUS_OK == devStatus)
                            {
                                ReceiveFrameProc rfCallBack = new ReceiveFrameProc(OnReceiveFrame);
                                devStatus = CGAPI.DeviceInit(mDeviceHandle, this.imageDispWnd.pB_Image.Handle, false, true);
                                if (DeviceStatus.STATUS_OK == devStatus)
                                {
                                    TsCameraStatus.Text = String.Format("相机状态： 正常");
                                }
                            }
                        }
                    }
                    Marshal.FreeHGlobal(ptr);
                }
            }
        }

        private int Camera_Closed()
        {
            if (mDeviceHandle != IntPtr.Zero)
            {
                CGAPI.Stop(mDeviceHandle);
                CGAPI.CloseDevice(mDeviceHandle);
                CGAPI.DeviceUnInit(mDeviceHandle);
                CGAPI.DeviceRelease(mDeviceHandle);
                mDeviceHandle = IntPtr.Zero;
                CGAPI.DeviceUnInitialSDK();
                TsCameraStatus.Text = String.Format("相机状态： 未连接");

                return 0;
            }
            else
            {
                return -1;
            }
        }

        private void Camera_SettingPage()
        {
            if ((mDeviceHandle != DeviceHandle.Zero) && (1 == CGAPI.IsReceivingData(mDeviceHandle)))
            {
                DeviceStatus devStatus = CGAPI.DeviceCreateSettingPage(mDeviceHandle, mThis.Handle, "");
                devStatus = CGAPI.DeviceShowSettingPage(mDeviceHandle, true);
            }
            else
            {
                MessageBox.Show("相机未连接！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string imagePath = "Image";
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        private bool Camera_Snapshot()
        {
            if ((mDeviceHandle != DeviceHandle.Zero) && (1 == CGAPI.IsReceivingData(mDeviceHandle)))
            {
                DeviceStatus devStatus = CGAPI.CaptureFile(mDeviceHandle, ImagePath, emDSFileType.FILE_BMP);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void OnRecvFrame(IntPtr pDevice, IntPtr pImageBuffer, ref DeviceFrameInfo pFrInfo, IntPtr lParam)
        {
            IntPtr pRGB24Buff = IntPtr.Zero;
            if ((pRGB24Buff = CGAPI.DeviceISP(mDeviceHandle, pImageBuffer, ref pFrInfo)) != null)
            {
            }
        }

        private static void OnReceiveFrame(IntPtr pDevice, IntPtr pImageBuffer, ref DeviceFrameInfo pFrInfo, IntPtr lParam)
        {
            mThis.OnRecvFrame(pDevice, pImageBuffer, ref pFrInfo, lParam);
        }

        #endregion

        #endregion

        #region 模板图像处理部分

        private HWindow GetHalconWindow()
        {
            return this.imageProcWnd.hWindowControl1.HalconWindow;
        }

        private ModelProcessor modelProcessor;
        public ModelProcessor ModelProcessor
        {
            get
            {
                if (modelProcessor == null)
                {
                    modelProcessor = new ModelProcessor(GetHalconWindow());
                }
                return modelProcessor;
            }
        }

        private bool isDetecting = false;
        public bool IsDetecting
        {
            get { return isDetecting; }
            set 
            {
                isDetecting = value;
                this.BeginInvoke(new Action(() => UpdateMenuItems()));
            }
        }

        private long okCount = 0;
        public long OkCount
        {
            get { return okCount; }
            set
            { 
                okCount = value; 
                this.BeginInvoke(new Action(()=>
                    {
                        this.TsQualifiedCnt.Text = this.okCount.ToString();
                    }));
            }
        }

        private long ngCount = 0;
        public long NgCount
        {
            get { return ngCount; }
            set 
            { 
                ngCount = value;
                this.BeginInvoke(new Action(()=>
                    {
                        this.TsUnqualifiedCnt.Text = this.ngCount.ToString();
                    }));
            }
        }
        
        private SelectModels selectModelsWnd;
        private void selectModelsMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectModelsWnd == null || selectModelsWnd.IsDisposed)
                {
                    this.selectModelsWnd = new SelectModels(this.ModelProcessor) { Owner = this };
                }
                selectModelsWnd.Show();
            }
            catch (Exception ex)
            {
                ex.GetType();
                MessageBox.Show("设定窗口打开失败！", "图相处理错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void manualDetect_Click(object sender, EventArgs e)
        {
            if (!OpenCamera())
            {
                return;
            }

            this.IsDetecting = true;
            if (this.CameraController.Snapshot())
            {
                if (!LoadICModels())
                {
                    return;
                }

                if (this.ModelProcessor.Detect())
                {
                    this.OkCount = this.OkCount + 1;
                }
                else
                {
                    this.NgCount = this.NgCount + 1;
                }
            }
            else
            {
                MessageBox.Show("拍摄图像失败！");
            }
            this.IsDetecting = false;
        }

        private void autoDetect_Click(object sender, EventArgs e)
        {
            if (this.worker == null || !this.worker.IsBusy)
            {
                StartAutoDetect();
            }
        }

        private void stopDetect_Click(object sender, EventArgs e)
        {
            StopAutoDetect();
        }

        private void clearRecordMenuItem_Click(object sender, EventArgs e)
        {
            ClearResultRecords();
        }

        private void ClearResultRecords()
        {
            this.OkCount = 0;
            this.NgCount = 0;
        }

        public bool LoadICModels()
        {
            if (!this.ModelProcessor.LoadModels())
            {
                MessageBox.Show("加载芯片模板失败！", "",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool CheckModelFile()
        {
            if (!this.ModelProcessor.HasValidModelFile())
            {
                System.Windows.MessageBox.Show("没有有效的模板文件");
                return false;
            }
            return true;
        }

        public bool Detect()
        {
            bool result = false;
            //头发检测
            if (this.ImageProcess.LoadImage(this.ImagePath))
            {
                if (this.ImageProcess.DoProcess())
                {
                    result = true;
                }
            }

            //模板匹配
            if (this.ModelProcessor.LoadImage())
            {
                if (!this.ModelProcessor.Detect())
                {
                    result = false;
                }
            }

            return result;
        }

        private BackgroundWorker worker;
        public bool StartAutoDetect()
        {
            if (!OpenCamera())
            {
                return false;
            }

            if (!CheckModelFile())
            {
                return false;
            }

            if (this.worker != null && this.worker.IsBusy)
            {
                return false;
            }

            if (this.worker == null)
            {
                this.worker = new BackgroundWorker();
                this.worker.WorkerSupportsCancellation = true;
                this.worker.WorkerReportsProgress = true;
                this.worker.DoWork += new DoWorkEventHandler(OnCyclicDetect);
                this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnCyclicDetectCompleted);
            }
            this.IsDetecting = true;

            if (!LoadICModels())
            {
                return false;
            }

            this.worker.RunWorkerAsync();
            return true;
        }

        public bool StopAutoDetect()
        {
            if (this.worker != null && this.worker.IsBusy)
            {
                this.worker.CancelAsync();
            }
            return true;
        }

        #region Simuluate Detect

        private void OnCyclicDetectCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.IsDetecting = false;
            CommandManager.InvalidateRequerySuggested();
        }

        private void OnCyclicDetect(object sender, DoWorkEventArgs e)
        {
            var interval = new TimeSpan(0, 0, 1);
            var startTime = DateTime.Now;
            bool cancel = false;
            while (true)
            {
                while ((DateTime.Now - startTime).Ticks < interval.Ticks)
                {
                    if (this.worker.CancellationPending)
                    {
                        cancel = true;
                        break;
                    }
                    System.Threading.Thread.Sleep(100);
                }

                if (cancel)
                {
                    break;
                }

                startTime = DateTime.Now;
                if (this.worker.CancellationPending)
                {
                    cancel = true;
                    break;
                }

                if (!this.CameraController.Snapshot())
                {
                    break;
                }

                if (Detect())
                {
                    this.OkCount = this.OkCount + 1;
                }
                else
                {
                    this.NgCount = this.NgCount + 1;
                }
            }
        }

        #endregion

        #endregion

        #region 相机操作部分

        public bool CameraIsOpen
        {
            get
            {
                return this.cameraController != null && this.cameraController.IsOpen;
            }
        }

        IntPtr GetCameraDispWnd()
        {
            return this.imageDispWnd.pB_Image.Handle;
        }

        private CameraController cameraController;
        public CameraController CameraController
        {
            get
            {
                if (cameraController == null)
                {
                    cameraController = new CameraController(GetCameraDispWnd());
                }
                return cameraController;
            }
        }

        private void openCameraMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenCamera())
            {
                this.TsCameraStatus.Text = "已连接";
            }
            else
            {
                System.Windows.MessageBox.Show("打开相机失败！");
            }
            UpdateMenuItems();
        }

        private void snapshotMenuItem_Click(object sender, EventArgs e)
        {
            if (!Snapshot())
            {
                System.Windows.MessageBox.Show("拍摄照片失败！");
            }
            else
            {
                System.Threading.Thread.Sleep(100);
                this.ModelProcessor.LoadImage();
            }
        }

        private void closeCameraMenuItem_Click(object sender, EventArgs e)
        {
            if (CloseCamera())
            {
                this.TsCameraStatus.Text = "未连接";
            }
            else
            {
                System.Windows.MessageBox.Show("关闭相机失败！");
            }
            UpdateMenuItems();
        }

        private void cameraSettingMenuItem_Click(object sender, EventArgs e)
        {
            OpenCameraSetting();
        }

        public bool OpenCamera()
        {
            if (!this.CameraController.IsOpen)
            {
                if (this.CameraController != null)
                {
                    if (this.CameraController.InitCamera())
                    {
                        int count = 0;
                        if (this.CameraController.SearchCameras(out count) && count != 0)
                        {
                            if (this.CameraController.OpenCamera(0))
                            {
                                return this.CameraController.StartVedio();
                            }
                        }
                    }
                }
                return false;
            }
            return true;
        }

        public bool Snapshot()
        {
            if (this.CameraController.IsOpen)
            {
                return this.CameraController.Snapshot();
            }
            return false;
        }

        public bool CloseCamera()
        {
            if (this.CameraController.IsOpen)
            {
                return this.CameraController.CloseCamera();
            }
            return true;
        }

        public void OpenCameraSetting()
        {
            if (this.CameraController.IsOpen)
            {
                this.CameraController.OpenSetting();
            }
        }

        #endregion

        private void UpdateMenuItems()
        {
            this.openCameraMenuItem.Enabled = !this.CameraIsOpen && !this.IsDetecting;
            this.snapshotMenuItem.Enabled = this.CameraIsOpen && !this.IsDetecting;
            this.closeCameraMenuItem.Enabled = this.CameraIsOpen && !this.IsDisposed;

            this.cameraSettingMenuItem.Enabled = this.CameraIsOpen && !this.IsDisposed;

            this.manualDetect.Enabled = this.CameraIsOpen && !this.IsDetecting;
            this.autoDetect.Enabled = this.CameraIsOpen && !this.IsDetecting;
            this.stopDetect.Enabled = this.IsDetecting;

            this.selectModelsMenuItem.Enabled = !this.IsDetecting;
            this.MenuImgProcSet.Enabled = !this.IsDetecting;
        }
    }
}
