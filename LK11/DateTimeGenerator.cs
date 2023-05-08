namespace LK11
{
    public class DateTimeGenerator:IDateTimeGenerator
    {
        public string GetCurrentDateTime() 
        {
            DateTime dateTime = DateTime.Now;
            string str = " today is " + dateTime.ToString();
            return str;

        }
        public string GetRandomDateTіme() 
        {
            var rnd = new Random();
            DateTime dateTime = new DateTime(rnd.Next(1000,3000), rnd.Next(1, 12), rnd.Next(1, 30), rnd.Next(0, 23), rnd.Next(0, 59), rnd.Next(0, 59));
            string str = " today is " + dateTime.ToString();
            return str;
        }
    }
}
