using System.Runtime.ExceptionServices;

namespace CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            int result = Multiplier(input[0], input[1]);
            Console.WriteLine(result);
        }

        public static int Multiplier(string str1, string str2)
        {

            int sum = 0;
            int length = Math.Max(str1.Length, str2.Length);
            for (int i = 0; i < length; i++)
            {
                if (i < str1.Length && i < str2.Length)
                {
                    sum += str1[i] * str2[i];
                }
                else if (i < str1.Length)
                {
                    sum += str1[i];
                }
                else if (i< str2.Length)
                {
                    sum += str2[i];
                }
            }
            return sum;
        }
    }
}