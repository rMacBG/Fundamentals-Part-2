using System.Text.RegularExpressions;

namespace Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> furnitures = new List<Furniture>();
            string pattern = @">>([A-Za-z]+)<<(\d+\.\d+|\d+)!(\d+)";
            Regex regex = new Regex(pattern);
            
            
            string command;
            while ((command = Console.ReadLine())!= "Purchase")
            {
                foreach (Match match in Regex.Matches(command, pattern))
                {
                    Furniture furniture = new Furniture();
                    furniture.Name = match.Groups[1].Value;
                    furniture.Price = decimal.Parse(match.Groups[2].Value);
                    furniture.Quantity = int.Parse(match.Groups[3].Value);

                    furnitures.Add(furniture);
                }
            }
            decimal totalCost = 0;
            Console.WriteLine("Bought furniture:");
            foreach (Furniture furniture in furnitures)
            {
                Console.WriteLine(furniture.Name);
                totalCost += furniture.Total();
            }
            Console.WriteLine($"Total money spend: {totalCost:f2}");
        }
    }

    class Furniture
    {
        private readonly string price;
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }


        public decimal Total()
        {
            return Price * Quantity;
        }
    }
}