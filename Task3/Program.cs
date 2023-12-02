using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder(str);

            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] arguments = command.Split(">>>");

                if (arguments[0] == "Contains")
                {
                    string containedString = arguments[1];
                    if (sb.ToString().Contains(containedString))
                    {
                        Console.WriteLine($"{sb} contains {containedString}");
                    }
                    else if (!sb.ToString().Contains(containedString))
                    {
                        Console.WriteLine("Substring not found!");
                    }
                    
                }
                else if (arguments[0] == "Flip")
                {
                    if (arguments[1] == "Upper")
                    {
                        int startIndex = int.Parse(arguments[2]);
                        int endIndex = int.Parse(arguments[3]);
                        int validStartIndex = Math.Max(0, startIndex);
                        int validEndIndex = Math.Min(sb.Length-1, endIndex);
                        if (validEndIndex >= validStartIndex)
                        {
                            for (int i = validStartIndex; i < validEndIndex; i++)
                            {
                                sb[i] = char.Parse(sb[i].ToString().ToUpper());
                            }
                        }
                        Console.WriteLine(sb);
                    }
                    else if (arguments[1] == "Lower")
                    {
                        int startIndex = int.Parse(arguments[2]);
                        int endIndex = int.Parse(arguments[3]);
                        int validStartIndex = Math.Max(0, startIndex);
                        int validEndIndex = Math.Min(sb.Length-1, endIndex);

                        if (validEndIndex >= validStartIndex)
                        {
                            for (int i = validStartIndex; i < validEndIndex; i++)
                            {
                                sb[i] = char.Parse(sb[i].ToString().ToLower());
                            }
                        }
                        Console.WriteLine(sb);
                    }
                    
                }
                else if (arguments[0] == "Slice")
                {
                    int startIndex = int.Parse(arguments[1]);
                    int endIndex = int.Parse(arguments[2]);
                    int validStartIndex = Math.Max(0, startIndex);
                    int validEndIndex = Math.Min(sb.Length - 1, endIndex);

                    if (validEndIndex >= validStartIndex)
                    {
                        int toRemove = validEndIndex - validStartIndex;
                        sb.Remove(validStartIndex, toRemove);
                    }
                    Console.WriteLine(sb);
                }

            }
            Console.WriteLine($"Your activation key is: {sb}");
        }
    }
}