namespace LK13
{
    public class DateTimeGenerator:IDateTimeGenerator
    {
        public void GetCurrentDateTime() 
        {
            DateTime dateTime = DateTime.Now;
            Console.Write(" today is "+dateTime.ToString());
        }
        public void GetRandomDateTіme() 
        {
            var rnd = new Random();
            DateTime dateTime = new DateTime(rnd.Next(1000,3000), rnd.Next(1, 12), rnd.Next(1, 30), rnd.Next(0, 23), rnd.Next(0, 59), rnd.Next(0, 59));
            Console.Write(" today is " + dateTime.ToString());
        }
    }
    public class GreetingsGenerator:IGreetingsGenerator
    {
        string[] greetings = new string[] { "Hello", "Good day","Welcome","Hi","Hey" };
        public void GetGreeting() 
        {
            var rnd = new Random();
            Console.Write(greetings[rnd.Next(0,4)]);
        }
    }
    public class NamesGenerator:INamesGenerator
    {
        string[] names = new string[] { "Mr Brown", "Mrs Smith", "John", "Mike", "Lola" };
        public void GetNames()
        {
            var rnd = new Random();
            Console.Write(" "+names[rnd.Next(0, 4)]);
        }
    }
}
