using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK3
{
    internal class Ram : IRam,IDev
    {
        public void Eject()
        {
            Console.WriteLine("Ram 1");
        }
    }
}
