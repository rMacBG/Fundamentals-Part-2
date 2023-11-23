using System.ComponentModel;
using System.Net;

namespace Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WordSynonyms();
            WordSynonymsAnotherWay();
        }

        
        public static void WordSynonyms()
        {
            int n = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = synonym;
                }
                else
                {
                    dictionary[word] += ", " + synonym;
                }

            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
        public static void WordSynonymsAnotherWay() 
        {
            int n = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = new List<string>() { synonym };
                }
                else
                {
                    dictionary[word].Add(synonym);
                }

            }
            foreach (var word in dictionary)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
               
            }
        }
    }
}