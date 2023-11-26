using System.Diagnostics.Metrics;
using System.Reflection;

namespace ReverseStrings
{
    public class Program
    {
        static void Main()
        {
            var strings = new Dictionary<string,string>();
            int counter = 0;
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();
                string name = arguments[0];
                string value = arguments[1];

                if (!strings.ContainsKey(name))
                {
                    strings.Add(name, value);
                    counter++;
                }
                else
                {
                    strings[name] = value;
                }
            }
            foreach (var name in strings)
            {
                Console.WriteLine($"{name.Key} -> {name.Value}");
            }
            Console.WriteLine($"How many times people were added: {counter}");
        }
    }
}