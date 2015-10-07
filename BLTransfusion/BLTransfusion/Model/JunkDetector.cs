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
        HObject ho_Image, ho_SE, ho_ImageBotHat, ho_Region;
        HObject ho_ConnectedRegionsPre, ho_SelectedRegionsPre, ho_Ellipse;
        HObject ho_RegionDilation, ho_RegionUnion, ho_ConnectedRegions;
        HObject ho_SelectedRegions, ho_Skeleton = null;

        // Local control variables 
        HTuple hv_Number = null;

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
                HOperatorSet.GenEmptyObj(out ho_SE);
                HOperatorSet.GenEmptyObj(out ho_ImageBotHat);
                HOperatorSet.GenEmptyObj(out ho_Region);
                HOperatorSet.GenEmptyObj(out ho_ConnectedRegionsPre);
                HOperatorSet.GenEmptyObj(out ho_SelectedRegionsPre);
                HOperatorSet.GenEmptyObj(out ho_Ellipse);
                HOperatorSet.GenEmptyObj(out ho_RegionDilation);
                HOperatorSet.GenEmptyObj(out ho_RegionUnion);
                HOperatorSet.GenEmptyObj(out ho_ConnectedRegions);
                HOperatorSet.GenEmptyObj(out ho_SelectedRegions);
                HOperatorSet.GenEmptyObj(out ho_Skeleton);
            }
            catch (Exception)
            {

            }

            this.LoadFromXml();
        }

        HTuple hv_Width = new HTuple();
        HTuple hv_Height = new HTuple();

        private string imagePath = "image";
        public bool LoadImage(string imagepath)
        {
            try
            {
                imagePath = imagepath;
                ho_Image.Dispose();
                HOperatorSet.ReadImage(out ho_Image, imagepath);
                HOperatorSet.GetImageSize(ho_Image, out hv_Width, out hv_Height);
                this.WindowHandle.SetPart(0, 0, hv_Height - 1, hv_Width - 1);
                this.WindowHandle.DispObj(ho_Image);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private int seWidth = 3;
        public int SeWidth
        {
            get { return seWidth; }
            set { seWidth = value; }
        }

        private int seHeight = 3;
        public int SeHeight
        {
            get { return seHeight; }
            set { seHeight = value; }
        }

        private byte roiMinGray = 20;
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

        private int roiMinArea = 5;
        public int RoiMinArea
        {
            get { return roiMinArea; }
            set { roiMinArea = value; }
        }

        private int roiMaxArea = 99999;
        public int RoiMaxArea
        {
            get { return roiMaxArea; }
            set { roiMaxArea = value; }
        }

        public bool SelectROI()
        {
            try
            {
                LoadImage(imagePath);

                //底帽变换，高亮图像中暗的像素点
                ho_SE.Dispose();
                HOperatorSet.GenDiscSe(out ho_SE, "byte", seWidth, seHeight, 0);
                ho_ImageBotHat.Dispose();
                HOperatorSet.GrayBothat(ho_Image, ho_SE, out ho_ImageBotHat);

                //去除底帽变换后小的斑点
                ho_Region.Dispose();
                HOperatorSet.Threshold(ho_ImageBotHat, out ho_Region, RoiMinGray, RoiMaxGray);
                ho_ConnectedRegionsPre.Dispose();
                HOperatorSet.Connection(ho_Region, out ho_ConnectedRegionsPre);
                ho_SelectedRegionsPre.Dispose();
                HOperatorSet.SelectShape(ho_ConnectedRegionsPre, out ho_SelectedRegionsPre, "area",
                    "and", RoiMinArea, RoiMaxArea);

                this.WindowHandle.ClearWindow();
                this.WindowHandle.DispObj(ho_SelectedRegionsPre);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private float maskWidth = 30;
        public float MaskWidth
        {
            get { return maskWidth; }
            set { maskWidth = value; }
        }

        private float maskHeight = 30;
        public float MaskHeight
        {
            get { return maskHeight; }
            set { maskHeight = value; }
        }

        private int targetMinArea = 15000;
        public int TargetMinArea
        {
            get { return targetMinArea; }
            set { targetMinArea = value; }
        }

        private int targetMaxArea = 999999;
        public int TargetMaxArea
        {
            get { return targetMaxArea; }
            set { targetMaxArea = value; }
        }

        private float targetMinAnisometry = 1.5f;
        public float TargetMinAnisometry
        {
            get { return targetMinAnisometry; }
            set { targetMinAnisometry = value; }
        }

        private float targetMaxAnisometry = 10.0f;
        public float TargetMaxAnisometry
        {
            get { return targetMaxAnisometry; }
            set { targetMaxAnisometry = value; }
        }

        private int targetMinOuterRadius = 100;
        public int TargetMinOuterRadius
        {
            get { return targetMinOuterRadius; }
            set { targetMinOuterRadius = value; }
        }

        private int targetMaxOuterRadius = 2000;
        public int TargetMaxOuterRadius
        {
            get { return targetMaxOuterRadius; }
            set { targetMaxOuterRadius = value; }
        }

        private float targetMinDistDeviation = 40.0f;
        public float TargetMinDistDeviation
        {
            get { return targetMinDistDeviation; }
            set { targetMinDistDeviation = value; }
        }

        private float targetMaxDistDeviation = 300.0f;
        public float TargetMaxDistDeviation
        {
            get { return targetMaxDistDeviation; }
            set { targetMaxDistDeviation = value; }
        }

        public bool Detect()
        {
            bool result = false;
            try
            {
                if (SelectROI() == false)
                {
                    return false;
                }
                
                //将分割的物体连接
                ho_Ellipse.Dispose();
                HOperatorSet.GenEllipse(out ho_Ellipse, 200, 200, 0, maskWidth, maskHeight);
                ho_RegionDilation.Dispose();
                HOperatorSet.Dilation1(ho_SelectedRegionsPre, ho_Ellipse, out ho_RegionDilation, 1);
                ho_RegionUnion.Dispose();
                HOperatorSet.Union1(ho_RegionDilation, out ho_RegionUnion);
                ho_ConnectedRegions.Dispose();
                HOperatorSet.Connection(ho_RegionUnion, out ho_ConnectedRegions);

                //目标选择
                ho_SelectedRegions.Dispose();
                HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegions, 
                    (((new HTuple("area")).TupleConcat("anisometry")).TupleConcat("outer_radius")).TupleConcat("dist_deviation"),
                    "and",
                    (((new HTuple(targetMinArea)).TupleConcat(targetMinAnisometry)).TupleConcat(targetMinOuterRadius)).TupleConcat(targetMinDistDeviation),
                    (((new HTuple(targetMaxArea)).TupleConcat(targetMaxAnisometry)).TupleConcat(targetMaxOuterRadius)).TupleConcat(targetMaxDistDeviation));

                //显示结果
                HOperatorSet.CountObj(ho_SelectedRegions, out hv_Number);
                this.WindowHandle.ClearWindow();
                this.WindowHandle.DispObj(ho_Image);
                if ((int)(new HTuple(hv_Number.TupleGreater(0))) != 0)
                {
                    ho_Skeleton.Dispose();
                    HOperatorSet.Skeleton(ho_SelectedRegions, out ho_Skeleton);
                    HOperatorSet.SetColor(windowHandle, "red");
                    this.WindowHandle.DispObj(ho_Skeleton);
                    this.WindowHandle.WriteString("                                                      不合格!");
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

        public void SaveToXml()
        {
            try
            {
                XDocument doc = new XDocument();
                doc.Add(new XElement("ProcessSetting",
                    new XAttribute("SeWidth", this.SeWidth),
                    new XAttribute("SeHeight", this.SeHeight),
                    new XAttribute("RoiMinGray", this.RoiMinGray),
                    new XAttribute("RoiMaxGray", this.RoiMaxGray),
                    new XAttribute("RoiMinArea", this.RoiMinArea),
                    new XAttribute("RoiMaxArea", this.RoiMaxArea),
                    new XAttribute("MaskWidth", this.MaskWidth),
                    new XAttribute("MaskHeight", this.MaskHeight),
                    new XAttribute("TargetMinArea", this.TargetMinArea),
                    new XAttribute("TargetMaxArea", this.TargetMaxArea),
                    new XAttribute("TargetMinAnisometry", this.TargetMinAnisometry),
                    new XAttribute("TargetMaxAnisometry", this.TargetMaxAnisometry),
                    new XAttribute("TargetMinOuterRadius", this.TargetMinOuterRadius),
                    new XAttribute("TargetMaxOuterRadius", this.TargetMaxOuterRadius),
                    new XAttribute("TargetMinDistDeviation", this.TargetMinDistDeviation),
                    new XAttribute("TargetMaxDistDeviation", this.TargetMaxDistDeviation)));
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
                this.SeWidth = int.Parse(root.Attribute("SeWidth").Value);
                this.SeHeight = int.Parse(root.Attribute("SeWidth").Value);
                this.RoiMinGray = byte.Parse(root.Attribute("RoiMinGray").Value);
                this.RoiMaxGray = byte.Parse(root.Attribute("RoiMaxGray").Value);
                this.RoiMinArea = int.Parse(root.Attribute("RoiMinArea").Value);
                this.RoiMaxArea = int.Parse(root.Attribute("RoiMaxArea").Value);

                this.MaskWidth = float.Parse(root.Attribute("MaskWidth").Value);
                this.MaskHeight = float.Parse(root.Attribute("MaskHeight").Value);
                this.TargetMinArea = int.Parse(root.Attribute("TargetMinArea").Value);
                this.TargetMaxArea = int.Parse(root.Attribute("TargetMaxArea").Value);
                this.TargetMinAnisometry = float.Parse(root.Attribute("TargetMinAnisometry").Value);
                this.TargetMaxAnisometry = float.Parse(root.Attribute("TargetMaxAnisometry").Value);
                this.TargetMinOuterRadius = int.Parse(root.Attribute("TargetMinOuterRadius").Value);
                this.TargetMaxOuterRadius = int.Parse(root.Attribute("TargetMaxOuterRadius").Value);
                this.TargetMinDistDeviation = float.Parse(root.Attribute("TargetMinDistDeviation").Value);
                this.TargetMaxDistDeviation = float.Parse(root.Attribute("TargetMaxDistDeviation").Value);
            }
            catch (Exception)
            {
                //MessageBox.Show("加载参数失败！", "错误");
            }
        }
    }
}