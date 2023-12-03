namespace ExamTask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Guests = new Dictionary<string, List<string>>();
            int unlikedMeals = 0;
            string input;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] arguments = input.Split("-");
                string command = arguments[0];
                string guest = arguments[1];
                string meal = arguments[2];
                if (command == "Like")
                {
                    if (!Guests.ContainsKey(guest))
                    {
                        Guests.Add(guest, new List<string>());
                        Guests[guest].Add(meal);
                        
                    }
                    if (!Guests[guest].Contains(meal))
                    {
                        Guests[guest].Add(meal);
                    }
                }
                else if (command == "Dislike")
                {
                    if (!Guests.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                        
                    }
                    else if (!Guests[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                    else 
                    {
                        Guests[guest].Remove(meal);
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                        unlikedMeals++;
                    }
                } 
            }
            foreach (var key in Guests)
            {
                Console.WriteLine($"{key.Key}: {string.Join(", ", key.Value)}");
            }
            Console.WriteLine($"Unliked meals: {unlikedMeals}");
        }
    }
}