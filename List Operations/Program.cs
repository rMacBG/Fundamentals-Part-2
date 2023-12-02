namespace List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Operations = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split();
                string action = commands[0];
                if (action == "Add")
                {
                    int task = int.Parse(commands[1]);
                    Operations.Add(task);
                }
                else if (action == "Insert")
                {
                    int task = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    if (index >= 0 && index < Operations.Count)
                    {
                        Operations.Insert(index, task);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (action == "Shift")
                {
                    string direction = commands[1];
                    if (direction == "left")
                    {
                        int task = int.Parse(commands[2]);
                        while (task != 0)
                        {
                            int currentnumber = Operations[0];
                            Operations.RemoveAt(0);
                            Operations.Add(currentnumber);
                            task--;
                        }
                    }
                    else if (direction == "right")
                    {
                        int task = int.Parse(commands[2]);
                        while (task != 0)
                        {
                            int currentnumber = Operations[Operations.Count - 1];
                            Operations.RemoveAt(Operations.Count - 1);
                            Operations.Insert(0, currentnumber);
                            task--;
                        }
                    }
                }
                else if (action == "Remove")
                {
                    int task = int.Parse(commands[1]);
                    if (task >= 0 && task < Operations.Count)
                    {
                        Operations.RemoveAt(task);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
            }
            Console.WriteLine(String.Join(" ", Operations));
        }
    }
}