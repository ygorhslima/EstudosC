public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(string nome)
    {
        energia = 100;
        vivo = true;
        this.nome = nome;
    }
    ~Jogador()
    {
        Console.WriteLine($"jogador {nome} foi destruido");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o nome do seu jogador: ");
        string player1 = Console.ReadLine() ?? "";
        var j1 = new Jogador(player1);
        var j2 = new Jogador("Scorpion");
        var j3 = new Jogador("Zavok");

        Console.WriteLine($"Seu jogador: {j1.nome}");
    }
}