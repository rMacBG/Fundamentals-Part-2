namespace OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OddOccurencies();
            //OddOccurenciesTakeTwo();
            //LinqWayToSolve();
            

        }
        public static void OddOccurencies()
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower();
                if (counts.ContainsKey(wordInLowerCase))
                {
                    counts[wordInLowerCase]++;
                }
                else
                {
                    counts.Add(wordInLowerCase, 1);
                }
            }
            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.WriteLine(count.Key + " ");
                }

            }
        }
        public static void OddOccurenciesTakeTwo()
        {
            string[] words = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
            var dictionary = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i].ToLower();
                if (!dictionary.ContainsKey(currentWord))
                {
                    dictionary.Add(currentWord, 0);
                }

                dictionary[currentWord]++;

            }

            foreach (var word in dictionary)
            {
                if (word.Value % 2 == 1)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
        public static void LinqWayToSolve()
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split()
                .Select(x => x.ToLower())
                .GroupBy(x => x)
                .Where(x => x.Count() % 2 == 1)
                .SelectMany(x => x)
                .Distinct()
                .ToList()));
        }
    }
}