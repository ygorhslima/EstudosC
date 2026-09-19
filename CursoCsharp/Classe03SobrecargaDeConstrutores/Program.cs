public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador()
    {
        nome="josé";
        energia=200;
        vivo=true;
    }
    public Jogador(string nome)
    {
        this.nome = nome;
    }

    public Jogador(string nome, int energia)
    {
        this.nome = nome;
        this.energia = energia;
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

public class Program
{
    public static void Main(string[] args)
    {
       Jogador j1 = new Jogador();
       Console.WriteLine(j1.Info());
    }
}