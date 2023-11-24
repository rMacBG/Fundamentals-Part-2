namespace SoftuniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var users = new Dictionary<string, User>();

            for (int i = 0; i < count; i++)
            {
                string[] arguments = Console.ReadLine()
                    .Split();
                string command = arguments[0];
                string userName = arguments[1];


                switch (command)
                {
                    case "register":
                        string licensePlate = arguments[2];
                        User newUser = new User(userName, licensePlate);
                        if (users.ContainsKey(userName))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {newUser.LicensePlate}");
                        }
                        else
                        {
                            users.Add(newUser.UserName, newUser);
                            Console.WriteLine($"{userName} registered {licensePlate} successfully");
                        }
                        break;
                    case "unregister":

                        if (users.ContainsKey(userName))
                        {
                            users.Remove(userName);
                            Console.WriteLine($"{userName} unregistered successfully");   
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        break;
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine(user.Value);
            }
        }
    }

    internal class User
    {
        public User(string userName, string licensePlate)
        {
            UserName = userName;
            LicensePlate = licensePlate;
        }

        public string UserName { get; set; }
        public string LicensePlate { get; set; }


        public override string ToString()
        {
            return $"{UserName} => {LicensePlate}";
        }
    }
}