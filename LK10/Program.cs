namespace LK10
{
    public class Program
    {

        static void Main()
        {
            Tasks();
            Thread.Sleep(1000);
        }

        static async void Tasks()
        {
            Task[] tasks = new Task[10];
            var rnd = new Random();
            int positive = 0;
            int negative = 0;
            var lockObj1 = new object();
            var lockObj2 = new object();
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    for (int j = 0; j < 100; j++)
                    {
                        var num = rnd.Next(1, 100);
                        if (num % 2 == 0)
                        {
                            lock (lockObj1)
                            {
                                positive++;
                            }
                        }
                        else
                        {
                            lock (lockObj2)
                            {
                                negative++;
                            }
                        }
                    }
                });
            }
            Task.WaitAll(tasks);
            Console.WriteLine($"Pos - {positive} Neg - {negative}");
        }
    }
}
