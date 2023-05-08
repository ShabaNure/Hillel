using Ninject;

namespace LK11
{
    public class RandomMessageBuilder : IRandomMessageBuilder
    {
        [Inject]
        public IGreetingsGenerator GreetingGenerator { get; set; }
        [Inject]
        public INamesGenerator NameGenerator { get; set; }
        [Inject]
        public IDateTimeGenerator DateTimeGenerator { get; set; }
        private string result;
        //public RandomMessageBuilder(IGreetingsGenerator greetingGenerator, INamesGenerator nameGenerator, IDateTimeGenerator dateTimeGenerator)
        //{
        //    GreetingGenerator = greetingGenerator;
        //    NameGenerator = nameGenerator;
        //    DateTimeGenerator = dateTimeGenerator;
        //}

        public void AddDateTime()
        {
            var rnd = new Random();
            if (rnd.Next(0, 2) == 0)
            { result += DateTimeGenerator.GetCurrentDateTime(); }
            else { result += DateTimeGenerator.GetRandomDateTіme(); }

        }
        public void AddGreeting()
        {
            result += GreetingGenerator.GetGreeting();
        }
        public void AddName()
        {
            result += NameGenerator.GetNames();
        }
        public string Result()
        {
            return result;
        }
    }
}
