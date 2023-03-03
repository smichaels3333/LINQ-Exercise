using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "Halo Infinite", "Call of Duty", "Forza Horizon", "Hogwarts Legacy"};
            var gameLength = videoGames.OrderBy(game=> game.Length);
            Console.WriteLine(gameLength);
        }
    }
}
