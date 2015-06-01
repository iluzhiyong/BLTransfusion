﻿using System;
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
    public class ImageProcess
    {
        // Local iconic variables 
        HObject ho_Image = null, ho_Regions = null, ho_ConnectedRegions = null;
        HObject ho_SelectedRegions = null, ho_ImageReduced = null, ho_ImageMean = null;
        HObject ho_RegionDynThresh = null, ho_RegionDilation = null;
        HObject ho_SelectedRegions2 = null, ho_RegionErosion = null;

        // Local control variables 
        HTuple hv_WindowHandle, hv_Width = new HTuple();
        HTuple hv_Height = new HTuple(), hv_Number = new HTuple();

        public ImageProcess()
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

        public bool LoadImage(string imagePath)
        {
            ho_Image.Dispose();
            HOperatorSet.ReadImage(out ho_Image, imagePath);
            if (HDevWindowStack.IsOpen())
            {
                HOperatorSet.DispObj(ho_Image, HDevWindowStack.GetActive());
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

        public bool SelectROI()
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
            if (HDevWindowStack.IsOpen())
            {
                 HOperatorSet.DispObj(ho_ImageReduced, HDevWindowStack.GetActive());
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
            return true;
        }

        public bool CalculateResult()
        {
            if (HDevWindowStack.IsOpen())
            {
                HOperatorSet.DispObj(ho_Image, HDevWindowStack.GetActive());
            }
            HOperatorSet.CountObj(ho_RegionErosion, out hv_Number);

            HOperatorSet.SetTposition(hv_WindowHandle, 100, 1);

            if (hv_Number > 0)
            {
                if (HDevWindowStack.IsOpen())
                {
                    HOperatorSet.DispObj(ho_RegionErosion, HDevWindowStack.GetActive());
                }
                HOperatorSet.WriteString(hv_WindowHandle, "               不合格!");
            }
            else
            {
                HOperatorSet.WriteString(hv_WindowHandle, "               合格!");
            }
            return true;
        }
    }
}