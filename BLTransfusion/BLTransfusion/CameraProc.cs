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
                bnStart.Text = "停止";
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
                        for (int i = 0; i < iCameraCounts; i++)
                        {
                            ComboBoxItem item = new ComboBoxItem();
                            EnumDeviceParam edp = (EnumDeviceParam)Marshal.PtrToStructure((IntPtr)((int)ptr + i * Marshal.SizeOf(new EnumDeviceParam())), typeof(EnumDeviceParam));
                            string strDevice = String.Format("{0} : {1}", edp.lpDeviceDesc, edp.devIndex);
                            item.Text = strDevice;
                            item.Value = ((edp.devIndex << 8) | edp.usbAddress);
                            mThis.AddDevice(item);
                        }
                    }
                    Marshal.FreeHGlobal(ptr);
                }
                if (cmbDevices.Items.Count > 0)
                {
                    cmbDevices.SelectedIndex = 0;
                }
            }
        }

        private void AddDevice(ComboBoxItem item)
        {
            cmbDevices.Items.Add(item);
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

                return 0;
            }
            else
            {
                return -1;
            }
        }

         DeviceStatus STATUS_DEVICE_NOT_DETECTED { get; set; }
         private int Camera_StartStop()
        {
            DeviceStatus devStatus = STATUS_DEVICE_NOT_DETECTED;
            //if (mDeviceHandle == IntPtr.Zero && bnStart.Text.Equals("开始"))
            //{
            //    Camera_Init();
            //    bnStart.Text = "停止";
            //}
            //if (mDeviceHandle != IntPtr.Zero && bnStart.Text.Equals("停止"))
            //{
            //    Camera_Closed();
            //    bnStart.Text = "开始";
            //}
            if (mDeviceHandle != IntPtr.Zero)
            {
                if (bnStart.Text.Equals("开始"))
                {
                    bnStart.Text = "停止";
                    devStatus = CGAPI.Start(mDeviceHandle);
                }
                else
                {
                    bnStart.Text = "开始";
                    devStatus = CGAPI.Stop(mDeviceHandle);
                }
                return 0;
            }
            else
            {
                LbCameraStatus.Text = String.Format("{0}", devStatus);
                return -1;
            }
        }

        private void Camera_SettingPage()
        {
            DeviceStatus devStatus = CGAPI.DeviceCreateSettingPage(mDeviceHandle, mThis.Handle, "");
            devStatus = CGAPI.DeviceShowSettingPage(mDeviceHandle, true);
            LbCameraStatus.Text = String.Format("{0}", devStatus);
        }

        private int Camera_Snapshot()
        {
            if (mDeviceHandle != DeviceHandle.Zero)
            {
                DateTime time = DateTime.Now;
                string strFile = @"Image" + time.ToFileTime();
                DeviceStatus devStatus = CGAPI.CaptureFile(mDeviceHandle, strFile, emDSFileType.FILE_BMP);
                strFile += ".bmp";
                if (DeviceStatus.STATUS_OK == devStatus)
                {
                    MessageBox.Show(strFile, "保存成功");
                }
                else
                {
                    MessageBox.Show(strFile, "保存失败");
                }

                return 0;
            }
            else
            {
                return -1;
            }
        }

        private void Camera_SelectedChanged()
        {
            ComboBoxItem selItem = (ComboBoxItem)cmbDevices.SelectedItem;
            byte byDev = (byte)((int)selItem.Value & 0xFF);
            LbCameraStatus.Text = String.Format("select id:{0}", byDev);
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
                DeviceStatus devStatus = CGAPI.OpenDeviceByUSBAddress(byDev, ref mDeviceHandle);
                if (DeviceStatus.STATUS_OK == devStatus)
                {
                    ReceiveFrameProc rfCallBack = new ReceiveFrameProc(OnReceiveFrame);
                    devStatus = CGAPI.DeviceInit(mDeviceHandle, pB_Image.Handle, false, true);
                    if (DeviceStatus.STATUS_OK == devStatus)
                    {
                    }
                }
                LbCameraStatus.Text = String.Format("{0}", devStatus);
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
