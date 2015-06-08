using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HalconDotNet;

namespace BLTransfusion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

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
            get { return imageProcess; }
            set
            {
                imageProcess = value;
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
            //this.BeginInvoke(new Action(() =>
            //{
            //this.ClearQualifiedCount();
            //this.ClearUnqualifiedCount();
            //}), null);

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
                    //if (Camera_Snapshot() == true)
                    //{
                    //    System.Threading.Thread.Sleep(100);
                    //    if (this.ProcessWorker.CancellationPending)
                    //    {
                    //        e.Cancel = true;
                    //        break;
                    //    }
                    //    this.imageProcess.LoadImage(ImagePath);

                    //    if (this.ImageProcess.SelectROI())
                    //    {
                    //        if (this.ProcessWorker.CancellationPending)
                    //        {
                    //            e.Cancel = true;
                    //            break;
                    //        }
                    //        if (this.ImageProcess.DoProcess())
                    //        {
                    //            if (this.ProcessWorker.CancellationPending)
                    //            {
                    //                e.Cancel = true;
                    //                break;
                    //            }
                    //            if (this.ImageProcess.CalculateResult())
                    //            {
                                    //this.QualifiedCount = this.ImageProcess.QualifiedCnt;
                                    //this.UnqualifiedCount = this.ImageProcess.UnqualifiedCnt;
                                    this.QualifiedCount += 1;
                                    this.UnqualifiedCount += 1;
                                    this.ProcessWorker.ReportProgress(0);
                            //    }
                            //}
                        //}
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MenuImgProcStart_Click(object sender, EventArgs e)
        {
            if (this.ProcessWorker != null && this.ProcessWorker.IsBusy)
            {
                return;
            }
            try
            {
                HOperatorSet.SetWindowAttr("background_color", "black");
                HDevWindowStack.Push(hWindowControl1.HalconWindow);
                if (imageProcess == null)
                {
                    imageProcess = new ImageProcess();
                    imageProcess.LoadImage(ImagePath);
                }
                else
                {
                    imageProcess.LoadImage(ImagePath);
                }
                this.ClearQualifiedCount();
                this.ClearUnqualifiedCount();
                this.ProcessWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("启动失败！\r\n{0}", ex.Message), "图相处理错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ImgProcSetWnd ImgProcWnd;
        private void MenuImgProcSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (ImgProcWnd == null || ImgProcWnd.IsDisposed)
                {
                    HOperatorSet.SetWindowAttr("background_color", "black");
                    HDevWindowStack.Push(hWindowControl1.HalconWindow);
                    
                    ImgProcWnd = new ImgProcSetWnd();
                    if (imageProcess == null)
                    {
                        imageProcess = new ImageProcess();
                        imageProcess.LoadImage(ImagePath);
                    }
                    else
                    {
                        imageProcess.LoadImage(ImagePath);
                    }
                    ImgProcWnd.ImageProcess = imageProcess;
                    ImgProcWnd.Show();
                }
                else
                {
                    ImgProcWnd.Show();
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
        }

        private int qualifiedCount;
        public int QualifiedCount
        {
            get { return qualifiedCount; }
            set { qualifiedCount = value; }
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
    }
}
