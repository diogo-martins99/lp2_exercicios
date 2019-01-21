using System;

namespace _16
{
    // Classe responsavél por criar o "jogo"
    public class Game
    {
        internal static int gamesPlayed;
        private int numberOfPlayers = 0;
        public Map map;

        // Constructor da classe que cria um jogo
        public Game(int numberOfPlayers, params string[] Name)
        {
            Random random = new Random();

            // efectua um random do mapa que irá ser criado
            if (random.Next(0, 10) < 5)
            {
                // Cria o mapa da masmorra e da o nome ao mesmo
                map = new DungeonMap(1);
                map.Name = "Caverna do Adeus";
            }
            else
            {
                // Cria o mundo aberto e o nome
                map = new OpenWorldMap(40, 40);
                map.Name = "Exodus";
            }
            for (int i = 0; i < numberOfPlayers; i++)
                map.AddPlayer(i, Name[0+i]);

        }

        // Método que efectua o ciclo de jogo
        internal void GameLoop()
        {
            map.PrintPlayerNames();
        }
    }
}