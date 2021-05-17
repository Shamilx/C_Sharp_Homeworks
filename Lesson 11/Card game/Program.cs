using System;
using System.Collections.Generic;
using source;

namespace Card_game
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Check readme.md before starting

            List<Player> players = new();

            players.Add(new Player("Adam"));
            players.Add(new Player("Adam2"));
            players.Add(new Player("Adam3"));

            Game obj2 = new(players);
            obj2.StartGame();
        }
    }
}
