namespace LK7
{
    public class Program
    {

        public delegate void Del(int x, int y, double[] mas, HashSet<double> set);
        static void Main()
        {
            var del = new Del(ArrayExtension.Calc);
            double[] mas = new double[100000];
            HashSet<double> lst = new HashSet<double>();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = i;
            }

            var thread1 = new Thread(() =>{ del(0, 50000, mas, lst); Console.WriteLine("Thread 1 - Finished"); });
            var thread2 = new Thread(() =>{ del(50000, 100000, mas, lst); Console.WriteLine("Thread 2 - Finished"); });
            thread1.Start();
            thread1.Join();
            thread2.Start();
            thread2.Join();
            Console.WriteLine("-----Proccess finished-----");
            foreach(var x in lst)
            Console.WriteLine(x);
        }
        
        
    }
}
