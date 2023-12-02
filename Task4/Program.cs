using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var emojiList = new Dictionary<string, int>();

            string text = Console.ReadLine();

            string numberPattern = @"(?<number>[0-9])";
            string pattern = @"(::|\*\*)([A-Z][a-z]{2,})\1";

            Regex r = new Regex(pattern);
            Regex regex = new Regex(numberPattern);

            MatchCollection matches = r.Matches(text);
            MatchCollection numberMatches = regex.Matches(text);

            int coolTotal = 0;

            

            foreach (Match match in numberMatches)
            {
                int number = int.Parse(match.ToString());
                numbers.Add(number);
            }

            if (numbers.Count >= 2)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i == 0)
                    {
                        coolTotal += numbers[i] * numbers[i + 1];
                        i++;
                    }
                    else
                    {
                        coolTotal *= numbers[i];
                    }
                }
            }
            else
            {
                coolTotal = numbers.Sum();
            }

            foreach (Match match in matches)
            {
                string emoji = match.Groups["2"].ToString();
                char[] letters = emoji.ToCharArray();
                int number = letters.Sum(x => (int)x);
                string trueEmoji = match.ToString();

                if (!emojiList.ContainsKey(trueEmoji))
                {
                    emojiList.Add(trueEmoji, number);
                }
            }

            Console.WriteLine($"Cool threshold: {coolTotal}");

            if (emojiList.Any())
            {
                Console.WriteLine($"{emojiList.Count} emojis found in the text. The cool ones are:");
                foreach (var (name, number) in emojiList)
                {
                    if (number > coolTotal)
                    {
                        Console.WriteLine($"{name}");
                    }
                }
            }
            
        }
    }
}