using System.Text.RegularExpressions;

namespace Regexing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string patterm = @"A\w+";

            //Regex r = new Regex(patterm);

            //Match match = r.Match("Alexander e pi4");
            //Console.WriteLine(match.Value);

            string text = "Today is 2015-05-11";
            string pattern = @"\d{4}-\d{2}-\d{2}";
            Regex regex = new Regex(pattern);
            bool containsValidDate = regex.IsMatch(text);
            Console.WriteLine(containsValidDate);

        }
    }
}