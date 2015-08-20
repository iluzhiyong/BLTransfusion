using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLTransfusion.Model;
using HalconDotNet;

namespace BLTransfusion.View
{
    public partial class ShapeModelDialog : Form
    {
        public ShapeModelDialog()
        {
            InitializeComponent();
        }

        public ShapeModelMatchProcess ModelInfo { get; private set; }

        public ModelProcessor ModelProcessor { get; set; }

        private void inspectShapeModelBtn_Click(object sender, EventArgs e)
        {
            if (this.ModelInfo != null && this.ModelProcessor != null)
            {
                this.ModelProcessor.LoadModelImage();
                this.ModelInfo.Image = this.ModelProcessor.Ho_Image;
                this.ModelInfo.DoInspectShapeModel();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ModelInfo != null && this.inspectNumLevelsComboBox.SelectedIndex >= 0 && this.inspectNumLevelsComboBox.SelectedIndex < 10 )
            {
                this.ModelInfo.InspectNumLevels = this.inspectNumLevelsComboBox.SelectedIndex + 1 ;
            }
        }

        public void SetModelInfo(ShapeModelMatchProcess modelInfo)
        {
            this.ModelInfo = modelInfo;
            if (this.ModelInfo != null && !this.IsDisposed)
            {
                this.inspectNumLevelsComboBox.SelectedIndex = this.ModelInfo.InspectNumLevels - 1;

                this.inspectContrastTextBox.DataBindings.Clear();
                this.inspectContrastTextBox.DataBindings.Add("Text", ModelInfo, "InspectContrast");

                this.numLevelsComboBox.SelectedIndex = this.ModelInfo.NumLevels - 1;

                this.numLevelsAutoCheckBox.DataBindings.Clear();
                this.numLevelsAutoCheckBox.DataBindings.Add("Checked", ModelInfo, "NumLevelsAuto");

                this.angleStartTextBox.DataBindings.Clear();
                this.angleStartTextBox.DataBindings.Add("Text", ModelInfo, "AngleStart");

                this.angleExtentTextBox.DataBindings.Clear();
                this.angleExtentTextBox.DataBindings.Add("Text", ModelInfo, "AngleExtent");

                this.angleStepTextBox.DataBindings.Clear();
                this.angleStepTextBox.DataBindings.Add("Text", ModelInfo, "AngleStep");

                this.angleStepAutoCheckBox.DataBindings.Clear();
                this.angleStepAutoCheckBox.DataBindings.Add("Checked", ModelInfo, "AngleStepAuto");

                this.ScaleMinTextBox.DataBindings.Clear();
                this.ScaleMinTextBox.DataBindings.Add("Text", ModelInfo, "ScaleMin");

                this.ScaleMaxTextBox.DataBindings.Clear();
                this.ScaleMaxTextBox.DataBindings.Add("Text", ModelInfo, "ScaleMax");

                this.scaleStepTextBox.DataBindings.Clear();
                this.scaleStepTextBox.DataBindings.Add("Text", ModelInfo, "ScaleStep");

                this.scaleStepAutoCheCkBox.DataBindings.Clear();
                this.scaleStepAutoCheCkBox.DataBindings.Add("Checked", ModelInfo, "ScaleStepAuto");

                this.optimizationComboBox.SelectedIndex = (int)this.ModelInfo.Optimization;

                this.metricComboBox.SelectedIndex = (int)this.ModelInfo.Metric;

                this.ContrastComboBox.SelectedIndex = (int)this.ModelInfo.Contrast;

                this.ContrastValueTextBox.DataBindings.Clear();
                this.ContrastValueTextBox.DataBindings.Add("Text", ModelInfo, "ContrastValue");

                this.minContrastCheckBox.DataBindings.Clear();
                this.minContrastCheckBox.DataBindings.Add("Checked", ModelInfo, "MinContrastAuto");

                this.minContrastTextBox.DataBindings.Clear();
                this.minContrastTextBox.DataBindings.Add("Text", ModelInfo, "MinContrast");

                this.matchAngleStartTextBox.DataBindings.Clear();
                this.matchAngleStartTextBox.DataBindings.Add("Text", ModelInfo, "MatchAngleStart");

                this.matchAngleExtentTextBox.DataBindings.Clear();
                this.matchAngleExtentTextBox.DataBindings.Add("Text", ModelInfo, "MatchAngleExtent");

                this.matchScaleMinTextBox.DataBindings.Clear();
                this.matchScaleMinTextBox.DataBindings.Add("Text", ModelInfo, "MatchScaleMin");

                this.matchScaleMaxTextBox.DataBindings.Clear();
                this.matchScaleMaxTextBox.DataBindings.Add("Text", ModelInfo, "MatchScaleMax");

                this.minScoreTextBox.DataBindings.Clear();
                this.minScoreTextBox.DataBindings.Add("Text", ModelInfo, "MatchMinScore");

                this.numMatchesTextBox.DataBindings.Clear();
                this.numMatchesTextBox.DataBindings.Add("Text", ModelInfo, "NumMatches");

                this.maxOverlapTextBox.DataBindings.Clear();
                this.maxOverlapTextBox.DataBindings.Add("Text", ModelInfo, "MaxOverlap");

                this.subPixelComboBox.SelectedIndex = (int)this.ModelInfo.SubPixel;

                this.matchNumLevelsComboBox.SelectedIndex = (int)this.ModelInfo.MatchNumLevels;

                this.greedinessTextBox.DataBindings.Clear();
                this.greedinessTextBox.DataBindings.Add("Text", ModelInfo, "MatchGreediness");

                this.resultScoreTextBox.DataBindings.Clear();
                this.resultScoreTextBox.DataBindings.Add("Text", ModelInfo, "ResultScore");

                this.resultCountTextBox.DataBindings.Clear();
                this.resultCountTextBox.DataBindings.Add("Text", ModelInfo, "ResultCount");
            }
        }

