namespace KpoLab.Lib.Utils
{
    using System;
    using System.Collections.Generic;

    public static class Parser
    {
        public static List<InformationSystem> Parse(IList<string> lines, char splitter)
        {
            var res = new List<InformationSystem>();

            foreach (var line in lines)
            {
                var arr = line.Split(splitter);
                if (arr.Length != 5)
                {
                    throw new ArgumentException("Недопустимый формат файла");
                }

                var item = new InformationSystem
                {
                    OperationSystem = arr[0],
                    Database = arr[1],
                    RamAmount = int.Parse(arr[2]),
                    MemoryAmount = int.Parse(arr[3]),
                    Cost = int.Parse(arr[4])
                };

                res.Add(item);
            }

            return res;
        }
    }
}
