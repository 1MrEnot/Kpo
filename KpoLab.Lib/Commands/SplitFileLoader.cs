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

                foreach (var line in lines)
                {
                    var arr = line.Split('|');
                    var item = new InformationSystem
                    {
                        OperationSystem = arr[0],
                        Database = arr[1],
                        RamAmount = int.Parse(arr[2]),
                        MemoryAmount = int.Parse(arr[3]),
                        Cost = int.Parse(arr[4])
                    };

                    Systems.Add(item);
                }
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
