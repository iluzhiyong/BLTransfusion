using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HalconDotNet;
using System.Xml.Linq;

namespace BLTransfusion
{
    public class JunkDetector : INotifyPropertyChanged
    {

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        // Local iconic variables 
        HObject ho_Image = null, ho_Regions = null, ho_ConnectedRegions = null;
        HObject ho_SelectedRegions = null, ho_ImageReduced = null, ho_ImageMean = null;
        HObject ho_RegionDynThresh = null, ho_RegionDilation = null;
        HObject ho_TargetRegions = null, ho_RegionErosion = null;

        // Local control variables 

        private HWindow windowHandle;
        public HWindow WindowHandle
        {
            get { return windowHandle; }
        }

        public JunkDetector(HWindow hWindow)
        {
            this.windowHandle = hWindow;

            try
            {
                // Initialize local and output iconic variables 
                HOperatorSet.GenEmptyObj(out ho_Image);
                HOperatorSet.GenEmptyObj(out ho_Regions);
                HOperatorSet.GenEmptyObj(out ho_ConnectedRegions);
                HOperatorSet.GenEmptyObj(out ho_SelectedRegions);
                HOperatorSet.GenEmptyObj(out ho_ImageReduced);
                HOperatorSet.GenEmptyObj(out ho_ImageMean);
                HOperatorSet.GenEmptyObj(out ho_RegionDynThresh);
                HOperatorSet.GenEmptyObj(out ho_RegionDilation);
                HOperatorSet.GenEmptyObj(out ho_TargetRegions);
                HOperatorSet.GenEmptyObj(out ho_RegionErosion);
            }
            catch (Exception)
            {

            }

            this.LoadFromXml();
        }

        HTuple hv_Width = new HTuple();
        HTuple hv_Height = new HTuple(), hv_Number = new HTuple();

        public bool LoadImage(string imagePath)
        {
            try
            {
                ho_Image.Dispose();
                HOperatorSet.ReadImage(out ho_Image, imagePath);
                HOperatorSet.GetImageSize(ho_Image, out hv_Width, out hv_Height);
                this.WindowHandle.SetPart(0, 0, hv_Height - 1, hv_Width - 1);
                this.WindowHandle.DispObj(ho_Image);
            }
            catch (Exception)
            {
                
            }

            return true;
        }

        private byte roiMinGray = 30;
        public byte RoiMinGray
        {
            get { return roiMinGray; }
            set { roiMinGray = value; }
        }

        private byte roiMaxGray = 255;
        public byte RoiMaxGray
        {
            get { return roiMaxGray; }
            set { roiMaxGray = value; }
        }

        private int roiMinArea = 800;
        public int RoiMinArea
        {
            get { return roiMinArea; }
            set { roiMinArea = value; }
        }

        private int roiMaxArea = 1500000;
        public int RoiMaxArea
        {
            get { return roiMaxArea; }
            set { roiMaxArea = value; }
        }

        private float targetMinRect = 0.0f;

        public float TargetMinRect
        {
            get { return targetMinRect; }
            set { targetMinRect = value; }
        }

        private float targetMaxRect = 0.2f;

        public float TargetMaxRect
        {
            get { return targetMaxRect; }
            set { targetMaxRect = value; }
        }

        public bool SelectROI()
        {
            try
            {
                ho_Regions.Dispose();
                HOperatorSet.Threshold(ho_Image, out ho_Regions, RoiMinGray, RoiMaxGray);
                ho_ConnectedRegions.Dispose();
                HOperatorSet.Connection(ho_Regions, out ho_ConnectedRegions);

                ho_SelectedRegions.Dispose();
                HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegions, "area", "and", RoiMinArea, RoiMaxArea);
                ho_ImageReduced.Dispose();
                HOperatorSet.ReduceDomain(ho_Image, ho_SelectedRegions, out ho_ImageReduced);

                this.WindowHandle.ClearWindow();
                this.WindowHandle.DispObj(ho_ImageReduced);
            }
            catch (Exception)
            {
                
            }

            return true;
        }

        private int maskWidth = 9;
        public int MaskWidth
        {
            get { return maskWidth; }
            set { maskWidth = value; }
        }

        private int maskHeight = 9;
        public int MaskHeight
        {
            get { return maskHeight; }
            set { maskHeight = value; }
        }

        private int dynThreshOffset = 9;
        public int DynThreshOffset
        {
            get { return dynThreshOffset; }
            set { dynThreshOffset = value; }
        }

        private double dilationErosionRadius = 3.5;
        public double DilationErosionRadius
        {
            get { return dilationErosionRadius; }
            set { dilationErosionRadius = value; }
        }

        private int targetMinArea = 100000;
        public int TargetMinArea
        {
            get { return targetMinArea; }
            set { targetMinArea = value; }
        }

