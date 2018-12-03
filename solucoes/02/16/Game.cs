using System;

namespace _16
{
    public class Game
    {
        internal static int gamesPlayed;
        private int numberOfPlayers;


        internal void GameLoop()
        {
            Console.WriteLine($"Foram jogados {gamesPlayed} jogos com " +
                $"{numberOfPlayers} jogadores. ");
            Console.WriteLine("Sobreviventes:");
        

        }
    }
}
