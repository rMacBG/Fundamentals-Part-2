using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\B\+359( |-)2\1[0-9]{3}\1[0-9]{4}";
            string numbers = Console.ReadLine();

            var phoneMatches = Regex.Matches(numbers, pattern);

            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToList();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
    /*
      +359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222
     */
}