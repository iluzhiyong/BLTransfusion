using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLTransfusion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Camera_Init();
            //SP_Init();
        }

        private void bnStart_Click(object sender, EventArgs e)
        {
            Camera_StartStop();
        }

        private void bnSettings_Click(object sender, EventArgs e)
        {
            Camera_SettingPage();
        }

        private void bnSnapShot_Click(object sender, EventArgs e)
        {
            Camera_Snapshot();
        }

        private void bnImageProc_Click(object sender, EventArgs e)
        {
            ImageProcessSettingWnd dlg = new ImageProcessSettingWnd();
            dlg.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Camera_Closed();
        }

        private void cmbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            Camera_SelectedChanged();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(String.Format("Image Width:{0}, Hight:{1}", this.pB_Image.Size.Width.ToString(), this.pB_Image.Size.Height.ToString()));
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            //Camera_SelectedChanged();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            SPCommand_OpenRelay1();
            SPCommand_OpenRelay2();
            //SPCommand_CloseRelay1();
            //SPCommand_CloseRelay2();
        }

        private void CameraSnapTimer_Tick(object sender, EventArgs e)
        {
            Camera_Snapshot();
        }
    }
}
