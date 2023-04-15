using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK7
{
    public static class ArrayExtension
    {
        public static void Calc(int x, int y, double[] mas, HashSet<double> set)
        {
            for (int i = x; i < y; i++)
            {
                double temp = Math.Sqrt(mas[i]);
                if (Convert.ToInt32(temp) == Convert.ToDouble(temp))
                    set.Add(temp);
                
            }
        }
    }
    
    
}
