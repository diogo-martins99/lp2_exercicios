using System;
using System.Collections.Generic;

namespace _16
{
    public class Map
    {
        public string Name { get; }
        protected string Filename { get; }
        List<Player> players; 

        public Map()
        {
            players = new List<Player>();
            players.Add(new Player(1, "Manel"));
            players.Add(new Player(2, "Rita"));
            players.Add(new Player(3, "Sara"));
            players.Add(new Player(4, "Joaquim"));

        }

        public void PrintPlayerNames()
        {

            foreach (Player player in players)
                player.PrintPlayerName();
        }


    }
}
