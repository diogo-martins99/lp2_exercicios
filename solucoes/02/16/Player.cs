using System;

namespace _16
{
    class Player
    { 
 
        public int ID { get; }
        public string Name { get; }
        private double health;
        private double shield;


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
