using System.Numerics;

namespace BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;
            var n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}