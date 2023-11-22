using System.ComponentModel;

namespace Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            var words = new Dictionary<string, List<string>>();
            for (int i = 0; i < counter; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (words.ContainsKey(word) == false)
                {
                    words.Add(word, new List<string>());
                    
                }
                else
                {
                    words[word].Add(synonym);
                }

            }
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}