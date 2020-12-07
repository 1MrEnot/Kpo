namespace KpoLab.Lib.Commands.Factory
{
    public class TestCommandFactory : IAbstractCommandFactory
    {
        public ILoader CreateLoader()
        {
            return new TestLoader();
        }
    }
}
