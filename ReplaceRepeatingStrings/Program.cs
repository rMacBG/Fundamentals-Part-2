using System.Text;

namespace ReplaceRepeatingStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine();
            }

            StringBuilder result = new StringBuilder();

            result.Append(str[0]);
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != str[i-1])
                {
                    result.Append(str[i]);
                }
                
            }

            Console.WriteLine(result);


        }   
    }
}