using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK5
{
    public class ArrayHandler
    {
        public event EventHandler<SqrEventArgs> AllSqr;

        public void SquareRoots()
        {
            var result = Square(x => x > 5);
            foreach (var res in result)
            Console.WriteLine($"sqr {res} > 5");

        }
        public IEnumerable<double> Square(Func<double, bool> lambda)
        {
            int[] numbers = { 3, 7, 14, 83, 59, 25, 36, 74, 16, 9, 49, 6, 8, 2, 4, 5, 7, 91, 23, 81 };
            var results = numbers.Sqr();
            foreach (var number in results)
            {
                var args = new SqrEventArgs() { Number = number };
                OnAllSqr(args);
                if (lambda(number))
                    yield return number;
            }
                
        }
        protected virtual void OnAllSqr(SqrEventArgs e) 
        {
            AllSqr?.Invoke(this, e);
        } 
    }
}
