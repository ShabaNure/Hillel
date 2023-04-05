using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK3
{
    internal class Cpu: ICpu, IDev
    {
        public void Unplug()
        {
            Console.WriteLine("CPU 1");
        }
    }
}
