namespace Exercicios.Ex106;

public class Program
{
    static void Lin(string estiloLinha, int quantCaracteres)
    {
        Console.WriteLine(string.Concat(Enumerable.Repeat(estiloLinha, quantCaracteres)));
    }
    public static void Main(string[] args)
    {
        var ListaDados = new List<Dictionary<string, object>>();
        string resposta = "S";

        while (resposta == "S".ToUpper())
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
            ListaDados.Add(jogador);

            while (true)
            {
                Console.Write("Quer continuar [S/N]: ");
                resposta = (Console.ReadLine() ?? "").ToUpper();
                if (resposta == "S" || resposta == "N")
                {
                    break;
                }
                Console.WriteLine("ERRO! Por favor, digite apenas S ou N.");
            }
        }


        Lin("-=", 34);
        Console.WriteLine("cod   nome       gols        total");
        Lin("-", 34);
        for (int i = 0; i < ListaDados.Count; i++)
        {
            var golsJogador = (List<int>)ListaDados[i]["gols"];
            string golsFormatado = $"[{string.Join(", ", golsJogador)}]";
            Console.WriteLine($"{i}   {ListaDados[i]["nome"]}       {golsFormatado}        {ListaDados[i]["total"]}");
        }
        Lin("-", 34);

        while (true)
        {
            Console.WriteLine("Mostrar dados de qual jogador? (999 para parar): ");
            int cod = int.Parse(Console.ReadLine() ?? "");
            if(cod == 999)
            {
                break;
            }
            if(cod >= 0 && cod < ListaDados.Count)
            {
                Console.WriteLine($"-- LEVANTAMENTO DO JOGADOR {ListaDados[cod]["nome"]}");
                var golsSelecionados = (List<int>) ListaDados[cod]["gols"];
                for (int i = 0; i < golsSelecionados.Count; i++)
                {
                    Console.WriteLine($"    No jogo {i} fez {golsSelecionados[i]}");
                }
            }
        }
    
        Console.WriteLine("<<< programa encerrado >>>");
    }
}