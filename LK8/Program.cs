namespace LK8
{
    public class Program
    {
        static void Main()
        {
            Thread[] threads = new Thread[10];
            var rnd = new Random();
            int positive = 0;
            int negative = 0;
            var lockObj = new object();
            for(int i =0;i<threads.Length;i++)
            {
                threads[i] = new Thread(() => 
                {
                    for(int j =0;j<100;j++)
                    {
                        lock(lockObj)
                        {
                            var num = rnd.Next(1, 100);
                            if (num % 2 == 0)
                            {
                                positive++;
                            }
                            else negative++;
                        }
                    }
                });
            }
            foreach (var thrd in threads)
            {
                thrd.Start();
            }
            foreach (var thrd in threads)
            {
                thrd.Join();
            }
            Console.WriteLine($"Pos - {positive} Neg - {negative}");
        }
    }
}
