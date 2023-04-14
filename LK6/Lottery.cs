namespace LK6
{

    public static class Lottery
    {
        public static void Emit(List<int> list,int number)
        {
            Random rnd = new Random();
            for(int i=0;i<5;i++)
            {
                list.Add(rnd.Next(1,number));
            }
        }
    }
}
