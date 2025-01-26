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
using System.IO;

namespace SerialPort
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {

        // 是否打开关闭串口标志
        private bool _isOpen = false;
        
        // 生成日志文件的路径
        private string logFilePath = "";
        private Thread CycleThread;
        
        // 是否循坏发送
        private bool _isCycle = false;

        public MainForm()
        {
            InitializeComponent();
            InitData();
            InitThread();
        }

        private void InitThread()
        {
            // 保存日志
            var saveLogThread = new Thread(() =>
            {
                while (true)
                {
                    if (recSaveFile.Checked && !string.IsNullOrEmpty(logFilePath))
                    {
                        File.WriteAllText(logFilePath, dataLog.Text);
                    }

                    Thread.Sleep(10000);
                }
            });

            saveLogThread.Start();
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
            dataLog.Text = "";
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

        /// <summary>
        ///  是否启用日志模式显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recLog_CheckedChanged(object sender, EventArgs e)
        {
            StringExtension.recLog = recLog.Checked;
        }

        /// <summary>
        /// 串口接收事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int len = serialPort.BytesToRead;
            byte[] buffers = new byte[len]; //用len 不会出现再一行的情况 
            serialPort.Read(buffers, 0, len);
            // 把流转成string
            string data = Encoding.UTF8.GetString(buffers);

            Invoke(new Action(() =>
            {
                if (recASCII.Checked) {
                    dataLog.AppendText(data.FormatStringLog());
                }
                else
                {   
                    // X2 补0
                    dataLog
                   .AppendText(string.Join(" ", buffers
                   .Select(b => b.ToString("X2")).ToArray())
                   .FormatStringLog());
                }
            }));

        }

        /// <summary>
        /// 点击发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = sendInfo.Text.Trim();
                if (result.Length == 0 && !_isCycle)
                {
                    MessageBox.Show("输入不能为空");
                    return;
                }

                // 关闭线程
                if (_isCycle)
                {
                    CycleThread?.Abort();
                    sendBtn.Text = "发送";
                    _isCycle = false;
                    DisableControls(true);
                    return;
                }
                if (result.Length > 0)
                {
                    // 是否生成随机数
                    if(randomCheck.Checked)
                    {
                        result += "-----" + new Random().Next(1, 999).ToString();
                    }

                  
                    // 选择循环周期
                    if(selectCycle.Checked)
                    {
                        CycleThread = new Thread(() =>
                        {
                            while (_isCycle) {
                                sendMessage(result);
                                Thread.Sleep(cycleTime.Text.ToString().ToInt32());
                            } 
                        });
                        CycleThread?.Start();
                        _isCycle = true;
                        DisableControls(false);
                        // 将发送选项设置为 disbale
                        sendBtn.Text = "停止发送";

                    } 
                    else
                    {
                        sendMessage(result);
                    }
                    
                }
            }
            catch (Exception ex) { 
                
            }
        }

        /// <summary>
        /// 发送信息
        /// </summary>
        /// <param name="result"></param>
        private void sendMessage(string result)
        {
            Invoke(new Action(() =>
            {
                // ascii 发送
                if(sendASCII.Checked)
                {
                    dataLog.AppendText(result.FormatStringLog());
                    serialPort.Write(result);
                }
                else
                {
                    byte[] sendBytes = TranStrToToHexByte(result);
                    if (sendBytes != null)
                    {
                        dataLog.AppendText(string.Join("",sendBytes
                            .Select(x => x.ToString("X2"))
                            .ToArray())
                            .FormatStringLog());

                        serialPort.Write(sendBytes, 0, sendBytes.Length);
                    }
                }
                sendInfo.Text = "";
            }));
        }


        /// <字符串转16进制格式,不够自动前面补零>
        /// 
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        private byte[] TranStrToToHexByte(string hexString)
        {
            int i;
            hexString = hexString.Replace(" ", "");//清除空格
            if ((hexString.Length % 2) != 0)//奇数个
            {
                byte[] returnBytes = new byte[(hexString.Length + 1) / 2];

                try
                {
                    for (i = 0; i < (hexString.Length - 1) / 2; i++)
                    {
                        returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                    }
                    returnBytes[returnBytes.Length - 1] = Convert.ToByte(hexString.Substring(hexString.Length - 1, 1).PadLeft(2, '0'), 16);
                }
                catch
                {
                    dataLog.AppendText("含有非16进制字符".FormatStringLog());
                    return null;
                }

                return returnBytes;
            }
            else
            {
                byte[] returnBytes = new byte[(hexString.Length) / 2];
                try
                {
                    for (i = 0; i < returnBytes.Length; i++)
                    {
                        returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                    }
                }
                catch
                {
                    dataLog.AppendText("含有非16进制字符".FormatStringLog());
                    return null;
                }
                return returnBytes;
            }
        }

        private void DisableControls(bool enable)
        {
            sendASCII.Enabled = enable;
            sendHEX.Enabled = enable;
            randomCheck.Enabled = enable;
            cycleTime.Enabled = enable;
            selectCycle.Enabled = enable;
        }

        private void recSaveFile_Click(object sender, EventArgs e)
        {
            if (recSaveFile.Checked)
            {
                // 弹出保存文件对话框
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    logFilePath = saveFileDialog.FileName;
                }
            }
        }
    }
}
