using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQGameList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and populate the list
            List<string> games = new List<string>()
            {
                "Halo",
                "The Legend of Zelda",
                "Minecraft",
                "Call of Duty",
                "Among Us",
                "Super Mario Bros",
                "Portal",
                "Elden Ring"
            };

            // Order the games by the length of their names using LINQ method syntax
            var orderedGames = games.OrderBy(game => game.Length).ToList();

            // Display the sorted list
            Console.WriteLine("Games ordered by name length:");
            foreach (var game in orderedGames)
            {
                Console.WriteLine($"{game} ({game.Length} characters)");
            }
        }
    }
}