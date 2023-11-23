namespace Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var charCounter = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == ' ')
                {
                    continue;
                }
                if (!charCounter.ContainsKey(ch))
                {
                    charCounter.Add(ch, 0);
                }
                charCounter[ch]++;
            }

            foreach (var item in charCounter)
            {
                char ch = item.Key;
                int count = item.Value;
                Console.WriteLine($"{ch} -> {count}");
            }
        }
    }
}