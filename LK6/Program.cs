namespace LK6
{
    public class Program
    {
        static void Main()
        {
            Lot(10);
            Lot(50);
            Lot(100);
        }
        public static void Lot(int  round)
        {

            int number = 100;
            List<int> list = new List<int>();
            for (int i = 0; i < round; i++)
            {
                Lottery.Emit(list, number);
            }
            var hashList = new HashSet<int>(list);
            StatOperations.NeverAppeared(number, hashList);
            StatOperations.MostAppeared(list,hashList);
            Console.WriteLine("-------------");

        }

    }
}
