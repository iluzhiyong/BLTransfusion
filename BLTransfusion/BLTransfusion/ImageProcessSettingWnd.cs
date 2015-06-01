using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BLTransfusion
{
    public partial class ImageProcessSettingWnd : Form
    {
        private ImageProcess imageProcess;
        public ImageProcess ImageProcess
        {
            get { return imageProcess; }
            set
            {
                imageProcess = value;
                this.tbRoiMinGray.DataBindings.Add("Text", imageProcess, "RoiMinGray");
                this.tbRoiMaxGray.DataBindings.Add("Text", imageProcess, "RoiMaxGray");

                this.tbRoiMinArea.DataBindings.Add("Text", imageProcess, "RoiMinArea");
                this.tbRoiMaxArea.DataBindings.Add("Text", imageProcess, "RoiMaxArea");

                this.tbMaskWidth.DataBindings.Add("Text", imageProcess, "MaskWidth");
                this.tbMaskHeight.DataBindings.Add("Text", imageProcess, "MaskHeight");

                this.tbDynThrehOffset.DataBindings.Add("Text", imageProcess, "DynThreshOffset");

                this.tbDilaEroRadius.DataBindings.Add("Text", imageProcess, "DilationErosionRadius");

                this.tbTartgetMinArea.DataBindings.Add("Text", imageProcess, "TargetMinArea");

                this.tbTargetMaxArea.DataBindings.Add("Text", imageProcess, "TargetMaxArea");
            }
        }

        public ImageProcessSettingWnd()
        {
            InitializeComponent();

            this.ImageProcess = new ImageProcess();
        }

        private void SelectRoiBtn_Click(object sender, EventArgs e)
        {

        }

        private void DoProcBtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
