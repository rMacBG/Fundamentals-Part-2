using System.Buffers;

namespace NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arr = new int[number];

            FillArray(number, arr);
            printMatrix(arr);

        }

        private static void printMatrix(int[] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix));
            }
        }
        static void FillArray(int number, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = number;
            }
        }
    }
}