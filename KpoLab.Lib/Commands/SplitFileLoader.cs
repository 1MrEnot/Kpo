using KpoLab.Lib.Common;
using KpoLab.Lib.Enums;
using KpoLab.Lib.Utils;
using System;
using System.Collections.Generic;
using System.IO;

namespace KpoLab.Lib.Commands
{
    public class SplitFileLoader : ILoader
    {
        public List<InformationSystem> Systems { get; } = new List<InformationSystem>();

        public LoadStatus Status { get; private set; } = LoadStatus.None;


        public void Execute()
        {
            var filename = GlobalAppSettings.DataFileName;

            if (filename == null)
            {
                Status = LoadStatus.FileNameIsEmpty;
                throw new ArgumentException("Не указан путь к файлу для загрузки");
            }

            if (!File.Exists(filename))
            {
                Status = LoadStatus.FileNotExists;
                throw new ArgumentException("Указанный файл не существует");
            }

            try
            {
                var lines = File.ReadAllLines(filename);
                Systems.Clear();
                Systems.AddRange(Parser.Parse(lines, '|'));
                Status = LoadStatus.Success;
            }
            catch (Exception e)
            {
                Status = LoadStatus.GeneralError;
                Logger.Log(e);
                throw;
            }
            
        }
    }
}
