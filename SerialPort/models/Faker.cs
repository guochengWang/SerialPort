﻿using System.Collections.Generic;
using System.IO.Ports;

namespace TulingGk.SerialPort.Models
{
    public static class Faker
    {
        // 获取串口
        public static List<string> GetPorts()
        {
            return new List<string>()
            {
                "COM1",
                "COM2",
                "COM3",
                "COM4",
            };
        }

        // 获取波特率
        public static List<int> GetBaudRates()
        {
            return new List<int>()
            {
                1382400,
                921600,
                460800,
                256000,
                230400,
                128000,
                115200,
                76800,
                57600,
                43000,
                38400,
                19200,
                14400,
                9600,
                4800,
                1200
            };
        }

        // 获取数据位
        public static List<string> GetDataBits()
        {
            return new List<string>()
            {
                "8",
                "7",
                "6",
                "5"
            };
        }
    }
}