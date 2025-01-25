using System;

namespace TulingGk.SerialPort.Helper
{
    public static class StringExtension
    {
        public static bool recLog = true;

        public static string FormatStringLog(this String msg)
        {
            // 启用了日志模式显示，前方追加日期
            if (recLog)
            {
                return "["+DateTime.Now+"]"+Environment.NewLine+msg+Environment.NewLine+Environment.NewLine;
            }

            return msg+Environment.NewLine+Environment.NewLine;
        }
    }
}