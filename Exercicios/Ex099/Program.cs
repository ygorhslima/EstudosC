/*
Faça um programa que ajude um jogador da MEGA SENA a criar
palpites, o programa vai perguntar quantos jogos serão gerados e vai sortear 6 números entre 1 a 60 para cada jogo, cadastrando tudo em uma lista composta
*/
namespace Exercicios.Ex099;
public class Program
{
    static void Lin()
    {
        Console.WriteLine(string.Concat(Enumerable.Repeat("=", 20)));
    }
    public static void Main(string[] args)
    {
        Lin();
        Console.WriteLine("JOGA NA MEGA SENA");
        Lin();
        Console.WriteLine("Quantos jogos você quer que eu sorteie: ");
        int quantidadeJogos = int.Parse(Console.ReadLine() ?? "");
        List<List<int>> todosOsJogos = [];
        int i;
        for (i = 0; i < quantidadeJogos; i++)
        {
            List<int> jogoAtual = [];
            while(jogoAtual.Count < 6)
            {
                int numeroSorteado = Random.Shared.Next(0,61);
                if (!jogoAtual.Contains(numeroSorteado))
                {
                    jogoAtual.Add(numeroSorteado);
                }
            }
            jogoAtual.Sort();
            todosOsJogos.Add(jogoAtual);

        }
        Lin();
        Console.WriteLine($"--- SORTEANDO {quantidadeJogos} JOGOS ---");
        Lin();
        for (i = 0; i < todosOsJogos.Count; i++)
        {
            List<int> jogo = todosOsJogos[i];
            Console.WriteLine($"Jogo {i + 1}: [ {string.Join(", ", jogo)} ]");
        }
        
        Lin();
        Console.WriteLine("Boa sorte!");
    }
}