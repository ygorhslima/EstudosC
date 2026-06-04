namespace Exercicios.Ex084;

public class Program
{
    static void Lin()
    {
        Console.WriteLine(string.Concat(Enumerable.Repeat("=", 20)));
    }
    public static void Main(string[] args)
    {
        const int MAX = 9;
        int i;
        string nome;
        int idade;
        string[] vetor_nome = new string[MAX];
        int[] vetor_idade = new int[MAX];

        for (i = 0; i < MAX; i++)
        {
            Console.Write("Digite um nome: ");
            nome = Console.ReadLine() ?? "";

            Console.Write("Digite um idade: ");
            idade = int.Parse(Console.ReadLine() ?? "");

            vetor_nome[i] = nome;
            vetor_idade[i] = idade;
        }

        Lin();
        Console.WriteLine("Dados: ");
        for (i = 0; i < MAX; i++)
        {
            Console.WriteLine($"-> {vetor_nome[i]}, {vetor_idade[i]}");
        }
        Lin();

        Lin();
        Console.WriteLine("Pessoas Menores de idade: ");
        for (i = 0; i < MAX; i++)
        {
            if (vetor_idade[i] < 18)
            {
                Console.WriteLine($"Nome: {vetor_nome[i]} - idade: {vetor_idade[i]}");
            }
        }
        Lin();
    }
}