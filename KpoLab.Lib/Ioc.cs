namespace KpoLab.Lib
{
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;
    using Commands;
    using Common;

    public static class Ioc
    {
        public static WindsorContainer Container { get; }

        static Ioc()
        {
            Container = new WindsorContainer();

            if (GlobalAppSettings.IsTest)
            {
                Container.Register(Component
                    .For<ILoader>()
                    .ImplementedBy<TestLoader>()
                    .LifeStyle.Transient);
            }
            else
            {
                Container.Register(Component
                    .For<ILoader>()
                    .ImplementedBy<SplitFileLoader>()
                    .LifeStyle.Transient);
            }
        }
    }
}
