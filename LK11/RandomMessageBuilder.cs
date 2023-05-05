namespace LK11
{
    public class RandomMessageBuilder:IRandomMessageBuilder
    {

        public void AddDateTime() 
        {
            var rnd = new Random();
            var dateTime = new DateTimeGenerator();
            if(rnd.Next(0, 2) == 0)
            { dateTime.GetCurrentDateTime(); }
            else { dateTime.GetRandomDateTіme(); }

        }
        public void AddGreeting() 
        {
            var greeting = new GreetingsGenerator();
            greeting.GetGreeting();
        }
        public void AddName() 
        {
            var name = new NamesGenerator();
            name.GetNames();
        }
        public void Result() 
        {
            AddGreeting();
            AddName();
            AddDateTime();
        }
    }
}
