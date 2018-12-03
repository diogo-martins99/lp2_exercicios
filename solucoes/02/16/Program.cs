
using System.Collections.Generic;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Game game1 = new Game();

            Player player = new Player(1, "Joaquim");
            Player player2 = new Player(2, "Joana");
            Player player3 = new Player(3, "Martim");
            Player player4 = new Player(4, "Paulo");

            game.GameLoop();


        }
    }
}
