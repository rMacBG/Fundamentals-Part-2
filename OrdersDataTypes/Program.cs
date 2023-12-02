namespace OrdersDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int i = 0; i < orders; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                double cost = ((days * capsuleCount) * capsulePrice);
                Console.WriteLine($"The price for the coffee is: ${cost:f2}");
                totalPrice += cost;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}