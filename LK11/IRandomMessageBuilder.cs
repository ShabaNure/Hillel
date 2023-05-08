namespace LK11
{
    public interface IRandomMessageBuilder
    {
        IDateTimeGenerator DateTimeGenerator { get; set; }
        IGreetingsGenerator GreetingGenerator { get; set; }
        INamesGenerator NameGenerator { get; set; }

        void AddDateTime();
        void AddGreeting();
        void AddName();
        string Result();
    }
}