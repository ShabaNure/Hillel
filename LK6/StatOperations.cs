namespace LK6
{
    public static class StatOperations
    {
        public static void NeverAppeared(List<double> list,double number, HashSet<double> lst)
        {
            for(int i =1;i<number+1;i++)
            {
                lst.Add(i);
            }
            foreach(var x in list)
            {
                lst.Remove(x);
            }
            
        }

        public static void MostAppeared(List<double> list, double[,] top)
        {
            

            for(int i=0;i<list.Count-1;i++)
            {
                int count = 0;
                for(int j=i+1;j<list.Count;j++)
                {
                    if (list[i] == list[j])
                    {
                        count++;
                    }

                    
                }
                if (count >= top[0, 0])
                {
                    top[0, 2] = top[0, 1];
                    top[0, 1] = top[0, 0];
                    top[1, 2] = top[1, 1];
                    top[1, 1] = top[1, 0];
                    top[0, 0] = count;
                    top[1, 0] = list[i];
                }
                else if (count >= top[0, 1] && list[i] != top[1, 0])
                {
                    top[0, 2] = top[0, 1];
                    top[1, 2] = top[1, 1];
                    top[0, 1] = count;
                    top[1, 1] = list[i];
                }
                else if (count >= top[0, 2] && list[i] != top[1, 0] && list[i] != top[1, 1])
                {
                    top[0, 2] = count;
                    top[1, 2] = list[i];
                }
            }

        }
    }
}
