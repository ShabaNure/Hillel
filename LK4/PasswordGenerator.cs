namespace LK4
{
    public static class PasswordGenerator
    {
        
        static string[] allowedSymbols = new string[] { ">", "&", "M", "I", "w", "g", "4", "1" };
        static string str;
        public static string Generate()
        {
            str = "";
            Random rnd = new Random();
            for(int i=0; i< rnd.Next(5, 8); i++) 
            {
                str += allowedSymbols[rnd.Next(0,7)];
            }
            return str;
        }
    }
}
