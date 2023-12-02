using System.Text.RegularExpressions;

namespace Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfNames = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, int> bestPLayers = new Dictionary<string, int>();
            string input = Console.ReadLine();

            string patternNames = @"[A-Za-z]";
            string patternNums = @"\d";

            while (input != "end of race")
            {
                Regex regexNames = new Regex(patternNames);
                Regex regexNums = new Regex(patternNums);

                var matchedNames = regexNames.Matches(input);
                var matchedNums = regexNums.Matches(input);

                string name = String.Empty;
                int kilometers = 0;

                name = BuildTheName(matchedNames, name);
                kilometers = CalculateKilometers(matchedNums, kilometers);

                IsPlayerValid(listOfNames, bestPLayers, name, kilometers);

                input = Console.ReadLine();
            }

            var topThreePlayers = bestPLayers.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, y => y.Value);

            int counter = 0;

            foreach (var player in topThreePlayers)
            {
                counter++;
                if (counter == 1)
                {
                    Console.WriteLine($"{counter}st place: {player.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"{counter}nd place: {player.Key}");
                }
                else
                {
                    Console.WriteLine($"{counter}rd place: {player.Key}");
                }

            }
        }

        private static void IsPlayerValid(List<string> listOfNames, Dictionary<string, int> bestPLayers, string name, int kilometers)
        {
            if (listOfNames.Contains(name))
            {
                if (!bestPLayers.ContainsKey(name))
                {
                    bestPLayers[name] = 0;
                }
                bestPLayers[name] += kilometers;

            }
        }

        private static int CalculateKilometers(MatchCollection matchedNums, int kilometers)
        {
            foreach (Match digit in matchedNums)
            {
                kilometers += int.Parse(digit.Value);
            }

            return kilometers;
        }

        private static string BuildTheName(MatchCollection matchedNames, string name)
        {
            foreach (Match letter in matchedNames)
            {
                name += letter.Value;
            }

            return name;
        }
    } 
}
