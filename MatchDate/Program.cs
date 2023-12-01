using System.Text.RegularExpressions;

namespace MatchDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<Day>[0-9]{2})([-.\/])(?<Month>[A-Z][a-z]{2})\1(?<Year>[0-9]{4})\b";
            
            string datesString = Console.ReadLine();
            
            var dates = Regex.Matches(datesString, pattern);

            foreach (Match match in dates)
            {
                var day = match.Groups["Day"].Value;
                var month = match.Groups["Month"].Value;
                var year = match.Groups["Year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }



        }
    }
    /*
     13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016
     */
}