using Ninject.Modules;
namespace LK11
{
    public class RandomMessageBuilderModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IRandomMessageBuilder>().To<RandomMessageBuilder>();
            Bind<IGreetingsGenerator>().To<GreetingsGenerator>();
            Bind<IDateTimeGenerator>().To<DateTimeGenerator>();
            Bind<INamesGenerator>().To<NamesGenerator>();
        }
    }
}
