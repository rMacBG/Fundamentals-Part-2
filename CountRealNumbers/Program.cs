namespace CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (int num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;

                }
                else
                {
                    counts.Add(num, 1);
                }
                
            }
            foreach (var i in counts)
            {
                Console.WriteLine($"{i.Key} -> {i.Value}");
            }
        }
    }
}