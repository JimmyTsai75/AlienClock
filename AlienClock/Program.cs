using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlienClock
{
    internal static class Program
    {
        /// <summary>
        /// Last saved alarm time
        /// </summary>
        public static string AlarmString = "";
        public static (string, string) AlarmHourAndMin = ("", "");
        private static string baseConfigPath = "";

        public static void SaveAlarmString()
        {
            var fileName = Path.Combine(baseConfigPath, "alarm.txt");
            TxtFileHelper.StringToFile(AlarmString, fileName);
        }
        public static (string, string) ReadAlarmString()
        {
            var fileName = Path.Combine(baseConfigPath, "alarm.txt");
            if (File.Exists(fileName))
            {
                AlarmString = TxtFileHelper.FileToString(fileName);
                string pattern = @"(\d+):(\d+)";

                Match match = Regex.Match(AlarmString, pattern);
                if (match.Success&&match.Groups.Count>=3)
                {
                    return (match.Groups[1].Value, match.Groups[2].Value);
                }
                else return ("", "");
            }
            else return ("", "");
        }
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            baseConfigPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");
            if (!Directory.Exists(baseConfigPath))
            {
                Directory.CreateDirectory(baseConfigPath);
            }
            AlarmHourAndMin=ReadAlarmString();
            
            Application.Run(new MainForm());
        }
    }
}
