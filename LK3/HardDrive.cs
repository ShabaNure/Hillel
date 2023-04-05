using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK3
{
    internal class HardDrive: IHardDrive,IDev
    {
        public void Remove()
        {
            Console.WriteLine("Hard Drive 1");
        }
    }
}
