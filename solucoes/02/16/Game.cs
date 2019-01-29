using System;

namespace _16
{
    // Classe responsável por criar o "jogo"
    public class Game
    {
        internal static int gamesPlayed = 0;
        private readonly int numberOfPlayers;
        public Map map;

        // Constructor da classe que cria um jogo
        public Game(params string[] names)
        {
            Random random = new Random();

            // efectua um random do mapa que irá ser criado
            if (random.Next(0, 10) < 5)
            {
                // Cria o mapa da masmorra e da o nome ao mesmo
                map = new DungeonMap(1) {Name = "Caverna do Adeus"};
           
            }
            else
            {
                // Cria o mundo aberto e o nome
                map = new OpenWorldMap(40, 40) {Name = "Exodus" };

            }
            // Iguala o tamanho do array ao tamanho total dos jogadores
            numberOfPlayers = names.Length;
            //gamesPlayed++;
            for (int i = 0; i < numberOfPlayers; i++)
                map.AddPlayer(i, names[i]);
            
           
        }

        // Método que efectua o ciclo de jogo
        internal void GameLoop()
        {
            gamesPlayed++;
            map.PrintPlayerNames();
            Console.WriteLine("Foram jogados : " + gamesPlayed);
        }
    }
}