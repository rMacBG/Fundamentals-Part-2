namespace ExamTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] arguments = command.Split(":|:");
                if (arguments[0] == "InsertSpace")
                {
                    int index = int.Parse(arguments[1]);
                    message = message.Insert(index, " ");
                }
                else if (arguments[0] == "ChangeAll")
                {
                    string substr = arguments[1];
                    string replacement = arguments[2];
                    message = message.Replace(substr, replacement);
                }
                else if (arguments[0] == "Reverse")
                {
                    string substring = arguments[1];
                    int substrIndex = message.IndexOf(substring);
                    if (substrIndex == -1)
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    message = message.Remove(substrIndex, substring.Length);
                    var reversedSubstr = new string(substring.Reverse().ToArray());
                    message += reversedSubstr;

                }
                Console.WriteLine(message);
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}