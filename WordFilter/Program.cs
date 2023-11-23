namespace WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, words));

            //Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine()
            //    .Split()
            //    .Where(x => x.Length % 2 == 0)
            //    .ToArray()));
        }
    }
}