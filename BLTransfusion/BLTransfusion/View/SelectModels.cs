using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLTransfusion.Model;

namespace BLTransfusion.View
{
    public partial class SelectModels : Form
    {
        public ModelProcessor ModelProcessor { get; private set; }

        public SelectModels(ModelProcessor modelProcessor)
        {
            this.ModelProcessor = modelProcessor;
            InitializeComponent();
            this.modelslistBox.DataSource = this.ModelProcessor.Models;
            this.modelslistBox.DisplayMember = "Label";
        }

        private void loadModelImage_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".bmp";

            dlg.Filter = "Bmp Image (.bmp)|*.bmp|Png Image (.png)|*.png|All files (*.*)|*.*";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                this.ModelProcessor.ModelImagePath = dlg.FileName;
                this.ModelProcessor.LoadModelImage();
            }
        }

        private void loadExistedModels_Click(object sender, EventArgs e)
        {
            if (!this.ModelProcessor.LoadModels())
            {
                MessageBox.Show("加载模板数据是失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addModel_Click(object sender, EventArgs e)
        {
            if (!this.ModelProcessor.DrawModelROI())
            {
                MessageBox.Show("添加模板失败！", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public ModelInfo SelectedModel
        {
            get 
            {
                return this.modelslistBox.SelectedValue as ModelInfo;
            }
        }

        private void deletedModel_Click(object sender, EventArgs e)
        {
            if (this.SelectedModel != null)
            {
                if (this.ModelProcessor.Models.Contains(SelectedModel))
                {
                    if (MessageBox.Show("确定删除当前模板？", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.ModelProcessor.Models.Remove(this.SelectedModel);
                    }
                }
            }
        }

        private void clearModels_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定清空所有模板？", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.ModelProcessor.Models.Clear();
            }
        }

        private void displayOneModel_Click(object sender, EventArgs e)
        {
            if (this.SelectedModel != null)
            {
                this.ModelProcessor.LoadImage();
                this.ModelProcessor.DisplayModelROI(this.SelectedModel);
            }
        }

        private void displayALLModel_Click(object sender, EventArgs e)
        {
            this.ModelProcessor.LoadImage();
            this.ModelProcessor.DisplayALLModelsROI();
        }

        private void saveModels_Click(object sender, EventArgs e)
        {
            if (this.ModelProcessor.Models != null && this.ModelProcessor.Models.Count > 0)
            {
                this.ModelProcessor.SaveModels();
            }
            else
            {
                MessageBox.Show("没有芯片模板数据！", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private ShapeModelDialog shapeModelDialog = null;

        private void InspectShapeModelBtn_Click(object sender, EventArgs e)
        {
            if (this.SelectedModel != null)
            {
                if (shapeModelDialog == null || shapeModelDialog.IsDisposed)
                {
                    shapeModelDialog = new ShapeModelDialog() { Owner = this };
                    shapeModelDialog.ModelProcessor = this.ModelProcessor;
                }
                shapeModelDialog.SetModelInfo(this.SelectedModel as ShapeModelMatchProcess);
                shapeModelDialog.Show();
            }

            //ShapeModelMatchProcess model = this.SelectedModel as ShapeModelMatchProcess;
            //if (model != null)
            //{
            //    this.ModelProcessor.LoadImage();

            //    model.Image = this.ModelProcessor.Ho_Image;

            //    this.ModelProcessor.DisplayModelROI(model);
            //    model.DoInspectShapeModel();           
            //}
        }

        private void modelslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SelectedModel != null && shapeModelDialog != null && !shapeModelDialog.IsDisposed)
            {
                shapeModelDialog.SetModelInfo(this.SelectedModel as ShapeModelMatchProcess);
            }
        }
    }
}
