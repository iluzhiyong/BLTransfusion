using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HalconDotNet;
using System.Xml.Linq;
using System.IO;
using BLTransfusion.Utility;

namespace BLTransfusion.Model
{

    public enum OptimizationType
    {
        auto = 0,
        none,
        point_reduction_low,
        point_reduction_medium,
        point_reduction_high,
        pregeneration,
        no_pregeneration,
    }

    public enum MetricType
    {
        use_polarity = 0,
        ignore_global_polarity,
        ignore_local_polarity,
        ignore_color_polarity,
    }

    public enum ContrastType
    {
        auto = 0,
        auto_contrast,
        auto_contrast_hyst,
        auto_min_size,
        user_defined,
    }

    public enum SubPixelType
    {
        none = 0,
        interpolation,
        least_squares,
        least_squares_high,
        least_squares_very_high,
        max_deformation_1,
        max_deformation_2,
        max_deformation_3,
        max_deformation_4,
        max_deformation_5,
        max_deformation_6,
    }

    public class ShapeModelMatchProcess : ModelInfo, IDisposable
    {
        public HWindow WindowHandle { get; set; }

        public HObject Image { get; set; }

        private HTuple modelID;
        public HTuple ModelID
        {
            get { return modelID; }
            set { modelID = value; }
        }

        HObject ho_Rectangle, ho_ImageRegion;
        HObject ho_ModelImages, ho_ModelRegions;

        public ShapeModelMatchProcess()
        {
            HOperatorSet.GenEmptyObj(out ho_Rectangle);
            HOperatorSet.GenEmptyObj(out ho_ImageRegion);
            HOperatorSet.GenEmptyObj(out ho_ModelImages);
            HOperatorSet.GenEmptyObj(out ho_ModelRegions);
        }

        public bool DoInspectShapeModel()
        {
            ho_Rectangle.Dispose();
            HOperatorSet.GenRectangle1(out ho_Rectangle, RowTop, ColumnLeft, RowBottom, ColumnRight);
            WindowHandle.SetLineWidth(3);
            WindowHandle.SetDraw("margin");
            WindowHandle.SetColor("blue");
            WindowHandle.DispObj(ho_Rectangle);

            ho_ImageRegion.Dispose();
            HOperatorSet.ReduceDomain(Image, ho_Rectangle, out ho_ImageRegion);

            ho_ModelImages.Dispose();
            ho_ModelRegions.Dispose();
            HOperatorSet.InspectShapeModel(ho_ImageRegion, out ho_ModelImages, out ho_ModelRegions, InspectNumLevels, InspectContrast);

            WindowHandle.DispObj(ho_ModelRegions);

            return true;
        }

        public bool DoCreateShapeModel()
        {
            HOperatorSet.CreateScaledShapeModel(ho_ImageRegion,
                (NumLevelsAuto) ? new HTuple("auto") : new HTuple(NumLevels),
                (new HTuple(AngleStart)).TupleRad(), (new HTuple(AngleExtent)).TupleRad(),
                (AngleStepAuto) ? new HTuple("auto") : (new HTuple(AngleStep)).TupleRad(),
                ScaleMin, ScaleMax,
                (ScaleStepAuto) ? new HTuple("auto") : new HTuple(ScaleStep), Optimization.ToString(), Metric.ToString(),
                (Contrast == ContrastType.user_defined) ? new HTuple(ContrastValue) : new HTuple(new string[] { Contrast.ToString() }),
                (MinContrastAuto) ? new HTuple("auto") : new HTuple(MinContrast), out modelID);
            return true;
        }

        public bool SaveShapeModel()
        {
            HOperatorSet.WriteShapeModel(ModelID, ModeFilePath);
            return true;
        }

        public bool LoadShapeModel()
        {
            HOperatorSet.ReadShapeModel(ModeFilePath, out modelID);
            return true;
        }

