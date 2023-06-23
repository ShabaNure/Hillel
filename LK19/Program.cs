namespace LK19
{
    class Program 
    {
        static void Main()
        {
            var url = "https://www.youtube.com";
            var client = new Http();
            client.GetUrl(url);
            client.PostUrl(url);
            object obj = "Object";
            client.PutUrl("https://localhost:8080", obj);
        }

    }
}