using System;

namespace _16
{
    // Classe que cria ojogador
    public class Player
    {
        // Propriedades que indicam o ID, nome, vida e escudo do jogador
        public int ID { get; }
        public string Name { get; }
        private double health;
        private double shield;

        // Constructor que cria o jogadaor com status base
        public Player(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
            health = 100;
            shield = 0;
        }

        // Método que imprime o nome do jogador
        public void PrintPlayerName()
        {
            Console.WriteLine("Jogador = " + Name);
        }
    }
}