        public bool DoFindScaledShapeModel()
        {
            HTuple hv_Row, hv_Column;
            HTuple hv_Angle, hv_Scale, hv_Score, hv_I;

            HOperatorSet.FindScaledShapeModel(Image, ModelID,
                (new HTuple(MatchAngleStart)).TupleRad(), (new HTuple(MatchAngleExtent)).TupleRad(),
                MatchScaleMin, MatchScaleMax, MatchMinScore, NumMatches,
                MaxOverlap, SubPixelString, MatchNumLevels, MatchGreediness,
                out hv_Row, out hv_Column, out hv_Angle, out hv_Scale, out hv_Score);

            //TODO: 判断有没有找到结果 ResultScore & ResultCount
            int count = 0;
            double w = this.ColumnRight - this.ColumnLeft;
            double h = this.RowBottom - this.RowTop;
            for (hv_I = 0; (int)hv_I <= (int)((new HTuple(hv_Score.TupleLength())) - 1); hv_I = (int)hv_I + 1)
            {
                if (hv_Score.TupleSelect(hv_I) >= this.ResultScore)
                {
                    count++;
                    HObject ho_Rectangle;
                    HOperatorSet.GenRectangle1(out ho_Rectangle, hv_Row.TupleSelect(hv_I) - h/2, hv_Column.TupleSelect(hv_I) - w/2, hv_Row.TupleSelect(hv_I)  + h/2, hv_Column.TupleSelect(hv_I) + w/2);
                    this.WindowHandle.SetLineWidth(3);
                    this.WindowHandle.SetDraw("margin");
                    this.WindowHandle.SetColor("red");
                    this.WindowHandle.DispObj(ho_Rectangle);
                    ho_Rectangle.Dispose();
                }
            }
            return (count == this.ResultCount);
        }

        public void Dispose()
        {
            ho_Rectangle.Dispose();
            ho_ImageRegion.Dispose();
            ho_ModelImages.Dispose();
            ho_ModelRegions.Dispose();
        }

        public int ModelIndex { get; set; }

        public string ModeFilePath
        {
            get
            {
                return Path.Combine(FilePathUtility.GetAssemblyPath(), string.Format("model{0}.shm", ModelIndex));
            }
        }

        //InspectShapeModel
        private int inspectNumLevels = 10;
        public int InspectNumLevels
        {
            get { return inspectNumLevels; }
            set { inspectNumLevels = value; }
        }

        private int inspectContrast = 60;
        public int InspectContrast
        {
            get { return inspectContrast; }
            set { inspectContrast = value; }
        }

        //CreateScaledShapeModel
        private int numLevels = 10;
        public int NumLevels
        {
            get { return numLevels; }
            set { numLevels = value; }
        }

        private bool numLevelsAuto = true;
        public bool NumLevelsAuto
        {
            get { return numLevelsAuto; }
            set { numLevelsAuto = value; }
        }

        private double angleStart = 0;
        public double AngleStart
        {
            get { return angleStart; }
            set { angleStart = value; }
        }

        private double angleExtent = 90;
        public double AngleExtent
        {
            get { return angleExtent; }
            set { angleExtent = value; }
        }

        private double angleStep = 10;
        public double AngleStep
        {
            get { return angleStep; }
            set { angleStep = value; }
        }

        private bool angleStepAuto = true;
        public bool AngleStepAuto
        {
            get { return angleStepAuto; }
            set { angleStepAuto = value; }
        }

        private double scaleMin = 0.8;
        public double ScaleMin
        {
            get { return scaleMin; }
            set { scaleMin = value; }
        }

        private double scaleMax = 1.2;
        public double ScaleMax
        {
            get { return scaleMax; }
            set { scaleMax = value; }
        }

        private double scaleStep = 0.1;
        public double ScaleStep
        {
            get { return scaleStep; }
            set { scaleStep = value; }
        }

        private bool scaleStepAuto = true;
        public bool ScaleStepAuto
        {
            get { return scaleStepAuto; }
            set { scaleStepAuto = value; }
        }

        private OptimizationType optimization = OptimizationType.auto;
        public OptimizationType Optimization
        {
            get { return optimization; }
            set { optimization = value; }
        }

        private MetricType metric = MetricType.use_polarity;
        public MetricType Metric
        {
            get { return metric; }
            set { metric = value; }
        }

        private ContrastType contrast = ContrastType.user_defined;
        public ContrastType Contrast
        {
            get { return contrast; }
            set { contrast = value; }
        }

        private int contrastValue = 60;
        public int ContrastValue
        {
            get { return contrastValue; }
            set { contrastValue = value; }
        }

        private int minContrast = 1;
        public int MinContrast
        {
            get { return minContrast; }
            set { minContrast = value; }
        }

        private bool minContrastAuto = true;
        public bool MinContrastAuto
        {
            get { return minContrastAuto; }
            set { minContrastAuto = value; }
        }

        //FindScaledShapeModel
        private double matchAngleStart = 0;
        public double MatchAngleStart
        {
            get { return matchAngleStart; }
            set { matchAngleStart = value; }
        }

