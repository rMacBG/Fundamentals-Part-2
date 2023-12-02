namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();


            for (int i = 0; i < numbers.Count; i++)
            {
                List<string> work = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();


                for (int j = 0; j < work.Count; j++)
                {

                    Console.Write($"{work[j]} ");


                }
            }
        }
    }
}