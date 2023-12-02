namespace Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            bool isPalindromeIntegers = false;
            while (number != "END")
            {
                Console.WriteLine(PrintPalidrome(number, isPalindromeIntegers).ToString().ToLower());
                number = Console.ReadLine();       
            }                                      
        }
        private static bool PrintPalidrome(string number, bool isPalindromeItegers)
        {
            var reverseNumber = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                char symbol = number[i];
                reverseNumber += symbol;
            }
            if (reverseNumber == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}