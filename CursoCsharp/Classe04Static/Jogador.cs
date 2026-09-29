namespace Classe04Static
{
    public class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;

        public Jogador()
        {
            nome = "josé";
            energia = 200;
            vivo = true;
        }

        public string Info()
        {
            return $"""
            Nome: {nome}
            Energia: {energia}
            está vivo?: {vivo}
            """;
        }
    }
}