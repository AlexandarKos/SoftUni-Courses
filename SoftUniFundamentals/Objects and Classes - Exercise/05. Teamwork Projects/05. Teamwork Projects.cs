using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                List<string> teamsInfo = Console.ReadLine().Split("-").ToList();
                string creator = teamsInfo[0];
                string teamName = teamsInfo[1];

                if (teams.Any(team => team.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team(teamName, creator);
                    teams.Add(team);
                    team.Members = new List<string>();
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            List<string> membersJoinInfo = Console.ReadLine().Split("->").ToList();

            while (membersJoinInfo[0] != "end of assignment")
            {
                string member = membersJoinInfo[0];
                string teamNameToJoin = membersJoinInfo[1];

                if (!teams.Any(team => team.TeamName == teamNameToJoin))
                {
                    Console.WriteLine($"Team {teamNameToJoin} does not exist!");
                }
                else if (teams.Any(team => team.Members.Contains(member)) || teams.Any(team => team.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamNameToJoin}!");
                }
                else
                {
                    var teamToFind = teams.Find(team => team.TeamName == teamNameToJoin);

                    teamToFind.Members.Add(member);
                }
                membersJoinInfo = Console.ReadLine().Split("->").ToList();
            }

            List<Team> validTeams = teams.Where(team => team.Members.Count > 0).ToList();
            List<Team> disbandedTeams = teams.Where(team => team.Members.Count == 0).ToList();

            validTeams = validTeams.OrderByDescending(team => team.Members.Count).ThenBy(team => team.TeamName).ToList();

            foreach (var team in validTeams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            if (disbandedTeams != null)
            {
                foreach (var team in disbandedTeams.OrderBy(x => x.TeamName))
                {
                    Console.WriteLine($"{team.TeamName}");
                }
            }
        }
    }

    class Team
    {
        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
        }

        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

    }
}