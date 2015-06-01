using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace BLTransfusion
{
    public partial class MainForm : Form
    {
        private void SP_Init()
        {
            this.serialPort1.PortName = "COM1";
            this.serialPort1.BaudRate = 9600;
            this.serialPort1.DataBits = 8;
            this.serialPort1.Open();
        }

        private void SPCommand_OpenRelay1()
        {
            byte[] cmdOpenRelay1 = new byte[] { 0xFE, 0x05, 0x00, 0x00, 0xFF, 0x00, 0x98, 0x35};
            this.serialPort1.Write(cmdOpenRelay1, 0, 8);
        }

        private void SPCommand_OpenRelay2()
        {
            byte[] cmdOpenRelay2 = new byte[] { 0xFE, 0x05, 0x00, 0x01, 0xFF, 0x00, 0xC9, 0xF5 };
            this.serialPort1.Write(cmdOpenRelay2, 0, 8);
        }

        private void SPCommand_CloseRelay1()
        {
            byte[] cmdCloseRelay1 = new byte[] { 0xFE, 0x05, 0x00, 0x00, 0x00, 0x00, 0xD9, 0xC5 };
            this.serialPort1.Write(cmdCloseRelay1, 0, 8);
        }

        private void SPCommand_CloseRelay2()
        {
            byte[] cmdCloseRelay2 = new byte[] { 0xFE, 0x05, 0x00, 0x01, 0x00, 0x00, 0x88, 0x05 };
            this.serialPort1.Write(cmdCloseRelay2, 0, 8);
        }
    }
}
