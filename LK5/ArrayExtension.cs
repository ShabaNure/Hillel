using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK5
{
    public static class ArrayExtension
    {
        public static IEnumerable<double> Sqr(this int[] array) 
        {
            foreach(var number in array) 
            {

                double x = Math.Sqrt(number);
                if (Convert.ToInt32(x) == Convert.ToDouble(x))
                    yield return x;
            }
        }
    }
    
}
