using System.Text.RegularExpressions;


namespace MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)";
            string names = Console.ReadLine();
            MatchCollection matchedNames = Regex.Matches(names, pattern);

            foreach (Match match in matchedNames)
            {
                Console.Write((match.Value + " "));
            }
            Console.WriteLine();

        }
    }
}

/*
Bethany Taylor, Oliver miller, sophia Johnson, SARah Wilson, John Smith, Sam        Smith

 */