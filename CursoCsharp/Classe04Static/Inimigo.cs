namespace Classe04Static
{
    public class Inimigo
    {
        static public bool alerta;
        public string nome;
        public Inimigo(string n)
        {
            alerta=false;
            nome=n;
        }
        public string Info()
        {
            return $"""
            Nome: {nome}
            """;
        }
    }
}