namespace _16
{
    // Classe que cria um mapa de masmorras e indica o número de masmorras que 
    // cria.
    public class DungeonMap : Map
    {
        // Propriedade que indica o número de masmorras
        public int NumberOfDungeons { get; }

        // Constructor da classe que inicia com x número de masmorras
        public DungeonMap(int dungeonNumber) : base()
        {
            NumberOfDungeons = dungeonNumber;
        }

    }
}
