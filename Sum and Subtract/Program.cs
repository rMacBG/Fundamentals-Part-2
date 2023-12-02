using System.Xml.Schema;

namespace Sum_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine()); 
            int third  = int.Parse(Console.ReadLine());
            int result = Add(first, second);
            int finalResult = Subtract(result, third);

            Console.WriteLine(finalResult);

        }
        public static int Add(int first, int second)
        {
           int result = first + second;
            return result;
        }
        public static int Subtract(int result, int third)
        {
            int total = result - third;
            return total;
        }
    }
}