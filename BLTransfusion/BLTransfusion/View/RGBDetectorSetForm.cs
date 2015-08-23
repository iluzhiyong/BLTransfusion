using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLTransfusion.View
{
    public partial class RGBDetectorSetForm : Form
    {
        public RGBDetectorSetForm()
        {
            InitializeComponent();
        }

        private RGBDetector detector;

        public RGBDetector Detector
        {
            get { return detector; }
            set 
            { 
                detector = value;

                this.tbRedMinGray.DataBindings.Add("Text", detector, "RedMinGray");
                this.tbRedMaxGray.DataBindings.Add("Text", detector, "RedMaxGray");
                this.tbGreenMinGray.DataBindings.Add("Text", detector, "GreenMinGray");
                this.tbGreenMaxGray.DataBindings.Add("Text", detector, "GreenMaxGray");
                this.tbBlueMinGray.DataBindings.Add("Text", detector, "BlueMinGray");
                this.tbBlueMaxGray.DataBindings.Add("Text", detector, "BlueMaxGray");

                this.tbMinArea.DataBindings.Add("Text", detector, "MinArea");
                this.tbMaxArea.DataBindings.Add("Text", detector, "MaxArea");
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            Detector.Threshold(RGBType.red);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            Detector.Threshold(RGBType.green);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            Detector.Threshold(RGBType.blue);
        }

        private void tbnProc_Click(object sender, EventArgs e)
        {
            if (detector.DoDetect() == true)
            {
                MessageBox.Show("检测到目标！");
            }
            else
            {
                MessageBox.Show("未检测到目标！");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Detector.SaveToXml();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
