namespace KpoLab.Lib.Commands
{
    using System.Collections.Generic;

    public interface ILoader
    {
        public void Execute();

        public List<InformationSystem> Systems { get; }
    }
}
