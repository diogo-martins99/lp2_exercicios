using System;

namespace _16
{
    public class Game
    {
        internal static int gamesPlayed;
        private int numberOfPlayers;

        Map map = new Map();

        internal void GameLoop()
        {
            Console.WriteLine($"Foram jogados {gamesPlayed = 3} jogos com " +
                $"{numberOfPlayers = 4} jogadores, os seus nomes são: ");
            map.PrintPlayerNames();

        }
    }
}
