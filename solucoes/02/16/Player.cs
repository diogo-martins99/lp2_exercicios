using System;

namespace _16
{
    public class Player
    {

        public int ID { get; }
        public string Name { get; }
        private readonly double health;
        private readonly double shield;

        public Player(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
            health = 100;
            shield = 0;
        }

        public void PrintPlayerName()
        {
            Console.WriteLine(this.Name);
        }
    }
}
