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

        private void CameraSnapTimer_Tick(object sender, EventArgs e)
        {
            if (Camera_Snapshot() == true)
            {
                if (this.ImageProcess.SelectROI())
                {
                    if (this.ImageProcess.DoProcess())
                    {
                        this.ImageProcess.CalculateResult();
                    }
                }
            }
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
        private void MenuImgProcStart_Click(object sender, EventArgs e)
        {
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

                //定时拍摄图像
                this.CameraSnapTimer.Enabled = true;
            }
            catch (Exception)
            {
                this.CameraSnapTimer.Enabled = false;
                MessageBox.Show("启动失败！", "图相处理错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.CameraSnapTimer.Enabled = false;
        }

        private void MenuImgProcCntClear_Click(object sender, EventArgs e)
        {

        }
    }
}
