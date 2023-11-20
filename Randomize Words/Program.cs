namespace Randomize_Words
{
    public class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = rnd.Next(words.Length);

                string currentWord = words[i];           
                string randomWord = words[randomIndex];
                words[i] = randomWord;
                words[randomIndex] = currentWord;
            }
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

        }
    }

    
}