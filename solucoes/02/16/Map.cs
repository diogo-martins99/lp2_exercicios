using System;
using System.Collections.Generic;

namespace _16
{
    public class Map
    {
        public string Name { get; set; }
        protected string Filename { get; set; }

     //   Player player = new Player(1, "joaquim");

        public Map(string Name, string Filename)
        {
            this.Name = Name;
            this.Filename = Filename;
        }

        public void PrintPlayerNames()
        {

            foreach (Player player in players)
                Console.WriteLine(player.Name);
        }


    }
}