        private void NumLevelsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ModelInfo != null && this.numLevelsComboBox.SelectedIndex >= 0 && this.numLevelsComboBox.SelectedIndex < 10)
            {
                this.ModelInfo.NumLevels = this.numLevelsComboBox.SelectedIndex + 1;
            }
        }

        private void numLevelsAutoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void optimizationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ModelInfo != null)
            {
                this.ModelInfo.Optimization =(OptimizationType)this.optimizationComboBox.SelectedIndex;
            }
        }

        private void metricComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ModelInfo != null)
            {
                this.ModelInfo.Metric = (MetricType)this.metricComboBox.SelectedIndex;
            }
        }

        private void subPixelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ModelInfo != null)
            {
                this.ModelInfo.SubPixel = (SubPixelType)this.subPixelComboBox.SelectedIndex;
            }
        }

        private void matchNumLevelsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ModelInfo != null)
            {
                this.ModelInfo.NumLevels = (int)(this.matchNumLevelsComboBox.SelectedIndex + 1);
            }
        }

        private void TestCreateShapeModelBtn_Click(object sender, EventArgs e)
        {
            if (this.ModelInfo != null && this.ModelProcessor != null)
            {
                try
                {
                    this.ModelProcessor.LoadModelImage();
                    this.ModelInfo.Image = this.ModelProcessor.Ho_Image;

                    HOperatorSet.ClearAllShapeModels();

                    if (this.ModelInfo.DoInspectShapeModel())
                    {
                        this.ModelInfo.DoCreateShapeModel();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this ,string.Format("Failed to create shape model : {0}", ex.Message), "Test Create Shape Model" );
                    return;
                }

                MessageBox.Show(this, "Succeed to test create shape model.", "Test Create Shape Model");
            }
        }

        private void ContrastComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ModelInfo != null)
            {
                this.ModelInfo.Contrast = (ContrastType)this.ContrastComboBox.SelectedIndex;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void testFindShapeModelBtn_Click(object sender, EventArgs e)
        {
            if (this.ModelInfo != null && this.ModelProcessor != null)
            {
                try
                {
                    this.ModelProcessor.LoadModelImage();
                    this.ModelInfo.Image = this.ModelProcessor.Ho_Image;

                    HOperatorSet.ClearAllShapeModels();

                    if (this.ModelInfo.DoInspectShapeModel())
                    {
                        if (this.ModelInfo.DoCreateShapeModel())
                        {
                            this.ModelProcessor.LoadImage();
                            this.ModelInfo.Image = this.ModelProcessor.Ho_Image;
                            this.ModelProcessor.DisplayImage();

                            if (this.ModelInfo.DoFindScaledShapeModel() == true)
                            {
                                MessageBox.Show(this, "Succeed to find shape model.", "Test find Shape Model");
                            }
                            else
                            {
                                MessageBox.Show(this, "Failed to find shape model.", "Test Create Shape Model");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, string.Format("Exception : {0}", ex.Message), "Test Create Shape Model");
                    return;
                }
            }
        }

    }
}
