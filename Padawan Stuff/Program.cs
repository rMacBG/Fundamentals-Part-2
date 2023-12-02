namespace Padawan_Stuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalPriceSabers = lightsaberPrice * Math.Ceiling(studentsCount * 1.1);
            double totalPriceRobes = robePrice * studentsCount;
            double freeBelts = studentsCount / 6;
            double totalPriceBelts = beltPrice * (studentsCount - freeBelts);

            double neededMoney = totalPriceSabers + totalPriceRobes + totalPriceBelts;

            if (neededMoney <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {neededMoney - budget:F2}lv more.");
            }
        }
    }
}