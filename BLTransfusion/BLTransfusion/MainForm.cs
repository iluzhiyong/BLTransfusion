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

            Camera_Init();
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

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Camera_Closed();
        }

        private void cmbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            Camera_SelectedChanged();
        }
    }
}
