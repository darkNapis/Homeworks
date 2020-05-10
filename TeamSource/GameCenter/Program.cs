using System;
using TeamSource.Helpers;
using TeamSource.Enteties;
using System.Linq;
using System.Collections.Generic;

namespace GameCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = TeamsDataBase.GetAllTeams();

            // Find all Teams with names starting with LA

            var findAllTeamsWithNamesStartingWithLA = teams
                .Where(team => team.Name.StartsWith("LA")).ToList();

            findAllTeamsWithNamesStartingWithLA.ForEach(team => Console.WriteLine(team.Name));



            // Find all team Names which are playing in "Staples Center"

            var findAllTeamNamesWhichPlayInStaplesCenter = teams
                .Where(team => team.Arena.Equals("Staples Center"))
                .Select(team => team.Name).ToList();

            findAllTeamNamesWhichPlayInStaplesCenter.ForEach(team => Console.WriteLine(team));



            // Find all teams coaches

            var allCoaches = teams.Select(team => team.Coach).ToList();

            allCoaches.ForEach(coach => Console.WriteLine(coach.FullName));

            
            
            // Find 3 oldest coaches names

            var oldest3CoachesNames = allCoaches.OrderByDescending(coach => coach.Age)
                                .Take(3)
                                .Select(coach => coach.FullName)
                                .ToList();

            oldest3CoachesNames.ForEach(trainerName => Console.WriteLine(trainerName));



            // Group all teams by their arenas

            var groupedTeamsByArenas = teams.GroupBy(team => team.Arena).ToList();

            foreach (var group in groupedTeamsByArenas)
            {
                Console.WriteLine($"{group.Key}");
                foreach (var team in group)
                {
                    Console.WriteLine($"----------{team.Name}");
                }
            }



            // Find all players in one list

            var allPlayers = new List<Player>();
            teams.ForEach(team => allPlayers.AddRange(team.Players));

            allPlayers.ForEach(player => Console.WriteLine(player.FullName));



            // Find player with best avgPtsPerGame

            var playerWithMostPtsPerGame = allPlayers.OrderByDescending(player => player
            .PlayerStatistic["PtsPerGame"]).FirstOrDefault();
            
            Console.WriteLine(playerWithMostPtsPerGame.FullName);

            
            
            // Find all coaches NAMES with Age > 50

            var allCoachesNamesWithAgesOver50 = allCoaches
                            .FindAll(coach => coach.Age > 50)
                            .Select(coach => coach.FullName)
                            .ToList();

            allCoachesNamesWithAgesOver50.ForEach(coach => Console.WriteLine(coach));


            
            // Order players by AGE - DESC

            var playersByAgeDesc = allPlayers.OrderByDescending(player => player.Age).ToList();

            playersByAgeDesc.ForEach(player => Console.WriteLine(player.FullName));


            
            // Find player with highest RebPerGame

            var playerWithHighestRebPerGame = allPlayers.OrderByDescending(player => player
                        .PlayerStatistic["RebPerGame"]).FirstOrDefault();

            Console.WriteLine(playerWithHighestRebPerGame.FullName);


            
            // Find all players with PtsPerGame > 20

            var allPlayersWithPtsPerGameOver20 = allPlayers.FindAll(player => player
                        .PlayerStatistic["PtsPerGame"] > 20)
                        .Select(player => player.FullName)
                        .ToList();

            allPlayersWithPtsPerGameOver20.ForEach(player => Console.WriteLine(player));


            
            // Find all players NAMES older then 30 years

            var allPlayersNamesOver30Years = allPlayers.FindAll(player => player.Age > 30).ToList();

            allPlayersNamesOver30Years.ForEach(player => Console.WriteLine(player.FullName));


            
            // Group players by age

            var groupPlayersByAge = allPlayers.GroupBy(player => player.Age).ToList();

            foreach (var group in groupPlayersByAge)
            {
                Console.WriteLine($"{group.Key}");
                foreach (var player in group)
                {
                    Console.WriteLine($"-------------{player.FullName}");
                }
            }


            
            // Find All players NAMES and PtsPerGame if have RebPerGame > 7.0

            var allPlayersNamesAndPtsPerGameIfRebPerGameOver7 = allPlayers
                        .FindAll(player => player.PlayerStatistic["RebPerGame"] > 7.0)
                        .ToList();

            foreach (var player in allPlayersNamesAndPtsPerGameIfRebPerGameOver7)
            {
                Console.WriteLine($"{player.FullName} ---" + $" {player.PlayerStatistic["PtsPerGame"]}");
            }



            // Find first 3 players with highest PtsPerGame

            var first3PlayersWithHighestPtsPerGame = allPlayers
                        .OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                        .Take(3).ToList();

            first3PlayersWithHighestPtsPerGame.ForEach(player => Console.WriteLine(player.FullName));



            // Find the team which has the player with highest PtsPerGame

            var teamWhichHavePlayerWithHighestPtsPerGame = teams
                        .Where(team => team.Players.Contains(playerWithMostPtsPerGame))
                        .Select(team => team.Name)
                        .ToList();

            teamWhichHavePlayerWithHighestPtsPerGame.ForEach(team => Console.WriteLine(team));



            // Find first 4 players with highest RebPerGame and order them by PtsPerGame - ASC

            var first4PlayersWithHighestRebPerGameAndOrderByPtsPerGameAsc = allPlayers
                .OrderByDescending(player => player.PlayerStatistic["RebPerGame"])
                .Take(4).OrderBy(player => player.PlayerStatistic["PtsPerGame"])
                .ToList();

            first4PlayersWithHighestRebPerGameAndOrderByPtsPerGameAsc.ForEach(player => Console.WriteLine(player.FullName));

            Console.ReadLine();
        }
    }
}
