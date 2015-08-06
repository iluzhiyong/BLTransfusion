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
                this.Models.Add(modelRoi);
                return true;
            }
            return false;
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
            catch
            {
                MessageBox.Show("保存模板文件失败", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        var model = new ModelInfo();
                        if (model.FromXElement(icmodelElement))
                        {
                            this.Models.Add(model);
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
  
        #region 处理 模板
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
}
