using Ninject;

namespace LK11
{
    internal class Program
    {
        static void Main()
        {
            var module = new RandomMessageBuilderModule();
            var kernel = new StandardKernel(module);
            var message = kernel.Get<IRandomMessageBuilder>();

            message.Result();
        }

    }
}
