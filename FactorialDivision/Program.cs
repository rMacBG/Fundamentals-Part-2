namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double firstFactorial = 1;

            for (int i = 1; i <= first; i++)
            {
                firstFactorial *= i;
            }

            double secondFactorial = 1;
            for (int i = 1; i <= second; i++)
            {
                secondFactorial *= i;
            }

            Console.WriteLine($"{(firstFactorial / secondFactorial):F2}");
        }
    }
}