namespace Lottery.Helper
{
    public static class LotoNumberGenerator
    {
        public static List<int> Generate(int count, int maxInclusive)
        {
            var list = new List<int>();
            var rand = new Random();

            while (list.Count < count)
            {
                int num = rand.Next(1, maxInclusive + 1);
                if (!list.Contains(num))
                {
                    list.Add(num);
                }
            }
            list.Sort();
            return list;
        }
    }
}