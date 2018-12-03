using System;

namespace _16
{
    class Player

    {
        Map map = new Map();
 
        public int ID { get; set; }
        public string Name { get; set; }
        private double health;
        private double shield;


        public Player(int id, string name)
        {
            this.ID = ID;
            Name = name;
            health = 100;
            shield = 0;
        }

        public void PrintPlayerNames()
        {
            map.PrintPlayerNames();

        }

    }
}
