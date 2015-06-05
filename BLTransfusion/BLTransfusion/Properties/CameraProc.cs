using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CGSDK;
using CGAPI = CGSDK.CGAPI;

using FactoryHandle = System.IntPtr;
using DeviceHandle = System.IntPtr;

namespace BLTransfusion
{
    public partial class MainForm : Form
    {
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
                                devStatus = CGAPI.DeviceInit(mDeviceHandle, pB_Image.Handle, false, true);
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
    }
}
