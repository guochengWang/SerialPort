using System;
using Masuit.Tools;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TulingGk.SerialPort.Helper;
using TulingGk.SerialPort.Models;

namespace SerialPort
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {

        // 是否打开关闭串口标志
        private bool _isOpen = false;
        
        // 生成日志文件的路径
        private string logFilePath = "";
        private Thread CycleThread;
        private bool _isCycle = false;

        public MainForm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            // 填充默认值
            port.Properties.Items.AddRange(Faker.GetPorts());
            baudRate.Properties.Items.AddRange(Faker.GetBaudRates());
            parityBit.Properties.Items.AddRange(Enum.GetValues(typeof(Parity)));
            dataBit.Properties.Items.AddRange(Faker.GetDataBits());
            stopBits.Properties.Items.AddRange(Enum.GetValues(typeof(StopBits)));

            // 默认选中
            port.SelectedIndex = 0;
            baudRate.SelectedIndex = 6;
            parityBit.SelectedIndex = 0;
            dataBit.SelectedIndex = 0;
            stopBits.SelectedIndex = 1;

            dataLog.AppendText(Environment.NewLine);
            sendInfo.AppendText(Environment.NewLine);
        }
        
     

        /// <summary>
        /// 清除接收
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearRec_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///  打开关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isOpen)
                {
                    serialPort?.Close();
                    serialPortBtn.Text = "打开串口";
                    ChangeComboxEnable(true);
                    dataLog.AppendText("连接关闭".FormatStringLog());
                }
                else
                {
                    serialPort.PortName = port.Text;
                    serialPort.BaudRate = baudRate.Text.ToInt32();
                    serialPort.DataBits = dataBit.Text.ToInt32();

                    if (Enum.TryParse(stopBits.Text, out StopBits stopBit))
                    {

                        if (stopBit != StopBits.None)
                        {
                            serialPort.StopBits = stopBit;
                        }
                    }

                    if (Enum.TryParse(parityBit.Text, out Parity parity))
                    {
                        serialPort.Parity = parity;
                    }

                    serialPort?.Open();
                    ChangeComboxEnable(false);
                    serialPortBtn.Text = "关闭串口";
                    dataLog.AppendText("连接打开".FormatStringLog());
                }

                _isOpen = !_isOpen;
                ChangeMemoEditLastend();
            }
            catch (Exception exception)
            {
                serialPortBtn.Text = "打开串口";
                dataLog.AppendText(exception.Message.FormatStringLog());
            }
        }

        /// <summary>
        ///  是否可以选中
        /// </summary>
        /// <param name="enbale"></param>
        private void ChangeComboxEnable(bool enbale)
        {
            port.Enabled = enbale;
            baudRate.Enabled = enbale;
            parityBit.Enabled = enbale;
            dataBit.Enabled = enbale;
            stopBits.Enabled = enbale;
        }

        /// <summary>
        ///  是否自动滚屏
        /// </summary>
        private void ChangeMemoEditLastend()
        {
            if (autoScroll.Checked)
            {
                dataLog.SelectionStart = dataLog.Text.Length;
                dataLog.ScrollToCaret();
            }
        }

    }
}
