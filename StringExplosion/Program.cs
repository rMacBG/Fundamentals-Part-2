/*
 peter>2sis>1a>2akarate>4hexmaster
 */

using System.Text;

namespace StringExplosion
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string result = Explosions(input);
            Console.WriteLine(result);
        }

        private static string Explosions(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int strength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    strength += int.Parse(input[i + 1].ToString());
                    stringBuilder.Append(input[i]);
                }
                else if (strength == 0)
                {
                    stringBuilder.Append(input[i]);
                }
                else
                {
                    strength--;
                }

            }
            return stringBuilder.ToString();
        }
    }
}