        private int targetMaxArea = 300000;
        public int TargetMaxArea
        {
            get { return targetMaxArea; }
            set { targetMaxArea = value; }
        }

        public bool Detect()
        {
            bool result = false;
            try
            {
                ho_ImageMean.Dispose();
                HOperatorSet.MeanImage(ho_ImageReduced, out ho_ImageMean, MaskWidth, MaskHeight);

                ho_RegionDynThresh.Dispose();
                HOperatorSet.DynThreshold(ho_ImageReduced, ho_ImageMean, out ho_RegionDynThresh, DynThreshOffset, "dark");

                ho_RegionDilation.Dispose();
                HOperatorSet.DilationCircle(ho_RegionDynThresh, out ho_RegionDilation, DilationErosionRadius);
                
                ho_ConnectedRegions.Dispose();
                HOperatorSet.Connection(ho_RegionDilation, out ho_ConnectedRegions);

                ho_TargetRegions.Dispose();
                HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_TargetRegions,
                    (new HTuple("area")).TupleConcat("rectangularity"), "and", (new HTuple(TargetMinArea)).TupleConcat(TargetMinRect), (new HTuple(TargetMaxArea)).TupleConcat(TargetMaxRect));

                ho_RegionErosion.Dispose();
                HOperatorSet.ErosionCircle(ho_TargetRegions, out ho_RegionErosion, DilationErosionRadius);

                //显示结果
                this.WindowHandle.DispObj(ho_Image);
                HOperatorSet.CountObj(ho_RegionErosion, out hv_Number);
                if ((int)(new HTuple(hv_Number.TupleGreaterEqual(1))) != 0)
                {
                    WindowHandle.DispObj(ho_RegionErosion);
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        public bool CalculateResult()
        {
            try
            {
                this.WindowHandle.DispObj(ho_Image);
                HOperatorSet.CountObj(ho_RegionErosion, out hv_Number);

                if (hv_Number > 0)
                {
                    this.WindowHandle.DispObj(ho_RegionErosion);
                    this.WindowHandle.WriteString("                                                      不合格!");
                }
                else
                {
                    this.WindowHandle.WriteString("                                                      合格!");
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("计算结果错误！", "图像处理错误");
            }

            return true;
        }

        public void SaveToXml()
        {
            try
            {
                XDocument doc = new XDocument();
                doc.Add(new XElement("ProcessSetting",
                    new XAttribute("RoiMinGray", this.RoiMinGray),
                    new XAttribute("RoiMaxGray", this.RoiMaxGray),
                    new XAttribute("RoiMinArea", this.RoiMinArea),
                    new XAttribute("RoiMaxArea", this.RoiMaxArea),
                    new XAttribute("MaskWidth", this.MaskWidth),
                    new XAttribute("MaskHeight", this.MaskHeight),
                    new XAttribute("DynThreshOffset", this.DynThreshOffset),
                    new XAttribute("DilationErosionRadius", this.DilationErosionRadius),
                    new XAttribute("TargetMinArea", this.TargetMinArea),
                    new XAttribute("TargetMaxArea", this.TargetMaxArea),
                    new XAttribute("TargetMinRect", this.TargetMinRect),
                    new XAttribute("TargetMaxRect", this.TargetMaxRect)));
                doc.Save("JunkDetectorConfig.xml");
                MessageBox.Show("保存参数成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("保存参数失败！", "错误");
            }
        }

        public void LoadFromXml()
        {
            XDocument doc = XDocument.Load("JunkDetectorConfig.xml");
            XElement root = doc.Root;
            try
            {
                this.RoiMinGray = byte.Parse(root.Attribute("RoiMinGray").Value);
                this.RoiMaxGray = byte.Parse(root.Attribute("RoiMaxGray").Value);

                this.RoiMinArea = int.Parse(root.Attribute("RoiMinArea").Value);
                this.RoiMaxArea = int.Parse(root.Attribute("RoiMaxArea").Value);

                this.MaskWidth = int.Parse(root.Attribute("MaskWidth").Value);
                this.MaskHeight = int.Parse(root.Attribute("MaskHeight").Value);

                this.DynThreshOffset = int.Parse(root.Attribute("DynThreshOffset").Value);

                this.DilationErosionRadius = double.Parse(root.Attribute("DilationErosionRadius").Value);

                this.TargetMinArea = int.Parse(root.Attribute("TargetMinArea").Value);
                this.TargetMaxArea = int.Parse(root.Attribute("TargetMaxArea").Value);

                this.TargetMinRect = float.Parse(root.Attribute("TargetMinRect").Value);
                this.TargetMaxRect = float.Parse(root.Attribute("TargetMaxRect").Value);
            }
            catch (Exception)
            {
                //MessageBox.Show("加载参数失败！", "错误");
            }
        }
    }
}