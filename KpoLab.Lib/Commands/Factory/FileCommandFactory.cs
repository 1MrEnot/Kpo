namespace KpoLab.Lib.Commands.Factory
{
    public class FileCommandFactory: IAbstractCommandFactory
    {
        public ILoader CreateLoader()
        {
            return new SplitFileLoader();
        }
    }
}
