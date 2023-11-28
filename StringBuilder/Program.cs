using System.Diagnostics;
using System.Text;

namespace StringBuilders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringBuilderSW();
            //StringSW();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i);
            }

            sb[2] = '5';
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.MaxCapacity);
        }
        public static void StringBuilderSW()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                stringBuilder.Append(i);
                
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public static void StringSW()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string text = "";
            for (int i = 0; i < 100000; i++)
            {
                text += i;

            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}