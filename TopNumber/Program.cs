namespace TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            IsTopNumber(n);
        }
        static void IsTopNumber(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                int sumDigits = 0;
                int counterOdds = 0;
                string toString = i.ToString();
                for (int j = 0; j < toString.Length; j++)
                {
                    int digit = int.Parse(toString[j].ToString());
                    if (digit % 2 != 0)
                    {
                        counterOdds++;
                    }
                    sumDigits += digit;
                }
                if (sumDigits % 8 == 0 && counterOdds >= 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}