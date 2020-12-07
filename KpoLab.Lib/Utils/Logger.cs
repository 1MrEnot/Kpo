using System;
using System.IO;

namespace KpoLab.Lib.Utils
{
    public static class Logger
    {
        public static string Path = "Log.txt";
        public const string Format = "[dd/MM/yyyy HH:mm]";

        public static void Log(string message)
        {
            var mes = $"{CurrentDataTime} - {message}{Environment.NewLine}";
            File.AppendAllText(Path, mes);
        }

        public static void Log(Exception ex)
        {
            Log(ex.Message);
        }

        private static string CurrentDataTime => DateTime.Now.ToString(Format);
    }
}
