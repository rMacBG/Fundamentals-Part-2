namespace CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RealNumbersWithArray();
            RealNumbersWithList();
        }
        public static void RealNumbersWithArray()
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var numberOccurrences = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (!numberOccurrences.ContainsKey(currentNumber))
                {
                    numberOccurrences[currentNumber] = 1;
                }
                else
                {
                    numberOccurrences[currentNumber]++;
                }

            }

            foreach (var item in numberOccurrences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
        public static void RealNumbersWithList()
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