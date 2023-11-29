using System.Numerics;

namespace MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string multiplier = Console.ReadLine();

            Console.WriteLine(Multiply(number, multiplier));
        }

        private static string Multiply(string number, string multiplier)
        {
            if (number == "0" || multiplier == "0")
            {
                return "0";
            }
            int carry = 0;
            int numberMultiplier = int.Parse(multiplier);

            char[] result = new char[number.Length + 1];

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(number[i].ToString());
                int product = digit * numberMultiplier + carry;

                result[i + 1] = (char)(product % 10 + '0');
                carry = product / 10;
            }

            if (carry > 0)
            {
                result[0] = (char)(carry + '0');
            }

            return new string(result).TrimStart('\0');
        }
    }
}