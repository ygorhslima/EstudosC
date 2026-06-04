namespace Exercicios.Ex088;

public class Program
{
    public static void Main(string[] args)
    {
        int i;
        const int MAX = 5;
        int[] vetor_numeros_aleatorios = new int[MAX];
        int maiorValor = 0;
        int menorValor = 0;
        
        Random computador = new();
        Console.WriteLine("Os valores sorteados foram: ");
        for (i = 0; i < MAX; i++)
        {
            vetor_numeros_aleatorios[i] = computador.Next(1, 100);
            if (i == 0)
            {
                maiorValor = vetor_numeros_aleatorios[i];
                menorValor = vetor_numeros_aleatorios[i];
            }
            if (vetor_numeros_aleatorios[i] > maiorValor)
            {
                maiorValor = vetor_numeros_aleatorios[i];
            }
            if (vetor_numeros_aleatorios[i] < menorValor)
            {
                menorValor = vetor_numeros_aleatorios[i];
            }

            Console.WriteLine(vetor_numeros_aleatorios[i]);
        }
        Console.WriteLine();
        Console.WriteLine($"O maior valor sorteado foi: {maiorValor}");
        Console.WriteLine($"O menor valor sorteado foi: {menorValor}");
    }
}