using System.Data;

namespace TeamworkProjects
{
    public class Team
    {
        public Team(string teamName, string creator)
        {
            this.TeamName = teamName;
            this.Creator = creator;
            Members = new List<string>();

        }
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        private string GetMembersString()
        {
            Members = Members
                .OrderBy(n => n)
                .ToList();
            string result = string.Empty;

            for (int i = 0; i < Members.Count - 1; i++)
            {
                result += $"-- {Members[i]}\n";
            }
            result += $"-- {Members[Members.Count-1]}";
            return result;
        }
        public override string ToString()
        {
            return $"{TeamName}\n" + $"- {Creator}\n" + $"{GetMembersString()}";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < counter; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split("-")
                    .ToArray();
                string teamName = commands[1];
                string creatorName = commands[0];
                Team team = new Team(teamName, creatorName);
                Team sameTeam = teams.Find(n => n.TeamName == team.TeamName);
                Team sameCreator = teams.Find(n => n.Creator == team.Creator);
                if (sameTeam != null)
                {
                    Console.WriteLine($"Team {team.TeamName} was already created!");
                    continue;
                }

                if (sameCreator != null)
                {
                    Console.WriteLine($"{team.Creator} cannot create another team!");
                    continue;
                }
                teams.Add(team);
                Console.WriteLine($"Team {team.TeamName} has been created by {team.Creator}!");
            }

            string input = Console.ReadLine();
            while (input == "end of assignment!")
            {
                string[] arguments = input
                    .Split("->");
                string joinName = arguments[0];
                string teamName = arguments[1];

                bool teamExists = teams.Any(n => n.TeamName == teamName);

                if (!teamExists)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(n => n.Creator == joinName) ||
                    teams.Any(n => n.Members.Contains(joinName)))
                {
                    Console.WriteLine($"Member {joinName} cannot join team {teamName}!");
                }

                teams.FirstOrDefault(t => t.TeamName == teamName).Members.Add(joinName);
                //Team team = teams.FirstOrDefault(t => t.TeamName == teamName);
                //if (team != null)
                //{
                //    team.Members.Add(joinName);
                //}
            }
            List<Team> leftTeams = teams.Where(t => t.Members.Count > 0).ToList();
            List<Team> disbandedTeams = teams.Where(t => t.Members.Count <= 0).ToList();
            List<Team> orderedTeams = leftTeams
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.TeamName)
                .ToList();

            orderedTeams.ForEach(t => Console.WriteLine(t));
            Console.WriteLine("Teams to disband:");
            disbandedTeams = disbandedTeams.OrderBy(t => t.TeamName).ToList();
            disbandedTeams.ForEach(t => Console.WriteLine(t));
        }
    }
}