/*
Crie um programa onde 4 jogadores joguem um dado e tenham resultados aleatórios,
guarde esses resultados em um dicionário. No final, coloque esse dicionário em ordem, sabendo que o vencedor
tirou o maior número no dado
*/

namespace Exercicios.Ex102;

public class Program
{
    public static void Main(string[] args)
    {
        Random random = new();
        var dadosJogadores = new Dictionary<string, int>(){
            {"jogador1",random.Next(1,101)},
            {"jogador2",random.Next(1,101)},
            {"jogador3",random.Next(1,101)},
            {"jogador4",random.Next(1,101)},
        };
        foreach (var item in dadosJogadores)
        {
            Console.WriteLine($"{item.Key} tirou {item.Value} no dado");
        }
        Console.WriteLine(string.Concat(Enumerable.Repeat("-=", 20)));
        Console.WriteLine("== RANKING DOS JOGADORES ==");
        // ordenar o dicionário do maior para o menor
        // usando select com (item,index) funcionando como um enumerate do python
        var ranking = dadosJogadores
        .OrderByDescending(jog => jog.Value)
        .Select((jog, index) => new
        {
            Posicao = index + 1,
            Nome = jog.Key,
            Score = jog.Value,
        });

        foreach (var colocado in ranking)
        {
            Console.WriteLine($"{colocado.Posicao}° lugar: {colocado.Nome} com {colocado.Score}");
        }
    }
}