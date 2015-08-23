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
    public enum RGBType
    {
        red = 0,
        green,
        blue,
    }

    public class RGBDetector : INotifyPropertyChanged
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

        HObject ho_Rgb, ho_ImageR, ho_ImageG, ho_ImageB;
        HObject ho_RegionR, ho_RegionG, ho_RegionB, ho_RGIntersection;
        HObject ho_RegionIntersection, ho_ConnectedRegions, ho_SelectedRegions;
        HObject ho_RegionFillUp = null, ho_Contours = null;
        HTuple hv_Number = null;

        private HWindow windowHandle;
        public HWindow WindowHandle
        {
            get { return windowHandle; }
        }

        public RGBDetector(HWindow hWindow)
        {
            this.windowHandle = hWindow;

            try
            {
                // Initialize local and output iconic variables 
                HOperatorSet.GenEmptyObj(out ho_Rgb);
                HOperatorSet.GenEmptyObj(out ho_ImageR);
                HOperatorSet.GenEmptyObj(out ho_ImageG);
                HOperatorSet.GenEmptyObj(out ho_ImageB);
                HOperatorSet.GenEmptyObj(out ho_RegionR);
                HOperatorSet.GenEmptyObj(out ho_RegionG);
                HOperatorSet.GenEmptyObj(out ho_RegionB);
                HOperatorSet.GenEmptyObj(out ho_RGIntersection);
                HOperatorSet.GenEmptyObj(out ho_RegionIntersection);
                HOperatorSet.GenEmptyObj(out ho_ConnectedRegions);
                HOperatorSet.GenEmptyObj(out ho_SelectedRegions);
                HOperatorSet.GenEmptyObj(out ho_RegionFillUp);
                HOperatorSet.GenEmptyObj(out ho_Contours);
            }
            catch (Exception)
            {
                //MessageBox.Show("初始化错误！", "图像处理错误");
            }

            LoadFromXml();
        }

        public bool LoadImage(string imagePath)
        {
            try
            {
                HTuple hv_width, hv_height;
                WindowHandle.ClearWindow();
                ho_Rgb.Dispose();
                HOperatorSet.ReadImage(out ho_Rgb, imagePath);
                HOperatorSet.GetImageSize(ho_Rgb, out hv_width, out hv_height);
                windowHandle.SetPart(0, 0, hv_height - 1, hv_width - 1);
                WindowHandle.DispObj(ho_Rgb);
            }
            catch (Exception)
            {
                //MessageBox.Show("加载图片错误！", "图像处理错误");
            }

            return true;
        }

        private byte redMinGray = 0;

        public byte RedMinGray
        {
            get { return redMinGray; }
            set { redMinGray = value; }
        }

        private byte redMaxGray = 128;

        public byte RedMaxGray
        {
            get { return redMaxGray; }
            set { redMaxGray = value; }
        }

        private byte greenMinGray = 0;

        public byte GreenMinGray
        {
            get { return greenMinGray; }
            set { greenMinGray = value; }
        }

        private byte greenMaxGray = 128;

        public byte GreenMaxGray
        {
            get { return greenMaxGray; }
            set { greenMaxGray = value; }
        }

        private byte blueMinGray = 0;

        public byte BlueMinGray
        {
            get { return blueMinGray; }
            set { blueMinGray = value; }
        }

        private byte blueMaxGray = 128;

        public byte BlueMaxGray
        {
            get { return blueMaxGray; }
            set { blueMaxGray = value; }
        }

        private float minArea = 1000;

        public float MinArea
        {
            get { return minArea; }
            set { minArea = value; }
        }

        private float maxArea = 100000;

        public float MaxArea
        {
            get { return maxArea; }
            set { maxArea = value; }
        }

        public bool Threshold(RGBType type)
        {
            try
            {
                ho_ImageR.Dispose(); ho_ImageG.Dispose(); ho_ImageB.Dispose();
                HOperatorSet.Decompose3(ho_Rgb, out ho_ImageR, out ho_ImageG, out ho_ImageB);
                
                switch(type)
                {
                    case RGBType.red:
                        ho_RegionR.Dispose();
                        HOperatorSet.Threshold(ho_ImageR, out ho_RegionR, RedMinGray, RedMaxGray);
                        WindowHandle.ClearWindow();
                        WindowHandle.DispObj(ho_RegionR);
                        break;

                    case RGBType.green:
                        ho_RegionG.Dispose();
                        HOperatorSet.Threshold(ho_ImageG, out ho_RegionG, GreenMinGray, GreenMaxGray);
                        WindowHandle.ClearWindow();
                        WindowHandle.DispObj(ho_RegionG);
                        break;

                    case RGBType.blue:
                        ho_RegionB.Dispose();
                        HOperatorSet.Threshold(ho_ImageB, out ho_RegionB, BlueMinGray, BlueMaxGray);
                        WindowHandle.ClearWindow();
                        WindowHandle.DispObj(ho_RegionB);
                        break;

                    default:
                        break;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private RGBType rgbType = RGBType.red;

        public RGBType RgbType
        {
            get { return rgbType; }
            set { rgbType = value; }
        }

        public bool DoDetect()
        {
            bool result = false;
            try
            {
                ho_ImageR.Dispose(); ho_ImageG.Dispose(); ho_ImageB.Dispose();
                HOperatorSet.Decompose3(ho_Rgb, out ho_ImageR, out ho_ImageG, out ho_ImageB);
                
                ho_RegionR.Dispose();
                HOperatorSet.Threshold(ho_ImageR, out ho_RegionR, RedMinGray, RedMaxGray);
                ho_RegionG.Dispose();
                HOperatorSet.Threshold(ho_ImageG, out ho_RegionG, GreenMinGray, GreenMaxGray);
                ho_RegionB.Dispose();
                HOperatorSet.Threshold(ho_ImageB, out ho_RegionB, BlueMinGray, BlueMaxGray);

                //求出三通道交集
                ho_RGIntersection.Dispose();
                HOperatorSet.Intersection(ho_RegionR, ho_RegionG, out ho_RGIntersection);
                ho_RegionIntersection.Dispose();
                HOperatorSet.Intersection(ho_RegionB, ho_RGIntersection, out ho_RegionIntersection);

                ho_ConnectedRegions.Dispose();
                HOperatorSet.Connection(ho_RegionIntersection, out ho_ConnectedRegions);

                ho_SelectedRegions.Dispose();
                HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegions, "area",
                    "and", MinArea, MaxArea);
                HOperatorSet.CountObj(ho_SelectedRegions, out hv_Number);

                if ((int)(new HTuple(hv_Number.TupleGreaterEqual(1))) != 0)
                {
                    ho_RegionFillUp.Dispose();
                    HOperatorSet.FillUp(ho_SelectedRegions, out ho_RegionFillUp);
                    ho_Contours.Dispose();
                    HOperatorSet.GenContourRegionXld(ho_RegionFillUp, out ho_Contours, "border");

                    WindowHandle.ClearWindow();

                    WindowHandle.DispObj(ho_Rgb);
                    WindowHandle.SetColor("green");
                    WindowHandle.DispObj(ho_Contours);

                    result = true;
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
                doc.Add(new XElement("RGBSetting",
                    new XAttribute("RedMinGray", this.RedMinGray),
                    new XAttribute("RedMaxGray", this.RedMaxGray),
                    new XAttribute("GreenMinGray", this.GreenMinGray),
                    new XAttribute("GreenMaxGray", this.GreenMaxGray),
                    new XAttribute("BlueMinGray", this.BlueMinGray),
                    new XAttribute("BlueMaxGray", this.BlueMaxGray),
                    new XAttribute("MinArea", this.MinArea),
                    new XAttribute("MaxArea", this.MaxArea)));
                doc.Save("RGBConfig.xml");
            }
            catch (Exception)
            {
                //MessageBox.Show("保存参数失败！", "错误");
            }
        }

        public void LoadFromXml()
        {
            XDocument doc = XDocument.Load("RGBConfig.xml");
            XElement root = doc.Root;
            try
            {
                this.RedMinGray = byte.Parse(root.Attribute("RedMinGray").Value);
                this.RedMaxGray = byte.Parse(root.Attribute("RedMaxGray").Value);
                this.GreenMinGray = byte.Parse(root.Attribute("GreenMinGray").Value);
                this.GreenMaxGray = byte.Parse(root.Attribute("GreenMaxGray").Value);
                this.BlueMinGray = byte.Parse(root.Attribute("BlueMinGray").Value);
                this.BlueMaxGray = byte.Parse(root.Attribute("BlueMaxGray").Value);

                this.MinArea = float.Parse(root.Attribute("MinArea").Value);
                this.MaxArea = float.Parse(root.Attribute("MaxArea").Value);
            }
            catch (Exception)
            {
                //MessageBox.Show("加载参数失败！", "错误");
            }
        }

    }
}