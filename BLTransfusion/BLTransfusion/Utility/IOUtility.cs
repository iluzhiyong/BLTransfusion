using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Xml.Linq;

namespace BLTransfusion
{
    public partial class MainForm : Form
    {
        private void SP_Open()
        {
            if (serialPort1.IsOpen)
            {
                //MessageBox.Show("串口已经打开。", "提示");
            }
            else
            {
                //这个类中我们不检查跨线程的调用是否合法(因为.net 2.0以后加强了安全机制,，不允许在winform中直接跨线程访问控件的属性)
                Control.CheckForIllegalCrossThreadCalls = false;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(sp1_DataReceived);

                this.serialPort1.PortName = "COM5";
                this.serialPort1.BaudRate = 9600;
                this.serialPort1.DataBits = 8;
                LoadSPConfig();
                this.serialPort1.Open();
            }
        }

        void sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("请先打开串口！", "Error");
                return;
            }
            else
            {
                byte[] receivedData = new byte[serialPort1.BytesToRead];
                serialPort1.Read(receivedData, 0, receivedData.Length);
                serialPort1.DiscardInBuffer();

                //串口接收到命令后，开始检测
                if (receivedData[0] == (byte)SP_CMD.SP_CMD_RCV_START)
                {
                    Action detect = new Action(SerialPortDetect);
                    detect.BeginInvoke(null, null);
                }
            }
        }

        public void LoadSPConfig()
        {
            try
            {
                XDocument doc = XDocument.Load("config.xml");
                XElement myConfig = doc.Root.Element("SerialPortConfig");

                serialPort1.PortName = myConfig.Element("SerialPort").Value;
                serialPort1.BaudRate = Int32.Parse(myConfig.Element("BaudRate").Value);

                switch (myConfig.Element("DataBits").Value)
                {
                    case "5":
                        serialPort1.DataBits = 0;
                        break;
                    case "6":
                        serialPort1.DataBits = 1;
                        break;
                    case "7":
                        serialPort1.DataBits = 2;
                        break;
                    case "8":
                        serialPort1.DataBits = 3;
                        break;
                    default:
                        {
                            MessageBox.Show("数据位预置参数错误。");
                            return;
                        }
                }

                switch (myConfig.Element("Stop").Value)
                {
                    case "0":
                        serialPort1.StopBits = StopBits.None;
                        break;
                    case "1":
                        serialPort1.StopBits = StopBits.One;
                        break;
                    case "2":
                        serialPort1.StopBits = StopBits.Two;
                        break;
                    case "1.5":
                        serialPort1.StopBits = StopBits.OnePointFive;
                        break;
                    default:
                        {
                            MessageBox.Show("停止位预置参数错误。");
                            return;
                        }
                }

                switch (myConfig.Element("Parity").Value)
                {
                    case "无":
                        serialPort1.Parity = Parity.None;
                        break;
                    case "偶校验":
                        serialPort1.Parity = Parity.Odd;
                        break;
                    case "奇校验":
                        serialPort1.Parity = Parity.Even;
                        break;
                    default:
                        {
                            MessageBox.Show("校验位预置参数错误。");
                            return;
                        }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("加载参数失败！", "错误");
            }
        }

        private void SP_Close()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void SPCommand_OpenRelay1()
        {
            if (serialPort1.IsOpen)
            {
                byte[] cmdOpenRelay1 = new byte[] { 0xFE, 0x05, 0x00, 0x00, 0xFF, 0x00, 0x98, 0x35 };
                this.serialPort1.Write(cmdOpenRelay1, 0, 8);
            }
        }

        private void SPCommand_OpenRelay2()
        {
            if (serialPort1.IsOpen)
            {
                byte[] cmdOpenRelay2 = new byte[] { 0xFE, 0x05, 0x00, 0x01, 0xFF, 0x00, 0xC9, 0xF5 };
                this.serialPort1.Write(cmdOpenRelay2, 0, 8);
            }
        }

        private void SPCommand_CloseRelay1()
        {
            if (serialPort1.IsOpen)
            {
                byte[] cmdCloseRelay1 = new byte[] { 0xFE, 0x05, 0x00, 0x00, 0x00, 0x00, 0xD9, 0xC5 };
                this.serialPort1.Write(cmdCloseRelay1, 0, 8);
            }
        }

        private void SPCommand_CloseRelay2()
        {
            if (serialPort1.IsOpen)
            {
                byte[] cmdCloseRelay2 = new byte[] { 0xFE, 0x05, 0x00, 0x01, 0x00, 0x00, 0x88, 0x05 };
                this.serialPort1.Write(cmdCloseRelay2, 0, 8);
            }
        }

        public enum SP_CMD
        {
            SP_CMD_RCV_START                    = 0x05,
            SP_CMD_SEND_START_AUTO_DECTET       = 0x01,
            SP_CMD_SEND_STOP_AUTO_DECTET        = 0x07,
            SP_CMD_SEND_FAILD                   = 0x02,
            SP_CMD_SEND_SUCESS                  = 0x04,
        };

        private void SerialPortCMD(SP_CMD cmd)
        {
            if (serialPort1.IsOpen)
            {
                byte[] data = new byte[] { 0xFF };
                data[0] = (byte)cmd;

                this.serialPort1.Write(data, 0, 1);
            }
        }

        private void SerialPortRslt(bool result)
        {
            if (serialPort1.IsOpen)
            {
                byte[] cmd = new byte[] { 0xFF };
                if (result == true)
                {
                    cmd[0] = (byte)SP_CMD.SP_CMD_SEND_SUCESS;
                }
                else
                {
                    cmd[0] = (byte)SP_CMD.SP_CMD_SEND_FAILD;
                }

                this.serialPort1.Write(cmd, 0, 1);
            }
        }
    }
}
