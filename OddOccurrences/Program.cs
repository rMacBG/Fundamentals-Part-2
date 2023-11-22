namespace OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words= Console.ReadLine().Split();
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
                Console.WriteLine(count.Key + " ");
            }
        }
    }
}