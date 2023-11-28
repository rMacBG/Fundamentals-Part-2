using System.Runtime.CompilerServices;

namespace ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ")
                .ToArray();
            foreach (var username in usernames)
            {

                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }
                if (isValidUserName(username))
                {
                    Console.WriteLine(username);
                }
                
            }
          
        }
        private static bool isValidUserName(string username)
        {
            return username
                .All(x => char
                .IsLetterOrDigit(x) ||
                x == '-' ||
                x == '_');
        }
    }
}