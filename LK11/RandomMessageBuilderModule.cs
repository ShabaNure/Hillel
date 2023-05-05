using Ninject.Modules;
namespace LK11
{
    public class RandomMessageBuilderModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IRandomMessageBuilder>().To<RandomMessageBuilder>();
        }
    }
}
