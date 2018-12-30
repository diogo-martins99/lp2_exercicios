using System;
using System.Collections.Generic;

namespace _16
{
    public abstract class Map
    {
        public string Name { get; }
        protected string Filename { get; }
        private List<Player> players;

        public Map()
        {

        }

        public void PrintPlayerNames()
        {
            foreach (Player player in players)
                player.PrintPlayerName();
        }

        public void AddPlayer(string playerName)
        {
                players.Add(new Player(1, playerName));
        }
    }
}