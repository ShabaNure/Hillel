using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LK13
{
    public class RandomMessageBuilderModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IRandomMessageBuilder>().To<RandomMessageBuilder>();
        }
    }
}
