using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Xml.Linq;

namespace BLTransfusion.View
{
    public partial class SerialPortSetForm : Form
    {
        public SerialPortSetForm()
        {
            InitializeComponent();
        }

        private void SerialPortSetForm_Load(object sender, EventArgs e)
        {
            if (SerialPort.GetPortNames() == null)
            {
                MessageBox.Show("本机没有串口！", "Error");
                return;
            }

            foreach (string s in SerialPort.GetPortNames())
            {
                cbSerial.Items.Add(s);
            }

            //可用的串口不固定，初始值不读配置文件
            cbSerial.Sorted = true;
            cbSerial.SelectedIndex = 0;

            LoadConfig();
            rbSend16.Checked = true;
            rbRcv16.Checked = true;

            //这个类中我们不检查跨线程的调用是否合法(因为.net 2.0以后加强了安全机制,，不允许在winform中直接跨线程访问控件的属性)
            Control.CheckForIllegalCrossThreadCalls = false;
            serialPortSet.DataReceived += new SerialDataReceivedEventHandler(sp1_DataReceived);
        }

        void sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!serialPortSet.IsOpen)
            {
                MessageBox.Show("请先打开串口！", "Error");
                return;
            }
            else
            {
                byte[] receivedData = new byte[serialPortSet.BytesToRead];
                serialPortSet.Read(receivedData, 0, receivedData.Length);
                serialPortSet.DiscardInBuffer();

                string strRcv = null;
                if (rbRcvStr.Checked)
                {
                    for (int i = 0; i < receivedData.Length; i++)
                    {
                        strRcv += Convert.ToChar(receivedData[i]);
                    }
                    txtRcv.Text += strRcv + "\r\n";
                }
                else
                {
                    try
                    {
                        for (int i = 0; i < receivedData.Length; i++)
                        {
                            strRcv += receivedData[i].ToString("X2");
                        }
                        txtRcv.Text += strRcv + "\r\n";
                    }
                    catch (SystemException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (serialPortSet.IsOpen)
            {
                MessageBox.Show("串口已经打开。", "提示");
            }
            else
            {
                try
                {
                    this.serialPortSet.PortName = cbSerial.SelectedItem.ToString();
                    this.serialPortSet.BaudRate = Int32.Parse(cbBaudRate.SelectedItem.ToString());
                    this.serialPortSet.DataBits = Int32.Parse(cbDataBits.SelectedItem.ToString());
                    this.serialPortSet.StopBits = (StopBits)cbStop.SelectedIndex;
                    this.serialPortSet.Parity = (Parity)cbParity.SelectedIndex;
                    this.serialPortSet.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!serialPortSet.IsOpen)
            {
                MessageBox.Show("请先打开串口！", "Error");
                return;
            }

            string strSend = txtSend.Text;
            if (rbSend16.Checked == true)
            {
                string[] strArray = strSend.Trim()
                                            .Replace(",", " ")
                                            .Replace("0x", "")
                                            .Replace("0X", "")
                                            .Split(' ');

                int byteBufferLength = strArray.Length;
                for (int i = 0; i < strArray.Length; i++)
                {
                    if (strArray[i] == "")
                    {
                        byteBufferLength--;
                    }
                }

                byte[] byteBufffer = new byte[byteBufferLength];
                int ii = 0;
                for (int i = 0; i < strArray.Length; i++)
                {
                    byte[] bytesOfStr = Encoding.Default.GetBytes(strArray[i]);
                    int decNum = 0;
                    if (strArray[i] == "")
                    {
                        continue;
                    }
                    else
                    {
                        decNum = Convert.ToInt32(strArray[i], 16);
                    }

                    try
                    {
                        byteBufffer[ii] = Convert.ToByte(decNum);
                    }
                    catch (SystemException ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return;
                    }

                    ii++;
                }

                serialPortSet.Write(byteBufffer, 0, byteBufffer.Length);
            }
            else
            {
                serialPortSet.WriteLine(txtSend.Text);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRcv.Text = "";
        }

        public void LoadConfig()
        {
            try
            {
                XDocument doc = XDocument.Load("config.xml");
                XElement myConfig = doc.Root.Element("SerialPortConfig");

                //cbSerial.SelectedText = myConfig.Element("SerialPort").Value;
                switch (myConfig.Element("BaudRate").Value)
                {
                    case "300":
                        cbBaudRate.SelectedIndex = 0;
                        break;
                    case "600":
                        cbBaudRate.SelectedIndex = 1;
                        break;
                    case "1200":
                        cbBaudRate.SelectedIndex = 2;
                        break;
                    case "2400":
                        cbBaudRate.SelectedIndex = 3;
                        break;
                    case "4800":
                        cbBaudRate.SelectedIndex = 4;
                        break;
                    case "9600":
                        cbBaudRate.SelectedIndex = 5;
                        break;
                    case "19200":
                        cbBaudRate.SelectedIndex = 6;
                        break;
                    case "38400":
                        cbBaudRate.SelectedIndex = 7;
                        break;
                    case "115200":
                        cbBaudRate.SelectedIndex = 8;
                        break;
                    default:
                        {
                            MessageBox.Show("波特率预置参数错误。");
                            return;
                        }
                }
                
                switch(myConfig.Element("DataBits").Value)
                {
                    case "5":
                        cbDataBits.SelectedIndex = 0;
                        break;
                    case "6":
                        cbDataBits.SelectedIndex = 1;
                        break;
                    case "7":
                        cbDataBits.SelectedIndex = 2;
                        break;
                    case "8":
                        cbDataBits.SelectedIndex = 3;
                        break;
                    default:
                        {
                            MessageBox.Show("数据位预置参数错误。");
                            return;
                        }
                }

                switch(myConfig.Element("Stop").Value)
                {
                    case "0":
                        cbStop.SelectedIndex = 0;
                        break;
                    case "1":
                        cbStop.SelectedIndex = 1;
                        break;
                    case "2":
                        cbStop.SelectedIndex = 2;
                        break;
                    case "1.5":
                        cbStop.SelectedIndex = 3;
                        break;
                    default:
                        {
                            MessageBox.Show("停止位预置参数错误。");
                            return;
                        }
                }

                switch(myConfig.Element("Parity").Value)
                {
                    case "无":
                        cbParity.SelectedIndex = 0;
                        break;
                    case "偶校验":
                        cbParity.SelectedIndex = 1;
                        break;
                    case "奇校验":
                        cbParity.SelectedIndex = 2;
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

        public void SaveConfig()
        {
            try
            {
                XDocument doc = XDocument.Load("config.xml");
                XElement myConfig = doc.Root.Element("SerialPortConfig");

                myConfig.Element("SerialPort").SetValue(cbSerial.SelectedItem);
                myConfig.Element("BaudRate").SetValue(cbBaudRate.SelectedItem);
                myConfig.Element("DataBits").SetValue(cbDataBits.SelectedItem);
                myConfig.Element("Stop").SetValue(cbStop.SelectedItem);
                myConfig.Element("Parity").SetValue(cbParity.SelectedItem);

                doc.Save("config.xml");

                MessageBox.Show("保存参数成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("保存参数失败！", "错误");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }
    }
}
