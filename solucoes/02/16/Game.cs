using System;

namespace _16
{
    public class Game
    {
        internal static int gamesPlayed;
        private int numberOfPlayers;

        Random rand = new Random();
        Player player = new Player(1, "manel");

        internal void GameLoop()
        {
            gamesPlayed = rand.Next(15);
            numberOfPlayers = rand.Next(30);

            Console.WriteLine($"Foram jogados {gamesPlayed} jogos com " +
                $"{numberOfPlayers} jogadores. ");
            Console.WriteLine("Sobreviventes:");
            player.PrintPlayerNames();

        }
    }
}