        private double matchAngleExtent = 90;
        public double MatchAngleExtent
        {
            get { return matchAngleExtent; }
            set { matchAngleExtent = value; }
        }

        private double matchScaleMin = 0.8;
        public double MatchScaleMin
        {
            get { return matchScaleMin; }
            set { matchScaleMin = value; }
        }

        private double matchScaleMax = 1.2;
        public double MatchScaleMax
        {
            get { return matchScaleMax; }
            set { matchScaleMax = value; }
        }

        private double matchMinScore = 0.8;
        public double MatchMinScore
        {
            get { return matchMinScore; }
            set { matchMinScore = value; }
        }

        private int numMatches = 1;
        public int NumMatches
        {
            get { return numMatches; }
            set { numMatches = value; }
        }

        private double maxOverlap = 0.5;
        public double MaxOverlap
        {
            get { return maxOverlap; }
            set { maxOverlap = value; }
        }

        private SubPixelType subPixel = SubPixelType.none;
        public SubPixelType SubPixel
        {
            get { return subPixel; }
            set { subPixel = value; }
        }

        public string SubPixelString
        {
            get
            {
                string ret = "none";
                switch (SubPixel)
                {
                    case SubPixelType.none:
                        ret = "none";
                        break;
                    case SubPixelType.interpolation:
                        ret = "interpolation";
                        break;
                    case SubPixelType.least_squares:
                        ret = "least_squares";
                        break;
                    case SubPixelType.least_squares_high:
                        ret = "least_squares_high";
                        break;
                    case SubPixelType.least_squares_very_high:
                        ret = "least_squares_very_high";
                        break;
                    case SubPixelType.max_deformation_1:
                        ret = "max_deformation 1";
                        break;
                    case SubPixelType.max_deformation_2:
                        ret = "max_deformation 2";
                        break;
                    case SubPixelType.max_deformation_3:
                        ret = "max_deformation 3";
                        break;
                    case SubPixelType.max_deformation_4:
                        ret = "max_deformation 4";
                        break;
                    case SubPixelType.max_deformation_5:
                        ret = "max_deformation 5";
                        break;
                    case SubPixelType.max_deformation_6:
                        ret = "max_deformation 6";
                        break;
                    default:
                        break;
                }
                return ret;
            }
        }

        private int matchNumLevels = 0;
        public int MatchNumLevels
        {
            get { return matchNumLevels; }
            set { matchNumLevels = value; }
        }

        private double matchGreediness = 0.9;
        public double MatchGreediness
        {
            get { return matchGreediness; }
            set { matchGreediness = value; }
        }

        //结果设定 
        private double resultScore = 0.9;
        public double ResultScore
        {
            get { return resultScore; }
            set { resultScore = value; }
        }

        private int resultCount = 1;
        public int ResultCount
        {
            get { return resultCount; }
            set { resultCount = value; }
        }

        public override XElement ToXElement()
        {
            var element = base.ToXElement();

            //InspectShapeModel
            element.Add(new XAttribute("InspectNumLevels", InspectNumLevels.ToString()));
            element.Add(new XAttribute("InspectContrast", InspectContrast.ToString()));
            element.Add(new XAttribute("NumLevels", NumLevels.ToString()));
            element.Add(new XAttribute("NumLevelsAuto", NumLevelsAuto.ToString()));
            element.Add(new XAttribute("AngleStart", AngleStart.ToString()));
            element.Add(new XAttribute("AngleExtent", AngleExtent.ToString()));
            element.Add(new XAttribute("AngleStep", AngleStep.ToString()));
            element.Add(new XAttribute("AngleStepAuto", AngleStepAuto.ToString()));
            element.Add(new XAttribute("ScaleMin", ScaleMin.ToString()));
            element.Add(new XAttribute("ScaleMax", ScaleMax.ToString()));
            element.Add(new XAttribute("ScaleStep", ScaleStep.ToString()));
            element.Add(new XAttribute("ScaleStepAuto", ScaleStepAuto.ToString()));
            element.Add(new XAttribute("Optimization", Optimization.ToString()));
            element.Add(new XAttribute("Metric", Metric.ToString()));
            element.Add(new XAttribute("Contrast", Contrast.ToString()));
            element.Add(new XAttribute("ContrastValue", ContrastValue.ToString()));
            element.Add(new XAttribute("MinContrast", MinContrast.ToString()));
            element.Add(new XAttribute("MinContrastAuto", MinContrastAuto.ToString()));
            element.Add(new XAttribute("MatchAngleStart", MatchAngleStart.ToString()));
            element.Add(new XAttribute("MatchAngleExtent", MatchAngleExtent.ToString()));
            element.Add(new XAttribute("MatchScaleMin", MatchScaleMin.ToString()));
            element.Add(new XAttribute("MatchScaleMax", MatchScaleMax.ToString()));
            element.Add(new XAttribute("MatchMinScore", MatchMinScore.ToString()));
            element.Add(new XAttribute("NumMatches", NumMatches.ToString()));
            element.Add(new XAttribute("MaxOverlap", MaxOverlap.ToString()));
            element.Add(new XAttribute("SubPixel", SubPixel.ToString()));
            element.Add(new XAttribute("MatchNumLevels", MatchNumLevels.ToString()));
            element.Add(new XAttribute("MatchGreediness", MatchGreediness.ToString()));

            element.Add(new XAttribute("ModelID", ModelID.I.ToString()));
            element.Add(new XAttribute("ModelIndex", ModelIndex.ToString()));

            element.Add(new XAttribute("ResultScore", ResultScore.ToString()));
            element.Add(new XAttribute("ResultCount", ResultCount.ToString()));

            return element;
        }

