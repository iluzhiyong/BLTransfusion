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
using System.Xml.Linq;


namespace BLTransfusion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            imageDispWnd = ImageDispForm.CreateFrom();
            imageDispWnd.MdiParent = this;
            imageDispWnd.Show();

            imageProcWnd = ImageProcForm.CreateFrom();
            imageProcWnd.MdiParent = this;
            imageProcWnd.Show();
        }

        private ImageDispForm imageDispWnd;
        private ImageProcForm imageProcWnd;

        private JunkDetector junkDetector;
        public JunkDetector JunkDetector
        {
            get
            {
                if (junkDetector == null)
                {
                    junkDetector = new JunkDetector(GetHalconWindow());
                }
                return junkDetector;
            }
        }

        private RGBDetector rgbDetector;
        public RGBDetector RgbDetector
        {
            get
            {
                if (rgbDetector == null)
                {
                    rgbDetector = new RGBDetector(GetHalconWindow());
                }
                return rgbDetector;
            }
        }

        private string imagePath = "Image";
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseCamera();
        }

        private void MenuOpenUART_Click(object sender, EventArgs e)
        {
            try
            {
                SP_Open();
                this.TsUartStatus.Text = "串口：打开";
            }
            catch (Exception)
            {
                MessageBox.Show("打开串口失败！");
            }
        }

        private void MenuCloseUART_Click(object sender, EventArgs e)
        {
            SP_Close();
            this.TsUartStatus.Text = "串口：关闭";
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


        #region 模板图像处理部分

        private HWindow GetHalconWindow()
        {
            return this.imageProcWnd.hWindowControl1.HalconWindow;
        }

        private ModelProcessor modelDetector;
        public ModelProcessor ModelDetector
        {
            get
            {
                if (modelDetector == null)
                {
                    modelDetector = new ModelProcessor(GetHalconWindow());
                }
                return modelDetector;
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

        private void manualDetect_Click(object sender, EventArgs e)
        {
            if (!OpenCamera())
            {
                return;
            }

            this.IsDetecting = true;
            if (this.CameraController.Snapshot())
            {
                if (!LoadModels())
                {
                    return;
                }

                if(Detect())
                {
                    this.OkCount = this.OkCount + 1;
                }
                else
                {
                    this.NgCount = this.NgCount + 1;
                    SPCommand_OpenRelay1();
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

        public bool LoadModels()
        {
            if (!this.ModelDetector.LoadModels())
            {
                MessageBox.Show("加载模板失败！", "",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool CheckModelFile()
        {
            if (!this.ModelDetector.HasValidModelFile())
            {
                System.Windows.MessageBox.Show("没有有效的模板文件");
                return false;
            }
            return true;
        }

        public bool Detect()
        {
            LoadConfig();
            if (doJunkDetectFlag == false && doModelDetectFlag == false && doRgbDetectFlag == false)
            {
                MessageBox.Show("请选择检测项目！", "错误");
                return false;
            }

            bool junkResult = false;
            //头发检测
            if ((doJunkDetectFlag == true) && (this.JunkDetector.LoadImage(this.ImagePath)))
            {
                if (this.JunkDetector.Detect())
                {
                    junkResult = true;
                }
            }

            //模板匹配
            bool modelResult = false;
            if ((doModelDetectFlag == true) && (this.ModelDetector.LoadImage()))
            {
                if (this.ModelDetector.Detect())
                {
                    modelResult = true;
                }
            }

            //RGB检测
            bool rgbResult = false;
            if ((doRgbDetectFlag == true) && (RgbDetector.LoadImage(this.ImagePath)))
            {
                if (RgbDetector.DoDetect() == true)
                {
                    rgbResult = true;
                }
            }

            if ((doJunkDetectFlag == true) && (doModelDetectFlag == true) && (doRgbDetectFlag == true))
            {
                return ((junkResult == false) && (modelResult == true) && (rgbResult == true));
            }
            else if ((doJunkDetectFlag == true) && (doModelDetectFlag == true) && (doRgbDetectFlag == false))
            {
                return ((junkResult == false) && (modelResult == true));
            }
            else if ((doJunkDetectFlag == true) && (doModelDetectFlag == false) && (doRgbDetectFlag == true))
            {
                return ((junkResult == false) && (rgbResult == true));
            }
            else if ((doJunkDetectFlag == false) && (doModelDetectFlag == true) && (doRgbDetectFlag == true))
            {
                return ((modelResult == true) && (rgbResult == true));
            }
            else if ((doJunkDetectFlag == true) && (doModelDetectFlag == false) && (doRgbDetectFlag == false))
            {
                return (junkResult == false);
            }
            else if ((doJunkDetectFlag == false) && (doModelDetectFlag == true) && (doRgbDetectFlag == false))
            {
                return (modelResult == true);
            }
            else if ((doJunkDetectFlag == false) && (doModelDetectFlag == false) && (doRgbDetectFlag == true))
            {
                return (rgbResult == true);
            }
            else
            {
                return false;
            }
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

            if (!LoadModels())
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
                this.TsCameraStatus.Text = "相机：打开";
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
                this.ModelDetector.LoadImage();
            }
        }

        private void closeCameraMenuItem_Click(object sender, EventArgs e)
        {
            if (CloseCamera())
            {
                this.TsCameraStatus.Text = "相机：关闭";
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
        }

        private AlgorithmForm algorithmForm;
        private void MenuImgProcAlgorithmSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (algorithmForm == null || algorithmForm.IsDisposed)
                {
                    this.algorithmForm = new AlgorithmForm();
                    this.algorithmForm.JunkDetector = this.JunkDetector;
                    this.algorithmForm.ModelDetector = this.ModelDetector;
                    this.algorithmForm.RgbDetector = this.RgbDetector;
                    this.algorithmForm.Show();
                }
                else
                {
                    algorithmForm.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("算法窗口打开失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean doJunkDetectFlag = false;
        private Boolean doModelDetectFlag = false;
        private Boolean doRgbDetectFlag = false;

        public void LoadConfig()
        {
            XDocument doc = XDocument.Load("AlgorithmConfig.xml");
            XElement root = doc.Root;
            try
            {
                doJunkDetectFlag = bool.Parse(root.Attribute("DoJunkDetectFlag").Value);
                doModelDetectFlag = bool.Parse(root.Attribute("DoRgbDetectFlag").Value);
                doRgbDetectFlag = bool.Parse(root.Attribute("DoModelDetectFlag").Value);
            }
            catch (Exception)
            {
                //MessageBox.Show("加载参数失败！", "错误");
            }
        }

        private void toolStripButton_ConnectCamera_Click(object sender, EventArgs e)
        {
            openCameraMenuItem_Click(sender, e);
        }

        private void toolStripButton_Snap_Click(object sender, EventArgs e)
        {
            snapshotMenuItem_Click(sender, e);
        }

        private void toolStripButton_CameraSet_Click(object sender, EventArgs e)
        {
            cameraSettingMenuItem_Click(sender, e);
        }

        private void toolStripButton_AutoStart_Click(object sender, EventArgs e)
        {
            autoDetect_Click(sender, e);
        }

        private void toolStripButton_AutoStop_Click(object sender, EventArgs e)
        {
            stopDetect_Click(sender, e);
        }

        private void toolStripButton_ClearResult_Click(object sender, EventArgs e)
        {
            clearRecordMenuItem_Click(sender, e);
        }

    }
}
