namespace LK11
{
    public class GreetingsGenerator:IGreetingsGenerator
    {
        string[] greetings = new string[] { "Hello", "Good day","Welcome","Hi","Hey" };
        public string GetGreeting() 
        {
            var rnd = new Random();
            return greetings[rnd.Next(greetings.Length)];
        }
    }
}
