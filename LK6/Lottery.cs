namespace LK6
{

    public static class Lottery
    {
        public static void Emit(List<double> list,double number)
        {
            Random rnd = new Random();
            for(int i=0;i<10;i++)
            {
                list.Add(rnd.Next(1,(int)number));
            }
        }
    }
}
