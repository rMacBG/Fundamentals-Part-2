using System.Text.RegularExpressions;

namespace ExamTask_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string pattern = @"[@#]+(?<color>[a-z]{3,})[@#]+[^a-z\d]*\/(?<amount>\d+)\/+";
            Regex r = new Regex(pattern);

            MatchCollection matchCollection = r.Matches(str);

            foreach (Match match in matchCollection)
            {
                Console.WriteLine($"You found {match.Groups["amount"]} {match.Groups["color"]} eggs!");
            }

        }
    }
}