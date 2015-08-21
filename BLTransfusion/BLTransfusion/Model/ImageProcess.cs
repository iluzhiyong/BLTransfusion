﻿using System;
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
    public class ImageProcess : INotifyPropertyChanged
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
        HObject ho_SelectedRegions2 = null, ho_RegionErosion = null;

        // Local control variables 

        private HWindow windowHandle;
        public HWindow WindowHandle
        {
            get { return windowHandle; }
        }

        public ImageProcess(HWindow hWindow)
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
                HOperatorSet.GenEmptyObj(out ho_SelectedRegions2);
                HOperatorSet.GenEmptyObj(out ho_RegionErosion);
            }
            catch (Exception)
            {
                //MessageBox.Show("初始化错误！", "图像处理错误");
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
                //MessageBox.Show("加载图片错误！", "图像处理错误");
            }

            return true;
        }

        private byte roiMinGray = 30;
        public byte RoiMinGray
        {
            get { return roiMinGray; }
            set { roiMinGray = value; OnPropertyChanged("RoiMinGray"); }
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

        public bool SelectROI()
        {
            try
            {
                ho_Regions.Dispose();
                HOperatorSet.Threshold(ho_Image, out ho_Regions, RoiMinGray, RoiMaxGray);
                ho_ConnectedRegions.Dispose();
                HOperatorSet.Connection(ho_Regions, out ho_ConnectedRegions);
                //面积可外部调节
                ho_SelectedRegions.Dispose();
                HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegions, "area", "and", RoiMinArea, RoiMaxArea);
                //执行填充后，获得完整区域，但，中间的黑色区域可能对下面的提取造成影响
                //fill_up (SelectedRegions, RegionFillUp)
                //reduce_domain (Image, RegionFillUp, ImageReduced)
                ho_ImageReduced.Dispose();
                HOperatorSet.ReduceDomain(ho_Image, ho_SelectedRegions, out ho_ImageReduced);

                this.WindowHandle.ClearWindow();
                this.WindowHandle.DispObj(ho_ImageReduced);
            }
            catch (Exception)
            {
                //MessageBox.Show("选择ROI错误！", "图像处理错误");
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

        private int targetMinArea = 1500;
        public int TargetMinArea
        {
            get { return targetMinArea; }
            set { targetMinArea = value; }
        }

        private int targetMaxArea = 3000;
        public int TargetMaxArea
        {
            get { return targetMaxArea; }
            set { targetMaxArea = value; }
        }

        public bool DoProcess()
        {
            try
            {
                //Mask宽度、高度可外部调节
                ho_ImageMean.Dispose();
                HOperatorSet.MeanImage(ho_ImageReduced, out ho_ImageMean, MaskWidth, MaskHeight);
                //Offset可外部调节
                ho_RegionDynThresh.Dispose();
                HOperatorSet.DynThreshold(ho_ImageReduced, ho_ImageMean, out ho_RegionDynThresh, DynThreshOffset, "dark");
                //膨胀用结构元素半径可外部调节
                ho_RegionDilation.Dispose();
                HOperatorSet.DilationCircle(ho_RegionDynThresh, out ho_RegionDilation, DilationErosionRadius);
                ho_ConnectedRegions.Dispose();
                HOperatorSet.Connection(ho_RegionDilation, out ho_ConnectedRegions);
                //检测目标面积可外部调节
                ho_SelectedRegions2.Dispose();
                HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegions2, "area", "and", TargetMinArea, TargetMaxArea);
                //获得Region的骨架（执行时间54.994ms）
                //skeleton (SelectedRegions2, Skeleton)
                //使用相同的结构元素进行腐蚀，可以恢复到膨胀前的Region，而且已经是连同的Region
                //腐蚀执行时间（14.566ms）
                ho_RegionErosion.Dispose();
                HOperatorSet.ErosionCircle(ho_SelectedRegions2, out ho_RegionErosion, DilationErosionRadius);
            }
            catch (Exception)
            {
                //MessageBox.Show("处理错误！", "图像处理错误");
            }

            return true;
        }

        private int qualifiedCnt = 0;
        public int QualifiedCnt
        {
            get { return qualifiedCnt; }
            set { qualifiedCnt = value; }
        }
        private int unqualifiedCnt = 0;
        public int UnqualifiedCnt
        {
            get { return unqualifiedCnt; }
            set { unqualifiedCnt = value; }
        }
        private bool isUnqualified = false;
        public bool IsUnqualified
        {
            get { return isUnqualified; }
            set { isUnqualified = value; }
        }
        public bool CalculateResult()
        {
            try
            {
                this.WindowHandle.DispObj(ho_Image);
                HOperatorSet.CountObj(ho_RegionErosion, out hv_Number);
                this.WindowHandle.SetTposition(500, 1);

                if (hv_Number > 0)
                {
                    isUnqualified = true;
                    this.WindowHandle.DispObj(ho_RegionErosion);
                    unqualifiedCnt++;
                    this.WindowHandle.WriteString("                                                      不合格!");
                }
                else
                {
                    isUnqualified = false;
                    qualifiedCnt++;
                    this.WindowHandle.WriteString("                                                      合格!");
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("计算结果错误！", "图像处理错误");
            }

            return true;
        }


        private string imageProcSettingFilePath = "ImgProcConfig.xml";
        public string ImageProcSettingFilePath
        {
            get { return imageProcSettingFilePath; }
            set { imageProcSettingFilePath = value; }
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
                    new XAttribute("TargetMaxArea", this.TargetMaxArea)));
                doc.Save(ImageProcSettingFilePath);
            }
            catch (Exception)
            {
                //MessageBox.Show("保存参数失败！", "错误");
            }
        }

        public void LoadFromXml()
        {
            XDocument doc = XDocument.Load(ImageProcSettingFilePath);
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
            }
            catch (Exception)
            {
                //MessageBox.Show("加载参数失败！", "错误");
            }
        }
    }
}