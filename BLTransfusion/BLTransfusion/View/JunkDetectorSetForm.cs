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

                this.tbSEWidth.DataBindings.Add("Text", detector, "SeWidth");
                this.tbSEHeight.DataBindings.Add("Text", detector, "SeHeight");

                this.tbRoiMinGray.DataBindings.Add("Text", detector, "RoiMinGray");
                this.tbRoiMaxGray.DataBindings.Add("Text", detector, "RoiMaxGray");

                this.tbRoiMinArea.DataBindings.Add("Text", detector, "RoiMinArea");
                this.tbRoiMaxArea.DataBindings.Add("Text", detector, "RoiMaxArea");

                this.tbMaskWidth.DataBindings.Add("Text", detector, "MaskWidth");
                this.tbMaskHeight.DataBindings.Add("Text", detector, "MaskHeight");

                this.tbTartgetMinArea.DataBindings.Add("Text", detector, "TargetMinArea");
                this.tbTargetMaxArea.DataBindings.Add("Text", detector, "TargetMaxArea");

                this.tbTargetMinAnisometry.DataBindings.Add("Text", detector, "TargetMinAnisometry");
                this.tbTargetMaxAnisometry.DataBindings.Add("Text", detector, "TargetMaxAnisometry");

                this.tbTargetMinOuterRadius.DataBindings.Add("Text", detector, "TargetMinOuterRadius");
                this.tbTargetMaxOuterRadius.DataBindings.Add("Text", detector, "TargetMaxOuterRadius");

                this.tbTargetMinDeviation.DataBindings.Add("Text", detector, "TargetMinDistDeviation");
                this.tbTargetMaxDeviation.DataBindings.Add("Text", detector, "TargetMaxDistDeviation");
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
                if (this.Detctor.Detect() == true)
                {
                    MessageBox.Show("检测到目标！");
                }
                else
                {
                    MessageBox.Show("未检测到目标！");
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
