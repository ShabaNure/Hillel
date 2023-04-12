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

            double number = Math.Pow(2, 6);
            List<double> list = new List<double>();
            HashSet<double> lstN = new HashSet<double>();
            double[,] Top = new double[2, 3];
            for (int i = 0; i < round; i++)
            {
                Lottery.Emit(list, number);
                StatOperations.NeverAppeared(list, number, lstN);
            }
            StatOperations.MostAppeared(list, Top);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Top[0, i] + " - " + Top[1, i]);
            }
            Console.WriteLine("-------------");
        }

    }
}
