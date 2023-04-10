namespace LK5
{
    public class Program
    {
        static void Main()
        {
            var root = new ArrayHandler();
            root.AllSqr += On_AllSqr;
            root.SquareRoots();

        }
        public static void On_AllSqr(object sender ,SqrEventArgs e) 
        {
            Console.WriteLine($"{e.Number*e.Number} - {e.Number}");    
        }
    }
}
