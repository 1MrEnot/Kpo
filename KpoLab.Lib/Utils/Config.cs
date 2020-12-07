using System;
using System.Configuration;
using System.Linq;

namespace KpoLab.Lib.Utils
{
    public class Config
    {
        public string AppSettings(string name)
        {
            var appSettings = ConfigurationManager.AppSettings;

            if (appSettings.AllKeys.Contains(name))
            {
                return appSettings[name];
            }

            return "";

        }
    }
}