        public override bool FromXElement(XElement element)
        {
            var ret = base.FromXElement(element);
            if (ret)
            {
                try
                {
                    InspectNumLevels = int.Parse(element.Attribute("InspectNumLevels").Value);
                    InspectContrast = int.Parse(element.Attribute("InspectContrast").Value);
                    NumLevels = int.Parse(element.Attribute("NumLevels").Value);
                    NumLevelsAuto = bool.Parse(element.Attribute("NumLevelsAuto").Value);
                    AngleStart = double.Parse(element.Attribute("AngleStart").Value);
                    AngleExtent = double.Parse(element.Attribute("AngleExtent").Value);
                    AngleStep = double.Parse(element.Attribute("AngleStep").Value);
                    AngleStepAuto = bool.Parse(element.Attribute("AngleStepAuto").Value);
                    ScaleMin = double.Parse(element.Attribute("ScaleMin").Value);
                    ScaleMax = double.Parse(element.Attribute("ScaleMax").Value);
                    ScaleStep = double.Parse(element.Attribute("ScaleStep").Value);
                    ScaleStepAuto = bool.Parse(element.Attribute("ScaleStepAuto").Value);
                    Optimization = (OptimizationType)Enum.Parse(typeof(OptimizationType), element.Attribute("Optimization").Value);
                    Metric = (MetricType)Enum.Parse(typeof(MetricType), element.Attribute("Metric").Value);
                    Contrast = (ContrastType)Enum.Parse(typeof(ContrastType), element.Attribute("Contrast").Value);
                    ContrastValue = int.Parse(element.Attribute("ContrastValue").Value);
                    MinContrast = int.Parse(element.Attribute("MinContrast").Value);
                    MinContrastAuto = bool.Parse(element.Attribute("MinContrastAuto").Value);
                    MatchAngleStart = double.Parse(element.Attribute("MatchAngleStart").Value);
                    MatchAngleExtent = double.Parse(element.Attribute("MatchAngleExtent").Value);
                    MatchScaleMin = double.Parse(element.Attribute("MatchScaleMin").Value);
                    MatchScaleMax = double.Parse(element.Attribute("MatchScaleMax").Value);
                    MatchMinScore = double.Parse(element.Attribute("MatchMinScore").Value);
                    NumMatches = int.Parse(element.Attribute("NumMatches").Value);
                    MaxOverlap = double.Parse(element.Attribute("MaxOverlap").Value);
                    SubPixel = (SubPixelType)Enum.Parse(typeof(SubPixelType), element.Attribute("SubPixel").Value);
                    MatchNumLevels = int.Parse(element.Attribute("MatchNumLevels").Value);
                    MatchGreediness = double.Parse(element.Attribute("MatchGreediness").Value);

                    ModelID = int.Parse(element.Attribute("ModelID").Value);
                    ModelIndex = int.Parse(element.Attribute("ModelIndex").Value);

                    ResultScore = double.Parse(element.Attribute("ResultScore").Value);
                    ResultCount = int.Parse(element.Attribute("ResultCount").Value);
                }
                catch
                {
                    ret = false;
                }
                ret = true;
            }
            return ret;
        }
    }
}
