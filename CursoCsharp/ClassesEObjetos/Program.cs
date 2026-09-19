public class Jogador
{
    public int energia = 100;
    public bool vivo = true;
}

public class Program
{
    public static void Main(string[] args)
    {
        var j1 = new Jogador();
        var j2 = new Jogador();
        var j3 = new Jogador();

        j1.energia = 50;

        foreach (var obj in new[] {j1,j2,j3})
        {
            Console.WriteLine($"Energia do jogador: {obj.energia}");
        }
    }
}