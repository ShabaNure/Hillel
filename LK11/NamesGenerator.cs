namespace LK11
{
    public class NamesGenerator:INamesGenerator
    {
        string[] names = new string[] { "Mr Brown", "Mrs Smith", "John", "Mike", "Lola" };
        public string GetNames()
        {
            var rnd = new Random();
            return names[rnd.Next(names.Length)];
        }
    }
}
