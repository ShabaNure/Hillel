namespace LK6
{
    public static class StatOperations
    {
        public static void NeverAppeared(int number, HashSet<int> list)
        {
            for(int i =1;i<=number;i++)
            {
                if (list.Contains(i)==false) 
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void MostAppeared(List<int> list, HashSet<int> hashList)
        {
            var dict = new Dictionary<int, int>();
            foreach(var x in hashList)
            {
                dict.Add(x, 0);

            }
            foreach (var number in list)
                if (dict.ContainsKey(number))
                    dict[number]++;
            var max = dict.Max(kv => kv.Value);

            Console.WriteLine("Max number - "+max);

        }
    }
}
