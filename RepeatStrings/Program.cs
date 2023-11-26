namespace RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();
            string result = string.Empty;
            foreach (var s in words)
            {
              int currentWordLength = s.Length;
                for (int i = 0; i < currentWordLength; i++)
                {
                    result = result + s;
                }
            }
            Console.WriteLine(result);
        }
    }
}