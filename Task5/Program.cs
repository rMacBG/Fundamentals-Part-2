namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = new List<Town>();
            string line;
            while ((line = Console.ReadLine()) != "Sail")
            {
                string[] tokens = line.Split("||");
                string townName = tokens[0];
                int population = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);

                Town town = towns.FirstOrDefault(x => x.Name == townName);
                if (town is not null)
                {
                    town.Population += population;
                    town.Gold += gold;
                    continue;
                }

                towns.Add(new Town
                {
                    Name = townName,
                    Population = population,
                    Gold = gold

                });
            }

            line = string.Empty;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] tokens = line.Split("=>");
                string command = tokens[0];
                string townName = tokens[1];
                Town town = towns.FirstOrDefault(x => x.Name == townName);
                if (command == "Plunder")
                {
                    int people = int.Parse(tokens[2]);
                    int gold = int.Parse(tokens[3]);
                    town.Population -= people;
                    town.Gold -= gold;
                    Console.WriteLine($"{town.Name} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (town.Population <= 0 || town.Gold <= 0)
                    {
                        Console.WriteLine($"{town.Name} has been wiped off the map!");
                        towns.Remove(town);
                    }
                }
                else//Prosper
                {
                    int gold = int.Parse(tokens[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }

                    town.Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {town.Name} now has {town.Gold} gold.");
                }
            }

            if (towns.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
                return;
            }

            Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
            foreach (Town town in towns)
            {
                Console.WriteLine($"{town.Name} -> Population: {town.Population} citizens, Gold: {town.Gold} kg");
            }
        }

    }
    public class Town
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}