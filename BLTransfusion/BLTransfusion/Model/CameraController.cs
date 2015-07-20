using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using CGSDK;
using CGAPI = CGSDK.CGAPI;
using FactoryHandle = System.IntPtr;
using DeviceHandle = System.IntPtr;
using System.Runtime.InteropServices;

namespace BLTransfusion.Model
{
    public class CameraController
    {
        private DeviceHandle mDeviceHandle = IntPtr.Zero;
        private DeviceHandle cameraPreviewHandle = IntPtr.Zero;

        public CameraController(DeviceHandle cameraPreviewHandle)
        {
            this.cameraPreviewHandle = cameraPreviewHandle;
        }

        ~CameraController()
        {
            if (this.IsOpen)
            {
                this.CloseCamera();
            }
        }
       
        private string imagePath = "Image";
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        private emDSFileType imageFileType;
        public emDSFileType ImageFileType
        {
            get { return imageFileType; }
            set { imageFileType = value; }
        }

        public bool IsOpen
        {
            get
            {
                return (mDeviceHandle != IntPtr.Zero);
            }
        }

        public bool InitCamera()
        {
            DeviceStatus devStatus = CGAPI.DeviceInitialSDK(cameraPreviewHandle, false);
            return (devStatus == DeviceStatus.STATUS_OK);
        }

        public bool SearchCameras(out int count)
        {
            count = 0;
            DeviceStatus devSatus = CGAPI.EnumDevice(IntPtr.Zero, ref count);
            return (devSatus == DeviceStatus.STATUS_OK);
        }

        public bool OpenCamera(byte cameraIndex)
        {
            if (this.IsOpen)
            {
                CloseCamera();
            }
            DeviceStatus devStatus = CGAPI.OpenDeviceByUSBAddress(cameraIndex, ref mDeviceHandle);
            if (DeviceStatus.STATUS_OK == devStatus)
            {
                devStatus = CGAPI.DeviceInit(mDeviceHandle, cameraPreviewHandle, false, true);
            }
            return (devStatus == DeviceStatus.STATUS_OK);
        }

        public bool CloseCamera()
        {
            if (this.IsOpen)
            {
                CGAPI.Stop(mDeviceHandle);
                CGAPI.CloseDevice(mDeviceHandle);
                CGAPI.DeviceUnInit(mDeviceHandle);
                CGAPI.DeviceRelease(mDeviceHandle);
                mDeviceHandle = IntPtr.Zero;
                CGAPI.DeviceUnInitialSDK();
            }
            return true;
        }

        public bool OpenSetting()
        {
            if (this.IsOpen)
            {
                DeviceStatus devStatus = CGAPI.DeviceCreateSettingPage(mDeviceHandle, this.cameraPreviewHandle, "");
                //if (devStatus == DeviceStatus.STATUS_OK)
                //{
                    devStatus = CGAPI.DeviceShowSettingPage(mDeviceHandle, true);
                //}
                return (devStatus == DeviceStatus.STATUS_OK);
            }
            return false;
        }

        public bool StartVedio()
        {
            DeviceStatus devStatus = DeviceStatus.STATUS_DEVICE_NOT_DETECTED;
             if (this.IsOpen)
             {
                 devStatus = CGAPI.Start(mDeviceHandle);
             }
            return (devStatus == DeviceStatus.STATUS_OK);
        }

        public bool StopVedio()
        {
            DeviceStatus devStatus = DeviceStatus.STATUS_DEVICE_NOT_DETECTED;
            if (this.IsOpen)
            {
                devStatus = CGAPI.Stop(mDeviceHandle);
            }
            return (devStatus == DeviceStatus.STATUS_OK);
        }

        public bool Snapshot()
        {
            return this.Snapshot(this.ImagePath, this.ImageFileType);
        }

        private bool Snapshot(string imagePath, emDSFileType fileType)
        {
            if (this.IsOpen && (CGAPI.IsReceivingData(mDeviceHandle) == 1))
            {
                DeviceStatus devStatus = CGAPI.CaptureFile(mDeviceHandle, imagePath, fileType);
                return (devStatus == DeviceStatus.STATUS_OK);
            }
            return false;
        }
    }
}
