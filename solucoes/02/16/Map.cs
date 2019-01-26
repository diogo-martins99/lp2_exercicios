using System;
using System.Collections.Generic;

namespace _16
{
    // Classe que indica o nome do mapa e que jogadores fazem parte do mesmo.
    public abstract class Map
    {
        public string Name { get; set; }
        protected string Filename { get; }
        private List<Player> players;

        public Map()
        {
            players = new List<Player>();
        }

        // Método que imprime o nome de cada jogador
        public void PrintPlayerNames()
        {
            foreach (Player player in players)
                player.PrintPlayerName();
            Console.WriteLine("Jogado no mapa = " + Name);
        }

        // Método que adiciona um jogador ao jogo
        public void AddPlayer(int num, string playerName)
        {
            players.Add(new Player(num, playerName));
        }
    }
}