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
    public partial class ImgProcSetWnd : Form
    {
        private JunkDetector detector;
        public JunkDetector Detctor
        {
            get { return detector; }
            set
            {
                detector = value;

                this.tbRoiMinGray.DataBindings.Add("Text", detector, "RoiMinGray");
                this.tbRoiMaxGray.DataBindings.Add("Text", detector, "RoiMaxGray");

                this.tbRoiMinArea.DataBindings.Add("Text", detector, "RoiMinArea");
                this.tbRoiMaxArea.DataBindings.Add("Text", detector, "RoiMaxArea");

                this.tbMaskWidth.DataBindings.Add("Text", detector, "MaskWidth");
                this.tbMaskHeight.DataBindings.Add("Text", detector, "MaskHeight");

                this.tbDynThrehOffset.DataBindings.Add("Text", detector, "DynThreshOffset");

                this.tbDilaEroRadius.DataBindings.Add("Text", detector, "DilationErosionRadius");

                this.tbTartgetMinArea.DataBindings.Add("Text", detector, "TargetMinArea");

                this.tbTargetMaxArea.DataBindings.Add("Text", detector, "TargetMaxArea");
            }
        }

        public ImgProcSetWnd()
        {
            InitializeComponent();
        }

        private void SelectRoiBtn_Click(object sender, EventArgs e)
        {
            this.Detctor.SelectROI();
        }

        private void DoProcBtn_Click(object sender, EventArgs e)
        {
            if (this.Detctor.SelectROI())
            {
                if (this.Detctor.DoProcess())
                {
                    this.Detctor.CalculateResult();
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (this.Detctor != null)
            {
                this.Detctor.SaveToXml();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detector.RoiMinGray = (byte)(detector.RoiMinGray + 1);
        }
    }
}
