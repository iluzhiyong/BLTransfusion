using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HalconDotNet;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using System.ComponentModel;
using System.IO;
using BLTransfusion.Utility;
using System.Windows.Forms;

namespace BLTransfusion.Model
{
    public class ModelProcessor : IDisposable
    {
        private HWindow windowHandle;

        private HObject ho_Image;

        public HObject Ho_Image
        {
            get { return ho_Image; }
        }

        private HTuple hv_width, hv_height;

        public ModelProcessor(HWindow windowHandle)
        {
            this.windowHandle = windowHandle;
            InitVariables();
        }

        public void Dispose()
        {
            UninitVariables();
        }

        #region 加载图片
        private string imagePath = "Image";
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        public bool LoadImage()
        {
            string filePath = this.ImagePath;
            if (!File.Exists(filePath))
            {
                filePath = Path.Combine(FilePathUtility.GetAssemblyPath(), filePath);
            }
            return this.LoadImage(filePath);
        }



        public bool LoadImage(string imagePath)
        {
            try
            {
                windowHandle.ClearWindow();
                HOperatorSet.ReadImage(out ho_Image, this.ImagePath);
                HOperatorSet.GetImageSize(ho_Image, out hv_width, out hv_height);
                windowHandle.SetPart(0, 0, hv_height - 1, hv_width - 1);
                windowHandle.DispObj(ho_Image);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DisplayImage()
        {
            try
            {
                windowHandle.ClearWindow();
                HOperatorSet.GetImageSize(ho_Image, out hv_width, out hv_height);
                windowHandle.SetPart(0, 0, hv_height - 1, hv_width - 1);
                windowHandle.DispObj(ho_Image);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }



        #endregion

        #region 加载模板图片
        private string modelImagePath = "Model";
        public string ModelImagePath
        {
            get { return modelImagePath; }
            set { modelImagePath = value; }
        }

        public bool LoadModelImage()
        {
            string filePath = this.ModelImagePath;
            if (!File.Exists(filePath))
            {
                filePath = Path.Combine(FilePathUtility.GetAssemblyPath(), filePath);
            }
            return this.LoadImage(filePath);
        }

        public void ResetModelImageFile()
        {
            this.ModelImagePath = "Model";
        }
        #endregion

        #region 绘制/显示 模板
        private BindingList<ModelInfo> models = new BindingList<ModelInfo>();
        public BindingList<ModelInfo> Models
        {
            get { return models; }
        }

        public int ModelsCount
        {
            get
            {
                return this.Models.Count();
            }
        }

        public virtual bool DrawModelROI()
        {
            var modelRoi = DrawROI.DrawRectangle(this.windowHandle);
            if (modelRoi != null)
            {
                var model = new ShapeModelMatchProcess()
                {
                    RowTop = modelRoi.RowTop,
                    RowBottom = modelRoi.RowBottom,
                    ColumnLeft = modelRoi.ColumnLeft,
                    ColumnRight = modelRoi.ColumnRight,
                    WindowHandle = windowHandle,
                    ModelIndex = GetNewModelIndex(),
                };
                this.Models.Add(model);
                return true;
            }
            return false;
        }

        private int GetNewModelIndex()
        {
            int index = 0;
            bool find = false;
            do
            {
                find = false;
                foreach (var model in this.Models)
                {
                    var shapeModel = model as ShapeModelMatchProcess;
                    if (shapeModel != null && shapeModel.ModelIndex == index)
                    {
                        find = true;
                        break;
                    }
                }
                if (find)
                {
                    index++;
                }
            } while (find);
            return index;
        }

        public virtual bool DisplayModelROI(ModelInfo modelInfo)
        {
            HObject ho_Rectangle;
            HOperatorSet.GenRectangle1(out ho_Rectangle, modelInfo.RowTop, modelInfo.ColumnLeft, modelInfo.RowBottom, modelInfo.ColumnRight);
            windowHandle.SetLineWidth(3);
            windowHandle.SetDraw("margin");
            windowHandle.SetColor("red");
            windowHandle.DispObj(ho_Rectangle);
            ho_Rectangle.Dispose();
            return true;
        }

        public virtual bool DisplayALLModelsROI()
        {
            foreach (var model in this.Models)
            {
                DisplayModelROI(model);
            }
            return true;
        }

        #endregion

        #region 保存/加载 模板文件
        private string modelsFilePath = "Models.xml";
        public string ModelsFilePath
        {
            get
            {
                return Path.Combine(FilePathUtility.GetAssemblyPath(), modelsFilePath);
            }
        }

        public virtual bool SaveModels()
        {
            if (this.Models == null || this.Models.Count <= 0)
            {
                MessageBox.Show("没有可保存的模板数据", "",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            HOperatorSet.ClearAllShapeModels();

            foreach (var model in this.Models)
            {
                var modelProc = model as ShapeModelMatchProcess;
                if (modelProc != null)
                {
                    modelProc.WindowHandle = windowHandle;
                    modelProc.Image = ho_Image;
                    modelProc.DoInspectShapeModel();
                    modelProc.DoCreateShapeModel();
                    modelProc.SaveShapeModel();
                }
            }
            try
            {
                XDocument doc = new XDocument();
                var models = new XElement("Models");
                foreach (var model in this.Models)
                {
                    var elem = model.ToXElement();
                    if (elem != null)
                    {
                        models.Add(model.ToXElement());
                    }
                }
                doc.Add(models);
                doc.Save(this.ModelsFilePath);
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("保存模板文件失败 : {0}", ex.Message), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            MessageBox.Show("保存模板文件成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public virtual bool LoadModels()
        {
            try
            {
                XDocument doc = XDocument.Load(this.ModelsFilePath);
                if (doc.Root != null && doc.Root.Elements("ModelInfo") != null && doc.Root.Elements("ModelInfo").Count() > 0)
                {
                    this.Models.Clear();
                    foreach (var icmodelElement in doc.Root.Elements("ModelInfo"))
                    {
                        var model = new ShapeModelMatchProcess();
                        model.WindowHandle = windowHandle;
                        model.Image = ho_Image;
                        if (model.FromXElement(icmodelElement))
                        {
                            this.Models.Add(model);
                        }
                    }
                    HOperatorSet.ClearAllShapeModels();
                    foreach (var model in this.Models)
                    {
                        var modelProc = model as ShapeModelMatchProcess;
                        if (modelProc != null)
                        {
                            modelProc.WindowHandle = windowHandle;
                            modelProc.Image = ho_Image;
                            modelProc.LoadShapeModel();
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion
  
        #region 处理模板
        public virtual bool ProcessOneModel(ModelInfo modelInfo)
        {
            DisplayModelROI(modelInfo);

            return true;
        }

        public virtual bool ProcessAllModel()
        {
            DisplayALLModelsROI();
            return true;
        }
        #endregion

        #region 其他函数
        public virtual void InitVariables()
        {
            HOperatorSet.GenEmptyObj(out ho_Image);
        }

        public virtual void UninitVariables()
        {
            ho_Image.Dispose();
        }
        #endregion

        public virtual bool Detect()
        {
            //TODO:具体的图像处理

            //下面为示例在图像中绘制出所有的模板
            bool result = true;
            foreach (var model in this.Models)
            {
                try
                {
                    ShapeModelMatchProcess m = model as ShapeModelMatchProcess;
                    if (m != null)
                    {
                        result = m.DoFindScaledShapeModel() ? result : false;
                    }
                }
                catch
                {
                    result = false;
                    break;
                }
                this.DisplayModelROI(model);
            }
            return result;
        }

        public virtual bool HasValidModelFile()
        {
            //TODO:具体的检测是否存在有效的模板文件
            //这里只是简单加载模板文件成功表示模板有效
            return LoadModels();
        }


    }

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
        HObject ho_ModelImages, ho_ModelRegions, ho_ModelContours;
        HObject ho_ContoursAffinTrans = null;
        HTuple hv_HomMat2DScale = new HTuple();

        public ShapeModelMatchProcess()
        {
            HOperatorSet.GenEmptyObj(out ho_Rectangle);
            HOperatorSet.GenEmptyObj(out ho_ImageRegion);
            HOperatorSet.GenEmptyObj(out ho_ModelImages);
            HOperatorSet.GenEmptyObj(out ho_ModelRegions);
            HOperatorSet.GenEmptyObj(out ho_ModelContours);
            HOperatorSet.GenEmptyObj(out ho_ContoursAffinTrans);
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
                (AngleStepAuto) ? new HTuple("auto") : new HTuple(AngleStep),
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
            HTuple hv_Angle, hv_Scale, hv_Score, hv_I, hv_HomMat2DRotate = new HTuple();

            HOperatorSet.FindScaledShapeModel(Image, ModelID, (new HTuple(MatchAngleStart)).TupleRad(),
                (new HTuple(MatchAngleExtent)).TupleRad(), MatchScaleMin, MatchScaleMax, MatchMinScore, NumMatches,
                MaxOverlap, SubPixelString, MatchNumLevels, MatchGreediness,
                out hv_Row, out hv_Column, out hv_Angle, out hv_Scale, out hv_Score);

            ho_ModelContours.Dispose();
            HOperatorSet.GetShapeModelContours(out ho_ModelContours, ModelID, 1);

            //循环显示模板位置
            for (hv_I = 0; (int)hv_I <= (int)((new HTuple(hv_Score.TupleLength())) - 1); hv_I = (int)hv_I + 1)
            {
                //通过点角度生成其次变换矩阵（包括旋转平移）
                HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_Row.TupleSelect(hv_I), hv_Column.TupleSelect(
                    hv_I), hv_Angle.TupleSelect(hv_I), out hv_HomMat2DRotate);
                //增加缩放到其次变换矩阵
                HOperatorSet.HomMat2dScale(hv_HomMat2DRotate, hv_Scale.TupleSelect(hv_I), hv_Scale.TupleSelect(
                    hv_I), hv_Column.TupleSelect(hv_I), hv_Row.TupleSelect(hv_I), out hv_HomMat2DScale);
                //实现仿射变换
                ho_ContoursAffinTrans.Dispose();
                HOperatorSet.AffineTransContourXld(ho_ModelContours, out ho_ContoursAffinTrans,
                    hv_HomMat2DScale);
                this.WindowHandle.DispObj(ho_ContoursAffinTrans);
            }
            //TODO: 判断有没有找到结果 ResultScore & ResultCount
            return true;
        }

        public void Dispose()
        {
            ho_Rectangle.Dispose();
            ho_ImageRegion.Dispose();
            ho_ModelImages.Dispose();
            ho_ModelRegions.Dispose();
            ho_ModelContours.Dispose();
            ho_ContoursAffinTrans.Dispose();
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
        private int inspectNumLevels = 4;
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
        private int numLevels = 4;
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

        private double angleStart = -0.39;
        public double AngleStart
        {
            get { return angleStart; }
            set { angleStart = value; }
        }

        private double angleExtent = 0.79;
        public double AngleExtent
        {
            get { return angleExtent; }
            set { angleExtent = value; }
        }

        private double angleStep = 0.0175;
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

        private double scaleMin = 0.9;
        public double ScaleMin
        {
            get { return scaleMin; }
            set { scaleMin = value; }
        }

        private double scaleMax = 1.1;
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

        private ContrastType contrast = ContrastType.auto;
        public ContrastType Contrast
        {
            get { return contrast; }
            set { contrast = value; }
        }

        private int contrastValue = 10;
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
        private double matchAngleStart = -0.39;
        public double MatchAngleStart
        {
            get { return matchAngleStart; }
            set { matchAngleStart = value; }
        }

        private double matchAngleExtent = 0.78;
        public double MatchAngleExtent
        {
            get { return matchAngleExtent; }
            set { matchAngleExtent = value; }
        }

        private double matchScaleMin = 0.9;
        public double MatchScaleMin
        {
            get { return matchScaleMin; }
            set { matchScaleMin = value; }
        }

        private double matchScaleMax = 1.1;
        public double MatchScaleMax
        {
            get { return matchScaleMax; }
            set { matchScaleMax = value; }
        }

        private double matchMinScore = 0.5;
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

        private SubPixelType subPixel = SubPixelType.least_squares;
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

        //结果设定 //TODO: ??????
        public HTuple ResultScore { get; set; }
        public int ResultCount { get; set; }

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
