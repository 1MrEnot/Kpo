namespace KpoLab.Lib.Common
{
    using Commands.Factory;
    using Utils;

    public static class GlobalAppSettings
    {
        public static string LogPath { get; private set; }

        public static string DataFileName { get; private set; }

        public static IAbstractCommandFactory CommandFactory { get; private set; }


        public static void Init()
        {
            var config = new Config();
            LogPath = config.AppSettings("logPath");
            DataFileName = config.AppSettings("dataFileName");

            if (bool.Parse(config.AppSettings("IsTest")))
            {
                CommandFactory = new TestCommandFactory();
            }
            else
            {
                CommandFactory = new FileCommandFactory();
            }
        }
    }
}
