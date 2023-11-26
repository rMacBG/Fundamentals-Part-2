namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(filter))
            {
                int startIndex = text.IndexOf(filter);
                text = text.Remove(startIndex, filter.Length);
                
            }
            Console.WriteLine(text);
        }
    }
}