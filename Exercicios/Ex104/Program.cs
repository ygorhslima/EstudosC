namespace Exercicios.Ex104;

public class Program
{
    public static void Main(string[] args)
    {
        var jogador = new Dictionary<string, object>();
        var gols = new List<int>();
        int contGols = 0;

        Console.Write("Nome do jogador: ");
        jogador["nome"] = Console.ReadLine() ?? "";

        Console.Write($"Quantas partidas {jogador["nome"]} jogou: ");
        int quantPartidas = int.Parse(Console.ReadLine() ?? "");
        for (int i = 0; i < quantPartidas; i++)
        {
            Console.Write($"Quantos gols na partida {i}? ");
            int gol = int.Parse(Console.ReadLine() ?? "");
            contGols += gol;
            gols.Add(gol);
        }


        jogador["gols"] = gols;
        jogador["total"] = contGols;

        Console.Write("{");
        foreach (var item in jogador)
        {
            if (item.Value is List<int> listaDeGols)
            {
                Console.Write($"'{item.Key}': [{string.Join(", ", listaDeGols)}],");
            }
            else
            {
                Console.Write($"'{item.Key}': '{item.Value},");
            }
        }
        Console.WriteLine("}");

        foreach (var item in jogador)
        {
            if (item.Value is List<int> listaDeGols)
            {
                Console.WriteLine($"O campo {item.Key} tem o valor [{string.Join(", ", listaDeGols)}]");
            }
            else
            {
                Console.WriteLine($"O Campo {item.Key} tem o valor {item.Value}");
            }
        }

        Console.WriteLine($"O jogador {jogador["nome"]} jogou 5 partidas");
        for (int i = 0; i < gols.Count; i++)
        {
            Console.WriteLine($"=> Na partida {i}, fez {gols[i]} gols");
        }
    }
}