namespace _16

{
    // Classe que indica o tamanho de um mapa aberto
    public class OpenWorldMap : Map
    {
        // Propriedades da classe, altura e largura
        public float Width { get; }
        public float Height { get; }

        // Constructor da classe OpenWorldMap
        public OpenWorldMap(float width, float height) : base()
        {
            Width = width;
            Height = height;

        }

    }
}
