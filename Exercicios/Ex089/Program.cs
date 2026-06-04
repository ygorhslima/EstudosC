namespace Exercicios.Ex089;

public class Program
{
    public static void Main(string[] args)
    {
        const int MAX = 4;
        int[] vetor = new int[MAX];
        int quantVezes9 = 0;
        int i;
        for (i = 0; i < MAX; i++)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine() ?? "");
            vetor[i] = numero;
            if(vetor[i] == 9)
            {
                quantVezes9++;
            }
        }
        Console.WriteLine("Você digitou os valores: ");
        for (i = 0; i < MAX; i++)
        {
            Console.WriteLine(vetor[i]);
        }
        Console.WriteLine();

        Console.WriteLine($"O valor 9 apareceu {quantVezes9} vezes");
        for ( i = 0; i < MAX; i++)
        {
            if(vetor[i] == 3)
            {
                Console.WriteLine($"O valor {vetor[i]} apareceu na {i+1} posição");
            }
        }
    }
}