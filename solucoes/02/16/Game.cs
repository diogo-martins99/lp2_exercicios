using System;
using System.Collections.Generic;

namespace _16
{
    public class Game
    {
        internal static int gamesPlayed;
        private int numberOfPlayers;
        Map map;

        public Game(params string[] Name)
        {
            Random random = new Random();

            random.Next(0, 1);
            if (random.Next() == 1)
            {
                map = new DungeonMap(1);
            }
            else
            {
                map = new OpenWorldMap(40, 40);
            }
            
           map.AddPlayer(Name);

        }

        internal void GameLoop()
        {
            map.PrintPlayerNames();

        }
    }
}