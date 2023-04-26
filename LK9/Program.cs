namespace LK9
{
    public class Program
    {
        static ManualResetEvent manualResetEvent = new ManualResetEvent(false);
        static Thread[] mainThreads = new Thread[4];
        static void Main()
        {
            Thrd();
        }
        static void Thrd()
        {
            var rnd = new Random();
            int n = 100000;
            int[] arr = new int[n];
            int[]sum= new int[4];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 20);
            }
            Thread checkThread = new Thread(() =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 1)
                        break;
                }
                manualResetEvent.Set();
            });
            mainThreads[0] = new Thread(() =>
            {
                manualResetEvent.WaitOne();
                for (int i = 0; i < 25000; i++)
                {
                    sum[0] += arr[i];
                }
            });
            mainThreads[1] = new Thread(() =>
            {
                manualResetEvent.WaitOne();
                for (int i = 25000; i < 50000; i++)
                {
                    sum[1] += arr[i];
                }
            });
            mainThreads[2] = new Thread(() =>
            {
                manualResetEvent.WaitOne();
                for (int i = 50000; i < 75000; i++)
                {
                    sum[2] += arr[i];
                }
            });
            mainThreads[3] = new Thread(() =>
            {
                manualResetEvent.WaitOne();
                for (int i = 75000; i < 100000; i++)
                {
                    sum[3] += arr[i];
                }
            });
            foreach (var x in mainThreads)
            {
                x.Start();
            }
            checkThread.Start();
            checkThread.Join();

            Console.WriteLine(sum[0] +sum[1] +sum[2] +sum[3]);
        }
    }
}
