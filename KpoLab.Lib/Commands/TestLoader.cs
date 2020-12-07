namespace KpoLab.Lib.Commands
{
    using System.Collections.Generic;

    public class TestLoader : ILoader
    {
        public List<InformationSystem> Systems { get; private set; }

        public void Execute()
        {
            Systems = new List<InformationSystem>
            {
                new InformationSystem
                {
                    OperationSystem = "OS/2",
                    Database = "DB2",
                    MemoryAmount = 130,
                    RamAmount = 22,
                    Cost = 3343
                },
                new InformationSystem
                {
                    OperationSystem = "Windows/NT",
                    Database = "SQLServer",
                    MemoryAmount = 230,
                    RamAmount = 24,
                    Cost = 2685
                },
                new InformationSystem
                {
                    OperationSystem = "SCO/Unix",
                    Database = "Oracle",
                    MemoryAmount = 110,
                    RamAmount = 48,
                    Cost = 3745
                },
            };
        }
    }
}
