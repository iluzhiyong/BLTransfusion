using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLTransfusion.Model;
using System.Xml.Linq;

namespace BLTransfusion.View
{
    public partial class AlgorithmForm : Form
    {
        public AlgorithmForm()
        {
            InitializeComponent();

            LoadConfig();
        }

        private Boolean doJunkDetectFlag = false;

        public Boolean DoJunkDetectFlag
        {
            get { return this.CB_Junk.Checked; }
            private set { doJunkDetectFlag = value; }
        }

        private Boolean doModelDetectFlag = false;

        public Boolean DoModelDetectFlag
        {
            get { return this.CB_Model.Checked; }
            private set { doModelDetectFlag = value; }
        }

        private Boolean doRgbDetectFlag = false;

        public Boolean DoRgbDetectFlag
        {
            get { return doRgbDetectFlag; }
            set { doRgbDetectFlag = value; }
        }

        private JunkDetector junkDetector;
        public JunkDetector JunkDetector
        {
            get { return junkDetector; }
            set { junkDetector = value; }
        }

        private ModelProcessor modelDetector;

        public ModelProcessor ModelDetector
        {
            get { return modelDetector; }
            set { modelDetector = value; }
        }

        private RGBDetector rgbDetector;

        public RGBDetector RgbDetector
        {
            get { return rgbDetector; }
            set { rgbDetector = value; }
        }

        private string imagePath = "Image";
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        private ImgProcSetWnd junkSetForm;
        private void Btn_Junk_Setting_Click(object sender, EventArgs e)
        {
            try
            {
                if (junkSetForm == null || junkSetForm.IsDisposed)
                {
                    JunkDetector.LoadImage(imagePath);

                    this.junkSetForm = new ImgProcSetWnd();
                    this.junkSetForm.Detctor = this.JunkDetector;
                    this.junkSetForm.Show();
                }
                else
                {
                    junkSetForm.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("设定窗口打开失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ModelSetForm modelSetForm;
        private void Btn_Model_Setting_Click(object sender, EventArgs e)
        {
            try
            {
                if (modelSetForm == null || modelSetForm.IsDisposed)
                {
                    this.modelSetForm = new ModelSetForm(this.ModelDetector);
                }
                modelSetForm.Show();
            }
            catch (Exception ex)
            {
                ex.GetType();
                MessageBox.Show("设定窗口打开失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private RGBDetectorSetForm rgbSetForm;
        private void btnRgbSetting_Click(object sender, EventArgs e)
        {
            try
            {
                if (rgbSetForm == null || rgbSetForm.IsDisposed)
                {
                    RgbDetector.LoadImage(imagePath);

                    this.rgbSetForm = new RGBDetectorSetForm();
                    this.rgbSetForm.Detector = this.RgbDetector;
                    this.rgbSetForm.Show();
                }
                else
                {
                    rgbSetForm.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("设定窗口打开失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadConfig()
        {
            try
            {
                XDocument doc = XDocument.Load("config.xml");
                XElement myConfig = doc.Root.Element("AlgorithmConfig");

                this.CB_Junk.Checked = bool.Parse(myConfig.Element("DoJunkDetectFlag").Value);
                this.CBRgb.Checked = bool.Parse(myConfig.Element("DoRgbDetectFlag").Value);
                this.CB_Model.Checked = bool.Parse(myConfig.Element("DoModelDetectFlag").Value);
            }
            catch (Exception)
            {
                //MessageBox.Show("加载参数失败！", "错误");
            }
        }

        public void SaveConfig()
        {
            try
            {
                XDocument doc = XDocument.Load("config.xml");
                XElement myConfig = doc.Root.Element("AlgorithmConfig");

                myConfig.Element("DoJunkDetectFlag").SetValue(this.CB_Junk.Checked);
                myConfig.Element("DoModelDetectFlag").SetValue(this.CB_Model.Checked);
                myConfig.Element("DoRgbDetectFlag").SetValue(this.CBRgb.Checked);

                doc.Save("config.xml");

                MessageBox.Show("保存参数成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("保存参数失败！", "错误");
            }
        }

        private void btnAlgSave_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void btnAlgCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
