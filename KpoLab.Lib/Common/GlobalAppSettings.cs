namespace KpoLab.Lib.Common
{
    using Utils;

    public static class GlobalAppSettings
    {
        public static string LogPath { get; private set; }

        public static string DataFileName { get; private set; }

        public static bool IsTest { get; private set; }


        public static void Init()
        {
            var config = new Config();
            LogPath = config.AppSettings("logPath");
            DataFileName = config.AppSettings("dataFileName");
            IsTest = bool.Parse(config.AppSettings("IsTest"));
        }
    }
}
