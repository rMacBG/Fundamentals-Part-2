namespace MinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Resources = new Dictionary<string, uint>();

            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {

                
                if (!Resources.ContainsKey(resource))
                {
                    Resources.Add(resource, 0);
                }
                var quantity = uint.Parse(Console.ReadLine());
                Resources[resource] += quantity;
                
            }

            foreach (var item in Resources)
            {
                string res = item.Key;
                uint qty = item.Value;
                Console.WriteLine($"{res} -> {qty}");
            }
        }
    }
}